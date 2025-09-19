namespace Bai_3._2
{
    public partial class Form1 : Form
    {
        private Button button1;

        public Form1()
        {
            InitializeComponent();

            // Add button for checking season
            button1 = new Button
            {
                Text = "Kiểm tra mùa",
                Location = new Point(339, 140),
                Size = new Size(100, 30)
            };
            button1.Click += button1_Click;
            Controls.Add(button1);

            label2.Text = "Nhập tháng (1-12):";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (int.TryParse(textBox1.Text, out int month) && month >= 1 && month <= 12)
            {
                string season = month switch
                {
                    1 or 2 or 3 => "Mùa Xuân",
                    4 or 5 or 6 => "Mùa Hạ",
                    7 or 8 or 9 => "Mùa Thu",
                    10 or 11 or 12 => "Mùa Đông",
                    _ => "Không xác định"
                };
                MessageBox.Show($"Tháng {month} thuộc {season}");
            }
            else
            {
                MessageBox.Show("Vui lòng nhập tháng hợp lệ (1-12).");
            }
        }
    }
}
