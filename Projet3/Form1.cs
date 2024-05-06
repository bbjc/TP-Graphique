using System.ComponentModel;

namespace Projet3
{
    public partial class Calcul : Form
    {
        public Calcul()
        {
            InitializeComponent();
            LblDate.Text = DateTime.Now.ToShortDateString();
            timer1.Start();
            LblHeure.Text = DateTime.Now.ToLongTimeString();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void BtnChance_Click(object sender, EventArgs e)
        {
            int x;
            Random alea = new Random();
            x = alea.Next(0, 16);
            TxtChance.Text = x.ToString();
        }

        private void BtnInit_Click(object sender, EventArgs e)
        {
            TxtCin.Text = "";
            TxtTel.Text = "";
            TxtNom.Text = "";
            TxtPrenom.Text = "";
            TxtLang.Text = "0";
            TxtTech.Text = "0";
            TxtChance.Text = "0";
            ChkExper.Checked = false;
            ChkMotiv.Checked = false;
            ChkDip.Checked = false;
            RdMas.Checked = false;
            RdFem.Checked = false;
            CmbAge.SelectedIndex = -1;
            BtnAjout.Enabled = false;
        }

        private void TxtLang_TextChanged(object sender, EventArgs e)
        {
            if (TxtLang.Text == "")
            {
                MessageBox.Show("Il faut saisir une note");

            }
            else
            {
                if (int.Parse(TxtLang.Text) > 20)
                {
                    MessageBox.Show("La note doit être entre 0 et 20");
                    TxtLang.SelectAll();

                }
            }
        }

        private void TxtTech_TextChanged(object sender, EventArgs e)
        {
            if (TxtTech.Text == "")
            {
                MessageBox.Show("Il faut saisir une note");

            }
            else
            {
                if (int.Parse(TxtTech.Text) > 20)
                {
                    MessageBox.Show("La note doit être entre 0 et 20");
                    TxtLang.SelectAll();

                }
            }

        }

        private void BtnCalc_Click(object sender, EventArgs e)
        {
            if ((TxtCin.Text == "") || (TxtTel.Text == "") || (TxtNom.Text == "") || (TxtPrenom.Text == ""))
            {
                MessageBox.Show("Il faut saisir toutes les informations");
                return;
            }
            int note1, note2, sexe, bonus, age, chance, score;

            note1 = int.Parse(TxtLang.Text);
            note2 = int.Parse(TxtTech.Text);

            if (RdMas.Checked)
            {
                sexe = 7;
            }
            else
            {
                sexe = 5;
            }
            bonus = 0;
            if (ChkDip.Checked)
            {
                bonus += bonus + 5;
            }
            if (ChkExper.Checked)
            {
                bonus += bonus + 15;
            }
            if (ChkMotiv.Checked)
            {
                bonus += bonus + 10;
            }
            switch (CmbAge.SelectedIndex)
            {
                case 0:
                    age = 20;
                    break;
                case 1:
                    age = 10;
                    break;
                case 2:
                    age = 5;
                    break;
                default:
                    age = 0;
                    break;
            }

            chance = int.Parse(TxtChance.Text);

            score = note1 + note2 + sexe + bonus + age + chance;

            TxtScore.Text = score.ToString();
            BtnAjout.Enabled = true;
        }

        private void BtnAjout_Click(object sender, EventArgs e)
        {
            Lst1.Items.Add(TxtCin.Text);
            Lst2.Items.Add(TxtTel.Text);
            Lst3.Items.Add(TxtPrenom.Text);
            Lst4.Items.Add(TxtNom.Text);
            BtnAjout.Enabled = false;
        }

        private void BtnQuit_Click(object sender, EventArgs e)
        {
            // Fermer l'application
            Application.Exit();
        }
    }
}
