using System;
using System.Collections;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;
using System.Web.UI.HtmlControls;
using System.Xml.Linq;
using System.IO;

public partial class FrontEnd : System.Web.UI.MasterPage
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }
    protected void btnSearch_Click(object sender, EventArgs e)
    {
            string Search = tbSearch.Text;

            Response.Redirect("~/Search/SearchResult.aspx?Keyword=" + Search);

    }
    protected void DropDownList1_SelectedIndexChanged(object sender, EventArgs e)
    {
        string DropDown = DropDownList1.Text;

        Response.Redirect("~/Search/SearchResult.aspx?Keyword=" + DropDown);
    }
}
