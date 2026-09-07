namespace BTCh3_Bai1
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
            Password = new Label();
            HienThi = new Label();
            txtNhapPassword = new TextBox();
            txtHienThi = new TextBox();
            backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            btnHienThi = new Button();
            btnTiep = new Button();
            btnDong = new Button();
            SuspendLayout();
            // 
            // Password
            // 
            Password.AutoSize = true;
            Password.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            Password.Location = new Point(102, 90);
            Password.Name = "Password";
            Password.Size = new Size(118, 20);
            Password.TabIndex = 0;
            Password.Text = "Nhập password";
            Password.Click += label1_Click;
            // 
            // HienThi
            // 
            HienThi.AutoSize = true;
            HienThi.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            HienThi.Location = new Point(129, 137);
            HienThi.Name = "HienThi";
            HienThi.Size = new Size(64, 20);
            HienThi.TabIndex = 1;
            HienThi.Text = "Hiển thị";
            // 
            // txtNhapPassword
            // 
            txtNhapPassword.Font = new Font("Segoe UI", 9F);
            txtNhapPassword.Location = new Point(220, 83);
            txtNhapPassword.Name = "txtNhapPassword";
            txtNhapPassword.PasswordChar = '*';
            txtNhapPassword.Size = new Size(141, 27);
            txtNhapPassword.TabIndex = 2;
            txtNhapPassword.TextChanged += textBox1_TextChanged;
            // 
            // txtHienThi
            // 
            txtHienThi.Location = new Point(220, 137);
            txtHienThi.Name = "txtHienThi";
            txtHienThi.Size = new Size(141, 27);
            txtHienThi.TabIndex = 3;
            // 
            // btnHienThi
            // 
            btnHienThi.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnHienThi.Location = new Point(85, 204);
            btnHienThi.Name = "btnHienThi";
            btnHienThi.Size = new Size(94, 29);
            btnHienThi.TabIndex = 4;
            btnHienThi.Text = "Hiển thị";
            btnHienThi.UseVisualStyleBackColor = true;
            btnHienThi.Click += btnHienThi_Click;
            // 
            // btnTiep
            // 
            btnTiep.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnTiep.Location = new Point(225, 204);
            btnTiep.Name = "btnTiep";
            btnTiep.Size = new Size(94, 29);
            btnTiep.TabIndex = 5;
            btnTiep.Text = "Tiếp";
            btnTiep.UseVisualStyleBackColor = true;
            btnTiep.Click += btnTiep_Click;
            // 
            // btnDong
            // 
            btnDong.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnDong.Location = new Point(359, 204);
            btnDong.Name = "btnDong";
            btnDong.Size = new Size(94, 29);
            btnDong.TabIndex = 6;
            btnDong.Text = "Đóng";
            btnDong.UseVisualStyleBackColor = true;
            btnDong.Click += btnDong_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(532, 268);
            Controls.Add(btnDong);
            Controls.Add(btnTiep);
            Controls.Add(btnHienThi);
            Controls.Add(txtHienThi);
            Controls.Add(txtNhapPassword);
            Controls.Add(HienThi);
            Controls.Add(Password);
            Name = "Form1";
            Text = "Sử dụng Label và Textbox";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label Password;
        private Label HienThi;
        private TextBox txtNhapPassword;
        private TextBox txtHienThi;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private Button btnHienThi;
        private Button btnTiep;
        private Button btnDong;
    }
}
