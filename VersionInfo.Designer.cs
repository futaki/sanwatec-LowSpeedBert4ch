namespace BERT
{
    partial class VersionForm
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
            this.LAB_GUI = new System.Windows.Forms.Label();
            this.LAB_GUI_VER = new System.Windows.Forms.Label();
            this.LAB_FW = new System.Windows.Forms.Label();
            this.LAB_FW_VER = new System.Windows.Forms.Label();
            this.LAB_MAC = new System.Windows.Forms.Label();
            this.LAB_MAC_ADDR = new System.Windows.Forms.Label();
            this.BTN_GET_VER = new System.Windows.Forms.Button();
            this.BTN_CLOSE = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // LAB_GUI
            // 
            this.LAB_GUI.AutoSize = true;
            this.LAB_GUI.Font = new System.Drawing.Font("Meiryo UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.LAB_GUI.Location = new System.Drawing.Point(25, 31);
            this.LAB_GUI.Name = "LAB_GUI";
            this.LAB_GUI.Size = new System.Drawing.Size(147, 20);
            this.LAB_GUI.TabIndex = 0;
            this.LAB_GUI.Text = "GUI     Version : ";
            // 
            // LAB_GUI_VER
            // 
            this.LAB_GUI_VER.AutoSize = true;
            this.LAB_GUI_VER.Font = new System.Drawing.Font("Meiryo UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.LAB_GUI_VER.Location = new System.Drawing.Point(182, 31);
            this.LAB_GUI_VER.Name = "LAB_GUI_VER";
            this.LAB_GUI_VER.Size = new System.Drawing.Size(71, 20);
            this.LAB_GUI_VER.TabIndex = 1;
            this.LAB_GUI_VER.Text = "1.0.1.1";
            // 
            // LAB_FW
            // 
            this.LAB_FW.AutoSize = true;
            this.LAB_FW.Font = new System.Drawing.Font("Meiryo UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.LAB_FW.Location = new System.Drawing.Point(25, 81);
            this.LAB_FW.Name = "LAB_FW";
            this.LAB_FW.Size = new System.Drawing.Size(146, 20);
            this.LAB_FW.TabIndex = 2;
            this.LAB_FW.Text = "FW      Version : ";
            // 
            // LAB_FW_VER
            // 
            this.LAB_FW_VER.AutoSize = true;
            this.LAB_FW_VER.Font = new System.Drawing.Font("Meiryo UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.LAB_FW_VER.Location = new System.Drawing.Point(185, 81);
            this.LAB_FW_VER.Name = "LAB_FW_VER";
            this.LAB_FW_VER.Size = new System.Drawing.Size(40, 20);
            this.LAB_FW_VER.TabIndex = 3;
            this.LAB_FW_VER.Text = "-.-.-";
            // 
            // LAB_MAC
            // 
            this.LAB_MAC.AutoSize = true;
            this.LAB_MAC.Font = new System.Drawing.Font("Meiryo UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.LAB_MAC.Location = new System.Drawing.Point(26, 131);
            this.LAB_MAC.Name = "LAB_MAC";
            this.LAB_MAC.Size = new System.Drawing.Size(143, 20);
            this.LAB_MAC.TabIndex = 4;
            this.LAB_MAC.Text = "MAC  Address : ";
            // 
            // LAB_MAC_ADDR
            // 
            this.LAB_MAC_ADDR.AutoSize = true;
            this.LAB_MAC_ADDR.Font = new System.Drawing.Font("Meiryo UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.LAB_MAC_ADDR.Location = new System.Drawing.Point(185, 131);
            this.LAB_MAC_ADDR.Name = "LAB_MAC_ADDR";
            this.LAB_MAC_ADDR.Size = new System.Drawing.Size(123, 20);
            this.LAB_MAC_ADDR.TabIndex = 5;
            this.LAB_MAC_ADDR.Text = "--:--:--:--:--:--";
            // 
            // BTN_GET_VER
            // 
            this.BTN_GET_VER.Font = new System.Drawing.Font("Meiryo UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.BTN_GET_VER.Location = new System.Drawing.Point(329, 102);
            this.BTN_GET_VER.Name = "BTN_GET_VER";
            this.BTN_GET_VER.Size = new System.Drawing.Size(87, 29);
            this.BTN_GET_VER.TabIndex = 6;
            this.BTN_GET_VER.Text = "GET";
            this.BTN_GET_VER.UseVisualStyleBackColor = true;
            this.BTN_GET_VER.Click += new System.EventHandler(this.BTN_GET_VER_Click);
            // 
            // BTN_CLOSE
            // 
            this.BTN_CLOSE.Font = new System.Drawing.Font("Meiryo UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.BTN_CLOSE.Location = new System.Drawing.Point(329, 164);
            this.BTN_CLOSE.Name = "BTN_CLOSE";
            this.BTN_CLOSE.Size = new System.Drawing.Size(87, 29);
            this.BTN_CLOSE.TabIndex = 7;
            this.BTN_CLOSE.Text = "Close";
            this.BTN_CLOSE.UseVisualStyleBackColor = true;
            this.BTN_CLOSE.Click += new System.EventHandler(this.BTN_CLOSE_Click);
            // 
            // VersionForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(443, 205);
            this.Controls.Add(this.BTN_CLOSE);
            this.Controls.Add(this.BTN_GET_VER);
            this.Controls.Add(this.LAB_MAC_ADDR);
            this.Controls.Add(this.LAB_MAC);
            this.Controls.Add(this.LAB_FW_VER);
            this.Controls.Add(this.LAB_FW);
            this.Controls.Add(this.LAB_GUI_VER);
            this.Controls.Add(this.LAB_GUI);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "VersionForm";
            this.ShowIcon = false;
            this.Text = "Version Information";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LAB_GUI;
        private System.Windows.Forms.Label LAB_GUI_VER;
        private System.Windows.Forms.Label LAB_FW;
        private System.Windows.Forms.Label LAB_FW_VER;
        private System.Windows.Forms.Label LAB_MAC;
        private System.Windows.Forms.Label LAB_MAC_ADDR;
        private System.Windows.Forms.Button BTN_GET_VER;
        private System.Windows.Forms.Button BTN_CLOSE;
    }
}