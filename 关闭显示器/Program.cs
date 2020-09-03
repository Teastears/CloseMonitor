using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace 关闭显示器
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Monitor is being shut off");
            Thread.Sleep(1000);
            CloseMonitor.Monitor.TurnOff();
        }
    }
}
