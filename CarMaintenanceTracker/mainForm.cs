using System;
using System.Collections.Specialized;
using System.Windows.Forms;

namespace CarMaintenanceTracker
{
    public partial class mainForm : Form
    {
        Car _selectedCar;

        public mainForm()
        {
            InitializeComponent();

            //upgrade settings.properties if assembly version changes
            if (!Properties.Settings.Default.SettingsUpdated)
            {
                Properties.Settings.Default.Upgrade();
                Properties.Settings.Default.SettingsUpdated = true;
                Properties.Settings.Default.Save();
            }
        }

        private void AboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //show about form
            using (aboutForm about = new aboutForm() { StartPosition = FormStartPosition.CenterParent })
            {
                about.ShowDialog();
            }
        }

        private void QuitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //exit application on quit
            Application.Exit();
        }

        private void SettingsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using (settingsForm settings = new settingsForm() { StartPosition = FormStartPosition.CenterParent })
            {
                settings.ShowDialog();
            }
        }

        private void MainForm_Shown(object sender, EventArgs e)
        {
            //initialize the car list
            //I've decided I want the user to always have 1 car in the car list, basically the user should enter their car on start if there's none in the system
            if (CarList.Initialize())
            {
                using (newEntryForm entryForm = new newEntryForm() { StartPosition = FormStartPosition.CenterParent })
                {
                    entryForm.ShowDialog();
                    CarList.AddCar(entryForm.NewCar);
                    _selectedCar = CarList.GetCar(entryForm.NewCar);

                    Properties.Settings.Default.LastCar = entryForm.NewCar;
                    Properties.Settings.Default.Save();
                }
            }
        }

        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            CarList.SaveCarList();
        }
    }
}
