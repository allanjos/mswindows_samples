using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;
using System.Net.Sockets;
using System.Windows.Forms;
using System.Threading;

namespace TCPDesktopServer
{
    public partial class formMain : Form
    {
        static private Socket socketServer = null;

        private IPAddress hostIP = (Dns.Resolve(IPAddress.Any.ToString())).AddressList[0];

        private int port = 5010;

        static private bool connected = false;

        private IPEndPoint ep = null;

        static private byte[] bufferReceive = null;

        private delegate void AddItemCallback(string msg);

        public formMain()
        {
            InitializeComponent();

            // Endpoint configuration

            ep = new IPEndPoint(hostIP, port);

            formMain.bufferReceive = new byte[2048];

            buttonStop.Enabled = false;

            this.FormClosing += formMain_Closing;
        }

        private void formMain_Closing(Object sender, System.ComponentModel.CancelEventArgs e)
        {
            LogRegister("formMain_Closing()");

            Disconnect();
        }

        private void buttonStart_Click(object sender, EventArgs e)
        {
            LogRegister("Connect");

            buttonStart.Enabled = false;

            buttonStop.Enabled = true;

            // Configure server socket

            if (socketServer == null)
            {
                socketServer = new Socket(AddressFamily.InterNetwork,
                                          SocketType.Stream,
                                          ProtocolType.Tcp);

                socketServer.Bind(ep);
            }

            socketServer.Listen(5);

            try
            {
                // socketServer.Accept();

                socketServer.BeginAccept(new AsyncCallback(AcceptCallback), socketServer);
            }
            catch (Exception exception)
            {
                LogRegister("Erro ao tentar aceitar a conexão.");
                LogRegister(exception.Message);
            }

            LogRegister("Exiting from connection method.");
        }

        public void AcceptCallback(IAsyncResult ar)
        {
            LogRegister("AcceptReceiveDataCallback()");

            formMain.connected = true;

            Socket listener = (Socket) ar.AsyncState;

            Socket handler = listener.EndAccept(ar);

            StateObject state = new StateObject();

            state.workSocket = handler;

            Debug.WriteLine("Enabling data receiving.");

            handler.BeginReceive(state.buffer, 0, StateObject.BufferSize, 0, new AsyncCallback(ReadCallback), state);

            /*
            byte[] buffer = new byte[2048];
            //int bytesTransferred;

            handler.BeginReceive(buffer, 0, buffer.Length, 0, new AsyncCallback(ReadCallback), ar.AsyncState);

            string stringTransferred = Encoding.ASCII.GetString(buffer, 0, bytesTransferred);

            Console.WriteLine("String transferred: " + stringTransferred);
            Console.WriteLine("Size of data transferred is {0}", bytesTransferred);
            */

            /*
            try
            {
                socketServer.Receive(bufferReceive);

                LogRegister("Received bytes: " + bufferReceive.Length);
            }
            catch (Exception exception)
            {
                LogRegister("Exception message: " + exception.Message);
            }
            */
        }

        private void ReadCallback(IAsyncResult ar)
        {
            Debug.WriteLine("ReadCallback()");

            StateObject stateObject = (StateObject) ar.AsyncState;

            Socket socket = stateObject.workSocket;

            SocketError socketError;

            int receivedBytes = socket.EndReceive(ar, out socketError);

            Debug.WriteLine("Received bytes: {0}", receivedBytes);

            if (receivedBytes > 0)
            {
                stateObject.sb.Append(Encoding.ASCII.GetString(stateObject.buffer, 0, receivedBytes));

                string message = "";

                for (int i = 0; i < receivedBytes; i++)
                {
                    if (i > 0)
                        message += ", ";

                    message += stateObject.buffer[i];
                }

                Debug.WriteLine("  Received buffer: " + message);

                socket.BeginReceive(stateObject.buffer,
                                    0,
                                    StateObject.BufferSize,
                                    0,
                                    new AsyncCallback(ReadCallback), stateObject);
            }
            else
            {
                if (stateObject.sb.Length > 1)
                {
                    string message = "";

                    for (int i = 0; i < receivedBytes; i++)
                    {
                        if (i > 0)
                            message += ", ";

                        message += stateObject.buffer[i];
                    }

                    Debug.WriteLine("  Received buffer [COMPLETE]: " + message);
                }

                socket.Close();
            }
        }

        private void buttonStop_Click(object sender, EventArgs e)
        {
            LogRegister("Disconnect");

            buttonStop.Enabled = false;

            buttonStart.Enabled = true;

            Disconnect();
        }

        private void Disconnect()
        {
            LogRegister("Disconnect()");

            if (socketServer != null && socketServer.Connected)
            {
                socketServer.Close();
            }

            formMain.connected = false;
        }

        private void formMain_Load(object sender, EventArgs e)
        {
            LogRegister("formMain_Load()");
        }

        private void AddItem(string text)
        {
            if (this.listViewEvents.InvokeRequired)
            {
                AddItemCallback call = new AddItemCallback(AddItem);

                listViewEvents.Invoke(call, new object[] { text });
            }
            else
            {
                listViewEvents.Items.Add(text, 0);
            }
        }

        private void LogRegister(string msg)
        {
            AddItem(msg);
        }
    }
}

public class StateObject
{
    public Socket workSocket = null;
    public const int BufferSize = 64;
    public byte[] buffer = new byte[BufferSize];
    public StringBuilder sb = new StringBuilder();
    public byte[] bufferFull = new byte[BufferSize];
}