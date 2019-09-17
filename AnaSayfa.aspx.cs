using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class AnaSayfa : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    protected void btnEkle_Click(object sender, EventArgs e)
    {
        Response.Redirect("ogrenciEkle.aspx");
    }

    protected void btnstaj_Click(object sender, EventArgs e)
    {
        Response.Redirect("stajEkle.aspx");
    }

    protected void btndegerlendirme_Click(object sender, EventArgs e)
    {
        Response.Redirect("stajdegerlendirme.aspx");
    }

    protected void btnkomisyon_Click(object sender, EventArgs e)
    {
        Response.Redirect("komisyonekle.aspx");
    }

    protected void btnmulakat_Click(object sender, EventArgs e)
    {
        Response.Redirect("mulakat.aspx");
    }

    protected void btnbitenler_Click(object sender, EventArgs e)
    {
        Response.Redirect("stajibitenler.aspx");
    }

    protected void btntariharaligi_Click(object sender, EventArgs e)
    {
        Response.Redirect("tariharaligi.aspx");
    }

    protected void btnogrencibilgileri_Click(object sender, EventArgs e)
    {
        Response.Redirect("ogrencibilgileri.aspx");
    }
}
