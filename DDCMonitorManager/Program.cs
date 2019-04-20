using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace DDCMonitorManager
{
    public static class Program
    {
        [STAThread]
        public static int Main(string[] args)
        {
            if (!args.Any())
            {
                new Application().Run(new MainWindow());
            }

            if (args[0] == "list")
            {
                var monitors = NativeCalls.EnumDisplayMonitors();
                foreach (var monitor in monitors)
                {
                    Console.WriteLine($"{monitor.DeviceName}: {monitor.Monitor.Width}x{monitor.Monitor.Height}");
                }
                Console.ReadKey();
            }


            return 0;
        }
    }
}
