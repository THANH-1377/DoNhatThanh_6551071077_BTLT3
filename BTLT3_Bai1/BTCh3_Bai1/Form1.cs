namespace BTCh3_Bai1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnHienThi_Click(object sender, EventArgs e)
        {
            txtHienThi.Text = txtNhapPassword.Text;
        }

        private void btnTiep_Click(object sender, EventArgs e)
        {
            txtNhapPassword.Clear();
            txtHienThi.Clear();

            txtNhapPassword.Focus();
        }

        private void btnDong_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
