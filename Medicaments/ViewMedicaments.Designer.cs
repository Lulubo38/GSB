namespace GeStionB.Medicaments
{
    partial class ViewMedicaments
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ViewMedicaments));
            MedicamentGridView = new DataGridView();
            Button_addMedicament = new Button();
            ((System.ComponentModel.ISupportInitialize)MedicamentGridView).BeginInit();
            SuspendLayout();
            // 
            // MedicamentGridView
            // 
            MedicamentGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            MedicamentGridView.Location = new Point(55, 55);
            MedicamentGridView.Name = "MedicamentGridView";
            MedicamentGridView.RowHeadersWidth = 92;
            MedicamentGridView.RowTemplate.Height = 45;
            MedicamentGridView.Size = new Size(1122, 823);
            MedicamentGridView.TabIndex = 0;
            MedicamentGridView.CellContentClick += MedicamentGridView_CellContentClick;
            // 
            // Button_addMedicament
            // 
            Button_addMedicament.Location = new Point(863, 929);
            Button_addMedicament.Name = "Button_addMedicament";
            Button_addMedicament.Size = new Size(327, 73);
            Button_addMedicament.TabIndex = 1;
            Button_addMedicament.Text = "Ajouter un médicament";
            Button_addMedicament.UseVisualStyleBackColor = true;
            Button_addMedicament.Click += Button_addMedicament_Click;
            // 
            // ViewMedicaments
            // 
            AutoScaleDimensions = new SizeF(15F, 37F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1235, 1037);
            Controls.Add(Button_addMedicament);
            Controls.Add(MedicamentGridView);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "ViewMedicaments";
            Text = "Liste des medicaments";
            ((System.ComponentModel.ISupportInitialize)MedicamentGridView).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView MedicamentGridView;
        private Button Button_addMedicament;
    }
}