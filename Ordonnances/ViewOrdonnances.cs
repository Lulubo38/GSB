using GeStionB.Patients;
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

namespace GeStionB.Ordonnances
{
    public partial class ViewOrdonnances : Form
    {
        OrdonnancesDataAccess dataAccess = new OrdonnancesDataAccess();
        string nom_m = "";
        public ViewOrdonnances(string nom_m)
        {
            InitializeComponent();
            updateDataGridView();
            this.Activated += ViewOrdonnances_Activated;
            this.nom_m = nom_m;
        }

        private void ViewOrdonnances_Activated(object sender, EventArgs e)
        {
            updateDataGridView();
        }




        public void updateDataGridView()
        {
            this.gridOrdonnance.DataSource = null;
            this.gridOrdonnance.DataSource = dataAccess.GetOrdonnancesListFromDB();
        }

        private void gridOrdonnance_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

            if (e.RowIndex >= 0)
            {
                DataGridViewRow selectedRow = this.gridOrdonnance.Rows[e.RowIndex];
                int id_o = Convert.ToInt32(selectedRow.Cells["ID"].Value);
                string posologie = selectedRow.Cells["Posologie"].Value.ToString();
                string date = selectedRow.Cells["Date de création"].Value.ToString();
                int duree = Convert.ToInt32(selectedRow.Cells["Durée du traitement (jours)"].Value.ToString());
                string instructions = selectedRow.Cells["Instructions"].Value.ToString();
                string nom_m = selectedRow.Cells["Medecin"].Value.ToString();
                string nom_p = selectedRow.Cells["Patient"].Value.ToString();
                string libelle_med = selectedRow.Cells["Medicament Prescrit"].Value.ToString();


                OrdonnancesDetails ordonnancesDetails = new OrdonnancesDetails(id_o, posologie, date, duree, instructions, nom_m, nom_p, libelle_med);
                ordonnancesDetails.Show();
            }

        }

        private void btn_AddOrdonnance_Click(object sender, EventArgs e)
        {
            addOrdonnance addOrdonnance = new addOrdonnance(nom_m);
            addOrdonnance.Show();
        }
    }
}
