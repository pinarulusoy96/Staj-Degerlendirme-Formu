using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class popuptakvim : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    protected void Calendar1_SelectionChanged(object sender, EventArgs e)
    {

    }

    protected void Calendar1_DayRender(object sender, DayRenderEventArgs e)
    {
        string script = "javascript:passDateValue('" + Request.QueryString["ctlid"] + "','" + e.Day.Date.ToString("dd/MM/yyyy") + "')";

        e.Cell.Text = "<a href=\"" + script + "\">" + e.Day.Date.Day.ToString() + "</a>";
    }

    protected void Calendar2_DayRender(object sender, DayRenderEventArgs e)
    {
        string script = "javascript:passDateValue('" + Request.QueryString["ctlid"] + "','" + e.Day.Date.ToString("dd/MM/yyyy") + "')";

        e.Cell.Text = "<a href=\"" + script + "\">" + e.Day.Date.Day.ToString() + "</a>";
    }
}
