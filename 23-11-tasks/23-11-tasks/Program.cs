using Microsoft.Win32;
using System;
using System.CodeDom;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace _23_11_tasks
{
    internal class Program
    {
        
        static void sum()
        {
            int sum = 0;
            
            for(int i=0;i<10;i++)
            {
                Console.WriteLine("please enter " +i+" number ");
                int x=Convert.ToInt32(Console.ReadLine());
                sum = sum + x;
            }
            Console.Write("sum of 10 numbers are :  ");
            Console.WriteLine(sum);
            Console.Write("avarge  of 10 numbers are :  ");
            Console.WriteLine (sum/10);
        }



        static void cube()

        {
            for (int i=1;i <=5;i++)
            {
                Console.Write("the number is :"+ i);
                Console.WriteLine("and cube of the 1 is " + (i*i*i));
            }
        }



        static void getYears(int[] years)
        {
           
            for(int i=0;i<years.Length;i++)
            {
                if (years[i]>1950)
                {
                    
                    Console.WriteLine(years[i]);
                }

               
            }
            
        }


        static int  Age(int year )
        {
            Console.Write("the age in days is :");
            return (year * 365);
        }



        static int animals( int x,int  y,int z)
        {
            return ((x * 2) + (y * 4) + (z * 4));
        }



        static void login(string user ,string pass)
        {

            string[] users = {"batool", "ayah", "hala", "lujain" };
     
            string[] passwords = {"123","123","123","1234" };
            //Console.WriteLine("please enter login user");
            //string user = Console.ReadLine();
            bool flag = false;
             for(int i=0;i<users.Length;i++)
            {
                if ((user == users[i]) && (pass== passwords[i]))
                {
                    flag= true;
                    break;
                }

                
            }
            if (flag)
            {
                Console.WriteLine("pass");
            }
            else
            {
                Console.WriteLine("fail");
            }

        }



        static void Power(int basse ,int exp)

        {
            int result = 1;
            while(exp!=0)
            {
                result=result*basse;
                exp--;
            }
            Console.WriteLine("Answer = "+ result);
        }


        //int[] leap= { 1900 - 2024 }

        static void leapyears()
        {
            for(int i=1900;i<=2024;i+=4)
            {
                //Console.WriteLine("batool");
               

               
                     Console.WriteLine(i); 
                
            }
        }


        static bool check_prime(int n)
        {
            bool is_prime = true;

            // 0 and 1 are not prime numbers
            //if (n == 0 || n == 1)
            //{
            //    is_prime = false;
            //}

            for (int i = 2; i <= n/2; i++)
            {
                if (n % i == 0)
                {
                    is_prime = false;
                    break;
                }
            }

            return is_prime;
        }



        static void splitsenternce( string sentence)
        {
            string[] nnewsentence = sentence.Split(' ');
            Console.WriteLine(nnewsentence.Length);
        }
        static void Main(string[] args)
            {

            Console.WriteLine("/////  TASK1   //////");
            sum();

            Console.WriteLine("/////  TASK2   //////");
            cube();
            Console.WriteLine("/////  TASK3   //////");

            int[] years = { 1763, 1972, 1925, 1916, 1984, 1124, 1950, 2020 };

            getYears(years);


            Console.WriteLine("/////  TASK4   //////");

            Console.WriteLine("please enter your age in year");
            int year = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine(Age(year));

            Console.WriteLine("/////  TASK5   //////");



            int x = Convert.ToInt32(Console.ReadLine());
            int y = Convert.ToInt32(Console.ReadLine());
            int z = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(animals(x, y, z));



            Console.WriteLine("/////  TASK6   //////");

            // string[] users = { "batool", "ayah", "hala", "lujain", "rama", "haya" };

            Console.WriteLine("enter your name");
            string str = Console.ReadLine();
            Console.WriteLine("enter your pass");
            string pass = Console.ReadLine();
            login(str, pass);

            Console.WriteLine("/////  TASK7   //////");

            Console.WriteLine("enter base ");
            int q = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("enter exp");
            int q1 = Convert.ToInt32(Console.ReadLine());
            Power(q, q1);


            Console.WriteLine("/////  TASK8   //////");
            leapyears();


            Console.WriteLine("/////  TASK9  //////");


            Console.WriteLine("please enter prime number");
            int y1=Convert.ToInt32(Console.ReadLine());
            if (check_prime(y1))
                Console.WriteLine( y1+ " is a prime number."); 
            else
                Console.WriteLine(y1 + " is not a prime number.");



            string sentence = Console.ReadLine();
            splitsenternce(sentence);
           
            
        }
    }
}
