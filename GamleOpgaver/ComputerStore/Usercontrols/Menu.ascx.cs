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

        Table menu = new Table();

        foreach (Computer.CategoriesRow categoriesRow in cat.GetCategory())
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

                catCell.Controls.Add(imgMenu);
                catCell.Controls.Add(lnkCategory);
                catRow.Cells.Add(catCell);
            }
            this.Controls.Add(menu);
        }
    }
}
