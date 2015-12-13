using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace DefaultDomainTests
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            Console.WriteLine(ConfigurationManager.AppSettings["One"]);

            Console.WriteLine(AppDomain.CurrentDomain.BaseDirectory);

            var type = Type.GetType("TotallyDifferentProject.Class1, TotallyDifferentProject");

            var instance = Activator.CreateInstance(type);

            Console.WriteLine(instance.ToString());

            Console.ReadLine();
        }
    }
}
