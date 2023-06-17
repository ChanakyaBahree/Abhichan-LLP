using System;
using System.Collections;
using System.Configuration;
using System.Data;
using System.Linq;

using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.HtmlControls;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;

using System.Xml.Linq;
using System.Threading;

namespace threaddemo
{
    public partial class _Default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            ThreadStart childthreat = new ThreadStart(childthreadcall);
            Response.Write("Child Thread Started <br/>");
            Thread child = new Thread(childthreat);

            child.Start();

            Response.Write("Main sleeping  for 2 seconds.......<br/>");
            Thread.Sleep(2000);
            Response.Write("<br/>Main aborting child thread<br/>");

            child.Abort();
        }

        public void childthreadcall()
        {
            try
            {
                lblmessage.Text = "<br />Child thread started <br/>";
                lblmessage.Text += "Child Thread: Coiunting to 10";

                for (int i = 0; i < 10; i++)
                {
                    Thread.Sleep(500);
                    lblmessage.Text += "<br/> in Child thread </br>";
                }

                lblmessage.Text += "<br/> child thread finished";

            }
            catch (ThreadAbortException e)
            {

                lblmessage.Text += "<br /> child thread - exception";

            }
            finally
            {
                lblmessage.Text += "<br /> child thread - unable to catch the  exception";
            }
        }
    }
}