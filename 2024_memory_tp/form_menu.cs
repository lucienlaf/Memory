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
    public partial class form_menu : Form
    {
        public form_menu()
        {
            InitializeComponent();
        }

        private void buttonQuitter_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void buttonValider_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(textCartes.Text))
            {
                textCartes.Text = "2";
            }
            form_cartes cartes = new form_cartes(int.Parse(textCartes.Text));
            cartes.ShowDialog();
        }
    }
}
