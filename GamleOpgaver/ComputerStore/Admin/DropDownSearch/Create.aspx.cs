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

public partial class Admin_DropDownSearch_Create : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }
    protected void btnCreate_Click(object sender, EventArgs e)
    {
        DropDownBLL DropDown = new DropDownBLL();
        try
        {
            string name = tbName.Text;
            DropDown.InsertDropDown(name);
        }

        catch (Exception)
        {
            lblMessage.Text = "Der opsted en fejl";
        }
    }
}
