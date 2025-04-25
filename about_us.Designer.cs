namespace Abdal_Security_Group_App
{
    partial class about_us
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(about_us));
            visualStudio2022DarkTheme1 = new Telerik.WinControls.Themes.VisualStudio2022DarkTheme();
            radLabel1 = new Telerik.WinControls.UI.RadLabel();
            radPictureBox1 = new Telerik.WinControls.UI.RadPictureBox();
            richTextBox_about_us = new RichTextBox();
            radLabel2 = new Telerik.WinControls.UI.RadLabel();
            radLabel3 = new Telerik.WinControls.UI.RadLabel();
            label_version = new Telerik.WinControls.UI.RadLabel();
            ((System.ComponentModel.ISupportInitialize)radLabel1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)radPictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)radLabel2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)radLabel3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)label_version).BeginInit();
            ((System.ComponentModel.ISupportInitialize)this).BeginInit();
            SuspendLayout();
            // 
            // radLabel1
            // 
            radLabel1.Location = new Point(149, 17);
            radLabel1.Name = "radLabel1";
            radLabel1.Size = new Size(337, 21);
            radLabel1.TabIndex = 0;
            radLabel1.Text = "Handcrafted with Passion by Ebrahim Shafiei (EbraSha)";
            radLabel1.ThemeName = "VisualStudio2022Dark";
            // 
            // radPictureBox1
            // 
            radPictureBox1.BackgroundImageLayout = ImageLayout.Stretch;
            radPictureBox1.Image = Properties.Resources.Untitled_3;
            radPictureBox1.Location = new Point(8, 5);
            radPictureBox1.Name = "radPictureBox1";
            radPictureBox1.Size = new Size(123, 259);
            radPictureBox1.TabIndex = 1;
            radPictureBox1.ThemeName = "VisualStudio2022Dark";
            // 
            // richTextBox_about_us
            // 
            richTextBox_about_us.BackColor = Color.FromArgb(60, 60, 70);
            richTextBox_about_us.BorderStyle = BorderStyle.None;
            richTextBox_about_us.ForeColor = SystemColors.InactiveCaption;
            richTextBox_about_us.Location = new Point(149, 163);
            richTextBox_about_us.Name = "richTextBox_about_us";
            richTextBox_about_us.ReadOnly = true;
            richTextBox_about_us.ScrollBars = RichTextBoxScrollBars.Vertical;
            richTextBox_about_us.Size = new Size(311, 105);
            richTextBox_about_us.TabIndex = 2;
            richTextBox_about_us.Text = "";
            // 
            // radLabel2
            // 
            radLabel2.Location = new Point(149, 48);
            radLabel2.Name = "radLabel2";
            radLabel2.Size = new Size(152, 21);
            radLabel2.TabIndex = 1;
            radLabel2.Text = "Prof.Shafiei@Gmail.com";
            radLabel2.ThemeName = "VisualStudio2022Dark";
            // 
            // radLabel3
            // 
            radLabel3.Location = new Point(149, 79);
            radLabel3.Name = "radLabel3";
            radLabel3.Size = new Size(244, 21);
            radLabel3.TabIndex = 1;
            radLabel3.Text = "www.Hackers.Zone - www.ebrasha.com";
            radLabel3.ThemeName = "VisualStudio2022Dark";
            // 
            // label_version
            // 
            label_version.Location = new Point(149, 110);
            label_version.Name = "label_version";
            label_version.Size = new Size(67, 21);
            label_version.TabIndex = 1;
            label_version.Text = "Version:....";
            label_version.ThemeName = "VisualStudio2022Dark";
            // 
            // about_us
            // 
            AutoScaleBaseSize = new Size(7, 15);
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(472, 274);
            Controls.Add(label_version);
            Controls.Add(radLabel3);
            Controls.Add(radLabel2);
            Controls.Add(richTextBox_about_us);
            Controls.Add(radPictureBox1);
            Controls.Add(radLabel1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            Name = "about_us";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "About Us";
            ThemeName = "VisualStudio2022Dark";
            FormClosing += about_us_FormClosing;
            Load += about_us_Load;
            ((System.ComponentModel.ISupportInitialize)radLabel1).EndInit();
            ((System.ComponentModel.ISupportInitialize)radPictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)radLabel2).EndInit();
            ((System.ComponentModel.ISupportInitialize)radLabel3).EndInit();
            ((System.ComponentModel.ISupportInitialize)label_version).EndInit();
            ((System.ComponentModel.ISupportInitialize)this).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Telerik.WinControls.Themes.VisualStudio2022DarkTheme visualStudio2022DarkTheme1;
        private Telerik.WinControls.UI.RadLabel radLabel1;
        private Telerik.WinControls.UI.RadPictureBox radPictureBox1;
        private RichTextBox richTextBox_about_us;
        private Telerik.WinControls.UI.RadLabel radLabel2;
        private Telerik.WinControls.UI.RadLabel radLabel3;
        private Telerik.WinControls.UI.RadLabel label_version;
    }
}
