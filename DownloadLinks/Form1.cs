using System;
using System.Diagnostics;
using System.IO;
using System.Net;

namespace DownloadLinks
{
    public partial class finestra : MetroFramework.Forms.MetroForm
    {
        private string url, rad, ext, dest;
        private int da, a_, cifre;
        private bool riempimento;

        public finestra()
        {
            InitializeComponent();
        }

        public finestra(string[] args)
        {
            // url radice estensione da a riempimento destinazione

            url = args[0];
            rad = args[1];
            ext = args[2];
            da = Convert.ToInt32(args[3]);
            a_ = Convert.ToInt32(args[4]);
            riempimento = Convert.ToBoolean(args[5]);
            dest = (args[6].EndsWith("\\") || args[6].EndsWith("/") ? args[6] : args[6] + "\\");
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            /*url_text.Text = "https://www.animelove-streaming21.cloud/anime/DDL/Anime/Yu-Gi-Oh-Zexal/";
            radice_text.Text = "Yu-Gi-Oh-Zexal_Ep_";
            estensione_text.Text = ".mp4";
            destinazione_text.Text = @"C:\Users\";*/
            da_text.Text = "0";
            a_text.Text = "50";
            no_radio.Checked = true;
        }

        private void download_Click(object sender, EventArgs e)
        {
            int a = Convert.ToInt32(a_text.Text);
            string dest1 = destinazione_text.Text;

            cifre = (int) Math.Floor(Math.Log(a) / Math.Log(10));
            destinazione_text.Text = (dest1.EndsWith("\\") || dest1.EndsWith("/") ? dest1 : dest1 + "\\");

            for (int i = Convert.ToInt32(da_text.Text); i <= a; i++)
                start_download(ref i);
        }

        public void download_Terminal()
        {
            cifre = (int)Math.Floor(Math.Log(a_) / Math.Log(10));

            for (int i = da; i <= a_; i++)
                start_download_terminal(ref i);
        }

        private void start_download(ref int i)
        {
            string zeri = "", nomefile;

            nomefile = radice_text.Text;

            if (si_radio.Checked == true)
            {
                for (int x = 0; x < cifre - (int)Math.Floor(Math.Log(i) / Math.Log(10)); x++)
                    zeri += "0";

                nomefile += zeri;
            }

            nomefile += i + estensione_text.Text;

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

        private void start_download_terminal(ref int i)
        {
            string zeri = "", nomefile;

            nomefile = rad;

            if (riempimento)
            {
                for (int x = 0; x < cifre - (int)Math.Floor(Math.Log(i) / Math.Log(10)); x++)
                    zeri += "0";

                nomefile += zeri;
            }

            nomefile += i + ext;

            using (var client = new WebClient())
            {
                try
                {
                    Debug.WriteLine(nomefile);
                    //client.DownloadFile(new Uri(url + nomefile), dest + nomefile);

                    using (Stream data = client.OpenRead(new Uri(url + nomefile)))
                    {
                        using (Stream targetfile = File.Create(dest + nomefile))
                        {
                            data.CopyTo(targetfile);
                        }
                    }
                }
                catch (Exception err)
                {
                    Debug.WriteLine(err.StackTrace);
                }
            }
        }

        void progress(object sender, DownloadProgressChangedEventArgs e)
        {
            progressione.Value = e.ProgressPercentage;
        }
    }
}
