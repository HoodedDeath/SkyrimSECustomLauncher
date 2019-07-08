namespace SkyrimSECustomLauncher
{
    partial class SettingsForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.SKSETxtBx = new System.Windows.Forms.TextBox();
            this.VanillaTxtBx = new System.Windows.Forms.TextBox();
            this.VLauncherTxtBx = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.VortexTxtBx = new System.Windows.Forms.TextBox();
            this.BrowseBtn = new System.Windows.Forms.Button();
            this.AcceptBtn = new System.Windows.Forms.Button();
            this.CancelBtn = new System.Windows.Forms.Button();
            this.HelpBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 15);
            this.label1.Margin = new System.Windows.Forms.Padding(3, 0, 0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(105, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "SKSE Loader Name:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(226, 15);
            this.label2.Margin = new System.Windows.Forms.Padding(3, 0, 0, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(103, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Vanilla Game Name:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(438, 15);
            this.label3.Margin = new System.Windows.Forms.Padding(3, 0, 0, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(120, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Vanilla Launcher Name:";
            // 
            // SKSETxtBx
            // 
            this.SKSETxtBx.Location = new System.Drawing.Point(120, 12);
            this.SKSETxtBx.Name = "SKSETxtBx";
            this.SKSETxtBx.Size = new System.Drawing.Size(100, 20);
            this.SKSETxtBx.TabIndex = 3;
            // 
            // VanillaTxtBx
            // 
            this.VanillaTxtBx.Location = new System.Drawing.Point(332, 12);
            this.VanillaTxtBx.Name = "VanillaTxtBx";
            this.VanillaTxtBx.Size = new System.Drawing.Size(100, 20);
            this.VanillaTxtBx.TabIndex = 4;
            // 
            // VLauncherTxtBx
            // 
            this.VLauncherTxtBx.Location = new System.Drawing.Point(561, 12);
            this.VLauncherTxtBx.Name = "VLauncherTxtBx";
            this.VLauncherTxtBx.Size = new System.Drawing.Size(100, 20);
            this.VLauncherTxtBx.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 41);
            this.label4.Margin = new System.Windows.Forms.Padding(3, 0, 0, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(95, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Vortex Install Path:";
            // 
            // VortexTxtBx
            // 
            this.VortexTxtBx.Location = new System.Drawing.Point(110, 38);
            this.VortexTxtBx.Name = "VortexTxtBx";
            this.VortexTxtBx.Size = new System.Drawing.Size(520, 20);
            this.VortexTxtBx.TabIndex = 7;
            // 
            // BrowseBtn
            // 
            this.BrowseBtn.Location = new System.Drawing.Point(636, 38);
            this.BrowseBtn.Name = "BrowseBtn";
            this.BrowseBtn.Size = new System.Drawing.Size(25, 20);
            this.BrowseBtn.TabIndex = 8;
            this.BrowseBtn.Text = "...";
            this.BrowseBtn.UseVisualStyleBackColor = true;
            this.BrowseBtn.Click += new System.EventHandler(this.BrowseBtn_Click);
            this.BrowseBtn.MouseLeave += new System.EventHandler(this.BrowseBtn_MouseLeave);
            this.BrowseBtn.MouseHover += new System.EventHandler(this.BrowseBtn_MouseHover);
            // 
            // AcceptBtn
            // 
            this.AcceptBtn.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.AcceptBtn.Location = new System.Drawing.Point(586, 64);
            this.AcceptBtn.Name = "AcceptBtn";
            this.AcceptBtn.Size = new System.Drawing.Size(75, 23);
            this.AcceptBtn.TabIndex = 9;
            this.AcceptBtn.Text = "Accept";
            this.AcceptBtn.UseVisualStyleBackColor = true;
            this.AcceptBtn.Click += new System.EventHandler(this.AcceptBtn_Click);
            // 
            // CancelBtn
            // 
            this.CancelBtn.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.CancelBtn.Location = new System.Drawing.Point(505, 64);
            this.CancelBtn.Name = "CancelBtn";
            this.CancelBtn.Size = new System.Drawing.Size(75, 23);
            this.CancelBtn.TabIndex = 10;
            this.CancelBtn.Text = "Cancel";
            this.CancelBtn.UseVisualStyleBackColor = true;
            this.CancelBtn.Click += new System.EventHandler(this.CancelBtn_Click);
            // 
            // HelpBtn
            // 
            this.HelpBtn.Location = new System.Drawing.Point(12, 64);
            this.HelpBtn.Name = "HelpBtn";
            this.HelpBtn.Size = new System.Drawing.Size(75, 23);
            this.HelpBtn.TabIndex = 11;
            this.HelpBtn.Text = "Help";
            this.HelpBtn.UseVisualStyleBackColor = true;
            this.HelpBtn.Click += new System.EventHandler(this.HelpBtn_Click);
            // 
            // SettingsForm
            // 
            this.AcceptButton = this.AcceptBtn;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.CancelBtn;
            this.ClientSize = new System.Drawing.Size(672, 96);
            this.Controls.Add(this.HelpBtn);
            this.Controls.Add(this.CancelBtn);
            this.Controls.Add(this.AcceptBtn);
            this.Controls.Add(this.BrowseBtn);
            this.Controls.Add(this.VortexTxtBx);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.VLauncherTxtBx);
            this.Controls.Add(this.VanillaTxtBx);
            this.Controls.Add(this.SKSETxtBx);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "SettingsForm";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "SettingsForm";
            this.TopMost = true;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.SettingsForm_FormClosing);
            this.Load += new System.EventHandler(this.SettingsForm_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.SettingsForm_KeyDown);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox SKSETxtBx;
        private System.Windows.Forms.TextBox VanillaTxtBx;
        private System.Windows.Forms.TextBox VLauncherTxtBx;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox VortexTxtBx;
        private System.Windows.Forms.Button BrowseBtn;
        private System.Windows.Forms.Button AcceptBtn;
        private System.Windows.Forms.Button CancelBtn;
        private System.Windows.Forms.Button HelpBtn;
    }
}