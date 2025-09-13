namespace Bai2._8
{
    public partial class Form1 : Form
    {
        // Change the type of txtKetQua from object to TextBox
        private TextBox txtKetQua;

        public Form1(TextBox txtKetQua)
        {
            this.txtKetQua = txtKetQua;
        }

        public Form1()
        {
            InitializeComponent();
        }

        private void btnTong_Click(object sender, EventArgs e)
        {
            float a = float.Parse(txta.Text);
            float b = float.Parse(txtb.Text);
            float tong = a + b;
            txtKetQua.Text = tong.ToString();
        }

        private void btnHieu_Click(object sender, EventArgs e)
        {
            float a = float.Parse(txta.Text);
            float b = float.Parse(txtb.Text);
            float hieu = a - b;
            txtKetQua.Text = hieu.ToString();
        }

        private void btnTich_Click(object sender, EventArgs e)
        {
            float a = float.Parse(txta.Text);
            float b = float.Parse(txtb.Text);
            float tich = a * b;
            txtKetQua.Text = tich.ToString();
        }

        private void btnThuong_Click(object sender, EventArgs e)
        {
            float a = float.Parse(txta.Text);
            float b = float.Parse(txtb.Text);
            if (b != 0)
                txtKetQua.Text = (a / b).ToString();
            else
                txtKetQua.Text = "Không chia được cho 0";
        }
    }
}