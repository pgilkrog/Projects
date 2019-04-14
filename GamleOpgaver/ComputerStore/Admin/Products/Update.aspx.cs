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

public partial class Admin_Products_Update : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }       
    
    public string GenerateString(string input)
    {
        string newString = Tools.CropText(input, 200, false);
        return newString;
    }
    protected void pnlGrid_SelectedIndexChanged(object sender, EventArgs e)
    {
        //Vælger hvilket Panel som skal være synligt når jeg trykker Select
       Panel1.Visible = false;
        pnlDetails.Visible = true;
    }
    protected void DetailsView1_ItemUpdating(object sender, DetailsViewUpdateEventArgs e)
    {
        DropDownList DropDownList1 = (DropDownList)Tools.FindControlRecursive(DetailsView1, "DropDownList1");
        int category = Convert.ToInt32(DropDownList1.SelectedValue);

        if (category != 0)
        {
            ObjectDataSource2.UpdateParameters.Add("CategoryID", System.Data.DbType.Int32, category.ToString());
        }

            else
            {
                ObjectDataSource2.UpdateMethod = "UpdateProductsNo";
            }
        

        FileUpload FileUpload1 = (FileUpload)Tools.FindControlRecursive(DetailsView1, "FileUpload1");

        //Hvis fileupload er tom gør det som står i if
        if (FileUpload1.FileName == "")
        {
            Image imgProduct = (Image)Tools.FindControlRecursive(DetailsView1, "imgProduct");
            string URL = imgProduct.ImageUrl;
            //Indsæt kun det som er efter det sidste slash=/
            int afterLastSlashIndex = URL.LastIndexOf("/") + 1;
            string filename = URL.Substring(afterLastSlashIndex, URL.Length - afterLastSlashIndex);
            ObjectDataSource2.UpdateParameters.Add("Image", System.Data.DbType.String, filename);
        }
        
        //Hvis fileupload er fyldt gør dette
        else
        {
            Label lblMessage = (Label)Tools.FindControlRecursive(DetailsView1, "lblMessage");

            string tempPath = "Images/TempImages";
            string imgPath = "Images/Products";
            string thumbPath = "Images/thumb";
            string savePath = Path.Combine(Request.PhysicalApplicationPath, tempPath);
            string saveThumbPath = Path.Combine(Request.PhysicalApplicationPath, thumbPath);

            string extension = Path.GetExtension(FileUpload1.FileName);
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
                    FileUpload1.SaveAs(TempImagesPath);
                    //Her laver vi vores to thumbnails som selv skalere filen, husk at dine filer skal være kvadratiske
                    ImageTools.GenerateThumbnail(TempImagesPath, ImageNormal, 240, 300, true, "high");
                    ImageTools.GenerateThumbnail(TempImagesPath, ImageThumb, 76, 96, true, "medium");

                    //Her skriver vi at filen er uploadet, og navnet på filen
                    lblMessage.Text = "Billedet" + FileUpload1.FileName + " er nu uploadet";

                    break;
                default:
                    lblMessage.Text = "Filtypen til billedet er ikke tilladet";
                    return;
            }
            ObjectDataSource2.UpdateParameters.Add("Image", System.Data.DbType.String, fileName);
        }
    }

    protected void DetailsView1_ItemUpdated(object sender, DetailsViewUpdatedEventArgs e)
    {
        pnlGrid.DataBind();
        lblUpdate.Text = "Productet er updateret";
        Panel1.Visible = true;
        pnlDetails.Visible = false;
    }
}