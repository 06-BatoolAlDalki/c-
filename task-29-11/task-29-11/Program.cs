using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace task_29_11
{

    class Employee
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Birh_date { get; set; }

        public void printt()
        {
            Console.WriteLine(Id+ " "+Name+" "+Birh_date);
        }
   public     Employee(int a, string b, string c) {
            Id = a;
            Name = b;
            Birh_date = c; }

        public void Calc ()
            {
            //Console.WriteLine();
            //var birthday = new DateTime(1999, 1, 7);
            //int age = (int)((DateTime.Now - birthday).TotalDays / 365.242199);
            //Console.WriteLine(age);
            DateTime dob = Convert.ToDateTime(Birh_date);
            DateTime PresentYear = DateTime.Now;
            TimeSpan ts = PresentYear - dob;
            DateTime Age = DateTime.MinValue.AddDays(ts.Days);
            Console.WriteLine(string.Format(" {0} Years {1} Month {2} Days", Age.Year - 1, Age.Month - 1, Age.Day - 1));
        }

        public void Calc(string s)
        {
            Birh_date = s;
            DateTime dob = Convert.ToDateTime(Birh_date);
            DateTime PresentYear = DateTime.Now;
            TimeSpan ts = PresentYear - dob;
            DateTime Age = DateTime.MinValue.AddDays(ts.Days);
            Console.WriteLine(string.Format(" {0} Years {1} Month {2} Days", Age.Year - 1, Age.Month - 1, Age.Day - 1));
        }
        public virtual void print() {
            Console.WriteLine("the Id of Employee" );
        }


    }
    class Manger : Employee
    {
        public Manger(int a , string b , string c) : base(a, b, c)
        {

        }


        public override void print()
        {
            Console.WriteLine("Hello Manger");
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
           // Employee e1 = new Manger(1,"batool", "18 Feb 1987");
           Employee e = new Manger(1, "batool", "18 Feb 1987");
           
            
            Manger manger = new Manger(1,"batool","1999");
            Console.WriteLine( "the ID of employee "+e.Id);
            Console.WriteLine("the name of employee " + e.Name);
           
            Console.WriteLine("the age of employee ");
            //manger.Calc();
            e.Calc();
            e.Calc("7 Feb 1999");
            e.print();
            e.printt();
           // manger.printt();
        }
    }
}
