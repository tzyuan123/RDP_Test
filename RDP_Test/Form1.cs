using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using MSTSCLib;

namespace RDP_Test
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnConnect_Click(object sender, EventArgs e)
         {

             rdpClient.Server = "192.168.3.162";
             rdpClient.UserName = "tzyuan123";
             rdpClient.AdvancedSettings2.RDPPort = 3389;
             rdpClient.AdvancedSettings2.SmartSizing = true;

             rdpClient.AdvancedSettings8.NegotiateSecurityLayer = true;

             IMsTscNonScriptable secured = (IMsTscNonScriptable)rdpClient.GetOcx();
             secured.ClearTextPassword = "tt1234";
             rdpClient.AdvancedSettings5.ClearTextPassword = "tt1234";
            
             rdpClient.ColorDepth = 24;
             rdpClient.Connect();
         }

        private void btnDisConnect_Click(object sender, EventArgs e)
        {

           rdpClient.Disconnect();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void doNothing(object sender, EventArgs e)
        {
        }

        private void rdpClient_OnMouseInputModeChanged(object sender, AxMSTSCLib.IMsTscAxEvents_OnMouseInputModeChangedEvent e)
        {

        }
    }

    


}
