using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using System.Net.Sockets;
using System.IO.Ports;
using System.Xml.Linq;
using System.Runtime.ConstrainedExecution;
using System.Threading;
using System.ComponentModel.Design;
using System.IO;
using static System.Net.Mime.MediaTypeNames;



namespace BERT
{
    public partial class BERT_MainForm : Form
    {
        BertPortSerial bertPortSerial1 = new BertPortSerial("COM01");
        BertPortSerial bertPortSerial2 = new BertPortSerial("COM02");
        BertPortTcp bertPortTcp = new BertPortTcp("tcp");
        BertPortBase bertPort1;
        BertPortBase bertPort2;
        BertPortBase preBertPort1; // CH確認後使用
        BertPortBase preBertPort2; // CH確認後使用

        public bool TxCh1Flag = false;
        public bool TxCh2Flag = false;
        public bool TxCh3Flag = false;
        public bool TxCh4Flag = false;
        public bool MesCh1Flag = false;
        public bool MesCh2Flag = false;
        public bool MesCh3Flag = false;
        public bool MesCh4Flag = false;
        public bool DHCPFlag = false;

        public const string fileFolder = "ProgramPattern";

        public int testcnt = 0;

        public string GUIVerInf = "";

        private string ipaddr = "";
        private string ipmask = "";
        private string gwaddr = "";

        private bool isUiLoadOfConnecting = false;
        private bool isUiLoadOfConnectingDone = false;

        private double dcnt1_Ch1 = 0;
        private double dcnt2_Ch1 = 0;
        private double dcnt3_Ch1 = 0;
        private double dover_Ch1 = 4294967295;
        private double dovercnt_Ch1 = 0;
        private double dcnt1_Ch2 = 0;
        private double dcnt2_Ch2 = 0;
        private double dcnt3_Ch2 = 0;
        private double dover_Ch2 = 4294967295;
        private double dovercnt_Ch2 = 0;
        private double dcnt1_Ch3 = 0;
        private double dcnt2_Ch3 = 0;
        private double dcnt3_Ch3 = 0;
        private double dover_Ch3 = 4294967295;
        private double dovercnt_Ch3 = 0;
        private double dcnt1_Ch4 = 0;
        private double dcnt2_Ch4 = 0;
        private double dcnt3_Ch4 = 0;
        private double dover_Ch4 = 4294967295;
        private double dovercnt_Ch4 = 0;

        private double ecnt1_Ch1 = 0;
        private double ecnt2_Ch1 = 0;
        private double ecnt3_Ch1 = 0;
        private double eover_Ch1 = 4294967295;
        private double eovercnt_Ch1 = 0;
        private double ecnt1_Ch2 = 0;
        private double ecnt2_Ch2 = 0;
        private double ecnt3_Ch2 = 0;
        private double eover_Ch2 = 4294967295;
        private double eovercnt_Ch2 = 0;
        private double ecnt1_Ch3 = 0;
        private double ecnt2_Ch3 = 0;
        private double ecnt3_Ch3 = 0;
        private double eover_Ch3 = 4294967295;
        private double eovercnt_Ch3 = 0;
        private double ecnt1_Ch4 = 0;
        private double ecnt2_Ch4 = 0;
        private double ecnt3_Ch4 = 0;
        private double eover_Ch4 = 4294967295;
        private double eovercnt_Ch4 = 0;

        public string IpAddr
        {
            set
            {
                ipaddr = value;
                IP_Txt.Text = ipaddr;
            }
            get
            {
                return ipaddr;
            }
        }

        public string IpMask
        {
            set
            {
                ipmask = value;
            }
            get
            {
                return ipmask;
            }
        }

        public string GwAddr
        {
            set
            {
                gwaddr = value;
            }
            get
            {
                return gwaddr;
            }
        }

        public BertPortBase GetBertPort1
        {
            get
            { 
                return bertPort1;
            }
        }

        public BertPortBase GetBertPort2
        {
            get
            {
                return bertPort2;
            }
        }

        public BERT_MainForm()
        {
            InitializeComponent();
            BERT_MainForm_Load();
        }

        private void BERT_MainForm_Load()
        {
            var assembly = Assembly.GetExecutingAssembly();
            var assemblyName = Assembly.GetExecutingAssembly().GetName(); 
            var fileVersionInfo = FileVersionInfo.GetVersionInfo(assembly.Location);


            string[] ports = SerialPort.GetPortNames();
            foreach (string port in ports)
            {
                CBOX_COM1.Items.Add(port);
            }
            foreach (string port in ports)
            {
                CBOX_COM2.Items.Add(port);
            }
            if (CBOX_COM1.Items.Count > 0)
            {
                CBOX_COM1.SelectedIndex = 0;
            }
            if (CBOX_COM2.Items.Count > 1)
            {
                CBOX_COM2.SelectedIndex = 1;
            }

            GUIVerInf = fileVersionInfo.FileVersion;

        }


        private void BitrateGUISet(string rslt)
        {
            switch(rslt)
            {
                case "1250m":
                    CBOX_BR.SelectedIndex = 0;
                    break;
                case "622m":
                    CBOX_BR.SelectedIndex = 1;
                    break;
                case "150m":
                    CBOX_BR.SelectedIndex = 2;
                    break;
                case "100m":
                    CBOX_BR.SelectedIndex = 3;
                    break;
                case "50m":
                    CBOX_BR.SelectedIndex = 4;
                    break;
                case "35.02m":
                    CBOX_BR.SelectedIndex = 5;
                    break;
                case "20m":
                    CBOX_BR.SelectedIndex = 6;
                    break;
                case "10m":
                    CBOX_BR.SelectedIndex = 7;
                    break;
                case "5m":
                    CBOX_BR.SelectedIndex = 8;
                    break;
                case "1.5m":
                    CBOX_BR.SelectedIndex =9;
                    break;
                default:
                    break;
            }
        }

        private void TriggerGUISet(string rslt)
        {
            switch (rslt)
            {
                case "1/8":
                    CMB_Trg.SelectedIndex = 0;
                    break;
                case "1/1":
                    CMB_Trg.SelectedIndex = 1;
                    break;
                default:
                    break;
            }
        }

        private void PPGGUISet(int ch, string rslt)
        {
            if (ch == 1)
            {
                switch (rslt)
                {
                    case "0":
                        BTN_TX_OUT_CH1.Text = "OFF";
                        BTN_TX_OUT_CH1.BackColor = Color.Red;
                        PBOX_Tx_STS_1.Image = BERT.Properties.Resources.led_red;
                        break;
                    case "1":
                        BTN_TX_OUT_CH1.Text = "ON";
                        BTN_TX_OUT_CH1.BackColor = Color.Lime;
                        PBOX_Tx_STS_1.Image = BERT.Properties.Resources.led_green;
                        break;
                    default:
                        break;
                }
            }
            else if (ch == 2)
            {
                switch (rslt)
                {
                    case "0":
                        BTN_TX_OUT_CH2.Text = "OFF";
                        BTN_TX_OUT_CH2.BackColor = Color.Red;
                        PBOX_Tx_STS_2.Image = BERT.Properties.Resources.led_red;
                        break;
                    case "1":
                        BTN_TX_OUT_CH2.Text = "ON";
                        BTN_TX_OUT_CH2.BackColor = Color.Lime;
                        PBOX_Tx_STS_2.Image = BERT.Properties.Resources.led_green;
                        break;
                    default:
                        break;
                }
            }
            else if (ch == 3)
            {
                switch (rslt)
                {
                    case "0":
                        BTN_TX_OUT_CH3.Text = "OFF";
                        BTN_TX_OUT_CH3.BackColor = Color.Red;
                        PBOX_Tx_STS_3.Image = BERT.Properties.Resources.led_red;
                        break;
                    case "1":
                        BTN_TX_OUT_CH3.Text = "ON";
                        BTN_TX_OUT_CH3.BackColor = Color.Lime;
                        PBOX_Tx_STS_3.Image = BERT.Properties.Resources.led_green;
                        break;
                    default:
                        break;
                }
            }
            else if (ch == 4)
            {
                switch (rslt)
                {
                    case "0":
                        BTN_TX_OUT_CH4.Text = "OFF";
                        BTN_TX_OUT_CH4.BackColor = Color.Red;
                        PBOX_Tx_STS_4.Image = BERT.Properties.Resources.led_red;
                        break;
                    case "1":
                        BTN_TX_OUT_CH4.Text = "ON";
                        BTN_TX_OUT_CH4.BackColor = Color.Lime;
                        PBOX_Tx_STS_3.Image = BERT.Properties.Resources.led_green;
                        break;
                    default:
                        break;
                }
            }
        }

        private void EdGUISet(int ch, string rslt)
        {
            if (ch == 1)
            {
                switch (rslt)
                {
                    case "0":
                        BTN_MES_CH1.Text = "START";
                        MesCh1Flag = false;
                        break;
                    case "1":
                        BTN_MES_CH1.Text = "STOP";
                        MesCh1Flag = true; 
                        break;
                    default:
                        break;
                }
            }
            else if (ch == 2)
            {
                switch (rslt)
                {
                    case "0":
                        BTN_MES_CH2.Text = "START";
                        MesCh2Flag = false;
                        break;
                    case "1":
                        BTN_MES_CH2.Text = "STOP";
                        MesCh2Flag = true;
                        break;
                    default:
                        break;
                }
            }
            else if (ch == 3)
            {
                switch (rslt)
                {
                    case "0":
                        BTN_MES_CH3.Text = "START";
                        MesCh3Flag = false;
                        break;
                    case "1":
                        BTN_MES_CH3.Text = "STOP";
                        MesCh3Flag = true;
                        break;
                    default:
                        break;
                }
            }
            else if (ch == 4)
            {
                switch (rslt)
                {
                    case "0":
                        BTN_MES_CH4.Text = "START";
                        MesCh4Flag = false;
                        break;
                    case "1":
                        BTN_MES_CH4.Text = "STOP";
                        MesCh4Flag = true;
                        break;
                    default:
                        break;
                }
            }
        }

        private void ReSyncModeSet(int ch, string rslt)
        {
            if (ch == 1)
            {
                switch (rslt)
                {
                    case "auto":
                        CBOX_ReSync_Mode_CH1.SelectedIndex = 0;
                        break;
                    case "manual":
                        CBOX_ReSync_Mode_CH1.SelectedIndex = 1;
                        break;
                    default:
                        break;
                }
            }
            else if (ch == 2)
            {
                switch (rslt)
                {
                    case "auto":
                        CBOX_ReSync_Mode_CH2.SelectedIndex = 0;
                        break;
                    case "manual":
                        CBOX_ReSync_Mode_CH2.SelectedIndex = 1;
                        break;
                    default:
                        break;
                }
            }
            else if (ch == 3)
            {
                switch (rslt)
                {
                    case "auto":
                        CBOX_ReSync_Mode_CH3.SelectedIndex = 0;
                        break;
                    case "manual":
                        CBOX_ReSync_Mode_CH3.SelectedIndex = 1;
                        break;
                    default:
                        break;
                }
            }
            else if (ch == 4)
            {
                switch (rslt)
                {
                    case "auto":
                        CBOX_ReSync_Mode_CH4.SelectedIndex = 0;
                        break;
                    case "manual":
                        CBOX_ReSync_Mode_CH4.SelectedIndex = 1;
                        break;
                    default:
                        break;
                }
            }
        }

        private void EdPatSet(int ch, string rslt)
        {
            if (ch == 1)
            {
                switch (rslt)
                {
                    case "pn7":
                        CMB_PN_CH1.SelectedIndex = 0;
                        break;
                    case "pn15":
                        CMB_PN_CH1.SelectedIndex = 1;
                        break;
                    case "pn23":
                        CMB_PN_CH1.SelectedIndex = 2;
                        break;
                    case "pn31":
                        CMB_PN_CH1.SelectedIndex = 3;
                        break;
                    default:
                        break;
                }
            }
            else if (ch == 2)
            {
                switch (rslt)
                {
                    case "pn7":
                        CMB_PN_CH2.SelectedIndex = 0;
                        break;
                    case "pn15":
                        CMB_PN_CH2.SelectedIndex = 1;
                        break;
                    case "pn23":
                        CMB_PN_CH2.SelectedIndex = 2;
                        break;
                    case "pn31":
                        CMB_PN_CH2.SelectedIndex = 3;
                        break;
                    default:
                        break;
                }
            }
            else if (ch == 3)
            {
                switch (rslt)
                {
                    case "pn7":
                        CMB_PN_CH3.SelectedIndex = 0;
                        break;
                    case "pn15":
                        CMB_PN_CH3.SelectedIndex = 1;
                        break;
                    case "pn23":
                        CMB_PN_CH3.SelectedIndex = 2;
                        break;
                    case "pn31":
                        CMB_PN_CH3.SelectedIndex = 3;
                        break;
                    default:
                        break;
                }
            }
            else if (ch == 4)
            {
                switch (rslt)
                {
                    case "pn7":
                        CMB_PN_CH4.SelectedIndex = 0;
                        break;
                    case "pn15":
                        CMB_PN_CH4.SelectedIndex = 1;
                        break;
                    case "pn23":
                        CMB_PN_CH4.SelectedIndex = 2;
                        break;
                    case "pn31":
                        CMB_PN_CH4.SelectedIndex = 3;
                        break;
                    default:
                        break;
                }
            }
        }

        private async void COM_Connect_BTN_Click(object sender, EventArgs e)
        {
            try
            {
                this.preBertPort1 = this.bertPortSerial1;
                bool connecting = this.BTN_COM_Connect.Text == "CONNECT";
                if (connecting)
                {
                    this.preBertPort1.BertPortNameSet(this.CBOX_COM1.Text);
                }

                this.preBertPort2 = this.bertPortSerial2;
                connecting = this.BTN_COM_Connect.Text == "CONNECT";
                if (connecting)
                {
                    this.preBertPort2.BertPortNameSet(this.CBOX_COM2.Text);
                }

                var p = new object[]{ connecting, false };

                await Task.Run(() =>
                {
                    this.Invoke(new Action(async () => await this.workerConnect(connecting, false)));
                });

            }
            catch (Exception ex)
            {
                string title = this.BTN_COM_Connect.Text == "CONNECT" ? "Connect start error" : "Disconnect start error";
                MessageBox.Show(ex.Message, title, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private async void BTN_ETHER_Connect_Click(object sender, EventArgs e)
        {
            try
            {
                this.bertPort1 = this.bertPortTcp;
                bool connecting = this.BTN_ETHER_Connect.Text == "CONNECT";
                if (connecting)
                {
                    this.bertPort1.BertPortNameSet(this.IP_Txt.Text);
                }

                var p = new object[2]{ connecting, true };
                //this.bgWorkerConnect.RunWorkerAsync(p);

                await Task.Run(() =>
                {
                    this.Invoke(new Action(async () => await this.workerConnect(connecting, true)));
                });

            }
            catch (Exception ex)
            {
                string title = this.BTN_ETHER_Connect.Text == "CONNECT" ? "Connect start error" : "Disconnect start error";
                MessageBox.Show(ex.Message, title, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

            private void CBOX_COM_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.CBOX_COM1.Text = CBOX_COM1.SelectedText;
        }


        private void バージョン情報VToolStripMenuItem_Click(object sender, EventArgs e)
        {
            VersionForm versionInfo = new VersionForm(bertPort1, GUIVerInf);

            versionInfo.ShowDialog();

        }

        private void ComPortToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ToolStripMenuItem item = (ToolStripMenuItem)sender;

            if (item.Checked == true)
                return;
            //チェック状態を反転させる
            item.Checked = !item.Checked;

            //通信パネル表示をCOMポートに切り替える
            COM_Panel.Visible = true;
            Ether_Panel.Visible = false;



        }

        private void CBOX_BR_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (this.isUiLoadOfConnecting)
            {
                return;
            }

            string br = "";
            string rslt = "";

            if (bertPort1.IsOpen)
            {
                br = CBOX_BR.Text + "m";
                rslt = Commands.SetBitrate(bertPort1, br);
            }
            else
            {
                DialogResult dr = MessageBox.Show("デバイスが接続されていません", "Error",
                                        MessageBoxButtons.OK,
                                            (MessageBoxIcon)Enum.Parse(typeof(MessageBoxIcon), "Error"));
                return;
            }
            if (bertPort2.IsOpen)
            {
                br = CBOX_BR.Text + "m";
                rslt = Commands.SetBitrate(bertPort2, br);
                return;
            }
            else
            {
                DialogResult dr = MessageBox.Show("デバイスが接続されていません", "Error",
                                        MessageBoxButtons.OK,
                                            (MessageBoxIcon)Enum.Parse(typeof(MessageBoxIcon), "Error"));
                return;
            }
        }

        private void CMB_Trg_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (this.isUiLoadOfConnecting)
            {
                return;
            }

            string trg = "";
            string rslt = "";

            if (bertPort1.IsOpen)
            {
                trg = CMB_Trg.Text;
                rslt = Commands.SetTrigger(bertPort1, trg);
            }
            else
            {
                DialogResult dr = MessageBox.Show("デバイスが接続されていません", "Error",
                                        MessageBoxButtons.OK,
                                            (MessageBoxIcon)Enum.Parse(typeof(MessageBoxIcon), "Error"));
                return;
            }
            if (bertPort2.IsOpen)
            {
                trg = CMB_Trg.Text;
                rslt = Commands.SetTrigger(bertPort2, trg);
                return;
            }
            else
            {
                DialogResult dr = MessageBox.Show("デバイスが接続されていません", "Error",
                                        MessageBoxButtons.OK,
                                            (MessageBoxIcon)Enum.Parse(typeof(MessageBoxIcon), "Error"));
                return;
            }
        }

        private void BTN_TX_OUT_CH1_Click(object sender, EventArgs e)
        {
            string rslt = "";

            if (bertPort1.IsOpen)
            {
                if (TxCh1Flag)
                {
                    rslt = Commands.SetPPG(bertPort1, 1, 0);
                    if (rslt == "OK") {
                        BTN_TX_OUT_CH1.Text = "OFF";
                        BTN_TX_OUT_CH1.BackColor = Color.Red;
                        TxCh1Flag = false;
                        PBOX_Tx_STS_1.Image = BERT.Properties.Resources.led_red;
                        return;
                    }
                }
                else
                {
                    rslt = Commands.SetPPG(bertPort1, 1, 1);
                    if (rslt == "OK")
                    {
                        BTN_TX_OUT_CH1.Text = "ON";
                        BTN_TX_OUT_CH1.BackColor = Color.Lime;
                        TxCh1Flag = true;
                        PBOX_Tx_STS_1.Image = BERT.Properties.Resources.led_green;
                        return;
                    }
                }
            }
            else
            {
                DialogResult dr = MessageBox.Show("デバイスが接続されていません", "Error",
                                        MessageBoxButtons.OK,
                                            (MessageBoxIcon)Enum.Parse(typeof(MessageBoxIcon), "Error"));
                return;
            }
        }

        private void BTN_TX_OUT_CH2_Click(object sender, EventArgs e)
        {
            string rslt = "";

            if (bertPort1.IsOpen)
            {
                if (TxCh2Flag)
                {
                    rslt = Commands.SetPPG(bertPort1, 2, 0);
                    if (rslt == "OK")
                    {
                        BTN_TX_OUT_CH2.Text = "OFF";
                        BTN_TX_OUT_CH2.BackColor = Color.Red;
                        TxCh2Flag = false;
                        PBOX_Tx_STS_2.Image = BERT.Properties.Resources.led_red;
                        return;
                    }
                }
                else
                {
                    rslt = Commands.SetPPG(bertPort1, 2, 1);
                    if (rslt == "OK")
                    {
                        BTN_TX_OUT_CH2.Text = "ON";
                        BTN_TX_OUT_CH2.BackColor = Color.Lime;
                        TxCh2Flag = true;
                        PBOX_Tx_STS_2.Image = BERT.Properties.Resources.led_green;
                        return;
                    }
                }
            }
            else
            {
                DialogResult dr = MessageBox.Show("デバイスが接続されていません", "Error",
                                        MessageBoxButtons.OK,
                                            (MessageBoxIcon)Enum.Parse(typeof(MessageBoxIcon), "Error"));
                return;
            }
        }

        private void BTN_TX_OUT_CH3_Click(object sender, EventArgs e)
        {
            string rslt = "";

            if (bertPort2.IsOpen)
            {
                if (TxCh3Flag)
                {
                    rslt = Commands.SetPPG(bertPort2, 1, 0);
                    if (rslt == "OK")
                    {
                        BTN_TX_OUT_CH3.Text = "OFF";
                        BTN_TX_OUT_CH3.BackColor = Color.Red;
                        TxCh3Flag = false;
                        PBOX_Tx_STS_3.Image = BERT.Properties.Resources.led_red;
                        return;
                    }
                }
                else
                {
                    rslt = Commands.SetPPG(bertPort2, 1, 1);
                    if (rslt == "OK")
                    {
                        BTN_TX_OUT_CH3.Text = "ON";
                        BTN_TX_OUT_CH3.BackColor = Color.Lime;
                        TxCh3Flag = true;
                        PBOX_Tx_STS_3.Image = BERT.Properties.Resources.led_green;
                        return;
                    }
                }
            }
            else
            {
                DialogResult dr = MessageBox.Show("デバイスが接続されていません", "Error",
                                        MessageBoxButtons.OK,
                                            (MessageBoxIcon)Enum.Parse(typeof(MessageBoxIcon), "Error"));
                return;
            }
        }

        private void BTN_TX_OUT_CH4_Click(object sender, EventArgs e)
        {
            string rslt = "";

            if (bertPort2.IsOpen)
            {
                if (TxCh4Flag)
                {
                    rslt = Commands.SetPPG(bertPort2, 2, 0);
                    if (rslt == "OK")
                    {
                        BTN_TX_OUT_CH4.Text = "OFF";
                        BTN_TX_OUT_CH4.BackColor = Color.Red;
                        TxCh4Flag = false;
                        PBOX_Tx_STS_4.Image = BERT.Properties.Resources.led_red;
                        return;
                    }
                }
                else
                {
                    rslt = Commands.SetPPG(bertPort2, 2, 1);
                    if (rslt == "OK")
                    {
                        BTN_TX_OUT_CH4.Text = "ON";
                        BTN_TX_OUT_CH4.BackColor = Color.Lime;
                        TxCh4Flag = true;
                        PBOX_Tx_STS_4.Image = BERT.Properties.Resources.led_green;
                        return;
                    }
                }
            }
            else
            {
                DialogResult dr = MessageBox.Show("デバイスが接続されていません", "Error",
                                        MessageBoxButtons.OK,
                                            (MessageBoxIcon)Enum.Parse(typeof(MessageBoxIcon), "Error"));
                return;
            }
        }

        private void BTN_MES_CH1_Click(object sender, EventArgs e)
        {
            string ret;

            if (bertPort1.IsOpen)
            {

                if (MesCh1Flag)
                {
                    ret = Commands.SetEd(bertPort1, 1, 0);
                    if (ret == "OK")
                    {
                        BTN_MES_CH1.Text = "START";
                        MesCh1Flag = false;
                    }
                }
                else
                {
                    ret = Commands.SetEd(bertPort1, 1, 1);
                    if (ret == "OK")
                    {
                        BTN_MES_CH1.Text = "STOP";
                        MesCh1Flag = true;
                    }
                }
            }
            else
            {
                DialogResult dr = MessageBox.Show("デバイスが接続されていません", "Error",
                                        MessageBoxButtons.OK,
                                            (MessageBoxIcon)Enum.Parse(typeof(MessageBoxIcon), "Error"));
                return;
            }

        }

        private void BTN_MES_CH2_Click(object sender, EventArgs e)
        {
            string ret;

            if (bertPort1.IsOpen)
            {
                if (MesCh2Flag)
                {
                    ret = Commands.SetEd(bertPort1, 2, 0);
                    if (ret == "OK")
                    {
                        BTN_MES_CH2.Text = "START";
                        MesCh2Flag = false;
                    }
                }
                else
                {
                    ret = Commands.SetEd(bertPort1, 2, 1);
                    if (ret == "OK")
                    {
                        BTN_MES_CH2.Text = "STOP";
                        MesCh2Flag = true;
                    }
                }
            }
            else
            {
                DialogResult dr = MessageBox.Show("デバイスが接続されていません", "Error",
                                        MessageBoxButtons.OK,
                                            (MessageBoxIcon)Enum.Parse(typeof(MessageBoxIcon), "Error"));
                return;
            }

        }

        private void BTN_MES_CH3_Click(object sender, EventArgs e)
        {
            string ret;

            if (bertPort2.IsOpen)
            {

                if (MesCh3Flag)
                {
                    ret = Commands.SetEd(bertPort2, 1, 0);
                    if (ret == "OK")
                    {
                        BTN_MES_CH3.Text = "START";
                        MesCh3Flag = false;
                    }
                }
                else
                {
                    ret = Commands.SetEd(bertPort2, 1, 1);
                    if (ret == "OK")
                    {
                        BTN_MES_CH3.Text = "STOP";
                        MesCh3Flag = true;
                    }
                }
            }
            else
            {
                DialogResult dr = MessageBox.Show("デバイスが接続されていません", "Error",
                                        MessageBoxButtons.OK,
                                            (MessageBoxIcon)Enum.Parse(typeof(MessageBoxIcon), "Error"));
                return;
            }

        }

        private void BTN_MES_CH4_Click(object sender, EventArgs e)
        {
            string ret;

            if (bertPort2.IsOpen)
            {

                if (MesCh4Flag)
                {
                    ret = Commands.SetEd(bertPort2, 2, 0);
                    if (ret == "OK")
                    {
                        BTN_MES_CH4.Text = "START";
                        MesCh4Flag = false;
                    }
                }
                else
                {
                    ret = Commands.SetEd(bertPort2, 2, 1);
                    if (ret == "OK")
                    {
                        BTN_MES_CH4.Text = "STOP";
                        MesCh4Flag = true;
                    }
                }
            }
            else
            {
                DialogResult dr = MessageBox.Show("デバイスが接続されていません", "Error",
                                        MessageBoxButtons.OK,
                                            (MessageBoxIcon)Enum.Parse(typeof(MessageBoxIcon), "Error"));
                return;
            }

        }

        private void CBOX_ReSync_Mode_CH1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (this.isUiLoadOfConnecting)
            {
                return;
            }

            string rslt = "";

            if (bertPort1.IsOpen)
            {
                if (CBOX_ReSync_Mode_CH1.SelectedIndex == 0)
                {
                    rslt = Commands.SetReSyncMode(bertPort1, 1, "auto");
                }
                else if (CBOX_ReSync_Mode_CH1.SelectedIndex == 1)
                {
                    rslt = Commands.SetReSyncMode(bertPort1, 1, "manual");
                }
            }
            else
            {
                DialogResult dr = MessageBox.Show("デバイスが接続されていません", "Error",
                                        MessageBoxButtons.OK,
                                            (MessageBoxIcon)Enum.Parse(typeof(MessageBoxIcon), "Error"));
                return;
            }
        }

        private void CBOX_ReSync_Mode_CH2_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (this.isUiLoadOfConnecting)
            {
                return;
            }

            string rslt = "";

            if (bertPort1.IsOpen)
            {
                if (CBOX_ReSync_Mode_CH2.SelectedIndex == 0)
                {
                    rslt = Commands.SetReSyncMode(bertPort1, 2, "auto");
                }
                else if (CBOX_ReSync_Mode_CH2.SelectedIndex == 1)
                {
                    rslt = Commands.SetReSyncMode(bertPort1, 2, "manual");
                }
            }
            else
            {
                DialogResult dr = MessageBox.Show("デバイスが接続されていません", "Error",
                                        MessageBoxButtons.OK,
                                            (MessageBoxIcon)Enum.Parse(typeof(MessageBoxIcon), "Error"));
                return;
            }
        }

        private void CBOX_ReSync_Mode_CH3_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (this.isUiLoadOfConnecting)
            {
                return;
            }

            string rslt = "";

            if (bertPort2.IsOpen)
            {
                if (CBOX_ReSync_Mode_CH3.SelectedIndex == 0)
                {
                    rslt = Commands.SetReSyncMode(bertPort2, 1, "auto");
                }
                else if (CBOX_ReSync_Mode_CH3.SelectedIndex == 1)
                {
                    rslt = Commands.SetReSyncMode(bertPort2, 1, "manual");
                }
            }
            else
            {
                DialogResult dr = MessageBox.Show("デバイスが接続されていません", "Error",
                                        MessageBoxButtons.OK,
                                            (MessageBoxIcon)Enum.Parse(typeof(MessageBoxIcon), "Error"));
                return;
            }
        }

        private void CBOX_ReSync_Mode_CH4_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (this.isUiLoadOfConnecting)
            {
                return;
            }

            string rslt = "";

            if (bertPort2.IsOpen)
            {
                if (CBOX_ReSync_Mode_CH4.SelectedIndex == 0)
                {
                    rslt = Commands.SetReSyncMode(bertPort2, 2, "auto");
                }
                else if (CBOX_ReSync_Mode_CH4.SelectedIndex == 1)
                {
                    rslt = Commands.SetReSyncMode(bertPort2, 2, "manual");
                }
            }
            else
            {
                DialogResult dr = MessageBox.Show("デバイスが接続されていません", "Error",
                                        MessageBoxButtons.OK,
                                            (MessageBoxIcon)Enum.Parse(typeof(MessageBoxIcon), "Error"));
                return;
            }
        }

        private void BTN_Sync_CH1_Click(object sender, EventArgs e)
        {
            string rslt = "";

            if (bertPort1.IsOpen)
            {
                dovercnt_Ch1 = 0;
                eovercnt_Ch1 = 0;
                rslt = Commands.ReSync(bertPort1, 1);
            }
            else
            {
                DialogResult dr = MessageBox.Show("デバイスが接続されていません", "Error",
                                        MessageBoxButtons.OK,
                                            (MessageBoxIcon)Enum.Parse(typeof(MessageBoxIcon), "Error"));
                return;
            }
        }

        private void BTN_Sync_CH2_Click(object sender, EventArgs e)
        {
            string rslt = "";

            if (bertPort1.IsOpen)
            {
                dovercnt_Ch2 = 0;
                eovercnt_Ch2 = 0;
                rslt = Commands.ReSync(bertPort1, 2);
            }
            else
            {
                DialogResult dr = MessageBox.Show("デバイスが接続されていません", "Error",
                                        MessageBoxButtons.OK,
                                            (MessageBoxIcon)Enum.Parse(typeof(MessageBoxIcon), "Error"));
                return;
            }
        }

        private void BTN_Sync_CH3_Click(object sender, EventArgs e)
        {
            string rslt = "";

            if (bertPort2.IsOpen)
            {
                dovercnt_Ch3 = 0;
                eovercnt_Ch3 = 0;
                rslt = Commands.ReSync(bertPort2, 1);
            }
            else
            {
                DialogResult dr = MessageBox.Show("デバイスが接続されていません", "Error",
                                        MessageBoxButtons.OK,
                                            (MessageBoxIcon)Enum.Parse(typeof(MessageBoxIcon), "Error"));
                return;
            }
        }

        private void BTN_Sync_CH4_Click(object sender, EventArgs e)
        {
            string rslt = "";

            if (bertPort2.IsOpen)
            {
                dovercnt_Ch4 = 0;
                eovercnt_Ch4 = 0;
                rslt = Commands.ReSync(bertPort2, 2);
            }
            else
            {
                DialogResult dr = MessageBox.Show("デバイスが接続されていません", "Error",
                                        MessageBoxButtons.OK,
                                            (MessageBoxIcon)Enum.Parse(typeof(MessageBoxIcon), "Error"));
                return;
            }
        }

        private void BTN_Flg_Rst_CH1_Click(object sender, EventArgs e)
        {
            string rslt = "";

            if (bertPort1.IsOpen)
            {
                rslt = Commands.ResetFlag(bertPort1, 1);

                PBOX_LOS_CH1.Image = BERT.Properties.Resources.led_off;
                PBOX_ERR_CH1.Image = BERT.Properties.Resources.led_off;
                PBOX_ERR_FLG_CH1.Image = BERT.Properties.Resources.led_off;
                PBOX_Tx_STS_1.Image = BERT.Properties.Resources.led_off;

            }
            else
            {
                DialogResult dr = MessageBox.Show("デバイスが接続されていません", "Error",
                                        MessageBoxButtons.OK,
                                            (MessageBoxIcon)Enum.Parse(typeof(MessageBoxIcon), "Error"));
                return;
            }
        }

        private void BTN_Flg_Rst_CH2_Click(object sender, EventArgs e)
        {
            string rslt = "";

            if (bertPort1.IsOpen)
            {
                rslt = Commands.ResetFlag(bertPort1, 2);
                PBOX_LOS_CH2.Image = BERT.Properties.Resources.led_off;
                PBOX_ERR_CH2.Image = BERT.Properties.Resources.led_off;
                PBOX_ERR_FLG_CH2.Image = BERT.Properties.Resources.led_off;
                PBOX_Tx_STS_2.Image = BERT.Properties.Resources.led_off;
            }
            else
            {
                DialogResult dr = MessageBox.Show("デバイスが接続されていません", "Error",
                                        MessageBoxButtons.OK,
                                            (MessageBoxIcon)Enum.Parse(typeof(MessageBoxIcon), "Error"));
                return;
            }
        }

        private void BTN_Flg_Rst_CH3_Click(object sender, EventArgs e)
        {
            string rslt = "";

            if (bertPort2.IsOpen)
            {
                rslt = Commands.ResetFlag(bertPort2, 1);

                PBOX_LOS_CH3.Image = BERT.Properties.Resources.led_off;
                PBOX_ERR_CH3.Image = BERT.Properties.Resources.led_off;
                PBOX_ERR_FLG_CH3.Image = BERT.Properties.Resources.led_off;
                PBOX_Tx_STS_3.Image = BERT.Properties.Resources.led_off;

            }
            else
            {
                DialogResult dr = MessageBox.Show("デバイスが接続されていません", "Error",
                                        MessageBoxButtons.OK,
                                            (MessageBoxIcon)Enum.Parse(typeof(MessageBoxIcon), "Error"));
                return;
            }
        }

        private void BTN_Flg_Rst_CH4_Click(object sender, EventArgs e)
        {
            string rslt = "";

            if (bertPort2.IsOpen)
            {
                rslt = Commands.ResetFlag(bertPort2, 2);
                PBOX_LOS_CH4.Image = BERT.Properties.Resources.led_off;
                PBOX_ERR_CH4.Image = BERT.Properties.Resources.led_off;
                PBOX_ERR_FLG_CH4.Image = BERT.Properties.Resources.led_off;
                PBOX_Tx_STS_4.Image = BERT.Properties.Resources.led_off;
            }
            else
            {
                DialogResult dr = MessageBox.Show("デバイスが接続されていません", "Error",
                                        MessageBoxButtons.OK,
                                            (MessageBoxIcon)Enum.Parse(typeof(MessageBoxIcon), "Error"));
                return;
            }
        }

        private void BTN_Cnt_Rst_CH1_Click(object sender, EventArgs e)
        {
            string rslt = "";

            if (bertPort1.IsOpen)
            {
                rslt = Commands.ResetCount(bertPort1, 1);
                ecnt1_Ch1 = 0;
                ecnt2_Ch1 = 0;
                ecnt3_Ch1 = 0;
                eover_Ch1 = 4294967295;
                eovercnt_Ch1 = 0;

                LAB_Mesure_Time_Result_CH1.Text = "0";

                dcnt1_Ch1 = 0;
                dcnt2_Ch1 = 0;
                dcnt3_Ch1 = 0;
                dovercnt_Ch1 = 0;


                LAB_Data_Cnt_Result_CH1.Text = "0.00E00";

                LAB_Err_Cnt_Result_CH1.Text = "0.00E00";

                LAB_BER_Result_CH1.Text = "0.00E-00";

                LAB_ES_Result_CH1.Text = "0.00%";
            }
            else
            {
                DialogResult dr = MessageBox.Show("デバイスが接続されていません", "Error",
                                        MessageBoxButtons.OK,
                                            (MessageBoxIcon)Enum.Parse(typeof(MessageBoxIcon), "Error"));
                return;
            }
        }

        private void BTN_Cnt_Rst_CH2_Click(object sender, EventArgs e)
        {
            string rslt = "";

            if (bertPort1.IsOpen)
            {
                rslt = Commands.ResetCount(bertPort1, 2);
                ecnt1_Ch2 = 0;
                ecnt2_Ch2 = 0;
                ecnt3_Ch2 = 0;
                eover_Ch2 = 4294967295;
                eovercnt_Ch2 = 0;

                LAB_Mesure_Time_Result_CH2.Text = "0";

                dcnt1_Ch2 = 0;
                dcnt2_Ch2 = 0;
                dcnt3_Ch2 = 0;
                dovercnt_Ch2 = 0;


                LAB_Data_Cnt_Result_CH2.Text = "0.00E00";

                LAB_Err_Cnt_Result_CH2.Text = "0.00E00";

                LAB_BER_Result_CH2.Text = "0.00E-00";

                LAB_ES_Result_CH2.Text = "0.00%";
            }
            else
            {
                DialogResult dr = MessageBox.Show("デバイスが接続されていません", "Error",
                                        MessageBoxButtons.OK,
                                            (MessageBoxIcon)Enum.Parse(typeof(MessageBoxIcon), "Error"));
                return;
            }
        }

        private void BTN_Cnt_Rst_CH3_Click(object sender, EventArgs e)
        {
            string rslt = "";

            if (bertPort2.IsOpen)
            {
                rslt = Commands.ResetCount(bertPort2, 1);
                ecnt1_Ch3 = 0;
                ecnt2_Ch3 = 0;
                ecnt3_Ch3 = 0;
                eover_Ch3 = 4294967295;
                eovercnt_Ch3 = 0;

                LAB_Mesure_Time_Result_CH1.Text = "0";

                dcnt1_Ch3 = 0;
                dcnt2_Ch3 = 0;
                dcnt3_Ch3 = 0;
                dovercnt_Ch3 = 0;


                LAB_Data_Cnt_Result_CH3.Text = "0.00E00";

                LAB_Err_Cnt_Result_CH3.Text = "0.00E00";

                LAB_BER_Result_CH3.Text = "0.00E-00";

                LAB_ES_Result_CH3.Text = "0.00%";
            }
            else
            {
                DialogResult dr = MessageBox.Show("デバイスが接続されていません", "Error",
                                        MessageBoxButtons.OK,
                                            (MessageBoxIcon)Enum.Parse(typeof(MessageBoxIcon), "Error"));
                return;
            }
        }

        private void BTN_Cnt_Rst_CH4_Click(object sender, EventArgs e)
        {
            string rslt = "";

            if (bertPort2.IsOpen)
            {
                rslt = Commands.ResetCount(bertPort2, 2);
                ecnt1_Ch4 = 0;
                ecnt2_Ch4 = 0;
                ecnt3_Ch4 = 0;
                eover_Ch4 = 4294967295;
                eovercnt_Ch4 = 0;

                LAB_Mesure_Time_Result_CH4.Text = "0";

                dcnt1_Ch4 = 0;
                dcnt2_Ch4 = 0;
                dcnt3_Ch4 = 0;
                dovercnt_Ch4 = 0;


                LAB_Data_Cnt_Result_CH4.Text = "0.00E00";

                LAB_Err_Cnt_Result_CH4.Text = "0.00E00";

                LAB_BER_Result_CH4.Text = "0.00E-00";

                LAB_ES_Result_CH4.Text = "0.00%";
            }
            else
            {
                DialogResult dr = MessageBox.Show("デバイスが接続されていません", "Error",
                                        MessageBoxButtons.OK,
                                            (MessageBoxIcon)Enum.Parse(typeof(MessageBoxIcon), "Error"));
                return;
            }
        }

        private void DspMesResultCh1(List<string> rslt)
        {
            double err = 0;
            double bit = 0;
            double es = 0;

            float dtime = 0;
            float etime = 0;
            float stime = 0;

            String wstr1 = "";

            if (rslt.Count <= 0)
            {
                return;
            }

            LAB_Mesure_Time_Result_CH1.Text = rslt[6];

            dcnt1_Ch1 = double.Parse(rslt[4]);

            if (dcnt1_Ch1 < dcnt2_Ch1)
            {
                dovercnt_Ch1 += 1;
            }
            dcnt3_Ch1 = dcnt1_Ch1 + dover_Ch1 * dovercnt_Ch1;
            dcnt2_Ch1 = dcnt1_Ch1;

            LAB_Data_Cnt_Result_CH1.Text = dcnt3_Ch1.ToString("0.00E00");

            ecnt1_Ch1 = double.Parse(rslt[5]);

            if (ecnt1_Ch1 < ecnt2_Ch1)
            {
                eovercnt_Ch1 += 1;
            }
            ecnt3_Ch1 = ecnt1_Ch1 + eover_Ch1 * eovercnt_Ch1;
            ecnt2_Ch1 = ecnt1_Ch1;

            LAB_Err_Cnt_Result_CH1.Text = ecnt3_Ch1.ToString("0.00E00");
        
            err = double.Parse(rslt[5]);
            bit = dcnt3_Ch1;
            es = (err / bit * 100);
            if (es == 0)
            {
                wstr1 = dcnt3_Ch1.ToString("0.00E00");
                wstr1 = wstr1.Substring(5);
                LAB_BER_Result_CH1.Text = "0.00E-" + wstr1;
            }
            else
            {
                LAB_BER_Result_CH1.Text = es.ToString("0.00E-00");
            }

            dtime = float.Parse(rslt[7]);
            etime = float.Parse(rslt[6]);
            stime = (dtime / etime * 100);
            LAB_ES_Result_CH1.Text = stime.ToString("F2") + "%";

            if (rslt[1] == "0")
            {
                PBOX_LOS_CH1.Image = PBOX_LOS_CH1.InitialImage;
            }
            else
            {
                PBOX_LOS_CH1.Image = PBOX_LOS_CH1.ErrorImage;
            }
            if (rslt[2] == "0")
            {
                PBOX_ERR_CH1.Image = PBOX_ERR_CH1.InitialImage;
            }
            else
            {
                PBOX_ERR_CH1.Image = PBOX_ERR_CH1.ErrorImage;
            }
            if (rslt[3] == "0")
            {
                PBOX_ERR_FLG_CH1.Image = PBOX_ERR_FLG_CH1.InitialImage;
            }
            else
            {
                PBOX_ERR_FLG_CH1.Image = PBOX_ERR_FLG_CH1.ErrorImage;
            }
        }
        private void DspMesResultCh2(List<string> rslt)
        {
            double err = 0;
            double bit = 0;
            double es = 0;

            float dtime = 0;
            float etime = 0;
            float stime = 0;

            String wstr1 = "";

            if (rslt.Count <= 0)
            {
                return;
            }

            LAB_Mesure_Time_Result_CH2.Text = rslt[6];

            dcnt1_Ch2 = double.Parse(rslt[4]);

            if (dcnt1_Ch2 < dcnt2_Ch2)
            {
                dovercnt_Ch2 += 1;
            }
            dcnt3_Ch2 = dcnt1_Ch2 + dover_Ch2 * dovercnt_Ch2;
            dcnt2_Ch2 = dcnt1_Ch2;

            LAB_Data_Cnt_Result_CH2.Text = dcnt3_Ch2.ToString("0.00E00");

            ecnt1_Ch2 = double.Parse(rslt[5]);

            if (ecnt1_Ch2 < ecnt2_Ch2)
            {
                eovercnt_Ch2 += 1;
            }
            ecnt3_Ch2 = ecnt1_Ch2 + eover_Ch2 * eovercnt_Ch2;
            ecnt2_Ch2 = ecnt1_Ch2;

            LAB_Err_Cnt_Result_CH2.Text = ecnt3_Ch2.ToString("0.00E00");

            err = double.Parse(rslt[5]);
            bit = dcnt3_Ch2;
            es = (err / bit * 100);
            if (es == 0)
            {
                wstr1 = dcnt3_Ch2.ToString("0.00E00");
                wstr1 = wstr1.Substring(5);
                LAB_BER_Result_CH2.Text = "0.00E-" + wstr1;
            }
            else
            {
                LAB_BER_Result_CH2.Text = es.ToString("0.00E-00");
            }

            dtime = float.Parse(rslt[7]);
            etime = float.Parse(rslt[6]);
            stime = (dtime / etime * 100);
            LAB_ES_Result_CH2.Text = stime.ToString("F2") + "%";

            if (rslt[1] == "0")
            {
                PBOX_LOS_CH2.Image = PBOX_LOS_CH2.InitialImage;
            }
            else
            {
                PBOX_LOS_CH2.Image = PBOX_LOS_CH2.ErrorImage;
            }
            if (rslt[2] == "0")
            {
                PBOX_ERR_CH2.Image = PBOX_ERR_CH2.InitialImage;
            }
            else
            {
                PBOX_ERR_CH2.Image = PBOX_ERR_CH2.ErrorImage;
            }
            if (rslt[3] == "0")
            {
                PBOX_ERR_FLG_CH2.Image = PBOX_ERR_FLG_CH2.InitialImage;
            }
            else
            {
                PBOX_ERR_FLG_CH2.Image = PBOX_ERR_FLG_CH2.ErrorImage;
            }
        }

        private void DspMesResultCh3(List<string> rslt)
        {
            double err = 0;
            double bit = 0;
            double es = 0;

            float dtime = 0;
            float etime = 0;
            float stime = 0;

            String wstr1 = "";

            if (rslt.Count <= 0)
            {
                return;
            }

            LAB_Mesure_Time_Result_CH3.Text = rslt[6];

            dcnt1_Ch3 = double.Parse(rslt[4]);

            if (dcnt1_Ch3 < dcnt2_Ch3)
            {
                dovercnt_Ch3 += 1;
            }
            dcnt3_Ch3 = dcnt1_Ch3 + dover_Ch3 * dovercnt_Ch3;
            dcnt2_Ch3 = dcnt1_Ch3;

            LAB_Data_Cnt_Result_CH3.Text = dcnt3_Ch3.ToString("0.00E00");

            ecnt1_Ch3 = double.Parse(rslt[5]);

            if (ecnt1_Ch3 < ecnt2_Ch3)
            {
                eovercnt_Ch3 += 1;
            }
            ecnt3_Ch3 = ecnt1_Ch3 + eover_Ch3 * eovercnt_Ch3;
            ecnt2_Ch3 = ecnt1_Ch3;

            LAB_Err_Cnt_Result_CH3.Text = ecnt3_Ch3.ToString("0.00E00");

            err = double.Parse(rslt[5]);
            bit = dcnt3_Ch3;
            es = (err / bit * 100);
            if (es == 0)
            {
                wstr1 = dcnt3_Ch3.ToString("0.00E00");
                wstr1 = wstr1.Substring(5);
                LAB_BER_Result_CH3.Text = "0.00E-" + wstr1;
            }
            else
            {
                LAB_BER_Result_CH3.Text = es.ToString("0.00E-00");
            }

            dtime = float.Parse(rslt[7]);
            etime = float.Parse(rslt[6]);
            stime = (dtime / etime * 100);
            LAB_ES_Result_CH3.Text = stime.ToString("F2") + "%";

            if (rslt[1] == "0")
            {
                PBOX_LOS_CH3.Image = PBOX_LOS_CH3.InitialImage;
            }
            else
            {
                PBOX_LOS_CH3.Image = PBOX_LOS_CH3.ErrorImage;
            }
            if (rslt[2] == "0")
            {
                PBOX_ERR_CH3.Image = PBOX_ERR_CH3.InitialImage;
            }
            else
            {
                PBOX_ERR_CH3.Image = PBOX_ERR_CH3.ErrorImage;
            }
            if (rslt[3] == "0")
            {
                PBOX_ERR_FLG_CH3.Image = PBOX_ERR_FLG_CH3.InitialImage;
            }
            else
            {
                PBOX_ERR_FLG_CH3.Image = PBOX_ERR_FLG_CH3.ErrorImage;
            }
        }

        private void DspMesResultCh4(List<string> rslt)
        {
            double err = 0;
            double bit = 0;
            double es = 0;

            float dtime = 0;
            float etime = 0;
            float stime = 0;

            String wstr1 = "";

            if (rslt.Count <= 0)
            {
                return;
            }

            LAB_Mesure_Time_Result_CH4.Text = rslt[6];

            dcnt1_Ch4 = double.Parse(rslt[4]);

            if (dcnt1_Ch4 < dcnt2_Ch4)
            {
                dovercnt_Ch4 += 1;
            }
            dcnt3_Ch4 = dcnt1_Ch4 + dover_Ch4 * dovercnt_Ch4;
            dcnt2_Ch4 = dcnt1_Ch4;

            LAB_Data_Cnt_Result_CH4.Text = dcnt3_Ch4.ToString("0.00E00");

            ecnt1_Ch4 = double.Parse(rslt[5]);

            if (ecnt1_Ch4 < ecnt2_Ch4)
            {
                eovercnt_Ch4 += 1;
            }
            ecnt3_Ch4 = ecnt1_Ch4 + eover_Ch4 * eovercnt_Ch4;
            ecnt2_Ch4 = ecnt1_Ch4;

            LAB_Err_Cnt_Result_CH4.Text = ecnt3_Ch4.ToString("0.00E00");

            err = double.Parse(rslt[5]);
            bit = dcnt3_Ch4;
            es = (err / bit * 100);
            if (es == 0)
            {
                wstr1 = dcnt3_Ch4.ToString("0.00E00");
                wstr1 = wstr1.Substring(5);
                LAB_BER_Result_CH4.Text = "0.00E-" + wstr1;
            }
            else
            {
                LAB_BER_Result_CH4.Text = es.ToString("0.00E-00");
            }

            dtime = float.Parse(rslt[7]);
            etime = float.Parse(rslt[6]);
            stime = (dtime / etime * 100);
            LAB_ES_Result_CH4.Text = stime.ToString("F2") + "%";

            if (rslt[1] == "0")
            {
                PBOX_LOS_CH4.Image = PBOX_LOS_CH4.InitialImage;
            }
            else
            {
                PBOX_LOS_CH4.Image = PBOX_LOS_CH4.ErrorImage;
            }
            if (rslt[2] == "0")
            {
                PBOX_ERR_CH4.Image = PBOX_ERR_CH4.InitialImage;
            }
            else
            {
                PBOX_ERR_CH4.Image = PBOX_ERR_CH4.ErrorImage;
            }
            if (rslt[3] == "0")
            {
                PBOX_ERR_FLG_CH4.Image = PBOX_ERR_FLG_CH4.InitialImage;
            }
            else
            {
                PBOX_ERR_FLG_CH4.Image = PBOX_ERR_FLG_CH4.ErrorImage;
            }
        }

        private void GetResult_Tick(object sender, EventArgs e)
        {
            List<string> rslt;

            if (bertPort1.IsOpen)
            {
                if (Commands.GetPPG(bertPort1, 1) == "1")
                {
                    BTN_TX_OUT_CH1.Text = "ON";
                    BTN_TX_OUT_CH1.BackColor = Color.Lime;
                    PBOX_Tx_STS_1.Image = BERT.Properties.Resources.led_green;
                    TxCh1Flag = true;
                }
                else
                {
                    BTN_TX_OUT_CH1.Text = "OFF";
                    BTN_TX_OUT_CH1.BackColor = Color.Red;
                    PBOX_Tx_STS_1.Image = BERT.Properties.Resources.led_red;
                    TxCh1Flag = false;
                }
                if (Commands.GetPPG(bertPort1, 2) == "1")
                {
                    BTN_TX_OUT_CH2.Text = "ON";
                    BTN_TX_OUT_CH2.BackColor = Color.Lime;
                    PBOX_Tx_STS_2.Image = BERT.Properties.Resources.led_green;
                    TxCh2Flag = true;
                }
                else
                {
                    BTN_TX_OUT_CH2.Text = "OFF";
                    BTN_TX_OUT_CH2.BackColor = Color.Red;
                    PBOX_Tx_STS_2.Image = BERT.Properties.Resources.led_red;
                    TxCh2Flag = false;
                }
            }

            if (bertPort2.IsOpen)
            {
                if (Commands.GetPPG(bertPort2, 1) == "1")
                {
                    BTN_TX_OUT_CH3.Text = "ON";
                    BTN_TX_OUT_CH3.BackColor = Color.Lime;
                    PBOX_Tx_STS_3.Image = BERT.Properties.Resources.led_green;
                    TxCh3Flag = true;
                }
                else
                {
                    BTN_TX_OUT_CH3.Text = "OFF";
                    BTN_TX_OUT_CH3.BackColor = Color.Red;
                    PBOX_Tx_STS_3.Image = BERT.Properties.Resources.led_red;
                    TxCh3Flag = false;
                }
                if (Commands.GetPPG(bertPort2, 2) == "1")
                {
                    BTN_TX_OUT_CH4.Text = "ON";
                    BTN_TX_OUT_CH4.BackColor = Color.Lime;
                    PBOX_Tx_STS_4.Image = BERT.Properties.Resources.led_green;
                    TxCh4Flag = true;
                }
                else
                {
                    BTN_TX_OUT_CH4.Text = "OFF";
                    BTN_TX_OUT_CH4.BackColor = Color.Red;
                    PBOX_Tx_STS_4.Image = BERT.Properties.Resources.led_red;
                    TxCh4Flag = false;
                }
            }

            if (MesCh1Flag)
            {
                try
                {
                    rslt = Commands.GetResult(bertPort1, 1);

                    if (rslt == null)
                    {
                        GetResult.Stop();
                        BTN_MES_CH1.Text = "START";
                        MesCh1Flag = false;
                        MesCh2Flag = false;
                        this.bertPort1.Close();
                        DialogResult dr = MessageBox.Show("データの取得ができませんでした。デバイスの接続を確認してください。", "Error",
                            MessageBoxButtons.OK,
                                (MessageBoxIcon)Enum.Parse(typeof(MessageBoxIcon), "Error"));

                        BTN_ETHER_Connect.Text = "CONNECT";
                        BTN_COM_Connect.Text = "CONNECT";
                        CBOX_COM1.Enabled = true;
                        IP_Txt.Enabled = true;
                        BTN_COM_IF_CHG.Enabled = true;
                        BTN_ETH_IF_CHG.Enabled = true;

                        PAN_Form_Main.Enabled = false; 
                        bertPort1.Close();
                        return;
                    }

                    DspMesResultCh1(rslt);
                }
                catch (Exception) 
                {
                    GetResult.Stop();
                    BTN_MES_CH1.Text = "START";
                    MesCh1Flag = false;
                    MesCh2Flag = false;
                    this.bertPort1.Close();
                    DialogResult dr = MessageBox.Show("データの取得ができませんでした。デバイスの接続を確認してください。", "Error",
                        MessageBoxButtons.OK,
                            (MessageBoxIcon)Enum.Parse(typeof(MessageBoxIcon), "Error"));

                    BTN_ETHER_Connect.Text = "CONNECT";
                    BTN_COM_Connect.Text = "CONNECT";
                    CBOX_COM1.Enabled = true;
                    IP_Txt.Enabled = true;
                    BTN_COM_IF_CHG.Enabled = true;
                    BTN_ETH_IF_CHG.Enabled = true;

                    PAN_Form_Main.Enabled = false;
                    bertPort1.Close();

                }

            }
            if (MesCh2Flag)
            {
                try
                {
                    rslt = Commands.GetResult(bertPort1, 2);
                    if (rslt == null)
                    {
                        GetResult.Stop();
                        BTN_MES_CH2.Text = "START";
                        MesCh1Flag = false;
                        MesCh2Flag = false;
                        this.bertPort1.Close();
                        DialogResult dr = MessageBox.Show("データの取得ができませんでした。デバイスの接続を確認してください。", "Error",
                            MessageBoxButtons.OK,
                                (MessageBoxIcon)Enum.Parse(typeof(MessageBoxIcon), "Error"));

                        BTN_ETHER_Connect.Text = "CONNECT";
                        BTN_COM_Connect.Text = "CONNECT";
                        CBOX_COM1.Enabled = true;
                        IP_Txt.Enabled = true;
                        BTN_COM_IF_CHG.Enabled = true;
                        BTN_ETH_IF_CHG.Enabled = true;
                        PAN_Form_Main.Enabled = false;
                        bertPort1.Close();
                        return;
                    }
                        DspMesResultCh2(rslt);
                }
                catch (Exception )
                {
                    GetResult.Stop();
                    BTN_MES_CH2.Text = "START";
                    MesCh1Flag = false;
                    MesCh2Flag = false;
                    this.bertPort1.Close();
                    DialogResult dr = MessageBox.Show("データの取得ができませんでした。デバイスの接続を確認してください。", "Error",
                        MessageBoxButtons.OK,
                            (MessageBoxIcon)Enum.Parse(typeof(MessageBoxIcon), "Error"));

                    BTN_ETHER_Connect.Text = "CONNECT";
                    BTN_COM_Connect.Text = "CONNECT";
                    CBOX_COM1.Enabled = true;
                    IP_Txt.Enabled = true;
                    BTN_COM_IF_CHG.Enabled = true;
                    BTN_ETH_IF_CHG.Enabled = true;
                    PAN_Form_Main.Enabled = false;
                    bertPort1.Close();
                }
            }

            if (MesCh3Flag)
            {
                try
                {
                    rslt = Commands.GetResult(bertPort2, 1);

                    if (rslt == null)
                    {
                        GetResult.Stop();
                        BTN_MES_CH3.Text = "START";
                        MesCh3Flag = false;
                        MesCh4Flag = false;
                        this.bertPort1.Close();
                        DialogResult dr = MessageBox.Show("データの取得ができませんでした。デバイスの接続を確認してください。", "Error",
                            MessageBoxButtons.OK,
                                (MessageBoxIcon)Enum.Parse(typeof(MessageBoxIcon), "Error"));

                        BTN_ETHER_Connect.Text = "CONNECT";
                        BTN_COM_Connect.Text = "CONNECT";
                        CBOX_COM2.Enabled = true;
                        IP_Txt.Enabled = true;
                        BTN_COM_IF_CHG.Enabled = true;
                        BTN_ETH_IF_CHG.Enabled = true;

                        PAN_Form_Main.Enabled = false;
                        bertPort2.Close();
                        return;
                    }

                    DspMesResultCh3(rslt);
                }
                catch (Exception)
                {
                    GetResult.Stop();
                    BTN_MES_CH3.Text = "START";
                    MesCh3Flag = false;
                    MesCh4Flag = false;
                    this.bertPort2.Close();
                    DialogResult dr = MessageBox.Show("データの取得ができませんでした。デバイスの接続を確認してください。", "Error",
                        MessageBoxButtons.OK,
                            (MessageBoxIcon)Enum.Parse(typeof(MessageBoxIcon), "Error"));

                    BTN_ETHER_Connect.Text = "CONNECT";
                    BTN_COM_Connect.Text = "CONNECT";
                    CBOX_COM2.Enabled = true;
                    IP_Txt.Enabled = true;
                    BTN_COM_IF_CHG.Enabled = true;
                    BTN_ETH_IF_CHG.Enabled = true;

                    PAN_Form_Main.Enabled = false;
                    bertPort2.Close();

                }
            }

            if (MesCh4Flag)
            {
                try
                {
                    rslt = Commands.GetResult(bertPort2, 2);

                    if (rslt == null)
                    {
                        GetResult.Stop();
                        BTN_MES_CH4.Text = "START";
                        MesCh3Flag = false;
                        MesCh4Flag = false;
                        this.bertPort2.Close();
                        DialogResult dr = MessageBox.Show("データの取得ができませんでした。デバイスの接続を確認してください。", "Error",
                            MessageBoxButtons.OK,
                                (MessageBoxIcon)Enum.Parse(typeof(MessageBoxIcon), "Error"));

                        BTN_ETHER_Connect.Text = "CONNECT";
                        BTN_COM_Connect.Text = "CONNECT";
                        CBOX_COM2.Enabled = true;
                        IP_Txt.Enabled = true;
                        BTN_COM_IF_CHG.Enabled = true;
                        BTN_ETH_IF_CHG.Enabled = true;

                        PAN_Form_Main.Enabled = false;
                        bertPort2.Close();
                        return;
                    }

                    DspMesResultCh4(rslt);
                }
                catch (Exception)
                {
                    GetResult.Stop();
                    BTN_MES_CH3.Text = "START";
                    MesCh3Flag = false;
                    MesCh4Flag = false;
                    this.bertPort2.Close();
                    DialogResult dr = MessageBox.Show("データの取得ができませんでした。デバイスの接続を確認してください。", "Error",
                        MessageBoxButtons.OK,
                            (MessageBoxIcon)Enum.Parse(typeof(MessageBoxIcon), "Error"));

                    BTN_ETHER_Connect.Text = "CONNECT";
                    BTN_COM_Connect.Text = "CONNECT";
                    CBOX_COM2.Enabled = true;
                    IP_Txt.Enabled = true;
                    BTN_COM_IF_CHG.Enabled = true;
                    BTN_ETH_IF_CHG.Enabled = true;

                    PAN_Form_Main.Enabled = false;
                    bertPort2.Close();

                }

            }
        }


        private void CMB_PN_CH1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (this.isUiLoadOfConnecting)
            {
                return;
            }

            string ptn = "";
            string len = "";
            string rslt = "";

            if (bertPort1.IsOpen)
            {
                ptn = CMB_PN_CH1.Text;
                len = CMB_LENGTH_CH1.Text;
                rslt = Commands.SetPpgPat(bertPort1, 1, ptn.ToLower(), len.ToLower());
                rslt = Commands.SetEdPat(bertPort1, 1, ptn.ToLower());
                return;
            }
            else
            {
                DialogResult dr = MessageBox.Show("デバイスが接続されていません", "Error",
                    MessageBoxButtons.OK,
                    (MessageBoxIcon)Enum.Parse(typeof(MessageBoxIcon), "Error"));
                return;
            }
        }

        private void CMB_PN_CH2_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (this.isUiLoadOfConnecting)
            {
                return;
            }

            string ptn = "";
            string len = "";
            string rslt = "";

            if (bertPort1.IsOpen)
            {
                ptn = CMB_PN_CH2.Text;
                len = CMB_LENGTH_CH2.Text;
                rslt = Commands.SetPpgPat(bertPort1, 2, ptn.ToLower(), len.ToLower());
                rslt = Commands.SetEdPat(bertPort1, 2, ptn.ToLower());
                return;
            }
            else
            {
                DialogResult dr = MessageBox.Show("デバイスが接続されていません", "Error",
                                        MessageBoxButtons.OK,
                                            (MessageBoxIcon)Enum.Parse(typeof(MessageBoxIcon), "Error"));
                return;
            }

        }

        private void CMB_PN_CH3_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (this.isUiLoadOfConnecting)
            {
                return;
            }

            string ptn = "";
            string len = "";
            string rslt = "";

            if (bertPort2.IsOpen)
            {
                ptn = CMB_PN_CH3.Text;
                len = CMB_LENGTH_CH3.Text;
                rslt = Commands.SetPpgPat(bertPort2, 1, ptn.ToLower(), len.ToLower());
                rslt = Commands.SetEdPat(bertPort2, 1, ptn.ToLower());
                return;
            }
            else
            {
                DialogResult dr = MessageBox.Show("デバイスが接続されていません", "Error",
                    MessageBoxButtons.OK,
                    (MessageBoxIcon)Enum.Parse(typeof(MessageBoxIcon), "Error"));
                return;
            }
        }

        private void CMB_PN_CH4_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (this.isUiLoadOfConnecting)
            {
                return;
            }

            string ptn = "";
            string len = "";
            string rslt = "";

            if (bertPort1.IsOpen)
            {
                ptn = CMB_PN_CH4.Text;
                len = CMB_LENGTH_CH4.Text;
                rslt = Commands.SetPpgPat(bertPort2, 2, ptn.ToLower(), len.ToLower());
                rslt = Commands.SetEdPat(bertPort2, 2, ptn.ToLower());
                return;
            }
            else
            {
                DialogResult dr = MessageBox.Show("デバイスが接続されていません", "Error",
                                        MessageBoxButtons.OK,
                                            (MessageBoxIcon)Enum.Parse(typeof(MessageBoxIcon), "Error"));
                return;
            }

        }

        private void CMB_LEN_CH1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (this.isUiLoadOfConnecting)
            {
                return;
            }

            string ptn = "";
            string len = "";
            string rslt = "";

            if (bertPort1.IsOpen)
            {
                ptn = CMB_PN_CH1.Text;
                len = CMB_LENGTH_CH1.Text;
                rslt = Commands.SetPpgPat(bertPort1, 1, ptn.ToLower(), len.ToLower());
                rslt = Commands.SetEdPat(bertPort1, 1, ptn.ToLower());
                return;
            }
            else
            {
                DialogResult dr = MessageBox.Show("デバイスが接続されていません", "Error",
                    MessageBoxButtons.OK,
                    (MessageBoxIcon)Enum.Parse(typeof(MessageBoxIcon), "Error"));
                return;
            }
        }

        private void CMB_LEN_CH2_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (this.isUiLoadOfConnecting)
            {
                return;
            }

            string ptn = "";
            string len = "";
            string rslt = "";

            if (bertPort1.IsOpen)
            {
                ptn = CMB_PN_CH2.Text;
                len = CMB_LENGTH_CH2.Text;
                rslt = Commands.SetPpgPat(bertPort1, 2, ptn.ToLower(), ptn.ToLower());
                rslt = Commands.SetEdPat(bertPort1, 2, ptn.ToLower());
                return;
            }
            else
            {
                DialogResult dr = MessageBox.Show("デバイスが接続されていません", "Error",
                                        MessageBoxButtons.OK,
                                            (MessageBoxIcon)Enum.Parse(typeof(MessageBoxIcon), "Error"));
                return;
            }

        }

        private void CMB_LEN_CH3_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (this.isUiLoadOfConnecting)
            {
                return;
            }

            string ptn = "";
            string len = "";
            string rslt = "";

            if (bertPort2.IsOpen)
            {
                ptn = CMB_PN_CH3.Text;
                len = CMB_PN_CH3.Text;
                rslt = Commands.SetPpgPat(bertPort2, 1, ptn.ToLower(), len.ToLower());
                rslt = Commands.SetEdPat(bertPort2, 1, ptn.ToLower());
                return;
            }
            else
            {
                DialogResult dr = MessageBox.Show("デバイスが接続されていません", "Error",
                    MessageBoxButtons.OK,
                    (MessageBoxIcon)Enum.Parse(typeof(MessageBoxIcon), "Error"));
                return;
            }
        }

        private void CMB_LEN_CH4_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (this.isUiLoadOfConnecting)
            {
                return;
            }

            string ptn = "";
            string len = "";
            string rslt = "";

            if (bertPort1.IsOpen)
            {
                ptn = CMB_PN_CH4.Text;
                rslt = Commands.SetPpgPat(bertPort2, 2, ptn.ToLower(), len.ToLower());
                rslt = Commands.SetEdPat(bertPort2, 2, ptn.ToLower());
                return;
            }
            else
            {
                DialogResult dr = MessageBox.Show("デバイスが接続されていません", "Error",
                                        MessageBoxButtons.OK,
                                            (MessageBoxIcon)Enum.Parse(typeof(MessageBoxIcon), "Error"));
                return;
            }

        }

        private void BTN_COM_IF_CHG_Click(object sender, EventArgs e)
        {
            if (BTN_COM_Connect.Text == "DISCONNECT")
            {
                DialogResult dr = MessageBox.Show("COMポートを切断してからインタフェースを切り替えてください", "Error",
                    MessageBoxButtons.OK,
                        (MessageBoxIcon)Enum.Parse(typeof(MessageBoxIcon), "Error"));
                return;
            }
            //COM_Panel.Visible = false;
            Ether_Panel.Visible = true;
        }

        private void BTN_ETH_IF_CHG_Click(object sender, EventArgs e)
        {
            if (BTN_ETHER_Connect.Text == "DISCONNECT")
            {
                DialogResult dr = MessageBox.Show("ETHERNETを切断してからインタフェースを切り替えてください", "Error",
                        MessageBoxButtons.OK,
                            (MessageBoxIcon)Enum.Parse(typeof(MessageBoxIcon), "Error"));
                return; 
            }
            COM_Panel.Visible = true;
            Ether_Panel.Visible = false;
        }

        private void netwrokSetNToolStripMenuItem_Click(object sender, EventArgs e)
        {
            NetworkSet networkSet = new NetworkSet(bertPort1, this);

            networkSet.ShowDialog();
            if (networkSet.NetworkSettingUpdated)
            {
                this.GetResult.Stop();
                this.ClosingIF();
                MessageBox.Show("ネットワークの設定を変更しました。GUIを再起動してください", "再起動", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private async Task<bool> workerConnect(bool isConnecting, bool isEther)
        {
            try
            {
                String chInfo = "";

                if (isConnecting)
                {
                    string msg;

                    try
                    {
                        await this.preBertPort1.Open();
                    }
                    catch(Exception ex)
                    {
                        msg = "BERT装置への接続ができませんでした。\n装置の接続を確認してください。";
                        MessageBox.Show(msg, "Connection error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return false;
                    }
                    Thread.Sleep(500);

                    try
                    {
                        await this.preBertPort2.Open();
                    }
                    catch (Exception ex)
                    {
                        msg = "BERT装置への接続ができませんでした。\n装置の接続を確認してください。";
                        MessageBox.Show(msg, "Connection error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return false;
                    }
                    Thread.Sleep(500);

                    chInfo = Commands.GetCH(preBertPort1);
                    if (chInfo == "1-2")
                    {
                        bertPort1 = preBertPort1;
                    }
                    else if(chInfo == "3-4")
                    {
                        bertPort2 = preBertPort1;
                    }
                    else
                    {
                        msg = "COMポートCH情報が取得できませんでした";
                        MessageBox.Show(msg, "Connection error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return false;
                    }
                    chInfo = Commands.GetCH(preBertPort2);
                    if (chInfo == "1-2")
                    {
                        bertPort1 = preBertPort2;
                    }
                    else if (chInfo == "3-4")
                    {
                        bertPort2 = preBertPort2;
                    }
                    else
                    {
                        msg = "COMポートCH情報が取得できませんでした";
                        MessageBox.Show(msg, "Connection error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return false;
                    }

                    this.isUiLoadOfConnecting = true;
                    BitrateGUISet(Commands.GetBitrate(bertPort1));
                    TriggerGUISet(Commands.GetTrigger(bertPort1));
                    for (int ch = 0; ch < 2; ch++)
                    {
                        var chNumber = ch + 1;
                        PPGGUISet(chNumber, Commands.GetPPG(bertPort1, chNumber));
                        EdGUISet(chNumber, Commands.GetEd(bertPort1, chNumber));
                        ReSyncModeSet(chNumber, Commands.GetReSyncMode(bertPort1, chNumber));
                        EdPatSet(chNumber, Commands.GetEdPat(bertPort1, chNumber));
                    }
                    for (int ch = 0; ch < 2; ch++)
                    {
                        var chNumber = ch + 3;
                        PPGGUISet(chNumber, Commands.GetPPG(bertPort2, ch+1));
                        EdGUISet(chNumber, Commands.GetEd(bertPort2, ch+1));
                        ReSyncModeSet(chNumber, Commands.GetReSyncMode(bertPort2, ch+1));
                        EdPatSet(chNumber, Commands.GetEdPat(bertPort2, ch+1));
                    }


                    SetProgramPattern();


                    this.DHCPFlag = Commands.GetDHCP(bertPort1) == "1";

                    Button button = null;
                    string portType = "";
                    if (isEther)
                    {
                        button = this.BTN_ETHER_Connect;
                        portType = "Ethernet";
                    }
                    else
                    {
                        button = this.BTN_COM_Connect;
                        portType = "COMポート";
                    }
                    this.updateConnected(button, button.Text == "CONNECT", portType);

                    this.isUiLoadOfConnecting = false;
                    BTN_COM_IF_CHG.Enabled = false;
                    BTN_ETH_IF_CHG.Enabled = false;
                    GetResult.Start();
                }
                else
                {
                    GetResult.Stop();

                    MesCh1Flag = false;
                    MesCh2Flag = false;
                    Thread.Sleep(1000);
                    ClosingIF();

                    BTN_COM_IF_CHG.Enabled = true;
                    BTN_ETH_IF_CHG.Enabled = true;
                }
                return true;
            }
            catch (Exception ex)
            {
                if (isConnecting)
                {
                    this.bertPort1.Close();
                    string msg;
                    if (isEther)
                    {
                        msg = "ETHERNET接続がタイムアウトで接続できませんでした";
                    }
                    else
                    {
                        msg = "COMポート接続がタイムアウトで接続できませんでした";
                    }
                    MessageBox.Show(msg, "Connection error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    MessageBox.Show(ex.Message, "Connection error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                return false;
            }
        }

        private void updateConnected(Button connectButton, bool isConnected, string portType)
        {
            connectButton.Text = isConnected ? "DISCONNECT" : "CONNECT";
            if (isConnected)
            {
                PAN_Form_Main.Enabled = true;
            }
            else
            {
                PAN_Form_Main.Enabled = false;
                isUiLoadOfConnectingDone = false;
            }
        }

        public void ClosingIF()
        {
            BTN_ETHER_Connect.Text = "CONNECT";
            BTN_COM_Connect.Text = "CONNECT";
            CBOX_COM1.Enabled = true;
            CBOX_COM2.Enabled = true;
            IP_Txt.Enabled = true;
            BTN_COM_IF_CHG.Enabled = true;
            BTN_ETH_IF_CHG.Enabled = true;
            PAN_Form_Main.Enabled = false;
            bertPort1.Close();
            bertPort2.Close();
        }


        private void 終了ToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BERT_MainForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (CBOX_COM1.SelectedItem == null)
            {
                Properties.Settings.Default.COMPortName1 = "";
            }
            else
            {
                Properties.Settings.Default.COMPortName1 = CBOX_COM1.SelectedItem.ToString();
            }
            if (CBOX_COM2.SelectedItem == null)
            {
                Properties.Settings.Default.COMPortName2 = "";
            }
            else
            {
                Properties.Settings.Default.COMPortName2 = CBOX_COM2.SelectedItem.ToString();
            }

            Properties.Settings.Default.RemoteIpAddress = IP_Txt.Text;
            Properties.Settings.Default.RemoteDhcpEnabled = DHCPFlag;


            if (Ether_Panel.Visible == false)
            {
                Properties.Settings.Default.InterfaceSelect = 0;
            }
            else
            {
                Properties.Settings.Default.InterfaceSelect = 1;
            }

            Properties.Settings.Default.Save();
        }

        private void BERT_MainForm_Load(object sender, EventArgs e)
        {
            string comname1 = "";
            string comname2 = "";
            int ifsel = 0;
            int selectid = 0;

            try
            {

                comname1 = Properties.Settings.Default.COMPortName1;
                comname2 = Properties.Settings.Default.COMPortName2;
                ifsel = Properties.Settings.Default.InterfaceSelect;
                IP_Txt.Text = Properties.Settings.Default.RemoteIpAddress;
                DHCPFlag = Properties.Settings.Default.RemoteDhcpEnabled;


                if (ifsel == 0)
                {
                    int id = 0;
                    for(id = 0; id < CBOX_COM1.Items.Count; id++)
                    {
                        if (CBOX_COM1.Items[id].ToString() == comname1)
                        {
                            selectid = id;
                        }
                    }
                    CBOX_COM1.SelectedIndex = selectid;
                    
                    selectid = 0;
                    for (id = 0; id < CBOX_COM2.Items.Count; id++)
                    {
                        if (CBOX_COM2.Items[id].ToString() == comname2)
                        {
                            selectid = id;
                        }
                    }
                    CBOX_COM2.SelectedIndex = selectid;

                    COM_Panel.Visible = true;
                    Ether_Panel.Visible = false;
                }
                else if (ifsel == 1)
                {
                    Ether_Panel.Visible = true;
                }
                else
                {
                    int id = 0;
                    for (id = 0; id < CBOX_COM1.Items.Count; id++)
                    {
                        if (CBOX_COM1.Items[id].ToString() == comname1)
                        {
                            selectid = id;
                        }
                    }
                    CBOX_COM1.SelectedIndex = selectid;

                    selectid = 0;
                    for (id = 0; id < CBOX_COM2.Items.Count; id++)
                    {
                        if (CBOX_COM2.Items[id].ToString() == comname2)
                        {
                            selectid = id;
                        }
                    }
                    CBOX_COM2.SelectedIndex = selectid;

                    COM_Panel.Visible = true;
                    Ether_Panel.Visible = false;
                }

            }
            catch (Exception)
            {
                DialogResult dr = MessageBox.Show("COMポートが認識できませんでした。\nBERT装置の接続を確認してください。", "Error",
                MessageBoxButtons.OK,
                (MessageBoxIcon)Enum.Parse(typeof(MessageBoxIcon), "Error"));
            }
        }

        private void BTN_ProgramPatternSetting_Click(object sender, EventArgs e)
        {
            var form = new ProgramPatternSetting();
            form.ShowDialog();
            form.Dispose();
        }

        private void SetProgramPattern()
        {
            string filePath = Directory.GetCurrentDirectory();
            string filePathD = filePath.Replace("\\", "/") + "/" + fileFolder + "/" + Properties.Settings.Default.ProgramPatternFileName + ".csv";

            IEnumerable<string> lines = File.ReadLines(filePathD);
            int lineNo = 0;
            foreach (string line in lines)
            {
                var sptext = line.Split(',');

                setProgramPattern(lineNo, sptext);
                lineNo++;
            }
        }

        private void setProgramPattern(int lineNo, string[] sptext)
        {
            string rslt = "";

            if (lineNo < 3)
            {
                rslt = Commands.SetPrgPat(bertPort1, lineNo, sptext);
            }
            else if (lineNo > 2)
            {
                rslt = Commands.SetPrgPat(bertPort2, lineNo, sptext);
            }
        }

    }
}
