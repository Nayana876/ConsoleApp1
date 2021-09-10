using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class User
    {
        public string name;
    }
    class Class2
    {
        public void createPattern()
        {
            byte b1 = 100;
            sbyte b2= -45;
            Object obj = new Object();
            User user1 = new User();
            obj = user1;
            dynamic data = 10;
            Console.WriteLine(data is int);
            data = "loop";
            Console.WriteLine(typeof(User));
            //Console.ReadLine();

;
        }
        public int age { get; } = 10;

        private int privateProp = 90;
        public int publicName
        {
            get { return privateProp; }
            set { 
                if (value != 90)
                    Console.WriteLine("Wrong value");
                else
                    privateProp = value;
                 }
            
        }
    }
}
