namespace Bai18
{
    partial class frmChild
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
            lblThongTin = new Label();
            SuspendLayout();
            // 
            // lblThongTin
            // 
            lblThongTin.Dock = DockStyle.Fill;
            lblThongTin.Font = new Font("Segoe UI", 12F);
            lblThongTin.Location = new Point(0, 0);
            lblThongTin.Name = "lblThongTin";
            lblThongTin.Size = new Size(400, 250);
            lblThongTin.TabIndex = 0;
            lblThongTin.Text = "Form con MDI\nMSSV: 6551071077";
            lblThongTin.TextAlign = ContentAlignment.MiddleCenter;
            lblThongTin.Click += lblThongTin_Click;
            // 
            // frmChild
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(400, 250);
            Controls.Add(lblThongTin);
            Name = "frmChild";
            Text = "Form con";
            ResumeLayout(false);
        }

        #endregion

        private Label lblThongTin;
    }
}
