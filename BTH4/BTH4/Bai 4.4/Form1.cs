namespace Bai_4._4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnTinh_Click(object sender, EventArgs e)
        {
            int n;
            if (int.TryParse(textBox1.Text, out n) && n >= 0)
            {
                // Tính tổng S = (n+1)^2
                int S = (n + 1) * (n + 1);

                // Gán kết quả vào textBox2
                textBox2.Text = S.ToString();
            }
            else
            {
                MessageBox.Show("Vui lòng nhập một số nguyên không âm hợp lệ!");
            }
        }
    }
}
