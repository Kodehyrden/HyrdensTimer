using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HyrdensTimer
{
    public partial class HyrdensTimerForm : Form
    {
        private Point formLocation;
        private System.Windows.Forms.FormBorderStyle borderStyle;
        private System.Drawing.Size formSize;
        private System.Drawing.Color txColor;
        private System.Drawing.Color bgColor;
        private bool fullScreen;
        private int duration;
        private DateTime startTime;
        private DateTime endTime;

        public HyrdensTimerForm()
        {
            InitializeComponent();
            borderStyle = this.FormBorderStyle;
            formSize = this.Size;
            txColor = TimeLeft.ForeColor;
            bgColor = this.BackColor;
            fullScreen = false;
            Duration = 15;
        }

        public int Duration {
            get { return duration; }
            set { duration = value; }
        }

        private void ToggleFullscreen()
        {
            if (!fullScreen)
            {
                formLocation = this.Location;
                this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
                this.Bounds = Screen.FromControl(this).Bounds;
                TimeLeft.ForeColor = System.Drawing.Color.White;
                this.BackColor = System.Drawing.Color.Black;
                fullScreen = true;
            }
            else
            {
                this.Location = formLocation;
                this.FormBorderStyle = borderStyle;
                this.Size = formSize;
                TimeLeft.ForeColor = txColor;
                this.BackColor = bgColor;
                fullScreen = false;
            }
        }

        private void UpdateLabel() 
        {
            TimeSpan timeLeft = endTime - DateTime.Now;
            TimeLeft.Text = (timeLeft.TotalSeconds < 0 ? "-" : "") +
                string.Format(Math.Abs(timeLeft.TotalMinutes) < 60 ? "{0:m\\:ss}" : "{0:h\\:mm\\:ss}", timeLeft);
        }
        
        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            bool result = true;
            switch (keyData)
            {
                case Keys.Escape:
                    if (fullScreen) ToggleFullscreen(); // Exit fullscreen
                    break;
                case Keys.T:
                    ToggleFullscreen();
                    break;
                default:
                  result = base.ProcessCmdKey(ref msg, keyData);
                  break;
            }
            return result;
        }

        private void HyrdensTimerForm_Shown(object sender, EventArgs e)
        { 
            startTime = DateTime.Now;
            endTime = startTime + new TimeSpan(0, duration, 0); 
            timer1.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            UpdateLabel();
        }

        private void TimeLeft_Click(object sender, EventArgs e)
        {
            ToggleFullscreen();
        }
    }
}
