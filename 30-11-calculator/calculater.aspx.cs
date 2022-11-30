using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ClassLibrary2;
namespace calculater30_11
{
    public partial class calculater : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            Class1 math = new Class1();

            // Declare variables and use methods from MathLibrary
            float add = math.Addition(Convert.ToInt32( TextBox1.Text), Convert.ToInt32(TextBox2.Text));
            Console.WriteLine(add);
            TextBox3.Text =Convert.ToString( add);
            
        }


        protected void Button2_Click(object sender, EventArgs e)
        {
            Class1 math = new Class1();

            // Declare variables and use methods from MathLibrary
            float substract = math.Substract(Convert.ToInt32(TextBox1.Text), Convert.ToInt32(TextBox2.Text));
            Console.WriteLine(substract);
            TextBox3.Text = Convert.ToString(substract);

        }


        protected void Button3_Click(object sender, EventArgs e)
        {
            Class1 math = new Class1();

            // Declare variables and use methods from MathLibrary
            float mul = math.Multiply(Convert.ToInt32(TextBox1.Text), Convert.ToInt32(TextBox2.Text));
            Console.WriteLine(mul);
            TextBox3.Text = Convert.ToString(mul);

        }


        protected void Button4_Click(object sender, EventArgs e)
        {
            Class1 math = new Class1();

            // Declare variables and use methods from MathLibrary
            float div = math.Devide(Convert.ToInt32(TextBox1.Text), Convert.ToInt32(TextBox2.Text));
            Console.WriteLine(div);
            TextBox3.Text = Convert.ToString(div);

        }
    }
}