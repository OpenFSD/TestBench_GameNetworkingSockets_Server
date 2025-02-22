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
        static private Thread thread_SendResult;
        static private Thread thread_RecieveInputAction;
        public Server() 
        {
            praiseEventId = 0;
        }

        static public void Create_Server_Networking()
        {
            Valve.Sockets.Library.Initialize();
            Server_Networking.CreateNetworkingServer();
            thread_SendResult = new Thread(Server_Assembly.Server.Thread_SendResult);
            thread_SendResult.Start();
            thread_RecieveInputAction = new Thread(Server_Assembly.Server.Thread_RecieveInputAction);
            thread_RecieveInputAction.Start();
        }

        static public void Thread_SendResult()
        {
            while (true)
            {
                Server_Assembly.Server_Networking.CreateAndSendNewMessage();
            }
        }

        static public void Thread_RecieveInputAction()
        {
            while (true)
            {
                Server_Assembly.Server_Networking.CopyPayloadFromMessage();
            }
        }
    }
}
