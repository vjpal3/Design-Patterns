using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SingletonPattern
{
    /* Creational type pattern
       Concurrent access to the resource is well managed by singleton design pattern. */
    public sealed class Singleton
    {
        private static int count;

        /*As part of the Implementation guidelines we need to ensure that only one instance of the class exists by declaring all
          constructors of the class to be private.  Also, to control the singleton access we need to provide a static property that 
          returns a single instance of the object. 
          That single instance created is responsible to coordinate actions across the application. */

        private static Singleton instance = null;

        public static Singleton GetInstance 
        { 
            get 
            { 
                if(instance == null)
                    instance = new Singleton();

                return instance;
            } 
        }
        private Singleton()
        {
            count++;
        }
        public void PrintDetails(string msg)
        {
            Console.WriteLine($"Message: { msg } Count: {count}");
        }
    }
}
