using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Server_Assembly
{
    public class Server
    {
        static private int praiseEventId;

        public Server() 
        {
            praiseEventId = 0;
        }

        static public void Create_Server_Networking()
        {
            Valve.Sockets.Library.Initialize();
            Server_Networking.CreateNetworkingServer();
        }
    }
}
