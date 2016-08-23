using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Will
{
    public partial class frmCustomers : Form
    {
        public frmCustomers()
        {
            InitializeComponent();
        }

        private void frmCustomers_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'willDataSet.CUSTORMER' table. You can move, or remove it, as needed.
            this.CUSTORMERTableAdapter.Fill(this.willDataSet.CUSTORMER);

            this.rptCustomers.RefreshReport();
        }

        private void rptCustomers_Load(object sender, EventArgs e)
        {

        }
    }
}
