using Orleans.Runtime.Configuration;
using Orleans.Runtime.Host;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Orleans.UniteExtension.Framework.SiloService
{
    class Program
    {
        static void Main(string[] args)
        {
            var m_SiloConfigFile = new FileInfo(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, $"{Path.GetFileNameWithoutExtension("OrleansConfiguration")}.xml"));

            using (var m_Host = new SiloHost("GrLionSilo", m_SiloConfigFile))
            {
                m_Host.Config.Globals.ReminderServiceType = GlobalConfiguration.ReminderServiceProviderType.ReminderTableGrain;
                m_Host.LoadOrleansConfig();
                m_Host.InitializeOrleansSilo();

                m_Host.StartOrleansSilo();

                ConsoleKeyInfo m_ConsoleKeyInfo = new ConsoleKeyInfo();

                while (m_ConsoleKeyInfo.Key != ConsoleKey.Escape)
                {
                    Console.WriteLine("OrleansSilo已启动,按下'Esc'键结束服务.");
                    m_ConsoleKeyInfo = Console.ReadKey();
                    Console.WriteLine($"{ m_ConsoleKeyInfo.Key}");
                }

                Console.WriteLine("正在结束OrleansSilo服务 . . .");

                m_Host.StopOrleansSilo();
            }
        }
    }
}
