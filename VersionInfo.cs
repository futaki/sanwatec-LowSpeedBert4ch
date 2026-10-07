using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BERT
{
    public partial class VersionForm : Form
    {
        BertPortBase _port1;
        BertPortBase _port2;
        String _verinfo;
        public VersionForm(BertPortBase port1, BertPortBase port2, String verinfo)
        {
            _port1 = port1;
            _port2 = port2;
            _verinfo = verinfo;
            InitializeComponent();
            LAB_GUI_VER.Text = _verinfo;
        }

        private void BTN_GET_VER_Click(object sender, EventArgs e)
        {
            try
            {
                if (_port1.IsOpen)
                {
                    string str = "";

                    str = Commands.GetVersion(_port1);

                    if (str != null)
                    {
                        LAB_FW_VER.Text = str;
                    }

                    str = Commands.GetMac(_port1);

                    if (str != null)
                    {
                        LAB_MAC_ADDR1.Text = str;
                    }

                }
                if (_port2.IsOpen)
                {
                    string str = "";

                    str = Commands.GetMac(_port2);

                    if (str != null)
                    {
                        LAB_MAC_ADDR2.Text = str;
                    }

                }
            }
            catch 
            {
                DialogResult dr = MessageBox.Show("BERTに接続できませんでした接続を確認してください", "Error",
            MessageBoxButtons.OK,
                (MessageBoxIcon)Enum.Parse(typeof(MessageBoxIcon), "Error"));
            }


        }

        private void BTN_CLOSE_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
