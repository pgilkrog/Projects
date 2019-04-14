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
/// Summary description for BannerBLL
/// </summary>
public class BannerBLL
{
    private BannerTableAdapter _bannerAdapter = null;

    protected BannerTableAdapter Adapter
    {
        get
        {
            if (_bannerAdapter == null)
            {
                _bannerAdapter = new BannerTableAdapter();

            }
            return _bannerAdapter;
        }
    }

    [System.ComponentModel.DataObjectMethodAttribute(System.ComponentModel.DataObjectMethodType.Select, true)]
    public Computer.BannerDataTable GetBanner()
    {
        return Adapter.GetBanner();
    }

    [System.ComponentModel.DataObjectMethodAttribute(System.ComponentModel.DataObjectMethodType.Select, false)]
    public Computer.BannerDataTable GetBannerByRandom()
    {
        return Adapter.GetBannerByRandom();
    }

    [System.ComponentModel.DataObjectMethodAttribute(System.ComponentModel.DataObjectMethodType.Insert, true)]
    public void InsertBanner(string Name, string Image)
    {
        Adapter.InsertBanner(Name, Image);
    }

    [System.ComponentModel.DataObjectMethodAttribute(System.ComponentModel.DataObjectMethodType.Delete, true)]
    public void DeleteBanner(int BannerID)
    {
        Adapter.DeleteBanner(BannerID);
    }
}
