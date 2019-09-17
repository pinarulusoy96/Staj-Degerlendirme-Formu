using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;
public partial class login : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }
    SqlConnection baglanti = new SqlConnection("Integrated Security=True;Data Source=DESKTOP-JDM7566;Initial Catalog=veritabani");
    protected void btnGiris_Click(object sender, EventArgs e)
    {
        string user = txtAd.Text; string password = txtSifre.Text;
        var error = errorMessage(user, password);
        if(error)
        {
            SqlCommand sorgu = new SqlCommand("SELECT * FROM login WHERE kullaniciadi=@user AND sifre=@password", baglanti);
            sorgu.Parameters.Add("@user", SqlDbType.VarChar).Value = txtAd.Text;
            sorgu.Parameters.Add("@password", SqlDbType.VarChar).Value = txtSifre.Text;
            baglanti.Open();

            SqlDataReader oku = sorgu.ExecuteReader();
            if (oku.Read())
            {
                Response.Redirect("AnaSayfa.aspx");
            }
            else
            {
                Page.ClientScript.RegisterClientScriptBlock(this.GetType(), "Başlık", "<script>alert('hatalı giriş');</script>");
            }
            oku.Close();
            baglanti.Close();
        }
        else
        {
            Page.ClientScript.RegisterClientScriptBlock(this.GetType(), "Başlık", "<script>alert('alanlar boş geçilemez');</script>");
        }
    }
    static bool errorMessage(string _user, string _password)
    {

        if (string.IsNullOrEmpty(_user) || string.IsNullOrEmpty(_password))
            return false;
        else
            return true;
    }
}

