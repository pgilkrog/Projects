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
    public Computer.ProductsDataTable GetProducts()
    {
        return Adapter.GetProducts();
    }

    [System.ComponentModel.DataObjectMethodAttribute(System.ComponentModel.DataObjectMethodType.Select, false)]
    public Computer.ProductsDataTable GetProductByProductID(int ProductID)
    {
        return Adapter.GetProductByProductID(ProductID);
    }

    [System.ComponentModel.DataObjectMethodAttribute(System.ComponentModel.DataObjectMethodType.Select, false)]
    public Computer.ProductsDataTable GetProductsByCategory(int CategoryID)
    {
        return Adapter.GetProductsByCategory(CategoryID);
    }

    [System.ComponentModel.DataObjectMethodAttribute(System.ComponentModel.DataObjectMethodType.Select, false)]
    public Computer.ProductsDataTable GetProductByRandom()
    {
        return Adapter.GetProductByRandom();
    }

    [System.ComponentModel.DataObjectMethodAttribute(System.ComponentModel.DataObjectMethodType.Select, false)]
    public Computer.ProductsDataTable GetProductsByNewest()
    {
        return Adapter.GetProductsByNewest();
    }

    [System.ComponentModel.DataObjectMethodAttribute(System.ComponentModel.DataObjectMethodType.Select, false)]
    public Computer.ProductsDataTable GetProductByPopular()
    {
        return Adapter.GetProductByPopular();
    }

    [System.ComponentModel.DataObjectMethodAttribute(System.ComponentModel.DataObjectMethodType.Delete, true)]
    public void DeleteProducts(int Original_ProductID)
    {
        Adapter.DeleteProducts(Original_ProductID);
    }

    [System.ComponentModel.DataObjectMethodAttribute(System.ComponentModel.DataObjectMethodType.Insert, true)]
    public void InsertProducts(string Name, string Description, string Facts, decimal Price, string Image, int Rating, int Category)
    {
        Adapter.InsertProducts(Name, Description, Facts, Price, Image, Rating, Category);
    }

    [System.ComponentModel.DataObjectMethodAttribute(System.ComponentModel.DataObjectMethodType.Update, true)]
    public void UpdateProducts(string Name, string Description, string Facts, decimal Price, string Image, int Rating, int CategoryID, int ProductID)
    {
        Adapter.UpdateProducts(Name, Description, Facts, Price, Image, Rating, CategoryID, ProductID);
    }

    [System.ComponentModel.DataObjectMethodAttribute(System.ComponentModel.DataObjectMethodType.Update, false)]
    public void UpdateProductsNo(string Name, string Description, string Facts, decimal Price, string Image, int Rating, int ProductID)
    {
        Adapter.UpdateProductsNo(Name, Description, Facts, Price, Image, Rating, ProductID);
    }

    [System.ComponentModel.DataObjectMethodAttribute(System.ComponentModel.DataObjectMethodType.Select, false)]
    public Computer.ProductsDataTable GetProductsBySearch(string Name, string Description)
    {
        return Adapter.GetProductsBySearch("%" + Name + "%", "%" + Description + "%");
    }
}