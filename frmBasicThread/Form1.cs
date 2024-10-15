using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace frmBasicThread
{
    public partial class frmBasicThread : Form
    {
        public frmBasicThread()
        {
            InitializeComponent();
        }

        private void btnRun_Click(object sender, EventArgs e)
        {
        
            label1.Text = "Starting Threads...";
            Refresh();

            Thread threadA = new Thread(new ThreadStart(MyThreadClass.Thread1));
            Thread threadB = new Thread(new ThreadStart(MyThreadClass.Thread1));


            threadA.Name = "Thread A";
            threadB.Name = "Thread B";


            threadA.Start();
            threadB.Start();

    
            threadA.Join();  

     
            label1.Text = "End of Thread.";
        }
    }

}

