using GeStionB.Allergies;
using GeStionB.Antecedent;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace GeStionB.Patients
{
    public partial class PatientsDetails : Form
    {
        public int Id { get; set; }
        // Propriété publique Id de type entier, utilisée pour stocker l'ID du patient

        public PatientsDetails(int id, string nom, string prenom, string sex, string birthday)
        {
            InitializeComponent();
            this.Id = id;
            // Affecte la valeur de l'ID passé en paramètre à la propriété Id de l'objet PatientsDetails
            this.Box_change_nom.Text = nom;
            // Affecte la valeur du nom passé en paramètre à la propriété Text de la boîte de texte Box_change_nom
            this.Box_change_prenom.Text = prenom;
            // Affecte la valeur du prénom passé en paramètre à la propriété Text de la boîte de texte Box_change_prenom
            this.combo_change_sexe.Text = sex;
            // Affecte la valeur du sexe passé en paramètre à la propriété Text de la liste déroulante combo_change_sexe
            this.date_PatientDetails.Text = birthday;
            // Affecte la valeur de la date de naissance passée en paramètre à la propriété Text de date_PatientDetails
        }

        private void PatientsDatails_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void User_change_button_Click(object sender, EventArgs e)
        {
            PatientDataAccess dataAccess = new PatientDataAccess();
            dataAccess.UpdatePatientInfo(Id, this.Box_change_nom.Text, this.Box_change_prenom.Text, this.combo_change_sexe.Text,this.date_PatientDetails.Text);
            this.Close();
        }

        private void btn_PatientsDetails_Antec_Click(object sender, EventArgs e)
        {
            ViewAntecedents viewAntecedents = new ViewAntecedents(Id);
            viewAntecedents.Show();
        }

        //Evenement qui corresponds au bouton pour gérer les allergies
        private void btn_PatientsDetails_Allergies_Click(object sender, EventArgs e)
        {  
            // Créer une nouvelle fenetre de viewAllergies en passe en parametre l'ID du patient
            ViewAllergies viewAntecedents = new ViewAllergies(Id);
            //Afficher la fenetre
            viewAntecedents.Show();
        }
    }
}
