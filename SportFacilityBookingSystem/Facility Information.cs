using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SportFacilityBookingSystem
{
    public partial class Facility_Information : Form
    {
        public Facility_Information()
        {
            InitializeComponent();
        }

        private void btnFacilityAdd_Click(object sender, EventArgs e)
        {
            AddFacility addFacility = new AddFacility();
            addFacility.ShowDialog();

        }

        private void btnFacilityEdit_Click(object sender, EventArgs e)
        {
            EditFacility editFacility = new EditFacility();
            editFacility.ShowDialog();
        }

        private void btnFacilityCancel_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
