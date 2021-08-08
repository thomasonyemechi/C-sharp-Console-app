using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {



        //c sharp functions
        // functions are written outside the main fucntion and are executed inside the main function
        // void is used when tere is no return value
        static void MyMethod(string name= "Gideon", int age = 18)
        {
            Console.WriteLine("My name is "+ name.ToUpper() + " my age is " + age);
        }

        static int Multply(int x, int y)
        {
            return x * y;
        }

        //named functions declearation
        static void NameArgument(string val1, string val2, string val3)
        {
            Console.WriteLine("val3 = " + val1);

        }


        //function overloading 
        static int PlusMethod(int x, int y)
        {
            return x + y;
        }

        static double PlusMethod(double x, double y)
        {
            return x + y;
        }

        static void Main(string[] args)
        {

            // Create a myCar object
            Cars myCar = new Cars();

            // Call the honk() method (From the Vehicle class) on the myCar object
            myCar.honk();

            // Display the value of the brand field (from the Vehicle class) and the value of the modelName from the Car class
            Console.WriteLine(myCar.brand + " " + myCar.modelName);





            Car Ford = new Car("Mustang_FORD", "Red", 1969);
            Console.WriteLine(Ford.color + " " + Ford.year + " " + Ford.model);

            Console.WriteLine(Ford.Total());

            //function overloading 

            Console.WriteLine("Int: " + PlusMethod(8, 5));
            Console.WriteLine("Int: " + PlusMethod(4.3, 6.26));

            //name function references
            NameArgument(val3: "o strong", val2: "value two", val1: "Lefendary");

            Console.WriteLine(Multply(12, 5));
            MyMethod("boluwa tife", 20);

            //user input 
            //asking the question
            //Console.WriteLine("What the heck is your name");
            //collecting user input
            //string name = Console.ReadLine();
            //returning the result to the view
            //Console.WriteLine("you heck name is" + name);


            //control statement


            int ctime = 14;

            if(ctime > -1 && ctime < 12)
            {
                Console.WriteLine("Good Morning " + ctime + " am");
            }else if(ctime > 11 && ctime < 17)
            {
                Console.WriteLine("good afternoon " + (ctime - 12) + " pm");
            }
            else
            {
                Console.WriteLine("good evening " + (ctime - 12) + " pm");
            }

            //csharp loops
            for (int i = 0; i <= 20; i++)
            {
                //if(i == 2) { i = 10; continue; }
                //Console.WriteLine(i + " multiply by 2 is = " + i * 2);
            }

            string[] cars = { "camry", "corolla", "TUNDRA", "bmw", "benz", "mazda", "toyota", "Arana" };

            foreach (string ic in cars)
            {
                //Console.WriteLine(ic.ToLower());
            }
            Array.Sort(cars);
            for (int i = 0; i < cars.Length; i++)
            {
                //Console.WriteLine("car " + (i+1) + " is " + cars[i]);
            }


            int[] numArray = { 23, 4, 32, 45, 4, 677, 566, 646, 8, 875, 85, 234, 1 };

            //for (int i = 0; i < numArray.Length; i++)
            Console.WriteLine(numArray.Sum());

            string name = Console.ReadLine();

        }
    }
}
