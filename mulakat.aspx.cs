using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;

public partial class mulakat : System.Web.UI.Page
{
    DataTable dt = new DataTable();
    protected void Page_Load(object sender, EventArgs e)
    {
        dt.Columns.AddRange(new DataColumn[2] { new DataColumn("numara"), new DataColumn("tarih") });
        if (ViewState["bilgiler"] != null)
        //www.aspnetornekleri.com
        {
            dt = (DataTable)ViewState["bilgiler"];
            GridView1.DataSource = dt;
            GridView1.DataBind();
        }

    }
    SqlConnection baglanti = new SqlConnection("Integrated Security=True;Data Source=DESKTOP-JDM7566;Initial Catalog=veritabani");
    protected void Button1_Click(object sender, EventArgs e)
    {
        try
        {
           

            int numara = Convert.ToInt32(TextBox1.Text);
            SqlCommand sorgu = new SqlCommand("SELECT stajid FROM stajekle WHERE ogrnumara=@user AND mulakatdurum=0 ", baglanti);
            sorgu.Parameters.Add("@user", SqlDbType.VarChar).Value = numara;
            baglanti.Open();
            string sonuc = sorgu.ExecuteScalar().ToString();
            baglanti.Close();

            int stajid = Convert.ToInt32(sonuc);
            SqlCommand sorgu2 = new SqlCommand("INSERT INTO mulakat (stajid,mulakattarihi) VALUES (@stajid,@mulakattarihi) ", baglanti);
            sorgu2.Parameters.AddWithValue("@mulakattarihi", Convert.ToDateTime(TextBox2.Text));
            sorgu2.Parameters.AddWithValue("@stajid", stajid);
            baglanti.Open();
            sorgu2.ExecuteNonQuery();
            baglanti.Close();
            dt.Rows.Add(TextBox1.Text, TextBox2.Text);
            ViewState["bilgiler"] = dt;
            GridView1.DataSource = dt;
            GridView1.DataBind();
        }
        catch (Exception)
        {

            Page.ClientScript.RegisterClientScriptBlock(this.GetType(), "Başlık", "<script>alert('ALANLAR BOŞ GEÇİLEMEZ');</script>");

        }



    }
}
