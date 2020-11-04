using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace GUI
{
    public partial class ComparacionProductos : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            string parametros = string.Empty;
            for (int i = 0; i < Request.QueryString.Count; i++)
              parametros += Request.QueryString[i].ToString().Replace("%20" ," ")+',';
            parametros.TrimEnd(',');
            
        }








    }
}