using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RoadTripRentals
{
    public partial class frmSettings : Form
    {
        public frmSettings()
        {
            InitializeComponent();
        }

        private void frmSettings_Load(object sender, EventArgs e)
        {
            // Load current settings
            colorSchemeComboBox.SelectedIndex = Settings.ColorScheme == "Dark" ? 1 : 0;
            checkBoxOption.Checked = Settings.OptionEnabled;
        }

        public static class Settings
        {
            public static string ColorScheme { get; set; }
            public static bool OptionEnabled { get; set; }
        }

        private void btnApply_Click(object sender, EventArgs e)
        {
            // Save settings
            Settings.ColorScheme = colorSchemeComboBox.SelectedIndex == 1 ? "Dark" : "Light";
            Settings.OptionEnabled = checkBoxOption.Checked;

            // Apply settings
            ApplySettings();

            MessageBox.Show("Settings applied!");
        }

        private void ApplySettings()
        {
            // Implement your custom logic to apply the settings
            if (Settings.OptionEnabled)
            {
                // Enable the specific functionality or feature
            }
            else
            {
                // Disable the specific functionality or feature
            }
        }
    }
}
