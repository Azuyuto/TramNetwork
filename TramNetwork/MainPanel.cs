using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Timers;
using System.Windows.Forms;
using TramNetwork.Controls;
using TramNetwork.Managers;

namespace TramNetwork
{
    public partial class MainPanel : Form
    {
        private System.Timers.Timer gameTimer { get; set; }
        static MainPanel instance;

        public static MainPanel Instance
        {
            get
            {
                if (instance == null)
                    return new MainPanel();

                return instance;
            }
        }

        public MainPanel()
        {
            instance = this;
            InitializeComponent();
            gameTimer = new System.Timers.Timer();
            gameTimer.Interval = 100;
            gameTimer.Elapsed += new ElapsedEventHandler(OnGameTimeEvent);
            SimulationManager.StartSimulation();
            DrawRoute();
        }

        private void DrawRoute()
        {
            simulationView.DrawRoute(SimulationManager.TramRoutes);
        }

        private void OnGameTimeEvent(object sender, System.Timers.ElapsedEventArgs e)
        {
            Invoke(new Action(() =>
            {
                SimulationManager.DoSimulationStep();
                setTime(SimulationManager.CurrentTime);
            }));
        }

        private void setTime(TimeSpan timeSpan)
        {
            timerLabel.Text = timeSpan.ToString(@"hh\:mm\:ss");
        }

        private void startButton_Click(object sender, EventArgs e)
        {
            gameTimer.Start();
        }

        private void stopSimulation_Click(object sender, EventArgs e)
        {
            gameTimer.Stop();
        }
    }
}
