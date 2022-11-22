using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace _22_11_tasks
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("//////Task1");
            int[] ARR = { 1, 7, 9, 45, };

            string[] arr2 = { "str", "alex", "moh" };
            string[] arr3 = { "str", "fox", "over", "Lazy", "dog" };





            Console.WriteLine("/////////Task2");
            string[] fruits = { "Tomato", "Banana", "Watermelon" };

            for(int i=0; i<fruits.Length; i++)
            {
                if (fruits[i]== "Tomato")
                {
                    Console.WriteLine(i);
                }
                if (fruits[i] == "Banana")
                {
                    Console.WriteLine(i);
                }
            }


            Console.WriteLine("////////////Task3");
            string[] food = { "mansaf", "makora", "pasta", "pizza", "banana" };
            foreach(string i in food) {

                Console.WriteLine(i);
               
            }





            Console.WriteLine("\n");
            for (int i=0;i<food.Length;i++) {

                Console.WriteLine(food[i]);
            }
            Console.WriteLine("\n");





            string[] sport = { "footaball", "tennis", "golf" };

            foreach (string i in sport)
            {
                Console.WriteLine(i);
            }
            Console.WriteLine("\n");
            for (int i = 0; i < sport.Length; i++)
            {

                Console.WriteLine(sport[i]);
            }

            //Console.WriteLine("\n");
            //string[] movie = { "mbc1", "mbc2", "mbc3", "mbc4" };
            //foreach (string i in movie) { 
            //Console.WriteLine(i);
            //}

            //Console.WriteLine("\n");
            //for (int i = 0; i <= movie.Length; i++)
            //{

            //    Console.WriteLine(movie[i]);
            //}



            Console.WriteLine("\n");

            Console.WriteLine("//////Task4");

            Console.WriteLine("enter 3 inputs");
            string str=Console.ReadLine();
            //  string s1 = "";
            //  string s2 = "";
            //  string s3 = "";
            // for(int i=0;i<str.Length;i++)
            //  {
            //      s1=str.Substring(0,1);
            //      s2=str.Substring(2,1);
            //      s3=str.Substring(4,1);

            //  }
            //int n1=Convert.ToInt32(s1);
            //  int n2 = Convert.ToInt32(s2);
            //  int n3 = Convert.ToInt32(s3);
            //  Console.WriteLine(n1+n2+n3);

            string[] s = str.Split(',');
            int sum1 = 0;
            foreach (string s2 in s) {
                sum1=sum1+ Convert.ToInt32( s2);
            }
            Console.WriteLine(sum1);

            Console.WriteLine("\n");
            Console.WriteLine("///////task5");
            int sum = 0;
            for(int i=1;i<100;i+=2)
            {
                sum += i; 
            }
            Console.WriteLine(sum);

            Console.WriteLine("\n");
            Console.WriteLine("///////task6");

            for(int i=0;i<=5;i++) { 
            for(int j=0;j<=i;j++)
                {
                    Console.Write("*");
                }
                Console.WriteLine(" ");
            }

            Console.WriteLine("\n");
            Console.WriteLine("///////task7");
            int ii = 1;
            for (int i = 0; i <= 5; i++)
            {
                for (int j = 0; j <= i; j++)
                {
                    Console.Write(ii);
                    ii++;
                }
                Console.WriteLine(" ");
            }


            Console.WriteLine("////////////////task8");
            int[] array =new int[] {1,2,3,4,5,3,2,1 };
            int[] distinct = array.Distinct().ToArray();
            int s4 = 0;
            //Console.WriteLine(String.Join(",", distinct));
            for(int i=0;i<distinct.Length;i++)
            {
                s4+= array[i];
            
            }
           
            Console.WriteLine(s4);
            Console.WriteLine(array.Length);
            Console.WriteLine( s4/distinct.Length);
        }
    }
}
