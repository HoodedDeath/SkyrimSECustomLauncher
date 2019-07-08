using System;
using System.Diagnostics;
using System.IO;
using System.Windows.Forms;
using Microsoft.Win32;

namespace SkyrimSECustomLauncher
{
    public partial class Form1 : Form
    {
        private readonly string _basePath = Environment.CurrentDirectory;
        private const string _regpath = "HKEY_CURRENT_USER\\Software\\HoodedDeathApplications\\SkyrimSE_Custom";
        private string _sksePath = null;
        private string _vanillaPath = null;
        private string _vanillaLauncherPath = null;
        private string _vortexPath = null;
        public Form1()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            LoadPaths();
        }
        private void LoadPaths()
        {
            //Check SKSE
            string temp = (string)Registry.GetValue(_regpath, "SKSE_NAME", null);
            if (temp == null || temp == "")
            {
                if (!File.Exists(Path.Combine(_basePath, "skse64_loader.exe")))
                {
                    SKSEBtn.Enabled = false;
                    MessageBox.Show("SKSE64 not installed. Use 'Settings' menu strip button to configure custom file name for SKSE.");
                }
                else
                {
                    SKSEBtn.Enabled = true;
                    _sksePath = Path.Combine(_basePath, "skse64_loader.exe");
                }
            }
            else
            {
                if (!File.Exists(Path.Combine(_basePath, temp)))
                {
                    SKSEBtn.Enabled = false;
                    MessageBox.Show("Custom SKSE executable not found.");
                }
                else
                {
                    SKSEBtn.Enabled = true;
                    _sksePath = Path.Combine(_basePath, temp);
                }
            }
            //Check Vanilla
            temp = (string)Registry.GetValue(_regpath, "VANILLA_NAME", null);
            if (temp == null || temp == "")
            {
                if (!File.Exists(Path.Combine(_basePath, "SkyrimSE.exe")))
                {
                    VanillaBtn.Enabled = false;
                    MessageBox.Show("Skyrim SE Vanilla not Found. Use 'Settings' menu strip button to configure custom file name for vanilla.");
                }
                else
                {
                    VanillaBtn.Enabled = true;
                    _vanillaPath = Path.Combine(_basePath, "SkyrimSE.exe");
                }
            }
            else
            {
                if (!File.Exists(Path.Combine(_basePath, temp)))
                {
                    VanillaBtn.Enabled = false;
                    MessageBox.Show("Custom Vanilla game executable not found.");
                }
                else
                {
                    VanillaBtn.Enabled = true;
                    _vanillaPath = Path.Combine(_basePath, temp);
                }
            }
            //Check Vanilla Launcher
            temp = (string)Registry.GetValue(_regpath, "VANILLA_LAUNCHER_NAME", null);
            if (temp == null || temp == "")
            {
                if (!File.Exists(Path.Combine(_basePath, "SkyrimSELauncher_VANILLA.exe")))
                {
                    OptionsBtn.Enabled = false;
                    MessageBox.Show("Skyrim SE Vanilla Launcher not Found. Use 'Settings' menu strip button to configure custom file name for vanilla launcher.");
                }
                else
                {
                    OptionsBtn.Enabled = true;
                    _vanillaLauncherPath = Path.Combine(_basePath, "SkyrimSELauncher_VANILLA.exe");
                }
            }
            else
            {
                if (!File.Exists(Path.Combine(_basePath, temp)))
                {
                    OptionsBtn.Enabled = false;
                    MessageBox.Show("Custom Vanilla launcher executable not found.");
                }
                else
                {
                    OptionsBtn.Enabled = true;
                    _vanillaLauncherPath = Path.Combine(_basePath, temp);
                }
            }
            //Check Vortex
            temp = (string)Registry.GetValue(_regpath, "VORTEX_PATH", null);
            if (temp == null || temp == "")
            {
                if (!File.Exists("C:\\Program Files\\Black Tree Gaming Ltd\\Vortex\\Vortex.exe"))
                {
                    VortexBtn.Enabled = false;
                    MessageBox.Show("Vortex not installed in default path. Use 'Settings' menu strip button to configure custom file path for Vortex executable.");
                }
                else
                {
                    VortexBtn.Enabled = true;
                    _vortexPath = "C:\\Program Files\\Black Tree Gaming Ltd\\Vortex\\Vortex.exe";
                }
            }
            else
            {
                if (!File.Exists(temp))
                {
                    VortexBtn.Enabled = false;
                    MessageBox.Show("Custom Vortex install path not valid.");
                }
                else
                {
                    VortexBtn.Enabled = true;
                    _vortexPath = temp;
                }
            }
        }
        private void Settings_Click(object sender, EventArgs e)
        {
            using (var form = new SettingsForm())
            {
                DialogResult res = form.ShowDialog();
                if (res == DialogResult.OK)
                {
                    LoadPaths();
                }
            }
        }
        private void SKSEBtn_Click(object sender, EventArgs e)
        {
            Process.Start(Path.Combine(_basePath, (_sksePath == null || _sksePath == "") ? "skse64_loader.exe" : _sksePath));
            Application.Exit();
        }
        private void VanillaBtn_Click(object sender, EventArgs e)
        {
            Process.Start(Path.Combine(_basePath, (_vanillaPath == null || _vanillaPath == "") ? "SkyrimSE.exe" : _vanillaPath));
            Application.Exit();
        }
        private void VortexBtn_Click(object sender, EventArgs e)
        {
            Process.Start((_vortexPath == null || _vortexPath == "") ? "C:\\Program Files\\Black Tree Gaming Ltd\\Vortex\\Vortex.exe" : _vortexPath);
        }
        private void OptionsBtn_Click(object sender, EventArgs e)
        {
            Process.Start(Path.Combine(_basePath, (_vanillaLauncherPath == null || _vanillaLauncherPath == "") ? "SkyrimSELauncher_VANILLA.exe" : _vanillaLauncherPath));
        }
        private void CancelBtn_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        private readonly ToolTip tip = new ToolTip();
        private void SKSEBtn_MouseHover(object sender, EventArgs e)
        {
            tip.Show("Launch Skyrim SE with SKSE loaded", this, ((Control)sender).Location, 5000);
        }
        private void SKSEBtn_MouseLeave(object sender, EventArgs e)
        {
            tip.Hide(this);
        }
        private void VanillaBtn_MouseHover(object sender, EventArgs e)
        {
            tip.Show("Launch vanilla Skyrim SE", this, ((Control)sender).Location, 5000);
        }
        private void VanillaBtn_MouseLeave(object sender, EventArgs e)
        {
            tip.Hide(this);
        }
        private void VortexBtn_MouseHover(object sender, EventArgs e)
        {
            tip.Show("Launch Vortex mod manager", this, ((Control)sender).Location, 5000);
        }
        private void VortexBtn_MouseLeave(object sender, EventArgs e)
        {
            tip.Hide(this);
        }
        private void OptionsBtn_MouseHover(object sender, EventArgs e)
        {
            tip.Show("Launch vanilla Skyrim SE launcher (only needed to change game options)", this, ((Control)sender).Location, 5000);
        }
        private void OptionsBtn_MouseLeave(object sender, EventArgs e)
        {
            tip.Hide(this);
        }
        private void CancelBtn_MouseHover(object sender, EventArgs e)
        {
            tip.Show("Close launcher", this, ((Control)sender).Location, 5000);
        }
        private void CancelBtn_MouseLeave(object sender, EventArgs e)
        {
            tip.Hide(this);
        }
    }
}
