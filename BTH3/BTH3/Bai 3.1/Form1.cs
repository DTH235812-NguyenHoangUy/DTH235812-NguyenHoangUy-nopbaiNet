namespace Bai_3._1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            textBox1.TextChanged += textBox1_TextChanged;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if (double.TryParse(textBox1.Text, out double x))
            {
                double y;
                if (x >= 2)
                    y = -8 * Math.Pow(x, 3) - 12 * x - 1;
                else if (x > 1)
                    y = Math.Pow(x, 2) - 6 * x - 19;
                else
                    y = 7 * x;

                textBox2.Text = y.ToString();
            }
            else
            {
                textBox2.Text = "";
            }
        }

        private void btnTinh_Click(object sender, EventArgs e)
        {

        }
    }
}
