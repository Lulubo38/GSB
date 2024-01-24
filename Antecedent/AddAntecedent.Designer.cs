namespace GeStionB.Antecedent
{
    partial class AddAntecedent
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
            label_libelleAntecedent = new Label();
            Box_addAntecedent_libelle = new TextBox();
            btn_ajoutAntecedent = new Button();
            SuspendLayout();
            // 
            // label_libelleAntecedent
            // 
            label_libelleAntecedent.AutoSize = true;
            label_libelleAntecedent.Location = new Point(192, 187);
            label_libelleAntecedent.Name = "label_libelleAntecedent";
            label_libelleAntecedent.Size = new Size(284, 37);
            label_libelleAntecedent.TabIndex = 0;
            label_libelleAntecedent.Text = "Libelle de l'antecedent";
            // 
            // Box_addAntecedent_libelle
            // 
            Box_addAntecedent_libelle.Location = new Point(199, 293);
            Box_addAntecedent_libelle.Name = "Box_addAntecedent_libelle";
            Box_addAntecedent_libelle.Size = new Size(225, 43);
            Box_addAntecedent_libelle.TabIndex = 1;
            // 
            // btn_ajoutAntecedent
            // 
            btn_ajoutAntecedent.Location = new Point(717, 748);
            btn_ajoutAntecedent.Name = "btn_ajoutAntecedent";
            btn_ajoutAntecedent.Size = new Size(273, 52);
            btn_ajoutAntecedent.TabIndex = 2;
            btn_ajoutAntecedent.Text = "Valider la création";
            btn_ajoutAntecedent.UseVisualStyleBackColor = true;
            btn_ajoutAntecedent.Click += btn_ajoutAntecedent_Click;
            // 
            // AddAntecedent
            // 
            AutoScaleDimensions = new SizeF(15F, 37F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1046, 865);
            Controls.Add(btn_ajoutAntecedent);
            Controls.Add(Box_addAntecedent_libelle);
            Controls.Add(label_libelleAntecedent);
            Name = "AddAntecedent";
            Text = "AddAntecedent";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label_libelleAntecedent;
        private TextBox Box_addAntecedent_libelle;
        private Button btn_ajoutAntecedent;
    }
}