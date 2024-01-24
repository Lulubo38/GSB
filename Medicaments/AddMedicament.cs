using GeStionB.Antecedent;
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

namespace GeStionB.Medicaments
{
    public partial class AddMedicament : Form
    {
        private AntecedentDataAccess dataAccess = new AntecedentDataAccess();
        public AddMedicament()
        {
            InitializeComponent();
        }



        private void Btn_AddMedicament_Ajouter_Click(object sender, EventArgs e)
        {
            MedicamentsDataAccess dataAccess = new MedicamentsDataAccess();
            dataAccess.CreateMedicament(this.Box_AddMedicament_libelle.Text);
            this.Close();
        }

        private void btn_addMedicament_addCI_Click(object sender, EventArgs e)
        {
            AddAntecedent addAntecedent = new AddAntecedent();
            addAntecedent.Show();
        }
    }
}
