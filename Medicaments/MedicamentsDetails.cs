using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using GeStionB.Antecedent;

namespace GeStionB.Medicaments
{
    public partial class MedicamentsDetails : Form
    {
        private AntecedentDataAccess dataAccessAntecedent = new AntecedentDataAccess();
        private MedicamentsDataAccess dataAccessMedicament = new MedicamentsDataAccess();
        private int Id { get; }

        public MedicamentsDetails(int id, string libelle)
        {
            InitializeComponent();

            this.Id = id;
            this.Box_change_libelle.Text = libelle;


        }



        private void btn_MedicamentsDetails_Valid_Click(object sender, EventArgs e)
        {
            dataAccessMedicament.UpdateMedicamentInfo(Id, this.Box_change_libelle.Text);
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ManageIncompatiblite manageIcompatiblite = new ManageIncompatiblite(Id);
            manageIcompatiblite.Show();
        }
    }

}
