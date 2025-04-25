using Abdal_Security_Group_App.Core;
using System.Diagnostics;
using System.Globalization;
using System.Reflection;
using System.Text.RegularExpressions;

namespace Abdal_Security_Group_App
{
    public partial class Main : Telerik.WinControls.UI.RadForm
    {
        private bool selected_file = false;
        private bool stop_op_status = false;
        private string abdal_app_name = Assembly.GetExecutingAssembly().GetName().ToString().Split(',')[0];
        private AbdalSoundPlayer ab_player = new AbdalSoundPlayer();

        private string abdal_app_name_for_url = Assembly.GetExecutingAssembly().GetName().ToString().Split(',')[0]
            .ToLower().Replace(' ', '-');


        public Main()
        {
            InitializeComponent();
            //change form title
            Version version = Assembly.GetExecutingAssembly().GetName().Version!;
            Text = abdal_app_name + " " + version.Major + "." + version.Minor;

            // Call Global Chilkat Unlock
            ChilkatMng.UnlockChilkat();
        }

        #region Dragable Form Start

        protected override void WndProc(ref Message m)
        {
            base.WndProc(ref m);
            if (m.Msg == WM_NCHITTEST)
                m.Result = (IntPtr)(HT_CAPTION);
        }

        private const int WM_NCHITTEST = 0x84;
        private const int HT_CLIENT = 0x1;
        private const int HT_CAPTION = 0x2;

        #endregion

        private async void Main_Load(object sender, EventArgs e)
        {
            desk_alert.ThemeName = "VisualStudio2022Dark";
            radWaitingBar1.Visible = false;
            progressBar1.Value1 = 0;
            await UpdateChecker.CheckForUpdateAsync();

        }

        private void menuItem_github_Click(object sender, EventArgs e)
        {
            ab_player.sPlayer("checkbox");
            Process.Start(new ProcessStartInfo("https://github.com/ebrasha/" + abdal_app_name_for_url) { UseShellExecute = true });
        }

        private void menuItem_gitlab_Click(object sender, EventArgs e)
        {
            ab_player.sPlayer("checkbox");
            Process.Start(new ProcessStartInfo("https://gitlab.com/Prof.Shafiei/" + abdal_app_name_for_url) { UseShellExecute = true });
        }

        private void menuItem_donate_Click(object sender, EventArgs e)
        {

        }

        private void menuItem_about_us_Click(object sender, EventArgs e)
        {
            ab_player.sPlayer("checkbox");
            about_us about_form = new Abdal_Security_Group_App.about_us();
            about_form.ShowDialog();
            about_form.TopMost = true;
        }

        private void Main_FormClosing(object sender, FormClosingEventArgs e)
        {
            ab_player.sPlayer("checkbox");
            Process.GetCurrentProcess().Kill();
            Environment.Exit(0);
        }

        private void bg_worker_RunWorkerCompleted(object sender, System.ComponentModel.RunWorkerCompletedEventArgs e)
        {
            radWaitingBar1.StopWaiting();
            radWaitingBar1.Visible = false;
            selected_file = false;
            progressBar1.Value1 = 100;

            if (e.Cancelled == true)
            {
                this.desk_alert.CaptionText = abdal_app_name;
                this.desk_alert.ContentText = "Canceled Process By User!";
                this.desk_alert.Show();
                ab_player.sPlayer("cancel");
            }
            else if (e.Error != null)
            {
                this.desk_alert.CaptionText = abdal_app_name;
                this.desk_alert.ContentText = e.Error.Message;
                this.desk_alert.Show();


                ab_player.sPlayer("error");
            }
            else
            {
                this.desk_alert.CaptionText = abdal_app_name;
                this.desk_alert.ContentText = "Done!";
                this.desk_alert.Show();

                if (stop_op_status)
                {
                    ab_player.sPlayerSync("cancel");
                }
                else
                {
                    ab_player.sPlayerSync("op-com");
                }

                ab_player.sPlayer("done");
            }
        }

        private void btn_start_Click(object sender, EventArgs e)
        {
            try
            {
                if (selected_file == false)
                {
                    ab_player.sPlayerSync("error");
                    string MessageBoxTitle = abdal_app_name;
                    string MessageBoxContent = "First please select the txt file";
                    DialogResult dialogResult = MessageBox.Show(MessageBoxContent, MessageBoxTitle,
                        MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);

                }
                else
                {
                    if (backgroundWorker1.IsBusy != true)
                    {
                        ab_player.sPlayerSync("start");
                        progressBar1.Value1 = 0;
                        radWaitingBar1.Visible = true;
                        radWaitingBar1.StartWaiting();
                        backgroundWorker1.RunWorkerAsync();
                    }
                }
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.ToString());
            }
        }

        private void btn_exit_Click(object sender, EventArgs e)
        {

            Application.Exit();
        }

        private void btn_minimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void irDonationBtn_Click(object sender, EventArgs e)
        {
            ab_player.sPlayer("coin");
            Process.Start(new ProcessStartInfo("https://alphajet.ir/abdal-donation") { UseShellExecute = true });
        }

        private void EnDonationBtn_Click(object sender, EventArgs e)
        {
            ab_player.sPlayer("coin");
            Process.Start(new ProcessStartInfo("https://ebrasha.com/abdal-donation") { UseShellExecute = true });
        }

        public string human_readable_size(string filename)
        {
            string[] sizes = { "B", "KB", "MB", "GB", "TB" };
            double len = new FileInfo(filename).Length;
            int order = 0;
            while (len >= 1024 && order < sizes.Length - 1)
            {
                order++;
                len = len / 1024;
            }


            string result = String.Format("{0:0.##} {1}", len, sizes[order]);
            return result;
        }

        private string seprate_3_digit(string my_number)
        {
            int number = Int32.Parse(my_number);
            return number.ToString("N0", new NumberFormatInfo()
            {
                NumberGroupSizes = new[] { 3 },
                NumberGroupSeparator = ","
            });
        }


        private void open_target_file_Click(object sender, EventArgs e)
        {
            openFileDialog1.AddExtension = false;
            openFileDialog1.FileName = "";
            openFileDialog1.Title = "Abdal Duplicate Remover";
            openFileDialog1.DefaultExt = "txt";
            openFileDialog1.Filter = "txt File |*.txt";
            openFileDialog1.CheckFileExists = true;
            openFileDialog1.CheckPathExists = true;
            var dialog = openFileDialog1.ShowDialog();
            if (dialog == DialogResult.OK)
            {
                selected_file = true;
                FileInfo info = new FileInfo(openFileDialog1.FileName);
                lb_file_name_org.Text = info.Name;
                lb_file_size_org.Text = human_readable_size(openFileDialog1.FileName);
                lb_file_lines_org.Text = seprate_3_digit(File.ReadLines(openFileDialog1.FileName).Count().ToString());
            }
        }
        public string RemoveAllSpaces(string string_target)
        {
            string user_string_target = string_target;
            user_string_target = Regex.Replace(user_string_target, @"\s+", " ");
            user_string_target = user_string_target.Replace(" ", "");
            user_string_target = user_string_target.ToLower();
            return user_string_target;
        }

        private void backgroundWorker1_DoWork(object sender, System.ComponentModel.DoWorkEventArgs e)
        {
            try
            {
                string[] lines_final = new[] { "" };
                string lines_remove_empty_line = "";


                var file_name = Path.GetFileNameWithoutExtension(openFileDialog1.FileName);
                var file_ext = Path.GetExtension(openFileDialog1.FileName);
                var file_path = Path.GetFullPath(openFileDialog1.FileName);
                file_path = file_path.Replace(file_name, "");
                file_path = file_path.Replace(file_ext, "");
                lines_final = File.ReadAllLines(openFileDialog1.FileName);
                if (cb_remove_liens_white_space.Checked)
                {
                    // lines_final = lines_final.Where(s => !string.IsNullOrWhiteSpace(s)).Distinct().ToArray();
                    // phase two
                    var lines_ = from element in lines_final
                                 select RemoveAllSpaces(element);
                    lines_final = lines_.ToArray();
                }


                if (cb_line_sort.Checked)
                {
                    if (rdb_ascending.IsChecked)
                    {
                        var lines_sort = from element in lines_final
                                         orderby element ascending
                                         select element;
                        lines_final = lines_sort.ToArray();
                    }
                    else
                    {
                        var lines_sort = from element in lines_final
                                         orderby element descending
                                         select element;
                        lines_final = lines_sort.ToArray();
                    }
                }

                if (cb_remove_duplicate.Checked)
                {
                    lines_final = lines_final.Distinct().ToArray();
                }

                if (cb_remove_empty_line.Checked)
                {
                    // string[] temp_final = new[] {""};
                    List<string> temp_final = new List<string>();
                    foreach (string line in lines_final)
                    {
                        if (line != "")
                        {
                            temp_final.Add(line);
                        }
                    }

                    lines_final = temp_final.ToArray();
                    lines_final = lines_final.Where(s => !string.IsNullOrEmpty(s)).ToArray();
                    lines_final = lines_final.Where(s => !string.IsNullOrWhiteSpace(s)).ToArray();
                    File.WriteAllLines(file_path + file_name + "_Abdal_Duplicate_Remover.txt", lines_final);
                }
                else
                {
                    File.WriteAllLines(file_path + file_name + "_Abdal_Duplicate_Remover.txt", lines_final);
                }


                // show file info
                FileInfo info = new FileInfo(openFileDialog1.FileName);
                string new_file_path = openFileDialog1.FileName.Replace(info.Name, "");
                new_file_path = new_file_path + file_name + "_Abdal_Duplicate_Remover.txt";
                lb_file_name_new.Text = file_name + "_Abdal_Duplicate_Remover.txt";
                lb_file_size_new.Text = human_readable_size(new_file_path);
                lb_file_lines_new.Text = seprate_3_digit(File.ReadLines(new_file_path).Count().ToString());
                openFileDialog1.Reset();
            }
            catch
            {
            }
        }



        private void cb_remove_liens_white_space_MouseHover(object sender, EventArgs e)
        {

        }

        private void btn_exit_MouseHover(object sender, EventArgs e)
        {
            
        }
    }
}