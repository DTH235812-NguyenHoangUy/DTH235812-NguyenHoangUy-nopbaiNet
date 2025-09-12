namespace Bai2._7
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
            btnTong = new Button();
            btnThongtin = new GroupBox();
            txtb = new TextBox();
            txta = new TextBox();
            labelb = new Label();
            labela = new Label();
            label2 = new Label();
            label1 = new Label();
            textBox3 = new TextBox();
            btnKetqua = new Label();
            btnThongtin.SuspendLayout();
            SuspendLayout();
            // 
            // btnTong
            // 
            btnTong.Location = new Point(317, 286);
            btnTong.Name = "btnTong";
            btnTong.Size = new Size(165, 50);
            btnTong.TabIndex = 7;
            btnTong.Text = "Tong";
            btnTong.UseVisualStyleBackColor = true;
            btnTong.Click += btnTong_Click;
            // 
            // btnThongtin
            // 
            btnThongtin.Controls.Add(txtb);
            btnThongtin.Controls.Add(txta);
            btnThongtin.Controls.Add(labelb);
            btnThongtin.Controls.Add(labela);
            btnThongtin.Location = new Point(255, 77);
            btnThongtin.Name = "btnThongtin";
            btnThongtin.Size = new Size(290, 127);
            btnThongtin.TabIndex = 6;
            btnThongtin.TabStop = false;
            btnThongtin.Text = "Thong tin";
            // 
            // txtb
            // 
            txtb.Location = new Point(83, 39);
            txtb.Name = "txtb";
            txtb.Size = new Size(100, 23);
            txtb.TabIndex = 3;
            // 
            // txta
            // 
            txta.Location = new Point(83, 17);
            txta.Name = "txta";
            txta.Size = new Size(100, 23);
            txta.TabIndex = 2;
            // 
            // labelb
            // 
            labelb.AutoSize = true;
            labelb.Location = new Point(30, 47);
            labelb.Name = "labelb";
            labelb.Size = new Size(17, 15);
            labelb.TabIndex = 1;
            labelb.Text = "b:";
            // 
            // labela
            // 
            labela.AutoSize = true;
            labela.Location = new Point(30, 20);
            labela.Name = "labela";
            labela.Size = new Size(16, 15);
            labela.TabIndex = 0;
            labela.Text = "a:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 32F);
            label2.Location = new Point(289, 2);
            label2.Name = "label2";
            label2.Size = new Size(222, 59);
            label2.TabIndex = 5;
            label2.Text = "Phep Toan";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(329, 35);
            label1.Name = "label1";
            label1.Size = new Size(0, 15);
            label1.TabIndex = 4;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(349, 235);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(100, 23);
            textBox3.TabIndex = 8;
            // 
            // btnKetqua
            // 
            btnKetqua.AutoSize = true;
            btnKetqua.Location = new Point(298, 238);
            btnKetqua.Name = "btnKetqua";
            btnKetqua.Size = new Size(50, 15);
            btnKetqua.TabIndex = 9;
            btnKetqua.Text = "Ket qua:";
            btnKetqua.Click += label3_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnKetqua);
            Controls.Add(textBox3);
            Controls.Add(btnTong);
            Controls.Add(btnThongtin);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            btnThongtin.ResumeLayout(false);
            btnThongtin.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnTong;
        private GroupBox btnThongtin;
        private TextBox txtb;
        private TextBox txta;
        private Label labelb;
        private Label labela;
        private Label label2;
        private Label label1;
        private TextBox textBox3;
        private Label btnKetqua;
    }
}
