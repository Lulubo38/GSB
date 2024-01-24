namespace GeStionB.Ordonnances
{
    partial class ViewOrdonnances
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ViewOrdonnances));
            gridOrdonnance = new DataGridView();
            btn_AddOrdonnance = new Button();
            ((System.ComponentModel.ISupportInitialize)gridOrdonnance).BeginInit();
            SuspendLayout();
            // 
            // gridOrdonnance
            // 
            gridOrdonnance.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            gridOrdonnance.Location = new Point(60, 57);
            gridOrdonnance.Name = "gridOrdonnance";
            gridOrdonnance.RowHeadersWidth = 92;
            gridOrdonnance.RowTemplate.Height = 45;
            gridOrdonnance.Size = new Size(1884, 838);
            gridOrdonnance.TabIndex = 0;
            gridOrdonnance.CellContentClick += gridOrdonnance_CellContentClick;
            // 
            // btn_AddOrdonnance
            // 
            btn_AddOrdonnance.Location = new Point(1635, 930);
            btn_AddOrdonnance.Name = "btn_AddOrdonnance";
            btn_AddOrdonnance.Size = new Size(309, 52);
            btn_AddOrdonnance.TabIndex = 1;
            btn_AddOrdonnance.Text = "Creer une ordonnance";
            btn_AddOrdonnance.UseVisualStyleBackColor = true;
            btn_AddOrdonnance.Click += btn_AddOrdonnance_Click;
            // 
            // ViewOrdonnances
            // 
            AutoScaleDimensions = new SizeF(15F, 37F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(2026, 1042);
            Controls.Add(btn_AddOrdonnance);
            Controls.Add(gridOrdonnance);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "ViewOrdonnances";
            Text = "Liste des ordonnances";
            ((System.ComponentModel.ISupportInitialize)gridOrdonnance).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView gridOrdonnance;
        private Button btn_AddOrdonnance;
    }
}