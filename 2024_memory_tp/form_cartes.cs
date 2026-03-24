using Microsoft.Win32.SafeHandles;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _2024_memory_tp
{
    public partial class form_cartes : Form
    {
        int totalChoisis;
        int nbCartes;
        List<String> lesCartes;
        public form_cartes(int Cartes)
        {
            InitializeComponent();
            lesCartes = new List<String>();
            totalChoisis = 0;
            nbCartes = Cartes;
            titreChoissisez.Text = "Choissisez un total de " + nbCartes + " paires (ou moins)";
        }

        private void buttonQuitter_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void buttonValider_Click(object sender, EventArgs e)
        {
            if (buttonValider.ForeColor == Color.LimeGreen)
            {
                if (totalChoisis < nbCartes)
                {
                    buttonValider.Text = "Le minimum de paires doit être de 2 !";
                    buttonValider.ForeColor = Color.Red;
                    buttonValider.Cursor = Cursors.No;
                    Thread.Sleep(1000);
                    buttonValider.Text = "Valider";
                    buttonValider.ForeColor = Color.LimeGreen;
                    buttonValider.Cursor = Cursors.Arrow;
                }
                if (totalChoisis > nbCartes)
                {
                    buttonValider.Text = "Le maximum de paires doit être de " + nbCartes + " !";
                    buttonValider.ForeColor = Color.Red;
                    buttonValider.Cursor = Cursors.No;
                    Thread.Sleep(1000);
                    buttonValider.Text = "Valider";
                    buttonValider.ForeColor = Color.LimeGreen;
                    buttonValider.Cursor = Cursors.Arrow;
                }
                if (totalChoisis >= 2 && totalChoisis <= nbCartes)
                {
                    form_memory memory = new form_memory(lesCartes);
                    memory.ShowDialog();
                }
            }
        }

        private void button_Click(object sender, EventArgs e)
        {
            pastilleChange(sender as Button);
        }
        private void pastilleChange(Button unBouton)
        {
            if (unBouton.Tag.ToString().ToLower() == "snake")
            {
                if (snake.BackColor == Color.IndianRed)
                {
                    snake.BackColor = Color.Green;
                    lesCartes.Add("snake");
                    lesCartes.Add("snake");
                    totalChoisis++;
                }
                else
                {
                    snake.BackColor = Color.IndianRed;
                    lesCartes.Remove("snake");
                    lesCartes.Remove("snake");
                    totalChoisis--;
                }
            }
            if (unBouton.Tag.ToString().ToLower() == "bomberman")
            {
                if (bomberman.BackColor == Color.IndianRed)
                {
                    bomberman.BackColor = Color.Green;
                    lesCartes.Add("bomberman");
                    lesCartes.Add("bomberman");
                    totalChoisis++;
                }
                else
                {
                    bomberman.BackColor = Color.IndianRed;
                    lesCartes.Remove("bomberman");
                    lesCartes.Remove("bomberman");
                    totalChoisis--;
                }
            }
            if (unBouton.Tag.ToString().ToLower() == "pacman")
            {
                if (pacman.BackColor == Color.IndianRed)
                {
                    pacman.BackColor = Color.Green;
                    lesCartes.Add("pacman");
                    lesCartes.Add("pacman");
                    totalChoisis++;
                }
                else
                {
                    pacman.BackColor = Color.IndianRed;
                    lesCartes.Remove("pacman");
                    lesCartes.Remove("pacman");
                    totalChoisis--;
                }
            }
            if (unBouton.Tag.ToString().ToLower() == "worms")
            {
                if (worms.BackColor == Color.IndianRed)
                {
                    worms.BackColor = Color.Green;
                    lesCartes.Add("worms");
                    lesCartes.Add("worms");
                    totalChoisis++;
                }
                else
                {
                    worms.BackColor = Color.IndianRed;
                    lesCartes.Remove("worms");
                    lesCartes.Remove("worms");
                    totalChoisis--;
                }
            }
            if (unBouton.Tag.ToString().ToLower() == "tetris")
            {
                if (tetris.BackColor == Color.IndianRed)
                {
                    tetris.BackColor = Color.Green;
                    lesCartes.Add("tetris");
                    lesCartes.Add("tetris");
                    totalChoisis++;
                }
                else
                {
                    tetris.BackColor = Color.IndianRed;
                    lesCartes.Remove("tetris");
                    lesCartes.Remove("tetris");
                    totalChoisis--;
                }
            }
            if (unBouton.Tag.ToString().ToLower() == "demineur")
            {
                if (demineur.BackColor == Color.IndianRed)
                {
                    demineur.BackColor = Color.Green;
                    lesCartes.Add("demineur");
                    lesCartes.Add("demineur");
                    totalChoisis++;
                }
                else
                {
                    demineur.BackColor = Color.IndianRed;
                    lesCartes.Remove("demineur");
                    lesCartes.Remove("demineur");
                    totalChoisis--;
                }
            }
            if (unBouton.Tag.ToString().ToLower() == "kirby")
            {
                if (kirby.BackColor == Color.IndianRed)
                {
                    kirby.BackColor = Color.Green;
                    lesCartes.Add("kirby");
                    lesCartes.Add("kirby");
                    totalChoisis++;
                }
                else
                {
                    kirby.BackColor = Color.IndianRed;
                    lesCartes.Remove("kirby");
                    lesCartes.Remove("kirby");
                    totalChoisis--;
                }
            }
            if (unBouton.Tag.ToString().ToLower() == "minecraft")
            {
                if (minecraft.BackColor == Color.IndianRed)
                {
                    minecraft.BackColor = Color.Green;
                    lesCartes.Add("minecraft");
                    lesCartes.Add("minecraft");
                    totalChoisis++;
                }
                else
                {
                    minecraft.BackColor = Color.IndianRed;
                    lesCartes.Remove("minecraft");
                    lesCartes.Remove("minecraft");
                    totalChoisis--;
                }
            }
            if (unBouton.Tag.ToString().ToLower() == "rayman")
            {
                if (rayman.BackColor == Color.IndianRed)
                {
                    rayman.BackColor = Color.Green;
                    lesCartes.Add("rayman");
                    lesCartes.Add("rayman");
                    totalChoisis++;
                }
                else
                {
                    rayman.BackColor = Color.IndianRed;
                    lesCartes.Remove("rayman");
                    lesCartes.Remove("rayman");
                    totalChoisis--;
                }
            }
            if (unBouton.Tag.ToString().ToLower() == "donkeykong")
            {
                if (donkeykong.BackColor == Color.IndianRed)
                {
                    donkeykong.BackColor = Color.Green;
                    lesCartes.Add("donkeykong");
                    lesCartes.Add("donkeykong");
                    totalChoisis++;
                }
                else
                {
                    donkeykong.BackColor = Color.IndianRed;
                    lesCartes.Remove("donkeykong");
                    lesCartes.Remove("donkeykong");
                    totalChoisis--;
                }
            }
        }
    }
}
