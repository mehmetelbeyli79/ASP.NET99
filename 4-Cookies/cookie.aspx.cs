using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Bakara2_32._4_Cookies
{
    public partial class cookie : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            /*
             Cookie'ler Kullanıcının bilgisayarında saklanan ve sunucunun kullanıcı hakkında birtakım bilgileri elde edebileceği değerleri
            saklayan küçük dosyalardır.Özellikle browser kapatılsa dahi sitenin kullanıcı adı ve şifremizi hatırlaması gibi geniş bir kullanım alanı vardır.
            HttpCookie nesnesi Cookie'lerin oluşturulması ve erişimi ve saklanması için gerekli nesnedir.
            Bu nesneyi yönetmenin yolu da "Response" ve "Request" nesneleri ile yapılan bildirimlerdir.
            Response ile Cookie oluşturulurken Request ile Cookie'ye erişim sağlanır.
             */
            Response.Cookies["renk"].Value = "Kırmızı";
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            Response.Redirect("cookie_yaz.aspx");
        }
    }
}