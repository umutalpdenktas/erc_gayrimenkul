using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

using System.Data.SqlClient;

namespace apt_deneme1.emlak
{
    public partial class index : System.Web.UI.Page
    {
        SqlConnection baglanti = new SqlConnection("Data Source=DESKTOP-Q87M83C\\SQLEXPRESS;Initial Catalog=apartman_sistem;Integrated Security=True");
        SqlCommand komut;
        SqlDataReader dr;

        SqlConnection baglanti2 = new SqlConnection("Data Source=DESKTOP-Q87M83C\\SQLEXPRESS;Initial Catalog=apartman_sistem;Integrated Security=True");
        SqlCommand komut2;
        SqlDataReader dr2;

        

        protected void Page_Load(object sender, EventArgs e)
        {

            if (Session["Username"] == null || Session["Password"] == null)
            {
                Response.Redirect("../index.aspx");
            }
            string gelenveri = Request.QueryString["veri"].ToString();
            baglanti.Open();
            komut = new SqlCommand("SELECT * FROM emlak WHERE emlak_id=@id");
            komut.Parameters.AddWithValue("@id", gelenveri);
            komut.Connection = baglanti;
            dr = komut.ExecuteReader();
            if (dr.Read())
            {
                Label1.Text = dr["emlak_isim"].ToString() + " " + dr["emlak_soyisim"].ToString();
            }
            baglanti.Close();


        }


        protected void ImageButton1_Click(object sender, ImageClickEventArgs e)
        {
            Session.Abandon();
            Response.Redirect("../index.aspx");
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            Response.Redirect("daireler/ertugrul.aspx?veri=1");
        }
    }
}