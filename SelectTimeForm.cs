using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HyrdensTimer {
    public partial class SelectTimeForm : Form {
 
        private HyrdensTimerForm mainForm;

        public SelectTimeForm(HyrdensTimerForm aMainForm) {
            decimal duration;
            mainForm = aMainForm;
            InitializeComponent();
            this.AcceptButton = buOK;
            this.CancelButton = buCancel;
            this.ActiveControl = SelectedTimeValue;
            string[] args = Environment.GetCommandLineArgs();
            try {
                // First argument is the time in minutes
                duration = Convert.ToInt32(args[1]);
            } catch (Exception) {
                // If the conversion goes wrong use as default 15 minutes
                duration = 15;
            }
            this.SelectedTimeValue.Value = duration;
            this.SelectedTimeValue.Select(0,Convert.ToString(duration).Length );
        }

        private void buOK_Click(object sender, EventArgs e) {
            mainForm.Duration = Convert.ToInt32(SelectedTimeValue.Value);
            DialogResult = System.Windows.Forms.DialogResult.OK;
            Close();
        }

        private void buCancel_Click(object sender, EventArgs e) {
            DialogResult = System.Windows.Forms.DialogResult.Cancel;
            Close();
        }
    }
}
