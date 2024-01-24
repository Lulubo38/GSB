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
    public partial class AdminValidation : Form
    {
        public AdminValidation()
        {
            InitializeComponent();
        }

        private async void Box_mdpAdmin_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                MedecinDataAccess dataAccess = new MedecinDataAccess();
                string hash = dataAccess.GetHashForAuthentification("administrateur");

                if (hash != null)
                {

                    Bcrypt bcrypt = new Bcrypt();
                    bool result = bcrypt.Descryption(this.Box_mdpAdmin.Text, hash);
                    if (result)
                    {
                        AddMedecin addMedecin = new AddMedecin();
                        this.Hide();
                        addMedecin.Show();
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
    }
}
