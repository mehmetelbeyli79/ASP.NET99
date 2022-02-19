using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Bakara2_32
{
    public partial class Ornek1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)//Sayfa Postalanmamış gönderilmemiş ise
            {
                Response.Write("Sayfa Henüz Gönderilmedi");
            }
            else
            {
                Response.Write("Sayfa Gönderildi");
            }

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            ad.Text = "Mehmet Elbeyli";
        }
    }
}