using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Bakara2_32._4_Cookies
{
    public partial class cookie_yaz : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            Response.Write(Request.Cookies["renk"].Value.ToString());
        }
    }
}