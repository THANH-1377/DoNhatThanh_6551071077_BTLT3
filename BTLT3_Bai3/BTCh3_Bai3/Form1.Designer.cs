namespace BTCh3_Bai3
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
            btnKetThuc = new Button();
            btnHo = new Button();
            btnTen = new Button();
            btnHoTen = new Button();
            txtHo = new TextBox();
            txtTen = new TextBox();
            lblHoTen = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(122, 95);
            label1.Name = "label1";
            label1.Size = new Size(51, 20);
            label1.TabIndex = 0;
            label1.Text = "Họ lót";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(122, 159);
            label2.Name = "label2";
            label2.Size = new Size(32, 20);
            label2.TabIndex = 1;
            label2.Text = "Tên";
            // 
            // btnKetThuc
            // 
            btnKetThuc.Location = new Point(217, 289);
            btnKetThuc.Name = "btnKetThuc";
            btnKetThuc.Size = new Size(150, 39);
            btnKetThuc.TabIndex = 2;
            btnKetThuc.Text = "Thoát chương trình";
            btnKetThuc.UseVisualStyleBackColor = true;
            btnKetThuc.Click += btnThoat_Click;
            // 
            // btnHo
            // 
            btnHo.Location = new Point(78, 221);
            btnHo.Name = "btnHo";
            btnHo.Size = new Size(94, 29);
            btnHo.TabIndex = 3;
            btnHo.Text = "Họ lót";
            btnHo.UseVisualStyleBackColor = true;
            btnHo.Click += btnHo_Click;
            // 
            // btnTen
            // 
            btnTen.Location = new Point(248, 221);
            btnTen.Name = "btnTen";
            btnTen.Size = new Size(94, 29);
            btnTen.TabIndex = 4;
            btnTen.Text = "Ten";
            btnTen.UseVisualStyleBackColor = true;
            btnTen.Click += btnTen_Click;
            // 
            // btnHoTen
            // 
            btnHoTen.Location = new Point(427, 221);
            btnHoTen.Name = "btnHoTen";
            btnHoTen.Size = new Size(94, 29);
            btnHoTen.TabIndex = 5;
            btnHoTen.Text = "Họ và tên";
            btnHoTen.UseVisualStyleBackColor = true;
            btnHoTen.Click += btnHoTen_Click;
            // 
            // txtHo
            // 
            txtHo.Location = new Point(217, 95);
            txtHo.Name = "txtHo";
            txtHo.Size = new Size(181, 27);
            txtHo.TabIndex = 6;
            // 
            // txtTen
            // 
            txtTen.BackColor = Color.RosyBrown;
            txtTen.ForeColor = Color.Black;
            txtTen.Location = new Point(217, 159);
            txtTen.Name = "txtTen";
            txtTen.Size = new Size(181, 27);
            txtTen.TabIndex = 7;
            // 
            // lblHoTen
            // 
            lblHoTen.BackColor = Color.SteelBlue;
            lblHoTen.Location = new Point(0, -2);
            lblHoTen.Name = "lblHoTen";
            lblHoTen.Size = new Size(604, 69);
            lblHoTen.TabIndex = 8;
            lblHoTen.Click += lblHoTen_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(605, 350);
            Controls.Add(lblHoTen);
            Controls.Add(txtTen);
            Controls.Add(txtHo);
            Controls.Add(btnHoTen);
            Controls.Add(btnTen);
            Controls.Add(btnHo);
            Controls.Add(btnKetThuc);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Bài Tập Họ Tên";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Button btnKetThuc;
        private Button btnHo;
        private Button btnTen;
        private Button btnHoTen;
        private TextBox txtHo;
        private TextBox txtTen;
        private Label lblHoTen;
    }
}
