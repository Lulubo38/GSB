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
    public partial class ViewAntecedents : Form
    {
        private int Id_p {  get; set; }
        public ViewAntecedents(int id_p)
        {
            Id_p = id_p;
            InitializeComponent();
            UpdateDataGridView(id_p);
            this.Activated += ViewAntecedents_Activated;

        }

        private void ViewAntecedents_Activated(object sender, EventArgs e)
        {
            UpdateDataGridView(Id_p);
        }

        private void UpdateDataGridView(int id_p)
        {
            AntecedentDataAccess dataAccess = new AntecedentDataAccess();
            this.Grid_Antecedent.DataSource = null;
            this.Grid_Antecedent.DataSource = dataAccess.GetAntecedentListFromDB(id_p);
        }

        private void ViewAntecedents_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            AttributeAntecedent attributeAntecedent = new AttributeAntecedent(Id_p);
            attributeAntecedent.Show();
        }
    }
}
