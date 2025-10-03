using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO.Ports;
using System.Threading;

namespace BERT
{
    internal class BertSerialPort
    {
        public System.IO.Ports.SerialPort port = new System.IO.Ports.SerialPort();



        public BertSerialPort()
        {
            this.port.NewLine = "\r\n";
        }

        public void Open(string portName)
        {
            this.port.PortName = portName;
            this.port.BaudRate = 115200;
            this.port.Open();
        }

        public Boolean IsOpen()
        {
            return this.port.IsOpen;
        }

        public void Close()
        {
            this.port.Close();
        }

        public void Send(string text)
        {
            this.port.WriteLine(text);
        }

        public String Read()
        {
            string str;
            string rslt;

            str = this.port.ReadLine();
            rslt = this.port.ReadLine();
            if (rslt != "OK")
            {
                DialogResult dr = MessageBox.Show("コマンド実行エラー　" + rslt, "Error", MessageBoxButtons.OK,
                                                (MessageBoxIcon)Enum.Parse(typeof(MessageBoxIcon), "Error"));
                return "";
            }
            return str;
        }

    }
}
