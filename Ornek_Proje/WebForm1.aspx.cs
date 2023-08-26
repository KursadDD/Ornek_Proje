using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Ornek_Proje.Siniflar;

namespace Ornek_Proje
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        Context c = new Context();
        protected void Page_Load(object sender, EventArgs e)
        {
            var kisilistesi = c.Kisilers.ToList();
            Repeater1.DataSource = kisilistesi;
            Repeater1.DataBind();
        }
    }
}