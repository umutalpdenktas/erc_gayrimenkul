using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

using System.Net;
using System.Net.Mail;

namespace apt_deneme1
{
    public partial class iletisim1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            try
            {
                MailMessage mail = new MailMessage();
                SmtpClient smtpServer = new SmtpClient("smtp.gmail.com");

                mail.From = new MailAddress("ercmenkul@gmail.com");
                mail.To.Add("ercmenkul@gmail.com");
                mail.Subject = TextBox2.Text + " Konu: " + TextBox3.Text;
                mail.Body = TextBox4.Text;

                smtpServer.Port = 587;
                smtpServer.Credentials = new System.Net.NetworkCredential("ercmenkul@gmail.com", "Ercmenkul12+");
                smtpServer.EnableSsl = true;

                smtpServer.Send(mail);
                Label1.Text = "Mailiniz başarıyla bize ulaştı.";
            }
            catch (Exception)
            {

                Label1.Text = "Hata";
            }
            
        }
    }
}