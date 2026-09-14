namespace BTCh3_Bai15
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void domainUpDown1_SelectedItemChanged(object sender, EventArgs e)
        {
            DomainUpDown dudColor = (DomainUpDown)sender;
            lblSampleText.ForeColor = Color.FromName(dudColor.Text);
        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            NumericUpDown nudSize = (NumericUpDown)sender;
            lblSampleText.Font = new
            Font(lblSampleText.Font.FontFamily, (float)nudSize.Value);
        }

        private void lblSampleText_Click(object sender, EventArgs e)
        {

        }
    }
}
