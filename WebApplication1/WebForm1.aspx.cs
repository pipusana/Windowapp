using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication1
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        Double  unti1,unti2,unti3;
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            unti1 = Convert.ToDouble(TextBox1.Text);
            unti2 = Convert.ToDouble(TextBox2.Text);
            unti3 = Convert.ToDouble(TextBox3.Text);
            Class1 sc = new Class1();
            Label4.Text = "Price : " +sc.untis(unti1);
            Label5.Text = "Price : " + sc.untis(unti2);
            Label6.Text = "Price : " + sc.untis(unti3);
        }
    }
}