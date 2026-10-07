using System.Drawing;

namespace BERT
{
    partial class BERT_MainForm
    {
        /// <summary>
        /// 必要なデザイナー変数です。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 使用中のリソースをすべてクリーンアップします。
        /// </summary>
        /// <param name="disposing">マネージド リソースを破棄する場合は true を指定し、その他の場合は false を指定します。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows フォーム デザイナーで生成されたコード

        /// <summary>
        /// デザイナー サポートに必要なメソッドです。このメソッドの内容を
        /// コード エディターで変更しないでください。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.Label LAB_TXout_CH1;
            System.Windows.Forms.Label LAB_PN_CH1;
            System.Windows.Forms.Label LAB_LENGTH_CH1;
            System.Windows.Forms.Label LAB_LOS_CH1;
            System.Windows.Forms.Label LAB_ERR_CH1;
            System.Windows.Forms.Label LAB_Mesure_Time_CH1;
            System.Windows.Forms.Label LAB_Data_Cnt_CH1;
            System.Windows.Forms.Label LAB_Err_Cnt_CH1;
            System.Windows.Forms.Label LAB_BER_CH1;
            System.Windows.Forms.Label LAB_ES_CH1;
            System.Windows.Forms.Label LAB_Mesure_CH1;
            System.Windows.Forms.Label LAB_TXout_CH2;
            System.Windows.Forms.Label LAB_PN_CH2;
            System.Windows.Forms.Label LAB_LENGTH_CH2;
            System.Windows.Forms.Label LAB_LOS_CH2;
            System.Windows.Forms.Label LAB_ERR_CH2;
            System.Windows.Forms.Label LAB_Mesure_Time_CH2;
            System.Windows.Forms.Label LAB_Data_Cnt_CH2;
            System.Windows.Forms.Label LAB_Err_Cnt_CH2;
            System.Windows.Forms.Label LAB_BER_CH2;
            System.Windows.Forms.Label LAB_ES_CH2;
            System.Windows.Forms.Label LAB_Mesure_CH3;
            System.Windows.Forms.Label LAB_ES_CH3;
            System.Windows.Forms.Label LAB_BER_CH3;
            System.Windows.Forms.Label LAB_Err_Cnt_CH3;
            System.Windows.Forms.Label LAB_Data_Cnt_CH3;
            System.Windows.Forms.Label LAB_Mesure_Time_CH3;
            System.Windows.Forms.Label LAB_ERR_CH3;
            System.Windows.Forms.Label LAB_LOS_CH3;
            System.Windows.Forms.Label LAB_LENGTH_CH3;
            System.Windows.Forms.Label LAB_PN_CH3;
            System.Windows.Forms.Label LAB_TXout_CH3;
            System.Windows.Forms.Label LAB_Mesure_CH4;
            System.Windows.Forms.Label LAB_ES_CH4;
            System.Windows.Forms.Label LAB_BER_CH4;
            System.Windows.Forms.Label LAB_Err_Cnt_CH4;
            System.Windows.Forms.Label LAB_Data_Cnt_CH4;
            System.Windows.Forms.Label LAB_Mesure_Time_CH4;
            System.Windows.Forms.Label LAB_ERR_CH4;
            System.Windows.Forms.Label LAB_LOS_CH4;
            System.Windows.Forms.Label LAB_LENGTH_CH4;
            System.Windows.Forms.Label LAB_PN_CH4;
            System.Windows.Forms.Label LAB_TXout_CH4;
            System.Windows.Forms.Label LAB_LENGTH_CH1_unit;
            System.Windows.Forms.Label LAB_LENGTH_CH2_unit;
            System.Windows.Forms.Label LAB_LENGTH_CH3_unit;
            System.Windows.Forms.Label LAB_LENGTH_CH4_unit;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BERT_MainForm));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.終了ToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolTToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.netwrokSetNToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.programPatternSetPToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ヘルプHToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripMenuItem_Ver = new System.Windows.Forms.ToolStripMenuItem();
            this.COM_Panel = new System.Windows.Forms.Panel();
            this.Ether_Panel = new System.Windows.Forms.Panel();
            this.TXT_IPAdr2 = new System.Windows.Forms.TextBox();
            this.LAB_Ether2 = new System.Windows.Forms.Label();
            this.BTN_ETH_IF_CHG = new System.Windows.Forms.Button();
            this.PBOX_ETHER_SYS_ERR = new System.Windows.Forms.PictureBox();
            this.LAB_ETHER_SYS_ERR = new System.Windows.Forms.Label();
            this.BTN_ETHER_Connect = new System.Windows.Forms.Button();
            this.TXT_IPAdr1 = new System.Windows.Forms.TextBox();
            this.LAB_Ether1 = new System.Windows.Forms.Label();
            this.CBOX_COM2 = new System.Windows.Forms.ComboBox();
            this.LAB_COM2 = new System.Windows.Forms.Label();
            this.PBOX_COM_SYS_ERR = new System.Windows.Forms.PictureBox();
            this.LAB_COM_SYS_ERR = new System.Windows.Forms.Label();
            this.LAB_COM1 = new System.Windows.Forms.Label();
            this.BTN_COM_Connect = new System.Windows.Forms.Button();
            this.CBOX_COM1 = new System.Windows.Forms.ComboBox();
            this.BTN_COM_IF_CHG = new System.Windows.Forms.Button();
            this.GetResult = new System.Windows.Forms.Timer(this.components);
            this.LAB_Bitrate = new System.Windows.Forms.Label();
            this.GBOX_CH1 = new System.Windows.Forms.GroupBox();
            this.PBOX_Tx_STS_1 = new System.Windows.Forms.PictureBox();
            this.CBOX_ReSync_Mode_CH1 = new System.Windows.Forms.ComboBox();
            this.LAB_ReSync_Mode_CH1 = new System.Windows.Forms.Label();
            this.BTN_MES_CH1 = new System.Windows.Forms.Button();
            this.GBOX_Result_CH1 = new System.Windows.Forms.GroupBox();
            this.LAB_ES_Result_CH1 = new System.Windows.Forms.Label();
            this.LAB_BER_Result_CH1 = new System.Windows.Forms.Label();
            this.LAB_Err_Cnt_Result_CH1 = new System.Windows.Forms.Label();
            this.LAB_Data_Cnt_Result_CH1 = new System.Windows.Forms.Label();
            this.LAB_Mesure_Time_Result_CH1 = new System.Windows.Forms.Label();
            this.BTN_Cnt_Rst_CH1 = new System.Windows.Forms.Button();
            this.GBOX_Monitor_CH1 = new System.Windows.Forms.GroupBox();
            this.BTN_Flg_Rst_CH1 = new System.Windows.Forms.Button();
            this.PBOX_ERR_CH1 = new System.Windows.Forms.PictureBox();
            this.PBOX_LOS_CH1 = new System.Windows.Forms.PictureBox();
            this.PBOX_ERR_FLG_CH1 = new System.Windows.Forms.PictureBox();
            this.GBOX_Setting_CH1 = new System.Windows.Forms.GroupBox();
            this.LAB_LENGTH_CH1_Val = new System.Windows.Forms.Label();
            this.CMB_PN_CH1 = new System.Windows.Forms.ComboBox();
            this.BTN_Sync_CH1 = new System.Windows.Forms.Button();
            this.BTN_TX_OUT_CH1 = new System.Windows.Forms.Button();
            this.LAB_Sync_CH1 = new System.Windows.Forms.Label();
            this.CBOX_BR = new System.Windows.Forms.ComboBox();
            this.LAB_Mbps = new System.Windows.Forms.Label();
            this.GBOX_CH2 = new System.Windows.Forms.GroupBox();
            this.PBOX_Tx_STS_2 = new System.Windows.Forms.PictureBox();
            this.CBOX_ReSync_Mode_CH2 = new System.Windows.Forms.ComboBox();
            this.LAB_ReSync_Mode_CH2 = new System.Windows.Forms.Label();
            this.BTN_Sync_CH2 = new System.Windows.Forms.Button();
            this.LAB_Sync_CH2 = new System.Windows.Forms.Label();
            this.BTN_MES_CH2 = new System.Windows.Forms.Button();
            this.LAB_Mesure_CH2 = new System.Windows.Forms.Label();
            this.GBOX_Result_CH2 = new System.Windows.Forms.GroupBox();
            this.LAB_TEST_CNT = new System.Windows.Forms.Label();
            this.LAB_ES_Result_CH2 = new System.Windows.Forms.Label();
            this.LAB_BER_Result_CH2 = new System.Windows.Forms.Label();
            this.LAB_Err_Cnt_Result_CH2 = new System.Windows.Forms.Label();
            this.LAB_Data_Cnt_Result_CH2 = new System.Windows.Forms.Label();
            this.LAB_Mesure_Time_Result_CH2 = new System.Windows.Forms.Label();
            this.BTN_Cnt_Rst_CH2 = new System.Windows.Forms.Button();
            this.GBOX_Monitor_CH2 = new System.Windows.Forms.GroupBox();
            this.PBOX_ERR_CH2 = new System.Windows.Forms.PictureBox();
            this.PBOX_LOS_CH2 = new System.Windows.Forms.PictureBox();
            this.PBOX_ERR_FLG_CH2 = new System.Windows.Forms.PictureBox();
            this.BTN_Flg_Rst_CH2 = new System.Windows.Forms.Button();
            this.GBOX_Setting_CH2 = new System.Windows.Forms.GroupBox();
            this.LAB_LENGTH_CH2_Val = new System.Windows.Forms.Label();
            this.CMB_PN_CH2 = new System.Windows.Forms.ComboBox();
            this.BTN_TX_OUT_CH2 = new System.Windows.Forms.Button();
            this.LAB_Trg = new System.Windows.Forms.Label();
            this.CMB_Trg = new System.Windows.Forms.ComboBox();
            this.LAB_Clock = new System.Windows.Forms.Label();
            this.PAN_Form_Main = new System.Windows.Forms.Panel();
            this.BTN_ProgramPatternSetting = new System.Windows.Forms.Button();
            this.LAB_Program_pattern = new System.Windows.Forms.Label();
            this.GBOX_CH4 = new System.Windows.Forms.GroupBox();
            this.PBOX_Tx_STS_4 = new System.Windows.Forms.PictureBox();
            this.CBOX_ReSync_Mode_CH4 = new System.Windows.Forms.ComboBox();
            this.LAB_ReSync_Mode_CH4 = new System.Windows.Forms.Label();
            this.BTN_MES_CH4 = new System.Windows.Forms.Button();
            this.GBOX_Result_CH4 = new System.Windows.Forms.GroupBox();
            this.LAB_ES_Result_CH4 = new System.Windows.Forms.Label();
            this.LAB_BER_Result_CH4 = new System.Windows.Forms.Label();
            this.LAB_Err_Cnt_Result_CH4 = new System.Windows.Forms.Label();
            this.LAB_Data_Cnt_Result_CH4 = new System.Windows.Forms.Label();
            this.LAB_Mesure_Time_Result_CH4 = new System.Windows.Forms.Label();
            this.BTN_Cnt_Rst_CH4 = new System.Windows.Forms.Button();
            this.GBOX_Monitor_CH4 = new System.Windows.Forms.GroupBox();
            this.BTN_Flg_Rst_CH4 = new System.Windows.Forms.Button();
            this.PBOX_ERR_CH4 = new System.Windows.Forms.PictureBox();
            this.PBOX_LOS_CH4 = new System.Windows.Forms.PictureBox();
            this.PBOX_ERR_FLG_CH4 = new System.Windows.Forms.PictureBox();
            this.GBOX_Setting_CH4 = new System.Windows.Forms.GroupBox();
            this.LAB_LENGTH_CH4_Val = new System.Windows.Forms.Label();
            this.CMB_PN_CH4 = new System.Windows.Forms.ComboBox();
            this.BTN_Sync_CH4 = new System.Windows.Forms.Button();
            this.BTN_TX_OUT_CH4 = new System.Windows.Forms.Button();
            this.LAB_Sync_CH4 = new System.Windows.Forms.Label();
            this.GBOX_CH3 = new System.Windows.Forms.GroupBox();
            this.PBOX_Tx_STS_3 = new System.Windows.Forms.PictureBox();
            this.CBOX_ReSync_Mode_CH3 = new System.Windows.Forms.ComboBox();
            this.LAB_ReSync_Mode_CH3 = new System.Windows.Forms.Label();
            this.BTN_MES_CH3 = new System.Windows.Forms.Button();
            this.GBOX_Result_CH3 = new System.Windows.Forms.GroupBox();
            this.LAB_ES_Result_CH3 = new System.Windows.Forms.Label();
            this.LAB_BER_Result_CH3 = new System.Windows.Forms.Label();
            this.LAB_Err_Cnt_Result_CH3 = new System.Windows.Forms.Label();
            this.LAB_Data_Cnt_Result_CH3 = new System.Windows.Forms.Label();
            this.LAB_Mesure_Time_Result_CH3 = new System.Windows.Forms.Label();
            this.BTN_Cnt_Rst_CH3 = new System.Windows.Forms.Button();
            this.GBOX_Monitor_CH3 = new System.Windows.Forms.GroupBox();
            this.BTN_Flg_Rst_CH3 = new System.Windows.Forms.Button();
            this.PBOX_ERR_CH3 = new System.Windows.Forms.PictureBox();
            this.PBOX_LOS_CH3 = new System.Windows.Forms.PictureBox();
            this.PBOX_ERR_FLG_CH3 = new System.Windows.Forms.PictureBox();
            this.GBOX_Setting_CH3 = new System.Windows.Forms.GroupBox();
            this.LAB_LENGTH_CH3_Val = new System.Windows.Forms.Label();
            this.CMB_PN_CH3 = new System.Windows.Forms.ComboBox();
            this.BTN_Sync_CH3 = new System.Windows.Forms.Button();
            this.BTN_TX_OUT_CH3 = new System.Windows.Forms.Button();
            this.LAB_Sync_CH3 = new System.Windows.Forms.Label();
            this.GBOX_ALL = new System.Windows.Forms.GroupBox();
            this.BTN_ALL_COUNTER_RESET = new System.Windows.Forms.Button();
            this.LAB_ALL_COUNTER = new System.Windows.Forms.Label();
            this.BTN_ALL_FLAG_RESET = new System.Windows.Forms.Button();
            this.LAB_ALL_FLAG = new System.Windows.Forms.Label();
            this.BTN_ALL_RESYNC = new System.Windows.Forms.Button();
            this.LAB_ALL_RESYNC = new System.Windows.Forms.Label();
            this.BTN_ALL_MEASURE = new System.Windows.Forms.Button();
            this.LAB_ALL_MEASURE = new System.Windows.Forms.Label();
            this.BTN_ALL_TX = new System.Windows.Forms.Button();
            this.LAB_ALL_TX_OUT = new System.Windows.Forms.Label();
            this.LAB_COM1_NAME = new System.Windows.Forms.Label();
            this.LAB_COM2_NAME = new System.Windows.Forms.Label();
            LAB_TXout_CH1 = new System.Windows.Forms.Label();
            LAB_PN_CH1 = new System.Windows.Forms.Label();
            LAB_LENGTH_CH1 = new System.Windows.Forms.Label();
            LAB_LOS_CH1 = new System.Windows.Forms.Label();
            LAB_ERR_CH1 = new System.Windows.Forms.Label();
            LAB_Mesure_Time_CH1 = new System.Windows.Forms.Label();
            LAB_Data_Cnt_CH1 = new System.Windows.Forms.Label();
            LAB_Err_Cnt_CH1 = new System.Windows.Forms.Label();
            LAB_BER_CH1 = new System.Windows.Forms.Label();
            LAB_ES_CH1 = new System.Windows.Forms.Label();
            LAB_Mesure_CH1 = new System.Windows.Forms.Label();
            LAB_TXout_CH2 = new System.Windows.Forms.Label();
            LAB_PN_CH2 = new System.Windows.Forms.Label();
            LAB_LENGTH_CH2 = new System.Windows.Forms.Label();
            LAB_LOS_CH2 = new System.Windows.Forms.Label();
            LAB_ERR_CH2 = new System.Windows.Forms.Label();
            LAB_Mesure_Time_CH2 = new System.Windows.Forms.Label();
            LAB_Data_Cnt_CH2 = new System.Windows.Forms.Label();
            LAB_Err_Cnt_CH2 = new System.Windows.Forms.Label();
            LAB_BER_CH2 = new System.Windows.Forms.Label();
            LAB_ES_CH2 = new System.Windows.Forms.Label();
            LAB_Mesure_CH3 = new System.Windows.Forms.Label();
            LAB_ES_CH3 = new System.Windows.Forms.Label();
            LAB_BER_CH3 = new System.Windows.Forms.Label();
            LAB_Err_Cnt_CH3 = new System.Windows.Forms.Label();
            LAB_Data_Cnt_CH3 = new System.Windows.Forms.Label();
            LAB_Mesure_Time_CH3 = new System.Windows.Forms.Label();
            LAB_ERR_CH3 = new System.Windows.Forms.Label();
            LAB_LOS_CH3 = new System.Windows.Forms.Label();
            LAB_LENGTH_CH3 = new System.Windows.Forms.Label();
            LAB_PN_CH3 = new System.Windows.Forms.Label();
            LAB_TXout_CH3 = new System.Windows.Forms.Label();
            LAB_Mesure_CH4 = new System.Windows.Forms.Label();
            LAB_ES_CH4 = new System.Windows.Forms.Label();
            LAB_BER_CH4 = new System.Windows.Forms.Label();
            LAB_Err_Cnt_CH4 = new System.Windows.Forms.Label();
            LAB_Data_Cnt_CH4 = new System.Windows.Forms.Label();
            LAB_Mesure_Time_CH4 = new System.Windows.Forms.Label();
            LAB_ERR_CH4 = new System.Windows.Forms.Label();
            LAB_LOS_CH4 = new System.Windows.Forms.Label();
            LAB_LENGTH_CH4 = new System.Windows.Forms.Label();
            LAB_PN_CH4 = new System.Windows.Forms.Label();
            LAB_TXout_CH4 = new System.Windows.Forms.Label();
            LAB_LENGTH_CH1_unit = new System.Windows.Forms.Label();
            LAB_LENGTH_CH2_unit = new System.Windows.Forms.Label();
            LAB_LENGTH_CH3_unit = new System.Windows.Forms.Label();
            LAB_LENGTH_CH4_unit = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            this.COM_Panel.SuspendLayout();
            this.Ether_Panel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PBOX_ETHER_SYS_ERR)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PBOX_COM_SYS_ERR)).BeginInit();
            this.GBOX_CH1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PBOX_Tx_STS_1)).BeginInit();
            this.GBOX_Result_CH1.SuspendLayout();
            this.GBOX_Monitor_CH1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PBOX_ERR_CH1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PBOX_LOS_CH1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PBOX_ERR_FLG_CH1)).BeginInit();
            this.GBOX_Setting_CH1.SuspendLayout();
            this.GBOX_CH2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PBOX_Tx_STS_2)).BeginInit();
            this.GBOX_Result_CH2.SuspendLayout();
            this.GBOX_Monitor_CH2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PBOX_ERR_CH2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PBOX_LOS_CH2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PBOX_ERR_FLG_CH2)).BeginInit();
            this.GBOX_Setting_CH2.SuspendLayout();
            this.PAN_Form_Main.SuspendLayout();
            this.GBOX_CH4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PBOX_Tx_STS_4)).BeginInit();
            this.GBOX_Result_CH4.SuspendLayout();
            this.GBOX_Monitor_CH4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PBOX_ERR_CH4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PBOX_LOS_CH4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PBOX_ERR_FLG_CH4)).BeginInit();
            this.GBOX_Setting_CH4.SuspendLayout();
            this.GBOX_CH3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PBOX_Tx_STS_3)).BeginInit();
            this.GBOX_Result_CH3.SuspendLayout();
            this.GBOX_Monitor_CH3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PBOX_ERR_CH3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PBOX_LOS_CH3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PBOX_ERR_FLG_CH3)).BeginInit();
            this.GBOX_Setting_CH3.SuspendLayout();
            this.GBOX_ALL.SuspendLayout();
            this.SuspendLayout();
            // 
            // LAB_TXout_CH1
            // 
            LAB_TXout_CH1.AutoSize = true;
            LAB_TXout_CH1.Font = new System.Drawing.Font("Meiryo UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            LAB_TXout_CH1.Location = new System.Drawing.Point(11, 30);
            LAB_TXout_CH1.Name = "LAB_TXout_CH1";
            LAB_TXout_CH1.Size = new System.Drawing.Size(109, 20);
            LAB_TXout_CH1.TabIndex = 11;
            LAB_TXout_CH1.Text = "TX OUTPUT";
            // 
            // LAB_PN_CH1
            // 
            LAB_PN_CH1.AutoSize = true;
            LAB_PN_CH1.Font = new System.Drawing.Font("Meiryo UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            LAB_PN_CH1.Location = new System.Drawing.Point(12, 24);
            LAB_PN_CH1.Name = "LAB_PN_CH1";
            LAB_PN_CH1.Size = new System.Drawing.Size(87, 20);
            LAB_PN_CH1.TabIndex = 13;
            LAB_PN_CH1.Text = "PATTERN";
            // 
            // LAB_LENGTH_CH1
            // 
            LAB_LENGTH_CH1.AutoSize = true;
            LAB_LENGTH_CH1.Font = new System.Drawing.Font("Meiryo UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            LAB_LENGTH_CH1.Location = new System.Drawing.Point(12, 54);
            LAB_LENGTH_CH1.Name = "LAB_LENGTH_CH1";
            LAB_LENGTH_CH1.Size = new System.Drawing.Size(78, 20);
            LAB_LENGTH_CH1.TabIndex = 22;
            LAB_LENGTH_CH1.Text = "LENGTH";
            // 
            // LAB_LOS_CH1
            // 
            LAB_LOS_CH1.AutoSize = true;
            LAB_LOS_CH1.Font = new System.Drawing.Font("Meiryo UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            LAB_LOS_CH1.Location = new System.Drawing.Point(12, 53);
            LAB_LOS_CH1.Name = "LAB_LOS_CH1";
            LAB_LOS_CH1.Size = new System.Drawing.Size(94, 20);
            LAB_LOS_CH1.TabIndex = 13;
            LAB_LOS_CH1.Text = "SYNC LOS";
            // 
            // LAB_ERR_CH1
            // 
            LAB_ERR_CH1.AutoSize = true;
            LAB_ERR_CH1.Font = new System.Drawing.Font("Meiryo UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            LAB_ERR_CH1.Location = new System.Drawing.Point(12, 91);
            LAB_ERR_CH1.Name = "LAB_ERR_CH1";
            LAB_ERR_CH1.Size = new System.Drawing.Size(68, 20);
            LAB_ERR_CH1.TabIndex = 16;
            LAB_ERR_CH1.Text = "ERROR";
            // 
            // LAB_Mesure_Time_CH1
            // 
            LAB_Mesure_Time_CH1.AutoSize = true;
            LAB_Mesure_Time_CH1.Font = new System.Drawing.Font("Meiryo UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            LAB_Mesure_Time_CH1.Location = new System.Drawing.Point(12, 53);
            LAB_Mesure_Time_CH1.Name = "LAB_Mesure_Time_CH1";
            LAB_Mesure_Time_CH1.Size = new System.Drawing.Size(166, 20);
            LAB_Mesure_Time_CH1.TabIndex = 13;
            LAB_Mesure_Time_CH1.Text = "MEASURE TIME(s)";
            // 
            // LAB_Data_Cnt_CH1
            // 
            LAB_Data_Cnt_CH1.AutoSize = true;
            LAB_Data_Cnt_CH1.Font = new System.Drawing.Font("Meiryo UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            LAB_Data_Cnt_CH1.Location = new System.Drawing.Point(12, 86);
            LAB_Data_Cnt_CH1.Name = "LAB_Data_Cnt_CH1";
            LAB_Data_Cnt_CH1.Size = new System.Drawing.Size(121, 20);
            LAB_Data_Cnt_CH1.TabIndex = 15;
            LAB_Data_Cnt_CH1.Text = "DATA COUNT";
            // 
            // LAB_Err_Cnt_CH1
            // 
            LAB_Err_Cnt_CH1.AutoSize = true;
            LAB_Err_Cnt_CH1.Font = new System.Drawing.Font("Meiryo UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            LAB_Err_Cnt_CH1.Location = new System.Drawing.Point(12, 116);
            LAB_Err_Cnt_CH1.Name = "LAB_Err_Cnt_CH1";
            LAB_Err_Cnt_CH1.Size = new System.Drawing.Size(134, 20);
            LAB_Err_Cnt_CH1.TabIndex = 17;
            LAB_Err_Cnt_CH1.Text = "ERROR COUNT";
            // 
            // LAB_BER_CH1
            // 
            LAB_BER_CH1.AutoSize = true;
            LAB_BER_CH1.Font = new System.Drawing.Font("Meiryo UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            LAB_BER_CH1.Location = new System.Drawing.Point(12, 146);
            LAB_BER_CH1.Name = "LAB_BER_CH1";
            LAB_BER_CH1.Size = new System.Drawing.Size(43, 20);
            LAB_BER_CH1.TabIndex = 19;
            LAB_BER_CH1.Text = "BER";
            // 
            // LAB_ES_CH1
            // 
            LAB_ES_CH1.AutoSize = true;
            LAB_ES_CH1.Font = new System.Drawing.Font("Meiryo UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            LAB_ES_CH1.Location = new System.Drawing.Point(12, 177);
            LAB_ES_CH1.Name = "LAB_ES_CH1";
            LAB_ES_CH1.Size = new System.Drawing.Size(48, 20);
            LAB_ES_CH1.TabIndex = 21;
            LAB_ES_CH1.Text = "%ES";
            // 
            // LAB_Mesure_CH1
            // 
            LAB_Mesure_CH1.AutoSize = true;
            LAB_Mesure_CH1.Font = new System.Drawing.Font("Meiryo UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            LAB_Mesure_CH1.Location = new System.Drawing.Point(11, 70);
            LAB_Mesure_CH1.Name = "LAB_Mesure_CH1";
            LAB_Mesure_CH1.Size = new System.Drawing.Size(92, 20);
            LAB_Mesure_CH1.TabIndex = 23;
            LAB_Mesure_CH1.Text = "MEASURE";
            // 
            // LAB_TXout_CH2
            // 
            LAB_TXout_CH2.AutoSize = true;
            LAB_TXout_CH2.Font = new System.Drawing.Font("Meiryo UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            LAB_TXout_CH2.Location = new System.Drawing.Point(6, 30);
            LAB_TXout_CH2.Name = "LAB_TXout_CH2";
            LAB_TXout_CH2.Size = new System.Drawing.Size(109, 20);
            LAB_TXout_CH2.TabIndex = 11;
            LAB_TXout_CH2.Text = "TX OUTPUT";
            // 
            // LAB_PN_CH2
            // 
            LAB_PN_CH2.AutoSize = true;
            LAB_PN_CH2.Font = new System.Drawing.Font("Meiryo UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            LAB_PN_CH2.Location = new System.Drawing.Point(12, 24);
            LAB_PN_CH2.Name = "LAB_PN_CH2";
            LAB_PN_CH2.Size = new System.Drawing.Size(87, 20);
            LAB_PN_CH2.TabIndex = 13;
            LAB_PN_CH2.Text = "PATTERN";
            // 
            // LAB_LENGTH_CH2
            // 
            LAB_LENGTH_CH2.AutoSize = true;
            LAB_LENGTH_CH2.Font = new System.Drawing.Font("Meiryo UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            LAB_LENGTH_CH2.Location = new System.Drawing.Point(12, 52);
            LAB_LENGTH_CH2.Name = "LAB_LENGTH_CH2";
            LAB_LENGTH_CH2.Size = new System.Drawing.Size(78, 20);
            LAB_LENGTH_CH2.TabIndex = 22;
            LAB_LENGTH_CH2.Text = "LENGTH";
            // 
            // LAB_LOS_CH2
            // 
            LAB_LOS_CH2.AutoSize = true;
            LAB_LOS_CH2.Font = new System.Drawing.Font("Meiryo UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            LAB_LOS_CH2.Location = new System.Drawing.Point(12, 53);
            LAB_LOS_CH2.Name = "LAB_LOS_CH2";
            LAB_LOS_CH2.Size = new System.Drawing.Size(94, 20);
            LAB_LOS_CH2.TabIndex = 13;
            LAB_LOS_CH2.Text = "SYNC LOS";
            // 
            // LAB_ERR_CH2
            // 
            LAB_ERR_CH2.AutoSize = true;
            LAB_ERR_CH2.Font = new System.Drawing.Font("Meiryo UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            LAB_ERR_CH2.Location = new System.Drawing.Point(12, 91);
            LAB_ERR_CH2.Name = "LAB_ERR_CH2";
            LAB_ERR_CH2.Size = new System.Drawing.Size(68, 20);
            LAB_ERR_CH2.TabIndex = 16;
            LAB_ERR_CH2.Text = "ERROR";
            // 
            // LAB_Mesure_Time_CH2
            // 
            LAB_Mesure_Time_CH2.AutoSize = true;
            LAB_Mesure_Time_CH2.Font = new System.Drawing.Font("Meiryo UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            LAB_Mesure_Time_CH2.Location = new System.Drawing.Point(12, 53);
            LAB_Mesure_Time_CH2.Name = "LAB_Mesure_Time_CH2";
            LAB_Mesure_Time_CH2.Size = new System.Drawing.Size(166, 20);
            LAB_Mesure_Time_CH2.TabIndex = 13;
            LAB_Mesure_Time_CH2.Text = "MEASURE TIME(s)";
            // 
            // LAB_Data_Cnt_CH2
            // 
            LAB_Data_Cnt_CH2.AutoSize = true;
            LAB_Data_Cnt_CH2.Font = new System.Drawing.Font("Meiryo UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            LAB_Data_Cnt_CH2.Location = new System.Drawing.Point(12, 86);
            LAB_Data_Cnt_CH2.Name = "LAB_Data_Cnt_CH2";
            LAB_Data_Cnt_CH2.Size = new System.Drawing.Size(121, 20);
            LAB_Data_Cnt_CH2.TabIndex = 15;
            LAB_Data_Cnt_CH2.Text = "DATA COUNT";
            // 
            // LAB_Err_Cnt_CH2
            // 
            LAB_Err_Cnt_CH2.AutoSize = true;
            LAB_Err_Cnt_CH2.Font = new System.Drawing.Font("Meiryo UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            LAB_Err_Cnt_CH2.Location = new System.Drawing.Point(12, 116);
            LAB_Err_Cnt_CH2.Name = "LAB_Err_Cnt_CH2";
            LAB_Err_Cnt_CH2.Size = new System.Drawing.Size(134, 20);
            LAB_Err_Cnt_CH2.TabIndex = 17;
            LAB_Err_Cnt_CH2.Text = "ERROR COUNT";
            // 
            // LAB_BER_CH2
            // 
            LAB_BER_CH2.AutoSize = true;
            LAB_BER_CH2.Font = new System.Drawing.Font("Meiryo UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            LAB_BER_CH2.Location = new System.Drawing.Point(12, 146);
            LAB_BER_CH2.Name = "LAB_BER_CH2";
            LAB_BER_CH2.Size = new System.Drawing.Size(43, 20);
            LAB_BER_CH2.TabIndex = 19;
            LAB_BER_CH2.Text = "BER";
            // 
            // LAB_ES_CH2
            // 
            LAB_ES_CH2.AutoSize = true;
            LAB_ES_CH2.Font = new System.Drawing.Font("Meiryo UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            LAB_ES_CH2.Location = new System.Drawing.Point(12, 177);
            LAB_ES_CH2.Name = "LAB_ES_CH2";
            LAB_ES_CH2.Size = new System.Drawing.Size(48, 20);
            LAB_ES_CH2.TabIndex = 21;
            LAB_ES_CH2.Text = "%ES";
            // 
            // LAB_Mesure_CH3
            // 
            LAB_Mesure_CH3.AutoSize = true;
            LAB_Mesure_CH3.Font = new System.Drawing.Font("Meiryo UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            LAB_Mesure_CH3.Location = new System.Drawing.Point(11, 70);
            LAB_Mesure_CH3.Name = "LAB_Mesure_CH3";
            LAB_Mesure_CH3.Size = new System.Drawing.Size(92, 20);
            LAB_Mesure_CH3.TabIndex = 23;
            LAB_Mesure_CH3.Text = "MEASURE";
            // 
            // LAB_ES_CH3
            // 
            LAB_ES_CH3.AutoSize = true;
            LAB_ES_CH3.Font = new System.Drawing.Font("Meiryo UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            LAB_ES_CH3.Location = new System.Drawing.Point(12, 177);
            LAB_ES_CH3.Name = "LAB_ES_CH3";
            LAB_ES_CH3.Size = new System.Drawing.Size(48, 20);
            LAB_ES_CH3.TabIndex = 21;
            LAB_ES_CH3.Text = "%ES";
            // 
            // LAB_BER_CH3
            // 
            LAB_BER_CH3.AutoSize = true;
            LAB_BER_CH3.Font = new System.Drawing.Font("Meiryo UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            LAB_BER_CH3.Location = new System.Drawing.Point(12, 146);
            LAB_BER_CH3.Name = "LAB_BER_CH3";
            LAB_BER_CH3.Size = new System.Drawing.Size(43, 20);
            LAB_BER_CH3.TabIndex = 19;
            LAB_BER_CH3.Text = "BER";
            // 
            // LAB_Err_Cnt_CH3
            // 
            LAB_Err_Cnt_CH3.AutoSize = true;
            LAB_Err_Cnt_CH3.Font = new System.Drawing.Font("Meiryo UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            LAB_Err_Cnt_CH3.Location = new System.Drawing.Point(12, 116);
            LAB_Err_Cnt_CH3.Name = "LAB_Err_Cnt_CH3";
            LAB_Err_Cnt_CH3.Size = new System.Drawing.Size(134, 20);
            LAB_Err_Cnt_CH3.TabIndex = 17;
            LAB_Err_Cnt_CH3.Text = "ERROR COUNT";
            // 
            // LAB_Data_Cnt_CH3
            // 
            LAB_Data_Cnt_CH3.AutoSize = true;
            LAB_Data_Cnt_CH3.Font = new System.Drawing.Font("Meiryo UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            LAB_Data_Cnt_CH3.Location = new System.Drawing.Point(12, 86);
            LAB_Data_Cnt_CH3.Name = "LAB_Data_Cnt_CH3";
            LAB_Data_Cnt_CH3.Size = new System.Drawing.Size(121, 20);
            LAB_Data_Cnt_CH3.TabIndex = 15;
            LAB_Data_Cnt_CH3.Text = "DATA COUNT";
            // 
            // LAB_Mesure_Time_CH3
            // 
            LAB_Mesure_Time_CH3.AutoSize = true;
            LAB_Mesure_Time_CH3.Font = new System.Drawing.Font("Meiryo UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            LAB_Mesure_Time_CH3.Location = new System.Drawing.Point(12, 53);
            LAB_Mesure_Time_CH3.Name = "LAB_Mesure_Time_CH3";
            LAB_Mesure_Time_CH3.Size = new System.Drawing.Size(166, 20);
            LAB_Mesure_Time_CH3.TabIndex = 13;
            LAB_Mesure_Time_CH3.Text = "MEASURE TIME(s)";
            // 
            // LAB_ERR_CH3
            // 
            LAB_ERR_CH3.AutoSize = true;
            LAB_ERR_CH3.Font = new System.Drawing.Font("Meiryo UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            LAB_ERR_CH3.Location = new System.Drawing.Point(12, 91);
            LAB_ERR_CH3.Name = "LAB_ERR_CH3";
            LAB_ERR_CH3.Size = new System.Drawing.Size(68, 20);
            LAB_ERR_CH3.TabIndex = 16;
            LAB_ERR_CH3.Text = "ERROR";
            // 
            // LAB_LOS_CH3
            // 
            LAB_LOS_CH3.AutoSize = true;
            LAB_LOS_CH3.Font = new System.Drawing.Font("Meiryo UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            LAB_LOS_CH3.Location = new System.Drawing.Point(12, 53);
            LAB_LOS_CH3.Name = "LAB_LOS_CH3";
            LAB_LOS_CH3.Size = new System.Drawing.Size(94, 20);
            LAB_LOS_CH3.TabIndex = 13;
            LAB_LOS_CH3.Text = "SYNC LOS";
            // 
            // LAB_LENGTH_CH3
            // 
            LAB_LENGTH_CH3.AutoSize = true;
            LAB_LENGTH_CH3.Font = new System.Drawing.Font("Meiryo UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            LAB_LENGTH_CH3.Location = new System.Drawing.Point(12, 54);
            LAB_LENGTH_CH3.Name = "LAB_LENGTH_CH3";
            LAB_LENGTH_CH3.Size = new System.Drawing.Size(78, 20);
            LAB_LENGTH_CH3.TabIndex = 22;
            LAB_LENGTH_CH3.Text = "LENGTH";
            // 
            // LAB_PN_CH3
            // 
            LAB_PN_CH3.AutoSize = true;
            LAB_PN_CH3.Font = new System.Drawing.Font("Meiryo UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            LAB_PN_CH3.Location = new System.Drawing.Point(12, 24);
            LAB_PN_CH3.Name = "LAB_PN_CH3";
            LAB_PN_CH3.Size = new System.Drawing.Size(87, 20);
            LAB_PN_CH3.TabIndex = 13;
            LAB_PN_CH3.Text = "PATTERN";
            // 
            // LAB_TXout_CH3
            // 
            LAB_TXout_CH3.AutoSize = true;
            LAB_TXout_CH3.Font = new System.Drawing.Font("Meiryo UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            LAB_TXout_CH3.Location = new System.Drawing.Point(11, 30);
            LAB_TXout_CH3.Name = "LAB_TXout_CH3";
            LAB_TXout_CH3.Size = new System.Drawing.Size(109, 20);
            LAB_TXout_CH3.TabIndex = 11;
            LAB_TXout_CH3.Text = "TX OUTPUT";
            // 
            // LAB_Mesure_CH4
            // 
            LAB_Mesure_CH4.AutoSize = true;
            LAB_Mesure_CH4.Font = new System.Drawing.Font("Meiryo UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            LAB_Mesure_CH4.Location = new System.Drawing.Point(11, 70);
            LAB_Mesure_CH4.Name = "LAB_Mesure_CH4";
            LAB_Mesure_CH4.Size = new System.Drawing.Size(92, 20);
            LAB_Mesure_CH4.TabIndex = 23;
            LAB_Mesure_CH4.Text = "MEASURE";
            // 
            // LAB_ES_CH4
            // 
            LAB_ES_CH4.AutoSize = true;
            LAB_ES_CH4.Font = new System.Drawing.Font("Meiryo UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            LAB_ES_CH4.Location = new System.Drawing.Point(12, 177);
            LAB_ES_CH4.Name = "LAB_ES_CH4";
            LAB_ES_CH4.Size = new System.Drawing.Size(48, 20);
            LAB_ES_CH4.TabIndex = 21;
            LAB_ES_CH4.Text = "%ES";
            // 
            // LAB_BER_CH4
            // 
            LAB_BER_CH4.AutoSize = true;
            LAB_BER_CH4.Font = new System.Drawing.Font("Meiryo UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            LAB_BER_CH4.Location = new System.Drawing.Point(12, 146);
            LAB_BER_CH4.Name = "LAB_BER_CH4";
            LAB_BER_CH4.Size = new System.Drawing.Size(43, 20);
            LAB_BER_CH4.TabIndex = 19;
            LAB_BER_CH4.Text = "BER";
            // 
            // LAB_Err_Cnt_CH4
            // 
            LAB_Err_Cnt_CH4.AutoSize = true;
            LAB_Err_Cnt_CH4.Font = new System.Drawing.Font("Meiryo UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            LAB_Err_Cnt_CH4.Location = new System.Drawing.Point(12, 116);
            LAB_Err_Cnt_CH4.Name = "LAB_Err_Cnt_CH4";
            LAB_Err_Cnt_CH4.Size = new System.Drawing.Size(134, 20);
            LAB_Err_Cnt_CH4.TabIndex = 17;
            LAB_Err_Cnt_CH4.Text = "ERROR COUNT";
            // 
            // LAB_Data_Cnt_CH4
            // 
            LAB_Data_Cnt_CH4.AutoSize = true;
            LAB_Data_Cnt_CH4.Font = new System.Drawing.Font("Meiryo UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            LAB_Data_Cnt_CH4.Location = new System.Drawing.Point(12, 86);
            LAB_Data_Cnt_CH4.Name = "LAB_Data_Cnt_CH4";
            LAB_Data_Cnt_CH4.Size = new System.Drawing.Size(121, 20);
            LAB_Data_Cnt_CH4.TabIndex = 15;
            LAB_Data_Cnt_CH4.Text = "DATA COUNT";
            // 
            // LAB_Mesure_Time_CH4
            // 
            LAB_Mesure_Time_CH4.AutoSize = true;
            LAB_Mesure_Time_CH4.Font = new System.Drawing.Font("Meiryo UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            LAB_Mesure_Time_CH4.Location = new System.Drawing.Point(12, 53);
            LAB_Mesure_Time_CH4.Name = "LAB_Mesure_Time_CH4";
            LAB_Mesure_Time_CH4.Size = new System.Drawing.Size(166, 20);
            LAB_Mesure_Time_CH4.TabIndex = 13;
            LAB_Mesure_Time_CH4.Text = "MEASURE TIME(s)";
            // 
            // LAB_ERR_CH4
            // 
            LAB_ERR_CH4.AutoSize = true;
            LAB_ERR_CH4.Font = new System.Drawing.Font("Meiryo UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            LAB_ERR_CH4.Location = new System.Drawing.Point(12, 91);
            LAB_ERR_CH4.Name = "LAB_ERR_CH4";
            LAB_ERR_CH4.Size = new System.Drawing.Size(68, 20);
            LAB_ERR_CH4.TabIndex = 16;
            LAB_ERR_CH4.Text = "ERROR";
            // 
            // LAB_LOS_CH4
            // 
            LAB_LOS_CH4.AutoSize = true;
            LAB_LOS_CH4.Font = new System.Drawing.Font("Meiryo UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            LAB_LOS_CH4.Location = new System.Drawing.Point(12, 53);
            LAB_LOS_CH4.Name = "LAB_LOS_CH4";
            LAB_LOS_CH4.Size = new System.Drawing.Size(94, 20);
            LAB_LOS_CH4.TabIndex = 13;
            LAB_LOS_CH4.Text = "SYNC LOS";
            // 
            // LAB_LENGTH_CH4
            // 
            LAB_LENGTH_CH4.AutoSize = true;
            LAB_LENGTH_CH4.Font = new System.Drawing.Font("Meiryo UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            LAB_LENGTH_CH4.Location = new System.Drawing.Point(12, 54);
            LAB_LENGTH_CH4.Name = "LAB_LENGTH_CH4";
            LAB_LENGTH_CH4.Size = new System.Drawing.Size(78, 20);
            LAB_LENGTH_CH4.TabIndex = 22;
            LAB_LENGTH_CH4.Text = "LENGTH";
            // 
            // LAB_PN_CH4
            // 
            LAB_PN_CH4.AutoSize = true;
            LAB_PN_CH4.Font = new System.Drawing.Font("Meiryo UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            LAB_PN_CH4.Location = new System.Drawing.Point(12, 24);
            LAB_PN_CH4.Name = "LAB_PN_CH4";
            LAB_PN_CH4.Size = new System.Drawing.Size(87, 20);
            LAB_PN_CH4.TabIndex = 13;
            LAB_PN_CH4.Text = "PATTERN";
            // 
            // LAB_TXout_CH4
            // 
            LAB_TXout_CH4.AutoSize = true;
            LAB_TXout_CH4.Font = new System.Drawing.Font("Meiryo UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            LAB_TXout_CH4.Location = new System.Drawing.Point(11, 30);
            LAB_TXout_CH4.Name = "LAB_TXout_CH4";
            LAB_TXout_CH4.Size = new System.Drawing.Size(109, 20);
            LAB_TXout_CH4.TabIndex = 11;
            LAB_TXout_CH4.Text = "TX OUTPUT";
            // 
            // LAB_LENGTH_CH1_unit
            // 
            LAB_LENGTH_CH1_unit.Font = new System.Drawing.Font("Meiryo UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            LAB_LENGTH_CH1_unit.Location = new System.Drawing.Point(372, 281);
            LAB_LENGTH_CH1_unit.Name = "LAB_LENGTH_CH1_unit";
            LAB_LENGTH_CH1_unit.Size = new System.Drawing.Size(36, 20);
            LAB_LENGTH_CH1_unit.TabIndex = 27;
            LAB_LENGTH_CH1_unit.Text = "bit";
            // 
            // LAB_LENGTH_CH2_unit
            // 
            LAB_LENGTH_CH2_unit.Font = new System.Drawing.Font("Meiryo UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            LAB_LENGTH_CH2_unit.Location = new System.Drawing.Point(301, 54);
            LAB_LENGTH_CH2_unit.Name = "LAB_LENGTH_CH2_unit";
            LAB_LENGTH_CH2_unit.Size = new System.Drawing.Size(36, 20);
            LAB_LENGTH_CH2_unit.TabIndex = 28;
            LAB_LENGTH_CH2_unit.Text = "bit";
            // 
            // LAB_LENGTH_CH3_unit
            // 
            LAB_LENGTH_CH3_unit.Font = new System.Drawing.Font("Meiryo UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            LAB_LENGTH_CH3_unit.Location = new System.Drawing.Point(301, 54);
            LAB_LENGTH_CH3_unit.Name = "LAB_LENGTH_CH3_unit";
            LAB_LENGTH_CH3_unit.Size = new System.Drawing.Size(36, 20);
            LAB_LENGTH_CH3_unit.TabIndex = 29;
            LAB_LENGTH_CH3_unit.Text = "bit";
            // 
            // LAB_LENGTH_CH4_unit
            // 
            LAB_LENGTH_CH4_unit.Font = new System.Drawing.Font("Meiryo UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            LAB_LENGTH_CH4_unit.Location = new System.Drawing.Point(301, 52);
            LAB_LENGTH_CH4_unit.Name = "LAB_LENGTH_CH4_unit";
            LAB_LENGTH_CH4_unit.Size = new System.Drawing.Size(36, 20);
            LAB_LENGTH_CH4_unit.TabIndex = 30;
            LAB_LENGTH_CH4_unit.Text = "bit";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem1,
            this.toolTToolStripMenuItem,
            this.ヘルプHToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1729, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.終了ToolStripMenuItem1});
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(51, 20);
            this.toolStripMenuItem1.Text = "File(F)";
            // 
            // 終了ToolStripMenuItem1
            // 
            this.終了ToolStripMenuItem1.Name = "終了ToolStripMenuItem1";
            this.終了ToolStripMenuItem1.Size = new System.Drawing.Size(108, 22);
            this.終了ToolStripMenuItem1.Text = "Exit(X)";
            this.終了ToolStripMenuItem1.Click += new System.EventHandler(this.終了ToolStripMenuItem1_Click);
            // 
            // toolTToolStripMenuItem
            // 
            this.toolTToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.netwrokSetNToolStripMenuItem,
            this.programPatternSetPToolStripMenuItem});
            this.toolTToolStripMenuItem.Name = "toolTToolStripMenuItem";
            this.toolTToolStripMenuItem.Size = new System.Drawing.Size(55, 20);
            this.toolTToolStripMenuItem.Text = "Tool(T)";
            // 
            // netwrokSetNToolStripMenuItem
            // 
            this.netwrokSetNToolStripMenuItem.Name = "netwrokSetNToolStripMenuItem";
            this.netwrokSetNToolStripMenuItem.Size = new System.Drawing.Size(194, 22);
            this.netwrokSetNToolStripMenuItem.Text = "Netwrok Set(N)";
            this.netwrokSetNToolStripMenuItem.Click += new System.EventHandler(this.netwrokSetNToolStripMenuItem_Click);
            // 
            // programPatternSetPToolStripMenuItem
            // 
            this.programPatternSetPToolStripMenuItem.Name = "programPatternSetPToolStripMenuItem";
            this.programPatternSetPToolStripMenuItem.Size = new System.Drawing.Size(194, 22);
            this.programPatternSetPToolStripMenuItem.Text = "Program Pattern Set(P)";
            this.programPatternSetPToolStripMenuItem.Click += new System.EventHandler(this.programPatternSetPToolStripMenuItem_Click_1);
            // 
            // ヘルプHToolStripMenuItem
            // 
            this.ヘルプHToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ToolStripMenuItem_Ver});
            this.ヘルプHToolStripMenuItem.Name = "ヘルプHToolStripMenuItem";
            this.ヘルプHToolStripMenuItem.Size = new System.Drawing.Size(61, 20);
            this.ヘルプHToolStripMenuItem.Text = "Help(H)";
            // 
            // ToolStripMenuItem_Ver
            // 
            this.ToolStripMenuItem_Ver.Name = "ToolStripMenuItem_Ver";
            this.ToolStripMenuItem_Ver.Size = new System.Drawing.Size(193, 22);
            this.ToolStripMenuItem_Ver.Text = "Version Information(A)";
            this.ToolStripMenuItem_Ver.Click += new System.EventHandler(this.バージョン情報VToolStripMenuItem_Click);
            // 
            // COM_Panel
            // 
            this.COM_Panel.Controls.Add(this.Ether_Panel);
            this.COM_Panel.Controls.Add(this.LAB_COM2_NAME);
            this.COM_Panel.Controls.Add(this.LAB_COM1_NAME);
            this.COM_Panel.Controls.Add(this.CBOX_COM2);
            this.COM_Panel.Controls.Add(this.LAB_COM2);
            this.COM_Panel.Controls.Add(this.PBOX_COM_SYS_ERR);
            this.COM_Panel.Controls.Add(this.LAB_COM_SYS_ERR);
            this.COM_Panel.Controls.Add(this.LAB_COM1);
            this.COM_Panel.Controls.Add(this.BTN_COM_Connect);
            this.COM_Panel.Controls.Add(this.CBOX_COM1);
            this.COM_Panel.Controls.Add(this.BTN_COM_IF_CHG);
            this.COM_Panel.Location = new System.Drawing.Point(0, 30);
            this.COM_Panel.Name = "COM_Panel";
            this.COM_Panel.Size = new System.Drawing.Size(1164, 63);
            this.COM_Panel.TabIndex = 1;
            // 
            // Ether_Panel
            // 
            this.Ether_Panel.Controls.Add(this.TXT_IPAdr2);
            this.Ether_Panel.Controls.Add(this.LAB_Ether2);
            this.Ether_Panel.Controls.Add(this.BTN_ETH_IF_CHG);
            this.Ether_Panel.Controls.Add(this.PBOX_ETHER_SYS_ERR);
            this.Ether_Panel.Controls.Add(this.LAB_ETHER_SYS_ERR);
            this.Ether_Panel.Controls.Add(this.BTN_ETHER_Connect);
            this.Ether_Panel.Controls.Add(this.TXT_IPAdr1);
            this.Ether_Panel.Controls.Add(this.LAB_Ether1);
            this.Ether_Panel.Location = new System.Drawing.Point(1, 0);
            this.Ether_Panel.Name = "Ether_Panel";
            this.Ether_Panel.Size = new System.Drawing.Size(1164, 63);
            this.Ether_Panel.TabIndex = 2;
            this.Ether_Panel.Visible = false;
            // 
            // TXT_IPAdr2
            // 
            this.TXT_IPAdr2.Font = new System.Drawing.Font("Meiryo UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TXT_IPAdr2.Location = new System.Drawing.Point(605, 20);
            this.TXT_IPAdr2.Name = "TXT_IPAdr2";
            this.TXT_IPAdr2.Size = new System.Drawing.Size(164, 28);
            this.TXT_IPAdr2.TabIndex = 10;
            this.TXT_IPAdr2.Text = "192.168.1.224";
            // 
            // LAB_Ether2
            // 
            this.LAB_Ether2.AutoSize = true;
            this.LAB_Ether2.Font = new System.Drawing.Font("Meiryo UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.LAB_Ether2.Location = new System.Drawing.Point(407, 23);
            this.LAB_Ether2.Name = "LAB_Ether2";
            this.LAB_Ether2.Size = new System.Drawing.Size(192, 20);
            this.LAB_Ether2.TabIndex = 9;
            this.LAB_Ether2.Text = "ETHERNET IP(CH3-4)";
            // 
            // BTN_ETH_IF_CHG
            // 
            this.BTN_ETH_IF_CHG.BackColor = System.Drawing.SystemColors.Control;
            this.BTN_ETH_IF_CHG.Font = new System.Drawing.Font("Meiryo UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.BTN_ETH_IF_CHG.Location = new System.Drawing.Point(986, 13);
            this.BTN_ETH_IF_CHG.Name = "BTN_ETH_IF_CHG";
            this.BTN_ETH_IF_CHG.Size = new System.Drawing.Size(165, 36);
            this.BTN_ETH_IF_CHG.TabIndex = 7;
            this.BTN_ETH_IF_CHG.Text = "IF CHANGE";
            this.BTN_ETH_IF_CHG.UseVisualStyleBackColor = false;
            this.BTN_ETH_IF_CHG.Click += new System.EventHandler(this.BTN_ETH_IF_CHG_Click);
            // 
            // PBOX_ETHER_SYS_ERR
            // 
            this.PBOX_ETHER_SYS_ERR.ErrorImage = ((System.Drawing.Image)(resources.GetObject("PBOX_ETHER_SYS_ERR.ErrorImage")));
            this.PBOX_ETHER_SYS_ERR.Image = ((System.Drawing.Image)(resources.GetObject("PBOX_ETHER_SYS_ERR.Image")));
            this.PBOX_ETHER_SYS_ERR.InitialImage = global::BERT.Properties.Resources.led_green;
            this.PBOX_ETHER_SYS_ERR.Location = new System.Drawing.Point(1308, 15);
            this.PBOX_ETHER_SYS_ERR.Name = "PBOX_ETHER_SYS_ERR";
            this.PBOX_ETHER_SYS_ERR.Size = new System.Drawing.Size(32, 32);
            this.PBOX_ETHER_SYS_ERR.TabIndex = 8;
            this.PBOX_ETHER_SYS_ERR.TabStop = false;
            this.PBOX_ETHER_SYS_ERR.Visible = false;
            // 
            // LAB_ETHER_SYS_ERR
            // 
            this.LAB_ETHER_SYS_ERR.AutoSize = true;
            this.LAB_ETHER_SYS_ERR.Font = new System.Drawing.Font("Meiryo UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.LAB_ETHER_SYS_ERR.Location = new System.Drawing.Point(1153, 21);
            this.LAB_ETHER_SYS_ERR.Name = "LAB_ETHER_SYS_ERR";
            this.LAB_ETHER_SYS_ERR.Size = new System.Drawing.Size(142, 20);
            this.LAB_ETHER_SYS_ERR.TabIndex = 7;
            this.LAB_ETHER_SYS_ERR.Text = "SYSTEM ERROR";
            this.LAB_ETHER_SYS_ERR.Visible = false;
            // 
            // BTN_ETHER_Connect
            // 
            this.BTN_ETHER_Connect.BackColor = System.Drawing.SystemColors.Control;
            this.BTN_ETHER_Connect.Font = new System.Drawing.Font("Meiryo UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.BTN_ETHER_Connect.Location = new System.Drawing.Point(815, 13);
            this.BTN_ETHER_Connect.Name = "BTN_ETHER_Connect";
            this.BTN_ETHER_Connect.Size = new System.Drawing.Size(156, 36);
            this.BTN_ETHER_Connect.TabIndex = 4;
            this.BTN_ETHER_Connect.Text = "CONNECT";
            this.BTN_ETHER_Connect.UseVisualStyleBackColor = false;
            this.BTN_ETHER_Connect.Click += new System.EventHandler(this.BTN_ETHER_Connect_Click);
            // 
            // TXT_IPAdr1
            // 
            this.TXT_IPAdr1.Font = new System.Drawing.Font("Meiryo UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TXT_IPAdr1.Location = new System.Drawing.Point(210, 20);
            this.TXT_IPAdr1.Name = "TXT_IPAdr1";
            this.TXT_IPAdr1.Size = new System.Drawing.Size(164, 28);
            this.TXT_IPAdr1.TabIndex = 1;
            this.TXT_IPAdr1.Text = "192.168.1.223";
            // 
            // LAB_Ether1
            // 
            this.LAB_Ether1.AutoSize = true;
            this.LAB_Ether1.Font = new System.Drawing.Font("Meiryo UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.LAB_Ether1.Location = new System.Drawing.Point(12, 23);
            this.LAB_Ether1.Name = "LAB_Ether1";
            this.LAB_Ether1.Size = new System.Drawing.Size(192, 20);
            this.LAB_Ether1.TabIndex = 0;
            this.LAB_Ether1.Text = "ETHERNET IP(CH1-2)";
            // 
            // CBOX_COM2
            // 
            this.CBOX_COM2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CBOX_COM2.Font = new System.Drawing.Font("MS UI Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.CBOX_COM2.FormattingEnabled = true;
            this.CBOX_COM2.Location = new System.Drawing.Point(520, 24);
            this.CBOX_COM2.Name = "CBOX_COM2";
            this.CBOX_COM2.Size = new System.Drawing.Size(121, 24);
            this.CBOX_COM2.TabIndex = 8;
            // 
            // LAB_COM2
            // 
            this.LAB_COM2.AutoSize = true;
            this.LAB_COM2.Font = new System.Drawing.Font("Meiryo UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.LAB_COM2.Location = new System.Drawing.Point(343, 26);
            this.LAB_COM2.Name = "LAB_COM2";
            this.LAB_COM2.Size = new System.Drawing.Size(185, 20);
            this.LAB_COM2.TabIndex = 7;
            this.LAB_COM2.Text = "COM PORT(CH3-4) : ";
            // 
            // PBOX_COM_SYS_ERR
            // 
            this.PBOX_COM_SYS_ERR.ErrorImage = ((System.Drawing.Image)(resources.GetObject("PBOX_COM_SYS_ERR.ErrorImage")));
            this.PBOX_COM_SYS_ERR.Image = ((System.Drawing.Image)(resources.GetObject("PBOX_COM_SYS_ERR.Image")));
            this.PBOX_COM_SYS_ERR.InitialImage = ((System.Drawing.Image)(resources.GetObject("PBOX_COM_SYS_ERR.InitialImage")));
            this.PBOX_COM_SYS_ERR.Location = new System.Drawing.Point(1284, 18);
            this.PBOX_COM_SYS_ERR.Name = "PBOX_COM_SYS_ERR";
            this.PBOX_COM_SYS_ERR.Size = new System.Drawing.Size(32, 32);
            this.PBOX_COM_SYS_ERR.TabIndex = 5;
            this.PBOX_COM_SYS_ERR.TabStop = false;
            this.PBOX_COM_SYS_ERR.Visible = false;
            // 
            // LAB_COM_SYS_ERR
            // 
            this.LAB_COM_SYS_ERR.AutoSize = true;
            this.LAB_COM_SYS_ERR.Font = new System.Drawing.Font("Meiryo UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.LAB_COM_SYS_ERR.Location = new System.Drawing.Point(1136, 24);
            this.LAB_COM_SYS_ERR.Name = "LAB_COM_SYS_ERR";
            this.LAB_COM_SYS_ERR.Size = new System.Drawing.Size(142, 20);
            this.LAB_COM_SYS_ERR.TabIndex = 4;
            this.LAB_COM_SYS_ERR.Text = "SYSTEM ERROR";
            this.LAB_COM_SYS_ERR.Visible = false;
            // 
            // LAB_COM1
            // 
            this.LAB_COM1.AutoSize = true;
            this.LAB_COM1.Font = new System.Drawing.Font("Meiryo UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.LAB_COM1.Location = new System.Drawing.Point(18, 26);
            this.LAB_COM1.Name = "LAB_COM1";
            this.LAB_COM1.Size = new System.Drawing.Size(185, 20);
            this.LAB_COM1.TabIndex = 0;
            this.LAB_COM1.Text = "COM PORT(CH1-2) : ";
            // 
            // BTN_COM_Connect
            // 
            this.BTN_COM_Connect.BackColor = System.Drawing.SystemColors.Control;
            this.BTN_COM_Connect.Font = new System.Drawing.Font("Meiryo UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.BTN_COM_Connect.Location = new System.Drawing.Point(709, 16);
            this.BTN_COM_Connect.Name = "BTN_COM_Connect";
            this.BTN_COM_Connect.Size = new System.Drawing.Size(165, 36);
            this.BTN_COM_Connect.TabIndex = 2;
            this.BTN_COM_Connect.Text = "CONNECT";
            this.BTN_COM_Connect.UseVisualStyleBackColor = false;
            this.BTN_COM_Connect.Click += new System.EventHandler(this.COM_Connect_BTN_Click);
            // 
            // CBOX_COM1
            // 
            this.CBOX_COM1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CBOX_COM1.Font = new System.Drawing.Font("MS UI Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.CBOX_COM1.FormattingEnabled = true;
            this.CBOX_COM1.Location = new System.Drawing.Point(193, 26);
            this.CBOX_COM1.Name = "CBOX_COM1";
            this.CBOX_COM1.Size = new System.Drawing.Size(121, 24);
            this.CBOX_COM1.TabIndex = 1;
            this.CBOX_COM1.SelectedIndexChanged += new System.EventHandler(this.CBOX_COM_SelectedIndexChanged);
            // 
            // BTN_COM_IF_CHG
            // 
            this.BTN_COM_IF_CHG.BackColor = System.Drawing.SystemColors.Control;
            this.BTN_COM_IF_CHG.Font = new System.Drawing.Font("Meiryo UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.BTN_COM_IF_CHG.Location = new System.Drawing.Point(884, 16);
            this.BTN_COM_IF_CHG.Name = "BTN_COM_IF_CHG";
            this.BTN_COM_IF_CHG.Size = new System.Drawing.Size(165, 36);
            this.BTN_COM_IF_CHG.TabIndex = 6;
            this.BTN_COM_IF_CHG.Text = "IF CHANGE";
            this.BTN_COM_IF_CHG.UseVisualStyleBackColor = false;
            this.BTN_COM_IF_CHG.Click += new System.EventHandler(this.BTN_COM_IF_CHG_Click);
            // 
            // GetResult
            // 
            this.GetResult.Interval = 500;
            this.GetResult.Tick += new System.EventHandler(this.GetResult_Tick);
            // 
            // LAB_Bitrate
            // 
            this.LAB_Bitrate.AutoSize = true;
            this.LAB_Bitrate.Font = new System.Drawing.Font("Meiryo UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.LAB_Bitrate.Location = new System.Drawing.Point(49, 25);
            this.LAB_Bitrate.Name = "LAB_Bitrate";
            this.LAB_Bitrate.Size = new System.Drawing.Size(68, 20);
            this.LAB_Bitrate.TabIndex = 1;
            this.LAB_Bitrate.Text = "Bitrate";
            this.LAB_Bitrate.UseMnemonic = false;
            // 
            // GBOX_CH1
            // 
            this.GBOX_CH1.Controls.Add(this.PBOX_Tx_STS_1);
            this.GBOX_CH1.Controls.Add(this.CBOX_ReSync_Mode_CH1);
            this.GBOX_CH1.Controls.Add(this.LAB_ReSync_Mode_CH1);
            this.GBOX_CH1.Controls.Add(this.BTN_MES_CH1);
            this.GBOX_CH1.Controls.Add(LAB_Mesure_CH1);
            this.GBOX_CH1.Controls.Add(this.GBOX_Result_CH1);
            this.GBOX_CH1.Controls.Add(this.GBOX_Monitor_CH1);
            this.GBOX_CH1.Controls.Add(this.GBOX_Setting_CH1);
            this.GBOX_CH1.Controls.Add(this.BTN_Sync_CH1);
            this.GBOX_CH1.Controls.Add(this.BTN_TX_OUT_CH1);
            this.GBOX_CH1.Controls.Add(this.LAB_Sync_CH1);
            this.GBOX_CH1.Controls.Add(LAB_TXout_CH1);
            this.GBOX_CH1.Font = new System.Drawing.Font("Meiryo UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.GBOX_CH1.Location = new System.Drawing.Point(48, 59);
            this.GBOX_CH1.Name = "GBOX_CH1";
            this.GBOX_CH1.Size = new System.Drawing.Size(385, 603);
            this.GBOX_CH1.TabIndex = 10;
            this.GBOX_CH1.TabStop = false;
            this.GBOX_CH1.Text = "CH1";
            // 
            // PBOX_Tx_STS_1
            // 
            this.PBOX_Tx_STS_1.ErrorImage = global::BERT.Properties.Resources.led_red;
            this.PBOX_Tx_STS_1.Image = global::BERT.Properties.Resources.led_off;
            this.PBOX_Tx_STS_1.InitialImage = global::BERT.Properties.Resources.led_green;
            this.PBOX_Tx_STS_1.Location = new System.Drawing.Point(187, 24);
            this.PBOX_Tx_STS_1.Name = "PBOX_Tx_STS_1";
            this.PBOX_Tx_STS_1.Size = new System.Drawing.Size(32, 32);
            this.PBOX_Tx_STS_1.TabIndex = 18;
            this.PBOX_Tx_STS_1.TabStop = false;
            this.PBOX_Tx_STS_1.Visible = false;
            // 
            // CBOX_ReSync_Mode_CH1
            // 
            this.CBOX_ReSync_Mode_CH1.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.CBOX_ReSync_Mode_CH1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CBOX_ReSync_Mode_CH1.Font = new System.Drawing.Font("MS UI Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.CBOX_ReSync_Mode_CH1.FormattingEnabled = true;
            this.CBOX_ReSync_Mode_CH1.Items.AddRange(new object[] {
            "Auto",
            "Manual"});
            this.CBOX_ReSync_Mode_CH1.Location = new System.Drawing.Point(227, 103);
            this.CBOX_ReSync_Mode_CH1.Name = "CBOX_ReSync_Mode_CH1";
            this.CBOX_ReSync_Mode_CH1.Size = new System.Drawing.Size(102, 24);
            this.CBOX_ReSync_Mode_CH1.TabIndex = 24;
            this.CBOX_ReSync_Mode_CH1.DrawItem += new System.Windows.Forms.DrawItemEventHandler(this.CBOX_ReSync_Mode_CH1_DrawItem);
            this.CBOX_ReSync_Mode_CH1.SelectedIndexChanged += new System.EventHandler(this.CBOX_ReSync_Mode_CH1_SelectedIndexChanged);
            // 
            // LAB_ReSync_Mode_CH1
            // 
            this.LAB_ReSync_Mode_CH1.AutoSize = true;
            this.LAB_ReSync_Mode_CH1.Font = new System.Drawing.Font("Meiryo UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.LAB_ReSync_Mode_CH1.Location = new System.Drawing.Point(11, 106);
            this.LAB_ReSync_Mode_CH1.Name = "LAB_ReSync_Mode_CH1";
            this.LAB_ReSync_Mode_CH1.Size = new System.Drawing.Size(133, 20);
            this.LAB_ReSync_Mode_CH1.TabIndex = 24;
            this.LAB_ReSync_Mode_CH1.Text = "RESYNC MODE";
            this.LAB_ReSync_Mode_CH1.UseMnemonic = false;
            // 
            // BTN_MES_CH1
            // 
            this.BTN_MES_CH1.BackColor = System.Drawing.SystemColors.Control;
            this.BTN_MES_CH1.Font = new System.Drawing.Font("Meiryo UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.BTN_MES_CH1.Location = new System.Drawing.Point(227, 62);
            this.BTN_MES_CH1.Name = "BTN_MES_CH1";
            this.BTN_MES_CH1.Size = new System.Drawing.Size(101, 36);
            this.BTN_MES_CH1.TabIndex = 23;
            this.BTN_MES_CH1.Text = "OFF";
            this.BTN_MES_CH1.UseVisualStyleBackColor = false;
            this.BTN_MES_CH1.Click += new System.EventHandler(this.BTN_MES_CH1_Click);
            // 
            // GBOX_Result_CH1
            // 
            this.GBOX_Result_CH1.Controls.Add(this.LAB_ES_Result_CH1);
            this.GBOX_Result_CH1.Controls.Add(this.LAB_BER_Result_CH1);
            this.GBOX_Result_CH1.Controls.Add(LAB_ES_CH1);
            this.GBOX_Result_CH1.Controls.Add(LAB_BER_CH1);
            this.GBOX_Result_CH1.Controls.Add(this.LAB_Err_Cnt_Result_CH1);
            this.GBOX_Result_CH1.Controls.Add(LAB_Err_Cnt_CH1);
            this.GBOX_Result_CH1.Controls.Add(this.LAB_Data_Cnt_Result_CH1);
            this.GBOX_Result_CH1.Controls.Add(LAB_Data_Cnt_CH1);
            this.GBOX_Result_CH1.Controls.Add(this.LAB_Mesure_Time_Result_CH1);
            this.GBOX_Result_CH1.Controls.Add(this.BTN_Cnt_Rst_CH1);
            this.GBOX_Result_CH1.Controls.Add(LAB_Mesure_Time_CH1);
            this.GBOX_Result_CH1.Location = new System.Drawing.Point(23, 380);
            this.GBOX_Result_CH1.Name = "GBOX_Result_CH1";
            this.GBOX_Result_CH1.Size = new System.Drawing.Size(343, 212);
            this.GBOX_Result_CH1.TabIndex = 16;
            this.GBOX_Result_CH1.TabStop = false;
            this.GBOX_Result_CH1.Text = "Result";
            // 
            // LAB_ES_Result_CH1
            // 
            this.LAB_ES_Result_CH1.AutoSize = true;
            this.LAB_ES_Result_CH1.Location = new System.Drawing.Point(180, 177);
            this.LAB_ES_Result_CH1.Name = "LAB_ES_Result_CH1";
            this.LAB_ES_Result_CH1.Size = new System.Drawing.Size(66, 20);
            this.LAB_ES_Result_CH1.TabIndex = 24;
            this.LAB_ES_Result_CH1.Text = "0.00%";
            // 
            // LAB_BER_Result_CH1
            // 
            this.LAB_BER_Result_CH1.AutoSize = true;
            this.LAB_BER_Result_CH1.Location = new System.Drawing.Point(180, 146);
            this.LAB_BER_Result_CH1.Name = "LAB_BER_Result_CH1";
            this.LAB_BER_Result_CH1.Size = new System.Drawing.Size(87, 20);
            this.LAB_BER_Result_CH1.TabIndex = 23;
            this.LAB_BER_Result_CH1.Text = "0.00E-00";
            // 
            // LAB_Err_Cnt_Result_CH1
            // 
            this.LAB_Err_Cnt_Result_CH1.AutoSize = true;
            this.LAB_Err_Cnt_Result_CH1.Font = new System.Drawing.Font("Meiryo UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.LAB_Err_Cnt_Result_CH1.Location = new System.Drawing.Point(180, 116);
            this.LAB_Err_Cnt_Result_CH1.Name = "LAB_Err_Cnt_Result_CH1";
            this.LAB_Err_Cnt_Result_CH1.Size = new System.Drawing.Size(80, 20);
            this.LAB_Err_Cnt_Result_CH1.TabIndex = 18;
            this.LAB_Err_Cnt_Result_CH1.Text = "0.00E00";
            this.LAB_Err_Cnt_Result_CH1.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // LAB_Data_Cnt_Result_CH1
            // 
            this.LAB_Data_Cnt_Result_CH1.AutoSize = true;
            this.LAB_Data_Cnt_Result_CH1.Font = new System.Drawing.Font("Meiryo UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.LAB_Data_Cnt_Result_CH1.Location = new System.Drawing.Point(180, 86);
            this.LAB_Data_Cnt_Result_CH1.Name = "LAB_Data_Cnt_Result_CH1";
            this.LAB_Data_Cnt_Result_CH1.Size = new System.Drawing.Size(80, 20);
            this.LAB_Data_Cnt_Result_CH1.TabIndex = 16;
            this.LAB_Data_Cnt_Result_CH1.Text = "0.00E00";
            this.LAB_Data_Cnt_Result_CH1.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // LAB_Mesure_Time_Result_CH1
            // 
            this.LAB_Mesure_Time_Result_CH1.AutoSize = true;
            this.LAB_Mesure_Time_Result_CH1.Font = new System.Drawing.Font("Meiryo UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.LAB_Mesure_Time_Result_CH1.Location = new System.Drawing.Point(179, 53);
            this.LAB_Mesure_Time_Result_CH1.Name = "LAB_Mesure_Time_Result_CH1";
            this.LAB_Mesure_Time_Result_CH1.Size = new System.Drawing.Size(20, 20);
            this.LAB_Mesure_Time_Result_CH1.TabIndex = 14;
            this.LAB_Mesure_Time_Result_CH1.Text = "0";
            this.LAB_Mesure_Time_Result_CH1.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // BTN_Cnt_Rst_CH1
            // 
            this.BTN_Cnt_Rst_CH1.BackColor = System.Drawing.SystemColors.Control;
            this.BTN_Cnt_Rst_CH1.Font = new System.Drawing.Font("Meiryo UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.BTN_Cnt_Rst_CH1.Location = new System.Drawing.Point(143, 11);
            this.BTN_Cnt_Rst_CH1.Name = "BTN_Cnt_Rst_CH1";
            this.BTN_Cnt_Rst_CH1.Size = new System.Drawing.Size(162, 36);
            this.BTN_Cnt_Rst_CH1.TabIndex = 13;
            this.BTN_Cnt_Rst_CH1.Text = "COUNTER RESET";
            this.BTN_Cnt_Rst_CH1.UseVisualStyleBackColor = false;
            this.BTN_Cnt_Rst_CH1.Click += new System.EventHandler(this.BTN_Cnt_Rst_CH1_Click);
            // 
            // GBOX_Monitor_CH1
            // 
            this.GBOX_Monitor_CH1.Controls.Add(this.BTN_Flg_Rst_CH1);
            this.GBOX_Monitor_CH1.Controls.Add(this.PBOX_ERR_CH1);
            this.GBOX_Monitor_CH1.Controls.Add(this.PBOX_LOS_CH1);
            this.GBOX_Monitor_CH1.Controls.Add(LAB_ERR_CH1);
            this.GBOX_Monitor_CH1.Controls.Add(this.PBOX_ERR_FLG_CH1);
            this.GBOX_Monitor_CH1.Controls.Add(LAB_LOS_CH1);
            this.GBOX_Monitor_CH1.Location = new System.Drawing.Point(23, 254);
            this.GBOX_Monitor_CH1.Name = "GBOX_Monitor_CH1";
            this.GBOX_Monitor_CH1.Size = new System.Drawing.Size(343, 126);
            this.GBOX_Monitor_CH1.TabIndex = 14;
            this.GBOX_Monitor_CH1.TabStop = false;
            this.GBOX_Monitor_CH1.Text = "Monitor";
            // 
            // BTN_Flg_Rst_CH1
            // 
            this.BTN_Flg_Rst_CH1.BackColor = System.Drawing.SystemColors.Control;
            this.BTN_Flg_Rst_CH1.Font = new System.Drawing.Font("Meiryo UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.BTN_Flg_Rst_CH1.Location = new System.Drawing.Point(143, 11);
            this.BTN_Flg_Rst_CH1.Name = "BTN_Flg_Rst_CH1";
            this.BTN_Flg_Rst_CH1.Size = new System.Drawing.Size(162, 36);
            this.BTN_Flg_Rst_CH1.TabIndex = 13;
            this.BTN_Flg_Rst_CH1.Text = "FLAG RESET";
            this.BTN_Flg_Rst_CH1.UseVisualStyleBackColor = false;
            this.BTN_Flg_Rst_CH1.Click += new System.EventHandler(this.BTN_Flg_Rst_CH1_Click);
            // 
            // PBOX_ERR_CH1
            // 
            this.PBOX_ERR_CH1.ErrorImage = global::BERT.Properties.Resources.led_red;
            this.PBOX_ERR_CH1.Image = global::BERT.Properties.Resources.led_off;
            this.PBOX_ERR_CH1.InitialImage = global::BERT.Properties.Resources.led_green;
            this.PBOX_ERR_CH1.Location = new System.Drawing.Point(183, 83);
            this.PBOX_ERR_CH1.Name = "PBOX_ERR_CH1";
            this.PBOX_ERR_CH1.Size = new System.Drawing.Size(32, 32);
            this.PBOX_ERR_CH1.TabIndex = 17;
            this.PBOX_ERR_CH1.TabStop = false;
            // 
            // PBOX_LOS_CH1
            // 
            this.PBOX_LOS_CH1.ErrorImage = global::BERT.Properties.Resources.led_red;
            this.PBOX_LOS_CH1.Image = global::BERT.Properties.Resources.led_off;
            this.PBOX_LOS_CH1.InitialImage = global::BERT.Properties.Resources.led_green;
            this.PBOX_LOS_CH1.Location = new System.Drawing.Point(183, 47);
            this.PBOX_LOS_CH1.Name = "PBOX_LOS_CH1";
            this.PBOX_LOS_CH1.Size = new System.Drawing.Size(32, 32);
            this.PBOX_LOS_CH1.TabIndex = 6;
            this.PBOX_LOS_CH1.TabStop = false;
            // 
            // PBOX_ERR_FLG_CH1
            // 
            this.PBOX_ERR_FLG_CH1.ErrorImage = global::BERT.Properties.Resources.led_red;
            this.PBOX_ERR_FLG_CH1.Image = global::BERT.Properties.Resources.led_off;
            this.PBOX_ERR_FLG_CH1.InitialImage = global::BERT.Properties.Resources.led_green;
            this.PBOX_ERR_FLG_CH1.Location = new System.Drawing.Point(237, 83);
            this.PBOX_ERR_FLG_CH1.Name = "PBOX_ERR_FLG_CH1";
            this.PBOX_ERR_FLG_CH1.Size = new System.Drawing.Size(32, 32);
            this.PBOX_ERR_FLG_CH1.TabIndex = 15;
            this.PBOX_ERR_FLG_CH1.TabStop = false;
            // 
            // GBOX_Setting_CH1
            // 
            this.GBOX_Setting_CH1.Controls.Add(this.LAB_LENGTH_CH1_Val);
            this.GBOX_Setting_CH1.Controls.Add(this.CMB_PN_CH1);
            this.GBOX_Setting_CH1.Controls.Add(LAB_LENGTH_CH1);
            this.GBOX_Setting_CH1.Controls.Add(LAB_PN_CH1);
            this.GBOX_Setting_CH1.Location = new System.Drawing.Point(23, 168);
            this.GBOX_Setting_CH1.Name = "GBOX_Setting_CH1";
            this.GBOX_Setting_CH1.Size = new System.Drawing.Size(343, 86);
            this.GBOX_Setting_CH1.TabIndex = 12;
            this.GBOX_Setting_CH1.TabStop = false;
            this.GBOX_Setting_CH1.Text = "Setting";
            // 
            // LAB_LENGTH_CH1_Val
            // 
            this.LAB_LENGTH_CH1_Val.Location = new System.Drawing.Point(204, 54);
            this.LAB_LENGTH_CH1_Val.Name = "LAB_LENGTH_CH1_Val";
            this.LAB_LENGTH_CH1_Val.Size = new System.Drawing.Size(100, 20);
            this.LAB_LENGTH_CH1_Val.TabIndex = 27;
            this.LAB_LENGTH_CH1_Val.Text = "127";
            this.LAB_LENGTH_CH1_Val.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // CMB_PN_CH1
            // 
            this.CMB_PN_CH1.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.CMB_PN_CH1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CMB_PN_CH1.Font = new System.Drawing.Font("MS UI Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.CMB_PN_CH1.FormattingEnabled = true;
            this.CMB_PN_CH1.Items.AddRange(new object[] {
            "PN7",
            "PN15",
            "PN23",
            "PN31",
            "PROGRAM"});
            this.CMB_PN_CH1.Location = new System.Drawing.Point(204, 20);
            this.CMB_PN_CH1.Name = "CMB_PN_CH1";
            this.CMB_PN_CH1.Size = new System.Drawing.Size(102, 23);
            this.CMB_PN_CH1.TabIndex = 25;
            this.CMB_PN_CH1.DrawItem += new System.Windows.Forms.DrawItemEventHandler(this.CMB_PN_CH1_DrawItem);
            this.CMB_PN_CH1.SelectedIndexChanged += new System.EventHandler(this.CMB_PN_CH1_SelectedIndexChanged);
            // 
            // BTN_Sync_CH1
            // 
            this.BTN_Sync_CH1.BackColor = System.Drawing.SystemColors.Control;
            this.BTN_Sync_CH1.Font = new System.Drawing.Font("Meiryo UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.BTN_Sync_CH1.Location = new System.Drawing.Point(226, 130);
            this.BTN_Sync_CH1.Name = "BTN_Sync_CH1";
            this.BTN_Sync_CH1.Size = new System.Drawing.Size(101, 36);
            this.BTN_Sync_CH1.TabIndex = 19;
            this.BTN_Sync_CH1.Text = "RESYNC";
            this.BTN_Sync_CH1.UseVisualStyleBackColor = false;
            this.BTN_Sync_CH1.Click += new System.EventHandler(this.BTN_Sync_CH1_Click);
            // 
            // BTN_TX_OUT_CH1
            // 
            this.BTN_TX_OUT_CH1.BackColor = System.Drawing.SystemColors.Control;
            this.BTN_TX_OUT_CH1.Font = new System.Drawing.Font("Meiryo UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.BTN_TX_OUT_CH1.Location = new System.Drawing.Point(227, 22);
            this.BTN_TX_OUT_CH1.Name = "BTN_TX_OUT_CH1";
            this.BTN_TX_OUT_CH1.Size = new System.Drawing.Size(101, 36);
            this.BTN_TX_OUT_CH1.TabIndex = 11;
            this.BTN_TX_OUT_CH1.Text = "OFF";
            this.BTN_TX_OUT_CH1.UseVisualStyleBackColor = false;
            this.BTN_TX_OUT_CH1.Click += new System.EventHandler(this.BTN_TX_OUT_CH1_Click);
            // 
            // LAB_Sync_CH1
            // 
            this.LAB_Sync_CH1.AutoSize = true;
            this.LAB_Sync_CH1.Font = new System.Drawing.Font("Meiryo UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.LAB_Sync_CH1.Location = new System.Drawing.Point(11, 137);
            this.LAB_Sync_CH1.Name = "LAB_Sync_CH1";
            this.LAB_Sync_CH1.Size = new System.Drawing.Size(77, 20);
            this.LAB_Sync_CH1.TabIndex = 18;
            this.LAB_Sync_CH1.Text = "RESYNC";
            this.LAB_Sync_CH1.UseMnemonic = false;
            // 
            // CBOX_BR
            // 
            this.CBOX_BR.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.CBOX_BR.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CBOX_BR.Font = new System.Drawing.Font("MS UI Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.CBOX_BR.FormattingEnabled = true;
            this.CBOX_BR.Items.AddRange(new object[] {
            "1250",
            "622",
            "150",
            "100",
            "50",
            "20",
            "10",
            "5",
            "1.5"});
            this.CBOX_BR.Location = new System.Drawing.Point(141, 22);
            this.CBOX_BR.Name = "CBOX_BR";
            this.CBOX_BR.Size = new System.Drawing.Size(76, 24);
            this.CBOX_BR.TabIndex = 6;
            this.CBOX_BR.DrawItem += new System.Windows.Forms.DrawItemEventHandler(this.CBOX_BR_DrawItem);
            this.CBOX_BR.SelectedIndexChanged += new System.EventHandler(this.CBOX_BR_SelectedIndexChanged);
            // 
            // LAB_Mbps
            // 
            this.LAB_Mbps.AutoSize = true;
            this.LAB_Mbps.Font = new System.Drawing.Font("Meiryo UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.LAB_Mbps.Location = new System.Drawing.Point(217, 25);
            this.LAB_Mbps.Name = "LAB_Mbps";
            this.LAB_Mbps.Size = new System.Drawing.Size(55, 20);
            this.LAB_Mbps.TabIndex = 20;
            this.LAB_Mbps.Text = "Mbps";
            this.LAB_Mbps.UseMnemonic = false;
            // 
            // GBOX_CH2
            // 
            this.GBOX_CH2.Controls.Add(this.PBOX_Tx_STS_2);
            this.GBOX_CH2.Controls.Add(this.CBOX_ReSync_Mode_CH2);
            this.GBOX_CH2.Controls.Add(this.LAB_ReSync_Mode_CH2);
            this.GBOX_CH2.Controls.Add(this.BTN_Sync_CH2);
            this.GBOX_CH2.Controls.Add(this.LAB_Sync_CH2);
            this.GBOX_CH2.Controls.Add(this.BTN_MES_CH2);
            this.GBOX_CH2.Controls.Add(this.LAB_Mesure_CH2);
            this.GBOX_CH2.Controls.Add(this.GBOX_Result_CH2);
            this.GBOX_CH2.Controls.Add(this.GBOX_Monitor_CH2);
            this.GBOX_CH2.Controls.Add(this.GBOX_Setting_CH2);
            this.GBOX_CH2.Controls.Add(this.BTN_TX_OUT_CH2);
            this.GBOX_CH2.Controls.Add(LAB_TXout_CH2);
            this.GBOX_CH2.Font = new System.Drawing.Font("Meiryo UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.GBOX_CH2.Location = new System.Drawing.Point(470, 59);
            this.GBOX_CH2.Name = "GBOX_CH2";
            this.GBOX_CH2.Size = new System.Drawing.Size(385, 603);
            this.GBOX_CH2.TabIndex = 17;
            this.GBOX_CH2.TabStop = false;
            this.GBOX_CH2.Text = "CH2";
            // 
            // PBOX_Tx_STS_2
            // 
            this.PBOX_Tx_STS_2.ErrorImage = global::BERT.Properties.Resources.led_red;
            this.PBOX_Tx_STS_2.Image = global::BERT.Properties.Resources.led_off;
            this.PBOX_Tx_STS_2.InitialImage = global::BERT.Properties.Resources.led_green;
            this.PBOX_Tx_STS_2.Location = new System.Drawing.Point(181, 23);
            this.PBOX_Tx_STS_2.Name = "PBOX_Tx_STS_2";
            this.PBOX_Tx_STS_2.Size = new System.Drawing.Size(32, 32);
            this.PBOX_Tx_STS_2.TabIndex = 25;
            this.PBOX_Tx_STS_2.TabStop = false;
            this.PBOX_Tx_STS_2.Visible = false;
            // 
            // CBOX_ReSync_Mode_CH2
            // 
            this.CBOX_ReSync_Mode_CH2.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.CBOX_ReSync_Mode_CH2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CBOX_ReSync_Mode_CH2.Font = new System.Drawing.Font("MS UI Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.CBOX_ReSync_Mode_CH2.FormattingEnabled = true;
            this.CBOX_ReSync_Mode_CH2.Items.AddRange(new object[] {
            "Auto",
            "Manual"});
            this.CBOX_ReSync_Mode_CH2.Location = new System.Drawing.Point(221, 102);
            this.CBOX_ReSync_Mode_CH2.Name = "CBOX_ReSync_Mode_CH2";
            this.CBOX_ReSync_Mode_CH2.Size = new System.Drawing.Size(102, 24);
            this.CBOX_ReSync_Mode_CH2.TabIndex = 25;
            this.CBOX_ReSync_Mode_CH2.DrawItem += new System.Windows.Forms.DrawItemEventHandler(this.CBOX_ReSync_Mode_CH2_DrawItem);
            this.CBOX_ReSync_Mode_CH2.SelectedIndexChanged += new System.EventHandler(this.CBOX_ReSync_Mode_CH2_SelectedIndexChanged);
            // 
            // LAB_ReSync_Mode_CH2
            // 
            this.LAB_ReSync_Mode_CH2.AutoSize = true;
            this.LAB_ReSync_Mode_CH2.Font = new System.Drawing.Font("Meiryo UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.LAB_ReSync_Mode_CH2.Location = new System.Drawing.Point(6, 106);
            this.LAB_ReSync_Mode_CH2.Name = "LAB_ReSync_Mode_CH2";
            this.LAB_ReSync_Mode_CH2.Size = new System.Drawing.Size(133, 20);
            this.LAB_ReSync_Mode_CH2.TabIndex = 25;
            this.LAB_ReSync_Mode_CH2.Text = "RESYNC MODE";
            this.LAB_ReSync_Mode_CH2.UseMnemonic = false;
            // 
            // BTN_Sync_CH2
            // 
            this.BTN_Sync_CH2.BackColor = System.Drawing.SystemColors.Control;
            this.BTN_Sync_CH2.Font = new System.Drawing.Font("Meiryo UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.BTN_Sync_CH2.Location = new System.Drawing.Point(222, 130);
            this.BTN_Sync_CH2.Name = "BTN_Sync_CH2";
            this.BTN_Sync_CH2.Size = new System.Drawing.Size(101, 36);
            this.BTN_Sync_CH2.TabIndex = 26;
            this.BTN_Sync_CH2.Text = "RESYNC";
            this.BTN_Sync_CH2.UseVisualStyleBackColor = false;
            this.BTN_Sync_CH2.Click += new System.EventHandler(this.BTN_Sync_CH2_Click);
            // 
            // LAB_Sync_CH2
            // 
            this.LAB_Sync_CH2.AutoSize = true;
            this.LAB_Sync_CH2.Font = new System.Drawing.Font("Meiryo UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.LAB_Sync_CH2.Location = new System.Drawing.Point(6, 137);
            this.LAB_Sync_CH2.Name = "LAB_Sync_CH2";
            this.LAB_Sync_CH2.Size = new System.Drawing.Size(77, 20);
            this.LAB_Sync_CH2.TabIndex = 26;
            this.LAB_Sync_CH2.Text = "RESYNC";
            this.LAB_Sync_CH2.UseMnemonic = false;
            // 
            // BTN_MES_CH2
            // 
            this.BTN_MES_CH2.BackColor = System.Drawing.SystemColors.Control;
            this.BTN_MES_CH2.Font = new System.Drawing.Font("Meiryo UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.BTN_MES_CH2.Location = new System.Drawing.Point(222, 62);
            this.BTN_MES_CH2.Name = "BTN_MES_CH2";
            this.BTN_MES_CH2.Size = new System.Drawing.Size(101, 36);
            this.BTN_MES_CH2.TabIndex = 26;
            this.BTN_MES_CH2.Text = "OFF";
            this.BTN_MES_CH2.UseVisualStyleBackColor = false;
            this.BTN_MES_CH2.Click += new System.EventHandler(this.BTN_MES_CH2_Click);
            // 
            // LAB_Mesure_CH2
            // 
            this.LAB_Mesure_CH2.AutoSize = true;
            this.LAB_Mesure_CH2.Font = new System.Drawing.Font("Meiryo UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.LAB_Mesure_CH2.Location = new System.Drawing.Point(6, 70);
            this.LAB_Mesure_CH2.Name = "LAB_Mesure_CH2";
            this.LAB_Mesure_CH2.Size = new System.Drawing.Size(92, 20);
            this.LAB_Mesure_CH2.TabIndex = 26;
            this.LAB_Mesure_CH2.Text = "MEASURE";
            // 
            // GBOX_Result_CH2
            // 
            this.GBOX_Result_CH2.Controls.Add(this.LAB_TEST_CNT);
            this.GBOX_Result_CH2.Controls.Add(this.LAB_ES_Result_CH2);
            this.GBOX_Result_CH2.Controls.Add(this.LAB_BER_Result_CH2);
            this.GBOX_Result_CH2.Controls.Add(LAB_ES_CH2);
            this.GBOX_Result_CH2.Controls.Add(LAB_BER_CH2);
            this.GBOX_Result_CH2.Controls.Add(this.LAB_Err_Cnt_Result_CH2);
            this.GBOX_Result_CH2.Controls.Add(LAB_Err_Cnt_CH2);
            this.GBOX_Result_CH2.Controls.Add(this.LAB_Data_Cnt_Result_CH2);
            this.GBOX_Result_CH2.Controls.Add(LAB_Data_Cnt_CH2);
            this.GBOX_Result_CH2.Controls.Add(this.LAB_Mesure_Time_Result_CH2);
            this.GBOX_Result_CH2.Controls.Add(this.BTN_Cnt_Rst_CH2);
            this.GBOX_Result_CH2.Controls.Add(LAB_Mesure_Time_CH2);
            this.GBOX_Result_CH2.Location = new System.Drawing.Point(23, 380);
            this.GBOX_Result_CH2.Name = "GBOX_Result_CH2";
            this.GBOX_Result_CH2.Size = new System.Drawing.Size(343, 212);
            this.GBOX_Result_CH2.TabIndex = 16;
            this.GBOX_Result_CH2.TabStop = false;
            this.GBOX_Result_CH2.Text = "Result";
            // 
            // LAB_TEST_CNT
            // 
            this.LAB_TEST_CNT.AutoSize = true;
            this.LAB_TEST_CNT.Location = new System.Drawing.Point(295, 187);
            this.LAB_TEST_CNT.Name = "LAB_TEST_CNT";
            this.LAB_TEST_CNT.Size = new System.Drawing.Size(20, 20);
            this.LAB_TEST_CNT.TabIndex = 26;
            this.LAB_TEST_CNT.Text = "0";
            this.LAB_TEST_CNT.Visible = false;
            // 
            // LAB_ES_Result_CH2
            // 
            this.LAB_ES_Result_CH2.AutoSize = true;
            this.LAB_ES_Result_CH2.Location = new System.Drawing.Point(180, 177);
            this.LAB_ES_Result_CH2.Name = "LAB_ES_Result_CH2";
            this.LAB_ES_Result_CH2.Size = new System.Drawing.Size(66, 20);
            this.LAB_ES_Result_CH2.TabIndex = 25;
            this.LAB_ES_Result_CH2.Text = "0.00%";
            // 
            // LAB_BER_Result_CH2
            // 
            this.LAB_BER_Result_CH2.AutoSize = true;
            this.LAB_BER_Result_CH2.Location = new System.Drawing.Point(180, 146);
            this.LAB_BER_Result_CH2.Name = "LAB_BER_Result_CH2";
            this.LAB_BER_Result_CH2.Size = new System.Drawing.Size(87, 20);
            this.LAB_BER_Result_CH2.TabIndex = 24;
            this.LAB_BER_Result_CH2.Text = "0.00E-00";
            // 
            // LAB_Err_Cnt_Result_CH2
            // 
            this.LAB_Err_Cnt_Result_CH2.AutoSize = true;
            this.LAB_Err_Cnt_Result_CH2.Font = new System.Drawing.Font("Meiryo UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.LAB_Err_Cnt_Result_CH2.Location = new System.Drawing.Point(180, 116);
            this.LAB_Err_Cnt_Result_CH2.Name = "LAB_Err_Cnt_Result_CH2";
            this.LAB_Err_Cnt_Result_CH2.Size = new System.Drawing.Size(80, 20);
            this.LAB_Err_Cnt_Result_CH2.TabIndex = 18;
            this.LAB_Err_Cnt_Result_CH2.Text = "0.00E00";
            this.LAB_Err_Cnt_Result_CH2.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // LAB_Data_Cnt_Result_CH2
            // 
            this.LAB_Data_Cnt_Result_CH2.AutoSize = true;
            this.LAB_Data_Cnt_Result_CH2.Font = new System.Drawing.Font("Meiryo UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.LAB_Data_Cnt_Result_CH2.Location = new System.Drawing.Point(180, 86);
            this.LAB_Data_Cnt_Result_CH2.Name = "LAB_Data_Cnt_Result_CH2";
            this.LAB_Data_Cnt_Result_CH2.Size = new System.Drawing.Size(80, 20);
            this.LAB_Data_Cnt_Result_CH2.TabIndex = 16;
            this.LAB_Data_Cnt_Result_CH2.Text = "0.00E00";
            this.LAB_Data_Cnt_Result_CH2.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // LAB_Mesure_Time_Result_CH2
            // 
            this.LAB_Mesure_Time_Result_CH2.AutoSize = true;
            this.LAB_Mesure_Time_Result_CH2.Font = new System.Drawing.Font("Meiryo UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.LAB_Mesure_Time_Result_CH2.Location = new System.Drawing.Point(179, 53);
            this.LAB_Mesure_Time_Result_CH2.Name = "LAB_Mesure_Time_Result_CH2";
            this.LAB_Mesure_Time_Result_CH2.Size = new System.Drawing.Size(20, 20);
            this.LAB_Mesure_Time_Result_CH2.TabIndex = 14;
            this.LAB_Mesure_Time_Result_CH2.Text = "0";
            this.LAB_Mesure_Time_Result_CH2.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // BTN_Cnt_Rst_CH2
            // 
            this.BTN_Cnt_Rst_CH2.BackColor = System.Drawing.SystemColors.Control;
            this.BTN_Cnt_Rst_CH2.Font = new System.Drawing.Font("Meiryo UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.BTN_Cnt_Rst_CH2.Location = new System.Drawing.Point(138, 11);
            this.BTN_Cnt_Rst_CH2.Name = "BTN_Cnt_Rst_CH2";
            this.BTN_Cnt_Rst_CH2.Size = new System.Drawing.Size(162, 36);
            this.BTN_Cnt_Rst_CH2.TabIndex = 13;
            this.BTN_Cnt_Rst_CH2.Text = "COUNTER RESET";
            this.BTN_Cnt_Rst_CH2.UseVisualStyleBackColor = false;
            this.BTN_Cnt_Rst_CH2.Click += new System.EventHandler(this.BTN_Cnt_Rst_CH2_Click);
            // 
            // GBOX_Monitor_CH2
            // 
            this.GBOX_Monitor_CH2.Controls.Add(this.PBOX_ERR_CH2);
            this.GBOX_Monitor_CH2.Controls.Add(this.PBOX_LOS_CH2);
            this.GBOX_Monitor_CH2.Controls.Add(LAB_ERR_CH2);
            this.GBOX_Monitor_CH2.Controls.Add(this.PBOX_ERR_FLG_CH2);
            this.GBOX_Monitor_CH2.Controls.Add(this.BTN_Flg_Rst_CH2);
            this.GBOX_Monitor_CH2.Controls.Add(LAB_LOS_CH2);
            this.GBOX_Monitor_CH2.Location = new System.Drawing.Point(23, 254);
            this.GBOX_Monitor_CH2.Name = "GBOX_Monitor_CH2";
            this.GBOX_Monitor_CH2.Size = new System.Drawing.Size(343, 126);
            this.GBOX_Monitor_CH2.TabIndex = 14;
            this.GBOX_Monitor_CH2.TabStop = false;
            this.GBOX_Monitor_CH2.Text = "Monitor";
            // 
            // PBOX_ERR_CH2
            // 
            this.PBOX_ERR_CH2.ErrorImage = global::BERT.Properties.Resources.led_red;
            this.PBOX_ERR_CH2.Image = global::BERT.Properties.Resources.led_off;
            this.PBOX_ERR_CH2.InitialImage = global::BERT.Properties.Resources.led_green;
            this.PBOX_ERR_CH2.Location = new System.Drawing.Point(176, 83);
            this.PBOX_ERR_CH2.Name = "PBOX_ERR_CH2";
            this.PBOX_ERR_CH2.Size = new System.Drawing.Size(32, 32);
            this.PBOX_ERR_CH2.TabIndex = 18;
            this.PBOX_ERR_CH2.TabStop = false;
            // 
            // PBOX_LOS_CH2
            // 
            this.PBOX_LOS_CH2.ErrorImage = global::BERT.Properties.Resources.led_red;
            this.PBOX_LOS_CH2.Image = global::BERT.Properties.Resources.led_off;
            this.PBOX_LOS_CH2.InitialImage = global::BERT.Properties.Resources.led_green;
            this.PBOX_LOS_CH2.Location = new System.Drawing.Point(176, 47);
            this.PBOX_LOS_CH2.Name = "PBOX_LOS_CH2";
            this.PBOX_LOS_CH2.Size = new System.Drawing.Size(32, 32);
            this.PBOX_LOS_CH2.TabIndex = 17;
            this.PBOX_LOS_CH2.TabStop = false;
            // 
            // PBOX_ERR_FLG_CH2
            // 
            this.PBOX_ERR_FLG_CH2.ErrorImage = global::BERT.Properties.Resources.led_red;
            this.PBOX_ERR_FLG_CH2.Image = global::BERT.Properties.Resources.led_off;
            this.PBOX_ERR_FLG_CH2.InitialImage = global::BERT.Properties.Resources.led_green;
            this.PBOX_ERR_FLG_CH2.Location = new System.Drawing.Point(233, 83);
            this.PBOX_ERR_FLG_CH2.Name = "PBOX_ERR_FLG_CH2";
            this.PBOX_ERR_FLG_CH2.Size = new System.Drawing.Size(32, 32);
            this.PBOX_ERR_FLG_CH2.TabIndex = 15;
            this.PBOX_ERR_FLG_CH2.TabStop = false;
            // 
            // BTN_Flg_Rst_CH2
            // 
            this.BTN_Flg_Rst_CH2.BackColor = System.Drawing.SystemColors.Control;
            this.BTN_Flg_Rst_CH2.Font = new System.Drawing.Font("Meiryo UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.BTN_Flg_Rst_CH2.Location = new System.Drawing.Point(138, 11);
            this.BTN_Flg_Rst_CH2.Name = "BTN_Flg_Rst_CH2";
            this.BTN_Flg_Rst_CH2.Size = new System.Drawing.Size(162, 36);
            this.BTN_Flg_Rst_CH2.TabIndex = 13;
            this.BTN_Flg_Rst_CH2.Text = "FLAG RESET";
            this.BTN_Flg_Rst_CH2.UseVisualStyleBackColor = false;
            this.BTN_Flg_Rst_CH2.Click += new System.EventHandler(this.BTN_Flg_Rst_CH2_Click);
            // 
            // GBOX_Setting_CH2
            // 
            this.GBOX_Setting_CH2.Controls.Add(this.LAB_LENGTH_CH2_Val);
            this.GBOX_Setting_CH2.Controls.Add(LAB_LENGTH_CH2_unit);
            this.GBOX_Setting_CH2.Controls.Add(LAB_LENGTH_CH2);
            this.GBOX_Setting_CH2.Controls.Add(this.CMB_PN_CH2);
            this.GBOX_Setting_CH2.Controls.Add(LAB_PN_CH2);
            this.GBOX_Setting_CH2.Location = new System.Drawing.Point(23, 168);
            this.GBOX_Setting_CH2.Name = "GBOX_Setting_CH2";
            this.GBOX_Setting_CH2.Size = new System.Drawing.Size(343, 86);
            this.GBOX_Setting_CH2.TabIndex = 12;
            this.GBOX_Setting_CH2.TabStop = false;
            this.GBOX_Setting_CH2.Text = "Setting";
            // 
            // LAB_LENGTH_CH2_Val
            // 
            this.LAB_LENGTH_CH2_Val.Location = new System.Drawing.Point(200, 54);
            this.LAB_LENGTH_CH2_Val.Name = "LAB_LENGTH_CH2_Val";
            this.LAB_LENGTH_CH2_Val.Size = new System.Drawing.Size(100, 20);
            this.LAB_LENGTH_CH2_Val.TabIndex = 28;
            this.LAB_LENGTH_CH2_Val.Text = "127";
            this.LAB_LENGTH_CH2_Val.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // CMB_PN_CH2
            // 
            this.CMB_PN_CH2.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.CMB_PN_CH2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CMB_PN_CH2.Font = new System.Drawing.Font("MS UI Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.CMB_PN_CH2.FormattingEnabled = true;
            this.CMB_PN_CH2.Items.AddRange(new object[] {
            "PN7",
            "PN15",
            "PN23",
            "PN31",
            "PROGRAM"});
            this.CMB_PN_CH2.Location = new System.Drawing.Point(198, 20);
            this.CMB_PN_CH2.Name = "CMB_PN_CH2";
            this.CMB_PN_CH2.Size = new System.Drawing.Size(102, 23);
            this.CMB_PN_CH2.TabIndex = 21;
            this.CMB_PN_CH2.DrawItem += new System.Windows.Forms.DrawItemEventHandler(this.CMB_PN_CH2_DrawItem);
            this.CMB_PN_CH2.SelectedIndexChanged += new System.EventHandler(this.CMB_PN_CH2_SelectedIndexChanged);
            // 
            // BTN_TX_OUT_CH2
            // 
            this.BTN_TX_OUT_CH2.BackColor = System.Drawing.SystemColors.Control;
            this.BTN_TX_OUT_CH2.Font = new System.Drawing.Font("Meiryo UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.BTN_TX_OUT_CH2.Location = new System.Drawing.Point(222, 22);
            this.BTN_TX_OUT_CH2.Name = "BTN_TX_OUT_CH2";
            this.BTN_TX_OUT_CH2.Size = new System.Drawing.Size(101, 36);
            this.BTN_TX_OUT_CH2.TabIndex = 11;
            this.BTN_TX_OUT_CH2.Text = "OFF";
            this.BTN_TX_OUT_CH2.UseVisualStyleBackColor = false;
            this.BTN_TX_OUT_CH2.Click += new System.EventHandler(this.BTN_TX_OUT_CH2_Click);
            // 
            // LAB_Trg
            // 
            this.LAB_Trg.AutoSize = true;
            this.LAB_Trg.Font = new System.Drawing.Font("Meiryo UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.LAB_Trg.Location = new System.Drawing.Point(323, 25);
            this.LAB_Trg.Name = "LAB_Trg";
            this.LAB_Trg.Size = new System.Drawing.Size(71, 20);
            this.LAB_Trg.TabIndex = 21;
            this.LAB_Trg.Text = "Trigger";
            this.LAB_Trg.UseMnemonic = false;
            // 
            // CMB_Trg
            // 
            this.CMB_Trg.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.CMB_Trg.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CMB_Trg.Font = new System.Drawing.Font("MS UI Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.CMB_Trg.FormattingEnabled = true;
            this.CMB_Trg.Items.AddRange(new object[] {
            "1/8",
            "1/1"});
            this.CMB_Trg.Location = new System.Drawing.Point(407, 23);
            this.CMB_Trg.Name = "CMB_Trg";
            this.CMB_Trg.Size = new System.Drawing.Size(100, 24);
            this.CMB_Trg.TabIndex = 22;
            this.CMB_Trg.DrawItem += new System.Windows.Forms.DrawItemEventHandler(this.CMB_Trg_DrawItem);
            this.CMB_Trg.SelectedIndexChanged += new System.EventHandler(this.CMB_Trg_SelectedIndexChanged);
            // 
            // LAB_Clock
            // 
            this.LAB_Clock.AutoSize = true;
            this.LAB_Clock.Font = new System.Drawing.Font("Meiryo UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.LAB_Clock.Location = new System.Drawing.Point(513, 23);
            this.LAB_Clock.Name = "LAB_Clock";
            this.LAB_Clock.Size = new System.Drawing.Size(54, 20);
            this.LAB_Clock.TabIndex = 23;
            this.LAB_Clock.Text = "Clock";
            this.LAB_Clock.UseMnemonic = false;
            // 
            // PAN_Form_Main
            // 
            this.PAN_Form_Main.Controls.Add(LAB_LENGTH_CH1_unit);
            this.PAN_Form_Main.Controls.Add(this.BTN_ProgramPatternSetting);
            this.PAN_Form_Main.Controls.Add(this.LAB_Program_pattern);
            this.PAN_Form_Main.Controls.Add(this.GBOX_CH4);
            this.PAN_Form_Main.Controls.Add(this.GBOX_CH3);
            this.PAN_Form_Main.Controls.Add(this.LAB_Clock);
            this.PAN_Form_Main.Controls.Add(this.CMB_Trg);
            this.PAN_Form_Main.Controls.Add(this.LAB_Trg);
            this.PAN_Form_Main.Controls.Add(this.GBOX_CH2);
            this.PAN_Form_Main.Controls.Add(this.LAB_Mbps);
            this.PAN_Form_Main.Controls.Add(this.CBOX_BR);
            this.PAN_Form_Main.Controls.Add(this.GBOX_CH1);
            this.PAN_Form_Main.Controls.Add(this.LAB_Bitrate);
            this.PAN_Form_Main.Enabled = false;
            this.PAN_Form_Main.Location = new System.Drawing.Point(0, 93);
            this.PAN_Form_Main.Name = "PAN_Form_Main";
            this.PAN_Form_Main.Size = new System.Drawing.Size(1751, 698);
            this.PAN_Form_Main.TabIndex = 2;
            // 
            // BTN_ProgramPatternSetting
            // 
            this.BTN_ProgramPatternSetting.BackColor = System.Drawing.SystemColors.Control;
            this.BTN_ProgramPatternSetting.Enabled = false;
            this.BTN_ProgramPatternSetting.Font = new System.Drawing.Font("Meiryo UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.BTN_ProgramPatternSetting.Location = new System.Drawing.Point(1545, 14);
            this.BTN_ProgramPatternSetting.Name = "BTN_ProgramPatternSetting";
            this.BTN_ProgramPatternSetting.Size = new System.Drawing.Size(107, 37);
            this.BTN_ProgramPatternSetting.TabIndex = 28;
            this.BTN_ProgramPatternSetting.Text = "SETTING";
            this.BTN_ProgramPatternSetting.UseVisualStyleBackColor = false;
            this.BTN_ProgramPatternSetting.Click += new System.EventHandler(this.BTN_ProgramPatternSetting_Click);
            // 
            // LAB_Program_pattern
            // 
            this.LAB_Program_pattern.AutoSize = true;
            this.LAB_Program_pattern.Enabled = false;
            this.LAB_Program_pattern.Font = new System.Drawing.Font("Meiryo UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.LAB_Program_pattern.Location = new System.Drawing.Point(1387, 22);
            this.LAB_Program_pattern.Name = "LAB_Program_pattern";
            this.LAB_Program_pattern.Size = new System.Drawing.Size(152, 20);
            this.LAB_Program_pattern.TabIndex = 27;
            this.LAB_Program_pattern.Text = "Program Pattern";
            // 
            // GBOX_CH4
            // 
            this.GBOX_CH4.Controls.Add(this.PBOX_Tx_STS_4);
            this.GBOX_CH4.Controls.Add(this.CBOX_ReSync_Mode_CH4);
            this.GBOX_CH4.Controls.Add(this.LAB_ReSync_Mode_CH4);
            this.GBOX_CH4.Controls.Add(this.BTN_MES_CH4);
            this.GBOX_CH4.Controls.Add(LAB_Mesure_CH4);
            this.GBOX_CH4.Controls.Add(this.GBOX_Result_CH4);
            this.GBOX_CH4.Controls.Add(this.GBOX_Monitor_CH4);
            this.GBOX_CH4.Controls.Add(this.GBOX_Setting_CH4);
            this.GBOX_CH4.Controls.Add(this.BTN_Sync_CH4);
            this.GBOX_CH4.Controls.Add(this.BTN_TX_OUT_CH4);
            this.GBOX_CH4.Controls.Add(this.LAB_Sync_CH4);
            this.GBOX_CH4.Controls.Add(LAB_TXout_CH4);
            this.GBOX_CH4.Font = new System.Drawing.Font("Meiryo UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.GBOX_CH4.Location = new System.Drawing.Point(1315, 59);
            this.GBOX_CH4.Name = "GBOX_CH4";
            this.GBOX_CH4.Size = new System.Drawing.Size(385, 603);
            this.GBOX_CH4.TabIndex = 26;
            this.GBOX_CH4.TabStop = false;
            this.GBOX_CH4.Text = "CH4";
            // 
            // PBOX_Tx_STS_4
            // 
            this.PBOX_Tx_STS_4.ErrorImage = global::BERT.Properties.Resources.led_red;
            this.PBOX_Tx_STS_4.Image = global::BERT.Properties.Resources.led_off;
            this.PBOX_Tx_STS_4.InitialImage = global::BERT.Properties.Resources.led_green;
            this.PBOX_Tx_STS_4.Location = new System.Drawing.Point(187, 24);
            this.PBOX_Tx_STS_4.Name = "PBOX_Tx_STS_4";
            this.PBOX_Tx_STS_4.Size = new System.Drawing.Size(32, 32);
            this.PBOX_Tx_STS_4.TabIndex = 18;
            this.PBOX_Tx_STS_4.TabStop = false;
            this.PBOX_Tx_STS_4.Visible = false;
            // 
            // CBOX_ReSync_Mode_CH4
            // 
            this.CBOX_ReSync_Mode_CH4.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.CBOX_ReSync_Mode_CH4.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CBOX_ReSync_Mode_CH4.Font = new System.Drawing.Font("MS UI Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.CBOX_ReSync_Mode_CH4.FormattingEnabled = true;
            this.CBOX_ReSync_Mode_CH4.Items.AddRange(new object[] {
            "Auto",
            "Manual"});
            this.CBOX_ReSync_Mode_CH4.Location = new System.Drawing.Point(227, 103);
            this.CBOX_ReSync_Mode_CH4.Name = "CBOX_ReSync_Mode_CH4";
            this.CBOX_ReSync_Mode_CH4.Size = new System.Drawing.Size(102, 24);
            this.CBOX_ReSync_Mode_CH4.TabIndex = 24;
            this.CBOX_ReSync_Mode_CH4.DrawItem += new System.Windows.Forms.DrawItemEventHandler(this.CBOX_ReSync_Mode_CH4_DrawItem);
            this.CBOX_ReSync_Mode_CH4.SelectedIndexChanged += new System.EventHandler(this.CBOX_ReSync_Mode_CH4_SelectedIndexChanged);
            // 
            // LAB_ReSync_Mode_CH4
            // 
            this.LAB_ReSync_Mode_CH4.AutoSize = true;
            this.LAB_ReSync_Mode_CH4.Font = new System.Drawing.Font("Meiryo UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.LAB_ReSync_Mode_CH4.Location = new System.Drawing.Point(11, 106);
            this.LAB_ReSync_Mode_CH4.Name = "LAB_ReSync_Mode_CH4";
            this.LAB_ReSync_Mode_CH4.Size = new System.Drawing.Size(133, 20);
            this.LAB_ReSync_Mode_CH4.TabIndex = 24;
            this.LAB_ReSync_Mode_CH4.Text = "RESYNC MODE";
            this.LAB_ReSync_Mode_CH4.UseMnemonic = false;
            // 
            // BTN_MES_CH4
            // 
            this.BTN_MES_CH4.BackColor = System.Drawing.SystemColors.Control;
            this.BTN_MES_CH4.Font = new System.Drawing.Font("Meiryo UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.BTN_MES_CH4.Location = new System.Drawing.Point(227, 62);
            this.BTN_MES_CH4.Name = "BTN_MES_CH4";
            this.BTN_MES_CH4.Size = new System.Drawing.Size(101, 36);
            this.BTN_MES_CH4.TabIndex = 23;
            this.BTN_MES_CH4.Text = "OFF";
            this.BTN_MES_CH4.UseVisualStyleBackColor = false;
            this.BTN_MES_CH4.Click += new System.EventHandler(this.BTN_MES_CH4_Click);
            // 
            // GBOX_Result_CH4
            // 
            this.GBOX_Result_CH4.Controls.Add(this.LAB_ES_Result_CH4);
            this.GBOX_Result_CH4.Controls.Add(this.LAB_BER_Result_CH4);
            this.GBOX_Result_CH4.Controls.Add(LAB_ES_CH4);
            this.GBOX_Result_CH4.Controls.Add(LAB_BER_CH4);
            this.GBOX_Result_CH4.Controls.Add(this.LAB_Err_Cnt_Result_CH4);
            this.GBOX_Result_CH4.Controls.Add(LAB_Err_Cnt_CH4);
            this.GBOX_Result_CH4.Controls.Add(this.LAB_Data_Cnt_Result_CH4);
            this.GBOX_Result_CH4.Controls.Add(LAB_Data_Cnt_CH4);
            this.GBOX_Result_CH4.Controls.Add(this.LAB_Mesure_Time_Result_CH4);
            this.GBOX_Result_CH4.Controls.Add(this.BTN_Cnt_Rst_CH4);
            this.GBOX_Result_CH4.Controls.Add(LAB_Mesure_Time_CH4);
            this.GBOX_Result_CH4.Location = new System.Drawing.Point(23, 380);
            this.GBOX_Result_CH4.Name = "GBOX_Result_CH4";
            this.GBOX_Result_CH4.Size = new System.Drawing.Size(343, 212);
            this.GBOX_Result_CH4.TabIndex = 16;
            this.GBOX_Result_CH4.TabStop = false;
            this.GBOX_Result_CH4.Text = "Result";
            // 
            // LAB_ES_Result_CH4
            // 
            this.LAB_ES_Result_CH4.AutoSize = true;
            this.LAB_ES_Result_CH4.Location = new System.Drawing.Point(180, 177);
            this.LAB_ES_Result_CH4.Name = "LAB_ES_Result_CH4";
            this.LAB_ES_Result_CH4.Size = new System.Drawing.Size(66, 20);
            this.LAB_ES_Result_CH4.TabIndex = 24;
            this.LAB_ES_Result_CH4.Text = "0.00%";
            // 
            // LAB_BER_Result_CH4
            // 
            this.LAB_BER_Result_CH4.AutoSize = true;
            this.LAB_BER_Result_CH4.Location = new System.Drawing.Point(180, 146);
            this.LAB_BER_Result_CH4.Name = "LAB_BER_Result_CH4";
            this.LAB_BER_Result_CH4.Size = new System.Drawing.Size(87, 20);
            this.LAB_BER_Result_CH4.TabIndex = 23;
            this.LAB_BER_Result_CH4.Text = "0.00E-00";
            // 
            // LAB_Err_Cnt_Result_CH4
            // 
            this.LAB_Err_Cnt_Result_CH4.AutoSize = true;
            this.LAB_Err_Cnt_Result_CH4.Font = new System.Drawing.Font("Meiryo UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.LAB_Err_Cnt_Result_CH4.Location = new System.Drawing.Point(180, 116);
            this.LAB_Err_Cnt_Result_CH4.Name = "LAB_Err_Cnt_Result_CH4";
            this.LAB_Err_Cnt_Result_CH4.Size = new System.Drawing.Size(80, 20);
            this.LAB_Err_Cnt_Result_CH4.TabIndex = 18;
            this.LAB_Err_Cnt_Result_CH4.Text = "0.00E00";
            this.LAB_Err_Cnt_Result_CH4.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // LAB_Data_Cnt_Result_CH4
            // 
            this.LAB_Data_Cnt_Result_CH4.AutoSize = true;
            this.LAB_Data_Cnt_Result_CH4.Font = new System.Drawing.Font("Meiryo UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.LAB_Data_Cnt_Result_CH4.Location = new System.Drawing.Point(180, 86);
            this.LAB_Data_Cnt_Result_CH4.Name = "LAB_Data_Cnt_Result_CH4";
            this.LAB_Data_Cnt_Result_CH4.Size = new System.Drawing.Size(80, 20);
            this.LAB_Data_Cnt_Result_CH4.TabIndex = 16;
            this.LAB_Data_Cnt_Result_CH4.Text = "0.00E00";
            this.LAB_Data_Cnt_Result_CH4.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // LAB_Mesure_Time_Result_CH4
            // 
            this.LAB_Mesure_Time_Result_CH4.AutoSize = true;
            this.LAB_Mesure_Time_Result_CH4.Font = new System.Drawing.Font("Meiryo UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.LAB_Mesure_Time_Result_CH4.Location = new System.Drawing.Point(179, 53);
            this.LAB_Mesure_Time_Result_CH4.Name = "LAB_Mesure_Time_Result_CH4";
            this.LAB_Mesure_Time_Result_CH4.Size = new System.Drawing.Size(20, 20);
            this.LAB_Mesure_Time_Result_CH4.TabIndex = 14;
            this.LAB_Mesure_Time_Result_CH4.Text = "0";
            this.LAB_Mesure_Time_Result_CH4.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // BTN_Cnt_Rst_CH4
            // 
            this.BTN_Cnt_Rst_CH4.BackColor = System.Drawing.SystemColors.Control;
            this.BTN_Cnt_Rst_CH4.Font = new System.Drawing.Font("Meiryo UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.BTN_Cnt_Rst_CH4.Location = new System.Drawing.Point(143, 11);
            this.BTN_Cnt_Rst_CH4.Name = "BTN_Cnt_Rst_CH4";
            this.BTN_Cnt_Rst_CH4.Size = new System.Drawing.Size(162, 36);
            this.BTN_Cnt_Rst_CH4.TabIndex = 13;
            this.BTN_Cnt_Rst_CH4.Text = "COUNTER RESET";
            this.BTN_Cnt_Rst_CH4.UseVisualStyleBackColor = false;
            this.BTN_Cnt_Rst_CH4.Click += new System.EventHandler(this.BTN_Cnt_Rst_CH4_Click);
            // 
            // GBOX_Monitor_CH4
            // 
            this.GBOX_Monitor_CH4.Controls.Add(this.BTN_Flg_Rst_CH4);
            this.GBOX_Monitor_CH4.Controls.Add(this.PBOX_ERR_CH4);
            this.GBOX_Monitor_CH4.Controls.Add(this.PBOX_LOS_CH4);
            this.GBOX_Monitor_CH4.Controls.Add(LAB_ERR_CH4);
            this.GBOX_Monitor_CH4.Controls.Add(this.PBOX_ERR_FLG_CH4);
            this.GBOX_Monitor_CH4.Controls.Add(LAB_LOS_CH4);
            this.GBOX_Monitor_CH4.Location = new System.Drawing.Point(23, 254);
            this.GBOX_Monitor_CH4.Name = "GBOX_Monitor_CH4";
            this.GBOX_Monitor_CH4.Size = new System.Drawing.Size(343, 126);
            this.GBOX_Monitor_CH4.TabIndex = 14;
            this.GBOX_Monitor_CH4.TabStop = false;
            this.GBOX_Monitor_CH4.Text = "Monitor";
            // 
            // BTN_Flg_Rst_CH4
            // 
            this.BTN_Flg_Rst_CH4.BackColor = System.Drawing.SystemColors.Control;
            this.BTN_Flg_Rst_CH4.Font = new System.Drawing.Font("Meiryo UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.BTN_Flg_Rst_CH4.Location = new System.Drawing.Point(143, 11);
            this.BTN_Flg_Rst_CH4.Name = "BTN_Flg_Rst_CH4";
            this.BTN_Flg_Rst_CH4.Size = new System.Drawing.Size(162, 36);
            this.BTN_Flg_Rst_CH4.TabIndex = 13;
            this.BTN_Flg_Rst_CH4.Text = "FLAG RESET";
            this.BTN_Flg_Rst_CH4.UseVisualStyleBackColor = false;
            this.BTN_Flg_Rst_CH4.Click += new System.EventHandler(this.BTN_Flg_Rst_CH4_Click);
            // 
            // PBOX_ERR_CH4
            // 
            this.PBOX_ERR_CH4.ErrorImage = global::BERT.Properties.Resources.led_red;
            this.PBOX_ERR_CH4.Image = global::BERT.Properties.Resources.led_off;
            this.PBOX_ERR_CH4.InitialImage = global::BERT.Properties.Resources.led_green;
            this.PBOX_ERR_CH4.Location = new System.Drawing.Point(183, 83);
            this.PBOX_ERR_CH4.Name = "PBOX_ERR_CH4";
            this.PBOX_ERR_CH4.Size = new System.Drawing.Size(32, 32);
            this.PBOX_ERR_CH4.TabIndex = 17;
            this.PBOX_ERR_CH4.TabStop = false;
            // 
            // PBOX_LOS_CH4
            // 
            this.PBOX_LOS_CH4.ErrorImage = global::BERT.Properties.Resources.led_red;
            this.PBOX_LOS_CH4.Image = global::BERT.Properties.Resources.led_off;
            this.PBOX_LOS_CH4.InitialImage = global::BERT.Properties.Resources.led_green;
            this.PBOX_LOS_CH4.Location = new System.Drawing.Point(183, 47);
            this.PBOX_LOS_CH4.Name = "PBOX_LOS_CH4";
            this.PBOX_LOS_CH4.Size = new System.Drawing.Size(32, 32);
            this.PBOX_LOS_CH4.TabIndex = 6;
            this.PBOX_LOS_CH4.TabStop = false;
            // 
            // PBOX_ERR_FLG_CH4
            // 
            this.PBOX_ERR_FLG_CH4.ErrorImage = global::BERT.Properties.Resources.led_red;
            this.PBOX_ERR_FLG_CH4.Image = global::BERT.Properties.Resources.led_off;
            this.PBOX_ERR_FLG_CH4.InitialImage = global::BERT.Properties.Resources.led_green;
            this.PBOX_ERR_FLG_CH4.Location = new System.Drawing.Point(237, 83);
            this.PBOX_ERR_FLG_CH4.Name = "PBOX_ERR_FLG_CH4";
            this.PBOX_ERR_FLG_CH4.Size = new System.Drawing.Size(32, 32);
            this.PBOX_ERR_FLG_CH4.TabIndex = 15;
            this.PBOX_ERR_FLG_CH4.TabStop = false;
            // 
            // GBOX_Setting_CH4
            // 
            this.GBOX_Setting_CH4.Controls.Add(this.LAB_LENGTH_CH4_Val);
            this.GBOX_Setting_CH4.Controls.Add(LAB_LENGTH_CH4_unit);
            this.GBOX_Setting_CH4.Controls.Add(this.CMB_PN_CH4);
            this.GBOX_Setting_CH4.Controls.Add(LAB_LENGTH_CH4);
            this.GBOX_Setting_CH4.Controls.Add(LAB_PN_CH4);
            this.GBOX_Setting_CH4.Location = new System.Drawing.Point(23, 168);
            this.GBOX_Setting_CH4.Name = "GBOX_Setting_CH4";
            this.GBOX_Setting_CH4.Size = new System.Drawing.Size(343, 86);
            this.GBOX_Setting_CH4.TabIndex = 12;
            this.GBOX_Setting_CH4.TabStop = false;
            this.GBOX_Setting_CH4.Text = "Setting";
            // 
            // LAB_LENGTH_CH4_Val
            // 
            this.LAB_LENGTH_CH4_Val.Location = new System.Drawing.Point(204, 52);
            this.LAB_LENGTH_CH4_Val.Name = "LAB_LENGTH_CH4_Val";
            this.LAB_LENGTH_CH4_Val.Size = new System.Drawing.Size(100, 20);
            this.LAB_LENGTH_CH4_Val.TabIndex = 31;
            this.LAB_LENGTH_CH4_Val.Text = "127";
            this.LAB_LENGTH_CH4_Val.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // CMB_PN_CH4
            // 
            this.CMB_PN_CH4.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.CMB_PN_CH4.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CMB_PN_CH4.Font = new System.Drawing.Font("MS UI Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.CMB_PN_CH4.FormattingEnabled = true;
            this.CMB_PN_CH4.Items.AddRange(new object[] {
            "PN7",
            "PN15",
            "PN23",
            "PN31",
            "PROGRAM"});
            this.CMB_PN_CH4.Location = new System.Drawing.Point(204, 20);
            this.CMB_PN_CH4.Name = "CMB_PN_CH4";
            this.CMB_PN_CH4.Size = new System.Drawing.Size(102, 23);
            this.CMB_PN_CH4.TabIndex = 25;
            this.CMB_PN_CH4.DrawItem += new System.Windows.Forms.DrawItemEventHandler(this.CMB_PN_CH4_DrawItem);
            this.CMB_PN_CH4.SelectedIndexChanged += new System.EventHandler(this.CMB_PN_CH4_SelectedIndexChanged);
            // 
            // BTN_Sync_CH4
            // 
            this.BTN_Sync_CH4.BackColor = System.Drawing.SystemColors.Control;
            this.BTN_Sync_CH4.Font = new System.Drawing.Font("Meiryo UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.BTN_Sync_CH4.Location = new System.Drawing.Point(226, 130);
            this.BTN_Sync_CH4.Name = "BTN_Sync_CH4";
            this.BTN_Sync_CH4.Size = new System.Drawing.Size(101, 36);
            this.BTN_Sync_CH4.TabIndex = 19;
            this.BTN_Sync_CH4.Text = "RESYNC";
            this.BTN_Sync_CH4.UseVisualStyleBackColor = false;
            this.BTN_Sync_CH4.Click += new System.EventHandler(this.BTN_Sync_CH4_Click);
            // 
            // BTN_TX_OUT_CH4
            // 
            this.BTN_TX_OUT_CH4.BackColor = System.Drawing.SystemColors.Control;
            this.BTN_TX_OUT_CH4.Font = new System.Drawing.Font("Meiryo UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.BTN_TX_OUT_CH4.Location = new System.Drawing.Point(227, 22);
            this.BTN_TX_OUT_CH4.Name = "BTN_TX_OUT_CH4";
            this.BTN_TX_OUT_CH4.Size = new System.Drawing.Size(101, 36);
            this.BTN_TX_OUT_CH4.TabIndex = 11;
            this.BTN_TX_OUT_CH4.Text = "OFF";
            this.BTN_TX_OUT_CH4.UseVisualStyleBackColor = false;
            this.BTN_TX_OUT_CH4.Click += new System.EventHandler(this.BTN_TX_OUT_CH4_Click);
            // 
            // LAB_Sync_CH4
            // 
            this.LAB_Sync_CH4.AutoSize = true;
            this.LAB_Sync_CH4.Font = new System.Drawing.Font("Meiryo UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.LAB_Sync_CH4.Location = new System.Drawing.Point(11, 137);
            this.LAB_Sync_CH4.Name = "LAB_Sync_CH4";
            this.LAB_Sync_CH4.Size = new System.Drawing.Size(77, 20);
            this.LAB_Sync_CH4.TabIndex = 18;
            this.LAB_Sync_CH4.Text = "RESYNC";
            this.LAB_Sync_CH4.UseMnemonic = false;
            // 
            // GBOX_CH3
            // 
            this.GBOX_CH3.Controls.Add(this.PBOX_Tx_STS_3);
            this.GBOX_CH3.Controls.Add(this.CBOX_ReSync_Mode_CH3);
            this.GBOX_CH3.Controls.Add(this.LAB_ReSync_Mode_CH3);
            this.GBOX_CH3.Controls.Add(this.BTN_MES_CH3);
            this.GBOX_CH3.Controls.Add(LAB_Mesure_CH3);
            this.GBOX_CH3.Controls.Add(this.GBOX_Result_CH3);
            this.GBOX_CH3.Controls.Add(this.GBOX_Monitor_CH3);
            this.GBOX_CH3.Controls.Add(this.GBOX_Setting_CH3);
            this.GBOX_CH3.Controls.Add(this.BTN_Sync_CH3);
            this.GBOX_CH3.Controls.Add(this.BTN_TX_OUT_CH3);
            this.GBOX_CH3.Controls.Add(this.LAB_Sync_CH3);
            this.GBOX_CH3.Controls.Add(LAB_TXout_CH3);
            this.GBOX_CH3.Font = new System.Drawing.Font("Meiryo UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.GBOX_CH3.Location = new System.Drawing.Point(895, 59);
            this.GBOX_CH3.Name = "GBOX_CH3";
            this.GBOX_CH3.Size = new System.Drawing.Size(385, 603);
            this.GBOX_CH3.TabIndex = 25;
            this.GBOX_CH3.TabStop = false;
            this.GBOX_CH3.Text = "CH3";
            // 
            // PBOX_Tx_STS_3
            // 
            this.PBOX_Tx_STS_3.ErrorImage = global::BERT.Properties.Resources.led_red;
            this.PBOX_Tx_STS_3.Image = global::BERT.Properties.Resources.led_off;
            this.PBOX_Tx_STS_3.InitialImage = global::BERT.Properties.Resources.led_green;
            this.PBOX_Tx_STS_3.Location = new System.Drawing.Point(187, 24);
            this.PBOX_Tx_STS_3.Name = "PBOX_Tx_STS_3";
            this.PBOX_Tx_STS_3.Size = new System.Drawing.Size(32, 32);
            this.PBOX_Tx_STS_3.TabIndex = 18;
            this.PBOX_Tx_STS_3.TabStop = false;
            this.PBOX_Tx_STS_3.Visible = false;
            // 
            // CBOX_ReSync_Mode_CH3
            // 
            this.CBOX_ReSync_Mode_CH3.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.CBOX_ReSync_Mode_CH3.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CBOX_ReSync_Mode_CH3.Font = new System.Drawing.Font("MS UI Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.CBOX_ReSync_Mode_CH3.FormattingEnabled = true;
            this.CBOX_ReSync_Mode_CH3.Items.AddRange(new object[] {
            "Auto",
            "Manual"});
            this.CBOX_ReSync_Mode_CH3.Location = new System.Drawing.Point(227, 103);
            this.CBOX_ReSync_Mode_CH3.Name = "CBOX_ReSync_Mode_CH3";
            this.CBOX_ReSync_Mode_CH3.Size = new System.Drawing.Size(102, 24);
            this.CBOX_ReSync_Mode_CH3.TabIndex = 24;
            this.CBOX_ReSync_Mode_CH3.DrawItem += new System.Windows.Forms.DrawItemEventHandler(this.CBOX_ReSync_Mode_CH3_DrawItem);
            this.CBOX_ReSync_Mode_CH3.SelectedIndexChanged += new System.EventHandler(this.CBOX_ReSync_Mode_CH3_SelectedIndexChanged);
            // 
            // LAB_ReSync_Mode_CH3
            // 
            this.LAB_ReSync_Mode_CH3.AutoSize = true;
            this.LAB_ReSync_Mode_CH3.Font = new System.Drawing.Font("Meiryo UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.LAB_ReSync_Mode_CH3.Location = new System.Drawing.Point(11, 106);
            this.LAB_ReSync_Mode_CH3.Name = "LAB_ReSync_Mode_CH3";
            this.LAB_ReSync_Mode_CH3.Size = new System.Drawing.Size(133, 20);
            this.LAB_ReSync_Mode_CH3.TabIndex = 24;
            this.LAB_ReSync_Mode_CH3.Text = "RESYNC MODE";
            this.LAB_ReSync_Mode_CH3.UseMnemonic = false;
            // 
            // BTN_MES_CH3
            // 
            this.BTN_MES_CH3.BackColor = System.Drawing.SystemColors.Control;
            this.BTN_MES_CH3.Font = new System.Drawing.Font("Meiryo UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.BTN_MES_CH3.Location = new System.Drawing.Point(227, 62);
            this.BTN_MES_CH3.Name = "BTN_MES_CH3";
            this.BTN_MES_CH3.Size = new System.Drawing.Size(101, 36);
            this.BTN_MES_CH3.TabIndex = 23;
            this.BTN_MES_CH3.Text = "OFF";
            this.BTN_MES_CH3.UseVisualStyleBackColor = false;
            this.BTN_MES_CH3.Click += new System.EventHandler(this.BTN_MES_CH3_Click);
            // 
            // GBOX_Result_CH3
            // 
            this.GBOX_Result_CH3.Controls.Add(this.LAB_ES_Result_CH3);
            this.GBOX_Result_CH3.Controls.Add(this.LAB_BER_Result_CH3);
            this.GBOX_Result_CH3.Controls.Add(LAB_ES_CH3);
            this.GBOX_Result_CH3.Controls.Add(LAB_BER_CH3);
            this.GBOX_Result_CH3.Controls.Add(this.LAB_Err_Cnt_Result_CH3);
            this.GBOX_Result_CH3.Controls.Add(LAB_Err_Cnt_CH3);
            this.GBOX_Result_CH3.Controls.Add(this.LAB_Data_Cnt_Result_CH3);
            this.GBOX_Result_CH3.Controls.Add(LAB_Data_Cnt_CH3);
            this.GBOX_Result_CH3.Controls.Add(this.LAB_Mesure_Time_Result_CH3);
            this.GBOX_Result_CH3.Controls.Add(this.BTN_Cnt_Rst_CH3);
            this.GBOX_Result_CH3.Controls.Add(LAB_Mesure_Time_CH3);
            this.GBOX_Result_CH3.Location = new System.Drawing.Point(23, 380);
            this.GBOX_Result_CH3.Name = "GBOX_Result_CH3";
            this.GBOX_Result_CH3.Size = new System.Drawing.Size(343, 212);
            this.GBOX_Result_CH3.TabIndex = 16;
            this.GBOX_Result_CH3.TabStop = false;
            this.GBOX_Result_CH3.Text = "Result";
            // 
            // LAB_ES_Result_CH3
            // 
            this.LAB_ES_Result_CH3.AutoSize = true;
            this.LAB_ES_Result_CH3.Location = new System.Drawing.Point(180, 177);
            this.LAB_ES_Result_CH3.Name = "LAB_ES_Result_CH3";
            this.LAB_ES_Result_CH3.Size = new System.Drawing.Size(66, 20);
            this.LAB_ES_Result_CH3.TabIndex = 24;
            this.LAB_ES_Result_CH3.Text = "0.00%";
            // 
            // LAB_BER_Result_CH3
            // 
            this.LAB_BER_Result_CH3.AutoSize = true;
            this.LAB_BER_Result_CH3.Location = new System.Drawing.Point(180, 146);
            this.LAB_BER_Result_CH3.Name = "LAB_BER_Result_CH3";
            this.LAB_BER_Result_CH3.Size = new System.Drawing.Size(87, 20);
            this.LAB_BER_Result_CH3.TabIndex = 23;
            this.LAB_BER_Result_CH3.Text = "0.00E-00";
            // 
            // LAB_Err_Cnt_Result_CH3
            // 
            this.LAB_Err_Cnt_Result_CH3.AutoSize = true;
            this.LAB_Err_Cnt_Result_CH3.Font = new System.Drawing.Font("Meiryo UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.LAB_Err_Cnt_Result_CH3.Location = new System.Drawing.Point(180, 116);
            this.LAB_Err_Cnt_Result_CH3.Name = "LAB_Err_Cnt_Result_CH3";
            this.LAB_Err_Cnt_Result_CH3.Size = new System.Drawing.Size(80, 20);
            this.LAB_Err_Cnt_Result_CH3.TabIndex = 18;
            this.LAB_Err_Cnt_Result_CH3.Text = "0.00E00";
            this.LAB_Err_Cnt_Result_CH3.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // LAB_Data_Cnt_Result_CH3
            // 
            this.LAB_Data_Cnt_Result_CH3.AutoSize = true;
            this.LAB_Data_Cnt_Result_CH3.Font = new System.Drawing.Font("Meiryo UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.LAB_Data_Cnt_Result_CH3.Location = new System.Drawing.Point(180, 86);
            this.LAB_Data_Cnt_Result_CH3.Name = "LAB_Data_Cnt_Result_CH3";
            this.LAB_Data_Cnt_Result_CH3.Size = new System.Drawing.Size(80, 20);
            this.LAB_Data_Cnt_Result_CH3.TabIndex = 16;
            this.LAB_Data_Cnt_Result_CH3.Text = "0.00E00";
            this.LAB_Data_Cnt_Result_CH3.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // LAB_Mesure_Time_Result_CH3
            // 
            this.LAB_Mesure_Time_Result_CH3.AutoSize = true;
            this.LAB_Mesure_Time_Result_CH3.Font = new System.Drawing.Font("Meiryo UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.LAB_Mesure_Time_Result_CH3.Location = new System.Drawing.Point(179, 53);
            this.LAB_Mesure_Time_Result_CH3.Name = "LAB_Mesure_Time_Result_CH3";
            this.LAB_Mesure_Time_Result_CH3.Size = new System.Drawing.Size(20, 20);
            this.LAB_Mesure_Time_Result_CH3.TabIndex = 14;
            this.LAB_Mesure_Time_Result_CH3.Text = "0";
            this.LAB_Mesure_Time_Result_CH3.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // BTN_Cnt_Rst_CH3
            // 
            this.BTN_Cnt_Rst_CH3.BackColor = System.Drawing.SystemColors.Control;
            this.BTN_Cnt_Rst_CH3.Font = new System.Drawing.Font("Meiryo UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.BTN_Cnt_Rst_CH3.Location = new System.Drawing.Point(143, 11);
            this.BTN_Cnt_Rst_CH3.Name = "BTN_Cnt_Rst_CH3";
            this.BTN_Cnt_Rst_CH3.Size = new System.Drawing.Size(162, 36);
            this.BTN_Cnt_Rst_CH3.TabIndex = 13;
            this.BTN_Cnt_Rst_CH3.Text = "COUNTER RESET";
            this.BTN_Cnt_Rst_CH3.UseVisualStyleBackColor = false;
            this.BTN_Cnt_Rst_CH3.Click += new System.EventHandler(this.BTN_Cnt_Rst_CH3_Click);
            // 
            // GBOX_Monitor_CH3
            // 
            this.GBOX_Monitor_CH3.Controls.Add(this.BTN_Flg_Rst_CH3);
            this.GBOX_Monitor_CH3.Controls.Add(this.PBOX_ERR_CH3);
            this.GBOX_Monitor_CH3.Controls.Add(this.PBOX_LOS_CH3);
            this.GBOX_Monitor_CH3.Controls.Add(LAB_ERR_CH3);
            this.GBOX_Monitor_CH3.Controls.Add(this.PBOX_ERR_FLG_CH3);
            this.GBOX_Monitor_CH3.Controls.Add(LAB_LOS_CH3);
            this.GBOX_Monitor_CH3.Location = new System.Drawing.Point(23, 254);
            this.GBOX_Monitor_CH3.Name = "GBOX_Monitor_CH3";
            this.GBOX_Monitor_CH3.Size = new System.Drawing.Size(343, 126);
            this.GBOX_Monitor_CH3.TabIndex = 14;
            this.GBOX_Monitor_CH3.TabStop = false;
            this.GBOX_Monitor_CH3.Text = "Monitor";
            // 
            // BTN_Flg_Rst_CH3
            // 
            this.BTN_Flg_Rst_CH3.BackColor = System.Drawing.SystemColors.Control;
            this.BTN_Flg_Rst_CH3.Font = new System.Drawing.Font("Meiryo UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.BTN_Flg_Rst_CH3.Location = new System.Drawing.Point(143, 11);
            this.BTN_Flg_Rst_CH3.Name = "BTN_Flg_Rst_CH3";
            this.BTN_Flg_Rst_CH3.Size = new System.Drawing.Size(162, 36);
            this.BTN_Flg_Rst_CH3.TabIndex = 13;
            this.BTN_Flg_Rst_CH3.Text = "FLAG RESET";
            this.BTN_Flg_Rst_CH3.UseVisualStyleBackColor = false;
            this.BTN_Flg_Rst_CH3.Click += new System.EventHandler(this.BTN_Flg_Rst_CH3_Click);
            // 
            // PBOX_ERR_CH3
            // 
            this.PBOX_ERR_CH3.ErrorImage = global::BERT.Properties.Resources.led_red;
            this.PBOX_ERR_CH3.Image = global::BERT.Properties.Resources.led_off;
            this.PBOX_ERR_CH3.InitialImage = global::BERT.Properties.Resources.led_green;
            this.PBOX_ERR_CH3.Location = new System.Drawing.Point(183, 83);
            this.PBOX_ERR_CH3.Name = "PBOX_ERR_CH3";
            this.PBOX_ERR_CH3.Size = new System.Drawing.Size(32, 32);
            this.PBOX_ERR_CH3.TabIndex = 17;
            this.PBOX_ERR_CH3.TabStop = false;
            // 
            // PBOX_LOS_CH3
            // 
            this.PBOX_LOS_CH3.ErrorImage = global::BERT.Properties.Resources.led_red;
            this.PBOX_LOS_CH3.Image = global::BERT.Properties.Resources.led_off;
            this.PBOX_LOS_CH3.InitialImage = global::BERT.Properties.Resources.led_green;
            this.PBOX_LOS_CH3.Location = new System.Drawing.Point(183, 47);
            this.PBOX_LOS_CH3.Name = "PBOX_LOS_CH3";
            this.PBOX_LOS_CH3.Size = new System.Drawing.Size(32, 32);
            this.PBOX_LOS_CH3.TabIndex = 6;
            this.PBOX_LOS_CH3.TabStop = false;
            // 
            // PBOX_ERR_FLG_CH3
            // 
            this.PBOX_ERR_FLG_CH3.ErrorImage = global::BERT.Properties.Resources.led_red;
            this.PBOX_ERR_FLG_CH3.Image = global::BERT.Properties.Resources.led_off;
            this.PBOX_ERR_FLG_CH3.InitialImage = global::BERT.Properties.Resources.led_green;
            this.PBOX_ERR_FLG_CH3.Location = new System.Drawing.Point(237, 83);
            this.PBOX_ERR_FLG_CH3.Name = "PBOX_ERR_FLG_CH3";
            this.PBOX_ERR_FLG_CH3.Size = new System.Drawing.Size(32, 32);
            this.PBOX_ERR_FLG_CH3.TabIndex = 15;
            this.PBOX_ERR_FLG_CH3.TabStop = false;
            // 
            // GBOX_Setting_CH3
            // 
            this.GBOX_Setting_CH3.Controls.Add(this.LAB_LENGTH_CH3_Val);
            this.GBOX_Setting_CH3.Controls.Add(LAB_LENGTH_CH3_unit);
            this.GBOX_Setting_CH3.Controls.Add(this.CMB_PN_CH3);
            this.GBOX_Setting_CH3.Controls.Add(LAB_LENGTH_CH3);
            this.GBOX_Setting_CH3.Controls.Add(LAB_PN_CH3);
            this.GBOX_Setting_CH3.Location = new System.Drawing.Point(23, 168);
            this.GBOX_Setting_CH3.Name = "GBOX_Setting_CH3";
            this.GBOX_Setting_CH3.Size = new System.Drawing.Size(343, 86);
            this.GBOX_Setting_CH3.TabIndex = 12;
            this.GBOX_Setting_CH3.TabStop = false;
            this.GBOX_Setting_CH3.Text = "Setting";
            // 
            // LAB_LENGTH_CH3_Val
            // 
            this.LAB_LENGTH_CH3_Val.Location = new System.Drawing.Point(205, 54);
            this.LAB_LENGTH_CH3_Val.Name = "LAB_LENGTH_CH3_Val";
            this.LAB_LENGTH_CH3_Val.Size = new System.Drawing.Size(100, 20);
            this.LAB_LENGTH_CH3_Val.TabIndex = 30;
            this.LAB_LENGTH_CH3_Val.Text = "127";
            this.LAB_LENGTH_CH3_Val.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // CMB_PN_CH3
            // 
            this.CMB_PN_CH3.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.CMB_PN_CH3.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CMB_PN_CH3.Font = new System.Drawing.Font("MS UI Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.CMB_PN_CH3.FormattingEnabled = true;
            this.CMB_PN_CH3.Items.AddRange(new object[] {
            "PN7",
            "PN15",
            "PN23",
            "PN31",
            "PROGRAM"});
            this.CMB_PN_CH3.Location = new System.Drawing.Point(204, 20);
            this.CMB_PN_CH3.Name = "CMB_PN_CH3";
            this.CMB_PN_CH3.Size = new System.Drawing.Size(102, 23);
            this.CMB_PN_CH3.TabIndex = 25;
            this.CMB_PN_CH3.DrawItem += new System.Windows.Forms.DrawItemEventHandler(this.CMB_PN_CH3_DrawItem);
            this.CMB_PN_CH3.SelectedIndexChanged += new System.EventHandler(this.CMB_PN_CH3_SelectedIndexChanged);
            // 
            // BTN_Sync_CH3
            // 
            this.BTN_Sync_CH3.BackColor = System.Drawing.SystemColors.Control;
            this.BTN_Sync_CH3.Font = new System.Drawing.Font("Meiryo UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.BTN_Sync_CH3.Location = new System.Drawing.Point(226, 130);
            this.BTN_Sync_CH3.Name = "BTN_Sync_CH3";
            this.BTN_Sync_CH3.Size = new System.Drawing.Size(101, 36);
            this.BTN_Sync_CH3.TabIndex = 19;
            this.BTN_Sync_CH3.Text = "RESYNC";
            this.BTN_Sync_CH3.UseVisualStyleBackColor = false;
            this.BTN_Sync_CH3.Click += new System.EventHandler(this.BTN_Sync_CH3_Click);
            // 
            // BTN_TX_OUT_CH3
            // 
            this.BTN_TX_OUT_CH3.BackColor = System.Drawing.SystemColors.Control;
            this.BTN_TX_OUT_CH3.Font = new System.Drawing.Font("Meiryo UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.BTN_TX_OUT_CH3.Location = new System.Drawing.Point(227, 22);
            this.BTN_TX_OUT_CH3.Name = "BTN_TX_OUT_CH3";
            this.BTN_TX_OUT_CH3.Size = new System.Drawing.Size(101, 36);
            this.BTN_TX_OUT_CH3.TabIndex = 11;
            this.BTN_TX_OUT_CH3.Text = "OFF";
            this.BTN_TX_OUT_CH3.UseVisualStyleBackColor = false;
            this.BTN_TX_OUT_CH3.Click += new System.EventHandler(this.BTN_TX_OUT_CH3_Click);
            // 
            // LAB_Sync_CH3
            // 
            this.LAB_Sync_CH3.AutoSize = true;
            this.LAB_Sync_CH3.Font = new System.Drawing.Font("Meiryo UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.LAB_Sync_CH3.Location = new System.Drawing.Point(11, 137);
            this.LAB_Sync_CH3.Name = "LAB_Sync_CH3";
            this.LAB_Sync_CH3.Size = new System.Drawing.Size(77, 20);
            this.LAB_Sync_CH3.TabIndex = 18;
            this.LAB_Sync_CH3.Text = "RESYNC";
            this.LAB_Sync_CH3.UseMnemonic = false;
            // 
            // GBOX_ALL
            // 
            this.GBOX_ALL.Controls.Add(this.BTN_ALL_COUNTER_RESET);
            this.GBOX_ALL.Controls.Add(this.LAB_ALL_COUNTER);
            this.GBOX_ALL.Controls.Add(this.BTN_ALL_FLAG_RESET);
            this.GBOX_ALL.Controls.Add(this.LAB_ALL_FLAG);
            this.GBOX_ALL.Controls.Add(this.BTN_ALL_RESYNC);
            this.GBOX_ALL.Controls.Add(this.LAB_ALL_RESYNC);
            this.GBOX_ALL.Controls.Add(this.BTN_ALL_MEASURE);
            this.GBOX_ALL.Controls.Add(this.LAB_ALL_MEASURE);
            this.GBOX_ALL.Controls.Add(this.BTN_ALL_TX);
            this.GBOX_ALL.Controls.Add(this.LAB_ALL_TX_OUT);
            this.GBOX_ALL.Enabled = false;
            this.GBOX_ALL.Font = new System.Drawing.Font("Meiryo UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.GBOX_ALL.Location = new System.Drawing.Point(1171, 50);
            this.GBOX_ALL.Name = "GBOX_ALL";
            this.GBOX_ALL.Size = new System.Drawing.Size(529, 90);
            this.GBOX_ALL.TabIndex = 3;
            this.GBOX_ALL.TabStop = false;
            this.GBOX_ALL.Text = "ALL";
            // 
            // BTN_ALL_COUNTER_RESET
            // 
            this.BTN_ALL_COUNTER_RESET.Location = new System.Drawing.Point(416, 45);
            this.BTN_ALL_COUNTER_RESET.Name = "BTN_ALL_COUNTER_RESET";
            this.BTN_ALL_COUNTER_RESET.Size = new System.Drawing.Size(88, 29);
            this.BTN_ALL_COUNTER_RESET.TabIndex = 9;
            this.BTN_ALL_COUNTER_RESET.Text = "RESET";
            this.BTN_ALL_COUNTER_RESET.UseVisualStyleBackColor = true;
            this.BTN_ALL_COUNTER_RESET.Click += new System.EventHandler(this.BTN_ALL_COUNTER_RESET_Click);
            // 
            // LAB_ALL_COUNTER
            // 
            this.LAB_ALL_COUNTER.AutoSize = true;
            this.LAB_ALL_COUNTER.Font = new System.Drawing.Font("Meiryo UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.LAB_ALL_COUNTER.Location = new System.Drawing.Point(424, 28);
            this.LAB_ALL_COUNTER.Name = "LAB_ALL_COUNTER";
            this.LAB_ALL_COUNTER.Size = new System.Drawing.Size(75, 17);
            this.LAB_ALL_COUNTER.TabIndex = 8;
            this.LAB_ALL_COUNTER.Text = "COUNTER";
            // 
            // BTN_ALL_FLAG_RESET
            // 
            this.BTN_ALL_FLAG_RESET.Location = new System.Drawing.Point(317, 45);
            this.BTN_ALL_FLAG_RESET.Name = "BTN_ALL_FLAG_RESET";
            this.BTN_ALL_FLAG_RESET.Size = new System.Drawing.Size(88, 29);
            this.BTN_ALL_FLAG_RESET.TabIndex = 7;
            this.BTN_ALL_FLAG_RESET.Text = "RESET";
            this.BTN_ALL_FLAG_RESET.UseVisualStyleBackColor = true;
            this.BTN_ALL_FLAG_RESET.Click += new System.EventHandler(this.BTN_ALL_FLAG_RESET_Click);
            // 
            // LAB_ALL_FLAG
            // 
            this.LAB_ALL_FLAG.AutoSize = true;
            this.LAB_ALL_FLAG.Font = new System.Drawing.Font("Meiryo UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.LAB_ALL_FLAG.Location = new System.Drawing.Point(340, 28);
            this.LAB_ALL_FLAG.Name = "LAB_ALL_FLAG";
            this.LAB_ALL_FLAG.Size = new System.Drawing.Size(44, 17);
            this.LAB_ALL_FLAG.TabIndex = 6;
            this.LAB_ALL_FLAG.Text = "FLAG";
            // 
            // BTN_ALL_RESYNC
            // 
            this.BTN_ALL_RESYNC.Location = new System.Drawing.Point(219, 45);
            this.BTN_ALL_RESYNC.Name = "BTN_ALL_RESYNC";
            this.BTN_ALL_RESYNC.Size = new System.Drawing.Size(88, 29);
            this.BTN_ALL_RESYNC.TabIndex = 5;
            this.BTN_ALL_RESYNC.Text = "RESYNC";
            this.BTN_ALL_RESYNC.UseVisualStyleBackColor = true;
            this.BTN_ALL_RESYNC.Click += new System.EventHandler(this.BTN_ALL_RESYNC_Click);
            // 
            // LAB_ALL_RESYNC
            // 
            this.LAB_ALL_RESYNC.AutoSize = true;
            this.LAB_ALL_RESYNC.Font = new System.Drawing.Font("Meiryo UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.LAB_ALL_RESYNC.Location = new System.Drawing.Point(232, 28);
            this.LAB_ALL_RESYNC.Name = "LAB_ALL_RESYNC";
            this.LAB_ALL_RESYNC.Size = new System.Drawing.Size(64, 17);
            this.LAB_ALL_RESYNC.TabIndex = 4;
            this.LAB_ALL_RESYNC.Text = "RESYNC";
            // 
            // BTN_ALL_MEASURE
            // 
            this.BTN_ALL_MEASURE.Location = new System.Drawing.Point(122, 45);
            this.BTN_ALL_MEASURE.Name = "BTN_ALL_MEASURE";
            this.BTN_ALL_MEASURE.Size = new System.Drawing.Size(88, 29);
            this.BTN_ALL_MEASURE.TabIndex = 3;
            this.BTN_ALL_MEASURE.Text = "ON";
            this.BTN_ALL_MEASURE.UseVisualStyleBackColor = true;
            this.BTN_ALL_MEASURE.Click += new System.EventHandler(this.BTN_ALL_MEASURE_Click);
            // 
            // LAB_ALL_MEASURE
            // 
            this.LAB_ALL_MEASURE.AutoSize = true;
            this.LAB_ALL_MEASURE.Font = new System.Drawing.Font("Meiryo UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.LAB_ALL_MEASURE.Location = new System.Drawing.Point(129, 28);
            this.LAB_ALL_MEASURE.Name = "LAB_ALL_MEASURE";
            this.LAB_ALL_MEASURE.Size = new System.Drawing.Size(75, 17);
            this.LAB_ALL_MEASURE.TabIndex = 2;
            this.LAB_ALL_MEASURE.Text = "MEASURE";
            // 
            // BTN_ALL_TX
            // 
            this.BTN_ALL_TX.Location = new System.Drawing.Point(26, 45);
            this.BTN_ALL_TX.Name = "BTN_ALL_TX";
            this.BTN_ALL_TX.Size = new System.Drawing.Size(88, 29);
            this.BTN_ALL_TX.TabIndex = 1;
            this.BTN_ALL_TX.Text = "ON";
            this.BTN_ALL_TX.UseVisualStyleBackColor = true;
            this.BTN_ALL_TX.Click += new System.EventHandler(this.BTN_ALL_TX_Click);
            // 
            // LAB_ALL_TX_OUT
            // 
            this.LAB_ALL_TX_OUT.AutoSize = true;
            this.LAB_ALL_TX_OUT.Font = new System.Drawing.Font("Meiryo UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.LAB_ALL_TX_OUT.Location = new System.Drawing.Point(27, 28);
            this.LAB_ALL_TX_OUT.Name = "LAB_ALL_TX_OUT";
            this.LAB_ALL_TX_OUT.Size = new System.Drawing.Size(87, 17);
            this.LAB_ALL_TX_OUT.TabIndex = 0;
            this.LAB_ALL_TX_OUT.Text = "TX OUTPUT";
            // 
            // LAB_COM1_NAME
            // 
            this.LAB_COM1_NAME.Font = new System.Drawing.Font("Meiryo UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.LAB_COM1_NAME.Location = new System.Drawing.Point(195, 21);
            this.LAB_COM1_NAME.Name = "LAB_COM1_NAME";
            this.LAB_COM1_NAME.Size = new System.Drawing.Size(145, 32);
            this.LAB_COM1_NAME.TabIndex = 9;
            this.LAB_COM1_NAME.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // LAB_COM2_NAME
            // 
            this.LAB_COM2_NAME.Font = new System.Drawing.Font("Meiryo UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.LAB_COM2_NAME.Location = new System.Drawing.Point(520, 22);
            this.LAB_COM2_NAME.Name = "LAB_COM2_NAME";
            this.LAB_COM2_NAME.Size = new System.Drawing.Size(145, 32);
            this.LAB_COM2_NAME.TabIndex = 10;
            this.LAB_COM2_NAME.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // BERT_MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1729, 783);
            this.Controls.Add(this.GBOX_ALL);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.PAN_Form_Main);
            this.Controls.Add(this.COM_Panel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.Name = "BERT_MainForm";
            this.Text = "ITS-8203 4CH BERT";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.BERT_MainForm_FormClosed);
            this.Load += new System.EventHandler(this.BERT_MainForm_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.COM_Panel.ResumeLayout(false);
            this.COM_Panel.PerformLayout();
            this.Ether_Panel.ResumeLayout(false);
            this.Ether_Panel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PBOX_ETHER_SYS_ERR)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PBOX_COM_SYS_ERR)).EndInit();
            this.GBOX_CH1.ResumeLayout(false);
            this.GBOX_CH1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PBOX_Tx_STS_1)).EndInit();
            this.GBOX_Result_CH1.ResumeLayout(false);
            this.GBOX_Result_CH1.PerformLayout();
            this.GBOX_Monitor_CH1.ResumeLayout(false);
            this.GBOX_Monitor_CH1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PBOX_ERR_CH1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PBOX_LOS_CH1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PBOX_ERR_FLG_CH1)).EndInit();
            this.GBOX_Setting_CH1.ResumeLayout(false);
            this.GBOX_Setting_CH1.PerformLayout();
            this.GBOX_CH2.ResumeLayout(false);
            this.GBOX_CH2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PBOX_Tx_STS_2)).EndInit();
            this.GBOX_Result_CH2.ResumeLayout(false);
            this.GBOX_Result_CH2.PerformLayout();
            this.GBOX_Monitor_CH2.ResumeLayout(false);
            this.GBOX_Monitor_CH2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PBOX_ERR_CH2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PBOX_LOS_CH2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PBOX_ERR_FLG_CH2)).EndInit();
            this.GBOX_Setting_CH2.ResumeLayout(false);
            this.GBOX_Setting_CH2.PerformLayout();
            this.PAN_Form_Main.ResumeLayout(false);
            this.PAN_Form_Main.PerformLayout();
            this.GBOX_CH4.ResumeLayout(false);
            this.GBOX_CH4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PBOX_Tx_STS_4)).EndInit();
            this.GBOX_Result_CH4.ResumeLayout(false);
            this.GBOX_Result_CH4.PerformLayout();
            this.GBOX_Monitor_CH4.ResumeLayout(false);
            this.GBOX_Monitor_CH4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PBOX_ERR_CH4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PBOX_LOS_CH4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PBOX_ERR_FLG_CH4)).EndInit();
            this.GBOX_Setting_CH4.ResumeLayout(false);
            this.GBOX_Setting_CH4.PerformLayout();
            this.GBOX_CH3.ResumeLayout(false);
            this.GBOX_CH3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PBOX_Tx_STS_3)).EndInit();
            this.GBOX_Result_CH3.ResumeLayout(false);
            this.GBOX_Result_CH3.PerformLayout();
            this.GBOX_Monitor_CH3.ResumeLayout(false);
            this.GBOX_Monitor_CH3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PBOX_ERR_CH3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PBOX_LOS_CH3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PBOX_ERR_FLG_CH3)).EndInit();
            this.GBOX_Setting_CH3.ResumeLayout(false);
            this.GBOX_Setting_CH3.PerformLayout();
            this.GBOX_ALL.ResumeLayout(false);
            this.GBOX_ALL.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem 終了ToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem ヘルプHToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ToolStripMenuItem_Ver;
        private System.Windows.Forms.Panel COM_Panel;
        private System.Windows.Forms.Label LAB_COM1;
        private System.Windows.Forms.ComboBox CBOX_COM1;
        private System.Windows.Forms.Button BTN_COM_Connect;
        private System.Windows.Forms.Label LAB_COM_SYS_ERR;
        private System.Windows.Forms.PictureBox PBOX_COM_SYS_ERR;
        private System.Windows.Forms.Panel Ether_Panel;
        private System.Windows.Forms.Label LAB_Ether1;
        private System.Windows.Forms.Button BTN_ETHER_Connect;
        private System.Windows.Forms.Label LAB_ETHER_SYS_ERR;
        private System.Windows.Forms.Timer GetResult;
        private System.Windows.Forms.Button BTN_COM_IF_CHG;
        private System.Windows.Forms.Button BTN_ETH_IF_CHG;
        private System.Windows.Forms.ToolStripMenuItem toolTToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem netwrokSetNToolStripMenuItem;
        private System.Windows.Forms.PictureBox PBOX_ETHER_SYS_ERR;
        private System.Windows.Forms.Label LAB_Bitrate;
        private System.Windows.Forms.GroupBox GBOX_CH1;
        private System.Windows.Forms.ComboBox CBOX_ReSync_Mode_CH1;
        private System.Windows.Forms.Label LAB_ReSync_Mode_CH1;
        private System.Windows.Forms.Button BTN_MES_CH1;
        private System.Windows.Forms.GroupBox GBOX_Result_CH1;
        private System.Windows.Forms.Label LAB_ES_Result_CH1;
        private System.Windows.Forms.Label LAB_BER_Result_CH1;
        private System.Windows.Forms.Label LAB_Err_Cnt_Result_CH1;
        private System.Windows.Forms.Label LAB_Data_Cnt_Result_CH1;
        private System.Windows.Forms.Label LAB_Mesure_Time_Result_CH1;
        private System.Windows.Forms.Button BTN_Cnt_Rst_CH1;
        private System.Windows.Forms.GroupBox GBOX_Monitor_CH1;
        private System.Windows.Forms.PictureBox PBOX_ERR_CH1;
        private System.Windows.Forms.PictureBox PBOX_LOS_CH1;
        private System.Windows.Forms.PictureBox PBOX_ERR_FLG_CH1;
        private System.Windows.Forms.Button BTN_Flg_Rst_CH1;
        private System.Windows.Forms.GroupBox GBOX_Setting_CH1;
        private System.Windows.Forms.ComboBox CMB_PN_CH1;
        private System.Windows.Forms.Button BTN_Sync_CH1;
        private System.Windows.Forms.Button BTN_TX_OUT_CH1;
        private System.Windows.Forms.Label LAB_Sync_CH1;
        private System.Windows.Forms.ComboBox CBOX_BR;
        private System.Windows.Forms.Label LAB_Mbps;
        private System.Windows.Forms.GroupBox GBOX_CH2;
        private System.Windows.Forms.ComboBox CBOX_ReSync_Mode_CH2;
        private System.Windows.Forms.Label LAB_ReSync_Mode_CH2;
        private System.Windows.Forms.Button BTN_Sync_CH2;
        private System.Windows.Forms.Label LAB_Sync_CH2;
        private System.Windows.Forms.Button BTN_MES_CH2;
        private System.Windows.Forms.Label LAB_Mesure_CH2;
        private System.Windows.Forms.GroupBox GBOX_Result_CH2;
        private System.Windows.Forms.Label LAB_ES_Result_CH2;
        private System.Windows.Forms.Label LAB_BER_Result_CH2;
        private System.Windows.Forms.Label LAB_Err_Cnt_Result_CH2;
        private System.Windows.Forms.Label LAB_Data_Cnt_Result_CH2;
        private System.Windows.Forms.Label LAB_Mesure_Time_Result_CH2;
        private System.Windows.Forms.Button BTN_Cnt_Rst_CH2;
        private System.Windows.Forms.GroupBox GBOX_Monitor_CH2;
        private System.Windows.Forms.PictureBox PBOX_ERR_CH2;
        private System.Windows.Forms.PictureBox PBOX_LOS_CH2;
        private System.Windows.Forms.PictureBox PBOX_ERR_FLG_CH2;
        private System.Windows.Forms.Button BTN_Flg_Rst_CH2;
        private System.Windows.Forms.GroupBox GBOX_Setting_CH2;
        private System.Windows.Forms.ComboBox CMB_PN_CH2;
        private System.Windows.Forms.Button BTN_TX_OUT_CH2;
        private System.Windows.Forms.Label LAB_Trg;
        private System.Windows.Forms.ComboBox CMB_Trg;
        private System.Windows.Forms.Label LAB_Clock;
        private System.Windows.Forms.Panel PAN_Form_Main;
        private System.Windows.Forms.Label LAB_TEST_CNT;
        public System.Windows.Forms.TextBox TXT_IPAdr1;
        private System.Windows.Forms.PictureBox PBOX_Tx_STS_1;
        private System.Windows.Forms.PictureBox PBOX_Tx_STS_2;
        private System.Windows.Forms.GroupBox GBOX_CH3;
        private System.Windows.Forms.PictureBox PBOX_Tx_STS_3;
        private System.Windows.Forms.ComboBox CBOX_ReSync_Mode_CH3;
        private System.Windows.Forms.Label LAB_ReSync_Mode_CH3;
        private System.Windows.Forms.Button BTN_MES_CH3;
        private System.Windows.Forms.GroupBox GBOX_Result_CH3;
        private System.Windows.Forms.Label LAB_ES_Result_CH3;
        private System.Windows.Forms.Label LAB_BER_Result_CH3;
        private System.Windows.Forms.Label LAB_Err_Cnt_Result_CH3;
        private System.Windows.Forms.Label LAB_Data_Cnt_Result_CH3;
        private System.Windows.Forms.Label LAB_Mesure_Time_Result_CH3;
        private System.Windows.Forms.Button BTN_Cnt_Rst_CH3;
        private System.Windows.Forms.GroupBox GBOX_Monitor_CH3;
        private System.Windows.Forms.Button BTN_Flg_Rst_CH3;
        private System.Windows.Forms.PictureBox PBOX_ERR_CH3;
        private System.Windows.Forms.PictureBox PBOX_LOS_CH3;
        private System.Windows.Forms.PictureBox PBOX_ERR_FLG_CH3;
        private System.Windows.Forms.GroupBox GBOX_Setting_CH3;
        private System.Windows.Forms.ComboBox CMB_PN_CH3;
        private System.Windows.Forms.Button BTN_Sync_CH3;
        private System.Windows.Forms.Button BTN_TX_OUT_CH3;
        private System.Windows.Forms.Label LAB_Sync_CH3;
        private System.Windows.Forms.GroupBox GBOX_CH4;
        private System.Windows.Forms.PictureBox PBOX_Tx_STS_4;
        private System.Windows.Forms.ComboBox CBOX_ReSync_Mode_CH4;
        private System.Windows.Forms.Label LAB_ReSync_Mode_CH4;
        private System.Windows.Forms.Button BTN_MES_CH4;
        private System.Windows.Forms.GroupBox GBOX_Result_CH4;
        private System.Windows.Forms.Label LAB_ES_Result_CH4;
        private System.Windows.Forms.Label LAB_BER_Result_CH4;
        private System.Windows.Forms.Label LAB_Err_Cnt_Result_CH4;
        private System.Windows.Forms.Label LAB_Data_Cnt_Result_CH4;
        private System.Windows.Forms.Label LAB_Mesure_Time_Result_CH4;
        private System.Windows.Forms.Button BTN_Cnt_Rst_CH4;
        private System.Windows.Forms.GroupBox GBOX_Monitor_CH4;
        private System.Windows.Forms.Button BTN_Flg_Rst_CH4;
        private System.Windows.Forms.PictureBox PBOX_ERR_CH4;
        private System.Windows.Forms.PictureBox PBOX_LOS_CH4;
        private System.Windows.Forms.PictureBox PBOX_ERR_FLG_CH4;
        private System.Windows.Forms.GroupBox GBOX_Setting_CH4;
        private System.Windows.Forms.ComboBox CMB_PN_CH4;
        private System.Windows.Forms.Button BTN_Sync_CH4;
        private System.Windows.Forms.Button BTN_TX_OUT_CH4;
        private System.Windows.Forms.Label LAB_Sync_CH4;
        private System.Windows.Forms.Label LAB_COM2;
        private System.Windows.Forms.ComboBox CBOX_COM2;
        private System.Windows.Forms.Label LAB_Ether2;
        public System.Windows.Forms.TextBox TXT_IPAdr2;
        private System.Windows.Forms.Label LAB_Program_pattern;
        private System.Windows.Forms.Button BTN_ProgramPatternSetting;
        private System.Windows.Forms.Label LAB_LENGTH_CH1_Val;
        private System.Windows.Forms.Label LAB_LENGTH_CH2_Val;
        private System.Windows.Forms.Label LAB_LENGTH_CH4_Val;
        private System.Windows.Forms.Label LAB_LENGTH_CH3_Val;
        private System.Windows.Forms.GroupBox GBOX_ALL;
        private System.Windows.Forms.Button BTN_ALL_TX;
        private System.Windows.Forms.Label LAB_ALL_TX_OUT;
        private System.Windows.Forms.Button BTN_ALL_RESYNC;
        private System.Windows.Forms.Label LAB_ALL_RESYNC;
        private System.Windows.Forms.Button BTN_ALL_MEASURE;
        private System.Windows.Forms.Label LAB_ALL_MEASURE;
        private System.Windows.Forms.Button BTN_ALL_FLAG_RESET;
        private System.Windows.Forms.Label LAB_ALL_FLAG;
        private System.Windows.Forms.Button BTN_ALL_COUNTER_RESET;
        private System.Windows.Forms.Label LAB_ALL_COUNTER;
        private System.Windows.Forms.ToolStripMenuItem programPatternSetPToolStripMenuItem;
        private System.Windows.Forms.Label LAB_COM1_NAME;
        private System.Windows.Forms.Label LAB_COM2_NAME;
    }
}

