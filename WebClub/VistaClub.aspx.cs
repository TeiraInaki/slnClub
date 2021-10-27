using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

using Datos.Admin;
using Datos.Models;

namespace WebClub
{
    public partial class VistaClub : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack)
            {
                LlenarGrid();
                LlenarDdl();
            }
        }

        private void LlenarGrid()
        {
            gridJugadores.DataSource = AdmJugador.Listar();
            gridJugadores.DataBind();
        }

        private void LlenarDdl()
        {
            DataTable dt = AdmPuesto.Listar();
            ddlPuesto.DataSource = dt;
            ddlPuesto.DataTextField = dt.Columns["Nombre"].ToString();
            ddlPuesto.DataValueField = dt.Columns["Nombre"].ToString();
            ddlPuesto.DataBind();

            DataRow fila = dt.NewRow();
            fila["Nombre"] = "[TODAS]";
            dt.Rows.InsertAt(fila, 0);
            ddlBuscarPorPuesto.DataSource = dt;
            ddlBuscarPorPuesto.DataTextField = dt.Columns["Nombre"].ToString();
            ddlBuscarPorPuesto.DataValueField = dt.Columns["Nombre"].ToString();
            ddlBuscarPorPuesto.DataBind();
        }

        protected void btnGuardar_Click(object sender, EventArgs e)
        {
            Jugador jugador = new Jugador()
            {
                Nombre=txtNombre.Text,
                Apellido=txtApellido.Text,
                FechaNacimiento=Convert.ToDateTime(txtFechaNacimiento.Text),
                Puesto=ddlPuesto.SelectedValue
            };

            int filasAfectadas = AdmJugador.Insertar(jugador);

            if (filasAfectadas>0)
            {
                LlenarGrid();
            }
        }

        protected void btnModificar_Click(object sender, EventArgs e)
        {
            Jugador jugador = new Jugador()
            {
                Id = Convert.ToInt32(txtId.Text),
                Nombre = txtNombre.Text,
                Apellido = txtApellido.Text,
                FechaNacimiento = Convert.ToDateTime(txtFechaNacimiento.Text),
                Puesto = ddlPuesto.SelectedValue
            };

            int filasAfectadas = AdmJugador.Modificar(jugador);

            if (filasAfectadas > 0)
            {
                LlenarGrid();
            }
        }

        protected void btnEliminar_Click(object sender, EventArgs e)
        {
            int filasAfectadas = AdmJugador.Eliminar(Convert.ToInt32(txtId.Text));

            if (filasAfectadas > 0)
            {
                LlenarGrid();
            }
        }

        protected void ddlBuscarPorPuesto_SelectedIndexChanged(object sender, EventArgs e)
        {
            string Seleccionado = ddlBuscarPorPuesto.SelectedValue;

            if (Seleccionado == "[TODAS]")
            {
                LlenarGrid();
            }
            else
            {
                gridJugadores.DataSource = AdmJugador.Listar(Seleccionado);
                gridJugadores.DataBind();
            }
        }
    }
}