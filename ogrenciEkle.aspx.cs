using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;

public partial class ogrenciEkle : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }
    int ogretim;
    SqlConnection baglanti = new SqlConnection("Integrated Security=True;Data Source=DESKTOP-JDM7566;Initial Catalog=veritabani");
    protected void btnEkle_Click(object sender, EventArgs e)
    {
        SqlCommand komut;
        komut = new SqlCommand("INSERT INTO ogrencibilgileri (ogradi,ogrsoyadi,ogrnumara,ogrsinif,ogrogretim) VALUES(@adi, @soyadi,@numara,@sinif,@ogretim)", baglanti);

        try
        {
           
            komut.Parameters.AddWithValue("@adi", txtAd.Text);
            komut.Parameters.AddWithValue("@soyadi", txtsoyad.Text);
            komut.Parameters.AddWithValue("@numara", Convert.ToInt32(txtnumara.Text));
            komut.Parameters.AddWithValue("@sinif", Convert.ToInt32(txtsinif.Text));

            if (RadioButton1.Checked == true)
            {
                ogretim = 1;
            }
            if (RadioButton2.Checked == true)
            {
                ogretim = 2;
            }
            komut.Parameters.AddWithValue("@ogretim", ogretim);
            baglanti.Open();
            komut.ExecuteNonQuery();
            baglanti.Close();
            Label3.Text = "ÖGRENCİ BAŞARIYLA EKLENDİ";

        }
        catch (Exception)
        {
            Label3.Text = "BU NUMARAYA AİT ÖGRENCİ VARDIR";
        }





    }

    protected void RadioButtonList1_SelectedIndexChanged(object sender, EventArgs e)
    {

    }

    protected void Buttongit_Click(object sender, EventArgs e)
    {
        Response.Redirect("stajEkle.aspx");
    }
}
