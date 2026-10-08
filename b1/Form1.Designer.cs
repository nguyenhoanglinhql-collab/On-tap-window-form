namespace b1
{
    partial class Form1
    {
        private TextBox servicePriceTextBox;
        private TextBox customerCountTextBox;
        private TextBox discountTextBox;
        private Label totalAmountLabel;
        private Button calculateButton;
        private Button clearButton;
        private TableLayoutPanel layout;
        private Label titleLabel;
        private Label servicePriceLabel;
        private Label customerCountLabel;
        private Label discountLabel;
        private Label resultTitleLabel;
        private FlowLayoutPanel buttonsPanel;

        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            servicePriceTextBox = new TextBox();
            customerCountTextBox = new TextBox();
            discountTextBox = new TextBox();
            totalAmountLabel = new Label();
            calculateButton = new Button();
            clearButton = new Button();
            layout = new TableLayoutPanel();
            titleLabel = new Label();
            servicePriceLabel = new Label();
            customerCountLabel = new Label();
            discountLabel = new Label();
            resultTitleLabel = new Label();
            buttonsPanel = new FlowLayoutPanel();
            layout.SuspendLayout();
            buttonsPanel.SuspendLayout();
            SuspendLayout();
            // 
            // servicePriceTextBox
            // 
            servicePriceTextBox.Dock = DockStyle.Fill;
            servicePriceTextBox.Location = new Point(245, 80);
            servicePriceTextBox.Margin = new Padding(6, 8, 6, 8);
            servicePriceTextBox.Name = "servicePriceTextBox";
            servicePriceTextBox.PlaceholderText = "Ví dụ: 150000";
            servicePriceTextBox.Size = new Size(285, 27);
            servicePriceTextBox.TabIndex = 0;
            servicePriceTextBox.TextAlign = HorizontalAlignment.Right;
            // 
            // customerCountTextBox
            // 
            customerCountTextBox.Dock = DockStyle.Fill;
            customerCountTextBox.Location = new Point(245, 134);
            customerCountTextBox.Margin = new Padding(6, 8, 6, 8);
            customerCountTextBox.Name = "customerCountTextBox";
            customerCountTextBox.PlaceholderText = "Ví dụ: 2";
            customerCountTextBox.Size = new Size(285, 27);
            customerCountTextBox.TabIndex = 1;
            customerCountTextBox.TextAlign = HorizontalAlignment.Right;
            // 
            // discountTextBox
            // 
            discountTextBox.Dock = DockStyle.Fill;
            discountTextBox.Location = new Point(245, 188);
            discountTextBox.Margin = new Padding(6, 8, 6, 8);
            discountTextBox.Name = "discountTextBox";
            discountTextBox.PlaceholderText = "0 - 100";
            discountTextBox.Size = new Size(285, 27);
            discountTextBox.TabIndex = 2;
            discountTextBox.Text = "0";
            discountTextBox.TextAlign = HorizontalAlignment.Right;
            // 
            // totalAmountLabel
            // 
            totalAmountLabel.Dock = DockStyle.Fill;
            totalAmountLabel.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            totalAmountLabel.ForeColor = Color.DarkGreen;
            totalAmountLabel.Location = new Point(242, 234);
            totalAmountLabel.Name = "totalAmountLabel";
            totalAmountLabel.Size = new Size(291, 54);
            totalAmountLabel.TabIndex = 5;
            totalAmountLabel.Text = "—";
            totalAmountLabel.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // calculateButton
            // 
            calculateButton.AutoSize = true;
            calculateButton.Location = new Point(403, 3);
            calculateButton.Name = "calculateButton";
            calculateButton.Padding = new Padding(12, 4, 12, 4);
            calculateButton.Size = new Size(100, 38);
            calculateButton.TabIndex = 3;
            calculateButton.Text = "Tính tiền";
            calculateButton.Click += CalculateButton_Click;
            // 
            // clearButton
            // 
            clearButton.AutoSize = true;
            clearButton.Location = new Point(296, 3);
            clearButton.Name = "clearButton";
            clearButton.Padding = new Padding(12, 4, 12, 4);
            clearButton.Size = new Size(101, 38);
            clearButton.TabIndex = 4;
            clearButton.Text = "Làm mới";
            clearButton.Click += ClearButton_Click;
            // 
            // layout
            // 
            layout.ColumnCount = 2;
            layout.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 42F));
            layout.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 58F));
            layout.Controls.Add(titleLabel, 0, 0);
            layout.Controls.Add(servicePriceLabel, 0, 1);
            layout.Controls.Add(servicePriceTextBox, 1, 1);
            layout.Controls.Add(customerCountLabel, 0, 2);
            layout.Controls.Add(customerCountTextBox, 1, 2);
            layout.Controls.Add(discountLabel, 0, 3);
            layout.Controls.Add(discountTextBox, 1, 3);
            layout.Controls.Add(resultTitleLabel, 0, 4);
            layout.Controls.Add(totalAmountLabel, 1, 4);
            layout.Controls.Add(buttonsPanel, 0, 5);
            layout.Dock = DockStyle.Fill;
            layout.Location = new Point(0, 0);
            layout.Name = "layout";
            layout.Padding = new Padding(24);
            layout.RowCount = 6;
            layout.RowStyles.Add(new RowStyle(SizeType.Absolute, 48F));
            layout.RowStyles.Add(new RowStyle(SizeType.Percent, 20F));
            layout.RowStyles.Add(new RowStyle(SizeType.Percent, 20F));
            layout.RowStyles.Add(new RowStyle(SizeType.Percent, 20F));
            layout.RowStyles.Add(new RowStyle(SizeType.Percent, 20F));
            layout.RowStyles.Add(new RowStyle(SizeType.Absolute, 56F));
            layout.Size = new Size(560, 370);
            layout.TabIndex = 0;
            // 
            // titleLabel
            // 
            layout.SetColumnSpan(titleLabel, 2);
            titleLabel.Dock = DockStyle.Fill;
            titleLabel.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            titleLabel.Location = new Point(27, 24);
            titleLabel.Name = "titleLabel";
            titleLabel.Size = new Size(506, 48);
            titleLabel.TabIndex = 0;
            titleLabel.Text = "TÍNH CƯỚC DỊCH VỤ";
            titleLabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // servicePriceLabel
            // 
            servicePriceLabel.Dock = DockStyle.Fill;
            servicePriceLabel.Location = new Point(27, 72);
            servicePriceLabel.Name = "servicePriceLabel";
            servicePriceLabel.Size = new Size(209, 54);
            servicePriceLabel.TabIndex = 1;
            servicePriceLabel.Text = "Đơn giá dịch vụ:";
            servicePriceLabel.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // customerCountLabel
            // 
            customerCountLabel.Dock = DockStyle.Fill;
            customerCountLabel.Location = new Point(27, 126);
            customerCountLabel.Name = "customerCountLabel";
            customerCountLabel.Size = new Size(209, 54);
            customerCountLabel.TabIndex = 2;
            customerCountLabel.Text = "Số lượng khách:";
            customerCountLabel.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // discountLabel
            // 
            discountLabel.Dock = DockStyle.Fill;
            discountLabel.Location = new Point(27, 180);
            discountLabel.Name = "discountLabel";
            discountLabel.Size = new Size(209, 54);
            discountLabel.TabIndex = 3;
            discountLabel.Text = "Giảm giá (%):";
            discountLabel.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // resultTitleLabel
            // 
            resultTitleLabel.Dock = DockStyle.Fill;
            resultTitleLabel.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            resultTitleLabel.Location = new Point(27, 234);
            resultTitleLabel.Name = "resultTitleLabel";
            resultTitleLabel.Size = new Size(209, 54);
            resultTitleLabel.TabIndex = 4;
            resultTitleLabel.Text = "Tổng tiền thanh toán:";
            resultTitleLabel.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // buttonsPanel
            // 
            layout.SetColumnSpan(buttonsPanel, 2);
            buttonsPanel.Controls.Add(calculateButton);
            buttonsPanel.Controls.Add(clearButton);
            buttonsPanel.Dock = DockStyle.Fill;
            buttonsPanel.FlowDirection = FlowDirection.RightToLeft;
            buttonsPanel.Location = new Point(27, 291);
            buttonsPanel.Name = "buttonsPanel";
            buttonsPanel.Size = new Size(506, 52);
            buttonsPanel.TabIndex = 6;
            buttonsPanel.WrapContents = false;
            // 
            // Form1
            // 
            AcceptButton = calculateButton;
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(560, 370);
            Controls.Add(layout);
            MinimumSize = new Size(480, 330);
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Máy tính cước dịch vụ";
            layout.ResumeLayout(false);
            layout.PerformLayout();
            buttonsPanel.ResumeLayout(false);
            buttonsPanel.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
    }
}
