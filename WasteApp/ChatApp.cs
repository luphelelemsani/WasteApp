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


namespace WindowsFormsApp1
{
    public partial class ChatApp : Form
    {
        Socket sck;
        EndPoint eplocal, epRemote;
        Byte[] buffer;
        public ChatApp()
        {
            InitializeComponent();
        }

        private void ChatApp_Load(object sender, EventArgs e)
        {
            // set up socket
            sck = new Socket(AddressFamily.InterNetwork, SocketType.Dgram, ProtocolType.Udp);
            sck.SetSocketOption(SocketOptionLevel.Socket, SocketOptionName.ReuseAddress, true);
            // get local IP
            IpBox.Text = GetLocalIP();
            IpRemoteBox.Text = GetLocalIP();
        }

        private void buttonConnect_Click(object sender, EventArgs e)
        {
            // binding socket
            eplocal = new IPEndPoint(IPAddress.Parse(IpBox.Text), Convert.ToInt32(PortBox.Text));
            sck.Bind(eplocal);
            //Connect to remote IP
            epRemote = new IPEndPoint(IPAddress.Parse(IpRemoteBox.Text), Convert.ToInt32(PortRemoteBox1.Text));
            sck.Connect(epRemote);
            //Listen to specific port
            buffer = new byte[1500];
            sck.BeginReceiveFrom(buffer, 0, buffer.Length, SocketFlags.None, ref epRemote, new AsyncCallback(MessageCallBack), buffer);

        }

        private string GetLocalIP()
        {
            IPHostEntry host;
            host = Dns.GetHostEntry(Dns.GetHostName());
            foreach (IPAddress ip in host.AddressList)
            {
                if (ip.AddressFamily == AddressFamily.InterNetwork)
                    return ip.ToString();

            }
            return "127.0.0.1";
        }

        private void buttonSend_Click(object sender, EventArgs e)
        {
            //Convert string to byte[]
            ASCIIEncoding aEncoding = new ASCIIEncoding();
            byte[] sendingMessage = new byte[1500];
            sendingMessage = aEncoding.GetBytes(Messagetext.Text);

            //Sending the Encoded message
            sck.Send(sendingMessage);

            //adding to the listbox
            listMessage.Items.Add("Me: " + Messagetext.Text);
            Messagetext.Text = "";

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
            Form3 su = new Form3();
            su.ShowDialog();
        }

        private void MessageCallBack(IAsyncResult aResult)
        {
            try

            {
                byte[] receivedData = new byte[1500];
                receivedData = (byte[])aResult.AsyncState;
                //Converting byte[] to string
                ASCIIEncoding aEncoding = new ASCIIEncoding();
                string receivedMessage = aEncoding.GetString(receivedData);
                //Adding message into listBox
                listMessage.Items.Add("Friend: " + receivedMessage);
                buffer = new byte[1500];
                sck.BeginReceiveFrom(buffer, 0, buffer.Length, SocketFlags.None, ref epRemote, new AsyncCallback(MessageCallBack), buffer);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

    }
}

