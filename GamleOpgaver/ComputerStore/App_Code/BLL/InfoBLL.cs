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
/// Summary description for Info
/// </summary>
public class InfoBLL
{
    private InfoTableAdapter _infoAdapter = null;

    protected InfoTableAdapter Adapter
    {
        get
        {
            if (_infoAdapter == null)
            {
                _infoAdapter = new InfoTableAdapter();

            }
            return _infoAdapter;
        }
    }

    [System.ComponentModel.DataObjectMethodAttribute(System.ComponentModel.DataObjectMethodType.Select, true)]
    public Computer.InfoDataTable GetInfo()
    {
        return Adapter.GetInfo();
    }

    [System.ComponentModel.DataObjectMethodAttribute(System.ComponentModel.DataObjectMethodType.Select, true)]
    public void UpdateInfo(string Name, string Address, string ZipCode, string City, string Phone, string Fax, string Email, int Original_InfoID)
    {
        Adapter.UpdateInfo(Name, Address, ZipCode, City, Phone, Fax, Email, Original_InfoID);
    }
}
