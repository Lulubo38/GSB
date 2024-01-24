namespace GeStionB.Ordonnances
{
    partial class addOrdonnance
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(addOrdonnance));
            btn_AddOrdonnance = new Button();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            box_posologie = new TextBox();
            box_duree = new TextBox();
            box_instructions = new TextBox();
            comboPatient = new ComboBox();
            comboMedicament = new ComboBox();
            label6 = new Label();
            SuspendLayout();
            // 
            // btn_AddOrdonnance
            // 
            btn_AddOrdonnance.Location = new Point(453, 794);
            btn_AddOrdonnance.Name = "btn_AddOrdonnance";
            btn_AddOrdonnance.Size = new Size(240, 52);
            btn_AddOrdonnance.TabIndex = 0;
            btn_AddOrdonnance.Text = "Valider la création";
            btn_AddOrdonnance.UseVisualStyleBackColor = true;
            btn_AddOrdonnance.Click += btn_AddOrdonnance_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(54, 47);
            label1.Name = "label1";
            label1.Size = new Size(134, 37);
            label1.TabIndex = 1;
            label1.Text = "Posologie";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(392, 47);
            label2.Name = "label2";
            label2.Size = new Size(88, 37);
            label2.TabIndex = 2;
            label2.Text = "Durée";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(54, 398);
            label3.Name = "label3";
            label3.Size = new Size(291, 37);
            label3.TabIndex = 3;
            label3.Text = "Instructions specifiques";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(54, 233);
            label4.Name = "label4";
            label4.Size = new Size(99, 37);
            label4.TabIndex = 4;
            label4.Text = "Patient";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(392, 233);
            label5.Name = "label5";
            label5.Size = new Size(165, 37);
            label5.TabIndex = 5;
            label5.Text = "Medicament";
            // 
            // box_posologie
            // 
            box_posologie.Location = new Point(54, 111);
            box_posologie.Name = "box_posologie";
            box_posologie.Size = new Size(225, 43);
            box_posologie.TabIndex = 6;
            // 
            // box_duree
            // 
            box_duree.Location = new Point(402, 111);
            box_duree.Name = "box_duree";
            box_duree.Size = new Size(225, 43);
            box_duree.TabIndex = 7;
            // 
            // box_instructions
            // 
            box_instructions.Location = new Point(54, 448);
            box_instructions.Multiline = true;
            box_instructions.Name = "box_instructions";
            box_instructions.Size = new Size(639, 287);
            box_instructions.TabIndex = 8;
            // 
            // comboPatient
            // 
            comboPatient.FormattingEnabled = true;
            comboPatient.Location = new Point(54, 284);
            comboPatient.Name = "comboPatient";
            comboPatient.Size = new Size(272, 45);
            comboPatient.TabIndex = 9;
            // 
            // comboMedicament
            // 
            comboMedicament.FormattingEnabled = true;
            comboMedicament.Location = new Point(402, 284);
            comboMedicament.Name = "comboMedicament";
            comboMedicament.Size = new Size(272, 45);
            comboMedicament.TabIndex = 10;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(552, 284);
            label6.Name = "label6";
            label6.Size = new Size(0, 37);
            label6.TabIndex = 11;
            // 
            // addOrdonnance
            // 
            AutoScaleDimensions = new SizeF(15F, 37F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(747, 892);
            Controls.Add(label6);
            Controls.Add(comboMedicament);
            Controls.Add(comboPatient);
            Controls.Add(box_instructions);
            Controls.Add(box_duree);
            Controls.Add(box_posologie);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(btn_AddOrdonnance);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "addOrdonnance";
            Text = "Créer une ordonnance";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btn_AddOrdonnance;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private TextBox box_posologie;
        private TextBox box_duree;
        private TextBox box_instructions;
        private ComboBox comboPatient;
        private ComboBox comboMedicament;
        private Label label6;
    }
}