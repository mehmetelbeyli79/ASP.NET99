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
    public partial class DataAdapterveDataSet : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            OleDbConnection baglan = new OleDbConnection("Provider=Microsoft.ACE.Oledb.12.0;Data Source=" + Server.MapPath("./ornek_veritabani.accdb"));
            baglan.Open();
            OleDbDataAdapter da = new OleDbDataAdapter("Select * from müşteriler", baglan);//Veritabanı için bir adaptör oluyor
            DataSet ds = new DataSet();//Veritabanı için bir veri seti hazırlanıp
            da.Fill(ds);//Adaptördeki tüm veriler Bu veri setinin içine atılıyor

            GridView1.DataSource = ds;//Gridview'e veri yolu olarak gösterilip
            GridView1.DataBind();//Data içeriye alınıyor.
        }
    }
}