using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using SoftProgBusiness.RRHH;
using SoftProgDomain.RRHH;

namespace SoftProgWA
{
    public partial class ListarEmpleados : System.Web.UI.Page
    {
        private EmpleadoBO boEmpleado;
        private BindingList<Empleado> empleados;
        protected void Page_Load(object sender, EventArgs e)
        {
            boEmpleado = new EmpleadoBO();
            empleados = boEmpleado.listarTodos();
            dgvEmpleados.DataSource = empleados;
            dgvEmpleados.DataBind();
        }

        protected void lbRegistrar_Click(object sender, EventArgs e)
        {
            Response.Redirect("RegistrarEmpleado.aspx");
        }

        protected void dgvEmpleados_RowDataBound(object sender, GridViewRowEventArgs e)
        {
            if (e.Row.RowType == DataControlRowType.DataRow)
            {
                e.Row.Cells[0].Text = DataBinder.Eval(e.Row.DataItem, "DNI").ToString();
                e.Row.Cells[1].Text = DataBinder.Eval(e.Row.DataItem, "Nombre").ToString() + " " + DataBinder.Eval(e.Row.DataItem, "ApellidoPaterno").ToString();
                e.Row.Cells[2].Text = ((Area)DataBinder.Eval(e.Row.DataItem, "Area")).Nombre;
            }
        }

        protected void dgvEmpleados_PageIndexChanging(object sender, GridViewPageEventArgs e)
        {
            dgvEmpleados.PageIndex = e.NewPageIndex;
            dgvEmpleados.DataBind();
        }
    }
}