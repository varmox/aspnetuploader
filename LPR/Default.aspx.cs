using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace LPR
{
    public partial class Default : System.Web.UI.Page
    {
        private string UploadDirectory { get; set; }

        protected void Page_Load(object sender, EventArgs e)
        {
            // Definiert das Upload-Verzeichenis ab RootPath der Website
            UploadDirectory = Server.MapPath("uploads");

            // Kontrolliert auf vorhandenes Upload-Verzeichnis
            if (!System.IO.Directory.Exists(UploadDirectory))
            {
                this.Panel1.Visible = false;
                this.Panel2.Visible = true;
                this.Label2.Text = "Upload-Verzeichnis '" + UploadDirectory + "' ist nicht vorhanden.";
            }
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            if (this.FileUpload1.HasFile)
            {
                string fileSavePath = UploadDirectory + @"\" + this.FileUpload1.FileName;
                if (!System.IO.File.Exists(fileSavePath))
                {
                    this.FileUpload1.SaveAs(fileSavePath);
                    this.Label1.Text = "OK: Datei '" + fileSavePath + "' wurde gespeichert.";
                }
                else
                {
                    this.Label1.Text = "FEHLER: Datei '" + fileSavePath + "' ist bereits vorhanden.";
                }
            }
            else
            {
                this.Label1.Text = "FEHLER: Keine Datei ausgewählt.";
            }
        }
    }
}