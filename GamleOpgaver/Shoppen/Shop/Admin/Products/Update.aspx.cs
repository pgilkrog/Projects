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

public partial class Admin_Products_Update : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }       
    
    public string GenerateString(string input)
    {
        string newString = Tools.CropText(input, 30, true);
        return newString;
    }
    protected void pnlGrid_SelectedIndexChanged(object sender, EventArgs e)
    {
        pnlGrid.Visible = false;
        pnlDetails.Visible = true;
    }
    protected void DetailsView1_ItemUpdating(object sender, DetailsViewUpdateEventArgs e)
    {
        DropDownList DropDownList1 = (DropDownList)Tools.FindControlRecursive(DetailsView1, "DropDownList1");
        int category = Convert.ToInt32(DropDownList1.SelectedValue);

        if (category != 0)
        {
            ObjectDataSource2.UpdateParameters.Add("Category", System.Data.DbType.Int32, 
        }

            else
            {

            }
    }
}
