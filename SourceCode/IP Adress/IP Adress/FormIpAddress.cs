using System;
using System.IO;    // need namespace System.IO; 
using System.Linq;
using System.Net;   // need namespace System.Net; 
using System.Net.Sockets;   // need namespace System.Net.Sockets; 
using System.Windows.Forms;

namespace IP_Adress
{
    public partial class FormIpAddress : Form
    {
        public FormIpAddress()
        {
            InitializeComponent();
            // MessageBox.Show(GetPublicIP().ToString());
            // listBox1.Items.Add(LocalIPAddress().ToString());
            label2.Text = GetPublicIP().ToString();
            localIPAddress();
        }

        public void localIPAddress()
        {
            //To get the local IP address 
            string sHostName = Dns.GetHostName();
            IPHostEntry ipE = Dns.GetHostByName(sHostName);
            IPAddress[] IpA = ipE.AddressList;
            for (int i = 0; i < IpA.Length; i++)
            {
                listBox1.Items.Add(IpA[i].ToString());
            }
        }

        private IPAddress LocalIPAddress1()
        {
            if (!System.Net.NetworkInformation.NetworkInterface.GetIsNetworkAvailable())
            {
                return null;
            }

            IPHostEntry host = Dns.GetHostEntry(Dns.GetHostName());

            return host
                .AddressList
                .FirstOrDefault(ip => ip.AddressFamily == AddressFamily.InterNetwork);
        }

        public string GetPublicIP()
        {
            String direction = "";
            WebRequest request = WebRequest.Create("http://checkip.dyndns.org/");
            using (WebResponse response = request.GetResponse())
            using (StreamReader stream = new StreamReader(response.GetResponseStream()))
            {
                direction = stream.ReadToEnd();
            }

            //Search for the ip in the html
            int first = direction.IndexOf("Address: ") + 9;
            int last = direction.LastIndexOf("</body>");
            direction = direction.Substring(first, last - first);

            return direction;
        }

        public string LocalIPAddress()
        {
            IPHostEntry host;
            string localIP = "";
            host = Dns.GetHostEntry(Dns.GetHostName());
            foreach (IPAddress ip in host.AddressList)
            {
                if (ip.AddressFamily == AddressFamily.InterNetwork)
                {
                    localIP = ip.ToString();
                    break;
                }
            }
            return localIP;
        }

    }
}
