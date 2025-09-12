namespace Bai2._4
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
            btnHoTen = new Label();
            textBox1 = new TextBox();
            btnHienThi = new Button();
            SuspendLayout();
            // 
            // btnHoTen
            // 
            btnHoTen.AutoSize = true;
            btnHoTen.Location = new Point(277, 120);
            btnHoTen.Name = "btnHoTen";
            btnHoTen.Size = new Size(44, 15);
            btnHoTen.TabIndex = 0;
            btnHoTen.Text = "ho ten:";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(342, 117);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(100, 23);
            textBox1.TabIndex = 1;
            textBox1.TextChanged += textBox1_TextChanged_1;
            // 
            // btnHienThi
            // 
            btnHienThi.Location = new Point(330, 167);
            btnHienThi.Name = "btnHienThi";
            btnHienThi.Size = new Size(75, 23);
            btnHienThi.TabIndex = 2;
            btnHienThi.Text = "Hien Thi";
            btnHienThi.UseVisualStyleBackColor = true;
            btnHienThi.Click += btnHienThi_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnHienThi);
            Controls.Add(textBox1);
            Controls.Add(btnHoTen);
            Name = "Form1";
            Text = "Bai2.4";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label btnHoTen;
        private TextBox textBox1;
        private Button btnHienThi;
    }
}
