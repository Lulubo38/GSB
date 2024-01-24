using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GeStionB.Medecin
{
    public partial class AddMedecin : Form
    {
        public AddMedecin()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btn_addMedecin_Valid_Click(object sender, EventArgs e)
        {
            Bcrypt bCrypt = new Bcrypt();
            //créer un nouvel obejt de la classe Bcrypt
            string hash = bCrypt.Encryption(this.box_AddMedecin_MDP.Text);
            //Utilise la méthode Encryption de la classe Bcrypt et recupere le resultat qui sera le hash du mot de passe
            MedecinDataAccess dataAccess = new MedecinDataAccess();
            dataAccess.AddMedecin(this.box_AddMedecin_nom.Text, this.box_AddMedecin_prenom.Text, this.date_AddMedecin.Text, this.box_AddMedecin_ID.Text, hash);
            //créer le medecin en BDD avec le mot de passe hasher
            MessageBox.Show("Utilisateur crée");
        }

        
    }
}
