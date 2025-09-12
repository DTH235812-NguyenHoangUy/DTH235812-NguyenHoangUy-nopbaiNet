namespace Bai2._6
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnTong_Click(object sender, EventArgs e)
        {
            float a = float.Parse(txtNhapa.Text);
            float b = float.Parse(txtNhapb.Text);
            float tong = a + b;
            MessageBox.Show(tong.ToString());
        }

        private void btnHieu_Click(object sender, EventArgs e)
        {
            float a = float.Parse(txtNhapa.Text);
            float b = float.Parse(txtNhapb.Text);
            float hieu = a - b;
            MessageBox.Show(hieu.ToString());
        }

        private void btnTich_Click(object sender, EventArgs e)
        {
            float a = float.Parse(txtNhapa.Text);
            float b = float.Parse(txtNhapb.Text);
            float tich = a * b;
            MessageBox.Show(tich.ToString());
        }

        private void btnThuong_Click(object sender, EventArgs e)
        {
            float a = float.Parse(txtNhapa.Text);
            float b = float.Parse(txtNhapb.Text);
            float thuong = a / b;
            MessageBox.Show(thuong  .ToString());
        }
    }
}
