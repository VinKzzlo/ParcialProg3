using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using SoftProgBusiness.RRHH;
using SoftProgDomain.RRHH;

namespace SoftProgWA
{
    public partial class RegistrarEmpleado : System.Web.UI.Page
    {
        private AreaBO boArea;
        private EmpleadoBO boEmpleado;

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                boArea = new AreaBO();
                ddlAreas.DataSource = boArea.listarTodos();
                ddlAreas.DataTextField = "Nombre";
                ddlAreas.DataBind();
            }
        }

        protected void btnGuardar_Click(object sender, EventArgs e)
        {
            //boEmpleado = new EmpleadoBO();
            //boArea = new AreaBO();
            //Empleado objEmpleado = new Empleado();
            //Area objArea = new Area();
            //objEmpleado.Nombre = txtNombre.Text;
            //objEmpleado.ApellidoPaterno = txtApellidoPaterno.Text;
            //objEmpleado.
        }
    }
}