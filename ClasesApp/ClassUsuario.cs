using System.IO;
using System.Runtime.Serialization;
using System.Xml.Linq;
using System.Xml.Serialization;
using ClasesApp;
using Newtonsoft.Json;


namespace AppConsorcio
{
    [Serializable]
    [XmlInclude(typeof(Usuario))]
    public class Usuario
    {
        private string nombre;
        private string contraseña;

        public Usuario()
        {

        }

        public Usuario(string nombre, string contraseña)
        {
            this.nombre = nombre;
            this.contraseña = contraseña;
        }
        //ctor

        public string Nombre { get => nombre; set => nombre = value; }
        public string Contraseña { get => contraseña; set => contraseña = value; }


    }
}

