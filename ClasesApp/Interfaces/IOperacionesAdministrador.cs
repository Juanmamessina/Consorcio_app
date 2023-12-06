using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClasesApp.Interfaces
{
    public interface IOperacionesAdministrador
    {
        bool EliminarUsuario(string nombreUsuarioAEliminar);
        bool CrearUsuario(string nombreUsuarioNuevo, string contraseñaUsuarioNuevo);
    }
}
