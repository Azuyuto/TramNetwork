using System;
using System.Drawing;
using System.Windows.Forms;

namespace TramNetwork.Controls
{
    public partial class SimulationView : Control
    {
        public SimulationView()
        {
            InitializeComponent();
        }

        private void PaintNodes(PaintEventArgs e)
        {
            Pen pen = Pens.Red;
            e.Graphics.DrawLine(pen, 1, 10, 200, 210);
        }
    }
}
