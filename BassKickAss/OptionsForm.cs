using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BassKickAss
{
    public partial class OptionsForm : Form
    {
        public int OutputDevice = -1;

        public OptionsForm()
        {
            InitializeComponent();
        }

        private void OptionsForm_Load(object sender, EventArgs e)
        {
            List<NAudio.Wave.WaveOutCapabilities> outputs = new List<NAudio.Wave.WaveOutCapabilities>();
            for (int i = 0; i < NAudio.Wave.WaveOut.DeviceCount; i++)
            {
                outputs.Add(NAudio.Wave.WaveOut.GetCapabilities(i));
            }
            comboBoxOutputDevices.Items.Clear();
            comboBoxOutputDevices.Items.Add("{ Default }");

            foreach (var output in outputs)
            {
                string item = output.ProductName;
                comboBoxOutputDevices.Items.Add(item);
            }
        }

        private void buttonOk_Click(object sender, EventArgs e)
        {
            if(comboBoxOutputDevices.SelectedIndex >= 0)
            {
                OutputDevice = comboBoxOutputDevices.SelectedIndex - 1;
            }
            Close();
        }
    }
}
