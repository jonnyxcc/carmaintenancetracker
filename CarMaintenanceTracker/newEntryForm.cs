using System;
using System.Windows.Forms;

namespace CarMaintenanceTracker
{
    public partial class newEntryForm : Form
    {
        public newEntryForm()
        {
            InitializeComponent();
        }

        private void newEntryForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (DialogResult != DialogResult.OK) //don't allow closing the window with the X button
            {
                e.Cancel = true;
                return;
            }
            if (string.IsNullOrEmpty(tbCarName.Text))
            {
                e.Cancel = true;
                epName.SetError(tbCarName, "You must enter the name of a car");
            }
            if (!int.TryParse(tbCarMileage.Text, out int val))
            {
                e.Cancel = true;
                epMileage.SetError(tbCarMileage, "You must enter the estimated car's mileage as a number");
            }
        }

        public string NewCar
        {
            get
            {
                return tbCarName.Text;
            }
        }

        public int CarMileage
        {
            get
            {
                return Convert.ToInt32(tbCarMileage.Text);
            }
        }
    }
}
