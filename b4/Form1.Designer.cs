namespace b4
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;
        private TableLayoutPanel mainLayout = null!;
        private TableLayoutPanel seatLayoutPanel = null!;
        private TableLayoutPanel bookingPanel = null!;
        private ComboBox timeSlotComboBox = null!;
        private Label selectedCountLabel = null!;
        private Label totalPriceLabel = null!;
        private Label timeSlotLabel = null!;
        private Button confirmButton = null!;
        private Button cancelButton = null!;
        private Button seatPreview01 = null!;
        private Button seatPreview02 = null!;
        private Button seatPreview03 = null!;
        private Button seatPreview04 = null!;
        private Button seatPreview05 = null!;
        private Button seatPreview06 = null!;
        private Button seatPreview07 = null!;
        private Button seatPreview08 = null!;
        private Button seatPreview09 = null!;
        private Button seatPreview10 = null!;
        private Button seatPreview11 = null!;
        private Button seatPreview12 = null!;
        private Button seatPreview13 = null!;
        private Button seatPreview14 = null!;
        private Button seatPreview15 = null!;
        private Button seatPreview16 = null!;
        private Button seatPreview17 = null!;
        private Button seatPreview18 = null!;
        private Button seatPreview19 = null!;
        private Button seatPreview20 = null!;

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
            mainLayout = new TableLayoutPanel();
            seatLayoutPanel = new TableLayoutPanel();
            seatPreview01 = new Button();
            seatPreview02 = new Button();
            seatPreview03 = new Button();
            seatPreview04 = new Button();
            seatPreview05 = new Button();
            seatPreview06 = new Button();
            seatPreview07 = new Button();
            seatPreview08 = new Button();
            seatPreview09 = new Button();
            seatPreview10 = new Button();
            seatPreview11 = new Button();
            seatPreview12 = new Button();
            seatPreview13 = new Button();
            seatPreview14 = new Button();
            seatPreview15 = new Button();
            seatPreview16 = new Button();
            seatPreview17 = new Button();
            seatPreview18 = new Button();
            seatPreview19 = new Button();
            seatPreview20 = new Button();
            bookingPanel = new TableLayoutPanel();
            timeSlotLabel = new Label();
            timeSlotComboBox = new ComboBox();
            selectedCountLabel = new Label();
            totalPriceLabel = new Label();
            confirmButton = new Button();
            cancelButton = new Button();
            mainLayout.SuspendLayout();
            seatLayoutPanel.SuspendLayout();
            bookingPanel.SuspendLayout();
            SuspendLayout();
            // 
            // mainLayout
            // 
            mainLayout.ColumnCount = 1;
            mainLayout.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            mainLayout.Controls.Add(seatLayoutPanel, 0, 0);
            mainLayout.Controls.Add(bookingPanel, 0, 1);
            mainLayout.Dock = DockStyle.Fill;
            mainLayout.Location = new Point(0, 0);
            mainLayout.Name = "mainLayout";
            mainLayout.Padding = new Padding(12);
            mainLayout.RowCount = 2;
            mainLayout.RowStyles.Add(new RowStyle(SizeType.Percent, 72F));
            mainLayout.RowStyles.Add(new RowStyle(SizeType.Percent, 28F));
            mainLayout.Size = new Size(850, 520);
            mainLayout.TabIndex = 0;
            // 
            // seatLayoutPanel
            // 
            seatLayoutPanel.BackColor = Color.White;
            seatLayoutPanel.CellBorderStyle = TableLayoutPanelCellBorderStyle.Single;
            seatLayoutPanel.ColumnCount = 5;
            seatLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 20F));
            seatLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 20F));
            seatLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 20F));
            seatLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 20F));
            seatLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 20F));
            seatLayoutPanel.Controls.Add(seatPreview01, 0, 0);
            seatLayoutPanel.Controls.Add(seatPreview02, 1, 0);
            seatLayoutPanel.Controls.Add(seatPreview03, 2, 0);
            seatLayoutPanel.Controls.Add(seatPreview04, 3, 0);
            seatLayoutPanel.Controls.Add(seatPreview05, 4, 0);
            seatLayoutPanel.Controls.Add(seatPreview06, 0, 1);
            seatLayoutPanel.Controls.Add(seatPreview07, 1, 1);
            seatLayoutPanel.Controls.Add(seatPreview08, 2, 1);
            seatLayoutPanel.Controls.Add(seatPreview09, 3, 1);
            seatLayoutPanel.Controls.Add(seatPreview10, 4, 1);
            seatLayoutPanel.Controls.Add(seatPreview11, 0, 2);
            seatLayoutPanel.Controls.Add(seatPreview12, 1, 2);
            seatLayoutPanel.Controls.Add(seatPreview13, 2, 2);
            seatLayoutPanel.Controls.Add(seatPreview14, 3, 2);
            seatLayoutPanel.Controls.Add(seatPreview15, 4, 2);
            seatLayoutPanel.Controls.Add(seatPreview16, 0, 3);
            seatLayoutPanel.Controls.Add(seatPreview17, 1, 3);
            seatLayoutPanel.Controls.Add(seatPreview18, 2, 3);
            seatLayoutPanel.Controls.Add(seatPreview19, 3, 3);
            seatLayoutPanel.Controls.Add(seatPreview20, 4, 3);
            seatLayoutPanel.Dock = DockStyle.Fill;
            seatLayoutPanel.Location = new Point(15, 15);
            seatLayoutPanel.Name = "seatLayoutPanel";
            seatLayoutPanel.Padding = new Padding(8);
            seatLayoutPanel.RowCount = 4;
            seatLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 25F));
            seatLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 25F));
            seatLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 25F));
            seatLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 25F));
            seatLayoutPanel.Size = new Size(820, 351);
            seatLayoutPanel.TabIndex = 1;
            // 
            // seatPreview01
            // 
            seatPreview01.Dock = DockStyle.Fill;
            seatPreview01.FlatStyle = FlatStyle.Flat;
            seatPreview01.Location = new Point(17, 17);
            seatPreview01.Margin = new Padding(8);
            seatPreview01.Name = "seatPreview01";
            seatPreview01.Size = new Size(143, 66);
            seatPreview01.TabIndex = 0;
            seatPreview01.Text = "A1";
            seatPreview01.UseVisualStyleBackColor = false;
            // 
            // seatPreview02
            // 
            seatPreview02.Dock = DockStyle.Fill;
            seatPreview02.FlatStyle = FlatStyle.Flat;
            seatPreview02.Location = new Point(177, 17);
            seatPreview02.Margin = new Padding(8);
            seatPreview02.Name = "seatPreview02";
            seatPreview02.Size = new Size(143, 66);
            seatPreview02.TabIndex = 1;
            seatPreview02.Text = "A2";
            seatPreview02.UseVisualStyleBackColor = false;
            // 
            // seatPreview03
            // 
            seatPreview03.Dock = DockStyle.Fill;
            seatPreview03.FlatStyle = FlatStyle.Flat;
            seatPreview03.Location = new Point(337, 17);
            seatPreview03.Margin = new Padding(8);
            seatPreview03.Name = "seatPreview03";
            seatPreview03.Size = new Size(143, 66);
            seatPreview03.TabIndex = 2;
            seatPreview03.Text = "A3";
            seatPreview03.UseVisualStyleBackColor = false;
            // 
            // seatPreview04
            // 
            seatPreview04.BackColor = Color.FromArgb(220, 70, 70);
            seatPreview04.Dock = DockStyle.Fill;
            seatPreview04.FlatStyle = FlatStyle.Flat;
            seatPreview04.ForeColor = Color.White;
            seatPreview04.Location = new Point(497, 17);
            seatPreview04.Margin = new Padding(8);
            seatPreview04.Name = "seatPreview04";
            seatPreview04.Size = new Size(143, 66);
            seatPreview04.TabIndex = 3;
            seatPreview04.Text = "A4\nĐã đặt";
            seatPreview04.UseVisualStyleBackColor = false;
            seatPreview04.Click += seatPreview04_Click;
            // 
            // seatPreview05
            // 
            seatPreview05.Dock = DockStyle.Fill;
            seatPreview05.FlatStyle = FlatStyle.Flat;
            seatPreview05.Location = new Point(657, 17);
            seatPreview05.Margin = new Padding(8);
            seatPreview05.Name = "seatPreview05";
            seatPreview05.Size = new Size(146, 66);
            seatPreview05.TabIndex = 4;
            seatPreview05.Text = "A5";
            seatPreview05.UseVisualStyleBackColor = false;
            // 
            // seatPreview06
            // 
            seatPreview06.Dock = DockStyle.Fill;
            seatPreview06.FlatStyle = FlatStyle.Flat;
            seatPreview06.Location = new Point(17, 100);
            seatPreview06.Margin = new Padding(8);
            seatPreview06.Name = "seatPreview06";
            seatPreview06.Size = new Size(143, 66);
            seatPreview06.TabIndex = 5;
            seatPreview06.Text = "B1";
            seatPreview06.UseVisualStyleBackColor = false;
            // 
            // seatPreview07
            // 
            seatPreview07.Dock = DockStyle.Fill;
            seatPreview07.FlatStyle = FlatStyle.Flat;
            seatPreview07.Location = new Point(177, 100);
            seatPreview07.Margin = new Padding(8);
            seatPreview07.Name = "seatPreview07";
            seatPreview07.Size = new Size(143, 66);
            seatPreview07.TabIndex = 6;
            seatPreview07.Text = "B2";
            seatPreview07.UseVisualStyleBackColor = false;
            // 
            // seatPreview08
            // 
            seatPreview08.Dock = DockStyle.Fill;
            seatPreview08.FlatStyle = FlatStyle.Flat;
            seatPreview08.Location = new Point(337, 100);
            seatPreview08.Margin = new Padding(8);
            seatPreview08.Name = "seatPreview08";
            seatPreview08.Size = new Size(143, 66);
            seatPreview08.TabIndex = 7;
            seatPreview08.Text = "B3";
            seatPreview08.UseVisualStyleBackColor = false;
            // 
            // seatPreview09
            // 
            seatPreview09.BackColor = Color.FromArgb(220, 70, 70);
            seatPreview09.Dock = DockStyle.Fill;
            seatPreview09.FlatStyle = FlatStyle.Flat;
            seatPreview09.ForeColor = Color.White;
            seatPreview09.Location = new Point(497, 100);
            seatPreview09.Margin = new Padding(8);
            seatPreview09.Name = "seatPreview09";
            seatPreview09.Size = new Size(143, 66);
            seatPreview09.TabIndex = 8;
            seatPreview09.Text = "B4\nĐã đặt";
            seatPreview09.UseVisualStyleBackColor = false;
            // 
            // seatPreview10
            // 
            seatPreview10.Dock = DockStyle.Fill;
            seatPreview10.FlatStyle = FlatStyle.Flat;
            seatPreview10.Location = new Point(657, 100);
            seatPreview10.Margin = new Padding(8);
            seatPreview10.Name = "seatPreview10";
            seatPreview10.Size = new Size(146, 66);
            seatPreview10.TabIndex = 9;
            seatPreview10.Text = "B5";
            seatPreview10.UseVisualStyleBackColor = false;
            seatPreview10.Click += seatPreview10_Click;
            // 
            // seatPreview11
            // 
            seatPreview11.Dock = DockStyle.Fill;
            seatPreview11.FlatStyle = FlatStyle.Flat;
            seatPreview11.Location = new Point(17, 183);
            seatPreview11.Margin = new Padding(8);
            seatPreview11.Name = "seatPreview11";
            seatPreview11.Size = new Size(143, 66);
            seatPreview11.TabIndex = 10;
            seatPreview11.Text = "C1";
            seatPreview11.UseVisualStyleBackColor = false;
            // 
            // seatPreview12
            // 
            seatPreview12.Dock = DockStyle.Fill;
            seatPreview12.FlatStyle = FlatStyle.Flat;
            seatPreview12.Location = new Point(177, 183);
            seatPreview12.Margin = new Padding(8);
            seatPreview12.Name = "seatPreview12";
            seatPreview12.Size = new Size(143, 66);
            seatPreview12.TabIndex = 11;
            seatPreview12.Text = "C2";
            seatPreview12.UseVisualStyleBackColor = false;
            // 
            // seatPreview13
            // 
            seatPreview13.Dock = DockStyle.Fill;
            seatPreview13.FlatStyle = FlatStyle.Flat;
            seatPreview13.Location = new Point(337, 183);
            seatPreview13.Margin = new Padding(8);
            seatPreview13.Name = "seatPreview13";
            seatPreview13.Size = new Size(143, 66);
            seatPreview13.TabIndex = 12;
            seatPreview13.Text = "C3";
            seatPreview13.UseVisualStyleBackColor = false;
            // 
            // seatPreview14
            // 
            seatPreview14.Dock = DockStyle.Fill;
            seatPreview14.FlatStyle = FlatStyle.Flat;
            seatPreview14.Location = new Point(497, 183);
            seatPreview14.Margin = new Padding(8);
            seatPreview14.Name = "seatPreview14";
            seatPreview14.Size = new Size(143, 66);
            seatPreview14.TabIndex = 13;
            seatPreview14.Text = "C4";
            seatPreview14.UseVisualStyleBackColor = false;
            // 
            // seatPreview15
            // 
            seatPreview15.BackColor = Color.FromArgb(220, 70, 70);
            seatPreview15.Dock = DockStyle.Fill;
            seatPreview15.FlatStyle = FlatStyle.Flat;
            seatPreview15.ForeColor = Color.White;
            seatPreview15.Location = new Point(657, 183);
            seatPreview15.Margin = new Padding(8);
            seatPreview15.Name = "seatPreview15";
            seatPreview15.Size = new Size(146, 66);
            seatPreview15.TabIndex = 14;
            seatPreview15.Text = "C5\nĐã đặt";
            seatPreview15.UseVisualStyleBackColor = false;
            // 
            // seatPreview16
            // 
            seatPreview16.Dock = DockStyle.Fill;
            seatPreview16.FlatStyle = FlatStyle.Flat;
            seatPreview16.Location = new Point(17, 266);
            seatPreview16.Margin = new Padding(8);
            seatPreview16.Name = "seatPreview16";
            seatPreview16.Size = new Size(143, 68);
            seatPreview16.TabIndex = 15;
            seatPreview16.Text = "D1";
            seatPreview16.UseVisualStyleBackColor = false;
            // 
            // seatPreview17
            // 
            seatPreview17.Dock = DockStyle.Fill;
            seatPreview17.FlatStyle = FlatStyle.Flat;
            seatPreview17.Location = new Point(177, 266);
            seatPreview17.Margin = new Padding(8);
            seatPreview17.Name = "seatPreview17";
            seatPreview17.Size = new Size(143, 68);
            seatPreview17.TabIndex = 16;
            seatPreview17.Text = "D2";
            seatPreview17.UseVisualStyleBackColor = false;
            // 
            // seatPreview18
            // 
            seatPreview18.Dock = DockStyle.Fill;
            seatPreview18.FlatStyle = FlatStyle.Flat;
            seatPreview18.Location = new Point(337, 266);
            seatPreview18.Margin = new Padding(8);
            seatPreview18.Name = "seatPreview18";
            seatPreview18.Size = new Size(143, 68);
            seatPreview18.TabIndex = 17;
            seatPreview18.Text = "D3";
            seatPreview18.UseVisualStyleBackColor = false;
            // 
            // seatPreview19
            // 
            seatPreview19.BackColor = Color.FromArgb(220, 70, 70);
            seatPreview19.Dock = DockStyle.Fill;
            seatPreview19.FlatStyle = FlatStyle.Flat;
            seatPreview19.ForeColor = Color.White;
            seatPreview19.Location = new Point(497, 266);
            seatPreview19.Margin = new Padding(8);
            seatPreview19.Name = "seatPreview19";
            seatPreview19.Size = new Size(143, 68);
            seatPreview19.TabIndex = 18;
            seatPreview19.Text = "D4\nĐã đặt";
            seatPreview19.UseVisualStyleBackColor = false;
            // 
            // seatPreview20
            // 
            seatPreview20.Dock = DockStyle.Fill;
            seatPreview20.FlatStyle = FlatStyle.Flat;
            seatPreview20.Location = new Point(657, 266);
            seatPreview20.Margin = new Padding(8);
            seatPreview20.Name = "seatPreview20";
            seatPreview20.Size = new Size(146, 68);
            seatPreview20.TabIndex = 19;
            seatPreview20.Text = "D5";
            seatPreview20.UseVisualStyleBackColor = false;
            // 
            // bookingPanel
            // 
            bookingPanel.ColumnCount = 4;
            bookingPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 13F));
            bookingPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 22F));
            bookingPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 30F));
            bookingPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 35F));
            bookingPanel.Controls.Add(timeSlotLabel, 0, 0);
            bookingPanel.Controls.Add(timeSlotComboBox, 1, 0);
            bookingPanel.Controls.Add(selectedCountLabel, 2, 0);
            bookingPanel.Controls.Add(totalPriceLabel, 3, 0);
            bookingPanel.Controls.Add(confirmButton, 2, 1);
            bookingPanel.Controls.Add(cancelButton, 3, 1);
            bookingPanel.Dock = DockStyle.Fill;
            bookingPanel.Location = new Point(15, 372);
            bookingPanel.Name = "bookingPanel";
            bookingPanel.Padding = new Padding(4, 8, 4, 0);
            bookingPanel.RowCount = 2;
            bookingPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            bookingPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            bookingPanel.Size = new Size(820, 133);
            bookingPanel.TabIndex = 2;
            // 
            // timeSlotLabel
            // 
            timeSlotLabel.Dock = DockStyle.Fill;
            timeSlotLabel.Font = new Font("Segoe UI", 10F);
            timeSlotLabel.Location = new Point(7, 8);
            timeSlotLabel.Name = "timeSlotLabel";
            timeSlotLabel.Size = new Size(99, 62);
            timeSlotLabel.TabIndex = 0;
            timeSlotLabel.Text = "Khung giờ:";
            timeSlotLabel.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // timeSlotComboBox
            // 
            timeSlotComboBox.Dock = DockStyle.Fill;
            timeSlotComboBox.DropDownStyle = ComboBoxStyle.DropDownList;
            timeSlotComboBox.Font = new Font("Segoe UI", 10F);
            timeSlotComboBox.Items.AddRange(new object[] { "Sáng - 100.000đ", "Tối - 150.000đ" });
            timeSlotComboBox.Location = new Point(112, 11);
            timeSlotComboBox.Name = "timeSlotComboBox";
            timeSlotComboBox.Size = new Size(172, 31);
            timeSlotComboBox.TabIndex = 1;
            // 
            // selectedCountLabel
            // 
            selectedCountLabel.Dock = DockStyle.Fill;
            selectedCountLabel.Font = new Font("Segoe UI", 10F);
            selectedCountLabel.Location = new Point(290, 8);
            selectedCountLabel.Name = "selectedCountLabel";
            selectedCountLabel.Size = new Size(237, 62);
            selectedCountLabel.TabIndex = 2;
            selectedCountLabel.Text = "Số vị trí đang chọn: 0";
            selectedCountLabel.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // totalPriceLabel
            // 
            totalPriceLabel.Dock = DockStyle.Fill;
            totalPriceLabel.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            totalPriceLabel.Location = new Point(533, 8);
            totalPriceLabel.Name = "totalPriceLabel";
            totalPriceLabel.Size = new Size(280, 62);
            totalPriceLabel.TabIndex = 3;
            totalPriceLabel.Text = "Tạm tính tiền: 0đ";
            totalPriceLabel.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // confirmButton
            // 
            confirmButton.Anchor = AnchorStyles.None;
            confirmButton.AutoSize = true;
            confirmButton.BackColor = Color.FromArgb(37, 99, 235);
            confirmButton.FlatAppearance.BorderSize = 0;
            confirmButton.FlatStyle = FlatStyle.Flat;
            confirmButton.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            confirmButton.ForeColor = Color.White;
            confirmButton.Location = new Point(353, 86);
            confirmButton.Name = "confirmButton";
            confirmButton.Size = new Size(110, 30);
            confirmButton.TabIndex = 5;
            confirmButton.Text = "Xác nhận đặt";
            confirmButton.UseVisualStyleBackColor = false;
            // 
            // cancelButton
            // 
            cancelButton.Anchor = AnchorStyles.None;
            cancelButton.AutoSize = true;
            cancelButton.Font = new Font("Segoe UI", 9F);
            cancelButton.Location = new Point(612, 86);
            cancelButton.Name = "cancelButton";
            cancelButton.Size = new Size(122, 30);
            cancelButton.TabIndex = 4;
            cancelButton.Text = "Hủy chọn tất cả";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(245, 247, 250);
            ClientSize = new Size(850, 520);
            Controls.Add(mainLayout);
            MinimumSize = new Size(700, 460);
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Đặt bàn hẹn giờ";
            mainLayout.ResumeLayout(false);
            seatLayoutPanel.ResumeLayout(false);
            bookingPanel.ResumeLayout(false);
            bookingPanel.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
    }
}
