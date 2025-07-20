using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace ModbusMultiWindowDemo
{
    partial class MainForm
    {
        private System.Windows.Forms.ComboBox comboBoxComPorts;
        private System.Windows.Forms.TextBox textBoxSlaveID;
        private System.Windows.Forms.Button buttonConnect;

        private void InitializeComponent()
        {
            this.comboBoxComPorts = new ComboBox();
            this.textBoxSlaveID = new TextBox();
            this.buttonConnect = new Button();

            this.SuspendLayout();

            this.comboBoxComPorts.Location = new System.Drawing.Point(12, 12);
            this.comboBoxComPorts.Width = 100;

            this.textBoxSlaveID.Location = new System.Drawing.Point(120, 12);
            this.textBoxSlaveID.Width = 50;

            this.buttonConnect.Location = new System.Drawing.Point(180, 10);
            this.buttonConnect.Text = "Connect";
            this.buttonConnect.Click += new System.EventHandler(this.buttonConnect_Click);

            this.ClientSize = new System.Drawing.Size(300, 50);
            this.Controls.Add(this.comboBoxComPorts);
            this.Controls.Add(this.textBoxSlaveID);
            this.Controls.Add(this.buttonConnect);
            this.Text = "Modbus Master";
            this.ResumeLayout(false);
        }
    }
}
