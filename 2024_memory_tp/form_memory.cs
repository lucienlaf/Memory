namespace _2024_memory_tp
{
    public partial class form_memory : Form
    {
        Button Carte1Clic;
        Button Carte2Clic;
        ToolTip toolTipCarte = new ToolTip();

        Random alea;
        int nbclic;
        int nbPairesOk;

        List<String> lesCartes;
        List<Button> lesBouttons;

        public form_memory(List<String> CartesList)
        {
            InitializeComponent();
            lesCartes = CartesList;
            lesBouttons = new List<Button>();
            remplirBouttons();
            alea = new Random();
            nbclic = 1;
            nbPairesOk = (lesCartes.Count() + 2) / 2;
            lblVictoire.Visible = false;
            activerCartes(false);
        }

        #region click
        private void buttonQuitter_Click(object sender, EventArgs e)
        {
            this.Close();
        }
  
        private void buttonValider_Click(object sender, EventArgs e)
        {
            if (buttonValider.Text == "C'est parti !")
            {
                buttonValider.Text = "On recommence ..";
                activerCartes(true);
                buttonValider.Enabled = false;
                voirCartes(true);

            }
            else
            {
                razFondCartes();
                buttonValider.Enabled = false;
                razToolTip();
            }
            alea = new Random();
            lblVictoire.Visible = false;
            nbclic = 1;
            nbPairesOk = (lesCartes.Count() + 1) / 2;
            attribuerImages();
        }

        private void button_Click(object sender, EventArgs e)
        {
            retournerCarte(sender as Button);
        }

        #endregion

        #region Timer
        private void timer1_Tick(object sender, EventArgs e)
        {
            bool reponse;
            // arrête le timer
            timer1.Stop();

            //gestion de l'égalité
            reponse = comparerCarte(Carte1Clic, Carte2Clic);

            if (reponse == true)
            {
                Carte1Clic.Visible = false;
                Carte2Clic.Visible = false;
                nbPairesOk--;
            }
            else
            {
                Carte1Clic.BackgroundImage = Properties.Resources.fond_carte_1;
                Carte2Clic.BackgroundImage = Properties.Resources.fond_carte_1;
            }
            controlefinPartie();
        }
        #endregion

        #region fonctions/procédures utiles
        private void remplirBouttons()
        {
            lesBouttons.Add(button1);
            lesBouttons.Add(button2);
            lesBouttons.Add(button3);
            lesBouttons.Add(button4);
            if (lesCartes.Count() >= 6)
            {
                lesBouttons.Add(button5);
                lesBouttons.Add(button6);
            }
            if (lesCartes.Count() >= 8) 
            {
                lesBouttons.Add(button7);
                lesBouttons.Add(button8);
            }
            if (lesCartes.Count() >= 10)
            {
                lesBouttons.Add(button9);
                lesBouttons.Add(button10);
            }
            if (lesCartes.Count() >= 12)
            {
                lesBouttons.Add(button11);
                lesBouttons.Add(button12);
            }
            if (lesCartes.Count() >= 13)
            {
                lesBouttons.Add(button13);
                lesBouttons.Add(button14);
            }
            if (lesCartes.Count() >= 15)
            {
                lesBouttons.Add(button15);
                lesBouttons.Add(button16);
            }
            if (lesCartes.Count() >= 17)
            {
                lesBouttons.Add(button17);
                lesBouttons.Add(button18);
            }
            if (lesCartes.Count() >= 19)
            {
                lesBouttons.Add(button19);
                lesBouttons.Add(button20);
            }
        }
   
        private void attribuerImages()
        {
            // la propriété Tag d'un Boutton est une zone qui est utilisable comme
            // bon nous semble, elle n'a aucun impact sur le graphique.
            foreach (Button bouttonTemp in lesBouttons){
                bouttonTemp.Tag = choisirImage();
            }
        }
 
        private void razFondCartes()
        {
            foreach (Button bouttonTemp in lesBouttons)
            {
                bouttonTemp.BackgroundImage = Properties.Resources.fond_carte_1;
            }
        }
 
        private void activerCartes(Boolean activer)
        {
            foreach (Button bouttonTemp in lesBouttons)
            {
                bouttonTemp.Enabled = activer;
            }
        }
 
        private void voirCartes(Boolean activer)
        {
            foreach (Button bouttonTemp in lesBouttons)
            {
                bouttonTemp.Visible = activer;
            }
        }
        private Boolean comparerCarte(Button Carte1, Button Carte2)
        {
            bool rep = false;
            if (Carte1.Tag.ToString() == Carte2.Tag.ToString())
            {
                // les cartes sont une paire 
                rep = true;
            }
            return rep;
        }
       
        private String choisirImage()
        {
            //remplis l'image dans l'index de la liste (qui est choisi aléatoirement entre 0 et la taille
            //de la liste
            String choix = null;
            int indice = alea.Next(0, lesCartes.Count());
            choix = lesCartes[indice];
            lesCartes.Remove(choix);
            return choix;
        }
     
        private void retournerCarte(Button unBouton)
        {
            if (timer1.Enabled == true)
                return;

            String nomfichier = unBouton.Tag.ToString();
            unBouton.BackgroundImage = (Bitmap)Properties.Resources.ResourceManager.GetObject(nomfichier);

            //if (unBouton.BackgroundImage == (Bitmap)Properties.Resources.ResourceManager.GetObject("fond_carte_1"))
            if (nbPairesOk > 0)
            {
                if (nbclic == 1)
                {
                    Carte1Clic = unBouton;
                    Carte1Clic.BackgroundImageLayout = ImageLayout.Stretch;
                    nbclic = 2;
                }
                else
                {
                    Carte2Clic = unBouton;
                    Carte2Clic.BackgroundImageLayout = ImageLayout.Stretch;
                    nbclic = 1;
                    timer1.Start();
                }
            }


        }

        private void controlefinPartie()
        {
            if (nbPairesOk <= 0)
            {
                infoJeux();
                lblVictoire.Visible = true;
                buttonValider.Enabled = true;
                voirCartes(false);
            }
        }
   
        #region ToolTip ou InfoBulles

        private void infoJeux()
        {
            foreach (Button bouttonTemp in lesBouttons)
            {
                creerToolTip(bouttonTemp);
            }
        }
   
        private void razToolTip()
        {
            toolTipCarte.RemoveAll();
        }
  
        private void creerToolTip(Button unBouton)
        {
            toolTipCarte.IsBalloon = true;
            toolTipCarte.AutoPopDelay = 5000;
            toolTipCarte.InitialDelay = 0;
            toolTipCarte.ReshowDelay = 0;
            toolTipCarte.SetToolTip(unBouton, unBouton.Tag.ToString());
        }
        #endregion

        #endregion
    }

}
