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

namespace loginform
{
    public partial class login : Form
    {
       
        public login()
        {
            InitializeComponent();

            
        }
        OleDbConnection con = new OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=USERS.mdb");
        OleDbCommand cmd = new OleDbCommand();
        OleDbDataAdapter da = new OleDbDataAdapter();
        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void signup_Click(object sender, EventArgs e)
        {
            new register().Show();
            this.Hide();

        }

        private void login_btn_Click(object sender, EventArgs e)
        {
            con.Open();
            string login = "SELECT * FROM USERS_TABLE WHERE USERNAME= '" + text_username.Text + "' and TXT_PASSWORD= '" + text_pass.Text + "'";
            cmd = new OleDbCommand(login, con);
            OleDbDataReader dr = cmd.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Load(dr);
            if (dt.Rows.Count!=0)
            {
                //The Form which will appear after loggin in
                //new dashboard().Show();
                this.Hide();
                new dashboard(dt).Show();
                MessageBox.Show("LOGIN SUCCESSFULL!!", "Login Success", MessageBoxButtons.OK);
                
                //MessageBox.Show("name:"+ , "Login Failed", MessageBoxButtons.OK);
                //this.Hide();
            }
            else
            {
                MessageBox.Show("Invalid Username or Password, Please Try Again", "Login Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                /*txtUsername.Text = "";
                txtpassword.Text = "";
                txtUsername.Focus();*/
            }
            con.Close();
        }

        private void pass_show_CheckedChanged(object sender, EventArgs e)
        {
            if (pass_show.Checked)
            {
                text_pass.UseSystemPasswordChar = false;
                //txtComPassword.PasswordChar = '\0';
            }
            else
            {
                text_pass.UseSystemPasswordChar = true;
                //txtComPassword.PasswordChar = '•';
            }
        }

        private void text_username_TextChanged(object sender, EventArgs e)
        {

        }

        private void text_pass_TextChanged(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }
    }
}
