namespace Bai_3._3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnKiemTra_Click(object sender, EventArgs e)
        {
            // Lấy giá trị ngày, tháng, năm từ các TextBox
            bool isDayValid = int.TryParse(textBox1.Text, out int day);
            bool isMonthValid = int.TryParse(textBox2.Text, out int month);
            bool isYearValid = int.TryParse(textBox3.Text, out int year);

            if (!isDayValid || !isMonthValid || !isYearValid)
            {
                MessageBox.Show("Vui lòng nhập ngày, tháng, năm là số nguyên hợp lệ.");
                return;
            }

            if (month < 1 || month > 12)
            {
                MessageBox.Show("Tháng không hợp lệ.");
                return;
            }

            int maxDay = month switch
            {
                1 or 3 or 5 or 7 or 8 or 10 or 12 => 31,
                4 or 6 or 9 or 11 => 30,
                2 => (IsLeapYear(year) ? 29 : 28),
                _ => 0
            };

            if (day < 1 || day > maxDay)
            {
                MessageBox.Show("Ngày không hợp lệ.");
            }
            else
            {
                MessageBox.Show("Ngày tháng hợp lệ.");
            }
        }

        private static bool IsLeapYear(int year)
        {
            return (year % 4 == 0 && year % 100 != 0) || (year % 400 == 0);
        }
    }
}
