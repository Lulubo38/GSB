namespace GeStionB.Medicaments
{
    partial class MedicamentsDetails
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MedicamentsDetails));
            Box_change_libelle = new TextBox();
            btn_MedicamentsDetails_Valid = new Button();
            btn_MNGIncompatibilite = new Button();
            SuspendLayout();
            // 
            // Box_change_libelle
            // 
            Box_change_libelle.Location = new Point(61, 75);
            Box_change_libelle.Name = "Box_change_libelle";
            Box_change_libelle.Size = new Size(225, 43);
            Box_change_libelle.TabIndex = 1;
            // 
            // btn_MedicamentsDetails_Valid
            // 
            btn_MedicamentsDetails_Valid.Location = new Point(486, 217);
            btn_MedicamentsDetails_Valid.Name = "btn_MedicamentsDetails_Valid";
            btn_MedicamentsDetails_Valid.Size = new Size(375, 63);
            btn_MedicamentsDetails_Valid.TabIndex = 6;
            btn_MedicamentsDetails_Valid.Text = "Valider les modifications";
            btn_MedicamentsDetails_Valid.UseVisualStyleBackColor = true;
            btn_MedicamentsDetails_Valid.Click += btn_MedicamentsDetails_Valid_Click;
            // 
            // btn_MNGIncompatibilite
            // 
            btn_MNGIncompatibilite.Location = new Point(415, 75);
            btn_MNGIncompatibilite.Name = "btn_MNGIncompatibilite";
            btn_MNGIncompatibilite.Size = new Size(446, 52);
            btn_MNGIncompatibilite.TabIndex = 7;
            btn_MNGIncompatibilite.Text = "Gérer les incompatibilités";
            btn_MNGIncompatibilite.UseVisualStyleBackColor = true;
            btn_MNGIncompatibilite.Click += button1_Click;
            // 
            // MedicamentsDetails
            // 
            AutoScaleDimensions = new SizeF(15F, 37F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(905, 321);
            Controls.Add(btn_MNGIncompatibilite);
            Controls.Add(btn_MedicamentsDetails_Valid);
            Controls.Add(Box_change_libelle);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "MedicamentsDetails";
            Text = "Détails du médicament";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private TextBox Box_change_libelle;
        private Button btn_MedicamentsDetails_Valid;
        private Button btn_MNGIncompatibilite;
    }
}