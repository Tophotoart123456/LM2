using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;
using System.Net.Sockets;
namespace LightManager
{
    public class ControlFor3D
    {    
        Socket socket = null;
        string _3DIp = "127.0.0.1";
        public ControlFor3D()
        {
            socket= new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);          
        }
        public bool Connact()
        {
            bool success = false;
            try
            {
                IPEndPoint endPoint = new IPEndPoint(IPAddress.Parse("127.0.0.1"), 9980);   // 端口号要与服务器对应
                socket.Connect(endPoint);
                success = true;
            }
            catch(Exception err)
            {

            }
            return success;
        }
        public void Close()
        {
            try
            {
                socket.Close();
            }
            catch(Exception err)
            {

            }
        }
        public int SendInfoTo3D(string param)
        {
            int size = 0;
            try
            {
                //update on 20200402
                LightManager.log.WriteInfo(param);
                if (null == param || 0 == param.Length)
                    return size;
                byte[] buffer = Encoding.Default.GetBytes(param);
                size=socket.Send(buffer);
                
            }
            catch(Exception err)
            {

            }
            return size;
        }



    }
}
