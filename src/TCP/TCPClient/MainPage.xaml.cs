using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Networking;
using Windows.Networking.Sockets;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;
using System.Diagnostics;
using Windows.Storage.Streams;
using Windows.UI.Popups;

// The Blank Page item template is documented at http://go.microsoft.com/fwlink/?LinkId=391641

namespace TCPClient
{
    public sealed partial class MainPage : Page
    {
        private StreamSocket socketClient = null;
        private HostName hostName = null;
        private bool connected = false;

        public MainPage()
        {
            this.InitializeComponent();

            this.NavigationCacheMode = NavigationCacheMode.Required;
        }

        /// <summary>
        /// Invoked when this page is about to be displayed in a Frame.
        /// </summary>
        /// <param name="e">Event data that describes how this page was reached.
        /// This parameter is typically used to configure the page.</param>
        protected override void OnNavigatedTo(NavigationEventArgs e)
        {
            // TODO: Prepare page for display here.

            // TODO: If your application contains multiple pages, ensure that you are
            // handling the hardware Back button by registering for the
            // Windows.Phone.UI.Input.HardwareButtons.BackPressed event.
            // If you are using the NavigationHelper provided by some templates,
            // this event is handled for you.
        }

        private async void ButtonConnect_Click(object sender, RoutedEventArgs e)
        {
            Debug.WriteLine("ButtonConnect_Click()");

            if (connected)
            {
                Debug.WriteLine("Already connected.");

                return;
            }

            if (socketClient == null)
            {
                socketClient = new StreamSocket();
            }

            if (textBoxServerName.Text.Length <= 0 || textBoxServerPort.Text.Length <= 0)
            {
                MessageDialog dialog = new MessageDialog("Inform the server name and port to connect.");

                await dialog.ShowAsync();
            }

            try
            {
                Debug.WriteLine("Trying to connect to host " + textBoxServerName.Text.ToString());

                hostName = new HostName(textBoxServerName.Text.ToString());

                string port = textBoxServerPort.Text;

                await socketClient.ConnectAsync(hostName, port);

                connected = true;

                Debug.WriteLine("Connection established.");

                textBlockStatus.Text = "Connected";
            }
            catch (Exception exception) {
                if (SocketError.GetStatus(exception.HResult) == SocketErrorStatus.Unknown)
                {
                    throw;
                }

                Debug.WriteLine("Connection failed with error: " + exception.Message);

                Disconnect();
            }
        }

        private void buttonDisconnect_Click(object sender, RoutedEventArgs e)
        {
            Disconnect();
        }

        private void Disconnect()
        {
            if (socketClient != null)
            {
                socketClient.Dispose();

                socketClient = null;
            }

            connected = false;

            textBlockStatus.Text = "Disconnected";
        }

        private async void buttonSend_Click(object sender, RoutedEventArgs e)
        {
            Debug.WriteLine("buttonSend_Click()");

            if (!connected)
            {
                Debug.WriteLine("Not connected to the server.");

                return;
            }

            try
            {
                byte[] bufferSend = {5, 6, 7, 8, 9};

                IBuffer buffer = bufferSend.AsBuffer();

                await socketClient.OutputStream.WriteAsync(buffer);

                /*
                string sendData = textBlockStatus.Text.ToString();

                DataWriter dataWriter = new DataWriter(socketClient.OutputStream);

                dataWriter.WriteBuffer(buffer);

                await dataWriter.FlushAsync();
                */

                /*
                uint len = dataWriter.MeasureString(sendData);

                await dataWriter.StoreAsync();

                Debug.WriteLine("Data was sent to the server.");
                */

                //dataWriter.DetachStream();

                //dataWriter.Dispose();
            }
            catch (Exception exception) {
                Debug.WriteLine("Exception message: " + exception.Message);
            }
        }
    }
}