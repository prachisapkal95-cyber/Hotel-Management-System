using System.Data;
using System.Diagnostics.Eventing.Reader;

namespace Hotel_Management
{
    public partial class Form1 : Form
    {
        function fn = new function();
        String query;

        public Form1()
        {
            InitializeComponent();
        }

        private void btnexit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            query = "select username,pass from employee where username = '" +txtUsername.Text+ "' and  pass = '" +txtPassword.Text+ "' ";
            DataSet ds = fn.getData(query);
            
            if(ds.Tables[0].Rows.Count != 0)

            //if (txtUsername.Text == "admin" && txtPassword.Text == "123")
            {
                labelError.Visible = false;
                Dashboard dash = new Dashboard();
                this.Hide();
                dash.Show();
            }
            else 
            {
                labelError.Visible = true;
                txtPassword.Clear();    

            }
        }
    }
}
