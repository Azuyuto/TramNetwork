
namespace TramNetwork
{
    partial class MainPanel
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.simulationView = new TramNetwork.Controls.SimulationView();
            this.navBar = new System.Windows.Forms.Panel();
            this.startButton = new System.Windows.Forms.Button();
            this.stopSimulation = new System.Windows.Forms.Button();
            this.timerLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
            this.navBar.SuspendLayout();
            this.SuspendLayout();
            // 
            // simulationView
            // 
            this.simulationView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.simulationView.Location = new System.Drawing.Point(0, 0);
            this.simulationView.Name = "simulationView";
            this.simulationView.Size = new System.Drawing.Size(800, 450);
            this.simulationView.TabIndex = 0;
            // 
            // navBar
            // 
            this.navBar.Controls.Add(this.timerLabel);
            this.navBar.Controls.Add(this.stopSimulation);
            this.navBar.Controls.Add(this.startButton);
            this.navBar.Dock = System.Windows.Forms.DockStyle.Top;
            this.navBar.Location = new System.Drawing.Point(0, 0);
            this.navBar.Name = "navBar";
            this.navBar.Size = new System.Drawing.Size(800, 30);
            this.navBar.TabIndex = 1;
            // 
            // startButton
            // 
            this.startButton.Location = new System.Drawing.Point(3, 3);
            this.startButton.Name = "startButton";
            this.startButton.Size = new System.Drawing.Size(121, 23);
            this.startButton.TabIndex = 2;
            this.startButton.Text = "Start Simulation";
            this.startButton.UseVisualStyleBackColor = true;
            this.startButton.Click += new System.EventHandler(this.startButton_Click);
            // 
            // stopSimulation
            // 
            this.stopSimulation.Location = new System.Drawing.Point(130, 3);
            this.stopSimulation.Name = "stopSimulation";
            this.stopSimulation.Size = new System.Drawing.Size(63, 23);
            this.stopSimulation.TabIndex = 3;
            this.stopSimulation.Text = "Stop";
            this.stopSimulation.UseVisualStyleBackColor = true;
            this.stopSimulation.Click += new System.EventHandler(this.stopSimulation_Click);
            // 
            // timerLabel
            // 
            this.timerLabel.AutoSize = true;
            this.timerLabel.Location = new System.Drawing.Point(199, 7);
            this.timerLabel.Name = "timerLabel";
            this.timerLabel.Size = new System.Drawing.Size(49, 15);
            this.timerLabel.TabIndex = 2;
            this.timerLabel.Text = "00:00:00";
            // 
            // MainPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.navBar);
            this.Controls.Add(this.simulationView);
            this.Name = "MainPanel";
            this.Text = "MainPanel";
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
            this.navBar.ResumeLayout(false);
            this.navBar.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.BindingSource bindingSource1;
        private Controls.SimulationView simulationView;
        private System.Windows.Forms.Panel navBar;
        private System.Windows.Forms.Label timerLabel;
        private System.Windows.Forms.Button stopSimulation;
        private System.Windows.Forms.Button startButton;
    }
}

