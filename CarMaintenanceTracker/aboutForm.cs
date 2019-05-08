using System.Diagnostics;
using System.Reflection;
using System.Windows.Forms;

namespace CarMaintenanceTracker
{
    public partial class aboutForm : Form
    {
        public aboutForm()
        {
            InitializeComponent();

            //adapted from https://stackoverflow.com/questions/909555/how-can-i-get-the-assembly-file-version, want the Version label to be the file version for the application
            Assembly assembly = Assembly.GetExecutingAssembly();
            FileVersionInfo fvi = FileVersionInfo.GetVersionInfo(assembly.Location);
            lbVersion.Text = fvi.FileVersion;
        }
    }
}
