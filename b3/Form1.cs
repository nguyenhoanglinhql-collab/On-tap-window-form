namespace b3
{
    public partial class Form1 : Form
    {
        private readonly List<Material> materials = [];

        public Form1()
        {
            InitializeComponent();
        }

        private void AddMaterial(object? sender, EventArgs e)
        {
            if (!TryReadMaterial(out var material))
            {
                return;
            }

            if (materials.Any(item => string.Equals(item.Code, material.Code, StringComparison.OrdinalIgnoreCase)))
            {
                MessageBox.Show(this, "Mã vật tư đã tồn tại.", "Không thể thêm", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                codeTextBox.Focus();
                return;
            }

            materials.Add(material);
            RefreshMaterialList();
            ClearInputs();
        }

        private void UpdateMaterial(object? sender, EventArgs e)
        {
            if (materialListView.SelectedItems.Count == 0)
            {
                MessageBox.Show(this, "Vui lòng chọn vật tư cần cập nhật.", "Chưa chọn vật tư", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            if (!TryReadMaterial(out var updatedMaterial))
            {
                return;
            }

            var selectedMaterial = (Material)materialListView.SelectedItems[0].Tag!;
            if (materials.Any(item => !ReferenceEquals(item, selectedMaterial)
                && string.Equals(item.Code, updatedMaterial.Code, StringComparison.OrdinalIgnoreCase)))
            {
                MessageBox.Show(this, "Mã vật tư đã tồn tại.", "Không thể cập nhật", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                codeTextBox.Focus();
                return;
            }

            selectedMaterial.Code = updatedMaterial.Code;
            selectedMaterial.Name = updatedMaterial.Name;
            selectedMaterial.Unit = updatedMaterial.Unit;
            selectedMaterial.Price = updatedMaterial.Price;
            RefreshMaterialList();
            ClearInputs();
        }

        private void DeleteMaterial(object? sender, EventArgs e)
        {
            if (materialListView.SelectedItems.Count == 0)
            {
                MessageBox.Show(this, "Vui lòng chọn dòng cần xóa.", "Chưa chọn vật tư", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            if (MessageBox.Show(this, "Bạn có chắc chắn muốn xóa dòng vật tư đã chọn?", "Xác nhận xóa",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question) != DialogResult.Yes)
            {
                return;
            }

            var selectedMaterial = (Material)materialListView.SelectedItems[0].Tag!;
            materials.Remove(selectedMaterial);
            RefreshMaterialList();
            ClearInputs();
        }

        private void DeleteAllMaterials(object? sender, EventArgs e)
        {
            materials.Clear();
            RefreshMaterialList();
            ClearInputs();
        }

        private void MaterialListView_SelectedIndexChanged(object? sender, EventArgs e)
        {
            if (materialListView.SelectedItems.Count == 0)
            {
                return;
            }

            var material = (Material)materialListView.SelectedItems[0].Tag!;
            codeTextBox.Text = material.Code;
            nameTextBox.Text = material.Name;
            unitComboBox.SelectedItem = material.Unit;
            priceInput.Value = material.Price;
        }

        private bool TryReadMaterial(out Material material)
        {
            var code = codeTextBox.Text.Trim();
            var name = nameTextBox.Text.Trim();
            if (code.Length == 0 || name.Length == 0)
            {
                MessageBox.Show(this, "Vui lòng nhập mã vật tư và tên vật tư.", "Thiếu thông tin", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                material = null!;
                return false;
            }

            material = new Material
            {
                Code = code,
                Name = name,
                Unit = unitComboBox.SelectedItem?.ToString() ?? "Cái",
                Price = priceInput.Value
            };
            return true;
        }

        private void RefreshMaterialList()
        {
            materialListView.BeginUpdate();
            materialListView.Items.Clear();
            foreach (var material in materials)
            {
                var row = new ListViewItem(material.Code) { Tag = material };
                row.SubItems.Add(material.Name);
                row.SubItems.Add(material.Unit);
                row.SubItems.Add(material.Price.ToString("N2"));
                materialListView.Items.Add(row);
            }
            materialListView.EndUpdate();
            countLabel.Text = $"Số lượng: {materials.Count}";
        }

        private void ClearInputs()
        {
            codeTextBox.Clear();
            nameTextBox.Clear();
            unitComboBox.SelectedIndex = 0;
            priceInput.Value = 0;
            codeTextBox.Focus();
        }

        private sealed class Material
        {
            public string Code { get; set; } = string.Empty;
            public string Name { get; set; } = string.Empty;
            public string Unit { get; set; } = string.Empty;
            public decimal Price { get; set; }
        }
    }
}
