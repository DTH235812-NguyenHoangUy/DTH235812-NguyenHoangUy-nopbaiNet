
namespace Bai2._8
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            btnThuong = new Button();
            btnTich = new Button();
            btnHieu = new Button();
            btnTong = new Button();
            groupBox1 = new GroupBox();
            txtNhapb = new TextBox();
            txtNhapa = new TextBox();
            txtb = new Label();
            txta = new Label();
            label1 = new Label();
            label2 = new Label();
            btnKetQua = new TextBox();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // btnThuong
            // 
            btnThuong.Location = new Point(544, 250);
            btnThuong.Name = "btnThuong";
            btnThuong.Size = new Size(75, 23);
            btnThuong.TabIndex = 11;
            btnThuong.Text = "Thuong";
            btnThuong.UseVisualStyleBackColor = true;
            // 
            // btnTich
            // 
            btnTich.Location = new Point(448, 250);
            btnTich.Name = "btnTich";
            btnTich.Size = new Size(75, 23);
            btnTich.TabIndex = 10;
            btnTich.Text = "Tich";
            btnTich.UseVisualStyleBackColor = true;
            // 
            // btnHieu
            // 
            btnHieu.Location = new Point(367, 250);
            btnHieu.Name = "btnHieu";
            btnHieu.Size = new Size(75, 23);
            btnHieu.TabIndex = 9;
            btnHieu.Text = "Hieu";
            btnHieu.UseVisualStyleBackColor = true;
            btnHieu.Click += btnHieu_Click;
            // 
            // btnTong
            // 
            btnTong.Location = new Point(286, 250);
            btnTong.Name = "btnTong";
            btnTong.Size = new Size(75, 23);
            btnTong.TabIndex = 8;
            btnTong.Text = "Tong";
            btnTong.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(txtNhapb);
            groupBox1.Controls.Add(txtNhapa);
            groupBox1.Controls.Add(txtb);
            groupBox1.Controls.Add(txta);
            groupBox1.Location = new Point(307, 114);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(200, 100);
            groupBox1.TabIndex = 7;
            groupBox1.TabStop = false;
            groupBox1.Text = "Thong Tin:";
            // 
            // txtNhapb
            // 
            txtNhapb.Location = new Point(84, 35);
            txtNhapb.Name = "txtNhapb";
            txtNhapb.Size = new Size(100, 23);
            txtNhapb.TabIndex = 3;
            // 
            // txtNhapa
            // 
            txtNhapa.Location = new Point(84, 16);
            txtNhapa.Name = "txtNhapa";
            txtNhapa.Size = new Size(100, 23);
            txtNhapa.TabIndex = 2;
            // 
            // txtb
            // 
            txtb.AutoSize = true;
            txtb.Location = new Point(28, 43);
            txtb.Name = "txtb";
            txtb.Size = new Size(17, 15);
            txtb.TabIndex = 1;
            txtb.Text = "b:";
            txtb.Click += txtb_Click;
            // 
            // txta
            // 
            txta.AutoSize = true;
            txta.Location = new Point(28, 19);
            txta.Name = "txta";
            txta.Size = new Size(16, 15);
            txta.TabIndex = 0;
            txta.Text = "a:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 20F);
            label1.Location = new Point(302, 43);
            label1.Name = "label1";
            label1.Size = new Size(156, 37);
            label1.TabIndex = 6;
            label1.Text = "PHEP TOAN";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(351, 221);
            label2.Name = "label2";
            label2.Size = new Size(49, 15);
            label2.TabIndex = 12;
            label2.Text = "ket qua:";
            // 
            // btnKetQua
            // 
            btnKetQua.Location = new Point(417, 218);
            btnKetQua.Multiline = true;
            btnKetQua.Name = "btnKetQua";
            btnKetQua.ScrollBars = ScrollBars.Vertical;
            btnKetQua.Size = new Size(100, 23);
            btnKetQua.TabIndex = 13;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnKetQua);
            Controls.Add(label2);
            Controls.Add(btnThuong);
            Controls.Add(btnTich);
            Controls.Add(btnHieu);
            Controls.Add(btnTong);
            Controls.Add(groupBox1);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Bai2.8";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        private void txtb_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        #endregion

        private Button btnThuong;
        private Button btnTich;
        private Button btnHieu;
        private Button btnTong;
        private GroupBox groupBox1;
        private TextBox txtNhapb;
        private TextBox txtNhapa;
        private Label txtb;
        private Label txta;
        private Label label1;
        private Label label2;
        private TextBox btnKetQua;
    }
}
