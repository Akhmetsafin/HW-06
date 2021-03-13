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
            var i = 100;
            Console.WriteLine("Введиде способ завершения процесса: 1- по ID, 2 - по имени");
            //int varKill = Convert.ToInt32(Console.ReadLine());


            {
                string s = Console.ReadLine();

                while (i > 0)
                {
                    if (string.IsNullOrEmpty(s))
                        break;
                    if (s == "1")
                    {
                        try
                        {
                            Console.WriteLine("Введиде ID:"); 
                           Process.GetProcessById(Int32.Parse(Console.ReadLine())).Kill();
                            Process.GetProcessById(Int32.Parse(Console.ReadLine())).WaitForExit();
                        }
                        catch (Exception e)//2222222222
                        {
                            Console.WriteLine("no correct.");
                            continue;
                        }

                    }
                    if (s == "2")
                    {
                        try
                        {
                            Console.WriteLine("Введиде имя процесса:");
                            Process.GetProcessesByName(Console.ReadLine())[0].Kill();
                            Process.GetProcessesByName(Console.ReadLine())[0].WaitForExit();
                        }
                        catch (Exception e)
                        {
                            Console.WriteLine("no correct.");
                            continue;
                        }
                    }
                    
                }
            }

        }
    }
}
