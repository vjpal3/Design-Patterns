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
            Singleton employee = Singleton.GetInstance;
            var msg = "From Employee";
            employee.PrintDetails(msg);
            
            Singleton student = Singleton.GetInstance;
            msg = "From Student";
            student.PrintDetails(msg);

        }
    }
}
