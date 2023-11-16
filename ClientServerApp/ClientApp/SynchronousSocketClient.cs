using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;

namespace ClientApp
{
    public class SynchronousSocketClient
    {
        const string IP_ADDRESS = "127.0.0.1";
        const int PORT_NUM = 11000;

        public string ContactServer(string userRequest)
        {
            string responseString = "";

            try
            {
                TcpClient client = new TcpClient();
                client.Connect(IPAddress.Parse(IP_ADDRESS), PORT_NUM);
                NetworkStream stream = client.GetStream();

                StreamReader streamReader = new StreamReader(stream);
                StreamWriter streamWriter = new StreamWriter(responseString);

                streamWriter.AutoFlush = true;
                streamWriter.Write(userRequest);
                responseString = streamReader.ReadLine();

                stream.Close();
                client.Close();
            }
            catch (Exception ex)
            {
                responseString = ex.Message;     
            }



            return responseString;
        }
    }
}
