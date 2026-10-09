namespace b4
{
    public partial class Form1 : Form
    {
        private const int SeatCount = 20;
        private const int MorningPrice = 100_000;
        private const int EveningPrice = 150_000;

        private readonly bool[] _selectedSeats = new bool[SeatCount];
        private readonly HashSet<int> _lockedSeats = [3, 8, 14, 18];
        private readonly List<Button> _seatButtons = [];

        public Form1()
        {
            InitializeComponent();
            timeSlotComboBox.SelectedIndex = 0;
            Load += Form1_Load;
            timeSlotComboBox.SelectedIndexChanged += (_, _) => UpdateSummary();
            confirmButton.Click += ConfirmButton_Click;
            cancelButton.Click += (_, _) => ClearSelection();
        }

        private void Form1_Load(object? sender, EventArgs e)
        {
            seatLayoutPanel.Controls.Clear();
            _seatButtons.Clear();

            for (var seatIndex = 0; seatIndex < SeatCount; seatIndex++)
            {
                var seatButton = new Button
                {
                    Text = GetSeatName(seatIndex),
                    Dock = DockStyle.Fill,
                    Margin = new Padding(8),
                    Font = new Font("Segoe UI", 10, FontStyle.Bold),
                    Tag = seatIndex,
                    FlatStyle = FlatStyle.Flat,
                    UseVisualStyleBackColor = false,
                    Cursor = Cursors.Hand,
                };
                seatButton.FlatAppearance.BorderSize = 0;
                seatButton.Click += SeatButton_Click;
                _seatButtons.Add(seatButton);
                seatLayoutPanel.Controls.Add(seatButton, seatIndex % 5, seatIndex / 5);
                UpdateSeatButton(seatIndex);
            }

            UpdateSummary();
        }

        private void SeatButton_Click(object? sender, EventArgs e)
        {
            if (sender is not Button { Tag: int seatIndex } || _lockedSeats.Contains(seatIndex))
            {
                return;
            }

            _selectedSeats[seatIndex] = !_selectedSeats[seatIndex];
            UpdateSeatButton(seatIndex);
            UpdateSummary();
        }

        private void ConfirmButton_Click(object? sender, EventArgs e)
        {
            var selectedCount = _selectedSeats.Count(selected => selected);
            if (selectedCount == 0)
            {
                MessageBox.Show("Vui lòng chọn ít nhất một vị trí.", "Chưa chọn vị trí", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            foreach (var seatIndex in Enumerable.Range(0, SeatCount).Where(index => _selectedSeats[index]))
            {
                _lockedSeats.Add(seatIndex);
                _selectedSeats[seatIndex] = false;
                UpdateSeatButton(seatIndex);
            }

            UpdateSummary();
            MessageBox.Show("Đặt vị trí thành công.", "Xác nhận", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void ClearSelection()
        {
            for (var seatIndex = 0; seatIndex < SeatCount; seatIndex++)
            {
                _selectedSeats[seatIndex] = false;
                UpdateSeatButton(seatIndex);
            }

            UpdateSummary();
        }

        private void UpdateSeatButton(int seatIndex)
        {
            var seatButton = _seatButtons[seatIndex];
            var seatName = GetSeatName(seatIndex);
            if (_lockedSeats.Contains(seatIndex))
            {
                seatButton.BackColor = Color.FromArgb(220, 70, 70);
                seatButton.ForeColor = Color.White;
                seatButton.Text = $"{seatName}\nĐã đặt";
            }
            else if (_selectedSeats[seatIndex])
            {
                seatButton.BackColor = Color.FromArgb(76, 175, 80);
                seatButton.ForeColor = Color.White;
                seatButton.Text = $"{seatName}\nĐang chọn";
            }
            else
            {
                seatButton.BackColor = Color.FromArgb(238, 241, 245);
                seatButton.ForeColor = Color.FromArgb(35, 48, 65);
                seatButton.Text = seatName;
            }
        }

        private static string GetSeatName(int seatIndex)
        {
            return $"{(char)('A' + seatIndex / 5)}{seatIndex % 5 + 1}";
        }

        private void UpdateSummary()
        {
            var selectedCount = _selectedSeats.Count(selected => selected);
            var unitPrice = timeSlotComboBox.SelectedIndex == 1 ? EveningPrice : MorningPrice;
            selectedCountLabel.Text = $"Số vị trí đang chọn: {selectedCount}";
            totalPriceLabel.Text = $"Tạm tính tiền: {(selectedCount * unitPrice).ToString("N0")}đ";
        }

        private void seatPreview04_Click(object sender, EventArgs e)
        {

        }

        private void seatPreview10_Click(object sender, EventArgs e)
        {

        }
    }
}
