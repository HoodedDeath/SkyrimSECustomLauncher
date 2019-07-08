namespace SkyrimSECustomLauncher
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.SKSEBtn = new System.Windows.Forms.Button();
            this.VanillaBtn = new System.Windows.Forms.Button();
            this.VortexBtn = new System.Windows.Forms.Button();
            this.OptionsBtn = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.settingsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.CancelBtn = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // SKSEBtn
            // 
            this.SKSEBtn.Location = new System.Drawing.Point(12, 27);
            this.SKSEBtn.Name = "SKSEBtn";
            this.SKSEBtn.Size = new System.Drawing.Size(100, 23);
            this.SKSEBtn.TabIndex = 0;
            this.SKSEBtn.Text = "Launch SKSE";
            this.SKSEBtn.UseVisualStyleBackColor = true;
            this.SKSEBtn.Click += new System.EventHandler(this.SKSEBtn_Click);
            this.SKSEBtn.MouseLeave += new System.EventHandler(this.SKSEBtn_MouseLeave);
            this.SKSEBtn.MouseHover += new System.EventHandler(this.SKSEBtn_MouseHover);
            // 
            // VanillaBtn
            // 
            this.VanillaBtn.Location = new System.Drawing.Point(118, 27);
            this.VanillaBtn.Name = "VanillaBtn";
            this.VanillaBtn.Size = new System.Drawing.Size(100, 23);
            this.VanillaBtn.TabIndex = 1;
            this.VanillaBtn.Text = "Launch Vanilla";
            this.VanillaBtn.UseVisualStyleBackColor = true;
            this.VanillaBtn.Click += new System.EventHandler(this.VanillaBtn_Click);
            this.VanillaBtn.MouseLeave += new System.EventHandler(this.VanillaBtn_MouseLeave);
            this.VanillaBtn.MouseHover += new System.EventHandler(this.VanillaBtn_MouseHover);
            // 
            // VortexBtn
            // 
            this.VortexBtn.Location = new System.Drawing.Point(12, 56);
            this.VortexBtn.Name = "VortexBtn";
            this.VortexBtn.Size = new System.Drawing.Size(100, 23);
            this.VortexBtn.TabIndex = 2;
            this.VortexBtn.Text = "Open Vortex";
            this.VortexBtn.UseVisualStyleBackColor = true;
            this.VortexBtn.Click += new System.EventHandler(this.VortexBtn_Click);
            this.VortexBtn.MouseLeave += new System.EventHandler(this.VortexBtn_MouseLeave);
            this.VortexBtn.MouseHover += new System.EventHandler(this.VortexBtn_MouseHover);
            // 
            // OptionsBtn
            // 
            this.OptionsBtn.Location = new System.Drawing.Point(118, 56);
            this.OptionsBtn.Name = "OptionsBtn";
            this.OptionsBtn.Size = new System.Drawing.Size(100, 23);
            this.OptionsBtn.TabIndex = 3;
            this.OptionsBtn.Text = "Vanilla Launcher";
            this.OptionsBtn.UseVisualStyleBackColor = true;
            this.OptionsBtn.Click += new System.EventHandler(this.OptionsBtn_Click);
            this.OptionsBtn.MouseLeave += new System.EventHandler(this.OptionsBtn_MouseLeave);
            this.OptionsBtn.MouseHover += new System.EventHandler(this.OptionsBtn_MouseHover);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.settingsToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(224, 24);
            this.menuStrip1.TabIndex = 4;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // settingsToolStripMenuItem
            // 
            this.settingsToolStripMenuItem.Name = "settingsToolStripMenuItem";
            this.settingsToolStripMenuItem.Size = new System.Drawing.Size(61, 20);
            this.settingsToolStripMenuItem.Text = "Settings";
            this.settingsToolStripMenuItem.Click += new System.EventHandler(this.Settings_Click);
            // 
            // CancelBtn
            // 
            this.CancelBtn.Location = new System.Drawing.Point(12, 85);
            this.CancelBtn.Name = "CancelBtn";
            this.CancelBtn.Size = new System.Drawing.Size(206, 23);
            this.CancelBtn.TabIndex = 5;
            this.CancelBtn.Text = "Cancel";
            this.CancelBtn.UseVisualStyleBackColor = true;
            this.CancelBtn.Click += new System.EventHandler(this.CancelBtn_Click);
            this.CancelBtn.MouseLeave += new System.EventHandler(this.CancelBtn_MouseLeave);
            this.CancelBtn.MouseHover += new System.EventHandler(this.CancelBtn_MouseHover);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(224, 121);
            this.Controls.Add(this.CancelBtn);
            this.Controls.Add(this.OptionsBtn);
            this.Controls.Add(this.VortexBtn);
            this.Controls.Add(this.VanillaBtn);
            this.Controls.Add(this.SKSEBtn);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Skyrim SE Custom Launcher";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button SKSEBtn;
        private System.Windows.Forms.Button VanillaBtn;
        private System.Windows.Forms.Button VortexBtn;
        private System.Windows.Forms.Button OptionsBtn;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem settingsToolStripMenuItem;
        private System.Windows.Forms.Button CancelBtn;
    }
}

