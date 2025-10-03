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
        BertPortBase _port;
        String _verinfo;
        public VersionForm(BertPortBase port, String verinfo)
        {
            _port = port;
            _verinfo = verinfo;
            InitializeComponent();
            LAB_GUI_VER.Text = _verinfo;
        }

        private void BTN_GET_VER_Click(object sender, EventArgs e)
        {
            try
            {
                if (_port.IsOpen)
                {
                    string str = "";

                    str = Commands.GetVersion(_port);

                    if (str != null)
                    {
                        LAB_FW_VER.Text = str;
                    }

                    str = Commands.GetMac(_port);

                    if (str != null)
                    {
                        LAB_MAC_ADDR.Text = str;
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
