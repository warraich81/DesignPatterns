using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Singleton
{
    class Program
    {
        static void Main(string[] args)
        {
            Parallel.Invoke(
                ()=> printEmp() ,
                ()=> printStudent()
                );
          
            Console.ReadLine();
        }

        private static void printStudent()
        {
            Singleton s3 = Singleton.GetInstance;
            s3.printMsg("Welcome to DP");
        }

        private static void printEmp()
        {
            Singleton s = Singleton.GetInstance;
            s.printMsg("Hello World");
        }
    }
}
