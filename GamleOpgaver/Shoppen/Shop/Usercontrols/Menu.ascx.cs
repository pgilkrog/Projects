using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Usercontrols_Menu : System.Web.UI.UserControl
{
    protected void Page_Load(object sender, EventArgs e)
    {
        CategoryBLL cat = new CategoryBLL();
        ProductsBLL prod = new ProductsBLL();

        Table menu = new Table();

        foreach (Shop.CategoriesRow categoriesRow in cat.GetCategory())
        {
            if (categoriesRow.Name != null)
            {
                TableRow catRow = new TableRow();
                menu.Rows.Add(catRow);
                TableCell catCell = new TableCell();
                LinkButton lnkCategory = new LinkButton();
                lnkCategory.ID = lnkCategory + categoriesRow.CategoryID.ToString();
                lnkCategory.Text = categoriesRow.Name;
                lnkCategory.PostBackUrl = "~/Products/Products.aspx?cat=" + categoriesRow.CategoryID;
                lnkCategory.CssClass = "MenuLinks";
                Image imgMenu = new Image();
                imgMenu.ImageUrl = "~/Images/visit.gif";
                Table prodMenu = new Table();
                foreach (Shop.ProductsRow productRow in prod.GetProductsByCategory(categoriesRow.CategoryID))
                {
                    TableRow prodRow = new TableRow();
                    menu.Rows.Add(prodRow);
                    TableCell prodCell = new TableCell();
                    Literal TabLit = new Literal();
                    TabLit.Text = "&nbsp;";
                    prodCell.Controls.Add(TabLit);
                    LinkButton lnkProduct = new LinkButton();
                    lnkProduct.ID = lnkProduct + productRow.ProductID.ToString();
                    lnkProduct.Text = productRow.Name;
                    lnkProduct.PostBackUrl = "~/Products/ProductDetail.aspx?ProductID=" + productRow.ProductID;
                    lnkProduct.CssClass = "MenuLinks";
                    Image imgprodMenu = new Image();
                    imgprodMenu.ImageUrl = "~/Images/visit.gif";
                    prodCell.Controls.Add(imgprodMenu);
                    prodCell.Controls.Add(lnkProduct);
                    prodRow.Cells.Add(prodCell);
                    prodMenu.Rows.Add(prodRow);
                }

                catCell.Controls.Add(imgMenu);
                catCell.Controls.Add(lnkCategory);
                catCell.Controls.Add(prodMenu);
                catRow.Cells.Add(catCell);
            }
            this.Controls.Add(menu);
        }
    }
}
