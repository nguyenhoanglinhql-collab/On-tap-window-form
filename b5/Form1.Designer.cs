namespace b5
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;
        private TableLayoutPanel dashboardLayout = null!;
        private SplitContainer splitContainer = null!;
        private TabControl detailTabs = null!;
        private TabPage customerTab = null!;
        private TabPage shippingTab = null!;
        private Label customerNameLabel = null!;
        private Label addressLabel = null!;
        private Label phoneLabel = null!;
        private TextBox customerNameTextBox = null!;
        private TextBox addressTextBox = null!;
        private TextBox phoneTextBox = null!;
        private Label carrierLabel = null!;
        private Label paymentLabel = null!;
        private Label deliveryDateLabel = null!;
        private Label shippingFeeLabel = null!;
        private ComboBox carrierComboBox = null!;
        private ComboBox paymentComboBox = null!;
        private DateTimePicker deliveryDatePicker = null!;
        private NumericUpDown shippingFeeNumeric = null!;
        private DataGridView itemGrid = null!;
        private DataGridViewTextBoxColumn productNameColumn = null!;
        private DataGridViewTextBoxColumn quantityColumn = null!;
        private DataGridViewTextBoxColumn weightColumn = null!;
        private DataGridViewTextBoxColumn unitPriceColumn = null!;
        private DataGridViewTextBoxColumn amountColumn = null!;
        private StatusStrip dashboardStatusStrip = null!;
        private ToolStripStatusLabel clockStatus = null!;
        private ToolStripStatusLabel quantityStatus = null!;
        private ToolStripStatusLabel weightStatus = null!;
        private ToolStripStatusLabel amountStatus = null!;
        private ErrorProvider errorProvider = null!;
        private System.Windows.Forms.Timer clockTimer = null!;

        protected override void Dispose(bool disposing)
        {
            if (disposing && components != null)
                components.Dispose();
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            dashboardLayout = new TableLayoutPanel();
            splitContainer = new SplitContainer();
            detailTabs = new TabControl();
            customerTab = new TabPage();
            shippingTab = new TabPage();
            customerNameLabel = new Label();
            addressLabel = new Label();
            phoneLabel = new Label();
            customerNameTextBox = new TextBox();
            addressTextBox = new TextBox();
            phoneTextBox = new TextBox();
            carrierLabel = new Label();
            paymentLabel = new Label();
            deliveryDateLabel = new Label();
            shippingFeeLabel = new Label();
            carrierComboBox = new ComboBox();
            paymentComboBox = new ComboBox();
            deliveryDatePicker = new DateTimePicker();
            shippingFeeNumeric = new NumericUpDown();
            itemGrid = new DataGridView();
            productNameColumn = new DataGridViewTextBoxColumn();
            quantityColumn = new DataGridViewTextBoxColumn();
            weightColumn = new DataGridViewTextBoxColumn();
            unitPriceColumn = new DataGridViewTextBoxColumn();
            amountColumn = new DataGridViewTextBoxColumn();
            dashboardStatusStrip = new StatusStrip();
            clockStatus = new ToolStripStatusLabel();
            quantityStatus = new ToolStripStatusLabel();
            weightStatus = new ToolStripStatusLabel();
            amountStatus = new ToolStripStatusLabel();
            errorProvider = new ErrorProvider(components);
            clockTimer = new System.Windows.Forms.Timer(components);
            ((System.ComponentModel.ISupportInitialize)splitContainer).BeginInit();
            splitContainer.Panel1.SuspendLayout();
            splitContainer.Panel2.SuspendLayout();
            splitContainer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)shippingFeeNumeric).BeginInit();
            ((System.ComponentModel.ISupportInitialize)itemGrid).BeginInit();
            ((System.ComponentModel.ISupportInitialize)errorProvider).BeginInit();
            dashboardLayout.SuspendLayout();
            customerTab.SuspendLayout();
            shippingTab.SuspendLayout();
            SuspendLayout();

            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1240, 500);
            MinimumSize = new Size(900, 450);
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Delivery Order Dashboard";

            dashboardLayout.ColumnCount = 1;
            dashboardLayout.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            dashboardLayout.RowCount = 2;
            dashboardLayout.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            dashboardLayout.RowStyles.Add(new RowStyle(SizeType.Absolute, 28F));
            dashboardLayout.Dock = DockStyle.Fill;
            dashboardLayout.Padding = new Padding(4);
            dashboardLayout.Controls.Add(splitContainer, 0, 0);
            dashboardLayout.Controls.Add(dashboardStatusStrip, 0, 1);
            Controls.Add(dashboardLayout);

            splitContainer.Dock = DockStyle.Fill;
            splitContainer.Orientation = Orientation.Vertical;
            splitContainer.Size = new Size(1232, 464);
            splitContainer.SplitterDistance = 390;
            splitContainer.SplitterWidth = 6;
            splitContainer.Panel1MinSize = 250;
            splitContainer.Panel2MinSize = 450;
            splitContainer.Panel1.Controls.Add(detailTabs);
            splitContainer.Panel2.Controls.Add(itemGrid);

            detailTabs.Dock = DockStyle.Fill;
            detailTabs.Controls.Add(customerTab);
            detailTabs.Controls.Add(shippingTab);
            detailTabs.SelectedIndex = 0;

            customerTab.Text = "Customer";
            customerTab.UseVisualStyleBackColor = true;
            customerTab.Controls.Add(customerNameLabel);
            customerTab.Controls.Add(customerNameTextBox);
            customerTab.Controls.Add(addressLabel);
            customerTab.Controls.Add(addressTextBox);
            customerTab.Controls.Add(phoneLabel);
            customerTab.Controls.Add(phoneTextBox);

            customerNameLabel.AutoSize = true;
            customerNameLabel.Location = new Point(16, 14);
            customerNameLabel.Text = "Customer Name";
            customerNameTextBox.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            customerNameTextBox.Location = new Point(16, 39);
            customerNameTextBox.Size = new Size(220, 27);
            addressLabel.AutoSize = true;
            addressLabel.Location = new Point(16, 76);
            addressLabel.Text = "Address";
            addressTextBox.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            addressTextBox.Location = new Point(16, 101);
            addressTextBox.Multiline = true;
            addressTextBox.Size = new Size(220, 80);
            phoneLabel.AutoSize = true;
            phoneLabel.Location = new Point(16, 190);
            phoneLabel.Text = "Phone";
            phoneTextBox.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            phoneTextBox.Location = new Point(16, 215);
            phoneTextBox.Size = new Size(220, 27);

            shippingTab.Text = "Shipping";
            shippingTab.UseVisualStyleBackColor = true;
            shippingTab.Controls.Add(carrierLabel);
            shippingTab.Controls.Add(carrierComboBox);
            shippingTab.Controls.Add(paymentLabel);
            shippingTab.Controls.Add(paymentComboBox);
            shippingTab.Controls.Add(deliveryDateLabel);
            shippingTab.Controls.Add(deliveryDatePicker);
            shippingTab.Controls.Add(shippingFeeLabel);
            shippingTab.Controls.Add(shippingFeeNumeric);
            carrierLabel.AutoSize = true;
            carrierLabel.Location = new Point(16, 14);
            carrierLabel.Text = "Carrier";
            carrierComboBox.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            carrierComboBox.DropDownStyle = ComboBoxStyle.DropDownList;
            carrierComboBox.Items.AddRange(new object[] { "Standard delivery", "Express delivery", "Same-day delivery", "Store pickup" });
            carrierComboBox.Location = new Point(16, 39);
            carrierComboBox.Size = new Size(220, 28);
            carrierComboBox.SelectedIndex = 0;
            paymentLabel.AutoSize = true;
            paymentLabel.Location = new Point(16, 79);
            paymentLabel.Text = "Payment Method";
            paymentComboBox.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            paymentComboBox.DropDownStyle = ComboBoxStyle.DropDownList;
            paymentComboBox.Items.AddRange(new object[] { "Cash on delivery", "Bank transfer", "Paid" });
            paymentComboBox.Location = new Point(16, 104);
            paymentComboBox.Size = new Size(220, 28);
            paymentComboBox.SelectedIndex = 0;
            deliveryDateLabel.AutoSize = true;
            deliveryDateLabel.Location = new Point(16, 144);
            deliveryDateLabel.Text = "Delivery Date";
            deliveryDatePicker.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            deliveryDatePicker.Format = DateTimePickerFormat.Short;
            deliveryDatePicker.Location = new Point(16, 169);
            deliveryDatePicker.Size = new Size(220, 27);
            shippingFeeLabel.AutoSize = true;
            shippingFeeLabel.Location = new Point(16, 209);
            shippingFeeLabel.Text = "Shipping Fee";
            shippingFeeNumeric.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            shippingFeeNumeric.Maximum = 100000000;
            shippingFeeNumeric.Increment = 5000;
            shippingFeeNumeric.ThousandsSeparator = true;
            shippingFeeNumeric.Value = 30000;
            shippingFeeNumeric.Location = new Point(16, 234);
            shippingFeeNumeric.Size = new Size(220, 27);

            itemGrid.Dock = DockStyle.Fill;
            itemGrid.AllowUserToAddRows = true;
            itemGrid.AllowUserToDeleteRows = true;
            itemGrid.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            itemGrid.ColumnHeadersHeight = 32;
            itemGrid.Columns.AddRange(new DataGridViewColumn[]
            {
                productNameColumn,
                quantityColumn,
                weightColumn,
                unitPriceColumn,
                amountColumn
            });
            itemGrid.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            itemGrid.MultiSelect = true;
            itemGrid.RowHeadersWidth = 42;
            productNameColumn.HeaderText = "Item Name";
            productNameColumn.Name = "ProductName";
            productNameColumn.FillWeight = 140;
            quantityColumn.HeaderText = "Quantity";
            quantityColumn.Name = "Quantity";
            quantityColumn.FillWeight = 75;
            weightColumn.HeaderText = "Weight (kg)";
            weightColumn.Name = "Weight";
            weightColumn.FillWeight = 90;
            unitPriceColumn.HeaderText = "Unit Price";
            unitPriceColumn.Name = "UnitPrice";
            unitPriceColumn.FillWeight = 95;
            amountColumn.HeaderText = "Amount";
            amountColumn.Name = "LineTotal";
            amountColumn.ReadOnly = true;
            amountColumn.FillWeight = 100;

            dashboardStatusStrip.Dock = DockStyle.Fill;
            dashboardStatusStrip.SizingGrip = false;
            dashboardStatusStrip.Items.AddRange(new ToolStripItem[]
            {
                clockStatus,
                quantityStatus,
                weightStatus,
                amountStatus
            });
            clockStatus.Text = "Time: --:--:--";
            quantityStatus.Text = "Total Qty: 0";
            weightStatus.Text = "Total Wt: 0.00 kg";
            amountStatus.Text = "Total Amt: 0.00";

            errorProvider.BlinkStyle = ErrorBlinkStyle.NeverBlink;
            errorProvider.ContainerControl = this;
            clockTimer.Interval = 1000;

            ((System.ComponentModel.ISupportInitialize)splitContainer).EndInit();
            splitContainer.Panel1.ResumeLayout(false);
            splitContainer.Panel2.ResumeLayout(false);
            splitContainer.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)shippingFeeNumeric).EndInit();
            ((System.ComponentModel.ISupportInitialize)itemGrid).EndInit();
            ((System.ComponentModel.ISupportInitialize)errorProvider).EndInit();
            dashboardLayout.ResumeLayout(false);
            customerTab.ResumeLayout(false);
            customerTab.PerformLayout();
            shippingTab.ResumeLayout(false);
            shippingTab.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
    }
}