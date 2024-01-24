namespace GeStionB.Antecedent
{
    partial class AttributeAntecedent
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AttributeAntecedent));
            combo_antecedents = new ComboBox();
            label_attributeAntecedent = new Label();
            btn_valid_attributAnT = new Button();
            Btn_AddAntecedent = new Button();
            SuspendLayout();
            // 
            // combo_antecedents
            // 
            combo_antecedents.FormattingEnabled = true;
            combo_antecedents.Location = new Point(159, 133);
            combo_antecedents.Name = "combo_antecedents";
            combo_antecedents.Size = new Size(272, 45);
            combo_antecedents.TabIndex = 0;
            // 
            // label_attributeAntecedent
            // 
            label_attributeAntecedent.AutoSize = true;
            label_attributeAntecedent.Location = new Point(67, 56);
            label_attributeAntecedent.Name = "label_attributeAntecedent";
            label_attributeAntecedent.Size = new Size(491, 37);
            label_attributeAntecedent.TabIndex = 1;
            label_attributeAntecedent.Text = "Quel antecedent voulez-vouz attribuer ?";
            // 
            // btn_valid_attributAnT
            // 
            btn_valid_attributAnT.Location = new Point(206, 220);
            btn_valid_attributAnT.Name = "btn_valid_attributAnT";
            btn_valid_attributAnT.Size = new Size(169, 52);
            btn_valid_attributAnT.TabIndex = 2;
            btn_valid_attributAnT.Text = "Valider";
            btn_valid_attributAnT.UseVisualStyleBackColor = true;
            btn_valid_attributAnT.Click += btn_valid_attributAnT_Click;
            // 
            // Btn_AddAntecedent
            // 
            Btn_AddAntecedent.Location = new Point(579, 128);
            Btn_AddAntecedent.Name = "Btn_AddAntecedent";
            Btn_AddAntecedent.Size = new Size(370, 52);
            Btn_AddAntecedent.TabIndex = 3;
            Btn_AddAntecedent.Text = "Ajouter un antecedent";
            Btn_AddAntecedent.UseVisualStyleBackColor = true;
            Btn_AddAntecedent.Click += Btn_AddAntecedent_Click;
            // 
            // AttributeAntecedent
            // 
            AutoScaleDimensions = new SizeF(15F, 37F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(993, 346);
            Controls.Add(Btn_AddAntecedent);
            Controls.Add(btn_valid_attributAnT);
            Controls.Add(label_attributeAntecedent);
            Controls.Add(combo_antecedents);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "AttributeAntecedent";
            Text = "Attribuer des antecedents";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox combo_antecedents;
        private Label label_attributeAntecedent;
        private Button btn_valid_attributAnT;
        private Button Btn_AddAntecedent;
    }
}