﻿using System;
using System.Collections;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.HtmlControls;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;
using System.Xml.Linq;

public partial class Products_Products : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }
    protected void GridView1_SelectedIndexChanged(object sender, EventArgs e)
    {
        string Product = GridView1.SelectedDataKey[0].ToString();
        Response.Redirect("ProductDetail.aspx?ProductID=" + Product);
    }

    public string GenerateString(string input)
    {
        string newString = Tools.CropText(input, 30, false);
        return newString;
    }
}