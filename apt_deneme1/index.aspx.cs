using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

using System.Configuration;
using System.Data.SqlClient;

namespace apt_deneme1
{
    public partial class index : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        SqlConnection baglanti = new SqlConnection("Data Source=DESKTOP-Q87M83C\\SQLEXPRESS;Initial Catalog=apartman_sistem;Integrated Security=True");
        SqlCommand komut;
        SqlDataReader dr;

        SqlConnection baglanti2 = new SqlConnection("Data Source=DESKTOP-Q87M83C\\SQLEXPRESS;Initial Catalog=apartman_sistem;Integrated Security=True");
        SqlCommand komut2;
        SqlDataReader dr2;

        public static string gonderilecekveri;

        protected void Button1_Click(object sender, EventArgs e)
        {

            baglanti.Open();
            komut = new SqlCommand("SELECT * FROM muhasebe WHERE muhasebe_uname=@muname AND muhasebe_sifre=@msifre");
            komut.Parameters.AddWithValue("@muname", TextBox1.Text);
            komut.Parameters.AddWithValue("@msifre", TextBox2.Text);
            komut.Connection = baglanti;
            dr = komut.ExecuteReader();
            if(dr.Read())
            {
                gonderilecekveri = dr["muhasebe_id"].ToString();
                Session["Username"] = dr["muhasebe_uname"].ToString();
                Session["Password"] = dr["muhasebe_sifre"].ToString();
                Response.Redirect("muhasebe/index.aspx?veri="+gonderilecekveri);
                baglanti.Close();
            }  
            else
            {
                baglanti2.Open();
                komut2 = new SqlCommand("SELECT * FROM emlak WHERE emlak_uname=@euname AND emlak_sifre=@esifre");
                komut2.Parameters.AddWithValue("@euname", TextBox1.Text);
                komut2.Parameters.AddWithValue("@esifre", TextBox2.Text);
                komut2.Connection = baglanti2;
                dr2 = komut2.ExecuteReader();
                if (dr2.Read())
                {
                    gonderilecekveri = dr2["emlak_id"].ToString();
                    Session["Username"] = dr2["emlak_uname"].ToString();
                    Session["Password"] = dr2["emlak_sifre"].ToString();
                    Response.Redirect("emlak/index.aspx?veri="+gonderilecekveri);
                    baglanti.Close();
                }
                else
                {
                    Label1.Text = "Kullanıcı adını veya Şifreyi yanlış girdiniz!";
                    TextBox1.Text = "";
                    TextBox2.Text = "";
                }
                /*Label1.Text = "Kullanıcı Adını veya Şifreyi yanlış girdiniz!";
                TextBox1.Text = "";
                TextBox2.Text = "";*/
                
            }
            
            

            /*
            string emlakid = "emlak";
            string emlaksifre = "1234";

            string muhasebeid = "muhasebe";
            string muhasebesifre = "1234";

            if(TextBox1.Text == "emlak" && TextBox2.Text == "1234")
            {
                Session["UserName"] = TextBox1.Text;
                Session["Pwd"] = TextBox2.Text;
                Response.Redirect("emlak/index.aspx");
            }
            if(TextBox1.Text == "muhasebe" && TextBox2.Text == "1234")
            {
                Session["UserName"] = TextBox1.Text;
                Session["Pwd"] = TextBox2.Text;
                Response.Redirect("muhasebe/index.aspx");
            }
            */
        }

    }
}