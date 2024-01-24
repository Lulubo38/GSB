namespace GeStionB.Allergies
{
    partial class AddAllergies
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
            label_libelleAllergies = new Label();
            Box_libelleAllergie = new TextBox();
            btn_CreateAllergie_Validate = new Button();
            SuspendLayout();
            // 
            // label_libelleAllergies
            // 
            label_libelleAllergies.AutoSize = true;
            label_libelleAllergies.Location = new Point(179, 134);
            label_libelleAllergies.Name = "label_libelleAllergies";
            label_libelleAllergies.Size = new Size(240, 37);
            label_libelleAllergies.TabIndex = 1;
            label_libelleAllergies.Text = "Libelle de l'allergie";
            // 
            // Box_libelleAllergie
            // 
            Box_libelleAllergie.Location = new Point(184, 202);
            Box_libelleAllergie.Name = "Box_libelleAllergie";
            Box_libelleAllergie.Size = new Size(225, 43);
            Box_libelleAllergie.TabIndex = 2;
            // 
            // btn_CreateAllergie_Validate
            // 
            btn_CreateAllergie_Validate.Location = new Point(446, 438);
            btn_CreateAllergie_Validate.Name = "btn_CreateAllergie_Validate";
            btn_CreateAllergie_Validate.Size = new Size(390, 52);
            btn_CreateAllergie_Validate.TabIndex = 3;
            btn_CreateAllergie_Validate.TabStop = false;
            btn_CreateAllergie_Validate.Text = "Valider la création de l'allergie";
            btn_CreateAllergie_Validate.UseVisualStyleBackColor = true;
            btn_CreateAllergie_Validate.Click += btn_CreateAllergie_Validate_Click;
            // 
            // AddAllergies
            // 
            AutoScaleDimensions = new SizeF(15F, 37F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(972, 554);
            Controls.Add(btn_CreateAllergie_Validate);
            Controls.Add(Box_libelleAllergie);
            Controls.Add(label_libelleAllergies);
            Name = "AddAllergies";
            Text = "AddAllergies";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label_libelleAllergies;
        private TextBox Box_libelleAllergie;
        private Button btn_CreateAllergie_Validate;
    }
}