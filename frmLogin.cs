using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;

namespace projectPAWD
{
    public partial class frmLogin : Form
    {
        public static string usernameApp = "";
        public static string carBrandApp = "";
        public static string passwApp = "";
        public frmLogin()
        {
            InitializeComponent();
        }
        OleDbConnection con = new OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=db_users.mdb");
        OleDbCommand cmd = new OleDbCommand();
        OleDbDataAdapter da = new OleDbDataAdapter();

        private void button1_Click(object sender, EventArgs e)
        {
            con.Open();
            string login = "SELECT * FROM tbl_users WHERE username= '" + txtUsername.Text + "' and password= '" + txtpassword.Text + "' and car_brand= '" + txtCarBrand.Text + "'";
            cmd = new OleDbCommand(login, con);
            OleDbDataReader dr = cmd.ExecuteReader();
            
            if (dr.Read() == true)
            {
                usernameApp = txtUsername.Text;
                carBrandApp = txtCarBrand.Text;
                passwApp = txtpassword.Text;
                //The Form which will appear after loggin in
                new frmAppointment().Show();
                this.Hide();
                con.Close();

            }
            else
            {
                MessageBox.Show("Invalid Username or Password or Car Brand, Please Try Again", "Login Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtUsername.Text = "";
                txtpassword.Text = "";
                txtCarBrand.Text = "";
                txtUsername.Focus();
                con.Close();
            }
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            txtUsername.Text = "";
            txtpassword.Text = "";
            txtCarBrand.Text = "";
        }

        private void checkBxShowPas_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBxShowPas.Checked)
            {
                txtpassword.PasswordChar = '\0';

            }
            else
            {
                txtpassword.PasswordChar = '•';

            }
        }

        private void label7_Click(object sender, EventArgs e)
        {
            new frmRegister().Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
