using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Bakara2_32._5_Sessions
{
    public partial class Session : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            //Session.Add("renk","Mavi"); bu şekilde de bir Session Tanımlanabirlir.
            /*
             Cookie'lere çok benzemekle birlikte daha küçük ölçekli verilerin oturum boyunca saklanmasını sağlayan değişken tanımlamasıdır.
            Session sayesinde kullanıcıya ait verileri sayfalar arasında kullanabiliriz.
            Sitede bulunduğumuz sürece sadece ve sadece bize ait değişkenleri kullanılmak istenirse Session kullanılabilir.
            Session ve Cookie çok karıştırılmaktadır.Bir örnek ile anlatılacak olursa:
            İstemci sunucuya bağlandığı zaman sunucu sadece o istemciye özel bir SessionId numarası atar.Ve bunu bir Cookie'de saklar.Böylece oturum boyunca 
            sadece o kullanıcıya ait değerleri saklar ve elde eder.

            //Session.Abandon(); Session Nesnesini Sonlandırmak İçin Kullanılır.
            //Session.Timeout=20; Oturumun kullanıcı hiç dokunmadığından kaç dakika sonra sonlandırılacağını belirler.Default 20 dakikadır.


             */
            Session["renk"] = "Mavi";
        }

        protected void Button1_Click(object sender, EventArgs e)
        {

        }
    }
}