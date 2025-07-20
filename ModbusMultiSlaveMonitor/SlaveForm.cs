using System.Windows.Forms;

namespace ModbusMultiWindowDemo
{
    public partial class SlaveForm : Form
    {
        public SlaveForm(int slaveId)
        {
            InitializeComponent();
            this.Text = $"Slave ID {slaveId}";
            label1.Text = $"模擬資料\nVoltage: 12.3V\nTemp: 25°C";
        }
    }
}
