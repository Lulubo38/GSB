using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GeStionB.Patients
{
    public partial class AddPatient : Form
    {
        public AddPatient()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button_AddPatient_Valid_Click(object sender, EventArgs e)
        {
            PatientDataAccess dataAccess = new PatientDataAccess();
            dataAccess.CreatePatient(this.Box_AddPatient_Name.Text, this.Box_AddPatient_Prenom.Text, this.Combo_AddPatient_sexe.Text,this.date_AddPatient.Text);
            this.Close();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
