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
    public class AreaBO
    {
        private AreaDAO daoArea;

        public AreaBO() { 
            daoArea = new AreaImpl();
        }

        public BindingList<Area> listarTodos()
        {
            return daoArea.listarTodos();
        }

        public int insertar(Area area)
        {
            int resultado = 0;
            if(area.Nombre == "")
            {
                throw new Exception("Debe ingresar el nombre");
            }
            resultado = daoArea.insertar(area);
            return resultado;
        }

        public int modificar(Area area)
        {
            int resultado = 0;
            if (area.Nombre == "")
            {
                throw new Exception("Debe ingresar el nombre");
            }
            resultado = daoArea.modificar(area);
            return resultado;
        }

        public int eliminar(int area) { 
            return daoArea.eliminar(area);
        }
    }
}
