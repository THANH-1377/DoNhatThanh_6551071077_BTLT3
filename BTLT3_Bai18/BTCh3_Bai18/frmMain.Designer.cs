namespace Bai18
{
    partial class frmMain
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            menuStrip1 = new MenuStrip();
            mnuFile = new ToolStripMenuItem();
            toolStripSeparator1 = new ToolStripSeparator();
            mnuNewChild = new ToolStripMenuItem();
            mnuExit = new ToolStripMenuItem();
            mnuWindow = new ToolStripMenuItem();
            mnuCascade = new ToolStripMenuItem();
            mnuTileHorizontal = new ToolStripMenuItem();
            mnuTileVertical = new ToolStripMenuItem();
            mnuHelp = new ToolStripMenuItem();
            mnuAbout = new ToolStripMenuItem();
            lblMssv = new Label();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(20, 20);
            menuStrip1.Items.AddRange(new ToolStripItem[] { mnuFile, mnuWindow, mnuHelp });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(900, 28);
            menuStrip1.TabIndex = 1;
            menuStrip1.Text = "menuStrip1";
            // 
            // mnuFile
            // 
            mnuFile.DropDownItems.AddRange(new ToolStripItem[] { toolStripSeparator1, mnuNewChild, mnuExit });
            mnuFile.Name = "mnuFile";
            mnuFile.Size = new Size(46, 24);
            mnuFile.Text = "File";
            // 
            // toolStripSeparator1
            // 
            toolStripSeparator1.Name = "toolStripSeparator1";
            toolStripSeparator1.Size = new Size(157, 6);
            // 
            // mnuNewChild
            // 
            mnuNewChild.Name = "mnuNewChild";
            mnuNewChild.Size = new Size(160, 26);
            mnuNewChild.Text = "New Child";
            mnuNewChild.Click += mnuNewChild_Click;
            // 
            // mnuExit
            // 
            mnuExit.Name = "mnuExit";
            mnuExit.Size = new Size(160, 26);
            mnuExit.Text = "Exit";
            mnuExit.Click += mnuExit_Click;
            // 
            // mnuWindow
            // 
            mnuWindow.DropDownItems.AddRange(new ToolStripItem[] { mnuCascade, mnuTileHorizontal, mnuTileVertical });
            mnuWindow.Name = "mnuWindow";
            mnuWindow.Size = new Size(78, 24);
            mnuWindow.Text = "Window";
            // 
            // mnuCascade
            // 
            mnuCascade.Name = "mnuCascade";
            mnuCascade.Size = new Size(190, 26);
            mnuCascade.Text = "Cascade";
            mnuCascade.Click += mnuCascade_Click;
            // 
            // mnuTileHorizontal
            // 
            mnuTileHorizontal.Name = "mnuTileHorizontal";
            mnuTileHorizontal.Size = new Size(190, 26);
            mnuTileHorizontal.Text = "Tile Horizontal";
            mnuTileHorizontal.Click += mnuTileHorizontal_Click;
            // 
            // mnuTileVertical
            // 
            mnuTileVertical.Name = "mnuTileVertical";
            mnuTileVertical.Size = new Size(190, 26);
            mnuTileVertical.Text = "Tile Vertical";
            mnuTileVertical.Click += mnuTileVertical_Click;
            // 
            // mnuHelp
            // 
            mnuHelp.DropDownItems.AddRange(new ToolStripItem[] { mnuAbout });
            mnuHelp.Name = "mnuHelp";
            mnuHelp.Size = new Size(55, 24);
            mnuHelp.Text = "Help";
            // 
            // mnuAbout
            // 
            mnuAbout.Name = "mnuAbout";
            mnuAbout.Size = new Size(133, 26);
            mnuAbout.Text = "About";
            mnuAbout.Click += mnuAbout_Click;
            // 
            // lblMssv
            // 
            lblMssv.AutoSize = true;
            lblMssv.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            lblMssv.Location = new Point(12, 40);
            lblMssv.Name = "lblMssv";
            lblMssv.Size = new Size(167, 23);
            lblMssv.TabIndex = 2;
            lblMssv.Text = "MSSV: 6551071077";
            lblMssv.Click += lblMssv_Click;
            // 
            // frmMain
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(900, 550);
            Controls.Add(lblMssv);
            Controls.Add(menuStrip1);
            IsMdiContainer = true;
            MainMenuStrip = menuStrip1;
            Name = "frmMain";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form";
            WindowState = FormWindowState.Maximized;
            FormClosing += frmMain_FormClosing;
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem mnuFile;
        private ToolStripMenuItem mnuNewChild;
        private ToolStripSeparator toolStripSeparator1;
        private ToolStripMenuItem mnuExit;
        private ToolStripMenuItem mnuWindow;
        private ToolStripMenuItem mnuCascade;
        private ToolStripMenuItem mnuTileHorizontal;
        private ToolStripMenuItem mnuTileVertical;
        private ToolStripMenuItem mnuHelp;
        private ToolStripMenuItem mnuAbout;
        private Label lblMssv;
    }
}
