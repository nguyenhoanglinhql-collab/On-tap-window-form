using System.Drawing;

namespace b2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            ticketIdTextBox.Text = $"IT-{DateTime.Now:yyyyMMddHHmmss}";
            FormClosed += (_, _) => errorPictureBox.Image?.Dispose();
        }

        private void UploadImage(object? sender, EventArgs e)
        {
            using var dialog = new OpenFileDialog
            {
                Title = "Chọn ảnh chụp lỗi",
                Filter = "Tệp hình ảnh (*.jpg;*.png)|*.jpg;*.png",
                CheckFileExists = true
            };

            if (dialog.ShowDialog(this) != DialogResult.OK)
            {
                return;
            }

            using var sourceImage = Image.FromFile(dialog.FileName);
            var displayedImage = new Bitmap(sourceImage);
            var previousImage = errorPictureBox.Image;
            errorPictureBox.Image = displayedImage;
            previousImage?.Dispose();
        }

        private void SubmitRequest(object? sender, EventArgs e)
        {
            var priority = lowPriorityRadioButton.Checked ? "Thấp"
                : urgentPriorityRadioButton.Checked ? "Khẩn cấp"
                : "Trung bình";
            var devices = new List<string>();
            if (desktopCheckBox.Checked) devices.Add("Máy tính bàn");
            if (laptopCheckBox.Checked) devices.Add("Laptop");
            if (printerCheckBox.Checked) devices.Add("Máy in");
            if (phoneCheckBox.Checked) devices.Add("Điện thoại");

            var summary = $"Mã phiếu: {ticketIdTextBox.Text}\n" +
                $"Người yêu cầu: {requesterTextBox.Text.Trim()}\n" +
                $"Ngày ghi nhận: {receivedDatePicker.Value:dd/MM/yyyy}\n" +
                $"Mức độ ưu tiên: {priority}\n" +
                $"Loại sự cố: {issueTypeComboBox.Text}\n" +
                $"Thiết bị ảnh hưởng: {(devices.Count > 0 ? string.Join(", ", devices) : "Không có thiết bị nào được chọn")}\n" +
                $"Ảnh chụp lỗi: {(errorPictureBox.Image is null ? "Chưa tải ảnh" : "Đã đính kèm ảnh")}";

            MessageBox.Show(this, summary, "Tóm tắt yêu cầu", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void ResetForm(object? sender, EventArgs e)
        {
            ticketIdTextBox.Text = $"IT-{DateTime.Now:yyyyMMddHHmmss}";
            requesterTextBox.Clear();
            receivedDatePicker.Value = DateTime.Today;
            mediumPriorityRadioButton.Checked = true;
            issueTypeComboBox.SelectedIndex = 0;
            desktopCheckBox.Checked = false;
            laptopCheckBox.Checked = false;
            printerCheckBox.Checked = false;
            phoneCheckBox.Checked = false;
            var previousImage = errorPictureBox.Image;
            errorPictureBox.Image = null;
            previousImage?.Dispose();
        }
    }
}