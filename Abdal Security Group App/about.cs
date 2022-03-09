using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Abdal_Security_Group_App
{
    public partial class about : Telerik.WinControls.UI.RadForm
    {
        private string abdal_app_name = Assembly.GetExecutingAssembly().GetName().ToString().Split(',')[0];
        private static System.IO.Stream str = Abdal_Duplicate_Remover_App.Properties.Resources.ab_us;
        private System.Media.SoundPlayer snd = new System.Media.SoundPlayer(str);

        public about()
        {
            InitializeComponent();
            Version version = Assembly.GetExecutingAssembly().GetName().Version;
            version_info.Text = "Version:" + " " + version.Major + "." + version.Minor;
            System.IO.Stream str = Abdal_Duplicate_Remover_App.Properties.Resources.ab_us;
            System.Media.SoundPlayer snd = new System.Media.SoundPlayer(str);
            snd.Play();
        }

        private void about_Load(object sender, EventArgs e)
        {
            // Call Global Chilkat Unlock
            Abdal_Security_Group_App.GlobalUnlockChilkat GlobalUnlock =
                new Abdal_Security_Group_App.GlobalUnlockChilkat();
            GlobalUnlock.unlock();

             
            DateTime get_current_year = DateTime.Now;
            copyright_text.Text =
                $"Copyright Ⓒ {get_current_year.Year.ToString()} - {get_current_year.AddYears(5).Year.ToString()} Abdal Security Group";

            string part_one_b64 =
                "SW50ZXJwcmV0YXRpb24gYW5kIERlZmluaXRpb25zCkludGVycHJldGF0aW9uClRoZSB3b3JkcyBvZiB3aGljaCB0aGUgaW5pdGlhbCBsZXR0ZXIgaXMgY2FwaXRhbGl6ZWQgaGF2ZSBtZWFuaW5ncyBkZWZpbmVkIHVuZGVyIHRoZSBmb2xsb3dpbmcgY29uZGl0aW9ucy4gVGhlIGZvbGxvd2luZyBkZWZpbml0aW9ucyBzaGFsbCBoYXZlIHRoZSBzYW1lIG1lYW5pbmcgcmVnYXJkbGVzcyBvZiB3aGV0aGVyIHRoZXkgYXBwZWFyIGluIHNpbmd1bGFyIG9yIGluIHBsdXJhbC4KRGVmaW5pdGlvbnMKRm9yIHRoZSBwdXJwb3NlcyBvZiB0aGlzIERpc2NsYWltZXI6CkFiZGFsIFNlY3VyaXR5IEdyb3VwIChyZWZlcnJlZCB0byBhcyBlaXRoZXIgInRoZSBBYmRhbCBTZWN1cml0eSBHcm91cCIsICJXZSIsICJVcyIgb3IgIk91ciIgaW4gdGhpcyBEaXNjbGFpbWVyKSByZWZlcnMgdG8gQWJkYWwgU2VjdXJpdHkgR3JvdXAuClNlcnZpY2UgcmVmZXJzIHRvIHRoZSBBcHBsaWNhdGlvbi4KWW91IG1lYW5zIHRoZSBpbmRpdmlkdWFsIGFjY2Vzc2luZyB0aGUgU2VydmljZSwgb3IgdGhlIEFiZGFsIFNlY3VyaXR5IEdyb3VwLCBvciBvdGhlciBsZWdhbCBlbnRpdHkgb24gYmVoYWxmIG9mIHdoaWNoIHN1Y2ggaW5kaXZpZHVhbCBpcyBhY2Nlc3Npbmcgb3IgdXNpbmcgdGhlIFNlcnZpY2UsIGFzIGFwcGxpY2FibGUuCkFwcGxpY2F0aW9uIG1lYW5zIHRoZSBzb2Z0d2FyZSBwcm9ncmFtIHByb3ZpZGVkIGJ5IHRoZSBBYmRhbCBTZWN1cml0eSBHcm91cCBkb3dubG9hZGVkIGJ5IFlvdSBvbiBhbnkgZWxlY3Ryb25pYyBkZXZpY2UgbmFtZWQ=";
            Chilkat.BinData bd2 = new Chilkat.BinData();
            bd2.AppendEncoded(part_one_b64, "base64");
            string decoded = bd2.GetString("utf-8");
            string part_one_b64_to_text = decoded;
            bd2.Clear();

            string part_two_b64 =
                "RGlzY2xhaW1lcgpUaGUgaW5mb3JtYXRpb24gY29udGFpbmVkIG9uIHRoZSBTZXJ2aWNlIGlzIGZvciBnZW5lcmFsIGluZm9ybWF0aW9uIHB1cnBvc2VzIG9ubHkuClRoZSBBYmRhbCBTZWN1cml0eSBHcm91cCBhc3N1bWVzIG5vIHJlc3BvbnNpYmlsaXR5IGZvciBlcnJvcnMgb3Igb21pc3Npb25zIGluIHRoZSBjb250ZW50cyBvZiB0aGUgU2VydmljZS4KSW4gbm8gZXZlbnQgc2hhbGwgdGhlIEFiZGFsIFNlY3VyaXR5IEdyb3VwIGJlIGxpYWJsZSBmb3IgYW55IHNwZWNpYWwsIGRpcmVjdCwgaW5kaXJlY3QsIGNvbnNlcXVlbnRpYWwsIG9yIGluY2lkZW50YWwgZGFtYWdlcyBvciBhbnkgZGFtYWdlcyB3aGF0c29ldmVyLCB3aGV0aGVyIGluIGFuIGFjdGlvbiBvZiBjb250cmFjdCwgbmVnbGlnZW5jZSBvciBvdGhlciB0b3J0LCBhcmlzaW5nIG91dCBvZiBvciBpbiBjb25uZWN0aW9uIHdpdGggdGhlIHVzZSBvZiB0aGUgU2VydmljZSBvciB0aGUgY29udGVudHMgb2YgdGhlIFNlcnZpY2UuIFRoZSBBYmRhbCBTZWN1cml0eSBHcm91cCByZXNlcnZlcyB0aGUgcmlnaHQgdG8gbWFrZSBhZGRpdGlvbnMsIGRlbGV0aW9ucywgb3IgbW9kaWZpY2F0aW9ucyB0byB0aGUgY29udGVudHMgb24gdGhlIFNlcnZpY2UgYXQgYW55IHRpbWUgd2l0aG91dCBwcmlvciBub3RpY2UuIApUaGUgQWJkYWwgU2VjdXJpdHkgR3JvdXAgZG9lcyBub3Qgd2FycmFudCB0aGF0IHRoZSBTZXJ2aWNlIGlzIGZyZWUgb2YgdmlydXNlcyBvciBvdGhlciBoYXJtZnVsIGNvbXBvbmVudHMuClVzYWdlIG9mIEFiZGFsIDQwNCBQZW5UZXN0ICBmb3IgYXR0YWNraW5nIHRhcmdldHMgd2l0aG91dCBwcmlvciBtdXR1YWwgY29uc2VudCBpcyBpbGxlZ2FsLiBJdCdzIHRoZSBlbmQgdXNlcidzIHJlc3BvbnNpYmlsaXR5IHRvIG9iZXkgYWxsIGFwcGxpY2FibGUgbG9jYWwsIHN0YXRlIGFuZCBmZWRlcmFsIGxhd3MuIERldmVsb3BlcnMgYXNzdW1lIG5vIGxpYWJpbGl0eSBhbmQgYXJlIG5vdCByZXNwb25zaWJsZSBmb3IgYW55IG1pc3VzZSBvciBkYW1hZ2UgY2F1c2VkIGJ5IHRoaXMgcHJvZ3JhbS4KCkV4dGVybmFsIExpbmtzIERpc2NsYWltZXIKVGhlIFNlcnZpY2UgbWF5IGNvbnRhaW4gbGlua3MgdG8gZXh0ZXJuYWwgd2Vic2l0ZXMgdGhhdCBhcmUgbm90IHByb3ZpZGVkIG9yIG1haW50YWluZWQgYnkgb3IgaW4gYW55IHdheSBhZmZpbGlhdGVkIHdpdGggdGhlIEFiZGFsIFNlY3VyaXR5IEdyb3VwLgpQbGVhc2Ugbm90ZSB0aGF0IHRoZSBBYmRhbCBTZWN1cml0eSBHcm91cCBkb2VzIG5vdCBndWFyYW50ZWUgdGhlIGFjY3VyYWN5LCByZWxldmFuY2UsIHRpbWVsaW5lc3MsIG9yIGNvbXBsZXRlbmVzcyBvZiBhbnkgaW5mb3JtYXRpb24gb24gdGhlc2UgZXh0ZXJuYWwgd2Vic2l0ZXMuCkVycm9ycyBhbmQgT21pc3Npb25zIERpc2NsYWltZXIKVGhlIGluZm9ybWF0aW9uIGdpdmVuIGJ5IHRoZSBTZXJ2aWNlIGlzIGZvciBnZW5lcmFsIGd1aWRhbmNlIG9uIG1hdHRlcnMgb2YgaW50ZXJlc3Qgb25seS4gRXZlbiBpZiB0aGUgQWJkYWwgU2VjdXJpdHkgR3JvdXAgdGFrZXMgZXZlcnkgcHJlY2F1dGlvbiB0byBpbnN1cmUgdGhhdCB0aGUgY29udGVudCBvZiB0aGUgU2VydmljZSBpcyBib3RoIGN1cnJlbnQgYW5kIGFjY3VyYXRlLCBlcnJvcnMgY2FuIG9jY3VyLiBQbHVzLCBnaXZlbiB0aGUgY2hhbmdpbmcgbmF0dXJlIG9mIGxhd3MsIHJ1bGVzIGFuZCByZWd1bGF0aW9ucywgdGhlcmUgbWF5IGJlIGRlbGF5cywgb21pc3Npb25zIG9yIGluYWNjdXJhY2llcyBpbiB0aGUgaW5mb3JtYXRpb24gY29udGFpbmVkIG9uIHRoZSBTZXJ2aWNlLgpUaGUgQWJkYWwgU2VjdXJpdHkgR3JvdXAgaXMgbm90IHJlc3BvbnNpYmxlIGZvciBhbnkgZXJyb3JzIG9yIG9taXNzaW9ucywgb3IgZm9yIHRoZSByZXN1bHRzIG9idGFpbmVkIGZyb20gdGhlIHVzZSBvZiB0aGlzIGluZm9ybWF0aW9uLgpGYWlyIFVzZSBEaXNjbGFpbWVyClRoZSBBYmRhbCBTZWN1cml0eSBHcm91cCBtYXkgdXNlIGNvcHlyaWdodGVkIG1hdGVyaWFsIHdoaWNoIGhhcyBub3QgYWx3YXlzIGJlZW4gc3BlY2lmaWNhbGx5IGF1dGhvcml6ZWQgYnkgdGhlIGNvcHlyaWdodCBvd25lci4gVGhlIEFiZGFsIFNlY3VyaXR5IEdyb3VwIGlzIG1ha2luZyBzdWNoIG1hdGVyaWFsIGF2YWlsYWJsZSBmb3IgY3JpdGljaXNtLCBjb21tZW50LCBuZXdzIHJlcG9ydGluZywgdGVhY2hpbmcsIHNjaG9sYXJzaGlwLCBvciByZXNlYXJjaC4KVGhlIEFiZGFsIFNlY3VyaXR5IEdyb3VwIGJlbGlldmVzIHRoaXMgY29uc3RpdHV0ZXMgYSAiZmFpciB1c2UiIG9mIGFueSBzdWNoIGNvcHlyaWdodGVkIG1hdGVyaWFsIGFzIHByb3ZpZGVkIGZvciBpbiBzZWN0aW9uIDEwNyBvZiB0aGUgVW5pdGVkIFN0YXRlcyBDb3B5cmlnaHQgbGF3LgpJZiBZb3Ugd2lzaCB0byB1c2UgY29weXJpZ2h0ZWQgbWF0ZXJpYWwgZnJvbSB0aGUgU2VydmljZSBmb3IgeW91ciBvd24gcHVycG9zZXMgdGhhdCBnbyBiZXlvbmQgZmFpciB1c2UsIFlvdSBtdXN0IG9idGFpbiBwZXJtaXNzaW9uIGZyb20gdGhlIGNvcHlyaWdodCBvd25lci4KVmlld3MgRXhwcmVzc2VkIERpc2NsYWltZXIKVGhlIFNlcnZpY2UgbWF5IGNvbnRhaW4gdmlld3MgYW5kIG9waW5pb25zIHdoaWNoIGFyZSB0aG9zZSBvZiB0aGUgYXV0aG9ycyBhbmQgZG8gbm90IG5lY2Vzc2FyaWx5IHJlZmxlY3QgdGhlIG9mZmljaWFsIHBvbGljeSBvciBwb3NpdGlvbiBvZiBhbnkgb3RoZXIgYXV0aG9yLCBhZ2VuY3ksIG9yZ2FuaXphdGlvbiwgZW1wbG95ZXIgb3IgQWJkYWwgU2VjdXJpdHkgR3JvdXAsIGluY2x1ZGluZyB0aGUgQWJkYWwgU2VjdXJpdHkgR3JvdXAuCkNvbW1lbnRzIHB1Ymxpc2hlZCBieSB1c2VycyBhcmUgdGhlaXIgc29sZSByZXNwb25zaWJpbGl0eSBhbmQgdGhlIHVzZXJzIHdpbGwgdGFrZSBmdWxsIHJlc3BvbnNpYmlsaXR5LCBsaWFiaWxpdHkgYW5kIGJsYW1lIGZvciBhbnkgbGliZWwgb3IgbGl0aWdhdGlvbiB0aGF0IHJlc3VsdHMgZnJvbSBzb21ldGhpbmcgd3JpdHRlbiBpbiBvciBhcyBhIGRpcmVjdCByZXN1bHQgb2Ygc29tZXRoaW5nIHdyaXR0ZW4gaW4gYSBjb21tZW50LiBUaGUgQWJkYWwgU2VjdXJpdHkgR3JvdXAgaXMgbm90IGxpYWJsZSBmb3IgYW55IGNvbW1lbnQgcHVibGlzaGVkIGJ5IHVzZXJzIGFuZCByZXNlcnZlcyB0aGUgcmlnaHQgdG8gZGVsZXRlIGFueSBjb21tZW50IGZvciBhbnkgcmVhc29uIHdoYXRzb2V2ZXIuCk5vIFJlc3BvbnNpYmlsaXR5IERpc2NsYWltZXIKVGhlIGluZm9ybWF0aW9uIG9uIHRoZSBTZXJ2aWNlIGlzIHByb3ZpZGVkIHdpdGggdGhlIHVuZGVyc3RhbmRpbmcgdGhhdCB0aGUgQWJkYWwgU2VjdXJpdHkgR3JvdXAgaXMgbm90IGhlcmVpbiBlbmdhZ2VkIGluIHJlbmRlcmluZyBsZWdhbCwgYWNjb3VudGluZywgdGF4LCBvciBvdGhlciBwcm9mZXNzaW9uYWwgYWR2aWNlIGFuZCBzZXJ2aWNlcy4gQXMgc3VjaCwgaXQgc2hvdWxkIG5vdCBiZSB1c2VkIGFzIGEgc3Vic3RpdHV0ZSBmb3IgY29uc3VsdGF0aW9uIHdpdGggcHJvZmVzc2lvbmFsIGFjY291bnRpbmcsIHRheCwgbGVnYWwgb3Igb3RoZXIgY29tcGV0ZW50IGFkdmlzZXJzLgpJbiBubyBldmVudCBzaGFsbCB0aGUgQWJkYWwgU2VjdXJpdHkgR3JvdXAgb3IgaXRzIHN1cHBsaWVycyBiZSBsaWFibGUgZm9yIGFueSBzcGVjaWFsLCBpbmNpZGVudGFsLCBpbmRpcmVjdCwgb3IgY29uc2VxdWVudGlhbCBkYW1hZ2VzIHdoYXRzb2V2ZXIgYXJpc2luZyBvdXQgb2Ygb3IgaW4gY29ubmVjdGlvbiB3aXRoIHlvdXIgYWNjZXNzIG9yIHVzZSBvciBpbmFiaWxpdHkgdG8gYWNjZXNzIG9yIHVzZSB0aGUgU2VydmljZS4KIlVzZSBhdCBZb3VyIE93biBSaXNrIiBEaXNjbGFpbWVyCkFsbCBpbmZvcm1hdGlvbiBpbiB0aGUgU2VydmljZSBpcyBwcm92aWRlZCAiYXMgaXMiLCB3aXRoIG5vIGd1YXJhbnRlZSBvZiBjb21wbGV0ZW5lc3MsIGFjY3VyYWN5LCB0aW1lbGluZXNzIG9yIG9mIHRoZSByZXN1bHRzIG9idGFpbmVkIGZyb20gdGhlIHVzZSBvZiB0aGlzIGluZm9ybWF0aW9uLCBhbmQgd2l0aG91dCB3YXJyYW50eSBvZiBhbnkga2luZCwgZXhwcmVzcyBvciBpbXBsaWVkLCBpbmNsdWRpbmcsIGJ1dCBub3QgbGltaXRlZCB0byB3YXJyYW50aWVzIG9mIHBlcmZvcm1hbmNlLCBtZXJjaGFudGFiaWxpdHkgYW5kIGZpdG5lc3MgZm9yIGEgcGFydGljdWxhciBwdXJwb3NlLgpUaGUgQWJkYWwgU2VjdXJpdHkgR3JvdXAgd2lsbCBub3QgYmUgbGlhYmxlIHRvIFlvdSBvciBhbnlvbmUgZWxzZSBmb3IgYW55IGRlY2lzaW9uIG1hZGUgb3IgYWN0aW9uIHRha2VuIGluIHJlbGlhbmNlIG9uIHRoZSBpbmZvcm1hdGlvbiBnaXZlbiBieSB0aGUgU2VydmljZSBvciBmb3IgYW55IGNvbnNlcXVlbnRpYWwsIHNwZWNpYWwgb3Igc2ltaWxhciBkYW1hZ2VzLCBldmVuIGlmIGFkdmlzZWQgb2YgdGhlIHBvc3NpYmlsaXR5IG9mIHN1Y2ggZGFtYWdlcy4KQ29udGFjdCBVcwpJZiB5b3UgaGF2ZSBhbnkgcXVlc3Rpb25zIGFib3V0IHRoaXMgRGlzY2xhaW1lciwgWW91IGNhbiBjb250YWN0IFVzOgpCeSBlbWFpbDogUHJvZi5TaGFmaWVpQGdtYWlsLmNvbQo=";
            bd2.AppendEncoded(part_two_b64, "base64");
            decoded = bd2.GetString("utf-8");
            string part_two_b64_to_text = decoded;
            bd2.Clear();


            richTextBox1.Text = "Disclaimer" + Environment.NewLine + "Last updated: December 01, " +
                                get_current_year.Year.ToString() + Environment.NewLine +
                                part_one_b64_to_text + " " + abdal_app_name + Environment.NewLine +
                                part_two_b64_to_text;


            
        }

        private void about_FormClosing(object sender, FormClosingEventArgs e)
        {
            snd.Stop();
        }
    }
}