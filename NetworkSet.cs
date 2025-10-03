using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO.Ports;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BERT
{
    public partial class NetworkSet : Form
    {
        private BertPortBase _bertPort;
        private BERT_MainForm _parentForm;
        public bool NetworkSettingUpdated = false;

        public NetworkSet(BertPortBase bertPort, BERT_MainForm parentForm)
        {
            InitializeComponent();
            _parentForm = parentForm;
            _bertPort = bertPort;
            NetworkSet_Load(_bertPort);
        }

        private void NetworkSet_Load(BertPortBase bertPort)
        {
            List<string> ipaddr;

            if (bertPort != null && bertPort.IsOpen && _bertPort.GetType() == typeof(BertPortSerial))
            {
                PBOX_COM_STS.Image = PBOX_COM_STS.InitialImage;
                ipaddr = Commands.IPGet(_parentForm.GetBertPort);

                this.IP_Txt.Enabled = true;
                this.IP_Txt.Text = ipaddr[0];
                this.MASK_Txt.Enabled = true;
                this.MASK_Txt.Text = ipaddr[1];
                this.GW_Txt.Enabled = true;
                this.GW_Txt.Text = ipaddr[2];

                this._parentForm.IP_Txt.Text = ipaddr[0];
            }
            else 
            {
                PBOX_COM_STS.Image = PBOX_COM_STS.ErrorImage;
                CBOX_DHCP.Checked = false;
                CBOX_DHCP.Enabled = false;
                IP_Txt.Enabled = false;
                MASK_Txt.Enabled = false;
                GW_Txt.Enabled = false;
                return;
            }

            if (_parentForm.DHCPFlag)
            {
                IP_Txt.Enabled = false;
                MASK_Txt.Enabled = false;
                GW_Txt.Enabled = false;
                CBOX_DHCP.Checked = true;
            }
            else
            {
                CBOX_DHCP.Checked = false;
                IP_Txt.Enabled = true;
                MASK_Txt.Enabled = true;
                GW_Txt.Enabled = true;
            }
        }

        private void BTN_Cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private BERT_MainForm Get_parentForm()
        {
            return _parentForm;
        }

        private void BTN_Set_Click(object sender, EventArgs e)
        {
            string rslt = "";

            if (_bertPort != null && _bertPort.IsOpen && _bertPort.GetType() == typeof(BertPortSerial))
            {
                _parentForm.IpAddr = IP_Txt.Text;
                _parentForm.IpMask = MASK_Txt.Text;
                _parentForm.GwAddr = GW_Txt.Text;

                if (_parentForm.DHCPFlag)
                {
                    rslt = Commands.SetDHCP(_parentForm.GetBertPort, 1);
                }
                else 
                {
                    rslt = Commands.SetDHCP(_parentForm.GetBertPort, 0);
                    rslt = Commands.IPSet(_parentForm.GetBertPort, _parentForm.IpAddr, _parentForm.IpMask, _parentForm.GwAddr);
                }

                Commands.Save(_parentForm.GetBertPort);
                Commands.Reset(_parentForm.GetBertPort);

                //if (this.InvokeRequired)
                //{
                //    _ = this.Invoke(new Action(Get_parentForm().ClosingIF));
                //}
                this.NetworkSettingUpdated = true;

                this.Close();
            }
            else
            {
                DialogResult dr = MessageBox.Show("COMポートにデバイスが接続されていません", "Error", MessageBoxButtons.OK,
                                (MessageBoxIcon)Enum.Parse(typeof(MessageBoxIcon), "Error"));
                this.Close();
                return;
            }
        }

        private void CBOX_DHCP_CheckedChanged(object sender, EventArgs e)
        {
            //string rslt = "";
            List<string> ipaddr;

            if (_bertPort != null && _bertPort.IsOpen)
            {
                if (CBOX_DHCP.Checked)
                {
                    //rslt = Commands.SetDHCP(_parentForm.GetBertPort, 1);

                    IP_Txt.Enabled = false;
                    MASK_Txt.Enabled = false;
                    GW_Txt.Enabled = false;
                    _parentForm.DHCPFlag = true;
                }
                else
                {
                    ipaddr = Commands.IPGet(_parentForm.GetBertPort);

                    IP_Txt.Enabled = true;
                    IP_Txt.Text = ipaddr[0];
                    MASK_Txt.Enabled = true;
                    MASK_Txt.Text = ipaddr[1];
                    GW_Txt.Enabled = true;
                    GW_Txt.Text = ipaddr[2];
                    _parentForm.DHCPFlag = false;
                }
            }
            else
            {
                IP_Txt.Enabled = false;
                MASK_Txt.Enabled = false;
                GW_Txt.Enabled = false;
                CBOX_DHCP.Enabled = false;
            }

        }
    }
}
