using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;

public partial class stajdegerlendirme : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }
    SqlConnection baglanti = new SqlConnection("Integrated Security=True;Data Source=DESKTOP-JDM7566;Initial Catalog=veritabani");
    protected void Button50_Click(object sender, EventArgs e)
    {
        int numara = Convert.ToInt32(TextBox3.Text);
        SqlCommand sorgu = new SqlCommand("SELECT * FROM ogrencibilgileri WHERE ogrnumara=@user ", baglanti);
        sorgu.Parameters.Add("@user", SqlDbType.VarChar).Value = numara;
        baglanti.Open();
        SqlDataReader oku = sorgu.ExecuteReader();
        while (oku.Read())
        {
            Label1.Visible = true;
            Label2.Visible = true;
            Label3.Visible = true;
            Label4.Visible = true;
           
            Label1.Text = oku[0].ToString();
            Label2.Text = oku[1].ToString();
            Label3.Text = oku[3].ToString();
            Label4.Text = oku[4].ToString();
        }
        oku.Close();
        baglanti.Close();
        SqlCommand sorgu2 = new SqlCommand("SELECT * FROM stajekle WHERE ogrnumara=@user AND mulakatdurumu=0 ", baglanti);
        sorgu2.Parameters.Add("@user", SqlDbType.VarChar).Value = numara;
        baglanti.Open();
        SqlDataReader oku2 = sorgu2.ExecuteReader();
        if(oku2.Read())
        {
                Label5.Visible = true;
                Label6.Visible = true;
                Label7.Visible = true;
                Label8.Visible = true;
                Label9.Visible = true;
                Label10.Visible = true;

                Label5.Text = oku2[1].ToString();
                Label6.Text = oku2[2].ToString();
                Label7.Text = oku2[3].ToString();
                Label8.Text = oku2[4].ToString();
                Label9.Text = oku2[5].ToString();
                Label10.Text = oku2[6].ToString();

        
            oku2.Close();
            
        }
        else
        {
            Page.ClientScript.RegisterClientScriptBlock(this.GetType(), "Başlık", "<script>alert('bu öğrenciye ait değerlendirilecek staj bulunamamıştır');</script>");
        }
        baglanti.Close();
    }

    protected void btndegerlendir_Click(object sender, EventArgs e)
    {
        double num;
        num = Convert.ToInt32(txtdevam.Text) * (0.04)+ Convert.ToInt32(txtcalısma.Text) * (0.04)+ Convert.ToInt32(txtvakit.Text) * (0.04)+
            Convert.ToInt32(txtamir.Text) * (0.04)+ Convert.ToInt32(txtdavranis.Text) * (0.04)+ Convert.ToInt32(txtproje.Text) * (0.15)+
            Convert.ToInt32(txtduzen.Text) * (0.05)+ Convert.ToInt32(txtsunum.Text) * (0.05)+ Convert.ToInt32(txticerik.Text) * (0.15)+
            Convert.ToInt32(txtmulakat.Text) * (0.40);
        double staj = Convert.ToInt32(Label9.Text);
        int gun = Convert.ToInt32((staj * num) / 81);




        Label11.Visible = true;
       // Label11.Text = Convert.ToString(gun);
        int numara = Convert.ToInt32(TextBox3.Text);
        SqlCommand sorgu3 = new SqlCommand("SELECT kabuledilengun FROM stajekle WHERE ogrnumara=@user ", baglanti);
        sorgu3.Parameters.Add("@user", SqlDbType.VarChar).Value = numara;
        baglanti.Open();
        string sonuc = sorgu3.ExecuteScalar().ToString();
        baglanti.Close();

        int sonuc1 = Convert.ToInt32(sonuc);
        int mulakat = 1;

        sonuc1 =gun;
        
        baglanti.Open();
        SqlCommand sorgu4 = new SqlCommand("UPDATE stajekle SET kabuledilengun=@kabuledilengun,mulakatdurumu=@mulakatdurum WHERE ogrnumara=@user AND mulakatdurumu=0", baglanti);
        sorgu4.Parameters.Add("@user", SqlDbType.VarChar).Value = numara;
        sorgu4.Parameters.AddWithValue("@kabuledilengun",sonuc1);
        sorgu4.Parameters.AddWithValue("@mulakatdurum", mulakat);
        sorgu4.ExecuteNonQuery();
        baglanti.Close();
       
        SqlCommand sorgu5 = new SqlCommand("SELECT SUM (kabuledilengun) FROM stajekle WHERE mulakatdurumu=1 AND ogrnumara=@user ", baglanti);
        sorgu5.Parameters.Add("@user", SqlDbType.VarChar).Value = numara;
        string sonuc3;
        int sonuc2;
        baglanti.Open();
        SqlDataReader gunSayisiAl = sorgu5.ExecuteReader();
        if(gunSayisiAl.Read())
        {
            Label13.Text = gunSayisiAl[0].ToString();
            if(Convert.ToInt32(gunSayisiAl[0]) > 55)
            {
                gunSayisiAl.Close();
               // Label13.Text += " Kabul edildi";
                SqlCommand guncelle = new SqlCommand();
                guncelle.CommandText = "Update stajekle Set durum=1 where ogrnumara=@ogrnumara";
                guncelle.Parameters.AddWithValue("@ogrnumara", numara);
                guncelle.Connection = baglanti;
                guncelle.ExecuteNonQuery();
                baglanti.Close();
            }
        }
        else
        {
            Label13.Text = " Bulunamadı ";
        }


        baglanti.Close();
    }

    protected void ImageButton1_Click(object sender, ImageClickEventArgs e)
    {
        Response.Redirect("AnaSayfa.aspx");
    }
}
