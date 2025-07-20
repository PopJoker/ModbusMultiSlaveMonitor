using System;
using System.Collections.Generic;
using System.IO.Ports;
using System.Linq;
using System.Windows.Forms;

namespace ModbusMultiWindowDemo
{
    public partial class MainForm : Form
    {
        private Dictionary<int, SlaveForm> slaveForms = new Dictionary<int, SlaveForm>();

        public MainForm()
        {
            InitializeComponent();
            comboBoxComPorts.Items.AddRange(SerialPort.GetPortNames());
        }

        private void buttonConnect_Click(object sender, EventArgs e)
        {
            if (!int.TryParse(textBoxSlaveID.Text, out int slaveId))
            {
                MessageBox.Show("請輸入正確的 Slave ID");
                return;
            }

            if (slaveForms.ContainsKey(slaveId))
            {
                MessageBox.Show($"ID {slaveId} 的視窗已開啟");
                return;
            }

            var form = new SlaveForm(slaveId);
            slaveForms[slaveId] = form;

            PositionForm(form, slaveForms.Count - 1);
            form.FormClosed += (s, args) => slaveForms.Remove(slaveId);
            form.Show();
        }

        private void PositionForm(Form form, int index)
        {
            int screenWidth = Screen.PrimaryScreen.WorkingArea.Width;
            int screenHeight = Screen.PrimaryScreen.WorkingArea.Height;
            int formWidth = screenWidth / 5;
            int formHeight = screenHeight / 2;

            int row = index / 5;
            int col = index % 5;

            form.StartPosition = FormStartPosition.Manual;
            form.Bounds = new System.Drawing.Rectangle(col * formWidth, row * formHeight, formWidth, formHeight);
        }
    }
}
