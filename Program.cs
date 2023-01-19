using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using System.Windows.Forms;

namespace Multithreading_11_3_Inprogress
{
    class Program
    {
        public static void LongOperation()
        {
            Console.WriteLine("Process started");
            Thread.Sleep(1500);
            Console.WriteLine("Process finished");
        }

        public static bool Popup(ThreadStart monitorthread, TimeSpan timeout)
        {
            Thread workerThread = new Thread(monitorthread);
            workerThread.Start();

            bool finished = workerThread.Join(timeout);
            
                

            return finished;

        }
        static void Main(string[] args)
        {
            if (Popup(LongOperation, TimeSpan.FromMilliseconds(1000)))
            {
               // MessageBox.Show("Thread was finished.");
            }
            else
            {
                MessageBox.Show("In Progress");
            }
            Console.ReadKey();
        }
    }
}
