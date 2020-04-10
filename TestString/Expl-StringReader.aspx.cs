using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

using System.IO;

namespace TestString
{
    public partial class Expl_StringReader : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnResult_Click(object sender, EventArgs e)
        {
            string myText = string.Empty;
            string result = string.Empty;
           

            myText = txtShow.Text;

            // Creates new StringReader instance from System.IO
            using (StringReader reader = new StringReader(myText))
            {
                // Loop over the lines in the string.
                int count = 0;
                string line;
                while ((line = reader.ReadLine()) != null)
                {
                    count++;
                    clsGlobal.builder.AppendFormat("Line {0}: {1} .\n", count, line);

                }
            }
            result = clsGlobal.builder.ToString();
            txtShow.Text = result;
        }

        protected void btnClear_Click(object sender, EventArgs e)
        {
            clsGlobal.builder.Clear();
        }

    }
}