using System.Windows.Forms;

namespace ModbusMultiWindowDemo
{
    partial class SlaveForm
    {
        private Label label1;

        private void InitializeComponent()
        {
            this.label1 = new Label();
            this.SuspendLayout();

            this.label1.Dock = DockStyle.Fill;
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 16F);
            this.Controls.Add(this.label1);

            this.ClientSize = new System.Drawing.Size(300, 200);
            this.ResumeLayout(false);
        }
    }
}
