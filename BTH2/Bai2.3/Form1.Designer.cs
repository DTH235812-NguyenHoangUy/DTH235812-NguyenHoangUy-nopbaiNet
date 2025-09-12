namespace Bai2._3
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
            btnHienThi = new Button();
            SuspendLayout();
            // 
            // btnHienThi
            // 
            btnHienThi.Location = new Point(275, 99);
            btnHienThi.Name = "btnHienThi";
            btnHienThi.Size = new Size(194, 57);
            btnHienThi.TabIndex = 0;
            btnHienThi.Text = "Hien Thi";
            btnHienThi.UseVisualStyleBackColor = true;
            btnHienThi.Click += button1_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnHienThi);
            Name = "Form1";
            Text = "Bai 2.3";
            Load += Form1_Load;
            ResumeLayout(false);
        }

        #endregion

        private Button btnHienThi;
    }
}
