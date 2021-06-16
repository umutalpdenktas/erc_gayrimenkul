using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

using System.Data.SqlClient;
using System.Data;
using System.IO;
using System.Configuration;
using System.Drawing;

namespace apt_deneme1.muhasebe.daireler
{
    public partial class ertugrul : System.Web.UI.Page
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

            baglanti.Open();
            komut = new SqlCommand("SELECT * FROM muhasebe WHERE muhasebe_id=@id");
            komut.Parameters.AddWithValue("@id", Request.QueryString["veri"].ToString());
            komut.Connection = baglanti;
            dr = komut.ExecuteReader();
            if (dr.Read())
            {
                Label1.Text = dr["muhasebe_isim"].ToString() + " " + dr["muhasebe_soyisim"].ToString();
            }
            baglanti.Close();

        }

        protected void ImageButton1_Click(object sender, ImageClickEventArgs e)
        {
            Session.Abandon();
            Response.Redirect("../index.aspx");
        }

        public override void VerifyRenderingInServerForm(Control control)
        {

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
    }
}