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

namespace GeStionB.Allergies
{
    public partial class AttributeAllergies : Form
    {
        AllergiesDataAccess dataAccess = new AllergiesDataAccess();
        int Id_p { get; set; }
        public AttributeAllergies(int id_p)
        {
            InitializeComponent();
            this.Id_p = id_p;
            this.Activated += AttributeAllergies_Activated;
        }

        private void AttributeAllergies_Activated(object sender, EventArgs e)
        {
            FillComboBox();
        }

        public void FillComboBox()
        {
            dataAccess.FillComboBox(combo_Allergies);
        }


        private void btn_attributeAllergies_valid_Click(object sender, EventArgs e)
        {
            
            dataAccess.AttributeAllergie(this.Id_p, this.combo_Allergies.Text);
            this.Close();
        }

        private void btn_createAllergie_Click(object sender, EventArgs e)
        {
            AddAllergies addAllergies = new AddAllergies();
            addAllergies.Show();
        }

        
    }
}
