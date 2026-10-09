using System.ComponentModel;
using System.Globalization;

namespace b5
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            if (LicenseManager.UsageMode != LicenseUsageMode.Designtime)
                WireDashboardBehavior();
        }

        private void WireDashboardBehavior()
        {
            itemGrid.CellValueChanged += ItemGrid_CellValueChanged;
            itemGrid.CurrentCellDirtyStateChanged += (_, _) =>
            {
                if (itemGrid.IsCurrentCellDirty)
                    itemGrid.CommitEdit(DataGridViewDataErrorContexts.Commit);
            };
            itemGrid.CellValidating += ItemGrid_CellValidating;
            itemGrid.CellEndEdit += (_, e) =>
            {
                if (e.RowIndex >= 0 && e.ColumnIndex >= 0)
                    UpdateCellValidation(itemGrid.Rows[e.RowIndex].Cells[e.ColumnIndex]);
                UpdateTotals();
            };
            itemGrid.RowsRemoved += (_, _) => UpdateTotals();
            itemGrid.DataError += (_, e) => e.ThrowException = false;
            KeyDown += Form1_KeyDown;

            clockTimer.Tick += (_, _) => UpdateClock();
            UpdateClock();
            UpdateTotals();
            clockTimer.Start();
        }

        private void ItemGrid_CellValueChanged(object? sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0 || e.ColumnIndex < 0 || itemGrid.Rows[e.RowIndex].IsNewRow)
                return;

            var row = itemGrid.Rows[e.RowIndex];
            if (e.ColumnIndex == itemGrid.Columns["Quantity"].Index || e.ColumnIndex == itemGrid.Columns["Weight"].Index)
                UpdateCellValidation(row.Cells[e.ColumnIndex]);

            UpdateLineTotal(row);
            UpdateTotals();
        }

        private void ItemGrid_CellValidating(object? sender, DataGridViewCellValidatingEventArgs e)
        {
            if (e.RowIndex < 0 || e.ColumnIndex < 0 || itemGrid.Rows[e.RowIndex].IsNewRow)
                return;

            var columnName = itemGrid.Columns[e.ColumnIndex].Name;
            if (columnName is "Quantity" or "Weight")
            {
                var cell = itemGrid.Rows[e.RowIndex].Cells[e.ColumnIndex];
                var value = e.FormattedValue?.ToString();
                SetValidationError(cell, value, columnName == "Quantity" ? "Số lượng" : "Trọng lượng");
            }
        }

        private void UpdateCellValidation(DataGridViewCell cell)
        {
            var name = itemGrid.Columns[cell.ColumnIndex].Name;
            if (name is "Quantity" or "Weight")
                SetValidationError(cell, cell.Value?.ToString(), name == "Quantity" ? "Số lượng" : "Trọng lượng");
        }

        private void SetValidationError(DataGridViewCell cell, string? value, string label)
        {
            var hasValue = !string.IsNullOrWhiteSpace(value);
            var valid = !hasValue || (TryParseDecimal(value, out var number) && number > 0);
            cell.ErrorText = valid ? string.Empty : $"{label} phải là số lớn hơn 0.";

            var hasErrors = itemGrid.Rows
                .Cast<DataGridViewRow>()
                .Where(row => !row.IsNewRow)
                .SelectMany(row => row.Cells.Cast<DataGridViewCell>())
                .Any(existingCell => !string.IsNullOrEmpty(existingCell.ErrorText));
            errorProvider.SetError(itemGrid, hasErrors ? "Kiểm tra các ô có biểu tượng cảnh báo màu đỏ." : string.Empty);
        }

        private void UpdateLineTotal(DataGridViewRow row)
        {
            var quantity = TryParseDecimal(row.Cells["Quantity"].Value?.ToString(), out var q) && q > 0 ? q : 0;
            var unitPrice = TryParseDecimal(row.Cells["UnitPrice"].Value?.ToString(), out var price) && price >= 0 ? price : 0;
            row.Cells["LineTotal"].Value = quantity > 0 && unitPrice > 0
                ? (quantity * unitPrice).ToString("N0", CultureInfo.GetCultureInfo("vi-VN"))
                : string.Empty;
        }

        private void UpdateTotals()
        {
            decimal totalQuantity = 0;
            decimal totalWeight = 0;
            decimal totalAmount = 0;

            foreach (DataGridViewRow row in itemGrid.Rows)
            {
                if (row.IsNewRow)
                    continue;

                var quantityValid = TryParseDecimal(row.Cells["Quantity"].Value?.ToString(), out var quantity) && quantity > 0;
                var weightValid = TryParseDecimal(row.Cells["Weight"].Value?.ToString(), out var weight) && weight > 0;
                var priceValid = TryParseDecimal(row.Cells["UnitPrice"].Value?.ToString(), out var price) && price >= 0;

                if (quantityValid)
                    totalQuantity += quantity;
                if (quantityValid && weightValid)
                    totalWeight += quantity * weight;
                if (quantityValid && priceValid)
                    totalAmount += quantity * price;
            }

            quantityStatus.Text = $"Total Qty: {totalQuantity:N0}";
            weightStatus.Text = $"Total Wt: {totalWeight:N2} kg";
            amountStatus.Text = $"Total Amt: {totalAmount.ToString("N2", CultureInfo.GetCultureInfo("en-US"))}";
        }

        private void UpdateClock() => clockStatus.Text = $"Time: {DateTime.Now:HH:mm:ss}";

        private void AddItemRow()
        {
            var rowIndex = itemGrid.Rows.Add();
            itemGrid.CurrentCell = itemGrid.Rows[rowIndex].Cells["ProductName"];
            itemGrid.BeginEdit(true);
        }

        private void DeleteSelectedRows()
        {
            foreach (DataGridViewRow row in itemGrid.SelectedRows.Cast<DataGridViewRow>().Where(row => !row.IsNewRow).OrderByDescending(row => row.Index).ToList())
                itemGrid.Rows.RemoveAt(row.Index);
            UpdateTotals();
        }

        private void Form1_KeyDown(object? sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F2)
            {
                AddItemRow();
                e.Handled = true;
                e.SuppressKeyPress = true;
            }
            else if (e.KeyCode == Keys.Delete && itemGrid.ContainsFocus)
            {
                DeleteSelectedRows();
                e.Handled = true;
                e.SuppressKeyPress = true;
            }
        }

        private static bool TryParseDecimal(string? value, out decimal number)
        {
            return decimal.TryParse(value, NumberStyles.Number, CultureInfo.CurrentCulture, out number)
                || decimal.TryParse(value, NumberStyles.Number, CultureInfo.InvariantCulture, out number);
        }

        private void customerNameLabel_Click(object sender, EventArgs e)
        {

        }
    }
}
