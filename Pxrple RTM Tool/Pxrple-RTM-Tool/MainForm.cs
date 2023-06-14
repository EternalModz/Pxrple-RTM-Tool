using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PS3Lib;
using PS3Lib.NET;
using PS3ManagerAPI;

namespace Tool_Base
{
    public partial class MainForm : Form
    {
        public static PS3API PS3 = new PS3API();
        public static PS3ManagerAPI.PS3MAPI PS3M_API = new PS3ManagerAPI.PS3MAPI();
        public MainForm()
        {
            InitializeComponent();
            GameModsGBox.Enabled = false;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        #region PS3 Connection

        private void CCAPI_CheckedChanged(object sender, EventArgs e)
        {
            PS3.ChangeAPI(SelectAPI.ControlConsole);
        }

        private void TMAPI_CheckedChanged(object sender, EventArgs e)
        {
            PS3.ChangeAPI(SelectAPI.TargetManager);
        }

        private void PS3MAPI_CheckedChanged(object sender, EventArgs e)
        {
            PS3.ChangeAPI(SelectAPI.PS3Manager);
        }

        private void ConnectBtn_Click(object sender, EventArgs e)
        {
            if (PS3.GetCurrentAPI() == SelectAPI.ControlConsole)
            {
                try
                {
                    MainForm.PS3.ConnectTarget(this.IPtextBox.Text);
                    this.StatusLabel.Text = "Connected";
                    this.StatusLabel.ForeColor = Color.Green;
                }
                catch
                {
                    this.StatusLabel.Text = "Not connected";
                    this.StatusLabel.ForeColor = Color.Red;
                }
            }
            else if (PS3.GetCurrentAPI() == SelectAPI.TargetManager)
            {
                try
                {
                    MainForm.PS3.ConnectTarget();
                    this.StatusLabel.Text = "Connected";
                    this.StatusLabel.ForeColor = Color.Green;
                }
                catch
                {
                    this.StatusLabel.Text = "Not connected";
                    this.StatusLabel.ForeColor = Color.Red;
                }
            }
            else if (PS3.GetCurrentAPI() == SelectAPI.PS3Manager)
            {
                try
                {
                    PS3M_API.ConnectTarget(this.IPtextBox.Text, Convert.ToInt32(7887));
                    if (PS3M_API.IsConnected)
                    foreach (uint pidProcess in MainForm.PS3M_API.Process.GetPidProcesses())
                    {
                        if (pidProcess != 0U)
                        {
                            PS3M_API.Process.GetName(pidProcess);
                        }
                    }
                    this.StatusLabel.Text = "Connected";
                    this.StatusLabel.ForeColor = Color.Green;
                }
                catch
                {
                    this.StatusLabel.Text = "Not connected";
                    this.StatusLabel.ForeColor = Color.Red;
                }
            }
        }

        private void AttachBtn_Click(object sender, EventArgs e)
        {
            if (PS3.GetCurrentAPI() == SelectAPI.ControlConsole || PS3.GetCurrentAPI() == SelectAPI.TargetManager)
            {
                try
                {
                    PS3.AttachProcess();
                    this.StatusLabel.Text = "Connected + Attached";
                    this.StatusLabel.ForeColor = Color.Green;
                }
                catch
                {
                    this.StatusLabel.Text = "Not attached";
                    this.StatusLabel.ForeColor = Color.Red;
                }
            }
            else if (PS3.GetCurrentAPI() == SelectAPI.PS3Manager)
            {
                try
                {
                    MainForm.PS3M_API.AttachProcess(MainForm.PS3M_API.Process.Processes_Pid[0]);
                    if (MainForm.PS3M_API.IsAttached)
                    {
                        //mods
                        this.StatusLabel.Text = "Connected + Attached";
                        this.StatusLabel.ForeColor = Color.Green;
                    }
                }
                catch
                {
                    this.StatusLabel.Text = "Not attached";
                    this.StatusLabel.ForeColor = Color.Red;
                }
            }

            GameModsGBox.Enabled = true;
        }

#endregion

        private void IP_Reader_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void writeIP_Btn_Click(object sender, EventArgs e)
        {

        }

        #region Minecraft PS3 Offsets

        //God Mode Mod (Host Mod)
        public void GOD_MODE(bool toggle)
        {
            if (toggle)
            {
                PS3.SetMemory(0x004B2021, new byte[] { 0x80 }); //Enabled
            }
            else if (!toggle)
            {
                PS3.SetMemory(0x004B2021, new byte[] { 0x20 }); //Disabled
            }
        }

        //Instant Kill (Host Mod)
        public void INSTANT_KILL(bool toggle)
        {
            if (toggle)
            {
                PS3.SetMemory(0x001AC411, new byte[] { 0xE0, 0x28, 0x90 }); //Enabled
            }
            else if (!toggle)
            {
                PS3.SetMemory(0x001AC411, new byte[] { 0xE0, 0x08, 0x90 }); //Disabled
            }
        }

        //Auto Hit & Auto Mine (Non-Host Mod)
        public void AUTO_MINE(bool toggle)
        {
            if (toggle)
            {
                PS3.SetMemory(0x00AEC42C, new byte[] { 0x40 }); //Enabled
            }
            else if (!toggle)
            {
                PS3.SetMemory(0x00AEC42C, new byte[] { 0x41 }); //Disabled
            }
        }

        //X-Ray (Non-Host Mod)
        public void XRAY(bool toggle)
        {
            if (toggle)
            {
                PS3.SetMemory(0x00A99154, new byte[] { 0xFC, 0x80, 0x30, 0x90 }); //Enabled
            }
            else if (!toggle)
            {
                PS3.SetMemory(0x00A99154, new byte[] { 0xFC, 0x60, 0x30, 0x90 }); //Disabled
            }
        }

        //Player ID Over Head (Non-Host Mod)
        public void GET_PLAYER_IDS_OVER_HEAD(bool toggle)
        {
            if (toggle)
            {
                PS3.SetMemory(0x004B5DF3, new byte[] { 0x01 }); //Enabled
            }
            else if (!toggle)
            {
                PS3.SetMemory(0x004B5DF3, new byte[] { 0x00 }); //Disabled
            }
        }

        //Can Fly (Host / Non-Host Mod)
        public void CAN_FLY(bool toggle)
        {
            if (toggle)
            {
                PS3.SetMemory(0x00B02378, new byte[] { 0x40 }); //Enabled
            }
            else if (!toggle)
            {
                PS3.SetMemory(0x00B02378, new byte[] { 0x41 }); //Disabled
            }
        }

        //ESP Players (Non-Host Multi-Mod)
        public void ESP_PLAYERS(bool toggle)
        {
            if (toggle)
            { //Enabled
                PS3.SetMemory(0x00A98F50, new byte[] { 0x3F, 0x00 });
                PS3.SetMemory(0x00AD5B60, new byte[] { 0x41 });
                PS3.SetMemory(0x00AD5A5C, new byte[] { 0x6F, 0xFF });
            }
            else if (!toggle)
            { //Disabled (? ||| Not sure if this one disables it...)
                PS3.SetMemory(0x00A98F50, new byte[] { 0x3D, 0x8C });
                PS3.SetMemory(0x00AD5B60, new byte[] { 0x40 });
                PS3.SetMemory(0x00AD5A5C, new byte[] { 0x3F, 0x80 });
            }
        }

        //ESP Chests (Non-Host)
        public void ESP_CHESTS(bool toggle)
        {
            if (toggle)
            {
                PS3.SetMemory(0x00A9C2B4, new byte[] { 0x3E, 0xFF }); //Enabled
            }
            else if (!toggle)
            {
                PS3.SetMemory(0x00A9C2B4, new byte[] { 0x3F, 0x80 }); //Disabled
            }
        }

        //Infinite Crafting (Host & Non-Host)
        public void INFINITE_CRAFTING(bool toggle)
        {
            if (toggle)
            {
                PS3.SetMemory(0x0098871F, new byte[] { 0x01 }); //Enabled
            }
            else if (!toggle)
            {
                PS3.SetMemory(0x0098871F, new byte[] { 0x00 }); //Disabled
            }
        }

        //Speed (Host & Non-Host Mod)
        public void SPEED(bool toggle)
        {
            if (toggle)
            {
                PS3.SetMemory(0x003ABD49, new byte[] { 0xFF, 0xFF, 0xFF }); //Enabled
            }
            else if (!toggle)
            {
                PS3.SetMemory(0x003ABD49, new byte[] { 0x26, 0xAD, 0x89 }); //Disabled
            }
        }

        //Super Speed (Host & Non-Host Mod)
        public void SUPER_SPEED(bool toggle)
        {
            if (toggle)
            {
                PS3.SetMemory(0x003ABD48, new byte[] { 0x3F, 0xFF, 0x00, 0x01 }); //Enabled
            }
            else if (!toggle)
            {
                PS3.SetMemory(0x003ABD48, new byte[] { 0x3E, 0x26, 0xAD, 0x89 }); //Disabled
            }
        }

        //Ultra Super Speed (Host & Non-Host Multi-Mod)
        public void ULTRA_SUPER_SPEED(bool toggle)
        {
            if (toggle)
            { //Enabled
                PS3.SetMemory(0x003ABD48, new byte[] { 0x3F, 0xFF, 0x00, 0x01 });
                PS3.SetMemory(0x003ABD48, new byte[] { 0x41, 0xFF });
            }
            else if (!toggle)
            { //Disabled
                PS3.SetMemory(0x003ABD48, new byte[] { 0x3E, 0x26, 0xAD, 0x89 });
                PS3.SetMemory(0x003ABD48, new byte[] { 0x3E, 0x26 });
            }
        }

        #endregion

        private void YouTubeBtn_Click(object sender, EventArgs e)
        {
            //Launches the browser to YouTube
            string url = "https://youtube.com/@EternalModzLive";
            Process.Start(url);
        }

        private void SourceCodeBtn_Click(object sender, EventArgs e)
        {
            //Launches the browser to GitHub
            string url = "https://github.com/EternalModz/Pxrple-RTM-Tool";
            Process.Start(url);
        }

        private void GodModeCBox_CheckedChanged(object sender, EventArgs e)
        {
            if (GodModeCBox.Checked)
            {
                GOD_MODE(true);
            }
            else
            {
                GOD_MODE(false);
            }
        }

        private void AutoHitAndMineCBox_CheckedChanged(object sender, EventArgs e)
        {
            if (AutoHitAndMineCBox.Checked)
            {
                AUTO_MINE(true);
            }
            else
            {
                AUTO_MINE(false);
            }
        }

        private void XRayCBox_CheckedChanged(object sender, EventArgs e)
        {
            if (XRayCBox.Checked)
            {
                XRAY(true);
            }
            else
            {
                XRAY(false);
            }
        }

        private void InstantKillCBox_CheckedChanged(object sender, EventArgs e)
        {
            if (InstantKillCBox.Checked)
            {
                INSTANT_KILL(true);
            }
            else
            {
                INSTANT_KILL(false);
            }
        }

        private void PlayerIDsOnHeadCBox_CheckedChanged(object sender, EventArgs e)
        {
            if (PlayerIDsOnHeadCBox.Checked)
            {
                GET_PLAYER_IDS_OVER_HEAD(true);
            }
            else
            {
                GET_PLAYER_IDS_OVER_HEAD(false);
            }
        }

        private void CanFlyCBox_CheckedChanged(object sender, EventArgs e)
        {
            if (CanFlyCBox.Checked)
            {
                CAN_FLY(true);
            }
            else
            {
                CAN_FLY(false);
            }
        }

        private void ESPPlayersCBox_CheckedChanged(object sender, EventArgs e)
        {
            if (ESPPlayersCBox.Checked)
            {
                ESP_PLAYERS(true);
            }
            else
            {
                ESP_PLAYERS(false);
            }
        }

        private void ESPChestsCBox_CheckedChanged(object sender, EventArgs e)
        {
            if (ESPChestsCBox.Checked)
            {
                ESP_CHESTS(true);
            }
            else
            {
                ESP_CHESTS(false);
            }
        }

        private void InfiniteCraftingCBox_CheckedChanged(object sender, EventArgs e)
        {
            if (InfiniteCraftingCBox.Checked)
            {
                INFINITE_CRAFTING(true);
            }
            else
            {
                INFINITE_CRAFTING(false);
            }
        }

        private void SpeedCBox_CheckedChanged(object sender, EventArgs e)
        {
            if (SpeedCBox.Checked)
            {
                SPEED(true);
            }
            else
            {
                SPEED(false);
            }
        }

        private void SuperSpeedCBox_CheckedChanged(object sender, EventArgs e)
        {
            if (SuperSpeedCBox.Checked)
            {
                SUPER_SPEED(true);
            }
            else
            {
                SUPER_SPEED(false);
            }
        }

        private void UltraSuperSpeedCBox_CheckedChanged(object sender, EventArgs e)
        {
            if (UltraSuperSpeedCBox.Checked)
            {
                ULTRA_SUPER_SPEED(true);
            }
            else
            {
                ULTRA_SUPER_SPEED(false);
            }
        }
    }
}