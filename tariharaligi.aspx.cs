using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;


public partial class tariharaligi : System.Web.UI.Page
{
    DataTable dt = new DataTable();
    protected void Page_Load(object sender, EventArgs e)
    {
        dt.Columns.AddRange(new DataColumn[5] { new DataColumn("ogrnumara"), new DataColumn("ogradi"), new DataColumn("ogrsoyadi"), new DataColumn("toplamgün"), new DataColumn("kabuledilengun") });
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
        SqlCommand sorgu2 = new SqlCommand("SELECT S.[ogrnumara],O.[ogradi],O.[ogrsoyadi],S.[toplamgün],S.[kabuledilengun] FROM [stajekle] S ,[ogrencibilgileri] O,[mulakat] M WHERE O.[ogrnumara]=S.[ogrnumara] AND S.[stajid]=M.[stajid] AND M.mulakattarihi BETWEEN @tarih1 AND @tarih2", baglanti);
        sorgu2.Parameters.AddWithValue("@tarih1",Convert.ToDateTime(TextBox1.Text));
        sorgu2.Parameters.AddWithValue("@tarih2", Convert.ToDateTime(TextBox2.Text));
        baglanti.Open();
        SqlDataReader oku = sorgu2.ExecuteReader();
        while (oku.Read())
        {

            string numara = oku[0].ToString();
            string ad = oku[1].ToString();
            string soyad= oku[2].ToString();
            string toplamgun = oku[3].ToString();
            string kabuledilengun = oku[4].ToString();

            dt.Rows.Add(numara,ad,soyad,toplamgun,kabuledilengun);
            ViewState["bilgiler"] = dt;
            GridView1.DataSource = dt;
            GridView1.DataBind();

        }
        oku.Close();
        baglanti.Close();
    }
}
