namespace Hotel_Management
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges1 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges2 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges3 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges4 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges5 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges6 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges7 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges8 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges9 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            panel1 = new Panel();
            btnexit = new Guna.UI2.WinForms.Guna2CircleButton();
            label3 = new Label();
            labelError = new Label();
            btnLogin = new Guna.UI2.WinForms.Guna2Button();
            txtPassword = new Guna.UI2.WinForms.Guna2TextBox();
            txtUsername = new Guna.UI2.WinForms.Guna2TextBox();
            guna2CirclePictureBox2 = new Guna.UI2.WinForms.Guna2CirclePictureBox();
            guna2CirclePictureBox1 = new Guna.UI2.WinForms.Guna2CirclePictureBox();
            label1 = new Label();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)guna2CirclePictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)guna2CirclePictureBox1).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.White;
            panel1.Controls.Add(btnexit);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(labelError);
            panel1.Controls.Add(btnLogin);
            panel1.Controls.Add(txtPassword);
            panel1.Controls.Add(txtUsername);
            panel1.Controls.Add(guna2CirclePictureBox2);
            panel1.Controls.Add(guna2CirclePictureBox1);
            panel1.Controls.Add(label1);
            panel1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            panel1.Location = new Point(458, 174);
            panel1.Name = "panel1";
            panel1.Size = new Size(1049, 619);
            panel1.TabIndex = 0;
            // 
            // btnexit
            // 
            btnexit.DisabledState.BorderColor = Color.DarkGray;
            btnexit.DisabledState.CustomBorderColor = Color.DarkGray;
            btnexit.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            btnexit.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            btnexit.FillColor = Color.Empty;
            btnexit.Font = new Font("Segoe UI", 9F);
            btnexit.ForeColor = Color.White;
            btnexit.Image = (Image)resources.GetObject("btnexit.Image");
            btnexit.ImageSize = new Size(30, 30);
            btnexit.Location = new Point(3, 3);
            btnexit.Name = "btnexit";
            btnexit.ShadowDecoration.CustomizableEdges = customizableEdges1;
            btnexit.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            btnexit.Size = new Size(70, 50);
            btnexit.TabIndex = 8;
            btnexit.Click += btnexit_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Italic, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.Silver;
            label3.Location = new Point(279, 557);
            label3.Name = "label3";
            label3.Size = new Size(625, 18);
            label3.TabIndex = 7;
            label3.Text = "You will accept our terms and condition when you login using correct username and password";
            // 
            // labelError
            // 
            labelError.AutoSize = true;
            labelError.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelError.ForeColor = Color.Red;
            labelError.Location = new Point(652, 464);
            labelError.Name = "labelError";
            labelError.Size = new Size(222, 20);
            labelError.TabIndex = 6;
            labelError.Text = "Worng Username or Password";
            labelError.Visible = false;
            // 
            // btnLogin
            // 
            btnLogin.BorderRadius = 22;
            btnLogin.CustomizableEdges = customizableEdges2;
            btnLogin.DisabledState.BorderColor = Color.DarkGray;
            btnLogin.DisabledState.CustomBorderColor = Color.DarkGray;
            btnLogin.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            btnLogin.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            btnLogin.FillColor = Color.FromArgb(0, 192, 0);
            btnLogin.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnLogin.ForeColor = Color.White;
            btnLogin.Location = new Point(620, 374);
            btnLogin.Name = "btnLogin";
            btnLogin.ShadowDecoration.CustomizableEdges = customizableEdges3;
            btnLogin.Size = new Size(299, 56);
            btnLogin.TabIndex = 5;
            btnLogin.Text = "Login";
            btnLogin.Click += btnLogin_Click;
            // 
            // txtPassword
            // 
            txtPassword.BorderRadius = 18;
            txtPassword.CustomizableEdges = customizableEdges4;
            txtPassword.DefaultText = "";
            txtPassword.DisabledState.BorderColor = Color.FromArgb(208, 208, 208);
            txtPassword.DisabledState.FillColor = Color.FromArgb(226, 226, 226);
            txtPassword.DisabledState.ForeColor = Color.FromArgb(138, 138, 138);
            txtPassword.DisabledState.PlaceholderForeColor = Color.FromArgb(138, 138, 138);
            txtPassword.FillColor = Color.FromArgb(224, 224, 224);
            txtPassword.FocusedState.BorderColor = Color.FromArgb(94, 148, 255);
            txtPassword.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtPassword.ForeColor = Color.Black;
            txtPassword.HoverState.BorderColor = Color.FromArgb(94, 148, 255);
            txtPassword.IconLeft = (Image)resources.GetObject("txtPassword.IconLeft");
            txtPassword.IconLeftSize = new Size(30, 30);
            txtPassword.Location = new Point(620, 257);
            txtPassword.Margin = new Padding(4, 6, 4, 6);
            txtPassword.Name = "txtPassword";
            txtPassword.PasswordChar = '*';
            txtPassword.PlaceholderText = "Password";
            txtPassword.SelectedText = "";
            txtPassword.ShadowDecoration.CustomizableEdges = customizableEdges5;
            txtPassword.Size = new Size(311, 66);
            txtPassword.TabIndex = 4;
            txtPassword.TextAlign = HorizontalAlignment.Center;
            // 
            // txtUsername
            // 
            txtUsername.BorderRadius = 18;
            txtUsername.CustomizableEdges = customizableEdges6;
            txtUsername.DefaultText = "";
            txtUsername.DisabledState.BorderColor = Color.FromArgb(208, 208, 208);
            txtUsername.DisabledState.FillColor = Color.FromArgb(226, 226, 226);
            txtUsername.DisabledState.ForeColor = Color.FromArgb(138, 138, 138);
            txtUsername.DisabledState.PlaceholderForeColor = Color.FromArgb(138, 138, 138);
            txtUsername.FillColor = Color.FromArgb(224, 224, 224);
            txtUsername.FocusedState.BorderColor = Color.FromArgb(94, 148, 255);
            txtUsername.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtUsername.ForeColor = Color.Black;
            txtUsername.HoverState.BorderColor = Color.FromArgb(94, 148, 255);
            txtUsername.IconLeft = (Image)resources.GetObject("txtUsername.IconLeft");
            txtUsername.IconLeftSize = new Size(30, 30);
            txtUsername.Location = new Point(620, 156);
            txtUsername.Margin = new Padding(4, 6, 4, 6);
            txtUsername.Name = "txtUsername";
            txtUsername.PlaceholderText = "Username";
            txtUsername.SelectedText = "";
            txtUsername.ShadowDecoration.CustomizableEdges = customizableEdges7;
            txtUsername.Size = new Size(311, 66);
            txtUsername.TabIndex = 3;
            txtUsername.TextAlign = HorizontalAlignment.Center;
            // 
            // guna2CirclePictureBox2
            // 
            guna2CirclePictureBox2.BackColor = Color.Transparent;
            guna2CirclePictureBox2.Image = (Image)resources.GetObject("guna2CirclePictureBox2.Image");
            guna2CirclePictureBox2.ImageRotate = 0F;
            guna2CirclePictureBox2.Location = new Point(136, 127);
            guna2CirclePictureBox2.Name = "guna2CirclePictureBox2";
            guna2CirclePictureBox2.ShadowDecoration.CustomizableEdges = customizableEdges8;
            guna2CirclePictureBox2.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            guna2CirclePictureBox2.Size = new Size(367, 342);
            guna2CirclePictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            guna2CirclePictureBox2.TabIndex = 2;
            guna2CirclePictureBox2.TabStop = false;
            guna2CirclePictureBox2.UseTransparentBackground = true;
            // 
            // guna2CirclePictureBox1
            // 
            guna2CirclePictureBox1.Image = (Image)resources.GetObject("guna2CirclePictureBox1.Image");
            guna2CirclePictureBox1.ImageRotate = 0F;
            guna2CirclePictureBox1.Location = new Point(136, 156);
            guna2CirclePictureBox1.Name = "guna2CirclePictureBox1";
            guna2CirclePictureBox1.ShadowDecoration.CustomizableEdges = customizableEdges9;
            guna2CirclePictureBox1.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            guna2CirclePictureBox1.Size = new Size(367, 328);
            guna2CirclePictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            guna2CirclePictureBox1.TabIndex = 1;
            guna2CirclePictureBox1.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Comic Sans MS", 22.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(664, 53);
            label1.Name = "label1";
            label1.Size = new Size(210, 51);
            label1.TabIndex = 0;
            label1.Text = "User Login";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1677, 835);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            WindowState = FormWindowState.Maximized;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)guna2CirclePictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)guna2CirclePictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Label label1;
        private Guna.UI2.WinForms.Guna2CirclePictureBox guna2CirclePictureBox2;
        private Guna.UI2.WinForms.Guna2CirclePictureBox guna2CirclePictureBox1;
        private Guna.UI2.WinForms.Guna2TextBox txtUsername;
        private Guna.UI2.WinForms.Guna2TextBox txtPassword;
        private Guna.UI2.WinForms.Guna2Button btnLogin;
        private Label label3;
        private Label labelError;
        private Guna.UI2.WinForms.Guna2CircleButton btnexit;
    }
}
