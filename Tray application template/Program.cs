using System;
using System.Threading;
using System.Threading.Tasks;
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
            Thread BackgroundThread = new Thread(() => { OnLoad(); }) { IsBackground = true };
            main_window main = new main_window(BackgroundThread);
            Application.Run(main);
        }

        private static void OnLoad()
        {
            ISocketService service = new SocketService(9999);
            Task.Run(() => service.CreateServer());
        }
    }
}
