using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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
            if (string.IsNullOrEmpty(tbCarName.Text))
            {
                e.Cancel = true;
                epMain.SetError(tbCarName, "You must enter the name of a car");
            }
        }

        public string NewCar
        {
            get
            {
                return tbCarName.Text;
            }
        }
    }
}
