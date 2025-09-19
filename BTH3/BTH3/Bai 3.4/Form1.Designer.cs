namespace Bai_3._4
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
            label5 = new Label();
            btnKetQua = new TextBox();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 16F);
            label1.Location = new Point(327, 50);
            label1.Name = "label1";
            label1.Size = new Size(285, 30);
            label1.TabIndex = 0;
            label1.Text = "GIAI PHUONG TRINH BAC 2";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(textBox3);
            groupBox1.Controls.Add(textBox2);
            groupBox1.Controls.Add(textBox1);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label2);
            groupBox1.Location = new Point(351, 94);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(200, 100);
            groupBox1.TabIndex = 1;
            groupBox1.TabStop = false;
            groupBox1.Text = "Phuong Trinh";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(18, 19);
            label2.Name = "label2";
            label2.Size = new Size(16, 15);
            label2.TabIndex = 0;
            label2.Text = "a:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(18, 34);
            label3.Name = "label3";
            label3.Size = new Size(17, 15);
            label3.TabIndex = 1;
            label3.Text = "b:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(18, 49);
            label4.Name = "label4";
            label4.Size = new Size(16, 15);
            label4.TabIndex = 2;
            label4.Text = "c:";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(55, 16);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(50, 23);
            textBox1.TabIndex = 3;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(55, 34);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(50, 23);
            textBox2.TabIndex = 4;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(55, 49);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(50, 23);
            textBox3.TabIndex = 5;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(352, 203);
            label5.Name = "label5";
            label5.Size = new Size(50, 15);
            label5.TabIndex = 2;
            label5.Text = "Ket qua:";
            // 
            // btnKetQua
            // 
            btnKetQua.Location = new Point(406, 200);
            btnKetQua.Name = "btnKetQua";
            btnKetQua.Size = new Size(166, 23);
            btnKetQua.TabIndex = 3;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnKetQua);
            Controls.Add(label5);
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
        private TextBox textBox3;
        private TextBox textBox2;
        private TextBox textBox1;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label5;
        private TextBox btnKetQua;
    }
}
