namespace GeStionB
{
    partial class Accueil
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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Accueil));
            contextMenuStrip1 = new ContextMenuStrip(components);
            menuStrip1 = new MenuStrip();
            menuStrip2 = new MenuStrip();
            gererLesPatientsToolStripMenuItem = new ToolStripMenuItem();
            gererLesOrdonnacToolStripMenuItem = new ToolStripMenuItem();
            gererLesMedicamentsToolStripMenuItem = new ToolStripMenuItem();
            menuStrip2.SuspendLayout();
            SuspendLayout();
            // 
            // contextMenuStrip1
            // 
            contextMenuStrip1.ImageScalingSize = new Size(36, 36);
            contextMenuStrip1.Name = "contextMenuStrip1";
            contextMenuStrip1.Size = new Size(61, 4);
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(36, 36);
            menuStrip1.Location = new Point(0, 47);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(938, 24);
            menuStrip1.TabIndex = 2;
            menuStrip1.Text = "menuStrip1";
            // 
            // menuStrip2
            // 
            menuStrip2.ImageScalingSize = new Size(36, 36);
            menuStrip2.Items.AddRange(new ToolStripItem[] { gererLesPatientsToolStripMenuItem, gererLesOrdonnacToolStripMenuItem, gererLesMedicamentsToolStripMenuItem });
            menuStrip2.Location = new Point(0, 0);
            menuStrip2.Name = "menuStrip2";
            menuStrip2.Size = new Size(938, 47);
            menuStrip2.TabIndex = 3;
            menuStrip2.Text = "menuStrip2";
            // 
            // gererLesPatientsToolStripMenuItem
            // 
            gererLesPatientsToolStripMenuItem.Name = "gererLesPatientsToolStripMenuItem";
            gererLesPatientsToolStripMenuItem.Size = new Size(245, 43);
            gererLesPatientsToolStripMenuItem.Text = "Gerer les patients";
            gererLesPatientsToolStripMenuItem.Click += gererLesPatiensToolStripMenuItem_Click;
            // 
            // gererLesOrdonnacToolStripMenuItem
            // 
            gererLesOrdonnacToolStripMenuItem.Name = "gererLesOrdonnacToolStripMenuItem";
            gererLesOrdonnacToolStripMenuItem.Size = new Size(303, 43);
            gererLesOrdonnacToolStripMenuItem.Text = "Gerer les ordonnances";
            gererLesOrdonnacToolStripMenuItem.Click += gererLesOrdonnacToolStripMenuItem_Click;
            // 
            // gererLesMedicamentsToolStripMenuItem
            // 
            gererLesMedicamentsToolStripMenuItem.Name = "gererLesMedicamentsToolStripMenuItem";
            gererLesMedicamentsToolStripMenuItem.Size = new Size(308, 43);
            gererLesMedicamentsToolStripMenuItem.Text = "Gerer les medicaments";
            gererLesMedicamentsToolStripMenuItem.Click += gererLesMedicamentsToolStripMenuItem_Click;
            // 
            // Accueil
            // 
            AutoScaleDimensions = new SizeF(15F, 37F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(938, 443);
            Controls.Add(menuStrip1);
            Controls.Add(menuStrip2);
            Icon = (Icon)resources.GetObject("$this.Icon");
            MainMenuStrip = menuStrip1;
            Name = "Accueil";
            Text = "Accueil";
            FormClosing += Accueil_FormClosing;
            menuStrip2.ResumeLayout(false);
            menuStrip2.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private ContextMenuStrip contextMenuStrip1;
        private MenuStrip menuStrip1;
        private MenuStrip menuStrip2;
        private ToolStripMenuItem gererLesPatientsToolStripMenuItem;
        private ToolStripMenuItem gererLesOrdonnacToolStripMenuItem;
        private ToolStripMenuItem gererLesMedicamentsToolStripMenuItem;
    }
}