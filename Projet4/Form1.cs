namespace Projet4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            this.ContextMenuStrip = contextMenuStrip1;
            this.Text = " Accueil";

        }

        private void backgroundWorker1_DoWork(object sender, System.ComponentModel.DoWorkEventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void deplacementDeDonnéesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form2 deplacementForm = new Form2();
            deplacementForm.ShowDialog();

        }

        private void eeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void deplacementDesDonnéesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form2 deplacementForm = new Form2();
            deplacementForm.ShowDialog();
        }

        private void ListeShow_Click(object sender, EventArgs e)
        {
            Form2 deplacementForm = new Form2();
            deplacementForm.ShowDialog();
        }
    }
}
