using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;
using System.Net.NetworkInformation;

namespace Port_Scanner
{
    public partial class PortScanner : Form
    {
        public PortScanner()
        {
            InitializeComponent();
        }
        public static ManualResetEvent connectDone = new ManualResetEvent(false);

        private void scan_Click(object sender, EventArgs e)
        {
            try
            {
                int StartPort = Convert.ToInt32(startPort.Value);
                int EndPort = Convert.ToInt32(endPort.Value);
                //int i;
                resultScan.Items.Clear();
                IPAddress addr = IPAddress.Parse(iPAddress.Text);
                for (int i = StartPort; i <= EndPort; i++)
                {
                    //С оздаем и инициализируем сокет
                    IPEndPoint ер = new IPEndPoint(addr, i);
                    Socket socket = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
                    //Пытаемся соединиться с сервером
                    IAsyncResult asyncResult = socket.BeginConnect(ер, new AsyncCallback(ConnectCallback), socket);
                    if (!asyncResult.AsyncWaitHandle.WaitOne(30, false))
                    {
                        socket.Close();
                        resultScan.Items.Add("Порт " + i.ToString());
                        resultScan.Items[i - StartPort].SubItems.Add("закрыт");
                        resultScan.Items[i - StartPort].BackColor = Color.OrangeRed;
                        resultScan.Refresh();
                    }
                    else
                    {
                        socket.Close();
                        resultScan.Items.Add("Порт " + i.ToString());
                        resultScan.Items[i - StartPort].SubItems.Add("открыт");
                        resultScan.Items[i - StartPort].BackColor = Color.LightGreen;
                    }
                }
            }
            catch
            {
                MessageBox.Show("Вы ввели не существующий IP адресс", "Ошибка...", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private static void ConnectCallback(IAsyncResult ar)
        {
            try
            {
                Socket client = (Socket)ar.AsyncState;
                client.EndConnect(ar);
                connectDone.Set();
            }
            catch (Exception e)
            {

            }
        }
    }
}
