using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Bakara2_32._2_Request_QueryString
{
    public partial class gelenIstek : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
           k_adi.Text=Request.QueryString["k_ad"];
            sifre.Text = Request.QueryString["sifre"];
        }
    }
}