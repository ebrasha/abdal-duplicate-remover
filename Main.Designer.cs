namespace Abdal_Security_Group_App
{
    partial class Main
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            visualStudio2022DarkTheme1 = new Telerik.WinControls.Themes.VisualStudio2022DarkTheme();
            radMenu1 = new Telerik.WinControls.UI.RadMenu();
            menuItem_about_us = new Telerik.WinControls.UI.RadMenuItem();
            menuItem_donate = new Telerik.WinControls.UI.RadMenuItem();
            irDonationBtn = new Telerik.WinControls.UI.RadMenuItem();
            EnDonationBtn = new Telerik.WinControls.UI.RadMenuItem();
            radMenuItem3 = new Telerik.WinControls.UI.RadMenuItem();
            menuItem_github = new Telerik.WinControls.UI.RadMenuItem();
            menuItem_gitlab = new Telerik.WinControls.UI.RadMenuItem();
            desk_alert = new Telerik.WinControls.UI.RadDesktopAlert(components);
            backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            btn_start = new Telerik.WinControls.UI.RadButton();
            btn_exit = new PictureBox();
            btn_minimize = new PictureBox();
            radWaitingBar1 = new Telerik.WinControls.UI.RadWaitingBar();
            waitingBarIndicatorElement1 = new Telerik.WinControls.UI.WaitingBarIndicatorElement();
            waitingBarIndicatorElement2 = new Telerik.WinControls.UI.WaitingBarIndicatorElement();
            open_target_file = new Telerik.WinControls.UI.RadButton();
            progressBar1 = new Telerik.WinControls.UI.RadProgressBar();
            radGroupBox1 = new Telerik.WinControls.UI.RadGroupBox();
            rdb_descending = new Telerik.WinControls.UI.RadRadioButton();
            rdb_ascending = new Telerik.WinControls.UI.RadRadioButton();
            cb_remove_empty_line = new Telerik.WinControls.UI.RadCheckBox();
            cb_remove_duplicate = new Telerik.WinControls.UI.RadCheckBox();
            cb_line_sort = new Telerik.WinControls.UI.RadCheckBox();
            cb_remove_liens_white_space = new Telerik.WinControls.UI.RadCheckBox();
            radGroupBox2 = new Telerik.WinControls.UI.RadGroupBox();
            lb_file_lines_org = new Telerik.WinControls.UI.RadLabel();
            radLabel3 = new Telerik.WinControls.UI.RadLabel();
            lb_file_size_org = new Telerik.WinControls.UI.RadLabel();
            radLabel2 = new Telerik.WinControls.UI.RadLabel();
            lb_file_name_org = new Telerik.WinControls.UI.RadLabel();
            radLabel1 = new Telerik.WinControls.UI.RadLabel();
            radGroupBox3 = new Telerik.WinControls.UI.RadGroupBox();
            lb_file_lines_new = new Telerik.WinControls.UI.RadLabel();
            radLabel9 = new Telerik.WinControls.UI.RadLabel();
            radLabel5 = new Telerik.WinControls.UI.RadLabel();
            lb_file_name_new = new Telerik.WinControls.UI.RadLabel();
            lb_file_size_new = new Telerik.WinControls.UI.RadLabel();
            radLabel7 = new Telerik.WinControls.UI.RadLabel();
            openFileDialog1 = new OpenFileDialog();
            ((System.ComponentModel.ISupportInitialize)radMenu1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)btn_start).BeginInit();
            ((System.ComponentModel.ISupportInitialize)btn_exit).BeginInit();
            ((System.ComponentModel.ISupportInitialize)btn_minimize).BeginInit();
            ((System.ComponentModel.ISupportInitialize)radWaitingBar1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)open_target_file).BeginInit();
            ((System.ComponentModel.ISupportInitialize)progressBar1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)radGroupBox1).BeginInit();
            radGroupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)rdb_descending).BeginInit();
            ((System.ComponentModel.ISupportInitialize)rdb_ascending).BeginInit();
            ((System.ComponentModel.ISupportInitialize)cb_remove_empty_line).BeginInit();
            ((System.ComponentModel.ISupportInitialize)cb_remove_duplicate).BeginInit();
            ((System.ComponentModel.ISupportInitialize)cb_line_sort).BeginInit();
            ((System.ComponentModel.ISupportInitialize)cb_remove_liens_white_space).BeginInit();
            ((System.ComponentModel.ISupportInitialize)radGroupBox2).BeginInit();
            radGroupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)lb_file_lines_org).BeginInit();
            ((System.ComponentModel.ISupportInitialize)radLabel3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)lb_file_size_org).BeginInit();
            ((System.ComponentModel.ISupportInitialize)radLabel2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)lb_file_name_org).BeginInit();
            ((System.ComponentModel.ISupportInitialize)radLabel1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)radGroupBox3).BeginInit();
            radGroupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)lb_file_lines_new).BeginInit();
            ((System.ComponentModel.ISupportInitialize)radLabel9).BeginInit();
            ((System.ComponentModel.ISupportInitialize)radLabel5).BeginInit();
            ((System.ComponentModel.ISupportInitialize)lb_file_name_new).BeginInit();
            ((System.ComponentModel.ISupportInitialize)lb_file_size_new).BeginInit();
            ((System.ComponentModel.ISupportInitialize)radLabel7).BeginInit();
            ((System.ComponentModel.ISupportInitialize)this).BeginInit();
            SuspendLayout();
            // 
            // radMenu1
            // 
            radMenu1.Dock = DockStyle.Bottom;
            radMenu1.Items.AddRange(new Telerik.WinControls.RadItem[] { menuItem_about_us, menuItem_donate, radMenuItem3 });
            radMenu1.Location = new Point(0, 613);
            radMenu1.Name = "radMenu1";
            radMenu1.Size = new Size(616, 28);
            radMenu1.TabIndex = 0;
            radMenu1.ThemeName = "VisualStudio2022Dark";
            // 
            // menuItem_about_us
            // 
            menuItem_about_us.Image = Properties.Resources.user_16x16;
            menuItem_about_us.Name = "menuItem_about_us";
            menuItem_about_us.Text = "About Us";
            menuItem_about_us.Click += menuItem_about_us_Click;
            // 
            // menuItem_donate
            // 
            menuItem_donate.Image = Properties.Resources.dollar16x16;
            menuItem_donate.Items.AddRange(new Telerik.WinControls.RadItem[] { irDonationBtn, EnDonationBtn });
            menuItem_donate.Name = "menuItem_donate";
            menuItem_donate.Text = "Donate";
            // 
            // irDonationBtn
            // 
            irDonationBtn.Image = Properties.Resources.iran_16x16;
            irDonationBtn.Name = "irDonationBtn";
            irDonationBtn.Text = "Persian speaker";
            irDonationBtn.Click += irDonationBtn_Click;
            // 
            // EnDonationBtn
            // 
            EnDonationBtn.Image = Properties.Resources.United_Kingdom16x16;
            EnDonationBtn.Name = "EnDonationBtn";
            EnDonationBtn.Text = "English speaker";
            EnDonationBtn.Click += EnDonationBtn_Click;
            // 
            // radMenuItem3
            // 
            radMenuItem3.Image = Properties.Resources.git_pull_request16x16;
            radMenuItem3.Items.AddRange(new Telerik.WinControls.RadItem[] { menuItem_github, menuItem_gitlab });
            radMenuItem3.Name = "radMenuItem3";
            radMenuItem3.Text = "Source Code";
            // 
            // menuItem_github
            // 
            menuItem_github.Image = Properties.Resources.github;
            menuItem_github.Name = "menuItem_github";
            menuItem_github.Text = "Github";
            menuItem_github.Click += menuItem_github_Click;
            // 
            // menuItem_gitlab
            // 
            menuItem_gitlab.Image = Properties.Resources.gitlab_icon_rgb;
            menuItem_gitlab.Name = "menuItem_gitlab";
            menuItem_gitlab.Text = "Gitlab";
            menuItem_gitlab.Visibility = Telerik.WinControls.ElementVisibility.Hidden;
            menuItem_gitlab.Click += menuItem_gitlab_Click;
            // 
            // backgroundWorker1
            // 
            backgroundWorker1.DoWork += backgroundWorker1_DoWork;
            backgroundWorker1.RunWorkerCompleted += bg_worker_RunWorkerCompleted;
            // 
            // btn_start
            // 
            btn_start.Location = new Point(128, 579);
            btn_start.Name = "btn_start";
            btn_start.Size = new Size(110, 24);
            btn_start.TabIndex = 1;
            btn_start.Text = "Start";
            btn_start.ThemeName = "VisualStudio2022Dark";
            btn_start.Click += btn_start_Click;
            // 
            // btn_exit
            // 
            btn_exit.BackColor = Color.Transparent;
            btn_exit.BackgroundImage = Properties.Resources.x_circle_21x21;
            btn_exit.BackgroundImageLayout = ImageLayout.Stretch;
            btn_exit.Cursor = Cursors.Hand;
            btn_exit.Location = new Point(7, 10);
            btn_exit.Name = "btn_exit";
            btn_exit.Size = new Size(21, 21);
            btn_exit.TabIndex = 2;
            btn_exit.TabStop = false;
            btn_exit.Click += btn_exit_Click;
            // 
            // btn_minimize
            // 
            btn_minimize.BackColor = Color.Transparent;
            btn_minimize.BackgroundImage = Properties.Resources.minus_circle_21x21;
            btn_minimize.BackgroundImageLayout = ImageLayout.Stretch;
            btn_minimize.Cursor = Cursors.Hand;
            btn_minimize.Location = new Point(34, 10);
            btn_minimize.Name = "btn_minimize";
            btn_minimize.Size = new Size(21, 21);
            btn_minimize.TabIndex = 3;
            btn_minimize.TabStop = false;
            btn_minimize.Click += btn_minimize_Click;
            // 
            // radWaitingBar1
            // 
            radWaitingBar1.Location = new Point(12, 360);
            radWaitingBar1.Name = "radWaitingBar1";
            radWaitingBar1.Size = new Size(300, 15);
            radWaitingBar1.TabIndex = 4;
            radWaitingBar1.Text = "radWaitingBar1";
            radWaitingBar1.ThemeName = "VisualStudio2022Dark";
            // 
            // 
            // 
            radWaitingBar1.WaitingBarElement.WaitingIndicatorSize = new Size(100, 14);
            radWaitingBar1.WaitingIndicators.Add(waitingBarIndicatorElement1);
            radWaitingBar1.WaitingIndicators.Add(waitingBarIndicatorElement2);
            radWaitingBar1.WaitingIndicatorSize = new Size(100, 14);
            radWaitingBar1.WaitingStyle = Telerik.WinControls.Enumerations.WaitingBarStyles.Dash;
            ((Telerik.WinControls.UI.RadWaitingBarElement)radWaitingBar1.GetChildAt(0)).WaitingIndicatorSize = new Size(100, 14);
            // 
            // waitingBarIndicatorElement1
            // 
            waitingBarIndicatorElement1.Name = "waitingBarIndicatorElement1";
            waitingBarIndicatorElement1.StretchHorizontally = false;
            // 
            // waitingBarIndicatorElement2
            // 
            waitingBarIndicatorElement2.Name = "waitingBarIndicatorElement2";
            waitingBarIndicatorElement2.StretchHorizontally = false;
            // 
            // open_target_file
            // 
            open_target_file.Location = new Point(12, 579);
            open_target_file.Name = "open_target_file";
            open_target_file.Size = new Size(110, 24);
            open_target_file.TabIndex = 5;
            open_target_file.Text = "Open target file";
            open_target_file.ThemeName = "VisualStudio2022Dark";
            open_target_file.Click += open_target_file_Click;
            // 
            // progressBar1
            // 
            progressBar1.Location = new Point(12, 381);
            progressBar1.Name = "progressBar1";
            progressBar1.Size = new Size(300, 24);
            progressBar1.TabIndex = 6;
            progressBar1.ThemeName = "VisualStudio2022Dark";
            // 
            // radGroupBox1
            // 
            radGroupBox1.AccessibleRole = AccessibleRole.Grouping;
            radGroupBox1.Controls.Add(rdb_descending);
            radGroupBox1.Controls.Add(rdb_ascending);
            radGroupBox1.Controls.Add(cb_remove_empty_line);
            radGroupBox1.Controls.Add(cb_remove_duplicate);
            radGroupBox1.Controls.Add(cb_line_sort);
            radGroupBox1.Controls.Add(cb_remove_liens_white_space);
            radGroupBox1.HeaderMargin = new Padding(1);
            radGroupBox1.HeaderText = "Config Actions";
            radGroupBox1.Location = new Point(12, 411);
            radGroupBox1.Name = "radGroupBox1";
            radGroupBox1.Size = new Size(300, 157);
            radGroupBox1.TabIndex = 7;
            radGroupBox1.Text = "Config Actions";
            radGroupBox1.ThemeName = "VisualStudio2022Dark";
            // 
            // rdb_descending
            // 
            rdb_descending.Location = new Point(188, 55);
            rdb_descending.Name = "rdb_descending";
            rdb_descending.Size = new Size(79, 18);
            rdb_descending.TabIndex = 5;
            rdb_descending.Text = "Descending";
            // 
            // rdb_ascending
            // 
            rdb_ascending.Location = new Point(110, 53);
            rdb_ascending.Name = "rdb_ascending";
            rdb_ascending.Size = new Size(72, 18);
            rdb_ascending.TabIndex = 4;
            rdb_ascending.Text = "Ascending";
            // 
            // cb_remove_empty_line
            // 
            cb_remove_empty_line.Location = new Point(15, 98);
            cb_remove_empty_line.Name = "cb_remove_empty_line";
            cb_remove_empty_line.Size = new Size(131, 17);
            cb_remove_empty_line.TabIndex = 3;
            cb_remove_empty_line.Text = "Remove Empty Lines";
            cb_remove_empty_line.ThemeName = "VisualStudio2022Dark";
            // 
            // cb_remove_duplicate
            // 
            cb_remove_duplicate.Location = new Point(15, 76);
            cb_remove_duplicate.Name = "cb_remove_duplicate";
            cb_remove_duplicate.Size = new Size(118, 17);
            cb_remove_duplicate.TabIndex = 2;
            cb_remove_duplicate.Text = "Remove Duplicate";
            cb_remove_duplicate.ThemeName = "VisualStudio2022Dark";
            // 
            // cb_line_sort
            // 
            cb_line_sort.Location = new Point(15, 54);
            cb_line_sort.Name = "cb_line_sort";
            cb_line_sort.Size = new Size(84, 17);
            cb_line_sort.TabIndex = 1;
            cb_line_sort.Text = "Line Sorting";
            cb_line_sort.ThemeName = "VisualStudio2022Dark";
            // 
            // cb_remove_liens_white_space
            // 
            cb_remove_liens_white_space.Location = new Point(15, 32);
            cb_remove_liens_white_space.Name = "cb_remove_liens_white_space";
            cb_remove_liens_white_space.Size = new Size(168, 17);
            cb_remove_liens_white_space.TabIndex = 0;
            cb_remove_liens_white_space.Text = "Remove Lines White Space ";
            cb_remove_liens_white_space.ThemeName = "VisualStudio2022Dark";
            // 
            // radGroupBox2
            // 
            radGroupBox2.AccessibleRole = AccessibleRole.Grouping;
            radGroupBox2.Controls.Add(lb_file_lines_org);
            radGroupBox2.Controls.Add(radLabel3);
            radGroupBox2.Controls.Add(lb_file_size_org);
            radGroupBox2.Controls.Add(radLabel2);
            radGroupBox2.Controls.Add(lb_file_name_org);
            radGroupBox2.Controls.Add(radLabel1);
            radGroupBox2.HeaderMargin = new Padding(1);
            radGroupBox2.HeaderText = "Original File Info";
            radGroupBox2.Location = new Point(341, 360);
            radGroupBox2.Name = "radGroupBox2";
            radGroupBox2.Size = new Size(263, 100);
            radGroupBox2.TabIndex = 8;
            radGroupBox2.Text = "Original File Info";
            radGroupBox2.ThemeName = "VisualStudio2022Dark";
            // 
            // lb_file_lines_org
            // 
            lb_file_lines_org.Location = new Point(87, 74);
            lb_file_lines_org.Name = "lb_file_lines_org";
            lb_file_lines_org.Size = new Size(14, 21);
            lb_file_lines_org.TabIndex = 4;
            lb_file_lines_org.Text = "0";
            lb_file_lines_org.ThemeName = "VisualStudio2022Dark";
            // 
            // radLabel3
            // 
            radLabel3.Location = new Point(16, 74);
            radLabel3.Name = "radLabel3";
            radLabel3.Size = new Size(65, 21);
            radLabel3.TabIndex = 4;
            radLabel3.Text = "File Lines:";
            radLabel3.ThemeName = "VisualStudio2022Dark";
            // 
            // lb_file_size_org
            // 
            lb_file_size_org.Location = new Point(72, 49);
            lb_file_size_org.Name = "lb_file_size_org";
            lb_file_size_org.Size = new Size(14, 21);
            lb_file_size_org.TabIndex = 3;
            lb_file_size_org.Text = "0";
            lb_file_size_org.ThemeName = "VisualStudio2022Dark";
            // 
            // radLabel2
            // 
            radLabel2.Location = new Point(16, 49);
            radLabel2.Name = "radLabel2";
            radLabel2.Size = new Size(54, 21);
            radLabel2.TabIndex = 2;
            radLabel2.Text = "FileSize:";
            radLabel2.ThemeName = "VisualStudio2022Dark";
            // 
            // lb_file_name_org
            // 
            lb_file_name_org.Location = new Point(90, 23);
            lb_file_name_org.Name = "lb_file_name_org";
            lb_file_name_org.Size = new Size(34, 21);
            lb_file_name_org.TabIndex = 1;
            lb_file_name_org.Text = "-----";
            lb_file_name_org.ThemeName = "VisualStudio2022Dark";
            // 
            // radLabel1
            // 
            radLabel1.Location = new Point(16, 22);
            radLabel1.Name = "radLabel1";
            radLabel1.Size = new Size(70, 21);
            radLabel1.TabIndex = 0;
            radLabel1.Text = "FileName: ";
            radLabel1.ThemeName = "VisualStudio2022Dark";
            // 
            // radGroupBox3
            // 
            radGroupBox3.AccessibleRole = AccessibleRole.Grouping;
            radGroupBox3.Controls.Add(lb_file_lines_new);
            radGroupBox3.Controls.Add(radLabel9);
            radGroupBox3.Controls.Add(radLabel5);
            radGroupBox3.Controls.Add(lb_file_name_new);
            radGroupBox3.Controls.Add(lb_file_size_new);
            radGroupBox3.Controls.Add(radLabel7);
            radGroupBox3.HeaderMargin = new Padding(1);
            radGroupBox3.HeaderText = "New File Info";
            radGroupBox3.Location = new Point(341, 468);
            radGroupBox3.Name = "radGroupBox3";
            radGroupBox3.Size = new Size(263, 100);
            radGroupBox3.TabIndex = 9;
            radGroupBox3.Text = "New File Info";
            radGroupBox3.ThemeName = "VisualStudio2022Dark";
            // 
            // lb_file_lines_new
            // 
            lb_file_lines_new.Location = new Point(82, 73);
            lb_file_lines_new.Name = "lb_file_lines_new";
            lb_file_lines_new.Size = new Size(14, 21);
            lb_file_lines_new.TabIndex = 9;
            lb_file_lines_new.Text = "0";
            lb_file_lines_new.ThemeName = "VisualStudio2022Dark";
            // 
            // radLabel9
            // 
            radLabel9.Location = new Point(11, 21);
            radLabel9.Name = "radLabel9";
            radLabel9.Size = new Size(70, 21);
            radLabel9.TabIndex = 5;
            radLabel9.Text = "FileName: ";
            radLabel9.ThemeName = "VisualStudio2022Dark";
            // 
            // radLabel5
            // 
            radLabel5.Location = new Point(11, 73);
            radLabel5.Name = "radLabel5";
            radLabel5.Size = new Size(65, 21);
            radLabel5.TabIndex = 10;
            radLabel5.Text = "File Lines:";
            radLabel5.ThemeName = "VisualStudio2022Dark";
            // 
            // lb_file_name_new
            // 
            lb_file_name_new.Location = new Point(85, 22);
            lb_file_name_new.Name = "lb_file_name_new";
            lb_file_name_new.Size = new Size(34, 21);
            lb_file_name_new.TabIndex = 6;
            lb_file_name_new.Text = "-----";
            lb_file_name_new.ThemeName = "VisualStudio2022Dark";
            // 
            // lb_file_size_new
            // 
            lb_file_size_new.Location = new Point(67, 48);
            lb_file_size_new.Name = "lb_file_size_new";
            lb_file_size_new.Size = new Size(14, 21);
            lb_file_size_new.TabIndex = 8;
            lb_file_size_new.Text = "0";
            lb_file_size_new.ThemeName = "VisualStudio2022Dark";
            // 
            // radLabel7
            // 
            radLabel7.Location = new Point(11, 48);
            radLabel7.Name = "radLabel7";
            radLabel7.Size = new Size(54, 21);
            radLabel7.TabIndex = 7;
            radLabel7.Text = "FileSize:";
            radLabel7.ThemeName = "VisualStudio2022Dark";
            // 
            // openFileDialog1
            // 
            openFileDialog1.FileName = "openFileDialog1";
            // 
            // Main
            // 
            AutoScaleBaseSize = new Size(7, 15);
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.bg42;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(616, 641);
            Controls.Add(radGroupBox3);
            Controls.Add(radGroupBox2);
            Controls.Add(radGroupBox1);
            Controls.Add(progressBar1);
            Controls.Add(open_target_file);
            Controls.Add(radWaitingBar1);
            Controls.Add(btn_minimize);
            Controls.Add(btn_exit);
            Controls.Add(btn_start);
            Controls.Add(radMenu1);
            FormBorderStyle = FormBorderStyle.None;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "Main";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            ThemeName = "VisualStudio2022Dark";
            FormClosing += Main_FormClosing;
            Load += Main_Load;
            ((System.ComponentModel.ISupportInitialize)radMenu1).EndInit();
            ((System.ComponentModel.ISupportInitialize)btn_start).EndInit();
            ((System.ComponentModel.ISupportInitialize)btn_exit).EndInit();
            ((System.ComponentModel.ISupportInitialize)btn_minimize).EndInit();
            ((System.ComponentModel.ISupportInitialize)radWaitingBar1).EndInit();
            ((System.ComponentModel.ISupportInitialize)open_target_file).EndInit();
            ((System.ComponentModel.ISupportInitialize)progressBar1).EndInit();
            ((System.ComponentModel.ISupportInitialize)radGroupBox1).EndInit();
            radGroupBox1.ResumeLayout(false);
            radGroupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)rdb_descending).EndInit();
            ((System.ComponentModel.ISupportInitialize)rdb_ascending).EndInit();
            ((System.ComponentModel.ISupportInitialize)cb_remove_empty_line).EndInit();
            ((System.ComponentModel.ISupportInitialize)cb_remove_duplicate).EndInit();
            ((System.ComponentModel.ISupportInitialize)cb_line_sort).EndInit();
            ((System.ComponentModel.ISupportInitialize)cb_remove_liens_white_space).EndInit();
            ((System.ComponentModel.ISupportInitialize)radGroupBox2).EndInit();
            radGroupBox2.ResumeLayout(false);
            radGroupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)lb_file_lines_org).EndInit();
            ((System.ComponentModel.ISupportInitialize)radLabel3).EndInit();
            ((System.ComponentModel.ISupportInitialize)lb_file_size_org).EndInit();
            ((System.ComponentModel.ISupportInitialize)radLabel2).EndInit();
            ((System.ComponentModel.ISupportInitialize)lb_file_name_org).EndInit();
            ((System.ComponentModel.ISupportInitialize)radLabel1).EndInit();
            ((System.ComponentModel.ISupportInitialize)radGroupBox3).EndInit();
            radGroupBox3.ResumeLayout(false);
            radGroupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)lb_file_lines_new).EndInit();
            ((System.ComponentModel.ISupportInitialize)radLabel9).EndInit();
            ((System.ComponentModel.ISupportInitialize)radLabel5).EndInit();
            ((System.ComponentModel.ISupportInitialize)lb_file_name_new).EndInit();
            ((System.ComponentModel.ISupportInitialize)lb_file_size_new).EndInit();
            ((System.ComponentModel.ISupportInitialize)radLabel7).EndInit();
            ((System.ComponentModel.ISupportInitialize)this).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Telerik.WinControls.Themes.VisualStudio2022DarkTheme visualStudio2022DarkTheme1;
        private Telerik.WinControls.UI.RadMenu radMenu1;
        private Telerik.WinControls.UI.RadMenuItem menuItem_about_us;
        private Telerik.WinControls.UI.RadMenuItem menuItem_donate;
        private Telerik.WinControls.UI.RadMenuItem radMenuItem3;
        private Telerik.WinControls.UI.RadMenuItem menuItem_github;
        private Telerik.WinControls.UI.RadMenuItem menuItem_gitlab;
        private Telerik.WinControls.UI.RadDesktopAlert desk_alert;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private Telerik.WinControls.UI.RadButton btn_start;
        private PictureBox btn_exit;
        private PictureBox btn_minimize;
        private Telerik.WinControls.UI.RadMenuItem irDonationBtn;
        private Telerik.WinControls.UI.RadMenuItem EnDonationBtn;
        private Telerik.WinControls.UI.RadWaitingBar radWaitingBar1;
        private Telerik.WinControls.UI.WaitingBarIndicatorElement waitingBarIndicatorElement1;
        private Telerik.WinControls.UI.WaitingBarIndicatorElement waitingBarIndicatorElement2;
        private Telerik.WinControls.UI.RadButton open_target_file;
        private Telerik.WinControls.UI.RadProgressBar progressBar1;
        private Telerik.WinControls.UI.RadGroupBox radGroupBox1;
        private Telerik.WinControls.UI.RadRadioButton rdb_ascending;
        private Telerik.WinControls.UI.RadCheckBox cb_remove_empty_line;
        private Telerik.WinControls.UI.RadCheckBox cb_remove_duplicate;
        private Telerik.WinControls.UI.RadCheckBox cb_line_sort;
        private Telerik.WinControls.UI.RadCheckBox cb_remove_liens_white_space;
        private Telerik.WinControls.UI.RadRadioButton rdb_descending;
        private Telerik.WinControls.UI.RadGroupBox radGroupBox2;
        private Telerik.WinControls.UI.RadGroupBox radGroupBox3;
        private Telerik.WinControls.UI.RadLabel lb_file_size_org;
        private Telerik.WinControls.UI.RadLabel radLabel2;
        private Telerik.WinControls.UI.RadLabel lb_file_name_org;
        private Telerik.WinControls.UI.RadLabel radLabel1;
        private Telerik.WinControls.UI.RadLabel lb_file_lines_org;
        private Telerik.WinControls.UI.RadLabel radLabel3;
        private Telerik.WinControls.UI.RadLabel lb_file_lines_new;
        private Telerik.WinControls.UI.RadLabel radLabel9;
        private Telerik.WinControls.UI.RadLabel radLabel5;
        private Telerik.WinControls.UI.RadLabel lb_file_name_new;
        private Telerik.WinControls.UI.RadLabel lb_file_size_new;
        private Telerik.WinControls.UI.RadLabel radLabel7;
        private OpenFileDialog openFileDialog1;
    }
}
