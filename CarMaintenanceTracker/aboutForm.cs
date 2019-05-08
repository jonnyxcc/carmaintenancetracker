using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CarMaintenanceTracker
{
    public partial class aboutForm : Form
    {
        public aboutForm()
        {
            InitializeComponent();

            //adapted from https://stackoverflow.com/questions/909555/how-can-i-get-the-assembly-file-version
            Assembly assembly = Assembly.GetExecutingAssembly();
            FileVersionInfo fvi = FileVersionInfo.GetVersionInfo(assembly.Location);
            lbVersion.Text = fvi.FileVersion;
        }
    }
}
