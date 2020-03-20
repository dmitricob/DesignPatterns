using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Singletone
{
    class Program
    {
        static void Main(string[] args)
        {
            Computer comp = new Computer();
            comp.Launch("win 8.1");
            comp.Run();

            comp.OS = OS.getInstance("Win 10");
            comp.Run();

        }
    }

    class Computer
    {
        public OS OS { get; set; }
        public void Launch(string osName)
        {
            OS = OS.getInstance(osName);
        }
        public void Run()
        {
            Console.WriteLine(OS.Name);
        }
    }

    class OS
    {
        private static OS instance;
        public string Name { get; private set; }
        private static object syncRoot = new Object();

        protected OS(string name)
        {
            Name = name;
        }

        public static OS getInstance(string osName)
        {
            if (instance == null)
            {
                lock (syncRoot)
                {
                    if (instance == null)
                        instance = new OS(osName);
                }
            }
            return instance;
        }
    }
}
