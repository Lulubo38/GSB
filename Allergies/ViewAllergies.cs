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
    public partial class ViewAllergies : Form
    {
        private int Id_p { get; set; }
        //initialise la variable qui contient l'ID du patient
        public ViewAllergies(int id_p)


        {
            //recupère l'ID passé en parametre et definit la variable Id_p afin
            //de le rentre accessible à toute la classe
            Id_p = id_p;
            //initialise la fentre
            InitializeComponent();
            //appelle la méthode UpdateDataGridView et lui passe en parametre l'id du patient
            UpdateDataGridView(id_p);
            //Evenement qui permet d'actualiser la GridView lorsque la fenetre est active
            this.Activated += ViewAllergies_Activated;
        }

        private void ViewAllergies_Activated(object sender, EventArgs e)
        {
            //appelle la méthode UpdateDataGridView et lui passe en parametre l'id du patient
            UpdateDataGridView(Id_p);
        }

        private void UpdateDataGridView(int id_p)
        {
            //Creer un nouvel objet, dataAccess afin de rendre accessible les methodes de AllergiesDataAccess
            AllergiesDataAccess dataAccess = new AllergiesDataAccess();
            //initialise la grid view à null
            this.Grid_Allergies.DataSource = null;
            //Complete la dataGridView avec les allergies du patient renvoyé par
            //la méthode GetAllergieListFromDB de dataAccess
            this.Grid_Allergies.DataSource = dataAccess.GetAllergieListFromDB(id_p);
        }




        private void btn_AtributeAllergie_Click(object sender, EventArgs e)
        {
            AttributeAllergies attributeAllergies = new AttributeAllergies(Id_p);
            attributeAllergies.Show();
        }

        private void ViewAllergies_Load(object sender, EventArgs e)
        {

        }
    }
}

