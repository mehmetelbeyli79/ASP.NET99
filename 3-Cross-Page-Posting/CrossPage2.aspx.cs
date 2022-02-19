using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Bakara2_32._3_Cross_Page_Posting
{
    public partial class CrossPage2 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            //Response.Write(PreviousPage==null);False
            if (PreviousPage != null)
            {
                Label1.Text = ((TextBox)PreviousPage.FindControl("txtAd")).Text;//ID'ye göre gelen sayfadaki veriyi kontrole göre almak bu şekilde
                Label2.Text = PreviousPage.Title;//Önceki sayfanın Başlığını çekiyor.
            }
        }
    }
}