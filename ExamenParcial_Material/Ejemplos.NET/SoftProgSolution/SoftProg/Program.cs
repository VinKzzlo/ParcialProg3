using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SoftProgBusiness.RRHH;
using SoftProgDomain.RRHH;

namespace SoftProg
{
    public class Program
    {
        static void Main(string[] args)
        {
            //System.Console.WriteLine("Mi primer programa en C#");
            //Area area = new Area();
            //area.Nombre = "WAAA";
            AreaBO boArea = new AreaBO();
            BindingList<Area> areasDB = boArea.listarTodos();
            foreach (Area a in areasDB)
                System.Console.WriteLine(a.IdArea + ". " + a.Nombre);

            Empleado empleado = new Empleado();
            empleado.Nombre = "MANUEL";
            empleado.DNI = "28762111";
            empleado.ApellidoPaterno = "TUPIA";
            empleado.Area = areasDB[0];
            empleado.Genero = 'M';
            empleado.Cargo = "PROFESOR ALGORITMOS AVANZADOS";
            empleado.Sueldo = 2500.00;
            empleado.FechaNacimiento =
                new DateTime(1993, 03, 19);


            EmpleadoBO boEmpleado = new EmpleadoBO();

            int resultado = boEmpleado.insertar(empleado);
            if (resultado != 0)
            {
                System.Console.WriteLine("Se ha registrado correctamente");
            }

            //Empleado emp = boEmpleado.obtenerEmpleadoPorId(2);

        }
    }
}
