using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Bakara2_32._5_Sessions
{
    public partial class Session_kullan : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            Response.Write("<b>Renk:</b>" + Session["renk"]+"<br/>");
            Response.Write("Session ID:"+Session.SessionID);//Oluşturulan bu id Cookie şeklinde saklanıyor yine
            
        }
    }
}