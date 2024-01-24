using GeStionB.Medicaments;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GeStionB.Antecedent
{
    public partial class AttributeAntecedent : Form
    {
        AntecedentDataAccess dataAccess = new AntecedentDataAccess();
        int Id_p { get; set; }
        public AttributeAntecedent(int id_p)
        {
            InitializeComponent();
            this.Id_p = id_p;
            this.Activated += AttributeAntecedent_Activated;
        }

        private void AttributeAntecedent_Activated(object sender, EventArgs e)
        {
            FillComboBox();
        }

        public void FillComboBox()
        {
            dataAccess.FillComboBox(combo_antecedents);
        }

        private void btn_valid_attributAnT_Click(object sender, EventArgs e)
        {
            AntecedentDataAccess dataAccess = new AntecedentDataAccess();
            dataAccess.AttributeAntecedent(this.Id_p, this.combo_antecedents.Text);
            this.Close();
        }

        private void Btn_AddAntecedent_Click(object sender, EventArgs e)
        {
            
                AddAntecedent addAntecedent = new AddAntecedent();
                addAntecedent.Show();
            
        }
    }
}
