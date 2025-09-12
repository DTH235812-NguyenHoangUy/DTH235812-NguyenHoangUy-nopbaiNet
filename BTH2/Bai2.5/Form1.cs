namespace Bai2._5
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void btnTong_Click(object sender, EventArgs e)
        {
            if (int.TryParse(textBox1.Text.Trim(), out int a) && int.TryParse(textBox2.Text.Trim(), out int b))
            {
                int tong = a + b;
                MessageBox.Show($"Tong cua {a} va {b} la: {tong}");
            }
            else
            {
                MessageBox.Show("Vui long nhap hai so nguyen hop le.");
            }
        }
    }
}
