namespace Bai_4._3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnTinh_Click(object sender, EventArgs e)
        {
            if (int.TryParse(textBox1.Text, out int n) && n > 0)
            {
                double sum = 0;
                for (int i = 1; i <= n; i++)
                {
                    sum += 1.0 / i;
                }
                textBox2.Text = sum.ToString();
            }
            else
            {
                MessageBox.Show("Please enter a valid positive integer in TextBox 1.");
            }
        }
    }
}
