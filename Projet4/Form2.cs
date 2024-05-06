using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Projet4
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
            this.Text = "Listes";
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void BtnAjouter_Click(object sender, EventArgs e)
        {
            if (Txt1.Text == "")
            {
                MessageBox.Show("Il faut un texte");

            }
            else
            {
                LstG1.Items.Add(Txt1.Text);
            }
            Txt1.Text = "";
            Txt1.Focus();
        }

        private void BtnVider_Click(object sender, EventArgs e)
        {
            LstG1.Items.Clear();
        }

        private void BtnSupprimer_Click(object sender, EventArgs e)
        {
            if (LstG1.SelectedIndex != -1) // Vérifie s'il y a un élément sélectionné
            {
                LstG1.Items.RemoveAt(LstG1.SelectedIndex);
            }
            else
            {
                MessageBox.Show("Veuillez sélectionner un élément à supprimer.");
            }
        }

        private void BtnGD1_Click(object sender, EventArgs e)
        {
            if (LstG1.SelectedIndex != -1) // Vérifie s'il y a un élément sélectionné
            {
                string element = LstG1.Items[LstG1.SelectedIndex].ToString();
                LstD1.Items.Add(element);
                LstG1.Items.RemoveAt(LstG1.SelectedIndex);
            }
            else
            {
                MessageBox.Show("Veuillez sélectionner un élément à deplacer.");
            }
        }

        private void BtnDG1_Click(object sender, EventArgs e)
        {
            if (LstD1.SelectedIndex != -1) // Vérifie s'il y a un élément sélectionné
            {
                string element = LstD1.Items[LstD1.SelectedIndex].ToString();
                LstG1.Items.Add(element);
                LstD1.Items.RemoveAt(LstD1.SelectedIndex);
            }
            else
            {
                MessageBox.Show("Veuillez sélectionner un élément à deplacer.");
            }
        }

        private void BtnAjouter2_Click(object sender, EventArgs e)
        {
            if (Txt2.Text == "")
            {
                MessageBox.Show("Il faut un texte");

            }
            else
            {
                LstG2.Items.Add(Txt2.Text);
            }
            Txt2.Text = "";
            Txt2.Focus();
        }

        private void BtnVider2_Click(object sender, EventArgs e)
        {
            LstG2.Items.Clear();
        }

        private void BtnSupprimer2_Click(object sender, EventArgs e)
        {
            if (LstG2.SelectedIndex != -1) // Vérifie s'il y a un élément sélectionné
            {
                // Parcours des éléments sélectionnés à supprimer
                for (int i = LstG2.SelectedIndices.Count - 1; i >= 0; i--)
                {
                    int selectedIndex = LstG2.SelectedIndices[i];
                    LstG2.Items.RemoveAt(selectedIndex);
                }
            }
            else
            {
                MessageBox.Show("Veuillez sélectionner un élément à supprimer.");
            }

        }

        private void BtnTGD2_Click(object sender, EventArgs e)
        {
            if (LstG2.SelectedIndex != -1) // Vérifie s'il y a un élément sélectionné
            {
                // Parcours des éléments sélectionnés à déplacer
                for (int i = LstG2.SelectedIndices.Count - 1; i >= 0; i--)
                {
                    int selectedIndex = LstG2.SelectedIndices[i];
                    string selectedItem = LstG2.Items[selectedIndex].ToString();

                    // Ajouter l'élément à la deuxième ListBox
                    LstD2.Items.Add(selectedItem);

                    // Supprimer l'élément de la première ListBox
                    LstG2.Items.RemoveAt(selectedIndex);
                }
            }
            else
            {
                MessageBox.Show("Veuillez sélectionner un élément à deplacer.");
            }

        }

        private void BtnTDG2_Click(object sender, EventArgs e)
        {
            if (LstD2.SelectedIndex != -1) // Vérifie s'il y a un élément sélectionné
            {
                // Parcours des éléments sélectionnés à déplacer
                for (int i = LstD2.SelectedIndices.Count - 1; i >= 0; i--)
                {
                    int selectedIndex = LstD2.SelectedIndices[i];
                    string selectedItem = LstD2.Items[selectedIndex].ToString();

                    // Ajouter l'élément à la deuxième ListBox
                    LstG2.Items.Add(selectedItem);

                    // Supprimer l'élément de la première ListBox
                    LstD2.Items.RemoveAt(selectedIndex);
                }
            }
            else
            {
                MessageBox.Show("Veuillez sélectionner un élément à deplacer.");
            }

        }

        private void BtnAjouter4_Click(object sender, EventArgs e)
        {
            if (Txt4.Text == "")
            {
                MessageBox.Show("Il faut un texte");

            }
            else
            {
                LstG4.Items.Add(Txt4.Text);
            }
            Txt4.Text = "";
            Txt4.Focus();
        }

        private void BtnVider4_Click(object sender, EventArgs e)
        {
            LstG4.Items.Clear();
        }

        private void BtnSupprimer4_Click(object sender, EventArgs e)
        {
            if (LstG4.SelectedIndex != -1) // Vérifie s'il y a un élément sélectionné
            {
                // Parcours des éléments sélectionnés à supprimer
                for (int i = LstG4.SelectedIndices.Count - 1; i >= 0; i--)
                {
                    int selectedIndex = LstG4.SelectedIndices[i];
                    LstG4.Items.RemoveAt(selectedIndex);
                }
            }
            else
            {
                MessageBox.Show("Veuillez sélectionner un élément à supprimer.");
            }
        }

        private void LstG4_MouseDown(object sender, MouseEventArgs e)
        {
            if (LstG4.SelectedItem != null)
            {
                LstG4.DoDragDrop(LstG4.SelectedItem, DragDropEffects.Move);
            }
        }

        private void LstD4_DragEnter(object sender, DragEventArgs e)
        {
            e.Effect = DragDropEffects.Move;
        }

        private void LstD4_DragDrop(object sender, DragEventArgs e)
        {
            Point point = LstD4.PointToClient(new Point(e.X, e.Y));
            int index = LstD4.IndexFromPoint(point);
            if (index < 0)
            {
                index = LstD4.Items.Count - 1;
            } // Si l'index est négatif, insérer à la fin
            else if (index > LstD4.Items.Count)
            {
                index = LstD4.Items.Count; // Si l'index est plus grand que la taille, insérer à la fin
            }
            object data = e.Data.GetData(typeof(string));
            LstD4.Items.Add(data);
            LstG4.Items.Remove(data);
        }

        private void LstD4_MouseDown(object sender, MouseEventArgs e)
        {
            if (LstD4.SelectedItem != null)
            {
                LstD4.DoDragDrop(LstD4.SelectedItem, DragDropEffects.Move);
            }
        }

        private void LstG4_DragEnter(object sender, DragEventArgs e)
        {
            e.Effect = DragDropEffects.Move;
        }

        private void LstG4_DragDrop(object sender, DragEventArgs e)
        {
            Point point = LstG4.PointToClient(new Point(e.X, e.Y));
            int index = LstG4.IndexFromPoint(point);
            if (index < 0)
            {
                index = LstG4.Items.Count - 1;
            } // Si l'index est négatif, insérer à la fin
            else if (index > LstG4.Items.Count)
            {
                index = LstG4.Items.Count;
            } // Si l'index est plus grand que la taille, insérer à la fin

            object data = e.Data.GetData(typeof(string));
            LstG4.Items.Add(data);
            LstD4.Items.Remove(data);
        }
    }
}
