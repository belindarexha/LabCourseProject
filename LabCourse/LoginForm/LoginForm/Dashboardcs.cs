using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LoginForm
{
    public partial class Dashboardcs : Form
    {
        public Dashboardcs()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            examdetails ed = new examdetails();
            ed.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Dashboardcs_Load(object sender, EventArgs e)
        {
            if (MyConnection.type == "A")
            {
                button1.Visible = true;
                button2.Visible = true;
                button3.Visible = true;
            }

            else if (MyConnection.type == "U") 
              
            {
                button1.Visible = true;
                button2.Visible = false;
                button3.Visible = true;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Administration a = new Administration();
            a.Show();
        }
    }
}
