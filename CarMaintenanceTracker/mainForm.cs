using System;
using System.Collections.Specialized;
using System.Windows.Forms;

namespace CarMaintenanceTracker
{
    public partial class mainForm : Form
    {
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

            //initialize the car list
            CarList.Initialize();
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
    }
}
