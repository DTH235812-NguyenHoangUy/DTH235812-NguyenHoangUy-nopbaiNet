namespace Bai2._5
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
            label2 = new Label();
            btnThongtin = new GroupBox();
            labela = new Label();
            labelb = new Label();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            btnTong = new Button();
            btnThongtin.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(336, 42);
            label1.Name = "label1";
            label1.Size = new Size(0, 15);
            label1.TabIndex = 0;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 32F);
            label2.Location = new Point(296, 9);
            label2.Name = "label2";
            label2.Size = new Size(222, 59);
            label2.TabIndex = 1;
            label2.Text = "Phep Toan";
            label2.Click += label2_Click;
            // 
            // btnThongtin
            // 
            btnThongtin.Controls.Add(textBox2);
            btnThongtin.Controls.Add(textBox1);
            btnThongtin.Controls.Add(labelb);
            btnThongtin.Controls.Add(labela);
            btnThongtin.Location = new Point(307, 84);
            btnThongtin.Name = "btnThongtin";
            btnThongtin.Size = new Size(200, 100);
            btnThongtin.TabIndex = 2;
            btnThongtin.TabStop = false;
            btnThongtin.Text = "Thong tin";
            btnThongtin.Enter += groupBox1_Enter;
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
            // labelb
            // 
            labelb.AutoSize = true;
            labelb.Location = new Point(30, 47);
            labelb.Name = "labelb";
            labelb.Size = new Size(17, 15);
            labelb.TabIndex = 1;
            labelb.Text = "b:";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(83, 17);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(100, 23);
            textBox1.TabIndex = 2;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(83, 39);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(100, 23);
            textBox2.TabIndex = 3;
            // 
            // btnTong
            // 
            btnTong.Location = new Point(378, 204);
            btnTong.Name = "btnTong";
            btnTong.Size = new Size(75, 23);
            btnTong.TabIndex = 3;
            btnTong.Text = "Tong";
            btnTong.UseVisualStyleBackColor = true;
            btnTong.Click += btnTong_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnTong);
            Controls.Add(btnThongtin);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Bai 2.5";
            btnThongtin.ResumeLayout(false);
            btnThongtin.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private GroupBox btnThongtin;
        private TextBox textBox2;
        private TextBox textBox1;
        private Label labelb;
        private Label labela;
        private Button btnTong;
    }
}
