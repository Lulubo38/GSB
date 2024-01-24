namespace GeStionB.Patients
{
    partial class AddPatient
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddPatient));
            Box_AddPatient_Name = new TextBox();
            Box_AddPatient_Prenom = new TextBox();
            Combo_AddPatient_sexe = new ComboBox();
            label_AddPatient_nom = new Label();
            label_AddPatient_prenom = new Label();
            label_AddPatient_sexe = new Label();
            button_AddPatient_Valid = new Button();
            date_AddPatient = new DateTimePicker();
            label3 = new Label();
            SuspendLayout();
            // 
            // Box_AddPatient_Name
            // 
            Box_AddPatient_Name.Location = new Point(73, 123);
            Box_AddPatient_Name.Name = "Box_AddPatient_Name";
            Box_AddPatient_Name.Size = new Size(225, 43);
            Box_AddPatient_Name.TabIndex = 0;
            Box_AddPatient_Name.TextChanged += textBox1_TextChanged;
            // 
            // Box_AddPatient_Prenom
            // 
            Box_AddPatient_Prenom.Location = new Point(450, 123);
            Box_AddPatient_Prenom.Name = "Box_AddPatient_Prenom";
            Box_AddPatient_Prenom.Size = new Size(225, 43);
            Box_AddPatient_Prenom.TabIndex = 1;
            // 
            // Combo_AddPatient_sexe
            // 
            Combo_AddPatient_sexe.FormattingEnabled = true;
            Combo_AddPatient_sexe.Items.AddRange(new object[] { "Homme", "Femme" });
            Combo_AddPatient_sexe.Location = new Point(73, 255);
            Combo_AddPatient_sexe.Name = "Combo_AddPatient_sexe";
            Combo_AddPatient_sexe.Size = new Size(279, 45);
            Combo_AddPatient_sexe.TabIndex = 8;
            // 
            // label_AddPatient_nom
            // 
            label_AddPatient_nom.AutoSize = true;
            label_AddPatient_nom.Location = new Point(73, 63);
            label_AddPatient_nom.Name = "label_AddPatient_nom";
            label_AddPatient_nom.Size = new Size(76, 37);
            label_AddPatient_nom.TabIndex = 9;
            label_AddPatient_nom.Text = "Nom";
            // 
            // label_AddPatient_prenom
            // 
            label_AddPatient_prenom.AutoSize = true;
            label_AddPatient_prenom.Location = new Point(450, 63);
            label_AddPatient_prenom.Name = "label_AddPatient_prenom";
            label_AddPatient_prenom.Size = new Size(109, 37);
            label_AddPatient_prenom.TabIndex = 10;
            label_AddPatient_prenom.Text = "Prenom";
            // 
            // label_AddPatient_sexe
            // 
            label_AddPatient_sexe.AutoSize = true;
            label_AddPatient_sexe.Location = new Point(78, 204);
            label_AddPatient_sexe.Name = "label_AddPatient_sexe";
            label_AddPatient_sexe.Size = new Size(71, 37);
            label_AddPatient_sexe.TabIndex = 11;
            label_AddPatient_sexe.Text = "Sexe";
            // 
            // button_AddPatient_Valid
            // 
            button_AddPatient_Valid.Location = new Point(941, 344);
            button_AddPatient_Valid.Name = "button_AddPatient_Valid";
            button_AddPatient_Valid.Size = new Size(266, 52);
            button_AddPatient_Valid.TabIndex = 12;
            button_AddPatient_Valid.Text = "Ajouter l'utilisateur";
            button_AddPatient_Valid.UseVisualStyleBackColor = true;
            button_AddPatient_Valid.Click += button_AddPatient_Valid_Click;
            // 
            // date_AddPatient
            // 
            date_AddPatient.CustomFormat = "yyyy-MM-dd";
            date_AddPatient.Format = DateTimePickerFormat.Custom;
            date_AddPatient.Location = new Point(450, 257);
            date_AddPatient.Name = "date_AddPatient";
            date_AddPatient.Size = new Size(450, 43);
            date_AddPatient.TabIndex = 16;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(450, 204);
            label3.Name = "label3";
            label3.Size = new Size(557, 37);
            label3.TabIndex = 15;
            label3.Text = "Date de naissance format : (Année-Mois-Jour)";
            // 
            // AddPatient
            // 
            AutoScaleDimensions = new SizeF(15F, 37F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1229, 422);
            Controls.Add(date_AddPatient);
            Controls.Add(label3);
            Controls.Add(button_AddPatient_Valid);
            Controls.Add(label_AddPatient_sexe);
            Controls.Add(label_AddPatient_prenom);
            Controls.Add(label_AddPatient_nom);
            Controls.Add(Combo_AddPatient_sexe);
            Controls.Add(Box_AddPatient_Prenom);
            Controls.Add(Box_AddPatient_Name);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "AddPatient";
            Text = "Ajouter un patient";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox Box_AddPatient_Name;
        private TextBox Box_AddPatient_Prenom;
        private ComboBox Combo_AddPatient_sexe;
        private Label label_AddPatient_nom;
        private Label label_AddPatient_prenom;
        private Label label_AddPatient_sexe;
        private Button button_AddPatient_Valid;
        private DateTimePicker date_AddPatient;
        private Label label3;
    }
}