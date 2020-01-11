using System;
using System.Windows.Forms;

namespace Tray_application_template
{
    public partial class main_window : Form
    {
        public main_window()
        {
            InitializeComponent();
        }

        private void TrayIcon_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            Show();
            this.WindowState = FormWindowState.Normal;
            trayIcon.Visible = false;
        }

        private void main_window_Resize(object sender, EventArgs e)
        {
            if(this.WindowState == FormWindowState.Minimized)
            {
                Hide();
                trayIcon.Visible = true;
                trayIcon.ShowBalloonTip(1000);
            }
        }
    }
}
