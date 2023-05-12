namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void opcoesToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void livrosMenuItem_Click(object sender, EventArgs e)
        {
            frmCadLivros frm = new frmCadLivros();
            frm.MdiParent= this;
            frm.Show();
        }
    }
}