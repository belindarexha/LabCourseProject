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
    public partial class Administration : Form
    {
        public Administration()
        {
            InitializeComponent();
        }

        private void Administration_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'databazaDataSet.examdetails' table. You can move, or remove it, as needed.
            this.examdetailsTableAdapter.Fill(this.databazaDataSet.examdetails);

        }

        private void examdetailsBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.examdetailsBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.databazaDataSet);

        }

        private void idLabel_Click(object sender, EventArgs e)
        {

        }
    }
}
