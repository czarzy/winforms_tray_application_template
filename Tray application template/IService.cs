using System.Net.Sockets;

namespace Tray_application_template
{
    interface ISocketService
    {
        int port { get; set; }
        void CreateServer();
    }
}
