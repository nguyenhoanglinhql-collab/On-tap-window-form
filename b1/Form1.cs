namespace b1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void CalculateButton_Click(object? sender, EventArgs e)
        {
            if (!decimal.TryParse(servicePriceTextBox.Text, out var servicePrice) || servicePrice < 0)
            {
                ShowInputError("Vui lòng nhập đơn giá dịch vụ hợp lệ (lớn hơn hoặc bằng 0).", servicePriceTextBox);
                return;
            }

            if (!int.TryParse(customerCountTextBox.Text, out var customerCount) || customerCount <= 0)
            {
                ShowInputError("Vui lòng nhập số lượng khách là số nguyên lớn hơn 0.", customerCountTextBox);
                return;
            }

            if (!decimal.TryParse(discountTextBox.Text, out var discountPercent) || discountPercent is < 0 or > 100)
            {
                ShowInputError("Vui lòng nhập mức giảm giá từ 0 đến 100 (%).", discountTextBox);
                return;
            }

            var total = servicePrice * customerCount * (100 - discountPercent) / 100;
            totalAmountLabel.Text = $"{total:N2} ₫";
        }

        private void ShowInputError(string message, TextBox textBox)
        {
            MessageBox.Show(this, message, "Lỗi nhập liệu", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            textBox.Focus();
            textBox.SelectAll();
        }

        private void ClearButton_Click(object? sender, EventArgs e)
        {
            servicePriceTextBox.Clear();
            customerCountTextBox.Clear();
            discountTextBox.Text = "0";
            totalAmountLabel.Text = "—";
            servicePriceTextBox.Focus();
        }
    }
}
