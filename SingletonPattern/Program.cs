using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SingletonPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            //Createa multi-threaded environment
            Parallel.Invoke(
                () => DisplayEmployee(),
                () => DisplayStudent()
            );

            Console.ReadLine();

        }

        private static void DisplayStudent()
        {
            Singleton student = Singleton.GetInstance;
            student.PrintDetails("From Student");
        }

        private static void DisplayEmployee()
        {
            Singleton employee = Singleton.GetInstance;
            employee.PrintDetails("From Employee");
        }
    }
}
