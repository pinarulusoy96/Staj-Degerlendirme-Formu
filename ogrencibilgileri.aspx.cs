using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;


public partial class ogrencibilgileri : System.Web.UI.Page
{
    DataTable dt = new DataTable();
    protected void Page_Load(object sender, EventArgs e)
    {
        
        dt.Columns.AddRange(new DataColumn[10] { new DataColumn("ogrnumara"), new DataColumn("ogradi"), new DataColumn("ogrsoyadi"), new DataColumn("kurumadi"), new DataColumn("sehir"), new DataColumn("toplamgün"), new DataColumn("baslamatarihi"), new DataColumn("bitistarihi"), new DataColumn("stajkonusu"), new DataColumn("kabuledilengun") });

        if (ViewState["bilgiler"] != null)
        //www.aspnetornekleri.com
        {
            dt = (DataTable)ViewState["bilgiler"];
            GridView1.DataSource = dt;
            GridView1.DataBind();
        }
    }
    SqlConnection baglanti = new SqlConnection("Integrated Security=True;Data Source=DESKTOP-JDM7566;Initial Catalog=veritabani");

    protected void Button1_Click1(object sender, EventArgs e)
    {
        dt.Rows.Clear();
        SqlCommand sorgu2 = new SqlCommand("SELECT DISTINCT S.[ogrnumara],O.[ogradi],O.[ogrsoyadi],S.[kurumadi],S.[sehir],S.[toplamgün],S.[baslamatarihi],S.[bitistarihi],S.[stajkonusu],S.[kabuledilengun] FROM [stajekle] S ,[ogrencibilgileri] O,[mulakat] M WHERE O.[ogrnumara]=S.[ogrnumara] AND S.[ogrnumara]=@ogrnumara AND S.[mulakatdurumu]=1", baglanti);
        sorgu2.Parameters.AddWithValue("@ogrnumara", Convert.ToInt32(TextBox1.Text));
        baglanti.Open();
        SqlDataReader oku = sorgu2.ExecuteReader();
        while (oku.Read())
        {

            string numara = oku[0].ToString();
            string ad = oku[1].ToString();
            string soyad = oku[2].ToString();
            string kurumadi = oku[3].ToString();
            string sehir = oku[4].ToString();
            string toplamgün = oku[5].ToString();
            string baslamatarihi = oku[6].ToString();
            string bitistarihi = oku[7].ToString();
            string stajkonusu = oku[8].ToString();
            string kabuledilengun = oku[9].ToString();
            dt.Rows.Add(numara, ad, soyad, kurumadi, sehir, toplamgün, baslamatarihi, bitistarihi, stajkonusu, kabuledilengun);
            ViewState["bilgiler"] = dt;
            GridView1.DataSource = dt;
            GridView1.DataBind();
        }
        

        oku.Close();
        baglanti.Close();

    }
}
