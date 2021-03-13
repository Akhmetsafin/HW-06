using System;
using System.Threading;
using System.Security.Permissions;
using System.Security.Principal;
using System.Diagnostics;

namespace Process1
{
    class Program
    {

        public static void Main(string[] args)
        {

            System.Diagnostics.Process[] cP = System.Diagnostics.Process.GetProcesses();
            foreach (System.Diagnostics.Process procesS in cP)
            {
                var letgh_ID = Convert.ToString(procesS.Id);
                Console.WriteLine($"ID: {procesS.Id}{new string(' ', 10 - letgh_ID.Length)} Name: {procesS.ProcessName}");
            }

            Console.WriteLine("Введиде способ завершения процесса: 1- по ID, 2 - по имени");
            //int varKill = Convert.ToInt32(Console.ReadLine());



            
            var s = Console.ReadLine();
            if (s == "1")
            {
                Console.WriteLine("Введиде ID");
                using Process Pid = Process.GetProcessById(Int32.Parse(Console.ReadLine()));
                Pid.Kill();
                //.WaitForExit();
                Console.WriteLine($"killed {Pid}");

            }
            if (s == "2")
            {
                Console.WriteLine("Введиде имя процесса");
                Process.GetProcessesByName(Console.ReadLine())[0].Kill();
                //Process.GetProcessesByName(Console.ReadLine())[0].WaitForExit();
                Console.WriteLine($"killed ");

            }
            if ((s != "2") && (s != "1"))
            {
                Console.WriteLine($" No killed ");
            }

            Console.ReadKey();

        }
    }
}          /
