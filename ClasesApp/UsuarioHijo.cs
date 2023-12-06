using System.IO;
using System.Runtime.Serialization;
using System.Xml.Linq;
using System.Xml.Serialization;
using ClasesApp;
using Newtonsoft.Json;



namespace ClasesApp
{
    [Serializable]
    [XmlInclude(typeof(Usuario))]
    public class Usuario : UsuarioPadre
    {
        public Usuario()
        {

        }

        public Usuario(string nombre, string contraseña, string categoria) : base(nombre, contraseña, categoria) 
        {
            Nombre = nombre;
            Contraseña = contraseña;
            categoria = "User";
        }

        public override string Categoria()
        {
            return categoria;
        }


        //public static bool operator ==(Usuario usuario, Type tipoUsuario)
        //{
        //    // Verificar si el usuario es nulo
        //    if (ReferenceEquals(usuario, null))
        //    {
        //        return false;
        //    }

        //    // Comparar el tipo de usuario con el tipo proporcionado
        //    return usuario.GetType() == tipoUsuario;
        //}

        //public static bool operator !=(Usuario usuario, Type tipoUsuario)
        //{
        //    return !(usuario == tipoUsuario);
        //}


    }
}

