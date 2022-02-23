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
    public partial class DataTableveOledbCommand : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            //Veri Görüntülemede DataAdapter ve DataTable Olayı
            /*
                DataTable'da OledbCommand ile Oluşturulan komut yapısı Datareader ve ExecuteReader ile okunup DataTable'a aktarılıyor ve Gridview'in datasource'una yazılır
                
                DataTable -> OledbCommand -> DataReader -> ExecuteReader -> Load metodu

             */

            /*
             
                DataAdapter'da ise Komut yapısı direkt kendi içinde oluşturulup dataset içini doldurulur Fill metodu ile ve artık Gridview için data source verilir.

                DataAdapter -> DataSet -> Fill metodu
             
                Bu yöntem daha kolay görünüyor.
             */


            OleDbConnection baglan = new OleDbConnection("Provider=Microsoft.ACE.Oledb.12.0;Data Source=" + Server.MapPath("./ornek_veritabani.accdb"));
            baglan.Open();

            DataTable veriler=new DataTable();
            OleDbCommand cmd = new OleDbCommand("Select * From müşteriler", baglan);
            OleDbDataReader dr = cmd.ExecuteReader();
            veriler.Load(dr);
            GridView1.DataSource = veriler;
            GridView1.DataBind();
            baglan.Close();
        }
    }
}