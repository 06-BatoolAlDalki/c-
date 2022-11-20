using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.ExceptionServices;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace _20_11
{
    internal class Program
    {
        static void Main(string[] args)
        {


           // question 1
            Console.WriteLine("please enter your favourite string");
            string str=Console.ReadLine();
            Console.WriteLine(str);
            
            //question 2
            double num = 12000;
            string car = "mercides";
            char c='A';
            bool batool = true;
            int num1 = 12;
            const int num2 = 13;

            Console.WriteLine(num);
            Console.WriteLine(car);
            Console.WriteLine(c);
            Console.WriteLine(batool);
            Console.WriteLine(num1);
            Console.WriteLine(num2);
            // Console.WriteLine(" ",car," ",c," ",batool," ",num1," ",num);

            //question3
            string[] cars = { "mercides", "lonovo", "kashef" };

            Console.WriteLine(cars[0]);
            Console.WriteLine(cars[1]);
            Console.WriteLine(cars[2]);
            Console.WriteLine(cars.Length);

            //question 4
            Console.WriteLine("your first name");
            string first = Console.ReadLine();
            Console.WriteLine("your last name");
            string Lfirst = Console.ReadLine();
            Console.WriteLine("your input your year of birth :");
            string birth = Console.ReadLine();
            Console.WriteLine(first + " " + Lfirst + " " + birth);
            //question 5

            int[] array_sort = { 2, 1, 4, 6, 5, 8 };
           Array.Sort(array_sort);

            Console.WriteLine( array_sort[0] );
            Console.WriteLine(array_sort[1]);
            Console.WriteLine(array_sort[2]);
            Console.WriteLine(array_sort[3]);
            Console.WriteLine(array_sort[4]);
            Console.WriteLine(array_sort[5]);
            //question 5

            int[] sum = { 12, 10, 20 };
            Console.WriteLine("Sum of all elements stored in the array is : ");
           Console.WriteLine(sum[0] + sum[1] + sum[2]);



        }
    }
}
