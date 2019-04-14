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
public class CategoryBLL
{
    private CategoriesTableAdapter _CategoryAdapter = null;

    protected CategoriesTableAdapter Adapter
    {
        get
        {
            if (_CategoryAdapter == null)
            {
                _CategoryAdapter = new CategoriesTableAdapter();

            }
            return _CategoryAdapter;
        }
    }

    [System.ComponentModel.DataObjectMethodAttribute(System.ComponentModel.DataObjectMethodType.Select, true)]
        public Shop.CategoriesDataTable GetCategory()
    {
        return Adapter.GetCategory();
    }

    [System.ComponentModel.DataObjectMethodAttribute(System.ComponentModel.DataObjectMethodType.Insert, true)]
    public void InsertCategory(string Name, string Description)
    {
        Adapter.InsertCategory(Name, Description);
    }

    [System.ComponentModel.DataObjectMethodAttribute(System.ComponentModel.DataObjectMethodType.Update, true)]
    public void UpdateCategories(string Name, string Description, int Original_CategoryID)
    {
        Adapter.UpdateCategories(Name, Description, Original_CategoryID);
    }

   
}
