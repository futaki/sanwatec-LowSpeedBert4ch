using System;
using System.Collections.Generic;
using System.IO.Ports;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Remoting.Messaging;

namespace BERT
{
    public class BertPortSerial : BertPortBase
    {
        private readonly SerialPort port;

        public override bool IsOpen => this.port.IsOpen;

        public BertPortSerial(string name)
        {
            base.name = name;
            this.port = new SerialPort
            {
                PortName = base.name,
                BaudRate = 115200,
                Parity = Parity.None,
                Handshake = Handshake.None,
                ReadTimeout = 500,
                WriteTimeout = 500,
                NewLine = "\r\n"
            };
        }

        public override void BertPortNameSet(string name)
        {
            base.name = name;
            this.port.PortName = name;
        }

        public override void Close()
        {
            this.port.Close();
        }

        public override async Task Open()
        {
            await Task.Delay(1); // ダミー
            this.port.Open();
        }

        public override string ReadLine()
        {
            return this.port.ReadLine();
        }

        public override void WriteLine(string command)
        {
            this.port.WriteLine(command);
        }
    }
}
