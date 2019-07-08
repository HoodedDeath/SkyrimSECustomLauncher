using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SkyrimSECustomLauncher
{
    public partial class SettingsForm : Form
    {
        private const string _regpath = "HKEY_CURRENT_USER\\Software\\HoodedDeathApplications\\SkyrimSE_Custom";
        public SettingsForm()
        {
            InitializeComponent();
        }
        private void HelpBtn_Click(object sender, EventArgs e)
        {
            MessageBox.Show("SKSE Loader Name -> Name of the SKSE Loader executable file, default: 'skse65_loader.exe'\nVanilla Game Name -> Name of the vanilla Skyrim SE executable file, default: 'SkyrimSE.exe'\nVanilla Launcher Name -> Name of the vanilla Skyrim SE launcher executable file, default: 'SkyrimSELauncher_VANILLA.exe'\nVortex Install Path -> Full path to the install location for Vortex, default: 'C:\\Program Files\\Black Tree Gaming Ltd\\Vortex\\Vortex.exe'\n\nLeave any box blank to use the default value\n\nThis executable needs to be in Skyrim Special Edition's root folder to function and needs to be named 'SkyrimSELauncher.exe' and launch when launched through Steam.");
        }
        private void BrowseBtn_Click(object sender, EventArgs e)
        {
            OpenFileDialog d = new OpenFileDialog();
            DialogResult res = d.ShowDialog();
            if (res == DialogResult.OK)
                VortexTxtBx.Text = d.FileName;
        }
        private readonly ToolTip tip = new ToolTip();
        private void BrowseBtn_MouseHover(object sender, EventArgs e)
        {
            tip.Show("Browse File", this, ((Control)sender).Location, 5000);
        }
        private void BrowseBtn_MouseLeave(object sender, EventArgs e)
        {
            tip.Hide(this);
        }
        private void CancelBtn_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }
        private void AcceptBtn_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
            this.Close();
        }
        private void SettingsForm_Load(object sender, EventArgs e)
        {
            SKSETxtBx.Text = (string)Registry.GetValue(_regpath, "SKSE_NAME", null);
            VanillaTxtBx.Text = (string)Registry.GetValue(_regpath, "VANILLA_NAME", null);
            VLauncherTxtBx.Text = (string)Registry.GetValue(_regpath, "VANILLA_LAUNCHER_NAME", null);
            VortexTxtBx.Text = (string)Registry.GetValue(_regpath, "VORTEX_PATH", null);
        }
        private void SettingsForm_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
                CancelBtn_Click(sender, null);
            if (e.KeyCode == Keys.Enter)
                AcceptBtn_Click(sender, null);
        }
        private void SettingsForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (this.DialogResult == DialogResult.OK)
            {
                Registry.SetValue(_regpath, "SKSE_NAME", SKSETxtBx.Text);
                Registry.SetValue(_regpath, "VANILLA_NAME", VanillaTxtBx.Text);
                Registry.SetValue(_regpath, "VANILLA_LAUNCHER_NAME", VLauncherTxtBx.Text);
                Registry.SetValue(_regpath, "VORTEX_PATH", VortexTxtBx.Text);

            }
            else
                this.DialogResult = DialogResult.Cancel;
            e.Cancel = false;
        }
    }
}
