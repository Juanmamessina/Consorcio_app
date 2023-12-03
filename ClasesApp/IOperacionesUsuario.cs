using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClasesApp
{
    public interface IOperacionesUsuario
    {
        bool ValidarUsuario(string nombre, string contraseña);
        bool CambiarUsuarioYContraseña(string nuevoUsuarioIngresado, string nuevaContraseñaIngresada, string nombreUsuarioActual);
        bool PublicarReclamo(string contenido, string nombreUsuarioActual);
    }
}
