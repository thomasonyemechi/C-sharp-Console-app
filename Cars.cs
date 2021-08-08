using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Car
    {

        //class field

        public string model;
        public string color;
        public int year;


        //defining properties
        public string myModel
        {
            get; set;
        }



        // using constructors with multiple parameters
        public Car(string modelName, string colorName, int yearName)
        {
            model = modelName;
            color = colorName;
            year = yearName;
        }



        

        //class method
        public string Total()
        {
            return "The model of my car is " + model +" the color is " + color ; 
        }



        

    }





    class Vehicle  // base class (parent) 
    {
        public string brand = "Ford";  // Vehicle field
        public void honk()             // Vehicle method 
        {
            Console.WriteLine("Tuut, tuut!");
        }
    }

    class Cars : Vehicle  // derived class (child)
    {
        public string modelName = "Mustang";  // Car field
    }






}







