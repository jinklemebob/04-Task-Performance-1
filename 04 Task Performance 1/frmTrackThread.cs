using System;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using System.Threading;


namespace _04_Task_Performance_1
{
    public partial class frmTrackThread : Form
    {
        [DllImport("kernel32.dll", SetLastError = true)]
        [return: MarshalAs(UnmanagedType.Bool)]
        static extern bool AllocConsole();
        Thread threadA;
        Thread threadB;
        Thread threadC;
        Thread threadD;

        public frmTrackThread()
        {
            InitializeComponent();
        }


            private void RunButton_Click(object sender, EventArgs e)
             {
            AllocConsole();

            Console.WriteLine("-- Thread Starts --");

            threadA = new Thread(MyThreadClass.Thread1);
            threadA.Name = "Thread A";
            threadA.Priority = ThreadPriority.Highest;

            threadB = new Thread(MyThreadClass.Thread2);
            threadB.Name = "Thread B";
            threadB.Priority = ThreadPriority.Normal;

            threadC = new Thread(MyThreadClass.Thread1);
            threadC.Name = "Thread C";
            threadC.Priority = ThreadPriority.AboveNormal;

            threadD = new Thread(MyThreadClass.Thread2);
            threadD.Name = "Thread D";
            threadD.Priority = ThreadPriority.BelowNormal;

            threadA.Start();
            threadB.Start();
            threadC.Start();
            threadD.Start();

            threadA.Join();
            threadB.Join();
            threadC.Join();
            threadD.Join();

            Console.WriteLine("-- End of Thread --");
            ThreadState.Text = "-- End of Thread --";
        }
    }
}
