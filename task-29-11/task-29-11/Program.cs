using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task_29_11
{

    class Employee
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Birh_date { get; set; }

   public     Employee(int a, string b, string c) {
            Id = a;
            Name = b;
            Birh_date = c; }

        public void Calc ()
            {
            //Console.WriteLine();
            var birthday = new DateTime(1999, 1, 7);
            int age = (int)((DateTime.Now - birthday).TotalDays / 365.242199);
            Console.WriteLine(age);
        }

        public void Calc(int a, int b, int c)
        {
            //Console.WriteLine();
            var birthday = new DateTime(a, b, c);
            int age = (int)((DateTime.Now - birthday).TotalDays / 365.242199);
            Console.WriteLine(age);
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
            Console.WriteLine("the Id of Manger");
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Employee e = new Employee(1, "batool", "7-1-1999");
            e.Calc();
            Manger manger = new Manger(1,"batool","1999");
            Console.WriteLine( "the ID of employee"+manger.Id);
            Console.WriteLine("the name of employee" + manger.Name);
            Console.WriteLine("the age of employee");
            manger.Calc();
            manger.Calc(2000, 1, 7);
            manger.print();

        }
    }
}
