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
    public partial class frmAppointment : Form
    {
        private OleDbConnection connection = new OleDbConnection();
        private OleDbConnection connection2 = new OleDbConnection();
        private OleDbConnection connection3 = new OleDbConnection();
        public frmAppointment()
        {
            InitializeComponent();
            connection.ConnectionString = @"Provider=Microsoft.Jet.OLEDB.4.0;Data Source=db_appointments.mdb";
            connection2.ConnectionString = @"Provider=Microsoft.Jet.OLEDB.4.0;Data Source=db_users.mdb";
            connection3.ConnectionString = @"Provider=Microsoft.Jet.OLEDB.4.0;Data Source=db_appointments.mdb";
        }
        OleDbConnection con = new OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=db_appointments.mdb");
        OleDbCommand cmd = new OleDbCommand();
        OleDbDataAdapter da = new OleDbDataAdapter();

        private void frmAppointment_Load(object sender, EventArgs e)
        {
            username.Text = "Hello " + frmLogin.usernameApp;
            subtitle.Text = "Make an appointment for your " + frmLogin.carBrandApp;
            AppDate.Value = DateTime.Today;
            AppDate.MinDate = DateTime.Today;
            if(frmLogin.usernameApp=="admin" && frmLogin.passwApp=="admin")
            {
                btn_appointments.Visible = true;
                btn_users.Visible = true;
                
            }
            
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            new frmLogin().Show();
            this.Hide();
        }

        private void AppButton_Click(object sender, EventArgs e)
        {
            con.Open();
            string register = "INSERT INTO tbl_appointments VALUES('" + frmLogin.usernameApp + "','" + frmLogin.carBrandApp + "','" + AppDate.Value + "','" + appHour.Value + "')";
            cmd = new OleDbCommand(register, con);
            cmd.ExecuteNonQuery();
            con.Close();

            MessageBox.Show("Your appointment has been successfuly done", "Appointment Done", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btn_appointments_Click(object sender, EventArgs e)
        {
            dataGridView.Visible = true;
            try
            {
                connection.Open();
                OleDbCommand command = new OleDbCommand();
                command.Connection = connection;
                string query = "SELECT * from tbl_appointments";
                command.CommandText = query;

                OleDbDataAdapter da = new OleDbDataAdapter(command);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dataGridView.DataSource = dt;

                connection.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error" + ex);
            }
        }

        private void btn_users_Click(object sender, EventArgs e)
        {
            dataGridView.Visible = true;
            try
            {
                connection2.Open();
                OleDbCommand command = new OleDbCommand();
                command.Connection = connection2;
                string query = "SELECT * from tbl_users";
                command.CommandText = query;

                OleDbDataAdapter da = new OleDbDataAdapter(command);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dataGridView.DataSource = dt;

                connection2.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error" + ex);
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            try
            {
                connection3.Open();
                OleDbCommand command = new OleDbCommand();
                command.Connection = connection3;
                string query = "SELECT * from tbl_appointments";
                command.CommandText = query;

                OleDbDataReader reader = command.ExecuteReader();
                chart1.Series["APP"].Points.Clear();
                while (reader.Read())
                {
                    chart1.Series["APP"].Points.AddXY(reader["username"].ToString(), reader["appHour"].ToString());
                }

                connection3.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error" + ex);
            }
        }
    }
}
