using System;
using System.Data;
using System.Configuration;
using System.Linq;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.HtmlControls;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;
using System.Xml.Linq;
using ComputerTableAdapters;

/// <summary>
/// Summary description for SideTextBLL
/// </summary>
public class SideTextBLL
{
    private SideTextTableAdapter _textAdapter = null;

    protected SideTextTableAdapter Adapter
    {
        get
        {
            if (_textAdapter == null)
            {
                _textAdapter = new SideTextTableAdapter();

            }
            return _textAdapter;
        }
    }

    [System.ComponentModel.DataObjectMethodAttribute(System.ComponentModel.DataObjectMethodType.Select, true)]
    public Computer.SideTextDataTable GetText()
    {
        return Adapter.GetText();
    }

    [System.ComponentModel.DataObjectMethodAttribute(System.ComponentModel.DataObjectMethodType.Update, true)]
    public void UpdateText(string Headline, string Text, int SideID)
    {
        Adapter.UpdateText(Headline, Text, SideID);
    }
}
