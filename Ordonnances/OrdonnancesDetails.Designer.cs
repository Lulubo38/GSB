namespace GeStionB.Ordonnances
{
    partial class OrdonnancesDetails
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(OrdonnancesDetails));
            btnCreatePDF = new Button();
            boxPosologie = new TextBox();
            boxDate = new TextBox();
            boxDuree = new TextBox();
            boxInstructions = new TextBox();
            comboMedicament = new ComboBox();
            comboPatient = new ComboBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            boxId = new TextBox();
            label8 = new Label();
            btn_suppOrdonnance = new Button();
            boxMedecin = new TextBox();
            SuspendLayout();
            // 
            // btnCreatePDF
            // 
            btnCreatePDF.Location = new Point(935, 644);
            btnCreatePDF.Name = "btnCreatePDF";
            btnCreatePDF.Size = new Size(228, 52);
            btnCreatePDF.TabIndex = 0;
            btnCreatePDF.Text = "Generer le PDF";
            btnCreatePDF.UseVisualStyleBackColor = true;
            btnCreatePDF.Click += btnCreatePDF_Click;
            // 
            // boxPosologie
            // 
            boxPosologie.Location = new Point(108, 146);
            boxPosologie.Name = "boxPosologie";
            boxPosologie.Size = new Size(225, 43);
            boxPosologie.TabIndex = 1;
            // 
            // boxDate
            // 
            boxDate.Location = new Point(466, 146);
            boxDate.Name = "boxDate";
            boxDate.ReadOnly = true;
            boxDate.Size = new Size(225, 43);
            boxDate.TabIndex = 2;
            // 
            // boxDuree
            // 
            boxDuree.Location = new Point(888, 159);
            boxDuree.Name = "boxDuree";
            boxDuree.Size = new Size(225, 43);
            boxDuree.TabIndex = 3;
            // 
            // boxInstructions
            // 
            boxInstructions.Location = new Point(113, 344);
            boxInstructions.Name = "boxInstructions";
            boxInstructions.Size = new Size(225, 43);
            boxInstructions.TabIndex = 4;
            // 
            // comboMedicament
            // 
            comboMedicament.FormattingEnabled = true;
            comboMedicament.Location = new Point(113, 468);
            comboMedicament.Name = "comboMedicament";
            comboMedicament.Size = new Size(272, 45);
            comboMedicament.TabIndex = 5;
            // 
            // comboPatient
            // 
            comboPatient.FormattingEnabled = true;
            comboPatient.Location = new Point(481, 468);
            comboPatient.Name = "comboPatient";
            comboPatient.Size = new Size(272, 45);
            comboPatient.TabIndex = 6;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(113, 82);
            label1.Name = "label1";
            label1.Size = new Size(134, 37);
            label1.TabIndex = 8;
            label1.Text = "Posologie";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(466, 68);
            label2.Name = "label2";
            label2.Size = new Size(213, 37);
            label2.TabIndex = 9;
            label2.Text = "Date de création";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(837, 92);
            label3.Name = "label3";
            label3.Size = new Size(357, 37);
            label3.TabIndex = 10;
            label3.Text = "Durée du traitement en jours";
            label3.Click += label3_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(113, 281);
            label4.Name = "label4";
            label4.Size = new Size(269, 37);
            label4.TabIndex = 11;
            label4.Text = "Instruction spécifique";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(113, 411);
            label5.Name = "label5";
            label5.Size = new Size(259, 37);
            label5.TabIndex = 12;
            label5.Text = "Medicament prescrit";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(481, 411);
            label6.Name = "label6";
            label6.Size = new Size(99, 37);
            label6.TabIndex = 13;
            label6.Text = "Patient";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(854, 411);
            label7.Name = "label7";
            label7.Size = new Size(119, 37);
            label7.TabIndex = 14;
            label7.Text = "Medecin";
            // 
            // boxId
            // 
            boxId.Location = new Point(466, 344);
            boxId.Name = "boxId";
            boxId.ReadOnly = true;
            boxId.Size = new Size(225, 43);
            boxId.TabIndex = 15;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(466, 281);
            label8.Name = "label8";
            label8.Size = new Size(138, 37);
            label8.TabIndex = 16;
            label8.Text = "Identifiant";
            // 
            // btn_suppOrdonnance
            // 
            btn_suppOrdonnance.Location = new Point(98, 659);
            btn_suppOrdonnance.Name = "btn_suppOrdonnance";
            btn_suppOrdonnance.Size = new Size(316, 52);
            btn_suppOrdonnance.TabIndex = 17;
            btn_suppOrdonnance.Text = "Supprimer l'ordonnance";
            btn_suppOrdonnance.UseVisualStyleBackColor = true;
            btn_suppOrdonnance.Click += btn_suppOrdonnance_Click;
            // 
            // boxMedecin
            // 
            boxMedecin.Location = new Point(854, 479);
            boxMedecin.Name = "boxMedecin";
            boxMedecin.ReadOnly = true;
            boxMedecin.Size = new Size(225, 43);
            boxMedecin.TabIndex = 18;
            // 
            // OrdonnancesDetails
            // 
            AutoScaleDimensions = new SizeF(15F, 37F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1221, 782);
            Controls.Add(boxMedecin);
            Controls.Add(btn_suppOrdonnance);
            Controls.Add(label8);
            Controls.Add(boxId);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(comboPatient);
            Controls.Add(comboMedicament);
            Controls.Add(boxInstructions);
            Controls.Add(boxDuree);
            Controls.Add(boxDate);
            Controls.Add(boxPosologie);
            Controls.Add(btnCreatePDF);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "OrdonnancesDetails";
            Text = "Détails de l'ordonnance";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnCreatePDF;
        private TextBox boxPosologie;
        private TextBox boxDate;
        private TextBox boxDuree;
        private TextBox boxInstructions;
        private ComboBox comboMedicament;
        private ComboBox comboPatient;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private TextBox boxId;
        private Label label8;
        private Button btn_suppOrdonnance;
        private TextBox boxMedecin;
    }
}