namespace GeStionB.Allergies
{
    partial class AttributeAllergies
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AttributeAllergies));
            combo_Allergies = new ComboBox();
            label_attributeAllergies = new Label();
            btn_attributeAllergies_valid = new Button();
            btn_createAllergie = new Button();
            SuspendLayout();
            // 
            // combo_Allergies
            // 
            combo_Allergies.FormattingEnabled = true;
            combo_Allergies.Location = new Point(157, 137);
            combo_Allergies.Name = "combo_Allergies";
            combo_Allergies.Size = new Size(272, 45);
            combo_Allergies.TabIndex = 0;
            // 
            // label_attributeAllergies
            // 
            label_attributeAllergies.AutoSize = true;
            label_attributeAllergies.Location = new Point(92, 69);
            label_attributeAllergies.Name = "label_attributeAllergies";
            label_attributeAllergies.Size = new Size(448, 37);
            label_attributeAllergies.TabIndex = 1;
            label_attributeAllergies.Text = "Quelle allergie voulez-vous attribuer";
            // 
            // btn_attributeAllergies_valid
            // 
            btn_attributeAllergies_valid.Location = new Point(164, 267);
            btn_attributeAllergies_valid.Name = "btn_attributeAllergies_valid";
            btn_attributeAllergies_valid.Size = new Size(265, 52);
            btn_attributeAllergies_valid.TabIndex = 2;
            btn_attributeAllergies_valid.Text = "Valider l'attribution";
            btn_attributeAllergies_valid.UseVisualStyleBackColor = true;
            btn_attributeAllergies_valid.Click += btn_attributeAllergies_valid_Click;
            // 
            // btn_createAllergie
            // 
            btn_createAllergie.Location = new Point(522, 137);
            btn_createAllergie.Name = "btn_createAllergie";
            btn_createAllergie.Size = new Size(370, 52);
            btn_createAllergie.TabIndex = 3;
            btn_createAllergie.Text = "Creer une nouvelle allergie";
            btn_createAllergie.UseVisualStyleBackColor = true;
            btn_createAllergie.Click += btn_createAllergie_Click;
            // 
            // AttributeAllergies
            // 
            AutoScaleDimensions = new SizeF(15F, 37F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(962, 400);
            Controls.Add(btn_createAllergie);
            Controls.Add(btn_attributeAllergies_valid);
            Controls.Add(label_attributeAllergies);
            Controls.Add(combo_Allergies);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "AttributeAllergies";
            Text = "Attribuer des allergies";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox combo_Allergies;
        private Label label_attributeAllergies;
        private Button btn_attributeAllergies_valid;
        private Button btn_createAllergie;
    }
}