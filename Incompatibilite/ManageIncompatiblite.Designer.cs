namespace GeStionB.Medicaments
{
    partial class ManageIncompatiblite
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ManageIncompatiblite));
            combo_Medicaments = new ComboBox();
            combo_allergie = new ComboBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            combo_antecedents = new ComboBox();
            btn_Incompatibilite_valid = new Button();
            SuspendLayout();
            // 
            // combo_Medicaments
            // 
            combo_Medicaments.FormattingEnabled = true;
            combo_Medicaments.Location = new Point(115, 194);
            combo_Medicaments.Name = "combo_Medicaments";
            combo_Medicaments.Size = new Size(272, 45);
            combo_Medicaments.TabIndex = 0;
            // 
            // combo_allergie
            // 
            combo_allergie.FormattingEnabled = true;
            combo_allergie.Location = new Point(479, 194);
            combo_allergie.Name = "combo_allergie";
            combo_allergie.Size = new Size(272, 45);
            combo_allergie.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(839, 126);
            label1.Name = "label1";
            label1.Size = new Size(152, 37);
            label1.TabIndex = 5;
            label1.Text = "Antecedent";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(479, 126);
            label2.Name = "label2";
            label2.Size = new Size(108, 37);
            label2.TabIndex = 6;
            label2.Text = "Allergie";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(115, 126);
            label3.Name = "label3";
            label3.Size = new Size(165, 37);
            label3.TabIndex = 7;
            label3.Text = "Medicament";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(64, 44);
            label4.Name = "label4";
            label4.Size = new Size(479, 37);
            label4.TabIndex = 8;
            label4.Text = "Ce medicament est incompatible avec :";
            // 
            // combo_antecedents
            // 
            combo_antecedents.FormattingEnabled = true;
            combo_antecedents.Location = new Point(839, 194);
            combo_antecedents.Name = "combo_antecedents";
            combo_antecedents.Size = new Size(272, 45);
            combo_antecedents.TabIndex = 9;
            // 
            // btn_Incompatibilite_valid
            // 
            btn_Incompatibilite_valid.Location = new Point(724, 304);
            btn_Incompatibilite_valid.Name = "btn_Incompatibilite_valid";
            btn_Incompatibilite_valid.Size = new Size(387, 52);
            btn_Incompatibilite_valid.TabIndex = 10;
            btn_Incompatibilite_valid.Text = "Valider l'incompatibilité";
            btn_Incompatibilite_valid.UseVisualStyleBackColor = true;
            btn_Incompatibilite_valid.Click += btn_Incompatibilite_valid_Click;
            // 
            // ManageIncompatiblite
            // 
            AutoScaleDimensions = new SizeF(15F, 37F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1146, 387);
            Controls.Add(btn_Incompatibilite_valid);
            Controls.Add(combo_antecedents);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(combo_allergie);
            Controls.Add(combo_Medicaments);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "ManageIncompatiblite";
            Text = "Gérer les incompatibilités";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox combo_Medicaments;
        private ComboBox combo_allergie;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private ComboBox combo_antecedents;
        private Button btn_Incompatibilite_valid;
    }
}