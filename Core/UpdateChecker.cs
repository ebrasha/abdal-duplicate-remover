﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Net.Http;
using Newtonsoft.Json.Linq;
using System.Windows.Forms;
using System.Diagnostics;

namespace Abdal_Security_Group_App.Core
{
    public static class UpdateChecker
    {
        private static readonly string repoOwner = "ebrasha";
        private static readonly string repoName = "abdal-shecan-dns";
        private static readonly string releaseUrl = "https://github.com/" + repoOwner + "/" + repoName + "/releases";

        private static string GetCurrentVersion()
        {
            // Get the current version from the assembly information
            return Assembly.GetExecutingAssembly().GetName().Version.ToString();
        }

        public static async Task CheckForUpdateAsync()
        {
            try
            {
                string currentVersion = GetCurrentVersion();
                string latestVersion = await GetLatestVersionFromGitHubAsync();

                if (IsNewVersionAvailable(currentVersion, latestVersion))
                {
                    DialogResult dialogResult = MessageBox.Show(
                        $"A new version ({latestVersion}) is available. Would you like to update now?",
                        "Update Available",
                        MessageBoxButtons.YesNo,
                        MessageBoxIcon.Information);


                    if (dialogResult == DialogResult.Yes)
                    {
                        // Open the release URL in the default web browser
                        Process.Start(new ProcessStartInfo(releaseUrl) { UseShellExecute = true });
                    }
                }
                else
                {
                    // "You are using the latest version."
                }
            }
            catch (HttpRequestException httpEx)
            {
                // MessageBox.Show(
                //     "There was a problem checking for updates. Please check your internet connection and try again.",
                //     "Update Check Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            catch (Exception ex)
            {
                // MessageBox.Show("An unexpected error occurred while checking for updates.",
                //     "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }

        private static async Task<string> GetLatestVersionFromGitHubAsync()
        {
            using (HttpClient client = new HttpClient())
            {
                // Add User-Agent header
                Version version = Assembly.GetExecutingAssembly().GetName().Version!;
                var abdal_app_name = Assembly.GetExecutingAssembly().GetName().ToString().Split(',')[0];
                string user_agent = abdal_app_name + " " + version.Major + "." + version.Minor;
                client.DefaultRequestHeaders.Add("User-Agent", "AbdalShecanDNS");
                string url = $"https://api.github.com/repos/{repoOwner}/{repoName}/releases/latest";
                string response = await client.GetStringAsync(url);
                JObject release = JObject.Parse(response);
                return release["tag_name"].ToString();
            }
        }

        private static bool IsNewVersionAvailable(string currentVersion, string latestVersion)
        {
            return string.Compare(currentVersion, latestVersion) < 0;
        }
    }
}