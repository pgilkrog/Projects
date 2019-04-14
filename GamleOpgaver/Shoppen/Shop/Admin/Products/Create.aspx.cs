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

public partial class Admin_Create : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    protected void Wizard1_FinishButtonClick(object sender, WizardNavigationEventArgs e)
    {
        if (uplImage.HasFile)
        {
            string tempPath = "Images/TempImages";
            string imgPath = "Images/Products";
            string thumbPath = "Images/thumb";
            string savePath = Path.Combine(Request.PhysicalApplicationPath, tempPath);
            string saveThumbPath = Path.Combine(Request.PhysicalApplicationPath, thumbPath);

            string extension = Path.GetExtension(uplImage.FileName);
            string fileName = Guid.NewGuid().ToString() + extension;
            string TempImagesPath = Path.Combine(savePath, fileName);
            string ThumbImagesPath = Path.Combine(saveThumbPath, fileName);
            string imgSavePath = Path.Combine(Request.PhysicalApplicationPath, imgPath);

            string ImageNormal = Path.Combine(imgSavePath, fileName);
            string imgSaveThumbPath = Path.Combine(Request.PhysicalApplicationPath, thumbPath);
            string ImageThumb = Path.Combine(imgSavePath, fileName);

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
                    //Her uploader vi filen til vores Temp mappe
                    uplImage.SaveAs(TempImagesPath);
                    //Her laver vi vores to thumbnails som selv skalere filen, husk at dine filer skal være kvadratiske
                    ImageTools.GenerateThumbnail(TempImagesPath, ImageNormal, 240, 300, true, "high");
                    ImageTools.GenerateThumbnail(TempImagesPath, ImageThumb, 76, 96, true, "medium");

                    //Her skriver vi at filen er uploadet, og navnet på filen
                    lblMessage.Text = "Billedet" + uplImage.FileName + " er nu uploadet";
                    Wizard1.Visible = false;

                    ProductsBLL product = new ProductsBLL();
                    try
                    {
                        string name = tbName.Text;
                        string description = tbDescription.Text;
                        description = Server.HtmlDecode(description.Replace("<BR />", Environment.NewLine));
                        decimal price = Convert.ToDecimal(tbPrice.Text.Replace(",", ","));
                        int category = Convert.ToInt32(rblCategories.SelectedValue);
                        product.InsertProducts(name, description, price, fileName, category);
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

        else
        {
            lblMessage.Text = "Du har ikke uploadet et billede!";
        }
    }
}
