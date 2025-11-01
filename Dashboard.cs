using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hotel_Management
{
    public partial class Dashboard : Form
    {
        public Dashboard()
        {
            InitializeComponent();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void guna2CircleButton2_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void guna2Button2_Click(object sender, EventArgs e)
        {
            MovingPanel.Left = btnCustomerRegistration.Left + 18;
            uC_CustomerRegistration1.Visible = true;
            uC_CustomerRegistration1.BringToFront();
         
        }

        private void guna2Button5_Click(object sender, EventArgs e)
        {
            uC_Employee1.Visible = true; 
            uC_Employee1.BringToFront();
            MovingPanel.Left = btnEmployee.Left + 18;
        }

        private void guna2Button3_Click(object sender, EventArgs e)
        {
            uC_CustomerCheckOut1.Visible = true;    
            uC_CustomerCheckOut1.BringToFront();
            MovingPanel.Left = btnCheckOut.Left + 18;
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnAddRoom_Click(object sender, EventArgs e)
        {
            MovingPanel.Left = btnAddRoom.Left + 18;
            uC_AddRoom1.Visible = true;
            uC_AddRoom1.BringToFront();
        }

        private void btnCustomerDetails_Click(object sender, EventArgs e)
        {
            uC_CustomerDetail1.Visible = true;
            uC_CustomerDetail1.BringToFront();
            MovingPanel.Left = btnCustomerDetails.Left + 18;
        }

        private void Dashboard_Load(object sender, EventArgs e)
        {
            uC_AddRoom1.Visible = false;
            uC_CustomerRegistration1.Visible = false;
            btnAddRoom.PerformClick();
            uC_Employee1.Visible = false;
        }
    }
}
