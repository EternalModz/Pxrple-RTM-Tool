namespace Tool_Base
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.ConnectBtn = new System.Windows.Forms.Button();
            this.IP_Reader = new System.Windows.Forms.CheckBox();
            this.IPtextBox = new System.Windows.Forms.TextBox();
            this.CCAPI = new System.Windows.Forms.RadioButton();
            this.TMAPI = new System.Windows.Forms.RadioButton();
            this.PS3MAPI = new System.Windows.Forms.RadioButton();
            this.AttachBtn = new System.Windows.Forms.Button();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.StatusLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.ConnectionBox = new System.Windows.Forms.GroupBox();
            this.IPWriterBox = new System.Windows.Forms.GroupBox();
            this.writeIP_Btn = new System.Windows.Forms.Button();
            this.IPtextBox2 = new System.Windows.Forms.TextBox();
            this.GameModsGBox = new System.Windows.Forms.GroupBox();
            this.XRayCBox = new System.Windows.Forms.CheckBox();
            this.CanFlyCBox = new System.Windows.Forms.CheckBox();
            this.PlayerIDsOnHeadCBox = new System.Windows.Forms.CheckBox();
            this.InstantKillCBox = new System.Windows.Forms.CheckBox();
            this.AutoHitAndMineCBox = new System.Windows.Forms.CheckBox();
            this.GodModeCBox = new System.Windows.Forms.CheckBox();
            this.ESPPlayersCBox = new System.Windows.Forms.CheckBox();
            this.UltraSuperSpeedCBox = new System.Windows.Forms.CheckBox();
            this.ESPChestsCBox = new System.Windows.Forms.CheckBox();
            this.SuperSpeedCBox = new System.Windows.Forms.CheckBox();
            this.SpeedCBox = new System.Windows.Forms.CheckBox();
            this.InfiniteCraftingCBox = new System.Windows.Forms.CheckBox();
            this.InformationLabel = new System.Windows.Forms.Label();
            this.SourceCodeBtn = new System.Windows.Forms.Button();
            this.YouTubeBtn = new System.Windows.Forms.Button();
            this.statusStrip1.SuspendLayout();
            this.ConnectionBox.SuspendLayout();
            this.IPWriterBox.SuspendLayout();
            this.GameModsGBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // ConnectBtn
            // 
            this.ConnectBtn.Location = new System.Drawing.Point(26, 79);
            this.ConnectBtn.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.ConnectBtn.Name = "ConnectBtn";
            this.ConnectBtn.Size = new System.Drawing.Size(252, 26);
            this.ConnectBtn.TabIndex = 0;
            this.ConnectBtn.Text = "Connect Target";
            this.ConnectBtn.UseVisualStyleBackColor = true;
            this.ConnectBtn.Click += new System.EventHandler(this.ConnectBtn_Click);
            // 
            // IP_Reader
            // 
            this.IP_Reader.AutoSize = true;
            this.IP_Reader.Location = new System.Drawing.Point(260, 52);
            this.IP_Reader.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.IP_Reader.Name = "IP_Reader";
            this.IP_Reader.Size = new System.Drawing.Size(15, 14);
            this.IP_Reader.TabIndex = 1;
            this.IP_Reader.UseVisualStyleBackColor = true;
            this.IP_Reader.CheckedChanged += new System.EventHandler(this.IP_Reader_CheckedChanged);
            // 
            // IPtextBox
            // 
            this.IPtextBox.Location = new System.Drawing.Point(26, 49);
            this.IPtextBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.IPtextBox.Name = "IPtextBox";
            this.IPtextBox.Size = new System.Drawing.Size(227, 23);
            this.IPtextBox.TabIndex = 3;
            // 
            // CCAPI
            // 
            this.CCAPI.AutoSize = true;
            this.CCAPI.Location = new System.Drawing.Point(26, 22);
            this.CCAPI.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.CCAPI.Name = "CCAPI";
            this.CCAPI.Size = new System.Drawing.Size(59, 19);
            this.CCAPI.TabIndex = 4;
            this.CCAPI.TabStop = true;
            this.CCAPI.Text = "CCAPI";
            this.CCAPI.UseVisualStyleBackColor = true;
            this.CCAPI.CheckedChanged += new System.EventHandler(this.CCAPI_CheckedChanged);
            // 
            // TMAPI
            // 
            this.TMAPI.AutoSize = true;
            this.TMAPI.Location = new System.Drawing.Point(98, 22);
            this.TMAPI.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.TMAPI.Name = "TMAPI";
            this.TMAPI.Size = new System.Drawing.Size(60, 19);
            this.TMAPI.TabIndex = 5;
            this.TMAPI.TabStop = true;
            this.TMAPI.Text = "TMAPI";
            this.TMAPI.UseVisualStyleBackColor = true;
            this.TMAPI.CheckedChanged += new System.EventHandler(this.TMAPI_CheckedChanged);
            // 
            // PS3MAPI
            // 
            this.PS3MAPI.AutoSize = true;
            this.PS3MAPI.Location = new System.Drawing.Point(170, 22);
            this.PS3MAPI.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.PS3MAPI.Name = "PS3MAPI";
            this.PS3MAPI.Size = new System.Drawing.Size(108, 19);
            this.PS3MAPI.TabIndex = 6;
            this.PS3MAPI.TabStop = true;
            this.PS3MAPI.Text = "PS3MAPI (HEN)";
            this.PS3MAPI.UseVisualStyleBackColor = true;
            this.PS3MAPI.CheckedChanged += new System.EventHandler(this.PS3MAPI_CheckedChanged);
            // 
            // AttachBtn
            // 
            this.AttachBtn.Location = new System.Drawing.Point(26, 112);
            this.AttachBtn.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.AttachBtn.Name = "AttachBtn";
            this.AttachBtn.Size = new System.Drawing.Size(252, 26);
            this.AttachBtn.TabIndex = 7;
            this.AttachBtn.Text = "Attach Process";
            this.AttachBtn.UseVisualStyleBackColor = true;
            this.AttachBtn.Click += new System.EventHandler(this.AttachBtn_Click);
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel,
            this.StatusLabel});
            this.statusStrip1.Location = new System.Drawing.Point(0, 280);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Padding = new System.Windows.Forms.Padding(1, 0, 16, 0);
            this.statusStrip1.Size = new System.Drawing.Size(665, 22);
            this.statusStrip1.TabIndex = 9;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel
            // 
            this.toolStripStatusLabel.Name = "toolStripStatusLabel";
            this.toolStripStatusLabel.Size = new System.Drawing.Size(43, 17);
            this.toolStripStatusLabel.Text = "Status:";
            // 
            // StatusLabel
            // 
            this.StatusLabel.ForeColor = System.Drawing.Color.Red;
            this.StatusLabel.Name = "StatusLabel";
            this.StatusLabel.Size = new System.Drawing.Size(88, 17);
            this.StatusLabel.Text = "Not connected";
            // 
            // ConnectionBox
            // 
            this.ConnectionBox.Controls.Add(this.CCAPI);
            this.ConnectionBox.Controls.Add(this.ConnectBtn);
            this.ConnectionBox.Controls.Add(this.IPtextBox);
            this.ConnectionBox.Controls.Add(this.AttachBtn);
            this.ConnectionBox.Controls.Add(this.IP_Reader);
            this.ConnectionBox.Controls.Add(this.TMAPI);
            this.ConnectionBox.Controls.Add(this.PS3MAPI);
            this.ConnectionBox.Location = new System.Drawing.Point(7, 14);
            this.ConnectionBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.ConnectionBox.Name = "ConnectionBox";
            this.ConnectionBox.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.ConnectionBox.Size = new System.Drawing.Size(303, 154);
            this.ConnectionBox.TabIndex = 10;
            this.ConnectionBox.TabStop = false;
            this.ConnectionBox.Text = "Connection";
            // 
            // IPWriterBox
            // 
            this.IPWriterBox.Controls.Add(this.writeIP_Btn);
            this.IPWriterBox.Controls.Add(this.IPtextBox2);
            this.IPWriterBox.Location = new System.Drawing.Point(-35, 218);
            this.IPWriterBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.IPWriterBox.Name = "IPWriterBox";
            this.IPWriterBox.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.IPWriterBox.Size = new System.Drawing.Size(12, 12);
            this.IPWriterBox.TabIndex = 11;
            this.IPWriterBox.TabStop = false;
            this.IPWriterBox.Text = "IP Writer";
            this.IPWriterBox.Visible = false;
            // 
            // writeIP_Btn
            // 
            this.writeIP_Btn.Location = new System.Drawing.Point(26, 52);
            this.writeIP_Btn.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.writeIP_Btn.Name = "writeIP_Btn";
            this.writeIP_Btn.Size = new System.Drawing.Size(252, 26);
            this.writeIP_Btn.TabIndex = 8;
            this.writeIP_Btn.Text = "Write IP";
            this.writeIP_Btn.UseVisualStyleBackColor = true;
            this.writeIP_Btn.Click += new System.EventHandler(this.writeIP_Btn_Click);
            // 
            // IPtextBox2
            // 
            this.IPtextBox2.Location = new System.Drawing.Point(26, 22);
            this.IPtextBox2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.IPtextBox2.Name = "IPtextBox2";
            this.IPtextBox2.Size = new System.Drawing.Size(251, 23);
            this.IPtextBox2.TabIndex = 8;
            // 
            // GameModsGBox
            // 
            this.GameModsGBox.Controls.Add(this.UltraSuperSpeedCBox);
            this.GameModsGBox.Controls.Add(this.IPWriterBox);
            this.GameModsGBox.Controls.Add(this.ESPChestsCBox);
            this.GameModsGBox.Controls.Add(this.SuperSpeedCBox);
            this.GameModsGBox.Controls.Add(this.SpeedCBox);
            this.GameModsGBox.Controls.Add(this.InfiniteCraftingCBox);
            this.GameModsGBox.Controls.Add(this.ESPPlayersCBox);
            this.GameModsGBox.Controls.Add(this.XRayCBox);
            this.GameModsGBox.Controls.Add(this.CanFlyCBox);
            this.GameModsGBox.Controls.Add(this.PlayerIDsOnHeadCBox);
            this.GameModsGBox.Controls.Add(this.InstantKillCBox);
            this.GameModsGBox.Controls.Add(this.AutoHitAndMineCBox);
            this.GameModsGBox.Controls.Add(this.GodModeCBox);
            this.GameModsGBox.Location = new System.Drawing.Point(317, 14);
            this.GameModsGBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.GameModsGBox.Name = "GameModsGBox";
            this.GameModsGBox.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.GameModsGBox.Size = new System.Drawing.Size(341, 260);
            this.GameModsGBox.TabIndex = 12;
            this.GameModsGBox.TabStop = false;
            this.GameModsGBox.Text = "Game Mods";
            // 
            // XRayCBox
            // 
            this.XRayCBox.AutoSize = true;
            this.XRayCBox.Location = new System.Drawing.Point(15, 80);
            this.XRayCBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.XRayCBox.Name = "XRayCBox";
            this.XRayCBox.Size = new System.Drawing.Size(112, 19);
            this.XRayCBox.TabIndex = 5;
            this.XRayCBox.Text = "X-Ray Vision (N)";
            this.XRayCBox.UseVisualStyleBackColor = true;
            this.XRayCBox.CheckedChanged += new System.EventHandler(this.XRayCBox_CheckedChanged);
            // 
            // CanFlyCBox
            // 
            this.CanFlyCBox.AutoSize = true;
            this.CanFlyCBox.Location = new System.Drawing.Point(15, 162);
            this.CanFlyCBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.CanFlyCBox.Name = "CanFlyCBox";
            this.CanFlyCBox.Size = new System.Drawing.Size(131, 19);
            this.CanFlyCBox.TabIndex = 4;
            this.CanFlyCBox.Text = "Enable Flying (H & N)";
            this.CanFlyCBox.UseVisualStyleBackColor = true;
            this.CanFlyCBox.CheckedChanged += new System.EventHandler(this.CanFlyCBox_CheckedChanged);
            // 
            // PlayerIDsOnHeadCBox
            // 
            this.PlayerIDsOnHeadCBox.AutoSize = true;
            this.PlayerIDsOnHeadCBox.Location = new System.Drawing.Point(15, 135);
            this.PlayerIDsOnHeadCBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.PlayerIDsOnHeadCBox.Name = "PlayerIDsOnHeadCBox";
            this.PlayerIDsOnHeadCBox.Size = new System.Drawing.Size(147, 19);
            this.PlayerIDsOnHeadCBox.TabIndex = 3;
            this.PlayerIDsOnHeadCBox.Text = "Player IDs On Head (N)";
            this.PlayerIDsOnHeadCBox.UseVisualStyleBackColor = true;
            this.PlayerIDsOnHeadCBox.CheckedChanged += new System.EventHandler(this.PlayerIDsOnHeadCBox_CheckedChanged);
            // 
            // InstantKillCBox
            // 
            this.InstantKillCBox.AutoSize = true;
            this.InstantKillCBox.Location = new System.Drawing.Point(15, 108);
            this.InstantKillCBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.InstantKillCBox.Name = "InstantKillCBox";
            this.InstantKillCBox.Size = new System.Drawing.Size(101, 19);
            this.InstantKillCBox.TabIndex = 2;
            this.InstantKillCBox.Text = "Instant Kill (H)";
            this.InstantKillCBox.UseVisualStyleBackColor = true;
            this.InstantKillCBox.CheckedChanged += new System.EventHandler(this.InstantKillCBox_CheckedChanged);
            // 
            // AutoHitAndMineCBox
            // 
            this.AutoHitAndMineCBox.AutoSize = true;
            this.AutoHitAndMineCBox.Location = new System.Drawing.Point(15, 52);
            this.AutoHitAndMineCBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.AutoHitAndMineCBox.Name = "AutoHitAndMineCBox";
            this.AutoHitAndMineCBox.Size = new System.Drawing.Size(124, 19);
            this.AutoHitAndMineCBox.TabIndex = 1;
            this.AutoHitAndMineCBox.Text = "Auto Hit & Mine (N)";
            this.AutoHitAndMineCBox.UseVisualStyleBackColor = true;
            this.AutoHitAndMineCBox.CheckedChanged += new System.EventHandler(this.AutoHitAndMineCBox_CheckedChanged);
            // 
            // GodModeCBox
            // 
            this.GodModeCBox.AutoSize = true;
            this.GodModeCBox.Location = new System.Drawing.Point(15, 25);
            this.GodModeCBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.GodModeCBox.Name = "GodModeCBox";
            this.GodModeCBox.Size = new System.Drawing.Size(102, 19);
            this.GodModeCBox.TabIndex = 0;
            this.GodModeCBox.Text = "God Mode (H)";
            this.GodModeCBox.UseVisualStyleBackColor = true;
            this.GodModeCBox.CheckedChanged += new System.EventHandler(this.GodModeCBox_CheckedChanged);
            // 
            // ESPPlayersCBox
            // 
            this.ESPPlayersCBox.AutoSize = true;
            this.ESPPlayersCBox.Location = new System.Drawing.Point(15, 190);
            this.ESPPlayersCBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.ESPPlayersCBox.Name = "ESPPlayersCBox";
            this.ESPPlayersCBox.Size = new System.Drawing.Size(105, 19);
            this.ESPPlayersCBox.TabIndex = 9;
            this.ESPPlayersCBox.Text = "ESP Players (N)";
            this.ESPPlayersCBox.UseVisualStyleBackColor = true;
            this.ESPPlayersCBox.CheckedChanged += new System.EventHandler(this.ESPPlayersCBox_CheckedChanged);
            // 
            // UltraSuperSpeedCBox
            // 
            this.UltraSuperSpeedCBox.AutoSize = true;
            this.UltraSuperSpeedCBox.Location = new System.Drawing.Point(172, 135);
            this.UltraSuperSpeedCBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.UltraSuperSpeedCBox.Name = "UltraSuperSpeedCBox";
            this.UltraSuperSpeedCBox.Size = new System.Drawing.Size(139, 19);
            this.UltraSuperSpeedCBox.TabIndex = 14;
            this.UltraSuperSpeedCBox.Text = "Ultra Super Speed (N)";
            this.UltraSuperSpeedCBox.UseVisualStyleBackColor = true;
            this.UltraSuperSpeedCBox.CheckedChanged += new System.EventHandler(this.UltraSuperSpeedCBox_CheckedChanged);
            // 
            // ESPChestsCBox
            // 
            this.ESPChestsCBox.AutoSize = true;
            this.ESPChestsCBox.Location = new System.Drawing.Point(172, 25);
            this.ESPChestsCBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.ESPChestsCBox.Name = "ESPChestsCBox";
            this.ESPChestsCBox.Size = new System.Drawing.Size(103, 19);
            this.ESPChestsCBox.TabIndex = 13;
            this.ESPChestsCBox.Text = "ESP Chests (N)";
            this.ESPChestsCBox.UseVisualStyleBackColor = true;
            this.ESPChestsCBox.CheckedChanged += new System.EventHandler(this.ESPChestsCBox_CheckedChanged);
            // 
            // SuperSpeedCBox
            // 
            this.SuperSpeedCBox.AutoSize = true;
            this.SuperSpeedCBox.Location = new System.Drawing.Point(172, 108);
            this.SuperSpeedCBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.SuperSpeedCBox.Name = "SuperSpeedCBox";
            this.SuperSpeedCBox.Size = new System.Drawing.Size(111, 19);
            this.SuperSpeedCBox.TabIndex = 12;
            this.SuperSpeedCBox.Text = "Super Speed (N)";
            this.SuperSpeedCBox.UseVisualStyleBackColor = true;
            this.SuperSpeedCBox.CheckedChanged += new System.EventHandler(this.SuperSpeedCBox_CheckedChanged);
            // 
            // SpeedCBox
            // 
            this.SpeedCBox.AutoSize = true;
            this.SpeedCBox.Location = new System.Drawing.Point(172, 80);
            this.SpeedCBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.SpeedCBox.Name = "SpeedCBox";
            this.SpeedCBox.Size = new System.Drawing.Size(78, 19);
            this.SpeedCBox.TabIndex = 11;
            this.SpeedCBox.Text = "Speed (N)";
            this.SpeedCBox.UseVisualStyleBackColor = true;
            this.SpeedCBox.CheckedChanged += new System.EventHandler(this.SpeedCBox_CheckedChanged);
            // 
            // InfiniteCraftingCBox
            // 
            this.InfiniteCraftingCBox.AutoSize = true;
            this.InfiniteCraftingCBox.Location = new System.Drawing.Point(172, 52);
            this.InfiniteCraftingCBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.InfiniteCraftingCBox.Name = "InfiniteCraftingCBox";
            this.InfiniteCraftingCBox.Size = new System.Drawing.Size(144, 19);
            this.InfiniteCraftingCBox.TabIndex = 10;
            this.InfiniteCraftingCBox.Text = "Infinite Crafting (H & N)";
            this.InfiniteCraftingCBox.UseVisualStyleBackColor = true;
            this.InfiniteCraftingCBox.CheckedChanged += new System.EventHandler(this.InfiniteCraftingCBox_CheckedChanged);
            // 
            // InformationLabel
            // 
            this.InformationLabel.AutoSize = true;
            this.InformationLabel.Font = new System.Drawing.Font("Segoe UI", 7.5F);
            this.InformationLabel.Location = new System.Drawing.Point(12, 178);
            this.InformationLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.InformationLabel.Name = "InformationLabel";
            this.InformationLabel.Size = new System.Drawing.Size(145, 72);
            this.InformationLabel.TabIndex = 13;
            this.InformationLabel.Text = "H = Host Mod\r\nN = Non-Host Mod\r\nTool Created By: EternalModz\r\nOffsets From: Ultim" +
    "ateCraft RTM\r\nPS3 APIs By: iixFi\r\nApp Version: 1.1.0";
            // 
            // SourceCodeBtn
            // 
            this.SourceCodeBtn.Location = new System.Drawing.Point(177, 178);
            this.SourceCodeBtn.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.SourceCodeBtn.Name = "SourceCodeBtn";
            this.SourceCodeBtn.Size = new System.Drawing.Size(130, 29);
            this.SourceCodeBtn.TabIndex = 14;
            this.SourceCodeBtn.Text = "Source Code";
            this.SourceCodeBtn.UseVisualStyleBackColor = true;
            this.SourceCodeBtn.Click += new System.EventHandler(this.SourceCodeBtn_Click);
            // 
            // YouTubeBtn
            // 
            this.YouTubeBtn.Location = new System.Drawing.Point(177, 221);
            this.YouTubeBtn.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.YouTubeBtn.Name = "YouTubeBtn";
            this.YouTubeBtn.Size = new System.Drawing.Size(130, 29);
            this.YouTubeBtn.TabIndex = 15;
            this.YouTubeBtn.Text = "Subscribe";
            this.YouTubeBtn.UseVisualStyleBackColor = true;
            this.YouTubeBtn.Click += new System.EventHandler(this.YouTubeBtn_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(665, 302);
            this.Controls.Add(this.YouTubeBtn);
            this.Controls.Add(this.SourceCodeBtn);
            this.Controls.Add(this.InformationLabel);
            this.Controls.Add(this.GameModsGBox);
            this.Controls.Add(this.ConnectionBox);
            this.Controls.Add(this.statusStrip1);
            this.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Pxrple RTM Tool | Made By: EternalModz";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ConnectionBox.ResumeLayout(false);
            this.ConnectionBox.PerformLayout();
            this.IPWriterBox.ResumeLayout(false);
            this.IPWriterBox.PerformLayout();
            this.GameModsGBox.ResumeLayout(false);
            this.GameModsGBox.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button ConnectBtn;
        private System.Windows.Forms.CheckBox IP_Reader;
        private System.Windows.Forms.TextBox IPtextBox;
        private System.Windows.Forms.RadioButton CCAPI;
        private System.Windows.Forms.RadioButton TMAPI;
        private System.Windows.Forms.RadioButton PS3MAPI;
        private System.Windows.Forms.Button AttachBtn;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel;
        private System.Windows.Forms.ToolStripStatusLabel StatusLabel;
        private System.Windows.Forms.GroupBox ConnectionBox;
        private System.Windows.Forms.GroupBox IPWriterBox;
        private System.Windows.Forms.Button writeIP_Btn;
        private System.Windows.Forms.TextBox IPtextBox2;
        private System.Windows.Forms.GroupBox GameModsGBox;
        private System.Windows.Forms.CheckBox XRayCBox;
        private System.Windows.Forms.CheckBox CanFlyCBox;
        private System.Windows.Forms.CheckBox PlayerIDsOnHeadCBox;
        private System.Windows.Forms.CheckBox InstantKillCBox;
        private System.Windows.Forms.CheckBox AutoHitAndMineCBox;
        private System.Windows.Forms.CheckBox GodModeCBox;
        private System.Windows.Forms.CheckBox UltraSuperSpeedCBox;
        private System.Windows.Forms.CheckBox ESPChestsCBox;
        private System.Windows.Forms.CheckBox SuperSpeedCBox;
        private System.Windows.Forms.CheckBox SpeedCBox;
        private System.Windows.Forms.CheckBox InfiniteCraftingCBox;
        private System.Windows.Forms.CheckBox ESPPlayersCBox;
        private System.Windows.Forms.Label InformationLabel;
        private System.Windows.Forms.Button SourceCodeBtn;
        private System.Windows.Forms.Button YouTubeBtn;
    }
}

