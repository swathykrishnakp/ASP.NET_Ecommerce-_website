using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace CAKE_PROJECT_
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        Class1 obj = new Class1();
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            string sel = "select max(Reg_id) from Login_Tab";
            string regid = obj.FUN_Scalar(sel);
            int reg_id = 0;
            if (regid == "")
            {
                reg_id = 1;
            }
            else
            {
                int newregid = Convert.ToInt32(regid);
                reg_id = newregid + 1;
            }
            string ins = "insert into Admin_Reg_Tab values(" + reg_id + ",'" + TextBox1.Text + "','" + TextBox2.Text + "','"+TextBox3.Text+"',"+TextBox4.Text+")";
            int i = obj.FUN_NonQuery(ins);
            if (i == 1)
            {
                string inslog = "insert into Login_Tab values(" + reg_id + ",'" + TextBox5.Text + "','" + TextBox6.Text + "','admin')";
                int j = obj.FUN_NonQuery(inslog);

            }
        }
    }
}