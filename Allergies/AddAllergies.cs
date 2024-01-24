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
    public partial class AddAllergies : Form
    {
        public AddAllergies()
        {
            InitializeComponent();
        }

        private void btn_CreateAllergie_Validate_Click(object sender, EventArgs e)
        {
            AllergiesDataAccess dataAccess = new AllergiesDataAccess();
            dataAccess.CreateAllergie(this.Box_libelleAllergie.Text);
            this.Close();
        }
    }
}
