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

public partial class Admin_Categories_Update : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    protected void pnlGrid_SelectedIndexChanged(object sender, EventArgs e)
    {
        //Vælger hvilket Panel som skal være synligt når jeg trykker Select
        Panel1.Visible = false;
        pnlDetails.Visible = true;
    }
    protected void DetailsView1_ItemUpdated(object sender, DetailsViewUpdatedEventArgs e)
    {
        pnlGrid.DataBind();
        lblUpdate.Text = "Productet er updateret";
        Panel1.Visible = true;
        pnlDetails.Visible = false;
    }
}
