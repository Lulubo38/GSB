
namespace GeStionB.Antecedent
{
    partial class ViewAntecedents
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ViewAntecedents));
            Grid_Antecedent = new DataGridView();
            button1 = new Button();
            ((System.ComponentModel.ISupportInitialize)Grid_Antecedent).BeginInit();
            SuspendLayout();
            // 
            // Grid_Antecedent
            // 
            Grid_Antecedent.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            Grid_Antecedent.Location = new Point(45, 34);
            Grid_Antecedent.Name = "Grid_Antecedent";
            Grid_Antecedent.RowHeadersWidth = 92;
            Grid_Antecedent.RowTemplate.Height = 45;
            Grid_Antecedent.Size = new Size(911, 719);
            Grid_Antecedent.TabIndex = 0;
            // 
            // button1
            // 
            button1.Location = new Point(513, 799);
            button1.Name = "button1";
            button1.Size = new Size(406, 52);
            button1.TabIndex = 1;
            button1.Text = "Attribuer un nouvel antecedent";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // ViewAntecedents
            // 
            AutoScaleDimensions = new SizeF(15F, 37F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1017, 884);
            Controls.Add(button1);
            Controls.Add(Grid_Antecedent);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "ViewAntecedents";
            Text = "Antecedents";
            Load += ViewAntecedents_Load;
            ((System.ComponentModel.ISupportInitialize)Grid_Antecedent).EndInit();
            ResumeLayout(false);
        }

        private DataGridView Grid_Antecedent;
        private Button button1;
    }
    #endregion
}