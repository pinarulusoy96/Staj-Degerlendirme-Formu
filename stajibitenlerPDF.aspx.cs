using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.UI.HtmlControls;
using System.IO;
using iTextSharp.text;
using iTextSharp.text.pdf;
using iTextSharp.text.html.simpleparser;
using System.Text.RegularExpressions;

public partial class stajibitenler : System.Web.UI.Page
{
    public string RelativeToAbsoluteURLS(string text)
    {
        if (String.IsNullOrEmpty(text))
            return text;

        string absoluteUrl = Request.PhysicalApplicationPath;
        String value = Regex.Replace(text, "<(.*?)(src)=\"(?!http)(.*?)\"(.*?)>", "<$1$2=\"" + absoluteUrl + "$3\"$4>", RegexOptions.IgnoreCase | RegexOptions.Multiline);
        return value.Replace(absoluteUrl + "/", absoluteUrl);
    }
    protected void Page_Load(object sender, EventArgs e)
    {
       
        IEnumerable<int> data = Enumerable.Range(1, 4);
        
        Grid.DataBind();
        Label1.Text = DateTime.Now.ToString();
        Page p = new Page();
        HtmlForm f = new HtmlForm();
        f.Controls.Add(form1);
        p.Controls.Add(f);
        StringWriter sw = new StringWriter();
        HtmlTextWriter htw = new HtmlTextWriter(sw);
        f.Controls[0].RenderControl(htw);
        string content = sw.ToString();
        Document doc = new Document(iTextSharp.text.PageSize.A4);
        MemoryStream output = new MemoryStream();
        PdfWriter.GetInstance(doc, output);
        doc.Open();
        content = RelativeToAbsoluteURLS(content);
        List<IElement> dizi = HTMLWorker.ParseToList(new StringReader(content), null);
        
        foreach (var item in dizi)
            doc.Add(item);
        doc.Close();
        Response.Clear();
        // tarayıcıda göstermek için:
        Response.AddHeader("content-disposition", "inline;");
        // download ettirmek için:

        //Response.AddHeader("content-disposition", "attachment;filename=dosyaadi.pdf;");
        Response.ContentType = "application/pdf";
        Response.BinaryWrite(output.ToArray());
        Response.End();

    }
    public string TurkceKarakter(string text)
    {

        text = text.Replace("İ", "\u0130");

        text = text.Replace("ı", "\u0131");

        text = text.Replace("Ş", "\u015e");

        text = text.Replace("ş", "\u015f");

        text = text.Replace("Ğ", "\u011e");

        text = text.Replace("ğ", "\u011f");

        text = text.Replace("Ö", "\u00d6");

        text = text.Replace("ö", "\u00f6");

        text = text.Replace("ç", "\u00e7");

        text = text.Replace("Ç", "\u00c7");

        text = text.Replace("ü", "\u00fc");

        text = text.Replace("Ü", "\u00dc");

        return text;
    }
    public override void VerifyRenderingInServerForm(Control control)
    {

    }

}
