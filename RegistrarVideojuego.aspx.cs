using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace GameSoftWA
{
    /* Colocar sus datos personales
     * ------------------------------------------------
     * Nombre Completo:
     * Codigo PUCP:
     * ------------------------------------------------
     */

    public partial class RegistrarVideojuego : System.Web.UI.Page
    {
        private Servicio.GeneroWSClient daoGenero;
        private Servicio.VideojuegoWSClient daoVideojuego;
        private Servicio.videojuego videojuego;

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                daoGenero = new Servicio.GeneroWSClient();
                ddlGenero.DataSource = new BindingList<Servicio.genero>(daoGenero.listarGenerosTodos().ToList());
                ddlGenero.DataTextField = "nombre";
                ddlGenero.DataValueField = "idGenero";
                ddlGenero.DataBind();
            }
            String accion = Request.QueryString["accion"];
            String idVideojuego = Request.QueryString["idVideojuego"];
            if (accion != null && accion == "ver" && idVideojuego != null)
            {
                daoVideojuego = new Servicio.VideojuegoWSClient();
                lblTitulo.Text = "Visualizar Videojuego";
                videojuego = daoVideojuego.obtenerVideojuegoPorId(Int32.Parse(idVideojuego));
                txtIdVideojuego.Text = videojuego.idVideojuego.ToString();
                txtNombre.Text = videojuego.nombre;
                ddlGenero.SelectedValue = videojuego.genero.idGenero.ToString();
                dtpFechaLanzamiento.Value = videojuego.fechaLanzamiento.ToString("yyyy-MM-dd");
                txtCostoDesarrollo.Text = videojuego.costoDesarrollo.ToString("N2");
                if (videojuego.clasificacion == Servicio.clasificacion.EVERYONE) rbEveryone.Checked = true;
                else if (videojuego.clasificacion == Servicio.clasificacion.TEEN) rbTeen.Checked = true;
                else if (videojuego.clasificacion == Servicio.clasificacion.MATURE) rbMature.Checked = true;
                else if (videojuego.clasificacion == Servicio.clasificacion.ADULTSONLY) rbAdultsOnly.Checked = true;
                string base64String = Convert.ToBase64String(videojuego.foto);
                string imageUrl = "data:image/jpeg;base64," + base64String;
                imgFotoVideojuego.ImageUrl = imageUrl;
                deshabilitarCampos();
            }
            else
                lblTitulo.Text = "Registrar Videojuego";
            if (IsPostBack && fileUploadFotoVideojuego.PostedFile != null && fileUploadFotoVideojuego.HasFile)
            {
                string extension = System.IO.Path.GetExtension(fileUploadFotoVideojuego.FileName);
                if (extension.ToLower() == ".jpg" || extension.ToLower() == ".jpeg" || extension.ToLower() == ".png" || extension.ToLower() == ".gif")
                {
                    string filename = Guid.NewGuid().ToString() + extension;
                    string filePath = Server.MapPath("~/Uploads/") + filename;
                    fileUploadFotoVideojuego.SaveAs(Server.MapPath("~/Uploads/") + filename);
                    imgFotoVideojuego.ImageUrl = "~/Uploads/" + filename;
                    imgFotoVideojuego.Visible = true;
                    FileStream fs = new FileStream(filePath, FileMode.Open, FileAccess.Read);
                    BinaryReader br = new BinaryReader(fs);
                    Session["foto"] = br.ReadBytes((int)fs.Length);
                    fs.Close();
                }
                else
                {
                    Response.Write("Por favor, selecciona un archivo de imagen válido.");
                }
            }
        }

        protected void btnRegresar_Click(object sender, EventArgs e)
        {
            Response.Redirect("ListarVideojuegos.aspx");
        }

        public void deshabilitarCampos()
        {
            txtNombre.Enabled = false;
            ddlGenero.Enabled = false;
            dtpFechaLanzamiento.Disabled = true;
            txtCostoDesarrollo.Enabled = false;
            fileUploadFotoVideojuego.Enabled = false;
            rbEveryone.Disabled = true;
            rbTeen.Disabled = true;
            rbMature.Disabled = true;
            rbAdultsOnly.Disabled = true;
            btnGuardar.Visible = false;
        }

        protected void btnGuardar_Click(object sender, EventArgs e)
        {
            videojuego = new Servicio.videojuego();
            videojuego.nombre = txtNombre.Text;
            videojuego.foto = (byte[])Session["foto"];
            videojuego.genero = new Servicio.genero();
            videojuego.genero.idGenero = Int32.Parse(ddlGenero.SelectedValue);
            videojuego.fechaLanzamiento = DateTime.Parse(dtpFechaLanzamiento.Value);
            videojuego.fechaLanzamientoSpecified = true;
            videojuego.costoDesarrollo = Double.Parse(txtCostoDesarrollo.Text);
            if (rbEveryone.Checked) videojuego.clasificacion = Servicio.clasificacion.EVERYONE;
            else if (rbTeen.Checked) videojuego.clasificacion = Servicio.clasificacion.TEEN;
            else if (rbMature.Checked) videojuego.clasificacion = Servicio.clasificacion.MATURE;
            else if (rbAdultsOnly.Checked) videojuego.clasificacion = Servicio.clasificacion.ADULTSONLY;
            videojuego.clasificacionSpecified = true;
            daoVideojuego = new Servicio.VideojuegoWSClient();
            daoVideojuego.insertarVideojuego(videojuego);
            Response.Redirect("ListarVideojuegos.aspx");
        }
    }
}