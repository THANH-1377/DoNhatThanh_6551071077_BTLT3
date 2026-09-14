namespace BTCh3_Bai15
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
            domainUpDown1 = new DomainUpDown();
            numericUpDown1 = new NumericUpDown();
            lblSampleText = new Label();
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(98, 84);
            label1.Name = "label1";
            label1.Size = new Size(48, 20);
            label1.TabIndex = 0;
            label1.Text = "Color:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(98, 160);
            label2.Name = "label2";
            label2.Size = new Size(39, 20);
            label2.TabIndex = 1;
            label2.Text = "Size:";
            // 
            // domainUpDown1
            // 
            domainUpDown1.Location = new Point(204, 84);
            domainUpDown1.Name = "domainUpDown1";
            domainUpDown1.Size = new Size(361, 27);
            domainUpDown1.TabIndex = 2;
            domainUpDown1.Text = "domainUpDown1";
            domainUpDown1.SelectedItemChanged += domainUpDown1_SelectedItemChanged;
            // 
            // numericUpDown1
            // 
            numericUpDown1.Location = new Point(204, 153);
            numericUpDown1.Name = "numericUpDown1";
            numericUpDown1.Size = new Size(349, 27);
            numericUpDown1.TabIndex = 3;
            numericUpDown1.ValueChanged += numericUpDown1_ValueChanged;
            // 
            // lblSampleText
            // 
            lblSampleText.AutoSize = true;
            lblSampleText.Location = new Point(204, 282);
            lblSampleText.Name = "lblSampleText";
            lblSampleText.Size = new Size(90, 20);
            lblSampleText.TabIndex = 4;
            lblSampleText.Text = "Sample Text";
            lblSampleText.Click += lblSampleText_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(lblSampleText);
            Controls.Add(numericUpDown1);
            Controls.Add(domainUpDown1);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private DomainUpDown domainUpDown1;
        private NumericUpDown numericUpDown1;
        private Label lblSampleText;
    }
}
