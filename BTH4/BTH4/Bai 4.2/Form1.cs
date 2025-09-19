namespace Bai_4._2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void btnTinh_Click_1(object sender, EventArgs e)
        {

        }
        private void btnTinh_TextChanged(object sender, EventArgs e)
        {

        }
        private void btnTinh_Click(object sender, EventArgs e)
        {
            if (int.TryParse(textBox1.Text, out int n) && n > 0)
            {
                int sum = 0;
                for (int i = 1; i <= n; i++)
                {
                    sum += i * i;
                }
                textBox2.Text = $"S = {sum}";
            }
            else
            {
                textBox2.Text = "Please enter a valid positive integer for n.";
            }
        }
    }
}


