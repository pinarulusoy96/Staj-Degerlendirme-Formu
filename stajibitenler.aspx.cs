using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;
using System.IO;

public partial class stajibitenler : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    protected void ImageButton1_Click(object sender, ImageClickEventArgs e)
    {
        Response.Redirect("stajibitenlerPDF.aspx");
    }

    protected void ImageButton2_Click(object sender, ImageClickEventArgs e)
    {
        Response.ClearContent();
        Response.AppendHeader("content-disposition", "attachement;filename=stajibitenlerlistesi.xls");
        Response.ContentType = "application/excel";
        StringWriter sw = new StringWriter();
        HtmlTextWriter ht = new HtmlTextWriter(sw);
        Grid.HeaderRow.Style.Add("background-color", "#FFFFFF");
        foreach (TableCell tableCell in Grid.HeaderRow.Cells)
        {
            tableCell.Style["background-color"] = "#FFFFFF";
        }
        foreach (GridViewRow gridViewRow in Grid.Rows)
        {
            gridViewRow.BackColor = System.Drawing.Color.White;
            foreach (TableCell gridViewRowTableCell in gridViewRow.Cells)
            {
                gridViewRowTableCell.Style["background-color"] = "#FFFFFF";
            }
        }
        Grid.RenderControl(ht);
        Response.Write(sw.ToString());
        Response.End();
    }
    public override void VerifyRenderingInServerForm(Control control)
    {

    }
}
