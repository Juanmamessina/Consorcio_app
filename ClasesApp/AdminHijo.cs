using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace ClasesApp
{
    [Serializable]
    [XmlInclude(typeof(AdminHijo))]
    public class AdminHijo : UsuarioPadre
    {
        public AdminHijo()
        {
            
        }

        public AdminHijo(string nombre, string contraseña) : base(nombre, contraseña)
        {
            Nombre = nombre;
            Contraseña = contraseña;
        }
    }
}
