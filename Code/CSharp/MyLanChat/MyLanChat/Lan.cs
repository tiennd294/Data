using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;
using System.Net.Sockets;

namespace MyLanChat
{
    public partial class Lan : Form
    {
        Socket sck;
        EndPoint epLocal, epRemote;
        byte[] buffer;
        public Lan()
        {
            InitializeComponent();
        }

        private void Lan_Load(object sender, EventArgs e)
        {
            sck = new Socket(AddressFamily.InterNetwork, SocketType.Dgram, ProtocolType.Udp);
            sck.SetSocketOption(SocketOptionLevel.Socket, SocketOptionName.ReuseAddress,true);
            txtMyIP.Text = GetLocalIP();
            txtYouIP.Text = GetLocalIP();
        }
        private string GetLocalIP()
        {
            IPHostEntry host;
            host = Dns.GetHostEntry(Dns.GetHostName());
            foreach (IPAddress ip in host.AddressList)
            {
                if (ip.AddressFamily == AddressFamily.InterNetwork)
                {
                    return ip.ToString();
                }
            }
            return "127.0.0.1";
        }

        private void btn_connect_Click(object sender, EventArgs e)
        {
            try
            {
                epLocal = new IPEndPoint(IPAddress.Parse(txtMyIP.Text), Convert.ToInt32(txtMyPort.Text));
                sck.Bind(epLocal);
                epRemote = new IPEndPoint(IPAddress.Parse(txtYouIP.Text), Convert.ToInt32(txtYouPort.Text));
                sck.Connect(epRemote);
                buffer = new byte[1500];
                sck.BeginReceiveFrom(buffer, 0, buffer.Length, SocketFlags.None, ref epRemote, new AsyncCallback(MessengeCallBack), buffer);

            }
            catch { }
        }

        private void MessengeCallBack(IAsyncResult aResult)
        {
            try
            {
                byte[] receivedData = (byte[])aResult.AsyncState;
                ASCIIEncoding aEncoding = new ASCIIEncoding();
                string receivedMessenge = aEncoding.GetString(receivedData);
                lbListchat.Items.Add("Friend: " + receivedMessenge);
                buffer = new byte[1500];
                sck.BeginReceiveFrom(buffer, 0, buffer.Length, SocketFlags.None, ref epRemote, new AsyncCallback(MessengeCallBack), buffer);
            }
            catch { }
        }

        private void btnSend_Click(object sender, EventArgs e)
        {
            ASCIIEncoding aEncoding = new ASCIIEncoding();
            byte[] sendingMessenge = new byte[1500];
            sendingMessenge = aEncoding.GetBytes(txtMess.Text);
            sck.Send(sendingMessenge);
            lbListchat.Items.Add("Me: " + txtMess.Text);
            txtMess.Text = "";
        }
    }
}
