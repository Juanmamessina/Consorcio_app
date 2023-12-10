using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;
using ClasesApp.Interfaces;
using ClasesApp.Serializadoras;

namespace ClasesApp.metodos
{
    public class MetodosAdministrador : IOperacionesAdministrador, ISerializable
    {
        public MetodosAdministrador()
        {

        }

        public bool EliminarUsuario(string nombreUsuarioAEliminar)
        {
            // Validar que las entradas no estén vacías
            if (string.IsNullOrWhiteSpace(nombreUsuarioAEliminar))
            {
                return false;
            }
            // Ruta del archivo XML
            string path = "C:\\Users\\Juanma\\Desktop\\CONSORCIOFINAL\\Consorcio_app\\Datos.xml";

            // Deserializar la lista actual de usuarios
            SerializadoraXML<Usuario> serializadora = new SerializadoraXML<Usuario>(path);
            List<Usuario> usuarios = serializadora.Deserializar();

            // Buscar el usuario en la lista
            Usuario usuarioAEliminar = usuarios.FirstOrDefault(u => u.Nombre == nombreUsuarioAEliminar);

            if (usuarioAEliminar != null)
            {
                usuarios.Remove(usuarioAEliminar);

                // Serializar la lista actualizada de usuarios al archivo XML
                serializadora.Serializar(usuarios);
            }
            return true;
        }

        public bool CrearUsuario(string nombreUsuarioNuevo, string contraseñaUsuarioNuevo)
        {
            string path = "C:\\Users\\Juanma\\Desktop\\CONSORCIOFINAL\\Consorcio_app\\Datos.xml";

            if (string.IsNullOrWhiteSpace(nombreUsuarioNuevo) || string.IsNullOrWhiteSpace(contraseñaUsuarioNuevo))
            {
                return false;
            }

            // Crear una instancia de la clase Usuario con los datos ingresados
            UsuarioPadre usuarioNuevo = new Usuario();
            usuarioNuevo.Nombre = nombreUsuarioNuevo;
            usuarioNuevo.Contraseña = contraseñaUsuarioNuevo;

            // Deserializar la lista actual de usuarios
            SerializadoraXML<Usuario> serializadora = new SerializadoraXML<Usuario>(path);
            List<Usuario> usuarios = serializadora.Deserializar();

            // Agregar el nuevo usuario a la lista
            usuarios.Add((Usuario)usuarioNuevo);

            DB.InsertUsuario((Usuario)usuarioNuevo);


            // Serializar la lista actualizada de usuarios al archivo XML
            serializadora.Serializar(usuarios);

            return true;
        }

        public void GetObjectData(SerializationInfo info, StreamingContext context)
        {
            throw new NotImplementedException();
        }
    }
}
