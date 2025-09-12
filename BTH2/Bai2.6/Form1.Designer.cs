namespace Bai2._6
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
            label1 = new Label();
            groupBox1 = new GroupBox();
            txtNhapb = new TextBox();
            txtNhapa = new TextBox();
            txtb = new Label();
            txta = new Label();
            btnTong = new Button();
            btnHieu = new Button();
            btnTich = new Button();
            btnThuong = new Button();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 20F);
            label1.Location = new Point(326, 44);
            label1.Name = "label1";
            label1.Size = new Size(156, 37);
            label1.TabIndex = 0;
            label1.Text = "PHEP TOAN";
            label1.Click += label1_Click;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(txtNhapb);
            groupBox1.Controls.Add(txtNhapa);
            groupBox1.Controls.Add(txtb);
            groupBox1.Controls.Add(txta);
            groupBox1.Location = new Point(331, 115);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(200, 100);
            groupBox1.TabIndex = 1;
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
            // btnTong
            // 
            btnTong.Location = new Point(316, 221);
            btnTong.Name = "btnTong";
            btnTong.Size = new Size(75, 23);
            btnTong.TabIndex = 2;
            btnTong.Text = "Tong";
            btnTong.UseVisualStyleBackColor = true;
            btnTong.Click += btnTong_Click;
            // 
            // btnHieu
            // 
            btnHieu.Location = new Point(399, 221);
            btnHieu.Name = "btnHieu";
            btnHieu.Size = new Size(75, 23);
            btnHieu.TabIndex = 3;
            btnHieu.Text = "Hieu";
            btnHieu.UseVisualStyleBackColor = true;
            btnHieu.Click += btnHieu_Click;
            // 
            // btnTich
            // 
            btnTich.Location = new Point(490, 220);
            btnTich.Name = "btnTich";
            btnTich.Size = new Size(75, 23);
            btnTich.TabIndex = 4;
            btnTich.Text = "Tich";
            btnTich.UseVisualStyleBackColor = true;
            btnTich.Click += btnTich_Click;
            // 
            // btnThuong
            // 
            btnThuong.Location = new Point(588, 221);
            btnThuong.Name = "btnThuong";
            btnThuong.Size = new Size(75, 23);
            btnThuong.TabIndex = 5;
            btnThuong.Text = "Thuong";
            btnThuong.UseVisualStyleBackColor = true;
            btnThuong.Click += btnThuong_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnThuong);
            Controls.Add(btnTich);
            Controls.Add(btnHieu);
            Controls.Add(btnTong);
            Controls.Add(groupBox1);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private GroupBox groupBox1;
        private TextBox txtNhapb;
        private TextBox txtNhapa;
        private Label txtb;
        private Label txta;
        private Button btnTong;
        private Button btnHieu;
        private Button btnTich;
        private Button btnThuong;
    }
}
