using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Collections.Generic;

namespace MyApiMovie.Web
{
    public partial class Index : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            List<TheMovieDb.DO.Movie> movies = TheMovieDb.Core.SearchMovieByTitle(txtPelicula.Text);

            string html = string.Empty;
            foreach (var item in movies)
            {
                html+=string.Format(@"
                    <div>
                        <img src='{3}' title='{0}'/><br/>
                        <span><a href=#>{0}</a></span><br/>
                        <strong>Fecha:</strong><span>{1}<span> | <strong>Calificación:</strong><span>{2}<span><br/>
                        
                    </div>", item.Title,item.ReleaseDate,item.Popularity,item.PosterPath);
                
            }
            ltrResultado.Text = html;
        }
    }
}