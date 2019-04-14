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
using ShopTableAdapters;

/// <summary>
/// Summary description for RatingBLL
/// </summary>
public class RatingBLL
{
    private RatingTableAdapter _ratingAdapter = null;

    protected RatingTableAdapter Adapter
    {
        get
        {
            if (_ratingAdapter == null)
            {
                _ratingAdapter = new RatingTableAdapter();
            }
            return _ratingAdapter;
        }
    }

    [System.ComponentModel.DataObjectMethodAttribute(System.ComponentModel.DataObjectMethodType.Select, true)]

    public Shop.RatingDataTable GetRating()
    {
        return Adapter.GetRating();
    }

    [System.ComponentModel.DataObjectMethodAttribute(System.ComponentModel.DataObjectMethodType.Insert, true)]
    public void InsertRating(int ProductID, int Rating)
    {
        Adapter.InsertRating(ProductID, Rating);
    } 
    
    public int AVGRating(int ProductID)
    {
        int avg = (int)Adapter.AVGRating(ProductID);
        return avg;
    }
}
