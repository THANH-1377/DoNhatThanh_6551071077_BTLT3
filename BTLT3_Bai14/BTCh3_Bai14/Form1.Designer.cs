namespace BTCh3_Bai14
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
            btnCapNhat = new Button();
            txtTen = new TextBox();
            lstLopA = new ListBox();
            lstLopB = new ListBox();
            btnQuaPhai = new Button();
            QuaAllPhai = new Button();
            btnQuaTrai = new Button();
            btnQuaAllTrai = new Button();
            btnXoaLopA = new Button();
            btnKetThuc = new Button();
            btnXoaLopB = new Button();
            menuStrip1 = new MenuStrip();
            cậpNhậtToolStripMenuItem = new ToolStripMenuItem();
            hệThốngToolStripMenuItem = new ToolStripMenuItem();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label1.Location = new Point(163, 70);
            label1.Name = "label1";
            label1.Size = new Size(60, 20);
            label1.TabIndex = 0;
            label1.Text = "Tên SV:";
            label1.Click += label1_Click;
            // 
            // btnCapNhat
            // 
            btnCapNhat.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnCapNhat.Location = new Point(554, 65);
            btnCapNhat.Name = "btnCapNhat";
            btnCapNhat.Size = new Size(94, 29);
            btnCapNhat.TabIndex = 1;
            btnCapNhat.Text = "Cập nhật";
            btnCapNhat.UseVisualStyleBackColor = true;
            btnCapNhat.Click += btnCapNhat_Click;
            // 
            // txtTen
            // 
            txtTen.Location = new Point(247, 67);
            txtTen.Name = "txtTen";
            txtTen.Size = new Size(280, 27);
            txtTen.TabIndex = 2;
            // 
            // lstLopA
            // 
            lstLopA.FormattingEnabled = true;
            lstLopA.Location = new Point(163, 117);
            lstLopA.Name = "lstLopA";
            lstLopA.SelectionMode = SelectionMode.MultiExtended;
            lstLopA.Size = new Size(172, 204);
            lstLopA.TabIndex = 3;
            lstLopA.SelectedIndexChanged += lstLopA_SelectedIndexChanged;
            // 
            // lstLopB
            // 
            lstLopB.FormattingEnabled = true;
            lstLopB.Location = new Point(491, 117);
            lstLopB.Name = "lstLopB";
            lstLopB.SelectionMode = SelectionMode.MultiExtended;
            lstLopB.Size = new Size(172, 204);
            lstLopB.TabIndex = 4;
            // 
            // btnQuaPhai
            // 
            btnQuaPhai.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnQuaPhai.Location = new Point(361, 117);
            btnQuaPhai.Name = "btnQuaPhai";
            btnQuaPhai.Size = new Size(94, 29);
            btnQuaPhai.TabIndex = 5;
            btnQuaPhai.Text = ">";
            btnQuaPhai.UseVisualStyleBackColor = true;
            btnQuaPhai.Click += btnQuaPhai_Click;
            // 
            // QuaAllPhai
            // 
            QuaAllPhai.Location = new Point(361, 168);
            QuaAllPhai.Name = "QuaAllPhai";
            QuaAllPhai.Size = new Size(94, 29);
            QuaAllPhai.TabIndex = 6;
            QuaAllPhai.Text = ">>";
            QuaAllPhai.UseVisualStyleBackColor = true;
            QuaAllPhai.Click += button3_Click;
            // 
            // btnQuaTrai
            // 
            btnQuaTrai.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnQuaTrai.Location = new Point(361, 225);
            btnQuaTrai.Name = "btnQuaTrai";
            btnQuaTrai.Size = new Size(94, 29);
            btnQuaTrai.TabIndex = 7;
            btnQuaTrai.Text = "<";
            btnQuaTrai.UseVisualStyleBackColor = true;
            btnQuaTrai.Click += btnQuaTrai_Click;
            // 
            // btnQuaAllTrai
            // 
            btnQuaAllTrai.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnQuaAllTrai.Location = new Point(361, 292);
            btnQuaAllTrai.Name = "btnQuaAllTrai";
            btnQuaAllTrai.Size = new Size(94, 29);
            btnQuaAllTrai.TabIndex = 8;
            btnQuaAllTrai.Text = "<<";
            btnQuaAllTrai.UseVisualStyleBackColor = true;
            btnQuaAllTrai.Click += btnQuaAllTrai_Click;
            // 
            // btnXoaLopA
            // 
            btnXoaLopA.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnXoaLopA.Location = new Point(162, 364);
            btnXoaLopA.Name = "btnXoaLopA";
            btnXoaLopA.Size = new Size(143, 29);
            btnXoaLopA.TabIndex = 9;
            btnXoaLopA.Text = "Xóa lớp A";
            btnXoaLopA.UseVisualStyleBackColor = true;
            btnXoaLopA.Click += btnXoaLopA_Click;
            // 
            // btnKetThuc
            // 
            btnKetThuc.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnKetThuc.Location = new Point(347, 364);
            btnKetThuc.Name = "btnKetThuc";
            btnKetThuc.Size = new Size(143, 29);
            btnKetThuc.TabIndex = 10;
            btnKetThuc.Text = "Kết Thúc";
            btnKetThuc.UseVisualStyleBackColor = true;
            btnKetThuc.Click += btnKetThuc_Click;
            // 
            // btnXoaLopB
            // 
            btnXoaLopB.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnXoaLopB.Location = new Point(519, 364);
            btnXoaLopB.Name = "btnXoaLopB";
            btnXoaLopB.Size = new Size(143, 29);
            btnXoaLopB.TabIndex = 11;
            btnXoaLopB.Text = "Xóa lớp B";
            btnXoaLopB.UseVisualStyleBackColor = true;
            btnXoaLopB.Click += btnXoaLopB_Click;
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(20, 20);
            menuStrip1.Items.AddRange(new ToolStripItem[] { cậpNhậtToolStripMenuItem, hệThốngToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(800, 28);
            menuStrip1.TabIndex = 12;
            menuStrip1.Text = "menuStrip1";
            // 
            // cậpNhậtToolStripMenuItem
            // 
            cậpNhậtToolStripMenuItem.Name = "cậpNhậtToolStripMenuItem";
            cậpNhậtToolStripMenuItem.Size = new Size(85, 24);
            cậpNhậtToolStripMenuItem.Text = "Cập Nhật";
            cậpNhậtToolStripMenuItem.Click += cậpNhậtToolStripMenuItem_Click;
            // 
            // hệThốngToolStripMenuItem
            // 
            hệThốngToolStripMenuItem.Name = "hệThốngToolStripMenuItem";
            hệThốngToolStripMenuItem.Size = new Size(88, 24);
            hệThốngToolStripMenuItem.Text = "Hệ Thống";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 431);
            Controls.Add(btnXoaLopB);
            Controls.Add(btnKetThuc);
            Controls.Add(btnXoaLopA);
            Controls.Add(btnQuaAllTrai);
            Controls.Add(btnQuaTrai);
            Controls.Add(QuaAllPhai);
            Controls.Add(btnQuaPhai);
            Controls.Add(lstLopB);
            Controls.Add(lstLopA);
            Controls.Add(txtTen);
            Controls.Add(btnCapNhat);
            Controls.Add(label1);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            Load += Form1_Load;
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Button btnCapNhat;
        private TextBox txtTen;
        private ListBox lstLopA;
        private ListBox lstLopB;
        private Button btnQuaPhai;
        private Button QuaAllPhai;
        private Button btnQuaTrai;
        private Button btnQuaAllTrai;
        private Button btnXoaLopA;
        private Button btnKetThuc;
        private Button btnXoaLopB;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem cậpNhậtToolStripMenuItem;
        private ToolStripMenuItem hệThốngToolStripMenuItem;
    }
}
