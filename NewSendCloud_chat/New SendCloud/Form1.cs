using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net.Sockets;
using System.Net;
using System.IO;
using Microsoft.Win32;
using System.Threading; //스레드 클래스 사용
using System.Security.Cryptography; //크립토 그래피 사용

namespace New_SendCloud
{
    public partial class Form1 : Form
    {
        TcpClient Client;
        StreamReader Reader;
        StreamWriter Writer;
        NetworkStream Stream;
        Thread ReceiveThread;
        bool Connected;
        TcpListener Server;

        int smemouse = 0;

        public Form1()
        {
            InitializeComponent();
        }
        private delegate void AddTextDelegate(string strText);
        private void Receive() //받는 함수
        {
            AddTextDelegate AddText = new AddTextDelegate(txtChat.AppendText);
            try //시도
            {
                while (Connected) //연결되었을 때까지 무한반복
                {
                    Thread.Sleep(0);
                    if (Stream.CanRead)
                    {
                        string tempStr = Reader.ReadLine();
                        if (tempStr.Length > 0)
                        {
                            tempStr = AESDecrypt256(tempStr);  //도착 메시지 복호화한 값 출력
                            Invoke(AddText, "클라이언트 :" + tempStr + "\r\n");
                            if (smemouse > 0) // SimpleMemo
                            {
                                serialPort1.PortName = "COM4";
                                serialPort1.BaudRate = 9600;
                                serialPort1.Open();
                                serialPort1.Write(tempStr);
                            }
                        }
                    }
                }
            }
            catch (Exception)
            {
            }
        }

        private void Listen()
        {
            AddTextDelegate AddText = new AddTextDelegate(txtChat.AppendText);
            try
            {
                IPAddress addr = new IPAddress(0);
                int port = 5879;
                Server = new TcpListener(addr, port);
                Server.Start();
                Invoke(AddText, "[SendCloud] 서버가 시작되었습니다." + "\r\n");
                Client = Server.AcceptTcpClient();
                Connected = true;
                Invoke(AddText, "[SendCloud] 클라이언트와 연결되었습니다." + "\r\n");
                Stream = Client.GetStream();
                Reader = new StreamReader(Stream);
                Writer = new StreamWriter(Stream);
                ReceiveThread = new Thread(new ThreadStart(Receive));
                ReceiveThread.Start();
                
            }
            catch (Exception)
            {
            }
        }

        private void 시작ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Thread ListenThread = new Thread(new ThreadStart(Listen));
            ListenThread.Start();
        }

        private void 서버연결ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (txtip.Text == "")
            {
                MessageBox.Show("IP주소를 입력해 주세요.", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else { // [*]
                try
                {
                    string IP = txtip.Text;
                    int port = 5879; //5879번 포트
                    Client = new TcpClient();
                    Client.Connect(IP, port);
                    Stream = Client.GetStream();
                    Connected = true;
                    txtChat.AppendText("서버와 연결되었습니다." + "\r\new");
                    Reader = new StreamReader(Stream);
                    Writer = new StreamWriter(Stream);
                    ReceiveThread = new Thread(new ThreadStart(Receive));
                    ReceiveThread.Start();
                }
                catch (Exception)
                {
                    txtChat.AppendText("서버에 연결할 수 없습니다." + "\r\n");
                }
            }
        }

        private void 닫기ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("준비 중입니다.", "New SendCloud"); // [*]
        }

        private void btnSend_Click(object sender, EventArgs e)
        {
            txtChat.AppendText("나:" + txtSend.Text + "\r\n");
            Writer.WriteLine(AESEncrypt256(txtSend.Text)); //보낼 때 암호화
            Writer.Flush();
            txtSend.Clear();
        }

        private void 환경설정ToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            if(MessageBox.Show("종료하시겠습니까?", "New SendCloud", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                Connected = false;
                if (Reader != null)
                    Reader.Close();
                if (Writer != null)
                    Writer.Close();
                if (Server != null)
                    Server.Stop();
                if (Client != null)
                    Client.Close();
                if (ReceiveThread != null)
                    ReceiveThread.Abort();
                //0720
                /*System.Diagnostics.Process[] processList = System.Diagnostics.Process.GetProcessesByName("New SendCloud.vshost");
                while (processList.Length < 1)
                {
                    processList = System.Diagnostics.Process.GetProcessesByName("New SendCloud.vshost");
                }
                processList[0].Kill();
                 * */
            }
            else
            {
                e.Cancel = true;
            }
        }

        private void txtSend_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)13) //Enter 키를 누를때
            {
                e.Handled = true; //소리 없앰
                if (this.txtSend.Text == "")
                {
                    this.txtSend.Focus();
                }
                else
                {
                    txtChat.AppendText("나:" + txtSend.Text + "\r\n");
                    Writer.WriteLine(AESEncrypt256(txtSend.Text)); //보낼 때 암호화
                    Writer.Flush();
                    txtSend.Clear();
                }
            }
        }
        private String AESEncrypt256(String InputText)
        {
            string Password = "nscaes256"; // 키값 생성

            RijndaelManaged RijndaelCipher = new RijndaelManaged();

            // 입력받은 문자열을 바이트 배열로 변환  
            byte[] PlainText = System.Text.Encoding.Unicode.GetBytes(InputText);

            // 딕셔너리 공격을 대비해서 키를 더 풀기 어렵게 만들기 위해서   
            // Salt를 사용한다.  
            byte[] Salt = Encoding.ASCII.GetBytes(Password.Length.ToString());

            PasswordDeriveBytes SecretKey = new PasswordDeriveBytes(Password, Salt);

            // Create a encryptor from the existing SecretKey bytes.  
            // encryptor 객체를 SecretKey로부터 만든다.  
            // Secret Key에는 32바이트  
            // Initialization Vector로 16바이트를 사용  
            ICryptoTransform Encryptor = RijndaelCipher.CreateEncryptor(SecretKey.GetBytes(32), SecretKey.GetBytes(16));

            MemoryStream memoryStream = new MemoryStream();

            // CryptoStream객체를 암호화된 데이터를 쓰기 위한 용도로 선언  
            CryptoStream cryptoStream = new CryptoStream(memoryStream, Encryptor, CryptoStreamMode.Write);

            cryptoStream.Write(PlainText, 0, PlainText.Length);

            cryptoStream.FlushFinalBlock();

            byte[] CipherBytes = memoryStream.ToArray();

            memoryStream.Close();
            cryptoStream.Close();

            string EncryptedData = Convert.ToBase64String(CipherBytes);

            return EncryptedData;
        }
        public String AESDecrypt256(String InputText)
        {
            string Password = "nscaes256";

            RijndaelManaged RijndaelCipher = new RijndaelManaged();

            byte[] EncryptedData = Convert.FromBase64String(InputText);
            byte[] Salt = Encoding.ASCII.GetBytes(Password.Length.ToString());

            PasswordDeriveBytes SecretKey = new PasswordDeriveBytes(Password, Salt);

            // Decryptor 객체를 만든다.  
            ICryptoTransform Decryptor = RijndaelCipher.CreateDecryptor(SecretKey.GetBytes(32), SecretKey.GetBytes(16));

            MemoryStream memoryStream = new MemoryStream(EncryptedData);

            // 데이터 읽기 용도의 cryptoStream객체  
            CryptoStream cryptoStream = new CryptoStream(memoryStream, Decryptor, CryptoStreamMode.Read);

            // 복호화된 데이터를 담을 바이트 배열을 선언한다.  
            byte[] PlainText = new byte[EncryptedData.Length];

            int DecryptedCount = cryptoStream.Read(PlainText, 0, PlainText.Length);

            memoryStream.Close();
            cryptoStream.Close();

            string DecryptedData = Encoding.Unicode.GetString(PlainText, 0, DecryptedCount);

            return DecryptedData;
        }

        private void simpleMemo사용ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("준비중입니다.", "SimpleMemo 연동");
        } 
    }
}
