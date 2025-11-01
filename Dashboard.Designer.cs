namespace Hotel_Management
{
    partial class Dashboard
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
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges1 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Dashboard));
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges2 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges3 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges4 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges5 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges6 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges7 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges8 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges9 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges10 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges11 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges12 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Panel = new Panel();
            MovingPanel = new Panel();
            btnEmployee = new Guna.UI2.WinForms.Guna2Button();
            btnCustomerDetails = new Guna.UI2.WinForms.Guna2Button();
            btnCheckOut = new Guna.UI2.WinForms.Guna2Button();
            btnCustomerRegistration = new Guna.UI2.WinForms.Guna2Button();
            btnAddRoom = new Guna.UI2.WinForms.Guna2Button();
            panel2 = new Panel();
            uC_Employee1 = new Hotel_Management.All_User_control.UC_Employee();
            uC_CustomerDetail1 = new Hotel_Management.All_User_control.UC_CustomerDetail();
            uC_CustomerCheckOut1 = new Hotel_Management.All_User_control.UC_CustomerCheckOut();
            uC_CustomerRegistration1 = new Hotel_Management.All_User_control.UC_CustomerRegistration();
            uC_AddRoom1 = new Hotel_Management.All_User_control.UC_AddRoom();
            btnExit = new Guna.UI2.WinForms.Guna2CircleButton();
            btnMinimize = new Guna.UI2.WinForms.Guna2CircleButton();
            guna2Elipse1 = new Guna.UI2.WinForms.Guna2Elipse(components);
            guna2Elipse2 = new Guna.UI2.WinForms.Guna2Elipse(components);
            guna2Elipse3 = new Guna.UI2.WinForms.Guna2Elipse(components);
            guna2Elipse4 = new Guna.UI2.WinForms.Guna2Elipse(components);
            guna2Elipse5 = new Guna.UI2.WinForms.Guna2Elipse(components);
            Panel.SuspendLayout();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // Panel
            // 
            Panel.BackColor = Color.FromArgb(0, 64, 64);
            Panel.BorderStyle = BorderStyle.FixedSingle;
            Panel.Controls.Add(MovingPanel);
            Panel.Controls.Add(btnEmployee);
            Panel.Controls.Add(btnCustomerDetails);
            Panel.Controls.Add(btnCheckOut);
            Panel.Controls.Add(btnCustomerRegistration);
            Panel.Controls.Add(btnAddRoom);
            Panel.Location = new Point(97, 12);
            Panel.Name = "Panel";
            Panel.Size = new Size(1676, 130);
            Panel.TabIndex = 0;
            Panel.Paint += panel1_Paint;
            // 
            // MovingPanel
            // 
            MovingPanel.BackColor = Color.Cyan;
            MovingPanel.Location = new Point(18, 111);
            MovingPanel.Name = "MovingPanel";
            MovingPanel.Size = new Size(285, 5);
            MovingPanel.TabIndex = 0;
            // 
            // btnEmployee
            // 
            btnEmployee.BorderRadius = 26;
            btnEmployee.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            btnEmployee.CheckedState.FillColor = Color.White;
            btnEmployee.CheckedState.ForeColor = Color.Black;
            btnEmployee.CustomizableEdges = customizableEdges1;
            btnEmployee.DisabledState.BorderColor = Color.DarkGray;
            btnEmployee.DisabledState.CustomBorderColor = Color.DarkGray;
            btnEmployee.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            btnEmployee.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            btnEmployee.FillColor = Color.FromArgb(0, 64, 64);
            btnEmployee.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnEmployee.ForeColor = Color.White;
            btnEmployee.Image = (Image)resources.GetObject("btnEmployee.Image");
            btnEmployee.ImageSize = new Size(40, 40);
            btnEmployee.Location = new Point(1394, 20);
            btnEmployee.Name = "btnEmployee";
            btnEmployee.ShadowDecoration.CustomizableEdges = customizableEdges2;
            btnEmployee.Size = new Size(249, 85);
            btnEmployee.TabIndex = 1;
            btnEmployee.Text = "Employee";
            btnEmployee.Click += guna2Button5_Click;
            // 
            // btnCustomerDetails
            // 
            btnCustomerDetails.BorderRadius = 26;
            btnCustomerDetails.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            btnCustomerDetails.CheckedState.FillColor = Color.White;
            btnCustomerDetails.CheckedState.ForeColor = Color.Black;
            btnCustomerDetails.CustomizableEdges = customizableEdges3;
            btnCustomerDetails.DisabledState.BorderColor = Color.DarkGray;
            btnCustomerDetails.DisabledState.CustomBorderColor = Color.DarkGray;
            btnCustomerDetails.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            btnCustomerDetails.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            btnCustomerDetails.FillColor = Color.FromArgb(0, 64, 64);
            btnCustomerDetails.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnCustomerDetails.ForeColor = Color.White;
            btnCustomerDetails.Image = (Image)resources.GetObject("btnCustomerDetails.Image");
            btnCustomerDetails.ImageSize = new Size(40, 40);
            btnCustomerDetails.Location = new Point(1019, 20);
            btnCustomerDetails.Name = "btnCustomerDetails";
            btnCustomerDetails.ShadowDecoration.CustomizableEdges = customizableEdges4;
            btnCustomerDetails.Size = new Size(320, 85);
            btnCustomerDetails.TabIndex = 1;
            btnCustomerDetails.Text = "Customer Details";
            btnCustomerDetails.Click += btnCustomerDetails_Click;
            // 
            // btnCheckOut
            // 
            btnCheckOut.BorderRadius = 26;
            btnCheckOut.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            btnCheckOut.CheckedState.FillColor = Color.White;
            btnCheckOut.CheckedState.ForeColor = Color.Black;
            btnCheckOut.CustomizableEdges = customizableEdges5;
            btnCheckOut.DisabledState.BorderColor = Color.DarkGray;
            btnCheckOut.DisabledState.CustomBorderColor = Color.DarkGray;
            btnCheckOut.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            btnCheckOut.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            btnCheckOut.FillColor = Color.FromArgb(0, 64, 64);
            btnCheckOut.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnCheckOut.ForeColor = Color.White;
            btnCheckOut.Image = (Image)resources.GetObject("btnCheckOut.Image");
            btnCheckOut.ImageSize = new Size(40, 40);
            btnCheckOut.Location = new Point(672, 20);
            btnCheckOut.Name = "btnCheckOut";
            btnCheckOut.ShadowDecoration.CustomizableEdges = customizableEdges6;
            btnCheckOut.Size = new Size(308, 85);
            btnCheckOut.TabIndex = 2;
            btnCheckOut.Text = "Check Out";
            btnCheckOut.Click += guna2Button3_Click;
            // 
            // btnCustomerRegistration
            // 
            btnCustomerRegistration.BorderRadius = 26;
            btnCustomerRegistration.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            btnCustomerRegistration.CheckedState.FillColor = Color.White;
            btnCustomerRegistration.CheckedState.ForeColor = Color.Black;
            btnCustomerRegistration.CustomizableEdges = customizableEdges7;
            btnCustomerRegistration.DisabledState.BorderColor = Color.DarkGray;
            btnCustomerRegistration.DisabledState.CustomBorderColor = Color.DarkGray;
            btnCustomerRegistration.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            btnCustomerRegistration.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            btnCustomerRegistration.FillColor = Color.FromArgb(0, 64, 64);
            btnCustomerRegistration.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnCustomerRegistration.ForeColor = Color.White;
            btnCustomerRegistration.Image = (Image)resources.GetObject("btnCustomerRegistration.Image");
            btnCustomerRegistration.ImageSize = new Size(40, 40);
            btnCustomerRegistration.Location = new Point(329, 20);
            btnCustomerRegistration.Name = "btnCustomerRegistration";
            btnCustomerRegistration.ShadowDecoration.CustomizableEdges = customizableEdges8;
            btnCustomerRegistration.Size = new Size(306, 85);
            btnCustomerRegistration.TabIndex = 1;
            btnCustomerRegistration.Text = "Customer Registration";
            btnCustomerRegistration.Click += guna2Button2_Click;
            // 
            // btnAddRoom
            // 
            btnAddRoom.BackColor = Color.FromArgb(0, 64, 64);
            btnAddRoom.BorderRadius = 26;
            btnAddRoom.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            btnAddRoom.CheckedState.FillColor = Color.White;
            btnAddRoom.CheckedState.ForeColor = Color.Black;
            btnAddRoom.CustomizableEdges = customizableEdges9;
            btnAddRoom.DisabledState.BorderColor = Color.DarkGray;
            btnAddRoom.DisabledState.CustomBorderColor = Color.DarkGray;
            btnAddRoom.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            btnAddRoom.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            btnAddRoom.FillColor = Color.FromArgb(0, 64, 64);
            btnAddRoom.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnAddRoom.ForeColor = Color.White;
            btnAddRoom.Image = (Image)resources.GetObject("btnAddRoom.Image");
            btnAddRoom.ImageSize = new Size(40, 40);
            btnAddRoom.Location = new Point(18, 20);
            btnAddRoom.Name = "btnAddRoom";
            btnAddRoom.ShadowDecoration.CustomizableEdges = customizableEdges10;
            btnAddRoom.Size = new Size(287, 85);
            btnAddRoom.TabIndex = 0;
            btnAddRoom.Text = "Add Room";
            btnAddRoom.Click += btnAddRoom_Click;
            // 
            // panel2
            // 
            panel2.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            panel2.Controls.Add(uC_Employee1);
            panel2.Controls.Add(uC_CustomerDetail1);
            panel2.Controls.Add(uC_CustomerCheckOut1);
            panel2.Controls.Add(uC_CustomerRegistration1);
            panel2.Controls.Add(uC_AddRoom1);
            panel2.Location = new Point(27, 148);
            panel2.Name = "panel2";
            panel2.Size = new Size(1705, 679);
            panel2.TabIndex = 1;
            // 
            // uC_Employee1
            // 
            uC_Employee1.BackColor = Color.White;
            uC_Employee1.Location = new Point(0, 0);
            uC_Employee1.Name = "uC_Employee1";
            uC_Employee1.Size = new Size(2008, 1046);
            uC_Employee1.TabIndex = 4;
            // 
            // uC_CustomerDetail1
            // 
            uC_CustomerDetail1.BackColor = Color.White;
            uC_CustomerDetail1.Location = new Point(0, 0);
            uC_CustomerDetail1.Name = "uC_CustomerDetail1";
            uC_CustomerDetail1.Size = new Size(2008, 1046);
            uC_CustomerDetail1.TabIndex = 3;
            // 
            // uC_CustomerCheckOut1
            // 
            uC_CustomerCheckOut1.BackColor = Color.White;
            uC_CustomerCheckOut1.Location = new Point(12, 2);
            uC_CustomerCheckOut1.Name = "uC_CustomerCheckOut1";
            uC_CustomerCheckOut1.Size = new Size(2008, 1046);
            uC_CustomerCheckOut1.TabIndex = 2;
            // 
            // uC_CustomerRegistration1
            // 
            uC_CustomerRegistration1.BackColor = Color.White;
            uC_CustomerRegistration1.Location = new Point(3, 3);
            uC_CustomerRegistration1.Name = "uC_CustomerRegistration1";
            uC_CustomerRegistration1.Size = new Size(2008, 1046);
            uC_CustomerRegistration1.TabIndex = 1;
            // 
            // uC_AddRoom1
            // 
            uC_AddRoom1.BackColor = Color.White;
            uC_AddRoom1.Location = new Point(3, 3);
            uC_AddRoom1.Name = "uC_AddRoom1";
            uC_AddRoom1.Size = new Size(1803, 856);
            uC_AddRoom1.TabIndex = 0;
            // 
            // btnExit
            // 
            btnExit.DisabledState.BorderColor = Color.DarkGray;
            btnExit.DisabledState.CustomBorderColor = Color.DarkGray;
            btnExit.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            btnExit.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            btnExit.FillColor = Color.Empty;
            btnExit.Font = new Font("Segoe UI", 9F);
            btnExit.ForeColor = Color.White;
            btnExit.Image = (Image)resources.GetObject("btnExit.Image");
            btnExit.ImageSize = new Size(35, 35);
            btnExit.Location = new Point(0, 0);
            btnExit.Name = "btnExit";
            btnExit.ShadowDecoration.CustomizableEdges = customizableEdges11;
            btnExit.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            btnExit.Size = new Size(49, 54);
            btnExit.TabIndex = 2;
            btnExit.Click += btnExit_Click;
            // 
            // btnMinimize
            // 
            btnMinimize.DisabledState.BorderColor = Color.DarkGray;
            btnMinimize.DisabledState.CustomBorderColor = Color.DarkGray;
            btnMinimize.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            btnMinimize.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            btnMinimize.FillColor = Color.Empty;
            btnMinimize.Font = new Font("Segoe UI", 9F);
            btnMinimize.ForeColor = Color.White;
            btnMinimize.Image = (Image)resources.GetObject("btnMinimize.Image");
            btnMinimize.ImageSize = new Size(35, 35);
            btnMinimize.Location = new Point(0, 49);
            btnMinimize.Name = "btnMinimize";
            btnMinimize.ShadowDecoration.CustomizableEdges = customizableEdges12;
            btnMinimize.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            btnMinimize.Size = new Size(49, 54);
            btnMinimize.TabIndex = 3;
            btnMinimize.Click += guna2CircleButton2_Click;
            // 
            // guna2Elipse1
            // 
            guna2Elipse1.BorderRadius = 30;
            guna2Elipse1.TargetControl = this;
            // 
            // guna2Elipse2
            // 
            guna2Elipse2.BorderRadius = 30;
            guna2Elipse2.TargetControl = this;
            // 
            // guna2Elipse3
            // 
            guna2Elipse3.BorderRadius = 30;
            guna2Elipse3.TargetControl = this;
            // 
            // guna2Elipse4
            // 
            guna2Elipse4.BorderRadius = 30;
            guna2Elipse4.TargetControl = this;
            // 
            // guna2Elipse5
            // 
            guna2Elipse5.BorderRadius = 30;
            guna2Elipse5.TargetControl = this;
            // 
            // Dashboard
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(0, 64, 64);
            ClientSize = new Size(1785, 878);
            Controls.Add(btnMinimize);
            Controls.Add(btnExit);
            Controls.Add(panel2);
            Controls.Add(Panel);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Dashboard";
            StartPosition = FormStartPosition.CenterScreen;
            Text = resources.GetString("$this.Text");
            WindowState = FormWindowState.Maximized;
            Load += Dashboard_Load;
            Panel.ResumeLayout(false);
            panel2.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel Panel;
        private Panel panel2;
        private Guna.UI2.WinForms.Guna2CircleButton btnExit;
        private Guna.UI2.WinForms.Guna2CircleButton btnMinimize;
        private Guna.UI2.WinForms.Guna2Button btnAddRoom;
        private Guna.UI2.WinForms.Guna2Button btnCustomerDetails;
        private Guna.UI2.WinForms.Guna2Button btnCheckOut;
        private Guna.UI2.WinForms.Guna2Button btnCustomerRegistration;
        private Guna.UI2.WinForms.Guna2Button btnEmployee;
        private Panel MovingPanel;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse1;
        private All_User_control.UC_AddRoom uC_AddRoom1;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse2;
        private All_User_control.UC_CustomerRegistration uC_CustomerRegistration1;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse3;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse4;
        private All_User_control.UC_CustomerCheckOut uC_CustomerCheckOut1;
        private All_User_control.UC_CustomerDetail uC_CustomerDetail1;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse5;
        private All_User_control.UC_Employee uC_Employee1;
    }
}