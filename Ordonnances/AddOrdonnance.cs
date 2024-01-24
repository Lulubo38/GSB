using GeStionB.Medicaments;
using GeStionB.Patients;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GeStionB.Ordonnances
{
    public partial class addOrdonnance : Form
    {
        string nom_m = "";
        public addOrdonnance(string nom_m)
        {
            this.nom_m = nom_m;
            InitializeComponent();
            FillComboBoxMedicaments();
            FillComboBoxPatients();
            
        }
        public void FillComboBoxMedicaments()
        {
            MedicamentsDataAccess dataAccessMedicament = new MedicamentsDataAccess();
            dataAccessMedicament.FillComboBox(comboMedicament);

        }
        public void FillComboBoxPatients()
        {
            PatientDataAccess dataAccessPatient = new PatientDataAccess();
            dataAccessPatient.FillComboBox(comboPatient);
        }

        private void btn_AddOrdonnance_Click(object sender, EventArgs e)
        {
            OrdonnancesDataAccess dataAccess = new OrdonnancesDataAccess();
            string posologie = this.box_posologie.Text;
            int duree = int.Parse(this.box_duree.Text);
            string instructions = this.box_instructions.Text;
            string nom_p = this.comboPatient.Text;
            string libelle_med = this.comboMedicament.Text;

            dataAccess.CreateOrdonnance(posologie, duree, instructions, nom_m, nom_p, libelle_med);
        }
    }
}
