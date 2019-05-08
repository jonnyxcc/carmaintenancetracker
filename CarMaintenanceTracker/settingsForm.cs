using System;
using System.Windows.Forms;

namespace CarMaintenanceTracker
{
    public partial class settingsForm : Form
    {
        Timer _clearTimer = new Timer();
        const int ErrorTime = 5000;

        public settingsForm()
        {
            InitializeComponent();

            UpdateCarSelection();
        }

        private void BAdd_Click(object sender, EventArgs e)
        {
            if (!CarList.AddCar(cbCarSelection.Text))
            {
                epMain.SetError(cbCarSelection, "You already have that car added.");

                _clearTimer.Interval = ErrorTime;
                _clearTimer.Tick += ClearTimer_Tick;
                _clearTimer.Start();
            }
            else
            {
                epMain.SetError(cbCarSelection, ""); //can clear error by providing right text

                UpdateCarSelection();
            }
        }

        private void ClearTimer_Tick(object sender, EventArgs e)
        {
            //clear the error after ErrorTime milliseconds
            epMain.SetError(cbCarSelection, "");
            _clearTimer.Stop();
        }

        private void UpdateCarSelection()
        {
            CarList.PopulateComboBox(cbCarSelection);
        }

        private void BRemove_Click(object sender, EventArgs e)
        {
            if (CarList.ContainsCar(cbCarSelection.Text))
            {
                epMain.SetError(cbCarSelection, ""); //can clear the error by providing right text
                if (MessageBox.Show("Are you sure you want to delete this car?", "Confirm?", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                {
                    CarList.RemoveCar(cbCarSelection.Text);
                }
            }
            else
            {
                epMain.SetError(cbCarSelection, "There is no car with this name.");

                _clearTimer.Interval = ErrorTime;
                _clearTimer.Tick += ClearTimer_Tick;
                _clearTimer.Start();
            }
        }
    }
}
