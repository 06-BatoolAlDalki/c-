using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _27_11_tasks
{

     class Person
    {


        private double age;
        private string gender;
        private string name;
        private string email;
        private int id;
        private string phone;

        public void  check_age(int age)
        {
            if (age >= 18 && age <= 60)
            {
                Console.WriteLine("welcome in our website");
            }
            else {Console.WriteLine("no this website isnt suit for you");
            }
        }

        public void check_gender(string gender)
        {
            if (gender == "female")
            {
                Console.WriteLine("female");

            }else
            {
                Console.WriteLine("male");
            }


        }

        
        public void check_name(string n) {
            name = n;
            Console.WriteLine(name);
        }


        public void check_email(string e)
        {

            email = e; Console.WriteLine(email);
        }

        public void check_phone(string p)
        {

           phone= p;

            //Console.WriteLine(phone.Length);

            string s = phone.Substring(0, 3);
            Console.WriteLine(s);
            if(s=="078" || s == "079" || s == "077")
                {
                Console.WriteLine(phone);
            }
            else { Console.WriteLine("please enter valid phone number"); }
        }


        public void print_id( int i)
        {
id= i;
            Console.WriteLine(id);
        }


        static void Main(string[] args)
        {
            Person batool = new Person();

            Console.WriteLine("//////check your age/////////");
            int age=Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("please enter your age");
            batool.check_age(age);





            Console.WriteLine("//////check your gender/////////");
          
            Console.WriteLine("please enter your gender");
            string gender = Console.ReadLine();
            batool.check_gender(gender);


            Console.WriteLine("//////print Name/////////");

            Console.WriteLine("please enter your NAME");
            string your_name = Console.ReadLine();
            batool.check_name(your_name);



            Console.WriteLine("//////print Email/////////");

            Console.WriteLine("please enter your EMAIL");
            string your_email = Console.ReadLine();
            batool.check_name(your_email);



            Console.WriteLine("//////print phone/////////");

            Console.WriteLine("please enter your PHONE");
            string phone = Console.ReadLine();
            batool.check_phone(phone);




            Console.WriteLine("//////print ID/////////");

            Console.WriteLine("please enter your ID");
            int id =Convert.ToInt32( Console.ReadLine());
            batool.print_id(id);
        }
    }
}
