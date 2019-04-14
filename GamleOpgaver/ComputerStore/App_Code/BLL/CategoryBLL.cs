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
        public Computer.CategoriesDataTable GetCategory()
    {
        return Adapter.GetCategory();
    }

    [System.ComponentModel.DataObjectMethodAttribute(System.ComponentModel.DataObjectMethodType.Select, true)]
    public Computer.CategoriesDataTable GetCategoryByCategory(int CategoryID)
    {
        return Adapter.GetCategoryByCategory(CategoryID);
    }

    [System.ComponentModel.DataObjectMethodAttribute(System.ComponentModel.DataObjectMethodType.Delete, true)]
    public void DeleteCategory(int CategoryID)
    {
        Adapter.DeleteCategory(CategoryID);
    }

    [System.ComponentModel.DataObjectMethodAttribute(System.ComponentModel.DataObjectMethodType.Insert, true)]
    public void InsertCategory(string Name)
    {
        Adapter.InsertCategory(Name);
    }

    [System.ComponentModel.DataObjectMethodAttribute(System.ComponentModel.DataObjectMethodType.Update, true)]
    public void UpdateCategory(string Name, int Original_CategoryID)
    {
        Adapter.UpdateCategory(Name, Original_CategoryID);
    }
}
