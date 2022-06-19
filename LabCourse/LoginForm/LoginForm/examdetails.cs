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
    public partial class examdetails : Form
    {
        public examdetails()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
           
        }

        private void examdetails_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'databaseDataSet.examDetails4' table. You can move, or remove it, as needed.
            this.examDetails4TableAdapter.Fill(this.databaseDataSet.examDetails4);
            // TODO: This line of code loads data into the 'databazaDataSet1.examdetails' table. You can move, or remove it, as needed.
            this.examdetailsTableAdapter1.Fill(this.databazaDataSet1.examdetails);
            // TODO: This line of code loads data into the 'databazaDataSet.examdetails' table. You can move, or remove it, as needed.
            this.examdetailsTableAdapter.Fill(this.databazaDataSet.examdetails);

        }

        private void fillByToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                this.examDetails4TableAdapter.FillBy(this.databaseDataSet.examDetails4);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }
    }
}
