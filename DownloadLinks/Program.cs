using System;
using System.Windows.Forms;
using System.Runtime.InteropServices;

namespace DownloadLinks
{
    static class Program
    {
        /// <summary>
        /// Punto di ingresso principale dell'applicazione.
        /// </summary>
        [STAThread]
        static void Main(string[] args)
        {
            try
            {
                if (args.Length == 0)
                {
                    Application.EnableVisualStyles();
                    Application.SetCompatibleTextRenderingDefault(false);
                    Application.Run(new finestra());
                }
                else if (args.Length == 7)
                {
                    finestra f = new finestra(args);
                    f.download_Terminal();
                }
                else throw new Exception();
            }
            catch (Exception e)
            {
                Console.WriteLine(e.StackTrace);
            }
        }
    }
}
