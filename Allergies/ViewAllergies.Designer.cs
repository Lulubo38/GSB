namespace GeStionB.Allergies
{
    partial class ViewAllergies
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ViewAllergies));
            Grid_Allergies = new DataGridView();
            btn_AtributeAllergie = new Button();
            ((System.ComponentModel.ISupportInitialize)Grid_Allergies).BeginInit();
            SuspendLayout();
            // 
            // Grid_Allergies
            // 
            Grid_Allergies.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            Grid_Allergies.Location = new Point(67, 54);
            Grid_Allergies.Name = "Grid_Allergies";
            Grid_Allergies.RowHeadersWidth = 92;
            Grid_Allergies.RowTemplate.Height = 45;
            Grid_Allergies.Size = new Size(860, 625);
            Grid_Allergies.TabIndex = 0;
            // 
            // btn_AtributeAllergie
            // 
            btn_AtributeAllergie.Location = new Point(763, 784);
            btn_AtributeAllergie.Name = "btn_AtributeAllergie";
            btn_AtributeAllergie.Size = new Size(314, 52);
            btn_AtributeAllergie.TabIndex = 1;
            btn_AtributeAllergie.Text = "Attribuer une allergie";
            btn_AtributeAllergie.UseVisualStyleBackColor = true;
            btn_AtributeAllergie.Click += btn_AtributeAllergie_Click;
            // 
            // ViewAllergies
            // 
            AutoScaleDimensions = new SizeF(15F, 37F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1130, 877);
            Controls.Add(btn_AtributeAllergie);
            Controls.Add(Grid_Allergies);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "ViewAllergies";
            Text = "Allergies";
            Load += ViewAllergies_Load;
            ((System.ComponentModel.ISupportInitialize)Grid_Allergies).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView Grid_Allergies;
        private Button btn_AtributeAllergie;
    }
}