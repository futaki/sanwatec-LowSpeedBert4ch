namespace BERT
{
    partial class NetworkSet
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(NetworkSet));
            this.LAB_Ether1 = new System.Windows.Forms.Label();
            this.IP1_Txt = new System.Windows.Forms.TextBox();
            this.LAB_COM_Status = new System.Windows.Forms.Label();
            this.PBOX_COM_STS = new System.Windows.Forms.PictureBox();
            this.BTN_Cancel = new System.Windows.Forms.Button();
            this.BTN_Set = new System.Windows.Forms.Button();
            this.LAB_IP1_MASK = new System.Windows.Forms.Label();
            this.MASK1_Txt = new System.Windows.Forms.TextBox();
            this.LAB_DGateway = new System.Windows.Forms.Label();
            this.GW_Txt = new System.Windows.Forms.TextBox();
            this.CBOX_DHCP = new System.Windows.Forms.CheckBox();
            this.MASK2_Txt = new System.Windows.Forms.TextBox();
            this.LAB_IP2_MASK = new System.Windows.Forms.Label();
            this.IP2_Txt = new System.Windows.Forms.TextBox();
            this.LAB_Ether2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.PBOX_COM_STS)).BeginInit();
            this.SuspendLayout();
            // 
            // LAB_Ether1
            // 
            this.LAB_Ether1.AutoSize = true;
            this.LAB_Ether1.Font = new System.Drawing.Font("Meiryo UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.LAB_Ether1.Location = new System.Drawing.Point(31, 23);
            this.LAB_Ether1.Name = "LAB_Ether1";
            this.LAB_Ether1.Size = new System.Drawing.Size(189, 20);
            this.LAB_Ether1.TabIndex = 1;
            this.LAB_Ether1.Text = "ETHERNET IP1 ADDR";
            // 
            // IP1_Txt
            // 
            this.IP1_Txt.Font = new System.Drawing.Font("Meiryo UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.IP1_Txt.Location = new System.Drawing.Point(226, 20);
            this.IP1_Txt.Name = "IP1_Txt";
            this.IP1_Txt.Size = new System.Drawing.Size(187, 28);
            this.IP1_Txt.TabIndex = 2;
            // 
            // LAB_COM_Status
            // 
            this.LAB_COM_Status.AutoSize = true;
            this.LAB_COM_Status.Font = new System.Drawing.Font("Meiryo UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.LAB_COM_Status.Location = new System.Drawing.Point(426, 23);
            this.LAB_COM_Status.Name = "LAB_COM_Status";
            this.LAB_COM_Status.Size = new System.Drawing.Size(172, 20);
            this.LAB_COM_Status.TabIndex = 3;
            this.LAB_COM_Status.Text = "COM PORT STATUS";
            // 
            // PBOX_COM_STS
            // 
            this.PBOX_COM_STS.ErrorImage = ((System.Drawing.Image)(resources.GetObject("PBOX_COM_STS.ErrorImage")));
            this.PBOX_COM_STS.Image = global::BERT.Properties.Resources.led_off;
            this.PBOX_COM_STS.InitialImage = global::BERT.Properties.Resources.led_green;
            this.PBOX_COM_STS.Location = new System.Drawing.Point(596, 17);
            this.PBOX_COM_STS.Name = "PBOX_COM_STS";
            this.PBOX_COM_STS.Size = new System.Drawing.Size(55, 32);
            this.PBOX_COM_STS.TabIndex = 9;
            this.PBOX_COM_STS.TabStop = false;
            // 
            // BTN_Cancel
            // 
            this.BTN_Cancel.BackColor = System.Drawing.SystemColors.Control;
            this.BTN_Cancel.Font = new System.Drawing.Font("Meiryo UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.BTN_Cancel.Location = new System.Drawing.Point(55, 213);
            this.BTN_Cancel.Name = "BTN_Cancel";
            this.BTN_Cancel.Size = new System.Drawing.Size(156, 36);
            this.BTN_Cancel.TabIndex = 10;
            this.BTN_Cancel.Text = "CANCEL";
            this.BTN_Cancel.UseVisualStyleBackColor = false;
            this.BTN_Cancel.Click += new System.EventHandler(this.BTN_Cancel_Click);
            // 
            // BTN_Set
            // 
            this.BTN_Set.BackColor = System.Drawing.SystemColors.Control;
            this.BTN_Set.Font = new System.Drawing.Font("Meiryo UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.BTN_Set.Location = new System.Drawing.Point(431, 213);
            this.BTN_Set.Name = "BTN_Set";
            this.BTN_Set.Size = new System.Drawing.Size(156, 36);
            this.BTN_Set.TabIndex = 11;
            this.BTN_Set.Text = "SET";
            this.BTN_Set.UseVisualStyleBackColor = false;
            this.BTN_Set.Click += new System.EventHandler(this.BTN_Set_Click);
            // 
            // LAB_IP1_MASK
            // 
            this.LAB_IP1_MASK.AutoSize = true;
            this.LAB_IP1_MASK.Font = new System.Drawing.Font("Meiryo UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.LAB_IP1_MASK.Location = new System.Drawing.Point(128, 58);
            this.LAB_IP1_MASK.Name = "LAB_IP1_MASK";
            this.LAB_IP1_MASK.Size = new System.Drawing.Size(94, 20);
            this.LAB_IP1_MASK.TabIndex = 12;
            this.LAB_IP1_MASK.Text = "IP1 MASK";
            // 
            // MASK1_Txt
            // 
            this.MASK1_Txt.Font = new System.Drawing.Font("Meiryo UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MASK1_Txt.Location = new System.Drawing.Point(225, 54);
            this.MASK1_Txt.Name = "MASK1_Txt";
            this.MASK1_Txt.Size = new System.Drawing.Size(187, 28);
            this.MASK1_Txt.TabIndex = 13;
            // 
            // LAB_DGateway
            // 
            this.LAB_DGateway.AutoSize = true;
            this.LAB_DGateway.Font = new System.Drawing.Font("Meiryo UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.LAB_DGateway.Location = new System.Drawing.Point(33, 161);
            this.LAB_DGateway.Name = "LAB_DGateway";
            this.LAB_DGateway.Size = new System.Drawing.Size(175, 20);
            this.LAB_DGateway.TabIndex = 14;
            this.LAB_DGateway.Text = "DEFAULT GW ADDR";
            // 
            // GW_Txt
            // 
            this.GW_Txt.Font = new System.Drawing.Font("Meiryo UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GW_Txt.Location = new System.Drawing.Point(224, 156);
            this.GW_Txt.Name = "GW_Txt";
            this.GW_Txt.Size = new System.Drawing.Size(187, 28);
            this.GW_Txt.TabIndex = 15;
            // 
            // CBOX_DHCP
            // 
            this.CBOX_DHCP.AutoSize = true;
            this.CBOX_DHCP.Font = new System.Drawing.Font("Meiryo UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.CBOX_DHCP.Location = new System.Drawing.Point(442, 77);
            this.CBOX_DHCP.Name = "CBOX_DHCP";
            this.CBOX_DHCP.Size = new System.Drawing.Size(115, 24);
            this.CBOX_DHCP.TabIndex = 17;
            this.CBOX_DHCP.Text = "USE DHCP";
            this.CBOX_DHCP.UseVisualStyleBackColor = true;
            this.CBOX_DHCP.CheckedChanged += new System.EventHandler(this.CBOX_DHCP_CheckedChanged);
            // 
            // MASK2_Txt
            // 
            this.MASK2_Txt.Font = new System.Drawing.Font("Meiryo UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MASK2_Txt.Location = new System.Drawing.Point(224, 122);
            this.MASK2_Txt.Name = "MASK2_Txt";
            this.MASK2_Txt.Size = new System.Drawing.Size(187, 28);
            this.MASK2_Txt.TabIndex = 21;
            // 
            // LAB_IP2_MASK
            // 
            this.LAB_IP2_MASK.AutoSize = true;
            this.LAB_IP2_MASK.Font = new System.Drawing.Font("Meiryo UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.LAB_IP2_MASK.Location = new System.Drawing.Point(127, 126);
            this.LAB_IP2_MASK.Name = "LAB_IP2_MASK";
            this.LAB_IP2_MASK.Size = new System.Drawing.Size(94, 20);
            this.LAB_IP2_MASK.TabIndex = 20;
            this.LAB_IP2_MASK.Text = "IP2 MASK";
            // 
            // IP2_Txt
            // 
            this.IP2_Txt.Font = new System.Drawing.Font("Meiryo UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.IP2_Txt.Location = new System.Drawing.Point(225, 88);
            this.IP2_Txt.Name = "IP2_Txt";
            this.IP2_Txt.Size = new System.Drawing.Size(187, 28);
            this.IP2_Txt.TabIndex = 19;
            // 
            // LAB_Ether2
            // 
            this.LAB_Ether2.AutoSize = true;
            this.LAB_Ether2.Font = new System.Drawing.Font("Meiryo UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.LAB_Ether2.Location = new System.Drawing.Point(30, 91);
            this.LAB_Ether2.Name = "LAB_Ether2";
            this.LAB_Ether2.Size = new System.Drawing.Size(189, 20);
            this.LAB_Ether2.TabIndex = 18;
            this.LAB_Ether2.Text = "ETHERNET IP2 ADDR";
            // 
            // NetworkSet
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(660, 273);
            this.Controls.Add(this.MASK2_Txt);
            this.Controls.Add(this.LAB_IP2_MASK);
            this.Controls.Add(this.IP2_Txt);
            this.Controls.Add(this.LAB_Ether2);
            this.Controls.Add(this.CBOX_DHCP);
            this.Controls.Add(this.GW_Txt);
            this.Controls.Add(this.LAB_DGateway);
            this.Controls.Add(this.MASK1_Txt);
            this.Controls.Add(this.LAB_IP1_MASK);
            this.Controls.Add(this.BTN_Set);
            this.Controls.Add(this.BTN_Cancel);
            this.Controls.Add(this.PBOX_COM_STS);
            this.Controls.Add(this.LAB_COM_Status);
            this.Controls.Add(this.IP1_Txt);
            this.Controls.Add(this.LAB_Ether1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "NetworkSet";
            this.ShowIcon = false;
            this.Text = "Network Set";
            ((System.ComponentModel.ISupportInitialize)(this.PBOX_COM_STS)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LAB_Ether1;
        private System.Windows.Forms.TextBox IP1_Txt;
        private System.Windows.Forms.Label LAB_COM_Status;
        private System.Windows.Forms.PictureBox PBOX_COM_STS;
        private System.Windows.Forms.Button BTN_Cancel;
        private System.Windows.Forms.Button BTN_Set;
        private System.Windows.Forms.Label LAB_IP1_MASK;
        private System.Windows.Forms.TextBox MASK1_Txt;
        private System.Windows.Forms.Label LAB_DGateway;
        private System.Windows.Forms.TextBox GW_Txt;
        private System.Windows.Forms.CheckBox CBOX_DHCP;
        private System.Windows.Forms.TextBox MASK2_Txt;
        private System.Windows.Forms.Label LAB_IP2_MASK;
        private System.Windows.Forms.TextBox IP2_Txt;
        private System.Windows.Forms.Label LAB_Ether2;
    }
}