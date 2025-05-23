using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SoftProgDomain.RRHH;
using SoftProgPersistance.RRHH.DAO;
using SoftProgPersistance.RRHH.Impl;

namespace SoftProgBusiness.RRHH
{
    public class EmpleadoBO
    {
        private EmpleadoDAO daoEmpleado;
        private AreaDAO daoArea;

        public EmpleadoBO()
        {
            daoEmpleado = new EmpleadoImpl();
            daoArea = new AreaImpl();
        }

        public Empleado obtenerEmpleadoPorID(int idEmpleado)
        {
            Empleado empleado = daoEmpleado.obtenerPorId(idEmpleado);
            empleado.Area = daoArea.obtenerPorId(empleado.Area.IdArea);
            return empleado;
        }

        public int insertar(Empleado empleado)
        {
            return daoEmpleado.insertar(empleado);
        }

        public int modificar(Empleado empleado) { 
            return daoEmpleado.modificar(empleado);
        }

        public int eliminar(int idEmpleado)
        {
            return daoEmpleado.eliminar(idEmpleado);
        }

        public BindingList<Empleado> listarTodos()
        {
            return daoEmpleado.listarTodos();
        }
    }
}
