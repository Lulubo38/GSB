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
    public partial class AddAntecedent : Form
    {
        
        public AddAntecedent()
        {
            InitializeComponent();
        }

        private void btn_ajoutAntecedent_Click(object sender, EventArgs e)
        {
            AntecedentDataAccess dataAccess = new AntecedentDataAccess();
            dataAccess.CreateAntecedent(this.Box_addAntecedent_libelle.Text);
            this.Close();
        }
    }
}
