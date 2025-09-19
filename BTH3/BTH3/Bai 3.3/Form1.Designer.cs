namespace Bai_3._3
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
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            textBox3 = new TextBox();
            btnKiemTra = new Button();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 16F);
            label1.Location = new Point(309, 40);
            label1.Name = "label1";
            label1.Size = new Size(247, 30);
            label1.TabIndex = 0;
            label1.Text = "KIEM TRA NGAY HOP LE";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(textBox3);
            groupBox1.Controls.Add(textBox2);
            groupBox1.Controls.Add(textBox1);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label2);
            groupBox1.Location = new Point(325, 73);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(200, 100);
            groupBox1.TabIndex = 1;
            groupBox1.TabStop = false;
            groupBox1.Text = "Thong tin";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(20, 20);
            label2.Name = "label2";
            label2.Size = new Size(38, 15);
            label2.TabIndex = 0;
            label2.Text = "Ngay:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(20, 35);
            label3.Name = "label3";
            label3.Size = new Size(43, 15);
            label3.TabIndex = 1;
            label3.Text = "Thang:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(20, 50);
            label4.Name = "label4";
            label4.Size = new Size(36, 15);
            label4.TabIndex = 2;
            label4.Text = "Nam:";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(69, 12);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(70, 23);
            textBox1.TabIndex = 3;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(69, 32);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(70, 23);
            textBox2.TabIndex = 4;
            textBox2.TextChanged += textBox2_TextChanged;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(69, 50);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(70, 23);
            textBox3.TabIndex = 5;
            // 
            // btnKiemTra
            // 
            btnKiemTra.Location = new Point(367, 180);
            btnKiemTra.Name = "btnKiemTra";
            btnKiemTra.Size = new Size(75, 23);
            btnKiemTra.TabIndex = 2;
            btnKiemTra.Text = "Kiem tra";
            btnKiemTra.UseVisualStyleBackColor = true;
            btnKiemTra.Click += btnKiemTra_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnKiemTra);
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
        private Label label4;
        private Label label3;
        private Label label2;
        private TextBox textBox2;
        private TextBox textBox1;
        private TextBox textBox3;
        private Button btnKiemTra;
    }
}
