using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;


using System.Text.RegularExpressions;



namespace TestString
{
    public partial class Expl_StringBuilder : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnAppend_Click(object sender, EventArgs e)
        {
            string value1 = txt01.Text;
            string value2 = txt02.Text;
            string result = value1+ value2;
            txtShow.Text = result;
        }

        protected void btnSplit_Click(object sender, EventArgs e)
        {
            string result = "";
            char value1 = ' ';
            string value = txtShow.Text;
            if (txtSingleSplit.Text != "")
                value1 = Convert.ToChar(txtSingleSplit.Text);
           
            string value2 = txtMultiSplit.Text;
            if (value1 != ' ')
            {
                string[] words = value.Split(value1);
                foreach (string word in words)
                {
                    result = result + "\r\n" + word;
                }

            }
            if (value2 != "")
            {
                char[] delimiter1 = value2.ToCharArray(); 
                
                //string[] words = Regex.Split(value, value2); 
                string[] words = value.Split(delimiter1, StringSplitOptions.RemoveEmptyEntries); //Remove empty string
                foreach (string word in words)
                {
                    result = result + "\r\n" + word;
                }

            }

            txtShow.Text = result;
            
        }

        protected void btnClear_Click(object sender, EventArgs e)
        {
            txtShow.Text = "";
            txt01.Text = "";
            txt02.Text = "";
            txtSingleSplit.Text = "";
            txtMultiSplit.Text = "";
        }

        protected void btnSplitWord_Click(object sender, EventArgs e)
        {
            string result = "";
            string value = txtShow.Text;
            string[] w = SplitWords(value);
            foreach (string word in w)
            {
                result = result + "\r\n" + word;
            }
            txtShow.Text = result;
        }


        static string[] SplitWords(string s)
        {
            //
            // Split on all non-word characters. It eliminates punctuation and whitespace.
            // ... Returns an array of all the words.
            //
            return Regex.Split(s, @"\W+");
            // @      special verbatim string syntax
            // \W+    one or more non-word characters together
        }

        protected void btnFind_Click(object sender, EventArgs e)
        {
            string result = "";
            string value = txtShow.Text;
            string findText = txtFind.Text;
            int i = value.IndexOf(findText);
            if (i != -1)
            {
                result = "Position of string = " + Convert.ToString(i);
            }
            else
            {
                result = "String not found";
            }
            txtShow.Text = txtShow.Text + "\r\n" + result;
        }

        protected void btnSubstring_Click(object sender, EventArgs e)
        {
            string result = "";
            string value = txtShow.Text;
            int startPos = Convert.ToInt32(txtStartPos.Text);

            result = "Value of substring = " +  value.Substring(startPos);
            txtShow.Text = txtShow.Text + "\r\n" + result;
        }

        protected void btnReplace_Click(object sender, EventArgs e)
        {

            string findWith = txtFindWith.Text;
            string replaceWith = txtReplaceWith.Text;

            string result = txtShow.Text;
            result = result.Replace(findWith, replaceWith);
            txtShow.Text = txtShow.Text + "\r\n" + result;

        }

        protected void btnLength_Click(object sender, EventArgs e)
        {
            string result = txtShow.Text;
            int strLen = result.Length;
            txtShow.Text = txtShow.Text + "\r\n" + "Text Length = " + Convert.ToString(strLen);

        }

        protected void btnCompare_Click(object sender, EventArgs e)
        {
            string compText=txtCompareText.Text;
            string compWith = txtCompareWith.Text;
            int result=0;

            //-----if equal =0/ if compText > compWith =1/if compText < compWith = -1 ------------
            if (ddlCaseType.Text == "Use Case")
            {
                StringComparer comparer1 = StringComparer.Ordinal;
                result = comparer1.Compare(compText, compWith);
            }
            else
            {
                StringComparer comparer1 = StringComparer.OrdinalIgnoreCase;
                result = comparer1.Compare(compText, compWith);
            }

            txtShow.Text = txtShow.Text + "\r\n" + "Result = " + Convert.ToString(result);



        }




    }
}