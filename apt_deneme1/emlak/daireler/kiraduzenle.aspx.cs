using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace apt_deneme1.emlak.daireler
{
    public partial class kiraduzenle : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["Username"] == null || Session["Password"] == null)
            {
                Response.Redirect("../index.aspx");
            }

        }
    }
}