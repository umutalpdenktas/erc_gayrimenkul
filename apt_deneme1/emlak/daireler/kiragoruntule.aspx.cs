using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

using System.Data.SqlClient;
using System.IO;

namespace apt_deneme1.emlak.daireler
{
    public partial class kiragoruntule : System.Web.UI.Page
    {
        SqlConnection baglanti = new SqlConnection("Data Source=DESKTOP-Q87M83C\\SQLEXPRESS;Initial Catalog=apartman_sistem;Integrated Security=True");
        SqlCommand komut;
        SqlDataReader dr;

        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["Username"] == null || Session["Password"] == null)
            {
                Response.Redirect("../index.aspx");
            }

            vericek();

        }

        void vericek()
        {
            baglanti.Open();
            komut = new SqlCommand("SELECT * FROM daireler WHERE daire_gid=@veri");
            komut.Parameters.AddWithValue("@veri", Request.QueryString["veri"]);
            komut.Connection = baglanti;
            dr = komut.ExecuteReader();
            if (dr.Read())
            {
                Label2.Text = dr["daire_aptid"].ToString() + " Nolu Daire Kira Bilgileri";
            }
        }

        protected void ImageButton1_Click(object sender, ImageClickEventArgs e)
        {
            Session.Abandon();
            Response.Redirect("../index.aspx");
        }

        void ExportToExcel()
        {
            if (GridView1.Rows.Count > 0)
            {
                /*  Response.Clear();
                  Response.Buffer = true;
                  Response.AppendHeader("content-disposition", "attachment; filename=myfile.xls");
                  Response.Charset = "UTF-8";
                  Response.ContentType = "application/vnd.openxmlformats-officedocument.spreadsheetml.sheet"; */

                Response.Clear();
                Response.Buffer = true;
                Response.AddHeader("content-disposition", "attachment;filename=Test.xls");
                Response.ContentType = "application/ms-excel";
                Response.ContentEncoding = System.Text.Encoding.Unicode;
                Response.BinaryWrite(System.Text.Encoding.Unicode.GetPreamble());

                StringWriter sw = new StringWriter();
                GridView1.HeaderRow.Style.Add("background-color", "#fff");
                GridView1.HeaderRow.Style.Add("color", "#000");
                GridView1.HeaderRow.Style.Add("font-weight", "bold");

                for (int i = 0; i < GridView1.Rows.Count; i++)
                {
                    GridViewRow grow = GridView1.Rows[i];
                    grow.BackColor = System.Drawing.Color.White;
                    grow.Attributes.Add("class", "textmode");
                }

                using (HtmlTextWriter hw = new HtmlTextWriter(sw))
                {
                    GridView1.RenderControl(hw);
                    Response.Output.Write(sw.ToString());
                    Response.Flush();
                    Response.End();
                }

            }
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            ExportToExcel();
        }

        public override void VerifyRenderingInServerForm(Control control)
        {

        }

    }
}