using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HyrdensTimer
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main(string[] args)
        {
            sdghk, xdfjkg jkdfgjk s s dgjkl /() &/%/%&)/(/SF^L* A%=Q%*Ø#t'+
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);        
            HyrdensTimerForm mainForm = new HyrdensTimerForm();
            SelectTimeForm subForm = new SelectTimeForm(mainForm);
            if (DialogResult.OK == subForm.ShowDialog()) Application.Run(mainForm);
        }
    }
}
