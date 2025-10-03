using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BERT
{
    public class BertPortTcp : BertPortBase
    {
        private TcpClient tcpClient = null;
        private StreamReader sr = null;
        private StreamWriter sw = null;
        private bool isOpen = false;

        public override bool IsOpen => this.tcpClient.Connected;

        public BertPortTcp(string name)
        {
            base.name = name;
            this.tcpClient = new TcpClient()
            {
                ReceiveTimeout = 1000,
                SendTimeout = 1000,
            };            
        }

        public override void BertPortNameSet(string name)
        {
            base.name = name;
        }

        public override void Close()
        {
            if (isOpen)
            {
                this.tcpClient.Close();
                isOpen = false;
            }
            this.sr = null;
            this.sw = null;
        }

        public override async Task Open()
        {
            //try
            //{
            //    if (!isOpen) 
            //    {
            //        this.tcpClient = new TcpClient()
            //        {
            //            ReceiveTimeout = 1000,
            //            SendTimeout = 1000,
            //        };
            //        this.tcpClient.Connect(base.name, 50055);
            //        var ns = this.tcpClient.GetStream();
            //        this.sr = new StreamReader(ns, Encoding.ASCII);
            //        this.sw = new StreamWriter(ns, Encoding.ASCII);
            //        isOpen = true;
            //    }

            //}
            //catch (SocketException)
            //{
            //    // 接続タイムアウトの処理
            //    DialogResult dr = MessageBox.Show("ETHERNET接続がタイムアウトで接続できませんでした", "Error",
            //            MessageBoxButtons.OK,
            //                (MessageBoxIcon)Enum.Parse(typeof(MessageBoxIcon), "Error"));


            //}

            String ipaddr = base.name;
            try
            {
                if (!isOpen)
                {
                    this.tcpClient = new TcpClient();
                    //タイムアウトの時間を設定
                    var timeout = 1000;
                    var task = tcpClient.ConnectAsync(ipaddr, 50055);
                    if (await Task.WhenAny(task, Task.Delay(timeout)) != task)
                    {
                        //タイムアウトの例外
                        throw new SocketException(10060);
                    }
                    var ns = this.tcpClient.GetStream();
                    this.sr = new StreamReader(ns, Encoding.ASCII);
                    this.sw = new StreamWriter(ns, Encoding.ASCII);
                    isOpen = true;
                }
        }
            catch (Exception ex)
            {
                //Debug.WriteLine(ex.Message);
                //// 接続タイムアウトの処理
                //DialogResult dr = MessageBox.Show("ETHERNET接続がタイムアウトで接続できませんでした", "Error",
                //        MessageBoxButtons.OK,
                //            (MessageBoxIcon)Enum.Parse(typeof(MessageBoxIcon), "Error"));
                isOpen = false;
                throw ex;
            }

}

        public override string ReadLine()
        {
            try
            {
                if (!isOpen)
                {
                    return "OK";
                }
                return this.sr.ReadLine();
            }
            catch (IOException)
            {
                this.Close();
                return "";
            }
        }

        public override void WriteLine(string command)
        {
            try
            {
                this.sw.WriteLine(command);
                this.sw.Flush();
            }
            catch (IOException)
            {
                this.Close();
            }
        }
    }
}