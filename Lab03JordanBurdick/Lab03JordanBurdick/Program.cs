using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab03JordanBurdick
{
    class Program
    {
        static void Main(string[] args)
        {
        Start:
            Console.Clear();

            //first input
            int userInput1;
            Console.WriteLine("Please enter a value.");
            userInput1 = int.Parse(Console.ReadLine());

            //second input
            int userInput2;
            Console.WriteLine("Please enter another value.");
            userInput2 = int.Parse(Console.ReadLine());

            //output
            string UserInput;
            Console.WriteLine("The sum of the two values is {0}", userInput1 + userInput2);
            Console.WriteLine("Press any key to continue to part 2, or type 'restart' to start over");
            UserInput = Console.ReadLine();
            if (UserInput == "restart")
            {
                goto Start;
            }
            Console.ReadKey(true);
            
            //part 2
            int x = 2;
            int y = 5;
            int z = -1;

            Console.WriteLine("To find the solution to this problem '(x + y) * (z + 10)' simply add the values");
            Console.WriteLine("X = {0}, y = {1}, z = {2} ",x,y,z);
            Console.WriteLine("Just like this, ({0} + {1}) * ({2} + 10)",x,y,z);
            Console.WriteLine("The answer is {0}", (x + y) * (z + 10));
            Console.ReadKey(true);

            //part 3
            Console.WriteLine("Hello\tWorld!");
            Console.WriteLine("Hello\nWorld");
            Console.WriteLine("Hello\\World");
            Console.WriteLine("\"Hello World\"");


            //pls
        }
    }
}
