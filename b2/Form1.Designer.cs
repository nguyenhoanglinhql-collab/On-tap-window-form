namespace b2
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;
        private GroupBox ticketInformationGroupBox;
        private GroupBox issueDetailsGroupBox;
        private Label ticketIdLabel;
        private Label requesterLabel;
        private Label receivedDateLabel;
        private Label priorityLabel;
        private Label issueTypeLabel;
        private Label affectedDevicesLabel;
        private Label errorImageLabel;
        private TextBox ticketIdTextBox;
        private TextBox requesterTextBox;
        private DateTimePicker receivedDatePicker;
        private RadioButton lowPriorityRadioButton;
        private RadioButton mediumPriorityRadioButton;
        private RadioButton urgentPriorityRadioButton;
        private ComboBox issueTypeComboBox;
        private CheckBox desktopCheckBox;
        private CheckBox laptopCheckBox;
        private CheckBox printerCheckBox;
        private CheckBox phoneCheckBox;
        private PictureBox errorPictureBox;
        private Button uploadImageButton;
        private Button submitButton;
        private Button resetButton;

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
            ticketInformationGroupBox = new GroupBox();
            issueDetailsGroupBox = new GroupBox();
            ticketIdLabel = new Label();
            requesterLabel = new Label();
            receivedDateLabel = new Label();
            priorityLabel = new Label();
            issueTypeLabel = new Label();
            affectedDevicesLabel = new Label();
            errorImageLabel = new Label();
            ticketIdTextBox = new TextBox();
            requesterTextBox = new TextBox();
            receivedDatePicker = new DateTimePicker();
            lowPriorityRadioButton = new RadioButton();
            mediumPriorityRadioButton = new RadioButton();
            urgentPriorityRadioButton = new RadioButton();
            issueTypeComboBox = new ComboBox();
            desktopCheckBox = new CheckBox();
            laptopCheckBox = new CheckBox();
            printerCheckBox = new CheckBox();
            phoneCheckBox = new CheckBox();
            errorPictureBox = new PictureBox();
            uploadImageButton = new Button();
            submitButton = new Button();
            resetButton = new Button();
            ticketInformationGroupBox.SuspendLayout();
            issueDetailsGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)errorPictureBox).BeginInit();
            SuspendLayout();

            ticketInformationGroupBox.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            ticketInformationGroupBox.Location = new Point(15, 15);
            ticketInformationGroupBox.Name = "ticketInformationGroupBox";
            ticketInformationGroupBox.Size = new Size(870, 175);
            ticketInformationGroupBox.TabIndex = 0;
            ticketInformationGroupBox.TabStop = false;
            ticketInformationGroupBox.Text = "Thông tin phiếu";

            ticketIdLabel.AutoSize = true;
            ticketIdLabel.Location = new Point(25, 42);
            ticketIdLabel.Name = "ticketIdLabel";
            ticketIdLabel.Size = new Size(67, 19);
            ticketIdLabel.Text = "Mã phiếu:";
            ticketInformationGroupBox.Controls.Add(ticketIdLabel);

            ticketIdTextBox.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            ticketIdTextBox.Location = new Point(125, 38);
            ticketIdTextBox.Name = "ticketIdTextBox";
            ticketIdTextBox.ReadOnly = true;
            ticketIdTextBox.Size = new Size(275, 25);
            ticketIdTextBox.TabIndex = 0;
            ticketInformationGroupBox.Controls.Add(ticketIdTextBox);

            requesterLabel.AutoSize = true;
            requesterLabel.Location = new Point(425, 42);
            requesterLabel.Name = "requesterLabel";
            requesterLabel.Size = new Size(98, 19);
            requesterLabel.Text = "Người yêu cầu:";
            ticketInformationGroupBox.Controls.Add(requesterLabel);

            requesterTextBox.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            requesterTextBox.Location = new Point(545, 38);
            requesterTextBox.Name = "requesterTextBox";
            requesterTextBox.Size = new Size(295, 25);
            requesterTextBox.TabIndex = 1;
            ticketInformationGroupBox.Controls.Add(requesterTextBox);

            receivedDateLabel.AutoSize = true;
            receivedDateLabel.Location = new Point(25, 94);
            receivedDateLabel.Name = "receivedDateLabel";
            receivedDateLabel.Size = new Size(99, 19);
            receivedDateLabel.Text = "Ngày ghi nhận:";
            ticketInformationGroupBox.Controls.Add(receivedDateLabel);

            receivedDatePicker.Format = DateTimePickerFormat.Short;
            receivedDatePicker.Location = new Point(125, 90);
            receivedDatePicker.Name = "receivedDatePicker";
            receivedDatePicker.Size = new Size(180, 25);
            receivedDatePicker.TabIndex = 2;
            ticketInformationGroupBox.Controls.Add(receivedDatePicker);

            priorityLabel.AutoSize = true;
            priorityLabel.Location = new Point(425, 94);
            priorityLabel.Name = "priorityLabel";
            priorityLabel.Size = new Size(108, 19);
            priorityLabel.Text = "Mức độ ưu tiên:";
            ticketInformationGroupBox.Controls.Add(priorityLabel);

            lowPriorityRadioButton.AutoSize = true;
            lowPriorityRadioButton.Location = new Point(545, 91);
            lowPriorityRadioButton.Name = "lowPriorityRadioButton";
            lowPriorityRadioButton.Size = new Size(54, 23);
            lowPriorityRadioButton.TabIndex = 3;
            lowPriorityRadioButton.Text = "Thấp";
            ticketInformationGroupBox.Controls.Add(lowPriorityRadioButton);

            mediumPriorityRadioButton.AutoSize = true;
            mediumPriorityRadioButton.Checked = true;
            mediumPriorityRadioButton.Location = new Point(610, 91);
            mediumPriorityRadioButton.Name = "mediumPriorityRadioButton";
            mediumPriorityRadioButton.Size = new Size(94, 23);
            mediumPriorityRadioButton.TabIndex = 4;
            mediumPriorityRadioButton.TabStop = true;
            mediumPriorityRadioButton.Text = "Trung bình";
            ticketInformationGroupBox.Controls.Add(mediumPriorityRadioButton);

            urgentPriorityRadioButton.AutoSize = true;
            urgentPriorityRadioButton.Location = new Point(715, 91);
            urgentPriorityRadioButton.Name = "urgentPriorityRadioButton";
            urgentPriorityRadioButton.Size = new Size(82, 23);
            urgentPriorityRadioButton.TabIndex = 5;
            urgentPriorityRadioButton.Text = "Khẩn cấp";
            ticketInformationGroupBox.Controls.Add(urgentPriorityRadioButton);

            issueDetailsGroupBox.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            issueDetailsGroupBox.Location = new Point(15, 205);
            issueDetailsGroupBox.Name = "issueDetailsGroupBox";
            issueDetailsGroupBox.Size = new Size(870, 440);
            issueDetailsGroupBox.TabIndex = 1;
            issueDetailsGroupBox.TabStop = false;
            issueDetailsGroupBox.Text = "Phân loại & Chi tiết";

            issueTypeLabel.AutoSize = true;
            issueTypeLabel.Location = new Point(25, 43);
            issueTypeLabel.Name = "issueTypeLabel";
            issueTypeLabel.Size = new Size(74, 19);
            issueTypeLabel.Text = "Loại sự cố:";
            issueDetailsGroupBox.Controls.Add(issueTypeLabel);

            issueTypeComboBox.DropDownStyle = ComboBoxStyle.DropDownList;
            issueTypeComboBox.Items.AddRange(new object[] { "Phần cứng", "Phần mềm", "Mạng", "Tài khoản" });
            issueTypeComboBox.Location = new Point(125, 39);
            issueTypeComboBox.Name = "issueTypeComboBox";
            issueTypeComboBox.Size = new Size(300, 25);
            issueTypeComboBox.TabIndex = 0;
            issueTypeComboBox.SelectedIndex = 0;
            issueDetailsGroupBox.Controls.Add(issueTypeComboBox);

            affectedDevicesLabel.AutoSize = true;
            affectedDevicesLabel.Location = new Point(25, 102);
            affectedDevicesLabel.Name = "affectedDevicesLabel";
            affectedDevicesLabel.Size = new Size(132, 19);
            affectedDevicesLabel.Text = "Thiết bị ảnh hưởng:";
            issueDetailsGroupBox.Controls.Add(affectedDevicesLabel);

            desktopCheckBox.AutoSize = true;
            desktopCheckBox.Location = new Point(35, 137);
            desktopCheckBox.Name = "desktopCheckBox";
            desktopCheckBox.Size = new Size(115, 23);
            desktopCheckBox.TabIndex = 1;
            desktopCheckBox.Text = "Máy tính bàn";
            issueDetailsGroupBox.Controls.Add(desktopCheckBox);

            laptopCheckBox.AutoSize = true;
            laptopCheckBox.Location = new Point(190, 137);
            laptopCheckBox.Name = "laptopCheckBox";
            laptopCheckBox.Size = new Size(69, 23);
            laptopCheckBox.TabIndex = 2;
            laptopCheckBox.Text = "Laptop";
            issueDetailsGroupBox.Controls.Add(laptopCheckBox);

            printerCheckBox.AutoSize = true;
            printerCheckBox.Location = new Point(35, 174);
            printerCheckBox.Name = "printerCheckBox";
            printerCheckBox.Size = new Size(71, 23);
            printerCheckBox.TabIndex = 3;
            printerCheckBox.Text = "Máy in";
            issueDetailsGroupBox.Controls.Add(printerCheckBox);

            phoneCheckBox.AutoSize = true;
            phoneCheckBox.Location = new Point(190, 174);
            phoneCheckBox.Name = "phoneCheckBox";
            phoneCheckBox.Size = new Size(93, 23);
            phoneCheckBox.TabIndex = 4;
            phoneCheckBox.Text = "Điện thoại";
            issueDetailsGroupBox.Controls.Add(phoneCheckBox);

            errorImageLabel.AutoSize = true;
            errorImageLabel.Location = new Point(465, 43);
            errorImageLabel.Name = "errorImageLabel";
            errorImageLabel.Size = new Size(88, 19);
            errorImageLabel.Text = "Ảnh chụp lỗi:";
            issueDetailsGroupBox.Controls.Add(errorImageLabel);

            errorPictureBox.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            errorPictureBox.BackColor = Color.WhiteSmoke;
            errorPictureBox.BorderStyle = BorderStyle.FixedSingle;
            errorPictureBox.Location = new Point(465, 72);
            errorPictureBox.Name = "errorPictureBox";
            errorPictureBox.Size = new Size(370, 290);
            errorPictureBox.SizeMode = PictureBoxSizeMode.StretchImage;
            issueDetailsGroupBox.Controls.Add(errorPictureBox);

            uploadImageButton.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            uploadImageButton.Location = new Point(715, 378);
            uploadImageButton.Name = "uploadImageButton";
            uploadImageButton.Size = new Size(120, 32);
            uploadImageButton.TabIndex = 6;
            uploadImageButton.Text = "Tải ảnh lỗi";
            uploadImageButton.UseVisualStyleBackColor = true;
            uploadImageButton.Click += UploadImage;
            issueDetailsGroupBox.Controls.Add(uploadImageButton);

            resetButton.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            resetButton.Location = new Point(680, 665);
            resetButton.Name = "resetButton";
            resetButton.Size = new Size(90, 32);
            resetButton.TabIndex = 2;
            resetButton.Text = "Nhập lại";
            resetButton.UseVisualStyleBackColor = true;
            resetButton.Click += ResetForm;

            submitButton.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            submitButton.Location = new Point(780, 665);
            submitButton.Name = "submitButton";
            submitButton.Size = new Size(105, 32);
            submitButton.TabIndex = 3;
            submitButton.Text = "Gửi yêu cầu";
            submitButton.UseVisualStyleBackColor = true;
            submitButton.Click += SubmitRequest;

            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(900, 720);
            Controls.Add(ticketInformationGroupBox);
            Controls.Add(issueDetailsGroupBox);
            Controls.Add(resetButton);
            Controls.Add(submitButton);
            MinimumSize = new Size(760, 650);
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Tiếp nhận & Phân loại sự cố IT";

            ticketInformationGroupBox.ResumeLayout(false);
            ticketInformationGroupBox.PerformLayout();
            issueDetailsGroupBox.ResumeLayout(false);
            issueDetailsGroupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)errorPictureBox).EndInit();
            ResumeLayout(false);
        }

        #endregion
    }
}
