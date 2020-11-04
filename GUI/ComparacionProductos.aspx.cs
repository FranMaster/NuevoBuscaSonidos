using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.HtmlControls;
using System.Web.UI.WebControls;

namespace GUI
{
    public partial class ComparacionProductos : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            string parametros = string.Empty;
            for (int i = 0; i < Request.QueryString.Count; i++)
            {
              parametros += Request.QueryString[i].ToString().Replace("%20" ," ")+',';
                CargarFront();
            }
            parametros.TrimEnd(',');
            
        }


        protected void CargarFront()
        {
            HtmlGenericControl DivContenedor = new HtmlGenericControl("div");
            DivContenedor.InnerHtml = "<div id='productos'> <div class='thumbnail'> <img src='...' alt='...'> <div class='caption'> <h3>Guitarra Tal</h3> <label >Precio</label> <label>Decripción</label> <p>Lorem ipsum dolor sit amet, consectetur adipisicing elit. Praesentium vitae corrupti quos porro? Cupiditate, reiciendis. Qui, quidem beatae. Quam quaerat fugit distinctio minima eos nulla, dicta ad eaque, officia praesentium quisquam ipsa aliquam quod excepturi autem sed accusantium quo fugiat facere voluptatem? Voluptate, nisi sit delectus ex architecto consequuntur quasi ratione deserunt reiciendis hic mollitia sequi vel numquam! Atque sint dolor eum voluptates ducimus facere voluptate, amet necessitatibus provident labore rerum eius ad. Omnis voluptates, sunt qui reiciendis sit, necessitatibus, quibusdam suscipit repellendus repudiandae debitis cum praesentium? Iste, impedit provident. Pariatur illo aliquam sit unde, minus quidem aut ducimus perspiciatis! </p> <p><a href='#' class='btn btn-primary' role='button'>Button</a> <a href='#' class='btn btn-default' role='button'>Button</a></p> </div> </div> </div>";
            this.Productos.Controls.Add(DivContenedor);            
        }








    }
}