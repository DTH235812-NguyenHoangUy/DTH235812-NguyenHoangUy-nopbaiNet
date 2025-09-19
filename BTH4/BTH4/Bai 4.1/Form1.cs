namespace Bai_4._1
{
    public partial class Form1 : Form
    {
        private object txtN;

        public Form1()
        {
            InitializeComponent();
        }

        private void btnTinh_Click(object sender, EventArgs e)
        {
            if (int.TryParse(textBox1.Text, out int n) && n > 0)
            {
                int sum = n * (n + 1) / 2;
                textBox2.Text = $"S = {sum}";
            }
            else
            {
                textBox2.Text = "Please enter a valid positive integer for n.";
            }
        }
    }
}
