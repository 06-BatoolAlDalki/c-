using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//enum


public enum Season
{
    Spring,
    Summer,
    Autumn,
    Winter
}


// defining struct
struct Employee
{
    public int id;

    public void getId(int id)
    {
        Console.WriteLine("Employee Id: " + id);
    }
}


//class
//class Car
//{
//   public string color = "red";
//}
namespace _21_11
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //data types
            int x = 10;
            double y = 20.12;
            string name = "ayah";
            bool z = true;
            char q = 'c';
            Console.WriteLine(x);
            Console.WriteLine(y);
            Console.WriteLine(name);
            Console.WriteLine(z);
            Console.WriteLine(q);

            //nullable data type
            Nullable<int> i = null;

            if (i.HasValue)
                Console.WriteLine(i.Value); // or Console.WriteLine(i)
            else
                Console.WriteLine("Null");

            //emnum
           

            var b = (Season)1;
            Console.WriteLine(b);  // output: Summer

            var c = (Season)4;
            Console.WriteLine(c);  // output: 4

            //struct data type


            // declare emp of struct Employee
            Employee emp;

            // accesses and sets struct field
            emp.id = 100;

            // accesses struct methods
            emp.getId(emp.id);

            Console.ReadLine();


            //////////class
            // Car myObj = new Car();
            //Console.WriteLine(myObj.color);


            //object 
            String[] test = { "1", "2" };
            object o = test;

            if (o is string[])
            {
                Console.WriteLine("this is string array");
            }





            ///ahmad
            int myint = 10;
            double mydu = myint;
            Console.WriteLine(mydu);
            Console.ReadLine();

            double myv = 10.8;
            int hell = (int)myint;
            Console.WriteLine(hell);




            //rahma
            Console.WriteLine("**");

            Console.WriteLine("Enter your age:");
            int age = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Your age : " + age);


            Console.WriteLine("***");
            Console.WriteLine("enter your grade");
            double grade = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("your grade : " + grade);
            Console.WriteLine("***");
            //mayyas


            int number = 10;
            double doubleNumber = 5.25;
            bool myBool = true;
            string mayyas = "mayyas";

            Console.WriteLine(Convert.ToString(number));    // Convert int to string
            Console.WriteLine(Convert.ToDouble(number));    // Convert int to double
            Console.WriteLine(Convert.ToInt32(doubleNumber));  // Convert double to int
            Console.WriteLine(Convert.ToString(myBool));   // Convert bool to string
            Console.WriteLine(Convert.ToInt64(doubleNumber));   // Convert bool to string
            Console.WriteLine(Convert.ToBoolean(doubleNumber));   // Convert double to bool
            Console.WriteLine(Convert.ToChar(mayyas[2]));   // Convert string to cha
        }

       

    }
    }

