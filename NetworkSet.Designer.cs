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
            this.LAB_Ether = new System.Windows.Forms.Label();
            this.IP_Txt = new System.Windows.Forms.TextBox();
            this.LAB_COM_Status = new System.Windows.Forms.Label();
            this.PBOX_COM_STS = new System.Windows.Forms.PictureBox();
            this.BTN_Cancel = new System.Windows.Forms.Button();
            this.BTN_Set = new System.Windows.Forms.Button();
            this.LAB_IP_MASK = new System.Windows.Forms.Label();
            this.MASK_Txt = new System.Windows.Forms.TextBox();
            this.LAB_DGateway = new System.Windows.Forms.Label();
            this.GW_Txt = new System.Windows.Forms.TextBox();
            this.CBOX_DHCP = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.PBOX_COM_STS)).BeginInit();
            this.SuspendLayout();
            // 
            // LAB_Ether
            // 
            this.LAB_Ether.AutoSize = true;
            this.LAB_Ether.Font = new System.Drawing.Font("Meiryo UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.LAB_Ether.Location = new System.Drawing.Point(12, 23);
            this.LAB_Ether.Name = "LAB_Ether";
            this.LAB_Ether.Size = new System.Drawing.Size(178, 20);
            this.LAB_Ether.TabIndex = 1;
            this.LAB_Ether.Text = "ETHERNET IP ADDR";
            // 
            // IP_Txt
            // 
            this.IP_Txt.Font = new System.Drawing.Font("Meiryo UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.IP_Txt.Location = new System.Drawing.Point(196, 20);
            this.IP_Txt.Name = "IP_Txt";
            this.IP_Txt.Size = new System.Drawing.Size(164, 28);
            this.IP_Txt.TabIndex = 2;
            this.IP_Txt.Text = "192.168.1.10";
            // 
            // LAB_COM_Status
            // 
            this.LAB_COM_Status.AutoSize = true;
            this.LAB_COM_Status.Font = new System.Drawing.Font("Meiryo UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.LAB_COM_Status.Location = new System.Drawing.Point(375, 23);
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
            this.PBOX_COM_STS.Location = new System.Drawing.Point(560, 20);
            this.PBOX_COM_STS.Name = "PBOX_COM_STS";
            this.PBOX_COM_STS.Size = new System.Drawing.Size(32, 32);
            this.PBOX_COM_STS.TabIndex = 9;
            this.PBOX_COM_STS.TabStop = false;
            // 
            // BTN_Cancel
            // 
            this.BTN_Cancel.BackColor = System.Drawing.SystemColors.Control;
            this.BTN_Cancel.Font = new System.Drawing.Font("Meiryo UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.BTN_Cancel.Location = new System.Drawing.Point(36, 139);
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
            this.BTN_Set.Location = new System.Drawing.Point(412, 139);
            this.BTN_Set.Name = "BTN_Set";
            this.BTN_Set.Size = new System.Drawing.Size(156, 36);
            this.BTN_Set.TabIndex = 11;
            this.BTN_Set.Text = "SET";
            this.BTN_Set.UseVisualStyleBackColor = false;
            this.BTN_Set.Click += new System.EventHandler(this.BTN_Set_Click);
            // 
            // LAB_IP_MASK
            // 
            this.LAB_IP_MASK.AutoSize = true;
            this.LAB_IP_MASK.Font = new System.Drawing.Font("Meiryo UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.LAB_IP_MASK.Location = new System.Drawing.Point(109, 58);
            this.LAB_IP_MASK.Name = "LAB_IP_MASK";
            this.LAB_IP_MASK.Size = new System.Drawing.Size(83, 20);
            this.LAB_IP_MASK.TabIndex = 12;
            this.LAB_IP_MASK.Text = "IP MASK";
            // 
            // MASK_Txt
            // 
            this.MASK_Txt.Font = new System.Drawing.Font("Meiryo UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MASK_Txt.Location = new System.Drawing.Point(195, 54);
            this.MASK_Txt.Name = "MASK_Txt";
            this.MASK_Txt.Size = new System.Drawing.Size(164, 28);
            this.MASK_Txt.TabIndex = 13;
            this.MASK_Txt.Text = "255.255.255.0";
            // 
            // LAB_DGateway
            // 
            this.LAB_DGateway.AutoSize = true;
            this.LAB_DGateway.Font = new System.Drawing.Font("Meiryo UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.LAB_DGateway.Location = new System.Drawing.Point(14, 94);
            this.LAB_DGateway.Name = "LAB_DGateway";
            this.LAB_DGateway.Size = new System.Drawing.Size(175, 20);
            this.LAB_DGateway.TabIndex = 14;
            this.LAB_DGateway.Text = "DEFAULT GW ADDR";
            // 
            // GW_Txt
            // 
            this.GW_Txt.Font = new System.Drawing.Font("Meiryo UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GW_Txt.Location = new System.Drawing.Point(194, 89);
            this.GW_Txt.Name = "GW_Txt";
            this.GW_Txt.Size = new System.Drawing.Size(164, 28);
            this.GW_Txt.TabIndex = 15;
            this.GW_Txt.Text = "192.168.1.1";
            // 
            // CBOX_DHCP
            // 
            this.CBOX_DHCP.AutoSize = true;
            this.CBOX_DHCP.Font = new System.Drawing.Font("Meiryo UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.CBOX_DHCP.Location = new System.Drawing.Point(412, 77);
            this.CBOX_DHCP.Name = "CBOX_DHCP";
            this.CBOX_DHCP.Size = new System.Drawing.Size(115, 24);
            this.CBOX_DHCP.TabIndex = 17;
            this.CBOX_DHCP.Text = "USE DHCP";
            this.CBOX_DHCP.UseVisualStyleBackColor = true;
            this.CBOX_DHCP.CheckedChanged += new System.EventHandler(this.CBOX_DHCP_CheckedChanged);
            // 
            // NetworkSet
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(619, 185);
            this.Controls.Add(this.CBOX_DHCP);
            this.Controls.Add(this.GW_Txt);
            this.Controls.Add(this.LAB_DGateway);
            this.Controls.Add(this.MASK_Txt);
            this.Controls.Add(this.LAB_IP_MASK);
            this.Controls.Add(this.BTN_Set);
            this.Controls.Add(this.BTN_Cancel);
            this.Controls.Add(this.PBOX_COM_STS);
            this.Controls.Add(this.LAB_COM_Status);
            this.Controls.Add(this.IP_Txt);
            this.Controls.Add(this.LAB_Ether);
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

        private System.Windows.Forms.Label LAB_Ether;
        private System.Windows.Forms.TextBox IP_Txt;
        private System.Windows.Forms.Label LAB_COM_Status;
        private System.Windows.Forms.PictureBox PBOX_COM_STS;
        private System.Windows.Forms.Button BTN_Cancel;
        private System.Windows.Forms.Button BTN_Set;
        private System.Windows.Forms.Label LAB_IP_MASK;
        private System.Windows.Forms.TextBox MASK_Txt;
        private System.Windows.Forms.Label LAB_DGateway;
        private System.Windows.Forms.TextBox GW_Txt;
        private System.Windows.Forms.CheckBox CBOX_DHCP;
    }
}