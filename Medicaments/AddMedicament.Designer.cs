namespace GeStionB.Medicaments
{
    partial class AddMedicament
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddMedicament));
            label_addMedicament_libelle = new Label();
            Box_AddMedicament_libelle = new TextBox();
            Btn_AddMedicament_Ajouter = new Button();
            SuspendLayout();
            // 
            // label_addMedicament_libelle
            // 
            label_addMedicament_libelle.AutoSize = true;
            label_addMedicament_libelle.Location = new Point(166, 114);
            label_addMedicament_libelle.Name = "label_addMedicament_libelle";
            label_addMedicament_libelle.Size = new Size(287, 37);
            label_addMedicament_libelle.TabIndex = 2;
            label_addMedicament_libelle.Text = "Libellé du médicament";
            // 
            // Box_AddMedicament_libelle
            // 
            Box_AddMedicament_libelle.Location = new Point(196, 199);
            Box_AddMedicament_libelle.Name = "Box_AddMedicament_libelle";
            Box_AddMedicament_libelle.Size = new Size(225, 43);
            Box_AddMedicament_libelle.TabIndex = 3;
            // 
            // Btn_AddMedicament_Ajouter
            // 
            Btn_AddMedicament_Ajouter.Location = new Point(183, 302);
            Btn_AddMedicament_Ajouter.Name = "Btn_AddMedicament_Ajouter";
            Btn_AddMedicament_Ajouter.Size = new Size(270, 55);
            Btn_AddMedicament_Ajouter.TabIndex = 5;
            Btn_AddMedicament_Ajouter.Text = "Créer le médicament";
            Btn_AddMedicament_Ajouter.UseVisualStyleBackColor = true;
            Btn_AddMedicament_Ajouter.Click += Btn_AddMedicament_Ajouter_Click;
            // 
            // AddMedicament
            // 
            AutoScaleDimensions = new SizeF(15F, 37F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(656, 420);
            Controls.Add(Btn_AddMedicament_Ajouter);
            Controls.Add(Box_AddMedicament_libelle);
            Controls.Add(label_addMedicament_libelle);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "AddMedicament";
            Text = "Ajouter un médicament";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label label_addMedicament_libelle;
        private TextBox Box_AddMedicament_libelle;
        private Button Btn_AddMedicament_Ajouter;
    }
}