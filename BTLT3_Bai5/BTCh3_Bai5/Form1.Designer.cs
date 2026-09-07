namespace BTCh3_Bai5
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
            txtNhapTen = new TextBox();
            radRed = new RadioButton();
            radGreen = new RadioButton();
            radBlue = new RadioButton();
            radBlack = new RadioButton();
            chkBold = new CheckBox();
            checkBox2 = new CheckBox();
            chkUnderline = new CheckBox();
            label2 = new Label();
            btnThoat = new Button();
            lblLapTrinh = new Label();
            groupBox1 = new GroupBox();
            groupBox2 = new GroupBox();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Black;
            label1.ForeColor = Color.Green;
            label1.Location = new Point(140, 64);
            label1.Name = "label1";
            label1.Size = new Size(70, 20);
            label1.TabIndex = 0;
            label1.Text = "Nhập tên";
            label1.Click += label1_Click;
            // 
            // txtNhapTen
            // 
            txtNhapTen.Location = new Point(249, 57);
            txtNhapTen.Name = "txtNhapTen";
            txtNhapTen.Size = new Size(125, 27);
            txtNhapTen.TabIndex = 1;
            txtNhapTen.TextChanged += txtNhapTen_TextChanged;
            // 
            // radRed
            // 
            radRed.AutoSize = true;
            radRed.Checked = true;
            radRed.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            radRed.ForeColor = Color.Red;
            radRed.Location = new Point(55, 37);
            radRed.Name = "radRed";
            radRed.Size = new Size(62, 27);
            radRed.TabIndex = 2;
            radRed.TabStop = true;
            radRed.Text = "Red";
            radRed.UseVisualStyleBackColor = true;
            radRed.CheckedChanged += radRed_CheckedChanged;
            // 
            // radGreen
            // 
            radGreen.AutoSize = true;
            radGreen.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            radGreen.ForeColor = Color.Green;
            radGreen.Location = new Point(55, 81);
            radGreen.Name = "radGreen";
            radGreen.Size = new Size(78, 27);
            radGreen.TabIndex = 3;
            radGreen.TabStop = true;
            radGreen.Text = "Green";
            radGreen.UseVisualStyleBackColor = true;
            radGreen.CheckedChanged += radGreen_CheckedChanged;
            // 
            // radBlue
            // 
            radBlue.AutoSize = true;
            radBlue.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            radBlue.ForeColor = Color.Blue;
            radBlue.Location = new Point(55, 124);
            radBlue.Name = "radBlue";
            radBlue.Size = new Size(66, 27);
            radBlue.TabIndex = 4;
            radBlue.TabStop = true;
            radBlue.Text = "Blue";
            radBlue.UseVisualStyleBackColor = true;
            radBlue.CheckedChanged += radBlue_CheckedChanged;
            // 
            // radBlack
            // 
            radBlack.AutoSize = true;
            radBlack.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            radBlack.ForeColor = Color.Black;
            radBlack.Location = new Point(55, 167);
            radBlack.Name = "radBlack";
            radBlack.Size = new Size(74, 27);
            radBlack.TabIndex = 5;
            radBlack.TabStop = true;
            radBlack.Text = "Black";
            radBlack.UseVisualStyleBackColor = true;
            radBlack.CheckedChanged += radBlack_CheckedChanged;
            // 
            // chkBold
            // 
            chkBold.AutoSize = true;
            chkBold.Font = new Font("Microsoft Sans Serif", 10F, FontStyle.Bold);
            chkBold.ForeColor = Color.RoyalBlue;
            chkBold.Location = new Point(39, 45);
            chkBold.Name = "chkBold";
            chkBold.Size = new Size(113, 24);
            chkBold.TabIndex = 6;
            chkBold.Text = "Đậm Bold";
            chkBold.UseVisualStyleBackColor = true;
            chkBold.CheckedChanged += chkBold_CheckedChanged;
            // 
            // checkBox2
            // 
            checkBox2.AutoSize = true;
            checkBox2.Font = new Font("Microsoft Sans Serif", 10F, FontStyle.Bold | FontStyle.Italic);
            checkBox2.ForeColor = Color.RoyalBlue;
            checkBox2.Location = new Point(39, 104);
            checkBox2.Name = "checkBox2";
            checkBox2.Size = new Size(146, 24);
            checkBox2.TabIndex = 7;
            checkBox2.Text = "Nghiêng Italic";
            checkBox2.UseVisualStyleBackColor = true;
            checkBox2.CheckedChanged += checkBox2_CheckedChanged;
            // 
            // chkUnderline
            // 
            chkUnderline.AutoSize = true;
            chkUnderline.Font = new Font("Microsoft Sans Serif", 10F, FontStyle.Bold | FontStyle.Underline);
            chkUnderline.ForeColor = Color.RoyalBlue;
            chkUnderline.Location = new Point(39, 152);
            chkUnderline.Name = "chkUnderline";
            chkUnderline.Size = new Size(121, 24);
            chkUnderline.TabIndex = 8;
            chkUnderline.Text = "Gạch chân";
            chkUnderline.UseVisualStyleBackColor = true;
            chkUnderline.CheckedChanged += chkUnderline_CheckedChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 10F);
            label2.ForeColor = Color.Brown;
            label2.Location = new Point(74, 357);
            label2.Name = "label2";
            label2.Size = new Size(118, 23);
            label2.TabIndex = 9;
            label2.Text = "Lập Trình Bởi: ";
            // 
            // btnThoat
            // 
            btnThoat.Location = new Point(347, 351);
            btnThoat.Name = "btnThoat";
            btnThoat.Size = new Size(94, 29);
            btnThoat.TabIndex = 11;
            btnThoat.Text = "Thoát";
            btnThoat.UseVisualStyleBackColor = true;
            btnThoat.Click += btnThoat_Click;
            // 
            // lblLapTrinh
            // 
            lblLapTrinh.BackColor = Color.Gray;
            lblLapTrinh.Location = new Point(198, 355);
            lblLapTrinh.Name = "lblLapTrinh";
            lblLapTrinh.Size = new Size(143, 30);
            lblLapTrinh.TabIndex = 12;
            // 
            // groupBox1
            // 
            groupBox1.BackColor = SystemColors.ActiveCaption;
            groupBox1.Controls.Add(radRed);
            groupBox1.Controls.Add(radGreen);
            groupBox1.Controls.Add(radBlue);
            groupBox1.Controls.Add(radBlack);
            groupBox1.Location = new Point(49, 122);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(233, 212);
            groupBox1.TabIndex = 13;
            groupBox1.TabStop = false;
            groupBox1.Text = "Color";
            groupBox1.Enter += groupBox1_Enter;
            // 
            // groupBox2
            // 
            groupBox2.BackColor = Color.AntiqueWhite;
            groupBox2.Controls.Add(checkBox2);
            groupBox2.Controls.Add(chkBold);
            groupBox2.Controls.Add(chkUnderline);
            groupBox2.Location = new Point(325, 122);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(233, 212);
            groupBox2.TabIndex = 14;
            groupBox2.TabStop = false;
            groupBox2.Text = "Font";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(587, 419);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Controls.Add(lblLapTrinh);
            Controls.Add(btnThoat);
            Controls.Add(label2);
            Controls.Add(txtNhapTen);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox txtNhapTen;
        private RadioButton radRed;
        private RadioButton radGreen;
        private RadioButton radBlue;
        private RadioButton radBlack;
        private CheckBox chkBold;
        private CheckBox checkBox2;
        private CheckBox chkUnderline;
        private Label label2;
        private Button btnThoat;
        private Label lblLapTrinh;
        private GroupBox groupBox1;
        private GroupBox groupBox2;
    }
}
