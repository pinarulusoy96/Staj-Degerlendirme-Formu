using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;

public partial class stajekle : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }
    protected void Calendar1_DayRender(object sender, DayRenderEventArgs e)
    {
        string script = "javascript:passDateValue('" + Request.QueryString["ctlid"] + "','" + e.Day.Date.ToString("MM/dd/yyyy") + "')";

        e.Cell.Text = "<a href=\"" + script + "\">" + e.Day.Date.Day.ToString() + "</a>";
    }

    SqlConnection baglanti = new SqlConnection("Integrated Security=True;Data Source=DESKTOP-JDM7566;Initial Catalog=veritabani");
    private object stajid;

    protected void Button3_Click(object sender, EventArgs e)
    {
        int numara = Convert.ToInt32(TextBox3.Text);
        SqlCommand sorgu = new SqlCommand("SELECT * FROM ogrencibilgileri WHERE ogrnumara=@user ", baglanti);
        sorgu.Parameters.Add("@user", SqlDbType.VarChar).Value =numara;
       
        baglanti.Open();
        SqlDataReader oku = sorgu.ExecuteReader();
        
        while (oku.Read())
        {
            Label1.Visible = true;
            Label2.Visible = true;
            Label3.Visible = true;
            Label4.Visible = true;
            Label1.Text= oku[0].ToString();
            Label2.Text = oku[1].ToString();
            Label3.Text = oku[3].ToString();
            Label4.Text = oku[4].ToString();
        }
        oku.Close();
        baglanti.Close();
    }

    protected void Button1_Click(object sender, EventArgs e)
    {

    }

    protected void Button2_Click(object sender, EventArgs e)
    {

    }
    
    protected void btn8_Click(object sender, EventArgs e)
    {
        int numara = Convert.ToInt32(TextBox3.Text);
        string kurum = txtkurum.Text;
        int toplamgun = Convert.ToInt32(TextBox4.Text);
        int sinif = Convert.ToInt32(Label3.Text);
        if(sinif==1)
        {
            Page.ClientScript.RegisterClientScriptBlock(this.GetType(), "Başlık", "<script>alert('1.sınıf öğrencileri staj yapamaz');</script>");
        }
        if(sinif==2)
        {
            if(toplamgun>=15 && toplamgun<=25)
            {
                ekle(numara);
            }
            else
            {
                Page.ClientScript.RegisterClientScriptBlock(this.GetType(), "Başlık", "<script>alert('2.sınıf öğrencileri 15 gün ile 25 gün arasında staj yapabilir');</script>");
            }
        }
        if(sinif>2)
        {
            if(RadioButton1.Checked)
            {
                var kurumvarligi = kurumbelirle(numara, kurum);
                if(kurumvarligi)
                {
                    if(toplamgun>=15 && toplamgun<=40)
                    {
                        ekle(numara);
                    }
                    else
                    {
                        Page.ClientScript.RegisterClientScriptBlock(this.GetType(), "Başlık", "<script>alert('daha önce aynı kurumda staj yaptığınız için bu kurumda en az 15 en fazla 40 gün staj yapabilirsiniz');</script>");
                    }
                }
                else
                {
                    if(toplamgun>=15 && toplamgun<=60)
                    {
                        ekle(numara);
                    }
                    else
                    {
                        Page.ClientScript.RegisterClientScriptBlock(this.GetType(), "Başlık", "<script>alert('arge de en az 15 gün en fazla 60 gün staj yapabilirsiniz');</script>");
                    }

                }
                
            }
            else
            {
                string kurumadi = Convert.ToString(kurumbelirle(numara, kurum));
                if (kurumadi == "true")
                {
                    if (toplamgun >= 15 && toplamgun <= 40)
                    {
                        ekle(numara);
                    }
                    else
                    {
                        Page.ClientScript.RegisterClientScriptBlock(this.GetType(), "Başlık", "<script>alert('daha önce aynı kurumda staj yaptığınız için bu kurumda en az 15 en fazla 40 gün staj yapabilirsiniz');</script>");
                    }
                }
                else
                {
                    if (toplamgun >= 15 && toplamgun <= 40)
                    {
                        ekle(numara);
                    }
                    else
                    {
                        Page.ClientScript.RegisterClientScriptBlock(this.GetType(), "Başlık", "<script>alert('bir kurumda en az 15 gün en fazla 40 gün staj yapabilirsiniz');</script>");
                        
                    }

                }
            }
        }
        

    }

    static bool kurumbelirle(int ogrnumara, string kurum)
    {
        SqlConnection baglanti = new SqlConnection("Integrated Security=True;Data Source=DESKTOP-JDM7566;Initial Catalog=veritabani");
        SqlCommand sorgu = new SqlCommand("SELECT kurumadi FROM stajekle WHERE ogrnumara=@number and kurumadi=@kurum ", baglanti);
        sorgu.Parameters.Add("@number", SqlDbType.VarChar).Value = ogrnumara;
        sorgu.Parameters.Add("@kurum", SqlDbType.VarChar).Value = kurum;
        baglanti.Open();
        string sonuc;
        if(sorgu.ExecuteScalar()==null)
        {
            sonuc = "0";
        }
        else
        {
            sonuc = sorgu.ExecuteScalar().ToString();
        }
        baglanti.Close();
        if (sonuc == "0")
            return false;
        else
            return true;
    }
    void ekle(int ogrnumara)
    {
        int durum = 0;
        int kabul = 0;
        int mulakat = 0;
        SqlConnection baglanti = new SqlConnection("Integrated Security=True;Data Source=DESKTOP-JDM7566;Initial Catalog=veritabani");
        SqlCommand komut;
        komut = new SqlCommand("INSERT INTO stajekle (ogrnumara,kurumadi,sehir,baslamatarihi,bitistarihi,toplamgün,stajkonusu,kabuledilengun,durum,mulakatdurumu)VALUES(@numara,@kurum,@sehir,@basla,@bitis,@toplam,@konu,@kabul,@durum,@mulakat)", baglanti);
       komut.Parameters.AddWithValue("@numara",Convert.ToInt32(TextBox3.Text));
        komut.Parameters.AddWithValue("@kurum",txtkurum.Text);
        komut.Parameters.AddWithValue("@sehir", txtsehir.Text);
        komut.Parameters.AddWithValue("@basla", Convert.ToDateTime(TextBox1.Text));
        komut.Parameters.AddWithValue("@bitis", Convert.ToDateTime(TextBox2.Text));
        komut.Parameters.AddWithValue("@toplam", Convert.ToInt32(TextBox4.Text));
        komut.Parameters.AddWithValue("@konu", stajkonusu.Text);
        komut.Parameters.AddWithValue("@kabul", kabul);
        komut.Parameters.AddWithValue("@durum", durum);
        komut.Parameters.AddWithValue("@mulakat", mulakat);
        baglanti.Open();
        komut.ExecuteNonQuery();
        baglanti.Close();
        Label5.Text = "ÖGRENCİ STAJI BAŞARIYLA EKLENDİ";
        Label5.Visible = true;

    }

    protected void txtsehir_SelectedIndexChanged(object sender, EventArgs e)
    {
       
    }

    protected void ImageButton1_Click(object sender, ImageClickEventArgs e)
    {
        Response.Redirect("AnaSayfa.aspx");
    }
}
