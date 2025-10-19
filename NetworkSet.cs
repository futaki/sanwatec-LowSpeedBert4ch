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
        private BertPortBase _bertPort1;
        private BertPortBase _bertPort2;
        private BERT_MainForm _parentForm;
        public bool NetworkSettingUpdated = false;

        public NetworkSet(BertPortBase bertPort1, BertPortBase bertPort2, BERT_MainForm parentForm)
        {
            InitializeComponent();
            _parentForm = parentForm;
            _bertPort1 = bertPort1;
            _bertPort2 = bertPort2;
            NetworkSet_Load(_bertPort1, _bertPort2);
        }

        private void NetworkSet_Load(BertPortBase bertPort1, BertPortBase bertPort2)
        {
            List<string> ipaddr1;
            List<string> ipaddr2;

            if (bertPort1 != null && bertPort1.IsOpen && _bertPort1.GetType() == typeof(BertPortSerial))
            {
                PBOX_COM_STS.Image = PBOX_COM_STS.InitialImage;
                ipaddr1 = Commands.IPGet(_parentForm.GetBertPort1);

                this.IP1_Txt.Enabled = true;
                this.IP1_Txt.Text = ipaddr1[0];
                this.MASK1_Txt.Enabled = true;
                this.MASK1_Txt.Text = ipaddr1[1];
                this.GW_Txt.Enabled = true;
                this.GW_Txt.Text = ipaddr1[2];

                this._parentForm.TXT_IPAdr1.Text = ipaddr1[0];
            }
            else 
            {
                PBOX_COM_STS.Image = PBOX_COM_STS.ErrorImage;
                CBOX_DHCP.Checked = false;
                CBOX_DHCP.Enabled = false;
                IP1_Txt.Enabled = false;
                MASK1_Txt.Enabled = false;
                GW_Txt.Enabled = false;
            }

            if (bertPort2 != null && bertPort2.IsOpen && _bertPort2.GetType() == typeof(BertPortSerial))
            {
                PBOX_COM_STS.Image = PBOX_COM_STS.InitialImage;
                ipaddr2 = Commands.IPGet(_parentForm.GetBertPort2);

                this.IP2_Txt.Enabled = true;
                this.IP2_Txt.Text = ipaddr2[0];
                this.MASK2_Txt.Enabled = true;
                this.MASK2_Txt.Text = ipaddr2[1];
                this.GW_Txt.Enabled = true;
                //this.GW_Txt.Text = ipaddr2[2];

                this._parentForm.TXT_IPAdr2.Text = ipaddr2[0];
            }
            else
            {
                PBOX_COM_STS.Image = PBOX_COM_STS.ErrorImage;
                CBOX_DHCP.Checked = false;
                CBOX_DHCP.Enabled = false;
                IP2_Txt.Enabled = false;
                MASK2_Txt.Enabled = false;
                GW_Txt.Enabled = false;
                return;
            }

            if (_parentForm.DHCPFlag)
            {
                IP1_Txt.Enabled = false;
                MASK1_Txt.Enabled = false;
                GW_Txt.Enabled = false;
                CBOX_DHCP.Checked = true;
            }
            else
            {
                CBOX_DHCP.Checked = false;
                IP1_Txt.Enabled = true;
                MASK1_Txt.Enabled = true;
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

            if (_bertPort1 != null && _bertPort1.IsOpen && _bertPort1.GetType() == typeof(BertPortSerial))
            {
                _parentForm.IpAddr1 = IP1_Txt.Text;
                _parentForm.IpMask1 = MASK1_Txt.Text;
                _parentForm.GwAddr = GW_Txt.Text;

                if (_parentForm.DHCPFlag)
                {
                    rslt = Commands.SetDHCP(_parentForm.GetBertPort1, 1);
                }
                else 
                {
                    rslt = Commands.SetDHCP(_parentForm.GetBertPort1, 0);
                    rslt = Commands.IPSet(_parentForm.GetBertPort1, _parentForm.IpAddr1, _parentForm.IpMask1, _parentForm.GwAddr);
                }
                Commands.Save(_parentForm.GetBertPort1);
                Commands.Reset(_parentForm.GetBertPort1);

                if (_parentForm.DHCPFlag)
                {
                    rslt = Commands.SetDHCP(_parentForm.GetBertPort2, 1);
                }
                else
                {
                    rslt = Commands.SetDHCP(_parentForm.GetBertPort2, 0);
                    rslt = Commands.IPSet(_parentForm.GetBertPort2, _parentForm.IpAddr2, _parentForm.IpMask2, _parentForm.GwAddr);
                }
                Commands.Save(_parentForm.GetBertPort2);
                Commands.Reset(_parentForm.GetBertPort2);

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

            if (_bertPort2 != null && _bertPort2.IsOpen && _bertPort2.GetType() == typeof(BertPortSerial))
            {
                _parentForm.IpAddr2 = IP2_Txt.Text;
                _parentForm.IpMask2 = MASK2_Txt.Text;
                _parentForm.GwAddr = GW_Txt.Text;

                if (_parentForm.DHCPFlag)
                {
                    rslt = Commands.SetDHCP(_parentForm.GetBertPort2, 1);
                }
                else
                {
                    rslt = Commands.SetDHCP(_parentForm.GetBertPort2, 0);
                    rslt = Commands.IPSet(_parentForm.GetBertPort2, _parentForm.IpAddr2, _parentForm.IpMask2, _parentForm.GwAddr);
                }

                Commands.Save(_parentForm.GetBertPort2);
                Commands.Reset(_parentForm.GetBertPort2);

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
            List<string> ipaddr1;
            List<string> ipaddr2;

            if (_bertPort1 != null && _bertPort1.IsOpen)
            {
                if (CBOX_DHCP.Checked)
                {
                    //rslt = Commands.SetDHCP(_parentForm.GetBertPort, 1);

                    IP1_Txt.Enabled = false;
                    MASK1_Txt.Enabled = false;
                    GW_Txt.Enabled = false;
                    _parentForm.DHCPFlag = true;
                }
                else
                {
                    ipaddr1 = Commands.IPGet(_parentForm.GetBertPort1);

                    IP1_Txt.Enabled = true;
                    IP1_Txt.Text = ipaddr1[0];
                    MASK1_Txt.Enabled = true;
                    MASK1_Txt.Text = ipaddr1[1];
                    GW_Txt.Enabled = true;
                    GW_Txt.Text = ipaddr1[2];
                    _parentForm.DHCPFlag = false;
                }
            }
            else
            {
                IP1_Txt.Enabled = false;
                MASK1_Txt.Enabled = false;
                GW_Txt.Enabled = false;
                CBOX_DHCP.Enabled = false;
            }

            if (_bertPort2 != null && _bertPort2.IsOpen)
            {
                if (CBOX_DHCP.Checked)
                {
                    //rslt = Commands.SetDHCP(_parentForm.GetBertPort, 1);

                    IP2_Txt.Enabled = false;
                    MASK2_Txt.Enabled = false;
                    GW_Txt.Enabled = false;
                    _parentForm.DHCPFlag = true;
                }
                else
                {
                    ipaddr2 = Commands.IPGet(_parentForm.GetBertPort2);

                    IP2_Txt.Enabled = true;
                    IP2_Txt.Text = ipaddr2[0];
                    MASK2_Txt.Enabled = true;
                    MASK2_Txt.Text = ipaddr2[1];
                    GW_Txt.Enabled = true;
                    GW_Txt.Text = ipaddr2[2];
                    _parentForm.DHCPFlag = false;
                }
            }
            else
            {
                IP2_Txt.Enabled = false;
                MASK2_Txt.Enabled = false;
                GW_Txt.Enabled = false;
                CBOX_DHCP.Enabled = false;
            }

        }
    }
}
