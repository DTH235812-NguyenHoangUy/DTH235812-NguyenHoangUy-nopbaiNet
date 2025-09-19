namespace Bai_3._4
{
    public partial class Form1 : Form
    {
        private Button btnGiai;

        public Form1()
        {
            InitializeComponent();

            // Add button for solving the equation
            btnGiai = new Button
            {
                Text = "Giải",
                Location = new Point(120, 70),
                Size = new Size(60, 30)
            };
            btnGiai.Click += btnGiai_Click;
            groupBox1.Controls.Add(btnGiai);

            label5.Text = "";
        }

        private void btnGiai_Click(object sender, EventArgs e)
        {
            bool isAValid = double.TryParse(textBox1.Text, out double a);
            bool isBValid = double.TryParse(textBox2.Text, out double b);
            bool isCValid = double.TryParse(textBox3.Text, out double c);

            if (!isAValid || !isBValid || !isCValid)
            {
                label5.Text = "Vui lòng nhập a, b, c là số hợp lệ.";
                return;
            }

            if (a == 0)
            {
                if (b == 0)
                {
                    label5.Text = c == 0 ? "Phương trình vô số nghiệm." : "Phương trình vô nghiệm.";
                }
                else
                {
                    double x = -c / b;
                    label5.Text = $"Phương trình có một nghiệm: x = {x}";
                }
                return;
            }

            double delta = b * b - 4 * a * c;
            if (delta < 0)
            {
                label5.Text = "Phương trình vô nghiệm.";
            }
            else if (delta == 0)
            {
                double x = -b / (2 * a);
                label5.Text = $"Phương trình có nghiệm kép: x = {x}";
            }
            else
            {
                double x1 = (-b + Math.Sqrt(delta)) / (2 * a);
                double x2 = (-b - Math.Sqrt(delta)) / (2 * a);
                label5.Text = $"Phương trình có hai nghiệm:\nx1 = {x1}\nx2 = {x2}";
            }
        }
    }
}
