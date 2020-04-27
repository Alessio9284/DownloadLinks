using System;
using System.Net;

namespace DownloadLinks
{
    public partial class finestra : MetroFramework.Forms.MetroForm
    {
        public finestra()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            /*url_text.Text = "https://www.animelove-streaming21.cloud/anime/DDL/Anime/Yu-Gi-Oh-Zexal/";
            radice_text.Text = "Yu-Gi-Oh-Zexal_Ep_";
            estensione_text.Text = ".mp4";
            destinazione_text.Text = @"F:\video\";*/
            da_text.Text = "0";
            a_text.Text = "50";
            no_radio.Checked = true;
        }

        private void download_Click(object sender, EventArgs e)
        {
            for (int i = Convert.ToInt32(da_text.Text); i <= Convert.ToInt32(a_text.Text); i++)
                start_download(ref i);
        }

        private void start_download(ref int i)
        {
            string zeri = "", nomefile;

            if (si_radio.Checked == true)
            {
                // riempimento con zeri
                if (i < 10) zeri = "00";
                else if (i < 100) zeri = "0";
            }

            nomefile = radice_text.Text + zeri + i + estensione_text.Text;

            using (var client = new WebClient())
            {
                try
                {
                    client.DownloadProgressChanged += progress;

                    //Console.WriteLine(url + nomefile + " bella " + dest + nomefile);
                    client.DownloadFileAsync
                    (
                        new Uri(url_text.Text + nomefile),
                        destinazione_text.Text + nomefile
                    );
                }
                catch (Exception err)
                {
                    i = Convert.ToInt32(a_text.Text);
                    errore.Text += err.StackTrace;
                }
            }
        }

        void progress(object sender, DownloadProgressChangedEventArgs e)
        {
            progressione.Value = e.ProgressPercentage;
        }
    }
}
