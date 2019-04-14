using System;
using System.Collections;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.HtmlControls;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;
using System.Xml.Linq;
using System.IO;

public partial class Admin_Banner_Create : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }
    protected void btnCreate_Click(object sender, EventArgs e)
    {
        if (uplImage.HasFile)
        {
            string tempPath = "Images/Banner/Image";
            string savePath = Path.Combine(Request.PhysicalApplicationPath, tempPath);
            string extension = Path.GetExtension(uplImage.FileName);
            string fileName = Guid.NewGuid().ToString() + extension;
            string TempImagesPath = Path.Combine(savePath, fileName);

            switch (extension.ToLower())
            {
                case ".png":
                    goto case "Upload";
                case ".gif":
                    goto case "Upload";
                case ".jpg":
                    goto case "Upload";
                case ".jpeg":
                    goto case "Upload";
                case "Upload":
                    uplImage.SaveAs(TempImagesPath);

                    lblMessage.Text = "Billedet" + uplImage.FileName + " er nu uploadet";

                    BannerBLL product = new BannerBLL();
                    try
                    {
                        string name = tbName.Text;
                        product.InsertBanner(name, fileName);
                    }

                    catch (Exception)
                    {
                        lblMessage.Text = "Der opsted en fejl";
                    }

                    break;
                default:
                    lblMessage.Text = "Filtypen til billedet er ikke tilladet";
                    return;
            }
        }
    }
}
