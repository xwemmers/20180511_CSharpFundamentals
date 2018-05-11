using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EventsDemo
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        GlassOfWater gow = null;

        private void Form1_Load(object sender, EventArgs e)
        {
            gow = new GlassOfWater();

            gow.TemperatureChanged += Gow_TemperatureChanged;

            gow.WaterBoiling += Gow_WaterBoiling;
            gow.WaterFreezing += Gow_WaterFreezing;
            gow.WaterNormal += Gow_WaterNormal;

            gow.Temperature = 20;
        }

        private void Gow_WaterNormal(DateTime when)
        {
            label1.BackColor = Color.White;
        }

        private void Gow_WaterFreezing(DateTime when)
        {
            label1.BackColor = Color.Blue;
        }

        private void Gow_WaterBoiling(DateTime when)
        {
            label1.BackColor = Color.Red;
        }

        private void Gow_TemperatureChanged(DateTime when)
        {
            label1.Text = $"De temperatuur is {gow.Temperature} op tijdstip {when.ToString("HH:mm:ss")}.";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            gow.Temperature--;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            gow.Temperature++;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            gow.Temperature -= 10;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            gow.Temperature += 10;

        }
    }
}
