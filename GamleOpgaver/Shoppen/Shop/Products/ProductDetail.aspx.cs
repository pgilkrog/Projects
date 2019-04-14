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

public partial class ProductDetail : System.Web.UI.Page
{
    RatingBLL rat = new RatingBLL();
        
    protected void Page_Load(object sender, EventArgs e)
    {
        int ProductID = Convert.ToInt32(Request.QueryString["ProductID"]);
        RateProduct.CurrentRating = rat.AVGRating(ProductID);
    }
    protected void btnRate_Click(object sender, EventArgs e)
    {
        int ProductID = Convert.ToInt32(Request.QueryString["ProductID"]);
        int rate = Rating1.CurrentRating;
        try
        {
            rat.InsertRating(ProductID, rate);
            lblRate.Text = "Tak for din bedømmelse";
            btnRate.Enabled = false;
        }
        catch
        {
            lblRate.Text = "Der opstod en fejl";
        }
    }
}
