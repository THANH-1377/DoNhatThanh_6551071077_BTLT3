namespace BTCh3_Bai16
{
    partial class StepByStep2_19
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            dlgOpenFile = new OpenFileDialog();
            dlgSaveFile = new SaveFileDialog();
            dlgFont = new FontDialog();
            dlgColor = new ColorDialog();
            mnuContext = new MenuStrip();
            contextMenuToolStripMenuItem = new ToolStripMenuItem();
            cutToolStripMenuItem = new ToolStripMenuItem();
            copyToolStripMenuItem = new ToolStripMenuItem();
            pasteToolStripMenuItem = new ToolStripMenuItem();
            mnuContext.SuspendLayout();
            SuspendLayout();
            // 
            // dlgOpenFile
            // 
            dlgOpenFile.FileName = "openFileDialog1";
            // 
            // mnuContext
            // 
            mnuContext.ImageScalingSize = new Size(24, 24);
            mnuContext.Items.AddRange(new ToolStripItem[] { contextMenuToolStripMenuItem });
            mnuContext.Location = new Point(0, 0);
            mnuContext.Name = "mnuContext";
            mnuContext.Size = new Size(800, 33);
            mnuContext.TabIndex = 1;
            mnuContext.Text = "mnuContext";
            // 
            // contextMenuToolStripMenuItem
            // 
            contextMenuToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { cutToolStripMenuItem, copyToolStripMenuItem, pasteToolStripMenuItem });
            contextMenuToolStripMenuItem.Name = "contextMenuToolStripMenuItem";
            contextMenuToolStripMenuItem.Size = new Size(139, 29);
            contextMenuToolStripMenuItem.Text = "Context Menu";
            // 
            // cutToolStripMenuItem
            // 
            cutToolStripMenuItem.Name = "cutToolStripMenuItem";
            cutToolStripMenuItem.Size = new Size(156, 34);
            cutToolStripMenuItem.Text = "Cu&t";
            // 
            // copyToolStripMenuItem
            // 
            copyToolStripMenuItem.Name = "copyToolStripMenuItem";
            copyToolStripMenuItem.Size = new Size(156, 34);
            copyToolStripMenuItem.Text = "&Copy";
            // 
            // pasteToolStripMenuItem
            // 
            pasteToolStripMenuItem.Name = "pasteToolStripMenuItem";
            pasteToolStripMenuItem.Size = new Size(156, 34);
            pasteToolStripMenuItem.Text = "&Paste";
            // 
            // StepByStep2_19
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(mnuContext);
            Name = "StepByStep2_19";
            Text = "StepByStep2_19";
            mnuContext.ResumeLayout(false);
            mnuContext.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private OpenFileDialog dlgOpenFile;
        private SaveFileDialog dlgSaveFile;
        private FontDialog dlgFont;
        private ColorDialog dlgColor;
        private MenuStrip mnuContext;
        private ToolStripMenuItem contextMenuToolStripMenuItem;
        private ToolStripMenuItem cutToolStripMenuItem;
        private ToolStripMenuItem copyToolStripMenuItem;
        private ToolStripMenuItem pasteToolStripMenuItem;
    }
}