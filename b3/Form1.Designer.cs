namespace b3
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;
        private SplitContainer splitContainer;
        private GroupBox inputGroup;
        private GroupBox listGroup;
        private Label codeLabel;
        private Label nameLabel;
        private Label unitLabel;
        private Label priceLabel;
        private TextBox codeTextBox;
        private TextBox nameTextBox;
        private ComboBox unitComboBox;
        private NumericUpDown priceInput;
        private Button addButton;
        private Button updateButton;
        private Button deleteButton;
        private Button deleteAllButton;
        private ListView materialListView;
        private Label countLabel;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            splitContainer = new SplitContainer();
            inputGroup = new GroupBox();
            listGroup = new GroupBox();
            codeLabel = new Label();
            nameLabel = new Label();
            unitLabel = new Label();
            priceLabel = new Label();
            codeTextBox = new TextBox();
            nameTextBox = new TextBox();
            unitComboBox = new ComboBox();
            priceInput = new NumericUpDown();
            addButton = new Button();
            updateButton = new Button();
            deleteButton = new Button();
            deleteAllButton = new Button();
            materialListView = new ListView();
            countLabel = new Label();
            ((System.ComponentModel.ISupportInitialize)splitContainer).BeginInit();
            splitContainer.Panel1.SuspendLayout();
            splitContainer.Panel2.SuspendLayout();
            splitContainer.SuspendLayout();
            inputGroup.SuspendLayout();
            listGroup.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)priceInput).BeginInit();
            SuspendLayout();
            // 
            // splitContainer
            // 
            splitContainer.Dock = DockStyle.Fill;
            splitContainer.FixedPanel = FixedPanel.Panel1;
            splitContainer.Location = new Point(0, 0);
            splitContainer.Name = "splitContainer";
            splitContainer.Panel1.Controls.Add(inputGroup);
            splitContainer.Panel1MinSize = 320;
            splitContainer.Panel2.Controls.Add(listGroup);
            splitContainer.Panel2MinSize = 450;
            splitContainer.Size = new Size(1100, 620);
            splitContainer.SplitterDistance = 350;
            splitContainer.TabIndex = 0;
            // 
            // inputGroup
            // 
            inputGroup.Controls.Add(codeLabel);
            inputGroup.Controls.Add(codeTextBox);
            inputGroup.Controls.Add(nameLabel);
            inputGroup.Controls.Add(nameTextBox);
            inputGroup.Controls.Add(unitLabel);
            inputGroup.Controls.Add(unitComboBox);
            inputGroup.Controls.Add(priceLabel);
            inputGroup.Controls.Add(priceInput);
            inputGroup.Controls.Add(addButton);
            inputGroup.Controls.Add(updateButton);
            inputGroup.Controls.Add(deleteButton);
            inputGroup.Controls.Add(deleteAllButton);
            inputGroup.Dock = DockStyle.Fill;
            inputGroup.Location = new Point(0, 0);
            inputGroup.Name = "inputGroup";
            inputGroup.Padding = new Padding(12);
            inputGroup.Size = new Size(350, 620);
            inputGroup.TabIndex = 0;
            inputGroup.TabStop = false;
            inputGroup.Text = "Thông tin vật tư";
            // 
            // codeLabel
            // 
            codeLabel.Location = new Point(16, 38);
            codeLabel.Name = "codeLabel";
            codeLabel.Size = new Size(100, 25);
            codeLabel.TabIndex = 0;
            codeLabel.Text = "Mã vật tư:";
            codeLabel.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // codeTextBox
            // 
            codeTextBox.Location = new Point(120, 38);
            codeTextBox.Name = "codeTextBox";
            codeTextBox.Size = new Size(205, 27);
            codeTextBox.TabIndex = 1;
            // 
            // nameLabel
            // 
            nameLabel.Location = new Point(16, 78);
            nameLabel.Name = "nameLabel";
            nameLabel.Size = new Size(100, 25);
            nameLabel.TabIndex = 2;
            nameLabel.Text = "Tên vật tư:";
            nameLabel.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // nameTextBox
            // 
            nameTextBox.Location = new Point(120, 78);
            nameTextBox.Name = "nameTextBox";
            nameTextBox.Size = new Size(205, 27);
            nameTextBox.TabIndex = 3;
            // 
            // unitLabel
            // 
            unitLabel.Location = new Point(16, 118);
            unitLabel.Name = "unitLabel";
            unitLabel.Size = new Size(100, 25);
            unitLabel.TabIndex = 4;
            unitLabel.Text = "Đơn vị tính:";
            unitLabel.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // unitComboBox
            // 
            unitComboBox.DropDownStyle = ComboBoxStyle.DropDownList;
            unitComboBox.FormattingEnabled = true;
            unitComboBox.Items.AddRange(new object[] { "Cái", "Bộ", "Kg", "Mét" });
            unitComboBox.Location = new Point(120, 118);
            unitComboBox.Name = "unitComboBox";
            unitComboBox.Size = new Size(205, 28);
            unitComboBox.TabIndex = 5;
            unitComboBox.SelectedIndex = 0;
            // 
            // priceLabel
            // 
            priceLabel.Location = new Point(16, 158);
            priceLabel.Name = "priceLabel";
            priceLabel.Size = new Size(100, 25);
            priceLabel.TabIndex = 6;
            priceLabel.Text = "Đơn giá nhập:";
            priceLabel.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // priceInput
            // 
            priceInput.DecimalPlaces = 2;
            priceInput.Location = new Point(120, 158);
            priceInput.Maximum = 1000000000000;
            priceInput.Name = "priceInput";
            priceInput.Size = new Size(205, 27);
            priceInput.TabIndex = 7;
            priceInput.ThousandsSeparator = true;
            // 
            // addButton
            // 
            addButton.Location = new Point(18, 215);
            addButton.Name = "addButton";
            addButton.Size = new Size(145, 38);
            addButton.TabIndex = 8;
            addButton.Text = "Thêm mới";
            addButton.UseVisualStyleBackColor = true;
            addButton.Click += AddMaterial;
            // 
            // updateButton
            // 
            updateButton.Location = new Point(180, 215);
            updateButton.Name = "updateButton";
            updateButton.Size = new Size(145, 38);
            updateButton.TabIndex = 9;
            updateButton.Text = "Cập nhật";
            updateButton.UseVisualStyleBackColor = true;
            updateButton.Click += UpdateMaterial;
            // 
            // deleteButton
            // 
            deleteButton.Location = new Point(18, 265);
            deleteButton.Name = "deleteButton";
            deleteButton.Size = new Size(145, 38);
            deleteButton.TabIndex = 10;
            deleteButton.Text = "Xóa dòng";
            deleteButton.UseVisualStyleBackColor = true;
            deleteButton.Click += DeleteMaterial;
            // 
            // deleteAllButton
            // 
            deleteAllButton.Location = new Point(180, 265);
            deleteAllButton.Name = "deleteAllButton";
            deleteAllButton.Size = new Size(145, 38);
            deleteAllButton.TabIndex = 11;
            deleteAllButton.Text = "Xóa toàn bộ";
            deleteAllButton.UseVisualStyleBackColor = true;
            deleteAllButton.Click += DeleteAllMaterials;
            // 
            // listGroup
            // 
            listGroup.Controls.Add(materialListView);
            listGroup.Controls.Add(countLabel);
            listGroup.Dock = DockStyle.Fill;
            listGroup.Location = new Point(0, 0);
            listGroup.Name = "listGroup";
            listGroup.Padding = new Padding(10);
            listGroup.Size = new Size(746, 620);
            listGroup.TabIndex = 0;
            listGroup.TabStop = false;
            listGroup.Text = "Danh sách vật tư";
            // 
            // materialListView
            // 
            materialListView.Columns.Add("Mã VT", 110);
            materialListView.Columns.Add("Tên VT", 260);
            materialListView.Columns.Add("Đơn vị tính", 120);
            materialListView.Columns.Add("Đơn giá", 150);
            materialListView.Dock = DockStyle.Fill;
            materialListView.FullRowSelect = true;
            materialListView.GridLines = true;
            materialListView.HideSelection = false;
            materialListView.Location = new Point(10, 30);
            materialListView.MultiSelect = false;
            materialListView.Name = "materialListView";
            materialListView.Size = new Size(726, 552);
            materialListView.TabIndex = 0;
            materialListView.UseCompatibleStateImageBehavior = false;
            materialListView.View = View.Details;
            materialListView.SelectedIndexChanged += MaterialListView_SelectedIndexChanged;
            // 
            // countLabel
            // 
            countLabel.Dock = DockStyle.Bottom;
            countLabel.Location = new Point(10, 582);
            countLabel.Name = "countLabel";
            countLabel.Size = new Size(726, 28);
            countLabel.TabIndex = 1;
            countLabel.Text = "Số lượng: 0";
            countLabel.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // Form1
            // 
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1100, 620);
            Controls.Add(splitContainer);
            MinimumSize = new Size(900, 500);
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Quản lý danh mục Vật tư / Linh kiện";
            ((System.ComponentModel.ISupportInitialize)splitContainer).EndInit();
            splitContainer.Panel1.ResumeLayout(false);
            splitContainer.Panel2.ResumeLayout(false);
            splitContainer.ResumeLayout(false);
            inputGroup.ResumeLayout(false);
            listGroup.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)priceInput).EndInit();
            ResumeLayout(false);
        }

        #endregion
    }
}