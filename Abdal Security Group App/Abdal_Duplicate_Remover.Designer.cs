namespace Abdal_Security_Group_App
{
    partial class Abdal_Duplicate_Remover
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Abdal_Duplicate_Remover));
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.desk_alert = new Telerik.WinControls.UI.RadDesktopAlert(this.components);
            this.Space1 = new Telerik.WinControls.UI.RadMenuItem();
            this.Space2 = new Telerik.WinControls.UI.RadMenuItem();
            this.radMenu1 = new Telerik.WinControls.UI.RadMenu();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.radGroupBox3 = new Telerik.WinControls.UI.RadGroupBox();
            this.lb_file_lines_new = new Telerik.WinControls.UI.RadLabel();
            this.radLabel5 = new Telerik.WinControls.UI.RadLabel();
            this.lb_file_name_new = new Telerik.WinControls.UI.RadLabel();
            this.lb_file_size_new = new Telerik.WinControls.UI.RadLabel();
            this.radLabel8 = new Telerik.WinControls.UI.RadLabel();
            this.radLabel9 = new Telerik.WinControls.UI.RadLabel();
            this.radGroupBox2 = new Telerik.WinControls.UI.RadGroupBox();
            this.lb_file_lines_org = new Telerik.WinControls.UI.RadLabel();
            this.radLabel3 = new Telerik.WinControls.UI.RadLabel();
            this.lb_file_name_org = new Telerik.WinControls.UI.RadLabel();
            this.lb_file_size_org = new Telerik.WinControls.UI.RadLabel();
            this.radLabel2 = new Telerik.WinControls.UI.RadLabel();
            this.radLabel1 = new Telerik.WinControls.UI.RadLabel();
            this.radGroupBox1 = new Telerik.WinControls.UI.RadGroupBox();
            this.rdb_descending = new Telerik.WinControls.UI.RadRadioButton();
            this.cb_remove_empty_line = new Telerik.WinControls.UI.RadCheckBox();
            this.cb_remove_liens_white_space = new Telerik.WinControls.UI.RadCheckBox();
            this.rdb_ascending = new Telerik.WinControls.UI.RadRadioButton();
            this.cb_remove_duplicate = new Telerik.WinControls.UI.RadCheckBox();
            this.cb_line_sort = new Telerik.WinControls.UI.RadCheckBox();
            this.radWaitingBar1 = new Telerik.WinControls.UI.RadWaitingBar();
            this.waitingBarIndicatorElement2 = new Telerik.WinControls.UI.WaitingBarIndicatorElement();
            this.waitingBarIndicatorElement1 = new Telerik.WinControls.UI.WaitingBarIndicatorElement();
            this.radButton2 = new Telerik.WinControls.UI.RadButton();
            this.radButton1 = new Telerik.WinControls.UI.RadButton();
            this.office2019LightTheme1 = new Telerik.WinControls.Themes.Office2019LightTheme();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.radMenuItem1 = new Telerik.WinControls.UI.RadMenuItem();
            this.radMenuItem2 = new Telerik.WinControls.UI.RadMenuItem();
            this.radMenuItem3 = new Telerik.WinControls.UI.RadMenuItem();
            this.radMenuItem4 = new Telerik.WinControls.UI.RadMenuItem();
            this.radMenuItem5 = new Telerik.WinControls.UI.RadMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.radMenu1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radGroupBox3)).BeginInit();
            this.radGroupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.lb_file_lines_new)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lb_file_name_new)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lb_file_size_new)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel8)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel9)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radGroupBox2)).BeginInit();
            this.radGroupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.lb_file_lines_org)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lb_file_name_org)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lb_file_size_org)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radGroupBox1)).BeginInit();
            this.radGroupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.rdb_descending)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cb_remove_empty_line)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cb_remove_liens_white_space)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rdb_ascending)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cb_remove_duplicate)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cb_line_sort)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radWaitingBar1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radButton2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radButton1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
            this.SuspendLayout();
            // 
            // backgroundWorker1
            // 
            this.backgroundWorker1.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorker1_DoWork);
            this.backgroundWorker1.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.backgroundWorker1_RunWorkerCompleted);
            // 
            // Space1
            // 
            this.Space1.Name = "Space1";
            this.Space1.Text = " ";
            // 
            // Space2
            // 
            this.Space2.Name = "Space2";
            this.Space2.Text = " ";
            // 
            // radMenu1
            // 
            this.radMenu1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.radMenu1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.radMenu1.Items.AddRange(new Telerik.WinControls.RadItem[] {
            this.radMenuItem1,
            this.Space1,
            this.radMenuItem2,
            this.Space2,
            this.radMenuItem3});
            this.radMenu1.Location = new System.Drawing.Point(0, 369);
            this.radMenu1.Name = "radMenu1";
            this.radMenu1.Size = new System.Drawing.Size(773, 25);
            this.radMenu1.TabIndex = 84;
            this.radMenu1.ThemeName = "Office2019Light";
            this.radMenu1.Click += new System.EventHandler(this.radMenu1_Click);
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(28, 100);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(306, 18);
            this.progressBar1.TabIndex = 91;
            // 
            // radGroupBox3
            // 
            this.radGroupBox3.AccessibleRole = System.Windows.Forms.AccessibleRole.Grouping;
            this.radGroupBox3.Controls.Add(this.lb_file_lines_new);
            this.radGroupBox3.Controls.Add(this.radLabel5);
            this.radGroupBox3.Controls.Add(this.lb_file_name_new);
            this.radGroupBox3.Controls.Add(this.lb_file_size_new);
            this.radGroupBox3.Controls.Add(this.radLabel8);
            this.radGroupBox3.Controls.Add(this.radLabel9);
            this.radGroupBox3.HeaderMargin = new System.Windows.Forms.Padding(1);
            this.radGroupBox3.HeaderText = "New File Info";
            this.radGroupBox3.Location = new System.Drawing.Point(372, 164);
            this.radGroupBox3.Name = "radGroupBox3";
            this.radGroupBox3.Size = new System.Drawing.Size(373, 116);
            this.radGroupBox3.TabIndex = 90;
            this.radGroupBox3.Text = "New File Info";
            this.radGroupBox3.ThemeName = "Office2019Light";
            // 
            // lb_file_lines_new
            // 
            this.lb_file_lines_new.Location = new System.Drawing.Point(90, 79);
            this.lb_file_lines_new.Name = "lb_file_lines_new";
            this.lb_file_lines_new.Size = new System.Drawing.Size(12, 18);
            this.lb_file_lines_new.TabIndex = 3;
            this.lb_file_lines_new.Text = "0";
            // 
            // radLabel5
            // 
            this.radLabel5.Location = new System.Drawing.Point(24, 79);
            this.radLabel5.Name = "radLabel5";
            this.radLabel5.Size = new System.Drawing.Size(54, 18);
            this.radLabel5.TabIndex = 2;
            this.radLabel5.Text = "File Lines:";
            // 
            // lb_file_name_new
            // 
            this.lb_file_name_new.Location = new System.Drawing.Point(90, 31);
            this.lb_file_name_new.Name = "lb_file_name_new";
            this.lb_file_name_new.Size = new System.Drawing.Size(24, 18);
            this.lb_file_name_new.TabIndex = 1;
            this.lb_file_name_new.Text = "----";
            // 
            // lb_file_size_new
            // 
            this.lb_file_size_new.Location = new System.Drawing.Point(90, 55);
            this.lb_file_size_new.Name = "lb_file_size_new";
            this.lb_file_size_new.Size = new System.Drawing.Size(12, 18);
            this.lb_file_size_new.TabIndex = 2;
            this.lb_file_size_new.Text = "0";
            // 
            // radLabel8
            // 
            this.radLabel8.Location = new System.Drawing.Point(24, 55);
            this.radLabel8.Name = "radLabel8";
            this.radLabel8.Size = new System.Drawing.Size(45, 18);
            this.radLabel8.TabIndex = 1;
            this.radLabel8.Text = "FileSize:";
            // 
            // radLabel9
            // 
            this.radLabel9.Location = new System.Drawing.Point(24, 31);
            this.radLabel9.Name = "radLabel9";
            this.radLabel9.Size = new System.Drawing.Size(59, 18);
            this.radLabel9.TabIndex = 0;
            this.radLabel9.Text = "FileName: ";
            // 
            // radGroupBox2
            // 
            this.radGroupBox2.AccessibleRole = System.Windows.Forms.AccessibleRole.Grouping;
            this.radGroupBox2.Controls.Add(this.lb_file_lines_org);
            this.radGroupBox2.Controls.Add(this.radLabel3);
            this.radGroupBox2.Controls.Add(this.lb_file_name_org);
            this.radGroupBox2.Controls.Add(this.lb_file_size_org);
            this.radGroupBox2.Controls.Add(this.radLabel2);
            this.radGroupBox2.Controls.Add(this.radLabel1);
            this.radGroupBox2.HeaderMargin = new System.Windows.Forms.Padding(1);
            this.radGroupBox2.HeaderText = "Original File Info";
            this.radGroupBox2.Location = new System.Drawing.Point(372, 32);
            this.radGroupBox2.Name = "radGroupBox2";
            this.radGroupBox2.Size = new System.Drawing.Size(373, 116);
            this.radGroupBox2.TabIndex = 89;
            this.radGroupBox2.Text = "Original File Info";
            this.radGroupBox2.ThemeName = "Office2019Light";
            // 
            // lb_file_lines_org
            // 
            this.lb_file_lines_org.Location = new System.Drawing.Point(90, 79);
            this.lb_file_lines_org.Name = "lb_file_lines_org";
            this.lb_file_lines_org.Size = new System.Drawing.Size(12, 18);
            this.lb_file_lines_org.TabIndex = 3;
            this.lb_file_lines_org.Text = "0";
            // 
            // radLabel3
            // 
            this.radLabel3.Location = new System.Drawing.Point(24, 79);
            this.radLabel3.Name = "radLabel3";
            this.radLabel3.Size = new System.Drawing.Size(54, 18);
            this.radLabel3.TabIndex = 2;
            this.radLabel3.Text = "File Lines:";
            // 
            // lb_file_name_org
            // 
            this.lb_file_name_org.Location = new System.Drawing.Point(90, 31);
            this.lb_file_name_org.Name = "lb_file_name_org";
            this.lb_file_name_org.Size = new System.Drawing.Size(24, 18);
            this.lb_file_name_org.TabIndex = 1;
            this.lb_file_name_org.Text = "----";
            // 
            // lb_file_size_org
            // 
            this.lb_file_size_org.Location = new System.Drawing.Point(90, 55);
            this.lb_file_size_org.Name = "lb_file_size_org";
            this.lb_file_size_org.Size = new System.Drawing.Size(12, 18);
            this.lb_file_size_org.TabIndex = 2;
            this.lb_file_size_org.Text = "0";
            // 
            // radLabel2
            // 
            this.radLabel2.Location = new System.Drawing.Point(24, 55);
            this.radLabel2.Name = "radLabel2";
            this.radLabel2.Size = new System.Drawing.Size(45, 18);
            this.radLabel2.TabIndex = 1;
            this.radLabel2.Text = "FileSize:";
            // 
            // radLabel1
            // 
            this.radLabel1.Location = new System.Drawing.Point(24, 31);
            this.radLabel1.Name = "radLabel1";
            this.radLabel1.Size = new System.Drawing.Size(59, 18);
            this.radLabel1.TabIndex = 0;
            this.radLabel1.Text = "FileName: ";
            // 
            // radGroupBox1
            // 
            this.radGroupBox1.AccessibleRole = System.Windows.Forms.AccessibleRole.Grouping;
            this.radGroupBox1.Controls.Add(this.rdb_descending);
            this.radGroupBox1.Controls.Add(this.cb_remove_empty_line);
            this.radGroupBox1.Controls.Add(this.cb_remove_liens_white_space);
            this.radGroupBox1.Controls.Add(this.rdb_ascending);
            this.radGroupBox1.Controls.Add(this.cb_remove_duplicate);
            this.radGroupBox1.Controls.Add(this.cb_line_sort);
            this.radGroupBox1.HeaderMargin = new System.Windows.Forms.Padding(1);
            this.radGroupBox1.HeaderText = "Config Actions";
            this.radGroupBox1.Location = new System.Drawing.Point(28, 127);
            this.radGroupBox1.Name = "radGroupBox1";
            this.radGroupBox1.Size = new System.Drawing.Size(306, 153);
            this.radGroupBox1.TabIndex = 88;
            this.radGroupBox1.Text = "Config Actions";
            this.radGroupBox1.ThemeName = "Office2019Light";
            // 
            // rdb_descending
            // 
            this.rdb_descending.Location = new System.Drawing.Point(193, 61);
            this.rdb_descending.Name = "rdb_descending";
            this.rdb_descending.Size = new System.Drawing.Size(79, 18);
            this.rdb_descending.TabIndex = 8;
            this.rdb_descending.TabStop = false;
            this.rdb_descending.Text = "descending";
            // 
            // cb_remove_empty_line
            // 
            this.cb_remove_empty_line.Location = new System.Drawing.Point(22, 106);
            this.cb_remove_empty_line.Name = "cb_remove_empty_line";
            this.cb_remove_empty_line.Size = new System.Drawing.Size(134, 17);
            this.cb_remove_empty_line.TabIndex = 6;
            this.cb_remove_empty_line.Text = "Remove Empty Lines";
            this.cb_remove_empty_line.ThemeName = "Office2019Light";
            // 
            // cb_remove_liens_white_space
            // 
            this.cb_remove_liens_white_space.Location = new System.Drawing.Point(22, 37);
            this.cb_remove_liens_white_space.Name = "cb_remove_liens_white_space";
            this.cb_remove_liens_white_space.Size = new System.Drawing.Size(171, 17);
            this.cb_remove_liens_white_space.TabIndex = 3;
            this.cb_remove_liens_white_space.Text = "Remove Lines White Space ";
            this.cb_remove_liens_white_space.ThemeName = "Office2019Light";
            // 
            // rdb_ascending
            // 
            this.rdb_ascending.CheckState = System.Windows.Forms.CheckState.Checked;
            this.rdb_ascending.Location = new System.Drawing.Point(115, 61);
            this.rdb_ascending.Name = "rdb_ascending";
            this.rdb_ascending.Size = new System.Drawing.Size(72, 18);
            this.rdb_ascending.TabIndex = 7;
            this.rdb_ascending.Text = "ascending";
            this.rdb_ascending.ToggleState = Telerik.WinControls.Enumerations.ToggleState.On;
            // 
            // cb_remove_duplicate
            // 
            this.cb_remove_duplicate.Location = new System.Drawing.Point(22, 83);
            this.cb_remove_duplicate.Name = "cb_remove_duplicate";
            this.cb_remove_duplicate.Size = new System.Drawing.Size(121, 17);
            this.cb_remove_duplicate.TabIndex = 5;
            this.cb_remove_duplicate.Text = "Remove Duplicate";
            this.cb_remove_duplicate.ThemeName = "Office2019Light";
            // 
            // cb_line_sort
            // 
            this.cb_line_sort.Location = new System.Drawing.Point(22, 60);
            this.cb_line_sort.Name = "cb_line_sort";
            this.cb_line_sort.Size = new System.Drawing.Size(87, 17);
            this.cb_line_sort.TabIndex = 4;
            this.cb_line_sort.Text = "Line Sorting";
            this.cb_line_sort.ThemeName = "Office2019Light";
            // 
            // radWaitingBar1
            // 
            this.radWaitingBar1.Location = new System.Drawing.Point(28, 83);
            this.radWaitingBar1.Name = "radWaitingBar1";
            this.radWaitingBar1.Size = new System.Drawing.Size(306, 11);
            this.radWaitingBar1.TabIndex = 87;
            this.radWaitingBar1.Text = "radWaitingBar1";
            this.radWaitingBar1.ThemeName = "Office2019Light";
            // 
            // 
            // 
            this.radWaitingBar1.WaitingBarElement.WaitingIndicatorSize = new System.Drawing.Size(100, 14);
            this.radWaitingBar1.WaitingIndicators.Add(this.waitingBarIndicatorElement2);
            this.radWaitingBar1.WaitingIndicators.Add(this.waitingBarIndicatorElement1);
            this.radWaitingBar1.WaitingIndicatorSize = new System.Drawing.Size(100, 14);
            this.radWaitingBar1.WaitingStyle = Telerik.WinControls.Enumerations.WaitingBarStyles.Dash;
            ((Telerik.WinControls.UI.RadWaitingBarElement)(this.radWaitingBar1.GetChildAt(0))).WaitingIndicatorSize = new System.Drawing.Size(100, 14);
            // 
            // waitingBarIndicatorElement2
            // 
            this.waitingBarIndicatorElement2.DisabledTextRenderingHint = System.Drawing.Text.TextRenderingHint.SystemDefault;
            this.waitingBarIndicatorElement2.Name = "waitingBarIndicatorElement2";
            this.waitingBarIndicatorElement2.StretchHorizontally = false;
            this.waitingBarIndicatorElement2.TextRenderingHint = System.Drawing.Text.TextRenderingHint.SystemDefault;
            this.waitingBarIndicatorElement2.UseCompatibleTextRendering = false;
            // 
            // waitingBarIndicatorElement1
            // 
            this.waitingBarIndicatorElement1.DisabledTextRenderingHint = System.Drawing.Text.TextRenderingHint.SystemDefault;
            this.waitingBarIndicatorElement1.Name = "waitingBarIndicatorElement1";
            this.waitingBarIndicatorElement1.StretchHorizontally = false;
            this.waitingBarIndicatorElement1.TextRenderingHint = System.Drawing.Text.TextRenderingHint.SystemDefault;
            this.waitingBarIndicatorElement1.UseCompatibleTextRendering = false;
            // 
            // radButton2
            // 
            this.radButton2.Location = new System.Drawing.Point(28, 296);
            this.radButton2.Name = "radButton2";
            this.radButton2.Size = new System.Drawing.Size(122, 24);
            this.radButton2.TabIndex = 86;
            this.radButton2.Text = "Start";
            this.radButton2.ThemeName = "Office2019Light";
            this.radButton2.Click += new System.EventHandler(this.radButton2_Click);
            // 
            // radButton1
            // 
            this.radButton1.Location = new System.Drawing.Point(28, 47);
            this.radButton1.Name = "radButton1";
            this.radButton1.Size = new System.Drawing.Size(110, 24);
            this.radButton1.TabIndex = 85;
            this.radButton1.Text = "Open target file";
            this.radButton1.ThemeName = "Office2019Light";
            this.radButton1.Click += new System.EventHandler(this.radButton1_Click_1);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // radMenuItem1
            // 
            this.radMenuItem1.Image = global::Abdal_Duplicate_Remover_App.Properties.Resources.Book_Earth_16;
            this.radMenuItem1.Name = "radMenuItem1";
            this.radMenuItem1.Text = "About Us";
            this.radMenuItem1.Click += new System.EventHandler(this.radMenuItem1_Click_1);
            // 
            // radMenuItem2
            // 
            this.radMenuItem2.Image = global::Abdal_Duplicate_Remover_App.Properties.Resources.coin_5_321;
            this.radMenuItem2.Name = "radMenuItem2";
            this.radMenuItem2.Text = "Donate";
            this.radMenuItem2.Click += new System.EventHandler(this.radMenuItem2_Click);
            // 
            // radMenuItem3
            // 
            this.radMenuItem3.Image = global::Abdal_Duplicate_Remover_App.Properties.Resources.Sitemap_16;
            this.radMenuItem3.Items.AddRange(new Telerik.WinControls.RadItem[] {
            this.radMenuItem4,
            this.radMenuItem5});
            this.radMenuItem3.Name = "radMenuItem3";
            this.radMenuItem3.Text = "Source Code";
            // 
            // radMenuItem4
            // 
            this.radMenuItem4.Image = global::Abdal_Duplicate_Remover_App.Properties.Resources.github;
            this.radMenuItem4.Name = "radMenuItem4";
            this.radMenuItem4.Text = "Github";
            this.radMenuItem4.Click += new System.EventHandler(this.radMenuItem4_Click);
            // 
            // radMenuItem5
            // 
            this.radMenuItem5.Image = global::Abdal_Duplicate_Remover_App.Properties.Resources.gitlab_icon_rgb;
            this.radMenuItem5.Name = "radMenuItem5";
            this.radMenuItem5.Text = "Gitlab";
            this.radMenuItem5.Click += new System.EventHandler(this.radMenuItem5_Click);
            // 
            // Abdal_Duplicate_Remover
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(773, 394);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.radGroupBox3);
            this.Controls.Add(this.radGroupBox2);
            this.Controls.Add(this.radGroupBox1);
            this.Controls.Add(this.radWaitingBar1);
            this.Controls.Add(this.radButton2);
            this.Controls.Add(this.radButton1);
            this.Controls.Add(this.radMenu1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Abdal_Duplicate_Remover";
            // 
            // 
            // 
            this.RootElement.ApplyShapeToControl = true;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Abdal Security Group App";
            this.ThemeName = "Office2019Light";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.radMenu1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radGroupBox3)).EndInit();
            this.radGroupBox3.ResumeLayout(false);
            this.radGroupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.lb_file_lines_new)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lb_file_name_new)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lb_file_size_new)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel8)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel9)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radGroupBox2)).EndInit();
            this.radGroupBox2.ResumeLayout(false);
            this.radGroupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.lb_file_lines_org)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lb_file_name_org)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lb_file_size_org)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radGroupBox1)).EndInit();
            this.radGroupBox1.ResumeLayout(false);
            this.radGroupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.rdb_descending)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cb_remove_empty_line)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cb_remove_liens_white_space)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rdb_ascending)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cb_remove_duplicate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cb_line_sort)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radWaitingBar1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radButton2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radButton1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private Telerik.WinControls.UI.RadDesktopAlert desk_alert;
        private Telerik.WinControls.UI.RadMenuItem radMenuItem1;
        private Telerik.WinControls.UI.RadMenu radMenu1;
        private Telerik.WinControls.UI.RadMenuItem radMenuItem2;
        private Telerik.WinControls.UI.RadMenuItem radMenuItem3;
        private Telerik.WinControls.UI.RadMenuItem radMenuItem4;
        private Telerik.WinControls.UI.RadMenuItem radMenuItem5;
        private Telerik.WinControls.UI.RadMenuItem Space1;
        private Telerik.WinControls.UI.RadMenuItem Space2;
        private System.Windows.Forms.ProgressBar progressBar1;
        private Telerik.WinControls.UI.RadGroupBox radGroupBox3;
        private Telerik.WinControls.UI.RadLabel lb_file_lines_new;
        private Telerik.WinControls.UI.RadLabel radLabel5;
        private Telerik.WinControls.UI.RadLabel lb_file_name_new;
        private Telerik.WinControls.UI.RadLabel lb_file_size_new;
        private Telerik.WinControls.UI.RadLabel radLabel8;
        private Telerik.WinControls.UI.RadLabel radLabel9;
        private Telerik.WinControls.UI.RadGroupBox radGroupBox2;
        private Telerik.WinControls.UI.RadLabel lb_file_lines_org;
        private Telerik.WinControls.UI.RadLabel radLabel3;
        private Telerik.WinControls.UI.RadLabel lb_file_name_org;
        private Telerik.WinControls.UI.RadLabel lb_file_size_org;
        private Telerik.WinControls.UI.RadLabel radLabel2;
        private Telerik.WinControls.UI.RadLabel radLabel1;
        private Telerik.WinControls.UI.RadGroupBox radGroupBox1;
        private Telerik.WinControls.UI.RadRadioButton rdb_descending;
        private Telerik.WinControls.UI.RadCheckBox cb_remove_empty_line;
        private Telerik.WinControls.UI.RadCheckBox cb_remove_liens_white_space;
        private Telerik.WinControls.UI.RadRadioButton rdb_ascending;
        private Telerik.WinControls.UI.RadCheckBox cb_remove_duplicate;
        private Telerik.WinControls.UI.RadCheckBox cb_line_sort;
        private Telerik.WinControls.UI.RadWaitingBar radWaitingBar1;
        private Telerik.WinControls.UI.WaitingBarIndicatorElement waitingBarIndicatorElement2;
        private Telerik.WinControls.UI.WaitingBarIndicatorElement waitingBarIndicatorElement1;
        private Telerik.WinControls.UI.RadButton radButton2;
        private Telerik.WinControls.UI.RadButton radButton1;
        private Telerik.WinControls.Themes.Office2019LightTheme office2019LightTheme1;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
    }
}

