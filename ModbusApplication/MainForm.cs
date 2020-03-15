using EasyModbus;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ModbusApplication
{
    public partial class MainForm : Form
    {
        private ModbusClient modbusClient;

        public MainForm()
        {
            InitializeComponent();
            updateTimer.Start();
        }

        private void connectButton_Click(object sender, EventArgs e)
        {
            modbusClient = new ModbusClient(ipAddressTextBox.Text, 502);
        }

        private void updateTimer_Tick(object sender, EventArgs e)
        {
            if (modbusClient != null)
            {
                if (modbusClient.Connected)
                {
                    connectedLabel.Text = "Connected";

                    int[] readHoldingRegisters = modbusClient.ReadHoldingRegisters(0, 10);    //Read 10 Holding Registers from Server, starting with Address 1
                    holdingRegListBox.Items.Clear();
                    holdingRegListBox.Items.Add(readHoldingRegisters);

                }
                else
                {
                    connectedLabel.Text = "Disconnected";
                }
            }
        }

        private void MainForm_Load(object sender, EventArgs e)
        {

        }
    }
}
