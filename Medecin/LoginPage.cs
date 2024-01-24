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
    public partial class LoginPage : Form
    {

        public LoginPage()
        {
            InitializeComponent();
        }

        private async void Btn_Login_valid_Click(object sender, EventArgs e)
        {
            MedecinDataAccess dataAccess = new MedecinDataAccess();
            string hash = dataAccess.GetHashForAuthentification(this.Box_Login_Username.Text);
            //récupere le hash de la BDD correspondant à l'utilisateur
            string nom_m = dataAccess.GetNameOfMedecin(this.Box_Login_Username.Text);
            //recupere le nom 
            if (hash != null)
            //si un hash est trouver dans la BDD -> comparer les mots de passe
            {
                Bcrypt bcrypt = new Bcrypt();
                bool result = bcrypt.Descryption(this.Box_Login_Password.Text, hash);
                //utilise la methode descryption de la classe Bcrypt
                if (result)
                {
                    //si le resultat est true -> ouvrir l'accueil et cacher la page de connexion
                    Accueil accueil = new Accueil(nom_m);
                    this.Hide();
                    accueil.Show();
                }
                else
                //sinon refuser la connexion
                {
                    MessageBox.Show("Mauvais identifiant/mot de passe");
                }
            }
            else
            //sinon attendre 800ms pour simuler la descryption du mot de passe
            //et ensuite interdire la connexion
            {
                await Task.Delay(800);
                MessageBox.Show("Mauvais identifiant/mot de passe");
            }
        }

        private void btn_addUser_Click(object sender, EventArgs e)
        {
            AdminValidation adminValidation = new AdminValidation();
            adminValidation.Show();
        }

        private async void Box_Login_Password_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                MedecinDataAccess dataAccess = new MedecinDataAccess();
                string hash = dataAccess.GetHashForAuthentification(this.Box_Login_Username.Text);
                string nom_m = dataAccess.GetNameOfMedecin(this.Box_Login_Username.Text);
                if (hash != null)
                {

                    Bcrypt bcrypt = new Bcrypt();
                    bool result = bcrypt.Descryption(this.Box_Login_Password.Text, hash);
                    if (result)
                    {
                        Accueil accueil = new Accueil(nom_m);
                        this.Hide();
                        accueil.Show();
                    }
                    else
                    {
                        MessageBox.Show("Mauvais identifiant/mot de passe");
                    }
                }
                else
                {
                    await Task.Delay(800);
                    MessageBox.Show("Mauvais identifiant/mot de passe");
                }
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}