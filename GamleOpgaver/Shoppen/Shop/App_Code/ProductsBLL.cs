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
/// Summary description for ProductsBLL
/// </summary>
public class ProductsBLL
{
    private ProductsTableAdapter _productsAdapter = null;

    protected ProductsTableAdapter Adapter
    {
        get
        {
            if (_productsAdapter == null)
            {
                _productsAdapter = new ProductsTableAdapter();

            }
            return _productsAdapter;
        }
    }

    [System.ComponentModel.DataObjectMethodAttribute(System.ComponentModel.DataObjectMethodType.Select, true)]
    public Shop.ProductsDataTable GetProducts()
    {
        return Adapter.GetProducts();
    }

    [System.ComponentModel.DataObjectMethodAttribute(System.ComponentModel.DataObjectMethodType.Select, false)]
    public Shop.ProductsDataTable GetProductsByProductID(int ProductID)
    {
        return Adapter.GetProductsByProductID(ProductID);
    }

    [System.ComponentModel.DataObjectMethodAttribute(System.ComponentModel.DataObjectMethodType.Select, false)]
    public Shop.ProductsDataTable GetProductsByCategory(int CategoryID)
    {
        return Adapter.GetProductsByCategory(CategoryID);
    }

    //[System.ComponentModel.DataObjectMethodAttribute(System.ComponentModel.DataObjectMethodType.Select, false)]
    //public Shop.ProductsDataTable Top3()
    //{
    //    return Adapter.Top3();
    //}

    [System.ComponentModel.DataObjectMethodAttribute(System.ComponentModel.DataObjectMethodType.Delete, true)]
    public void DeleteProducts(int Original_ProductID)
    {
        Adapter.DeleteProducts(Original_ProductID);
    }

    [System.ComponentModel.DataObjectMethodAttribute(System.ComponentModel.DataObjectMethodType.Update, true)]
    public void UpdateProducts(string Name, string Description, decimal Price, string Image, string Category, int ProductID)
    {
        Adapter.UpdateProducts(Name, Description, Price, Image, Category, ProductID);
    }

    [System.ComponentModel.DataObjectMethodAttribute(System.ComponentModel.DataObjectMethodType.Insert, true)]
    public void InsertProducts(string Name, string Description, decimal Price, string Image, int Category)
    {
        Adapter.InsertProducts(Name, Description, Price, Image, Category);
    }

    [System.ComponentModel.DataObjectMethodAttribute(System.ComponentModel.DataObjectMethodType.Select, false)]
    public Shop.ProductsDataTable GetProductBySearch(string Name, string Description)
    {
       return Adapter.GetProductBySearch("%" + Name + "%", "%" + Description + "%");
    }
}
