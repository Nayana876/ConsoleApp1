using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
	class Program
	{
	
		public static void Main()
		{
			Class1 c1 = new Class1();
			c1.createPattern(8);
			c1.age1 = 20;
			Console.WriteLine(c1.ageGetSet);
			c1.ageGetSet = 2;
			Console.WriteLine(c1.age1);
			Console.WriteLine(c1.ageGetSet);

			Class2 user1 = new Class2();
			user1.createPattern();
			Console.WriteLine(user1 is Class2);
			//Var type
			var name = "Welcome";
			var a = 34;
			Console.WriteLine("name = {0} a = {1}", name, a);

			takeInputFromConsole();

			
			//ArrayDemo();
			//Class1 c2 = new Class1();

			const int month = 12;

			Console.ReadLine();
		}

        private static void takeInputFromConsole()
        {
			int y;
			y = Convert.ToInt32(Console.ReadLine());
			Console.WriteLine(y);
			Console.Read();
        }

        private static void ArrayDemo()
        {
			int[] array = { 1, 2, 4, 6, 8, 9, 11, 14, 15 };
			var a = from i in array where i % 2 == 0 select i;
			foreach (var _a in a)
			{
				Console.WriteLine("{0}\n", _a);
			}
		}
    }
}