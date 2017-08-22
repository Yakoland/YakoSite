using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication4.usandoentitiframework
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        private NorthwindEntities db = new NorthwindEntities();
        protected void Page_Load(object sender, EventArgs e)
        {
            actualizarlista();
        }
        public void actualizarlista() {
            ListView1.Items.Clear();
            var query = from x in db.Customers select new { x.CompanyName, x.Fax};
                ListView1.DataSource = query;
                ListView1.DataBind();
        }

    }
}