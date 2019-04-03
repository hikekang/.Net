using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;



namespace _8
{
   
    public partial class _Default : Page
    {
       

        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {

            int hits;
            if (ViewState["hits"] == null)
            {
                hits = 0;
            }
            else
            {
                hits = (int)ViewState["hits"];
            }
            hits++;
            ViewState["hits"] = hits;
            this.TextBox1.Text = hits.ToString();
        }

        protected void TextBox1_TextChanged(object sender, EventArgs e)
        {
           
        }
    }
}