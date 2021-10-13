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
    public partial class register : Form
    {
        public register()
        {
            InitializeComponent();
        }
        OleDbConnection con = new OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=USERS.mdb");
        OleDbCommand cmd = new OleDbCommand();
        OleDbDataAdapter da = new OleDbDataAdapter();

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void guna2GradientPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void guna2DateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void guna2TextBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void guna2ComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void register_btn_Click(object sender, EventArgs e)
        {
            if (username.Text == "" && CNF.Text == "" && CNF_PASSWORD.Text == "")
            {
                MessageBox.Show("Username and Password fields are empty", "Registration Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            else if (CNF.Text == CNF_PASSWORD.Text)
            {
                con.Open();
                //,DOB,USERNAME     "','"+DOB.Text+ "','" + username.Text +
                string register = "INSERT INTO USERS_TABLE (FIRST_NAME,LAST_NAME,EMAIL,ROLE,DOB,USERNAME,TXT_PASSWORD) VALUES('" + first_name.Text +"','" +last_name.Text + "','" + mail.Text + "','" + role.Text + "','" + DOB.Text + "','" + username.Text + "','"+ CNF.Text+"')";
                cmd = new OleDbCommand(register, con);
                cmd.ExecuteNonQuery();
                con.Close();

                username.Text = "";
                CNF.Text = "";
                CNF_PASSWORD.Text = "";

                MessageBox.Show("Your Account has been Successfully Created", "Registration Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Passwords does not match, Please Re-enter", "Registration Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                CNF.Text = "";
                CNF_PASSWORD.Text = "";
                CNF.Focus();
            }
        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void signup_Click(object sender, EventArgs e)
        {
            new login().Show();
            this.Hide();
        }
    }
}
