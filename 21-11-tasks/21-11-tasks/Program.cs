using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _21_11_tasks
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("task1");
            Console.WriteLine("enter the first num");
            int x = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("enter the second num");
            int y = Convert.ToInt32(Console.ReadLine());
            if (x <= y) { Console.WriteLine(x); }
            else { Console.WriteLine(y); }

            Console.WriteLine("///////");
            Console.WriteLine("task2");
            Console.WriteLine("please enter sign num");
            int sign_num = Convert.ToInt32(Console.ReadLine());
            if (sign_num >= 0)
            { Console.WriteLine("+"); }
            else
            {
                Console.WriteLine("-");
            }

            Console.WriteLine("///////////");

            Console.WriteLine("task3");


            Console.WriteLine("enter first num");
            int num1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("enter second num");
            int num2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("enter third num");
            int num3 = Convert.ToInt32(Console.ReadLine());

            int[] array;
            array = new int[] { num1, num2, num3 };

            Array.Sort(array);
            Console.WriteLine(array[2]);
            Console.WriteLine(array[1]);
            Console.WriteLine(array[0]);

            Console.WriteLine("///////////");

            Console.WriteLine("task4");

            Console.WriteLine("enter first");
            int n1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("enter second ");
            int n2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("enter third ");
            int n3 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("enter four ");
            int n4 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("enter five");
            int n5 = Convert.ToInt32(Console.ReadLine());


            int[] array1;
            array1 = new int[] { n1, n2, n3, n4, n5 };
            Array.Sort(array1);

            Console.WriteLine(array1[4]);

            Console.WriteLine("///////////");

            Console.WriteLine("task5");
            Console.WriteLine("input hours");
            double hour = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine(hour * 0.621371);



            Console.WriteLine("///////////");

            Console.WriteLine("task6");
            Console.WriteLine("input hours:");
            int hour_num = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("input minutes");
            int minute = Convert.ToInt32(Console.ReadLine());
            Console.Write(((hour_num * 60) + minute));

            Console.WriteLine("///////////");

            Console.WriteLine("task7");
            Console.WriteLine("input minutes:");
            int total_min = Convert.ToInt32(Console.ReadLine());
            int h = (total_min / 60);
            int m = (total_min % 60);
            Console.WriteLine("hours" + h + "    mintues" + m);


            Console.WriteLine("///////////");

            Console.WriteLine("task8");
            string[] arr1 = { "batool", "ayah", "rama", "ali" };
            int l1 = arr1[0].Length;
            int l2= arr1[1].Length;
            int l3 = arr1[2].Length;
            int l4 = arr1[3].Length;
            int[] arr5 = { l1, l2, l3, l4 };
            Array.Sort(arr5);
           int min = arr5[0];
            Console.WriteLine(min);

            Console.WriteLine(arr1[0].Substring(0, min));
            Console.WriteLine(arr1[1].Substring(0, min));
            Console.WriteLine(arr1[2].Substring(0, min));
            Console.WriteLine(arr1[3].Substring(0, min));













        }
    }
}
