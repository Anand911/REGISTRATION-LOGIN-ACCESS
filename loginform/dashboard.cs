using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace loginform
{
    public partial class dashboard : Form
    {
        string user,fname,lname, role,mail;

        private void guna2GradientPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void guna2GradientPanel1_Paint_1(object sender, PaintEventArgs e)
        {

        }

        private void roles_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void name_Click(object sender, EventArgs e)
        {

        }

        private void guna2GradientPanel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void dashboard_Load(object sender, EventArgs e)
        {
            username.Text = "<" + user + ">";
            name.Text = fname + " " + lname;
            roles.Text = role;
            email.Text = mail;

        }

        private void guna2PictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        public dashboard(DataTable dt)
        {
            InitializeComponent();
            fname = dt.Rows[0].Field<string>("FIRST_NAME");
            lname = dt.Rows[0].Field<string>("LAST_NAME");
            user = dt.Rows[0].Field<string>("USERNAME");
            role = dt.Rows[0].Field<string>("ROLE");
            mail = dt.Rows[0].Field<string>("EMAIL");

        }

    }
}
