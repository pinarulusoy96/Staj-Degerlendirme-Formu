using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;


public partial class komisyonekle : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }
    SqlConnection baglanti = new SqlConnection("Integrated Security=True;Data Source=DESKTOP-JDM7566;Initial Catalog=veritabani");
    protected void btnuyeekle_Click(object sender, EventArgs e)
    {
        SqlCommand komut;
        komut = new SqlCommand("INSERT INTO komisyonuye (unvan,ad,soyad) VALUES(@unvan,@adi, @soyadi)", baglanti);
        komut.Parameters.AddWithValue("@unvan", txtAd.Text);
        komut.Parameters.AddWithValue("@adi", txtsoyad.Text);
        komut.Parameters.AddWithValue("@soyadi", txtnumara.Text);
        baglanti.Open();
        komut.ExecuteNonQuery();
        Response.Redirect("komisyonekle.aspx");

    }

    protected void LinkButton1_Click(object sender, EventArgs e)
    {
        
    }

    protected void TextBox6_TextChanged(object sender, EventArgs e)
    {

    }

    protected void TextBox7_TextChanged(object sender, EventArgs e)
    {

    }

    protected void LinkButton2_Click(object sender, EventArgs e)
    {
        SqlDataSource2.InsertParameters["unvan"].DefaultValue = ((TextBox)GridView1.FooterRow.FindControl("unvan")).Text;
        SqlDataSource2.InsertParameters["ad"].DefaultValue = ((TextBox)GridView1.FooterRow.FindControl("ad")).Text;
        SqlDataSource2.InsertParameters["soyad"].DefaultValue = ((TextBox)GridView1.FooterRow.FindControl("soyad")).Text;
        SqlDataSource2.Insert();
    }
}
