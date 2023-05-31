using System;
using System.Data.OleDb;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace DashboardApp
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        OleDbConnection connectionString2 = new OleDbConnection("Provider=sqloledb;Data Source=Gio;Initial Catalog=db_users;Integrated Security=SSPI;");
        OleDbCommand cmd = new OleDbCommand();
        OleDbDataAdapter da = new OleDbDataAdapter();       

        private void button1_Click(object sender, EventArgs e)
        {
            connectionString2.Open();
            string login = "SELECT * FROM tbl_users WHERE username = '" + txtUsername.Text + "' and password = '" + txtPassword.Text + "'";
            cmd = new OleDbCommand(login, connectionString2);
            OleDbDataReader dr = cmd.ExecuteReader();
            if (dr.Read() == true)
            {
                new Form1().Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Ivalid Username or Password, Please Try Again", "Login Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtUsername.Text = "";
                txtPassword.Text = "";
                txtUsername.Focus();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            txtUsername.Text = "";
            txtPassword.Text = "";
            txtUsername.Focus();
        }

        private void checkbxShowPassword_CheckedChanged(object sender, EventArgs e)
        {
            if (checkbxShowPassword.Checked)
            {
                txtPassword.PasswordChar = '\0';
            }
            else
            {
                txtPassword.PasswordChar = '•';
            }
        }

        private void label6_Click(object sender, EventArgs e)
        {
            new Registration().Show();
            this.Hide();
        }
    }
}
