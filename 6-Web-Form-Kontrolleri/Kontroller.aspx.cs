using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Bakara2_32._6_Web_Form_Kontrolleri
{
    public partial class Kontroller : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void t_gorun_CheckedChanged(object sender, EventArgs e)
        {
            if(t_gorun.Checked==true)
            {
                secenek_listesi.RepeatLayout = RepeatLayout.Table;
            }
            else
            {
                secenek_listesi.RepeatLayout=RepeatLayout.Flow;
            }
        }

        protected void y_gorun_CheckedChanged(object sender, EventArgs e)
        {
            if(y_gorun.Checked==true)
            {
                secenek_listesi.RepeatDirection = RepeatDirection.Horizontal;
            }
            else
            {
                secenek_listesi.RepeatDirection=RepeatDirection.Vertical;   
            }
        }

        protected void s_yaz_Click(object sender, EventArgs e)
        {
            string secilenler = "";
            for(int i=0;i<=secenek_listesi.Items.Count-1;i++)
            {
                if(secenek_listesi.Items[i].Selected == true)
                {
                    secilenler = secilenler + secenek_listesi.Items[i].Text+"<br/>";
                }

                
            }
            Label1.Text = secilenler;
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            if(Page.IsValid)
            {
                Label1.Text = "Sayfa Geçerli";
            }
        }
    }
}