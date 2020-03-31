using System;
using System.Windows.Forms;

namespace Sotyafoglalo
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            try
            {
                if (DataBaseHelper.csatlakozas())
                {
                    Application.EnableVisualStyles();
                    Application.SetCompatibleTextRenderingDefault(false);
                    Application.Run(new Bejelentkezes());
                    DataBaseHelper.kapcsolatZaras();
                }
                else
                {
                    MessageBox.Show("Hiányos adatbázis!\n" +
                        "Keresd a fejlesztőt: Rekenei Zolta +36702395180");
                }
            }
            catch (Exception e)
            {
                MessageBox.Show("\n\n" + e.ToString());
            }
        }
    }
}
