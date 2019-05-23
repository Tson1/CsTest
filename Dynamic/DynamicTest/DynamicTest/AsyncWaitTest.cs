using System.Linq;
using System.Text;
using System.Threading.Tasks;

using NUnit.Framework;
using System.Dynamic;
using System.Diagnostics;
using System.Runtime.Serialization;
using System;
namespace DynamicTest
{
    [TestFixture]
    public class AsyncWaitTest
    {
        [Test]
        public void NormalTest()
        {
            Debug.WriteLine("Main thread One Start.");

            methodOne();


            System.Threading.Thread.Sleep(3 * 1000);
            Debug.WriteLine("Main thread One End.");
        }

        private static void methodOne()
        {
            Debug.WriteLine("New thread start.");
            Task.Run(new Action(LongTaskOne));
            Debug.WriteLine("New thread END.");
        }
        private static void LongTaskOne(){
            Debug.WriteLine("LongTaskOne start .");
            System.Threading.Thread.Sleep(1 * 1000);
            Debug.WriteLine("LongTaskOne END .");
        }

        [Test]
        public void AsyncWaitMethodTest()
        {
            Debug.WriteLine("Main thread AsyncWait Start.");

            methodTow();


            System.Threading.Thread.Sleep(3 * 1000);
            Debug.WriteLine("Main thread AsyncWait End.");
        }
        [Test]
        public void AsyncWaitMethodTest2()
        {
            Debug.WriteLine("Main thread AsyncWait Start.");

            
            for (int i = 0; i < 3; i++)
            {
                methodTow();
            }

            System.Threading.Thread.Sleep(3 * 1000);
            Debug.WriteLine("Main thread AsyncWait End.");
        }
        private async static void methodTow()
        {
            Debug.WriteLine("New thread start.");
            await Task.Run(new Action(LongTaskTow));
            Debug.WriteLine("New thread end.");
        }
        private static void LongTaskTow()
        {
            var guid = Guid.NewGuid().ToString();
            Debug.WriteLine(string.Format( "LongTaskTow start {0}.",guid));
            System.Threading.Thread.Sleep(1 * 1000);
            Debug.WriteLine(string.Format("LongTaskTow END {0}.", guid));
        }

    }
}
