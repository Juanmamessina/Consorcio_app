using System;
using System.Xml.Serialization;

namespace AppConsorcio.Clases
{
    [Serializable]
    [XmlRoot("usuarios")]
    public class Usuario
    {
        public string nombre { get; set; }
        public string contraseña { get; set; }
    }
}
