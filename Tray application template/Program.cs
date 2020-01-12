using System;
using System.Windows.Forms;

namespace Tray_application_template
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            main_window main = new main_window();
            main.Load += OnLoad;
            Application.Run(main);
        }

        private static void OnLoad(object sender, EventArgs e)
        {
            ISocketService service = new SocketService(9999);
            service.CreateServer();
        }
    }
}
