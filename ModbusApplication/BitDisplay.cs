using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ModbusApplication
{
    public partial class BitDisplay : Form
    {
        int value;
        public BitDisplay(int value)
        {
            InitializeComponent();

            this.value = value;
        }

        private void BitDisplay_Load(object sender, EventArgs e)
        {
            loadBits();
            timer1.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            loadBits();
        }

        private void loadBits()
        {
            var bv = new BitArray(new int[] { value }).Cast<bool>().ToArray();

            bit0.Checked = bv[0];
            bit1.Checked = bv[1];
            bit2.Checked = bv[2];
            bit3.Checked = bv[3];
            bit4.Checked = bv[4];
            bit5.Checked = bv[5];
            bit6.Checked = bv[6];
            bit7.Checked = bv[7];
            bit8.Checked = bv[8];
            bit9.Checked = bv[9];
            bit10.Checked = bv[10];
            bit11.Checked = bv[11];
            bit12.Checked = bv[12];
            bit13.Checked = bv[13];
            bit14.Checked = bv[14];
            bit15.Checked = bv[15];

        }
    }
}
