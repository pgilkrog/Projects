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

public partial class Contact : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }
    protected void btnSend_Click(object sender, EventArgs e)
    {
        string from = tbEmail.Text;
        string subject = tbSubject.Text;
        string body = "<b>Navn: </b>" + tbName + "<BR>" + "<b>Address: </b>" + tbAddress.Text
            + "<BR>" + "<b>Zip code/City: </b>" + tbZip.Text + tbCity + "<BR>" + "<b>Phone: </b>" + tbPhone.Text + "<BR>" + "<BR>" + "<b>Description: </b>" + tbDesc.Text;
        string to = "mabj@mediacollege.dk";
        string SMTP = "10.138.22.47";

        try
        {
            Tools tool = new Tools();
            tool.SendMail(to, from, subject, body, SMTP);
            lblMessage.Text = "You will receive our answer as soon as possible";
        }

        catch (Exception err)
        {
            lblMessage.Text = "Der opstod en fejl:<br />" + err + "<br /> Hvis fejlen kommer igen, kontakt venligst adminstrator";
        }
    }
}
