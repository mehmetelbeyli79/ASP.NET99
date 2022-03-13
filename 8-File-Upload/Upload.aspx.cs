using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Bakara2_32._8_File_Upload
{
    public partial class Upload : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            if (FileUpload1.HasFile)
                try
                {
                    if (FileUpload1.PostedFile.ContentType == "image/jpeg")
                    {
                        if (FileUpload1.PostedFile.ContentLength < 102400)
                        {
                            FileUpload1.SaveAs(Server.MapPath("./Uploaded_Files/") + FileUpload1.FileName);
                            Label1.Text = "Dosya Adı: " +
                                FileUpload1.PostedFile.FileName +
                                "<br />Dosya Boyutu: " +
                                FileUpload1.PostedFile.ContentLength +
                                "<br />Dosya Türü: " +
                                FileUpload1.PostedFile.ContentType;
                        }
                        else
                        {
                            Label1.Text = "Maksimum boyut 100 KB olmalı.";
                        }
                    }
                    else
                    {
                        Label1.Text = "Resim dosyası seçin.";
                    }

                }
                catch (Exception ex)
                {
                    Label1.Text = "Hata Oluştu: " + ex.Message.ToString();
                }
            else
            {
                Label1.Text = "Dosya Seçin ve GÖNDER Butonuna Tıklayın.";
            }
        }
    }
}