using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

using System.Text;

namespace TestString
{
    public partial class Expl_StringBuilder1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnAppend_Click(object sender, EventArgs e)
        {
            string tempStr = string.Empty;
            // Declare a new StringBuilder.
            tempStr = txt01.Text;
            // Append to StringBuilder.
          clsGlobal. builder.Append(tempStr).Append(" ");
            tempStr = txt02.Text;
            clsGlobal.builder.Append(tempStr).Append(" ");
            tempStr = txt03.Text;
            clsGlobal.builder.Append(tempStr).Append(" ");
            tempStr = txt04.Text;
            clsGlobal.builder.Append(tempStr).Append(" ");
            // Get a reference to the StringBuilder's buffer content.
            string innerString = clsGlobal.builder.ToString();
            txtShow.Text = innerString;
        }

        protected void btnAppendLine_Click(object sender, EventArgs e)
        {
            string tempStr = string.Empty;
            // Declare a new StringBuilder.
            
            tempStr = txt01.Text;
            // Append to StringBuilder.
            clsGlobal.builder.Append(tempStr).Append(" ");
            // Append to StringBuilder newline on the end.
            clsGlobal.builder.AppendLine();
            tempStr = txt02.Text;
            clsGlobal.builder.Append(tempStr).Append(" ");
            clsGlobal.builder.AppendLine();
            tempStr = txt03.Text;
            clsGlobal.builder.Append(tempStr).Append(" ");
            clsGlobal.builder.AppendLine();
            tempStr = txt04.Text;
            clsGlobal.builder.Append(tempStr).Append(" ");
            clsGlobal.builder.AppendLine();
            // Get a reference to the StringBuilder's buffer content.
            string innerString = clsGlobal.builder.ToString();
            txtShow.Text = innerString;
        }

        protected void btnClear_Click(object sender, EventArgs e)
        {
            //Clear erases the character data from a StringBuilder instance
            clsGlobal.builder.Clear();            
            string innerString = clsGlobal.builder.ToString();
            txtShow.Text = innerString;
        }

        protected void btnResult_Click(object sender, EventArgs e)
        {
            string innerString = clsGlobal.builder.ToString();
            txtShow.Text = innerString;
        }

        protected void btnLength_Click(object sender, EventArgs e)
        {
            int strLen = 0;
            strLen = clsGlobal.builder.Length;
            txtShow.Text = "Length = " + Convert.ToString(strLen);
        }

        protected void btnReplace_Click(object sender, EventArgs e)
        {
            string tempFind = string.Empty;
            string tempReplace = string.Empty;
            tempFind = txtFindWith.Text;
            tempReplace = txtReplaceWith.Text;
            // Replace
            clsGlobal.builder.Replace(tempFind, tempReplace);
            string innerString = clsGlobal.builder.ToString();
            string result = txtShow.Text;
            result =result + "\r\n" + innerString;
            txtShow.Text = result;
        }

        protected void btnRemove_Click(object sender, EventArgs e)
        {

            int removeStart = 0;
            int removeEnd = 0;

            removeStart = Convert.ToInt32(txtStartRemove.Text);
            removeEnd = Convert.ToInt32(txtEndRemove.Text);
            //Remove from start to end position
            clsGlobal.builder.Remove(removeStart, removeEnd);
            string innerString = clsGlobal.builder.ToString();
            string result = txtShow.Text;
            result = result + "\r\n" + innerString;
            txtShow.Text = result;
        }

        protected void btnSubstring_Click(object sender, EventArgs e)
        {
            int charPos = 0;
            charPos = Convert.ToInt32(txtStartPos.Text);
            string result = Convert.ToString( clsGlobal.builder[charPos]);
            string innerString = clsGlobal.builder.ToString();

            result = innerString + "\r\n" + result;
            txtShow.Text = result;
        }

        protected void btnFind_Click(object sender, EventArgs e)
        {

            string result = "";
            string value = clsGlobal.builder.ToString();
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

        protected void btnInsert_Click(object sender, EventArgs e)
        {
           int insertStart=0;
            string insertText = string.Empty;
            insertStart =Convert.ToInt32( txtInsertStart.Text);
            insertText =txtToInsert.Text;
            // Insert Text at Index
            clsGlobal.builder.Insert(insertStart, insertText);
            string innerString = clsGlobal.builder.ToString();
            string result = txtShow.Text;
            result = result + "\r\n" + innerString;
            txtShow.Text = result;
        }
    }
}