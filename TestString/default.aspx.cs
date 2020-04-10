using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace TestString
{
    public partial class _default : System.Web.UI.Page
    {
        public _default()
{
    this.Init += new EventHandler(Page_Init);
}
 
private void Page_Init(object sender, System.EventArgs e)
{
    this.EnableViewState = false;
}
        
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            Label1.Text = TextBox1.Text;
        }

        int MinusFunction(int a, int b)
        {
            return a - b;
        }
    }
}