namespace GeStionB.Medecin
{
    partial class LoginPage
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoginPage));
            Btn_Login_valid = new Button();
            Box_Login_Username = new TextBox();
            Box_Login_Password = new TextBox();
            label1 = new Label();
            label2 = new Label();
            btn_addUser = new Button();
            pictureBox1 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // Btn_Login_valid
            // 
            Btn_Login_valid.Location = new Point(184, 251);
            Btn_Login_valid.Margin = new Padding(1);
            Btn_Login_valid.Name = "Btn_Login_valid";
            Btn_Login_valid.Size = new Size(79, 21);
            Btn_Login_valid.TabIndex = 3;
            Btn_Login_valid.Text = "Valider";
            Btn_Login_valid.UseVisualStyleBackColor = true;
            Btn_Login_valid.Click += Btn_Login_valid_Click;
            // 
            // Box_Login_Username
            // 
            Box_Login_Username.Location = new Point(174, 170);
            Box_Login_Username.Margin = new Padding(1);
            Box_Login_Username.Name = "Box_Login_Username";
            Box_Login_Username.Size = new Size(107, 23);
            Box_Login_Username.TabIndex = 1;
            // 
            // Box_Login_Password
            // 
            Box_Login_Password.Location = new Point(174, 214);
            Box_Login_Password.Margin = new Padding(1);
            Box_Login_Password.Name = "Box_Login_Password";
            Box_Login_Password.Size = new Size(107, 23);
            Box_Login_Password.TabIndex = 2;
            Box_Login_Password.UseSystemPasswordChar = true;
            Box_Login_Password.KeyPress += Box_Login_Password_KeyPress;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(174, 147);
            label1.Margin = new Padding(1, 0, 1, 0);
            label1.Name = "label1";
            label1.Size = new Size(61, 15);
            label1.TabIndex = 3;
            label1.Text = "Identifiant";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(174, 193);
            label2.Margin = new Padding(1, 0, 1, 0);
            label2.Name = "label2";
            label2.Size = new Size(77, 15);
            label2.TabIndex = 4;
            label2.Text = "Mot de passe";
            // 
            // btn_addUser
            // 
            btn_addUser.Location = new Point(374, 286);
            btn_addUser.Margin = new Padding(1);
            btn_addUser.Name = "btn_addUser";
            btn_addUser.Size = new Size(115, 21);
            btn_addUser.TabIndex = 5;
            btn_addUser.Text = "Créer un compte";
            btn_addUser.UseVisualStyleBackColor = true;
            btn_addUser.Click += btn_addUser_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(85, 13);
            pictureBox1.Margin = new Padding(1);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(298, 133);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 6;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // LoginPage
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(507, 324);
            Controls.Add(pictureBox1);
            Controls.Add(btn_addUser);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(Box_Login_Password);
            Controls.Add(Box_Login_Username);
            Controls.Add(Btn_Login_valid);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(1);
            Name = "LoginPage";
            Text = "Page de connexion";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button Btn_Login_valid;
        private TextBox Box_Login_Username;
        private TextBox Box_Login_Password;
        private Label label1;
        private Label label2;
        private Button btn_addUser;
        private PictureBox pictureBox1;
    }
}