using GameSoftWA.Servicio;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace GameSoftWA
{
    /* Colocar los datos personales
     * ------------------------------------------------
     * Nombre Completo:
     * Codigo PUCP:
     * ------------------------------------------------
     */
    public partial class ListarVideojuegos : System.Web.UI.Page
    {
        private Servicio.VideojuegoWSClient daoVideojuego;
        private BindingList<Servicio.videojuego> videojuegos;
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                daoVideojuego = new VideojuegoWSClient();
                Servicio.videojuego[] videojuegosAux = daoVideojuego.listarVideojuegosPorNombre(txtNombre.Text);
                if(videojuegosAux != null)
                {
                    videojuegos = new BindingList<videojuego>(videojuegosAux.ToList());
                    gvVideojuegos.DataSource = videojuegos;
                    gvVideojuegos.DataBind();
                }
                
            }
        }

        protected void lbRegistrar_Click(object sender, EventArgs e)
        {
            Response.Redirect("RegistrarVideojuego.aspx");
        }

        protected void gvVideojuegos_RowDataBound(object sender, GridViewRowEventArgs e)
        {
            if (e.Row.RowType == DataControlRowType.DataRow)
            {
                e.Row.Cells[0].Text = DataBinder.Eval(e.Row.DataItem, "idVideojuego").ToString();
                e.Row.Cells[1].Text = DataBinder.Eval(e.Row.DataItem, "nombre").ToString();
                e.Row.Cells[2].Text = ((Servicio.genero)DataBinder.Eval(e.Row.DataItem, "genero")).nombre.ToString();
                e.Row.Cells[3].Text = DataBinder.Eval(e.Row.DataItem, "clasificacion").ToString();
            }
        }

        protected void lbBuscar_Click(object sender, EventArgs e)
        {
            daoVideojuego = new VideojuegoWSClient();
            Servicio.videojuego[] videojuegosAux = daoVideojuego.listarVideojuegosPorNombre(txtNombre.Text);
            if (videojuegosAux != null)
            {
                videojuegos = new BindingList<videojuego>(videojuegosAux.ToList());
                gvVideojuegos.DataSource = videojuegos;
                gvVideojuegos.DataBind();
            }
        }

        protected void lbVisualizar_Click(object sender, EventArgs e)
        {
            int idVideojuego = Int32.Parse(((LinkButton)sender).CommandArgument);
            Response.Redirect("RegistrarVideojuego.aspx?accion=ver&idVideojuego="+idVideojuego.ToString());
        }
    }
}