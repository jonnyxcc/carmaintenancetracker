using System;
using System.Windows.Forms;

namespace CarMaintenanceTracker
{
    public partial class settingsForm : Form
    {
        Timer _clearTimer = new Timer();
        const int ErrorTime = 5000;
        Control _clrControl;

        public settingsForm()
        {
            InitializeComponent();

            UpdateCarSelection();

            _clearTimer.Tick += ClearTimer_Tick;
            _clearTimer.Interval = ErrorTime;

            Disposed += SettingsForm_Disposed;

            if (!string.IsNullOrEmpty(Properties.Settings.Default.LastCar))
                cbCarSelection.SelectedIndex = cbCarSelection.Items.IndexOf(Properties.Settings.Default.LastCar);

            bRemove.Enabled = CarList.AllowDelete;
        }

        private void SettingsForm_Disposed(object sender, EventArgs e)
        {
            Disposed -= SettingsForm_Disposed;

            _clearTimer.Tick -= ClearTimer_Tick;
            _clearTimer.Dispose();
        }

        private void BAdd_Click(object sender, EventArgs e)
        {
            if (!CarList.AddCar(cbCarSelection.Text))
            {
                SetError(cbCarSelection, "You already have that car added.");
            }
            else
            {
                SetError(cbCarSelection, ""); //can clear error by providing right text
                bRemove.Enabled = CarList.AllowDelete;

                UpdateCarSelection();
            }
        }

        private void ClearTimer_Tick(object sender, EventArgs e)
        {
            //clear the error after ErrorTime milliseconds
            if (_clrControl != null) epMain.SetError(_clrControl, "");
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
                    bRemove.Enabled = CarList.AllowDelete;
                    UpdateCarSelection();
                }
            }
            else
            {
                SetError(cbCarSelection, "There is no car with this name.");
            }
        }

        private void TbOilChangeMiles_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            var curBox = sender as TextBox;
            if (curBox.Text == "") return;
            if (int.TryParse(curBox.Text, out int val))
            {

            }
            else
            {
                e.Cancel = true;
                SetError(curBox, "You must type a number with no decimals into this box.");
            }
        }

        private void SetError(Control ctrl, string errorMsg)
        {
            epMain.SetError(ctrl, errorMsg);
            _clrControl = ctrl;
            _clearTimer.Start();
        }

        public void ControlToggle(bool toggle)
        {
            //if there's no selected cars we don't want users editing text boxes
            tbMilesPerTireRotation.Enabled = toggle;
            tbOilChangeMiles.Enabled = toggle;
        }

        public void PopulateTextBoxes()
        {

        }

        private void SettingsForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (DialogResult == DialogResult.OK) //user selected a new car
            {
                Properties.Settings.Default.LastCar = cbCarSelection.Text;
                Properties.Settings.Default.Save();
            }
        }
    }
}
