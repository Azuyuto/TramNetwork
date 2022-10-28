using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using TramNetwork.Common.Models;

namespace TramNetwork.Controls
{
    public partial class SimulationView : UserControl
    {
        public List<TramRoute> TramRoutes { get; set; }
        public SimulationView()
        {
            InitializeComponent();
        }

        public void DrawRoute(List<TramRoute> tramRoutes)
        {
            TramRoutes = tramRoutes;
            this.Refresh();
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);
            for (int i = 0; i < TramRoutes.Count; i++)
            {
                for (int j = 0; j < TramRoutes[i].Coordinators.Count - 1;j++)
                {
                    float x1 = TramRoutes[i].Coordinators[j].X;
                    float y1 = TramRoutes[i].Coordinators[j].Y;
                    float x2 = TramRoutes[i].Coordinators[j+1].X;
                    float y2 = TramRoutes[i].Coordinators[j+1].Y;
                    drawLine(e, x1, y1, x2, y2);
                }
            }
        }

        private void drawLine(PaintEventArgs e, float x1, float y1, float x2, float y2)
        {
            Pen pen = new Pen(Color.FromArgb(255, 0, 0, 0), 2);
            pen.DashStyle = System.Drawing.Drawing2D.DashStyle.Dash;
            e.Graphics.DrawLine(pen, x1, y1, x2, y2);
        }
    }
}
