using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class _Default : Page
{
    int i = 0;
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    protected void RadioButton1_CheckedChanged(object sender, EventArgs e)
    {

    }



    protected void Button1_Click(object sender, EventArgs e)
    {
        if (RadioButton1.Checked == true)
        {
            i+=20;
        }
        if (CheckBox1.Checked == true && CheckBox2.Checked == true)
        {
            i += 20;
        }
        TextBox1.Text = Convert.ToString(i);
    }
}