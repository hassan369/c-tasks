using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace _30_11_2022
{

    class math
    {


        public static double sum(double x,double y)
        {
            double result  = x+y ;
            return result ;
        }

        public static double sub(double x, double y)
        {
            double result = x - y;
            return result ;
        }

        public static double multi(double x, double y)
        {
            double result = x * y;
            return result;
        }
        public static double div(double x, double y)
        {
            double result = x / y;
            return result;
        }
    }
    public partial class calculater : System.Web.UI.Page
    {
        

        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            double txt1 = Convert.ToDouble(TextBox1.Text);
            double txt2 = Convert.ToDouble(TextBox2.Text);
            

           double result1= math.sum(txt1,txt2);
            TextBox3.Text = Convert.ToString(result1);

        }

        protected void sub_Click(object sender, EventArgs e)
        {
            double txt1 = Convert.ToDouble(TextBox1.Text);
            double txt2 = Convert.ToDouble(TextBox2.Text);
            
            double result2 = math.sub(txt1, txt2);
            TextBox3.Text = Convert.ToString(result2);
        }

        protected void multi_Click(object sender, EventArgs e)
        {
            double txt1 = Convert.ToDouble(TextBox1.Text);
            double txt2 = Convert.ToDouble(TextBox2.Text);
            
            
            double result3 = math.multi(txt1, txt2);
            TextBox3.Text = Convert.ToString(result3);
        }

        protected void divid_Click(object sender, EventArgs e)
        {
            double txt1 = Convert.ToDouble(TextBox1.Text);
            double txt2 = Convert.ToDouble(TextBox2.Text);
           
            double result4 = math.div(txt1, txt2);
            TextBox3.Text = Convert.ToString(result4);
        }
    }
}