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
/// Summary description for DropDownBLL
/// </summary>
public class DropDownBLL
{
    private DropDownTableAdapter _DropDownAdapter = null;

    protected DropDownTableAdapter Adapter
    {
        get
        {
            if (_DropDownAdapter == null)
            {
                _DropDownAdapter = new DropDownTableAdapter();

            }
            return _DropDownAdapter;
        }
    }

    [System.ComponentModel.DataObjectMethodAttribute(System.ComponentModel.DataObjectMethodType.Select, true)]
    public Computer.DropDownDataTable GetDropDown()
    {
        return Adapter.GetDropDown();
    }

    [System.ComponentModel.DataObjectMethodAttribute(System.ComponentModel.DataObjectMethodType.Select, false)]
    public Computer.DropDownDataTable GetDropDownByDropDownID(int DropDownID)
    {
        return Adapter.GetDropDownByDropDownID(DropDownID);
    }

    [System.ComponentModel.DataObjectMethodAttribute(System.ComponentModel.DataObjectMethodType.Delete, true)]
    public void DeleteDropDown(int DropDownID)
    {
        Adapter.DeleteDropDown(DropDownID);
    }

    [System.ComponentModel.DataObjectMethodAttribute(System.ComponentModel.DataObjectMethodType.Insert, true)]
    public void InsertDropDown(string Name)
    {
        Adapter.InsertDropDown(Name);
    }

    [System.ComponentModel.DataObjectMethodAttribute(System.ComponentModel.DataObjectMethodType.Update, true)]
    public void UpdateDropDown(string Name, int Original_DropDownID)
    {
        Adapter.UpdateDropDown(Name, Original_DropDownID);
    }
}
