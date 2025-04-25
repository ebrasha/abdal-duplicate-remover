namespace Abdal_Security_Group_App
{
    partial class Legal_disclaimer
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Legal_disclaimer));
            visualStudio2022DarkTheme1 = new Telerik.WinControls.Themes.VisualStudio2022DarkTheme();
            legal_dis = new RichTextBox();
            bt_Accept = new Telerik.WinControls.UI.RadButton();
            bt_Decline = new Telerik.WinControls.UI.RadButton();
            ((System.ComponentModel.ISupportInitialize)bt_Accept).BeginInit();
            ((System.ComponentModel.ISupportInitialize)bt_Decline).BeginInit();
            ((System.ComponentModel.ISupportInitialize)this).BeginInit();
            SuspendLayout();
            // 
            // legal_dis
            // 
            legal_dis.BackColor = Color.FromArgb(60, 60, 70);
            legal_dis.BorderStyle = BorderStyle.None;
            legal_dis.ForeColor = SystemColors.InactiveBorder;
            legal_dis.Location = new Point(12, 21);
            legal_dis.Name = "legal_dis";
            legal_dis.ReadOnly = true;
            legal_dis.ScrollBars = RichTextBoxScrollBars.Vertical;
            legal_dis.Size = new Size(639, 158);
            legal_dis.TabIndex = 0;
            legal_dis.Text = "";
            // 
            // bt_Accept
            // 
            bt_Accept.Image = Properties.Resources.checkmark;
            bt_Accept.Location = new Point(18, 199);
            bt_Accept.Name = "bt_Accept";
            bt_Accept.Size = new Size(110, 24);
            bt_Accept.TabIndex = 1;
            bt_Accept.Text = "I Accept";
            bt_Accept.ThemeName = "VisualStudio2022Dark";
            bt_Accept.Click += bt_Accept_Click;
            // 
            // bt_Decline
            // 
            bt_Decline.Image = Properties.Resources.cancel_sign;
            bt_Decline.Location = new Point(137, 199);
            bt_Decline.Name = "bt_Decline";
            bt_Decline.Size = new Size(110, 24);
            bt_Decline.TabIndex = 2;
            bt_Decline.Text = "I Decline";
            bt_Decline.ThemeName = "VisualStudio2022Dark";
            bt_Decline.Click += bt_Decline_Click;
            // 
            // Legal_disclaimer
            // 
            AutoScaleBaseSize = new Size(7, 15);
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(663, 237);
            Controls.Add(bt_Decline);
            Controls.Add(bt_Accept);
            Controls.Add(legal_dis);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            Name = "Legal_disclaimer";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Legal disclaimer";
            ThemeName = "VisualStudio2022Dark";
            FormClosing += Legal_disclaimer_FormClosing;
            Load += Legal_disclaimer_Load;
            ((System.ComponentModel.ISupportInitialize)bt_Accept).EndInit();
            ((System.ComponentModel.ISupportInitialize)bt_Decline).EndInit();
            ((System.ComponentModel.ISupportInitialize)this).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Telerik.WinControls.Themes.VisualStudio2022DarkTheme visualStudio2022DarkTheme1;
        private RichTextBox legal_dis;
        private Telerik.WinControls.UI.RadButton bt_Accept;
        private Telerik.WinControls.UI.RadButton bt_Decline;
    }
}
