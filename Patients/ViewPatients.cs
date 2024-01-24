using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using GeStionB.Patients;

namespace GeStionB
{
    public partial class ViewPatients : Form
    {
        private PatientDataAccess dataAccess = new PatientDataAccess();
        public ViewPatients()
        {
            InitializeComponent();
            updateDataGridView();
            this.Activated += ViewPatients_Activated;
        }

        private void ViewPatients_Activated(object sender, EventArgs e)
        {
            updateDataGridView();
        }


        

        public void updateDataGridView()
        {
            this.PatientGridView.DataSource = null;
            this.PatientGridView.DataSource = dataAccess.GetPatientListFromDB();
        }

        // Au clic sur une cellule de la grille (DataGridView) ->
        private void PatientGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            // Vérifie si l'index de ligne est valide (supérieur ou égal à zéro)
            if (e.RowIndex >= 0)
            {
                // Récupère la ligne sélectionnée à partir de l'index de ligne
                DataGridViewRow selectedRow = this.PatientGridView.Rows[e.RowIndex];

                // Récupère les valeurs des cellules de la ligne sélectionnée
                int id = Convert.ToInt32(selectedRow.Cells["ID"].Value);
                string nom = selectedRow.Cells["nom"].Value.ToString();
                string prenom = selectedRow.Cells["prenom"].Value.ToString();
                string sexe = selectedRow.Cells["sexe"].Value.ToString();
                string birthday = selectedRow.Cells["Date de naissance"].Value.ToString();

                // Crée une instance de PatientsDetails avec les valeurs récupérées
                PatientsDetails patientDetail = new PatientsDetails(id, nom, prenom, sexe, birthday);

                // Affiche la fenêtre PatientsDetails
                patientDetail.Show();
            }
        }

        private void Add_patient_button_Click(object sender, EventArgs e)
        {
            AddPatient addPatient = new AddPatient();
            addPatient.Show();
        }
    }
}
