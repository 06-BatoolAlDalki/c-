﻿using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace _28_11_tasks_inheritence
{


    class car
    {
       
       
        private string cars_make ;

        public string Cars_make
        {
            get; set;
        }
        private int year;

        public int Year
        {
            get;set;
        }
        private string Type;

        public string type
        {
            set { Type = value; }
            get { return Type; }
        }


        private double price;
        public double Price
        {
            get { return price; }
            set { price = value; }
        }
        private string model;
        public string Model
        {
            set { model = value; }
            get { return model; }
        }
        private int Pallet_NO;

        public int pallet_NO
        {
            get { return Pallet_NO; }
            set { Pallet_NO = value; }
        }
        private string color;


        public string Color
        {
            set { color = value; }
            get { return color; }
        }

       



       

        public void start()
        {
            Console.WriteLine("Lets GO , Only enjoy");
        }


        public void stop()
        {
            Console.WriteLine("Good Bye , Only enjoy");
        }
    }

    class Test_car : car
    {

        public Test_car(string a, int y, string t, double p, string m, int num, string c)
        {
            Cars_make = a;
            Year = y;
            type = t;
            Price = p;
            Model = m;
            pallet_NO = num;
            Color = c;
        }

    }
    internal class Program
    {
        static void Main(string[] args)
        {

            //car obj1= new car();
            Test_car obj1 = new Test_car ("batool", 2022,"2022",20220,"2022",5066,"red");
            //  obj1.Cars_make = "batool";


            //Cars_make = a;
            //Year = y;
            //type = t;
            //Price = p;
            //Model = m;
            //pallet_NO = num;
            //Color = c;
            Console.WriteLine(obj1.Cars_make +" "+ obj1.Year+" "+obj1.type +" "+ obj1.Price+" "+obj1.Model+" "+obj1.pallet_NO
                +" "+obj1.Color);
            obj1.start();
            obj1.stop();
        }
    }
}
