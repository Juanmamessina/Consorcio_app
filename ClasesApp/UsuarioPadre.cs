using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace ClasesApp
{
    [Serializable]
    [XmlInclude(typeof(Usuario))]
    [XmlInclude(typeof(AdminHijo))]

    public  abstract class UsuarioPadre
    {
        private string nombre;
        private string contraseña;
        public string categoria;

        public string Nombre { get => nombre; set => nombre = value; }
        public string Contraseña { get => contraseña; set => contraseña = value; }

        public UsuarioPadre()
        {
            
        }

        public UsuarioPadre(string nombre, string contraseña, string categoria)
        {
            Nombre = nombre;
            Contraseña = contraseña;
            this.categoria = categoria;
        }

        public abstract string Categoria();
        
    }
}
