using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.OleDb;

namespace Bakara2_32._7_Veritabani_Islemleri
{
    public partial class Baglanti : System.Web.UI.Page
    {
        
        protected void Page_Load(object sender, EventArgs e)
        {

            OleDbConnection db_baglanti = new OleDbConnection("Provider=Microsoft.ACE.Oledb.12.0;Data Source=" + Server.MapPath("./ornek_veritabani.accdb"));
            db_baglanti.Open();
            if (db_baglanti != null)
            {
                Response.Write("Bağlantı Kuruldu.OleDbConnection İle Bağlantımız Hazır..."+ "<br/><br/>");
                Response.Write("OleDbDataReader Nesnesi ve Read() Metodu İle Ad Alanları sayfamıza çekildi."+ "<br/><br/>");

                /*SQL sorgularını çalıştırmak için OleDbCommand nesesinden faydalanyoruz.
                Sorguyu çalıştırmak için iki yöntem var.Birincisi veriyi kullanmayıp direk kayıt yapma güncelleme gibi işlemlerde kullanılan ExecuteNonQuery()
                İkincisi isi eğer sorguyu kullanacaksak örneğin sitede belli yerlere yazılacaksa ExecuteReader() ile okutup bir data set oluşturmuş oluruz.
                ExecuteReaderile okunan yapı bir kayıt seti halindedir.Bunu da kullanacabilmek için başka bir data nesnesine ihtiyaç vardır.
                O da DataReader nesnesidir. OleDbDataReader Nesnesi sadece okunabilir kayıt setini alır ve görüntüler.Değişiklik yapmaz.

                Bu nesne aslında bir dizi döndürür ve o dizinin elemanlarına veritabanındaki adları üzerinden ulaşabiliriz.
                */
                OleDbCommand cmd = new OleDbCommand("Select * from müşteriler",db_baglanti);
                OleDbDataReader alinan=cmd.ExecuteReader();

                //DipNot: Asp sayfalarında sunucu tarafında yani runat = "server" olan kod sadece bir tane olabilir

                while (alinan.Read())
                    //Burada Read metodu ile kayıt kayıt okuma yapıldığını anlıyoruz while döngüsü ile tüm kayıtlar bitene kadar kayıtları bize döndürecektir.
                    //Burada okunanlardan sadece üç kayır döndürmesini de isteyebiliriz.Bunun için for ile 3 defa dönen bir döngü içinde bunu da yapabiliriz.
                {
                    Response.Write(alinan["ad"] + "<br>");
                }




            }
            else
            {
                Response.Write("Bağlantı Başarısız");
            }
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            OleDbConnection db_baglanti = new OleDbConnection("Provider=Microsoft.ACE.Oledb.12.0;Data Source=" + Server.MapPath("./ornek_veritabani.accdb"));
            db_baglanti.Open();
            string kosul = TextBox1.Text;
            OleDbCommand filtre = new OleDbCommand("Select * from müşteriler Where ad LIKE '%" + kosul + "%'",db_baglanti);
            OleDbDataReader dr= filtre.ExecuteReader();
            Response.Write("<ol>");
            while(dr.Read())
            {
                Response.Write("<li>"+dr["ad"]+" "+dr["soyad"] + " " + dr["meslek"] + " " + dr["yaş"]+"</li>");
            }
            Response.Write("</ol>");
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            OleDbConnection db_baglanti = new OleDbConnection("Provider=Microsoft.ACE.Oledb.12.0;Data Source=" + Server.MapPath("./ornek_veritabani.accdb"));
            db_baglanti.Open();
            string ad = TextBox2.Text;
            string soyad = TextBox3.Text;
            string meslek= TextBox4.Text;
            int yas=Convert.ToInt32(TextBox5.Text);
            //Values ('" + ad + "','" + soyad + "','" + meslek + "','" + yas + "')
            OleDbCommand cmd = new OleDbCommand("Insert INTO müşteriler (ad,soyad,meslek,yaş) Values ('" + ad + "','" + soyad + "','" + meslek + "','" + yas + "')", db_baglanti);
            cmd.ExecuteNonQuery();
            db_baglanti.Close();
            Response.Write("Veritabanına Kaydınız Başarıyla Tamamlandı...");
        }
    }
}