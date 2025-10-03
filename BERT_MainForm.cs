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



namespace BERT
{
    public partial class BERT_MainForm : Form
    {
        BertPortSerial bertPortSerial = new BertPortSerial("COM01");
        BertPortTcp bertPortTcp = new BertPortTcp("tcp");
        BertPortBase bertPort;

        public bool TxCh1Flag = false;
        public bool TxCh2Flag = false;
        public bool MesCh1Flag = false;
        public bool MesCh2Flag = false;
        public bool DHCPFlag = false;

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

        public BertPortBase GetBertPort
        {
            get
            { 
                return bertPort;
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
                CBOX_COM.Items.Add(port);
            }
            if (CBOX_COM.Items.Count > 0)
            {
                CBOX_COM.SelectedIndex = 0;
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
        }

        private async void COM_Connect_BTN_Click(object sender, EventArgs e)
        {
            try
            {
                this.bertPort = this.bertPortSerial;
                bool connecting = this.BTN_COM_Connect.Text == "CONNECT";
                if (connecting)
                {
                    this.bertPort.BertPortNameSet(this.CBOX_COM.Text);
                }

                var p = new object[]{ connecting, false };
                //this.bgWorkerConnect.RunWorkerAsync(p);

                await Task.Run(() =>
                {
                    this.Invoke(new Action(async () => await this.workerConnect(connecting, false)));
                });

                //Thread.Sleep(500);

                //if (connecting)
                //{
                //    GetResult.Start();
                //    CBOX_COM.Enabled = false;
                //    IP_Txt.Enabled = false;
                //    BTN_COM_IF_CHG.Enabled = false;
                //    BTN_ETH_IF_CHG.Enabled = false;
                //}
                //else
                //{
                //    GetResult.Stop();
                //    CBOX_COM.Enabled = true;
                //    IP_Txt.Enabled = true;
                //    BTN_COM_IF_CHG.Enabled = true;
                //    BTN_ETH_IF_CHG.Enabled = true;
                //}
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
                this.bertPort = this.bertPortTcp;
                bool connecting = this.BTN_ETHER_Connect.Text == "CONNECT";
                if (connecting)
                {
                    this.bertPort.BertPortNameSet(this.IP_Txt.Text);
                }

                var p = new object[2]{ connecting, true };
                //this.bgWorkerConnect.RunWorkerAsync(p);

                await Task.Run(() =>
                {
                    this.Invoke(new Action(async () => await this.workerConnect(connecting, true)));
                });

                //Thread.Sleep(500);

                //if (connecting)
                //{
                //    GetResult.Start();
                //    CBOX_COM.Enabled = false;
                //    IP_Txt.Enabled = false;
                //    BTN_COM_IF_CHG.Enabled = false;
                //    BTN_ETH_IF_CHG.Enabled = false;
                //}
                //else
                //{
                //    GetResult.Stop();
                //    CBOX_COM.Enabled = true;
                //    IP_Txt.Enabled = true;
                //    BTN_COM_IF_CHG.Enabled = true;
                //    BTN_ETH_IF_CHG.Enabled = true;
                //}
            }
            catch (Exception ex)
            {
                string title = this.BTN_ETHER_Connect.Text == "CONNECT" ? "Connect start error" : "Disconnect start error";
                MessageBox.Show(ex.Message, title, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

            private void CBOX_COM_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.CBOX_COM.Text = CBOX_COM.SelectedText;
        }


        private void バージョン情報VToolStripMenuItem_Click(object sender, EventArgs e)
        {
            VersionForm versionInfo = new VersionForm(bertPort, GUIVerInf);

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

            if (bertPort.IsOpen)
            {
                br = CBOX_BR.Text + "m";
                rslt = Commands.SetBitrate(bertPort, br);
                if (CBOX_BR.Text == "35.02")
                {
                    LAB_FUGO_Result_CH1.Text = "Manchester";
                    LAB_FUGO_Result_CH2.Text = "Manchester";
                }
                else
                {
                    LAB_FUGO_Result_CH1.Text = "NRZ";
                    LAB_FUGO_Result_CH2.Text = "NRZ";
                }
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

            if (bertPort.IsOpen)
            {
                trg = CMB_Trg.Text;
                rslt = Commands.SetTrigger(bertPort, trg);
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

            if (bertPort.IsOpen)
            {
                if (TxCh1Flag)
                {
                    rslt = Commands.SetPPG(bertPort, 1, 0);
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
                    rslt = Commands.SetPPG(bertPort, 1, 1);
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

            if (bertPort.IsOpen)
            {
                if (TxCh2Flag)
                {
                    rslt = Commands.SetPPG(bertPort, 2, 0);
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
                    rslt = Commands.SetPPG(bertPort, 2, 1);
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

        private void BTN_MES_CH1_Click(object sender, EventArgs e)
        {
            string ret;

            if (bertPort.IsOpen)
            {
                //if (!MesCh1Flag && !MesCh2Flag)
                //{
                //    GetResult.Start();
                //}

                if (MesCh1Flag)
                {
                    ret = Commands.SetEd(bertPort, 1, 0);
                    if (ret == "OK")
                    {
                        BTN_MES_CH1.Text = "START";
                        MesCh1Flag = false;
                    }
                }
                else
                {
                    ret = Commands.SetEd(bertPort, 1, 1);
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

            if (bertPort.IsOpen)
            {
                //if (!MesCh1Flag && !MesCh2Flag)
                //{
                //    GetResult.Start();
                //}

                if (MesCh2Flag)
                {
                    ret = Commands.SetEd(bertPort, 2, 0);
                    if (ret == "OK")
                    {
                        BTN_MES_CH2.Text = "START";
                        MesCh2Flag = false;
                    }
                }
                else
                {
                    ret = Commands.SetEd(bertPort, 2, 1);
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

        private void CBOX_ReSync_Mode_CH1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (this.isUiLoadOfConnecting)
            {
                return;
            }

            string rslt = "";

            if (bertPort.IsOpen)
            {
                if (CBOX_ReSync_Mode_CH1.SelectedIndex == 0)
                {
                    rslt = Commands.SetReSyncMode(bertPort, 1, "auto");
                }
                else if (CBOX_ReSync_Mode_CH1.SelectedIndex == 1)
                {
                    rslt = Commands.SetReSyncMode(bertPort, 1, "manual");
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

            if (bertPort.IsOpen)
            {
                if (CBOX_ReSync_Mode_CH2.SelectedIndex == 0)
                {
                    rslt = Commands.SetReSyncMode(bertPort, 2, "auto");
                }
                else if (CBOX_ReSync_Mode_CH2.SelectedIndex == 1)
                {
                    rslt = Commands.SetReSyncMode(bertPort, 2, "manual");
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

            if (bertPort.IsOpen)
            {
                dovercnt_Ch1 = 0;
                eovercnt_Ch1 = 0;
                rslt = Commands.ReSync(bertPort, 1);
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

            if (bertPort.IsOpen)
            {
                dovercnt_Ch2 = 0;
                eovercnt_Ch2 = 0;
                rslt = Commands.ReSync(bertPort, 2);
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

            if (bertPort.IsOpen)
            {
                rslt = Commands.ResetFlag(bertPort, 1);

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

            if (bertPort.IsOpen)
            {
                rslt = Commands.ResetFlag(bertPort, 2);
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

        private void BTN_Cnt_Rst_CH1_Click(object sender, EventArgs e)
        {
            string rslt = "";

            if (bertPort.IsOpen)
            {
                rslt = Commands.ResetCount(bertPort, 1);
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

            if (bertPort.IsOpen)
            {
                rslt = Commands.ResetCount(bertPort, 2);
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

        private void GetResult_Tick(object sender, EventArgs e)
        {
            List<string> rslt;

            //LAB_TEST_CNT.Text = testcnt.ToString();
            //testcnt += 1;

            if (bertPort.IsOpen)
            {
                if (Commands.GetPPG(bertPort, 1) == "1")
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
                if (Commands.GetPPG(bertPort, 2) == "1")
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

            if (MesCh1Flag)
            {
                try
                {
                    rslt = Commands.GetResult(bertPort, 1);

                    if (rslt == null)
                    {
                        GetResult.Stop();
                        BTN_MES_CH1.Text = "START";
                        MesCh1Flag = false;
                        MesCh2Flag = false;
                        this.bertPort.Close();
                        DialogResult dr = MessageBox.Show("データの取得ができませんでした。デバイスの接続を確認してください。", "Error",
                            MessageBoxButtons.OK,
                                (MessageBoxIcon)Enum.Parse(typeof(MessageBoxIcon), "Error"));

                        BTN_ETHER_Connect.Text = "CONNECT";
                        BTN_COM_Connect.Text = "CONNECT";
                        CBOX_COM.Enabled = true;
                        IP_Txt.Enabled = true;
                        BTN_COM_IF_CHG.Enabled = true;
                        BTN_ETH_IF_CHG.Enabled = true;

                        PAN_Form_Main.Enabled = false; 
                        bertPort.Close();
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
                    this.bertPort.Close();
                    DialogResult dr = MessageBox.Show("データの取得ができませんでした。デバイスの接続を確認してください。", "Error",
                        MessageBoxButtons.OK,
                            (MessageBoxIcon)Enum.Parse(typeof(MessageBoxIcon), "Error"));

                    BTN_ETHER_Connect.Text = "CONNECT";
                    BTN_COM_Connect.Text = "CONNECT";
                    CBOX_COM.Enabled = true;
                    IP_Txt.Enabled = true;
                    BTN_COM_IF_CHG.Enabled = true;
                    BTN_ETH_IF_CHG.Enabled = true;

                    PAN_Form_Main.Enabled = false;
                    bertPort.Close();

                }

            }
            if (MesCh2Flag)
            {
                try
                {
                    rslt = Commands.GetResult(bertPort, 2);
                    if (rslt == null)
                    {
                        GetResult.Stop();
                        BTN_MES_CH2.Text = "START";
                        MesCh1Flag = false;
                        MesCh2Flag = false;
                        this.bertPort.Close();
                        DialogResult dr = MessageBox.Show("データの取得ができませんでした。デバイスの接続を確認してください。", "Error",
                            MessageBoxButtons.OK,
                                (MessageBoxIcon)Enum.Parse(typeof(MessageBoxIcon), "Error"));

                        BTN_ETHER_Connect.Text = "CONNECT";
                        BTN_COM_Connect.Text = "CONNECT";
                        CBOX_COM.Enabled = true;
                        IP_Txt.Enabled = true;
                        BTN_COM_IF_CHG.Enabled = true;
                        BTN_ETH_IF_CHG.Enabled = true;
                        PAN_Form_Main.Enabled = false;
                        bertPort.Close();
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
                    this.bertPort.Close();
                    DialogResult dr = MessageBox.Show("データの取得ができませんでした。デバイスの接続を確認してください。", "Error",
                        MessageBoxButtons.OK,
                            (MessageBoxIcon)Enum.Parse(typeof(MessageBoxIcon), "Error"));

                    BTN_ETHER_Connect.Text = "CONNECT";
                    BTN_COM_Connect.Text = "CONNECT";
                    CBOX_COM.Enabled = true;
                    IP_Txt.Enabled = true;
                    BTN_COM_IF_CHG.Enabled = true;
                    BTN_ETH_IF_CHG.Enabled = true;
                    PAN_Form_Main.Enabled = false;
                    bertPort.Close();
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
            string rslt = "";

            if (bertPort.IsOpen)
            {
                ptn = CMB_PN_CH1.Text;
                rslt = Commands.SetPpgPat(bertPort, 1, ptn.ToLower());
                rslt = Commands.SetEdPat(bertPort, 1, ptn.ToLower());
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
            string rslt = "";

            if (bertPort.IsOpen)
            {
                ptn = CMB_PN_CH2.Text;
                rslt = Commands.SetPpgPat(bertPort, 2, ptn.ToLower());
                rslt = Commands.SetEdPat(bertPort, 2, ptn.ToLower());
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
            NetworkSet networkSet = new NetworkSet(bertPort, this);

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
                if (isConnecting)
                {
                    await this.bertPort.Open();
                    Thread.Sleep(500);
                    this.isUiLoadOfConnecting = true;
                    BitrateGUISet(Commands.GetBitrate(bertPort));
                    TriggerGUISet(Commands.GetTrigger(bertPort));
                    for (int ch = 0; ch < 2; ch++)
                    {
                        var chNumber = ch + 1;
                        PPGGUISet(chNumber, Commands.GetPPG(bertPort, chNumber));
                        EdGUISet(chNumber, Commands.GetEd(bertPort, chNumber));
                        ReSyncModeSet(chNumber, Commands.GetReSyncMode(bertPort, chNumber));
                        EdPatSet(chNumber, Commands.GetEdPat(bertPort, chNumber));
                    }
                    this.DHCPFlag = Commands.GetDHCP(bertPort) == "1";

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
                    //this.bertPort.Close();
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
                    this.bertPort.Close();
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
                //MessageBox.Show(portType + "に接続しました", "CONNECT",
                //    MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                PAN_Form_Main.Enabled = false;
                isUiLoadOfConnectingDone = false;
                //MessageBox.Show(portType + "を切断しました", "DISCONNECT",
                //    MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        public void ClosingIF()
        {
            BTN_ETHER_Connect.Text = "CONNECT";
            BTN_COM_Connect.Text = "CONNECT";
            CBOX_COM.Enabled = true;
            IP_Txt.Enabled = true;
            BTN_COM_IF_CHG.Enabled = true;
            BTN_ETH_IF_CHG.Enabled = true;
            PAN_Form_Main.Enabled = false;
            bertPort.Close();
        }


        private void 終了ToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            //this.bgWorkerConnect.RunWorkerAsync(false);
            //Thread.Sleep(500);
            this.Close();
        }

        private void BERT_MainForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (CBOX_COM.SelectedItem == null)
            {
                Properties.Settings.Default.COMPortName = "";
            }
            else
            {
                Properties.Settings.Default.COMPortName = CBOX_COM.SelectedItem.ToString();
            }
            Properties.Settings.Default.RemoteIpAddress = IP_Txt.Text;
            Properties.Settings.Default.RemoteDhcpEnabled = DHCPFlag;


            //if ( this.bertPort == null )
            //    {
            //        Properties.Settings.Default.InterfaceSelect = 0;
            //    }
            //else if (this.bertPort.GetType() == typeof(BertPortSerial))
            //{
            //    Properties.Settings.Default.InterfaceSelect = 0;
            //}
            //else if(this.bertPort.GetType() == typeof(BertPortTcp))
            //{
            //    Properties.Settings.Default.InterfaceSelect = 1;
            //}
            //else
            //{
            //    Properties.Settings.Default.InterfaceSelect = 0;
            //}

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
            string comname = "";
            int ifsel = 0;
            int selectid = 0;

            try
            {

                comname = Properties.Settings.Default.COMPortName;
                ifsel = Properties.Settings.Default.InterfaceSelect;
                IP_Txt.Text = Properties.Settings.Default.RemoteIpAddress;
                DHCPFlag = Properties.Settings.Default.RemoteDhcpEnabled;


                if (ifsel == 0)
                {
                    int id = 0;
                    for(id = 0; id < CBOX_COM.Items.Count; id++)
                    {
                        if (CBOX_COM.Items[id].ToString() == comname)
                        {
                            selectid = id;
                        }
                    }
                    CBOX_COM.SelectedIndex = selectid;
                    COM_Panel.Visible = true;
                    Ether_Panel.Visible = false;
                }
                else if (ifsel == 1)
                {
                    //COM_Panel.Visible = false;
                    Ether_Panel.Visible = true;
                }
                else
                {
                    int id = 0;
                    for (id = 0; id < CBOX_COM.Items.Count; id++)
                    {
                        if (CBOX_COM.Items[id].ToString() == comname)
                        {
                            selectid = id;
                        }
                    }
                    CBOX_COM.SelectedIndex = selectid;
                    COM_Panel.Visible = true;
                    Ether_Panel.Visible = false;
                }

            }
            catch (Exception)
            {
        //        DialogResult dr = MessageBox.Show("初期化に失敗しました", "Error",
        //MessageBoxButtons.OK,
        //    (MessageBoxIcon)Enum.Parse(typeof(MessageBoxIcon), "Error"));
                //MessageBox.Show("初期化失敗");
            }
        }
    }
}
