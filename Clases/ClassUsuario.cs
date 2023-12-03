using System.IO;
using System.Runtime.Serialization;
using System.Xml.Linq;
using System.Xml.Serialization;
using Clases;
using Newtonsoft.Json;




namespace AppConsorcio
{
    [Serializable]
    [XmlRoot("usuarios")]
    public class Usuario : IOperacionesUsuario, ISerializable
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

        public bool ValidarUsuario(string nombre, string contraseña)
        {
            bool usuarioValido = false;

            // Valido que las entradas no estén vacías
            if (string.IsNullOrWhiteSpace(nombre) || string.IsNullOrWhiteSpace(contraseña))
            {
                usuarioValido = false;
            }
            else
            {
                // Cargar y analizar el archivo XML
                string xmlFilePath = "C:\\Users\\Juanma\\Desktop\\AppConsorcioFinal\\Consorcio_app\\Datos.xml";

                XDocument xmlDoc = XDocument.Load(xmlFilePath);

                // Obtener la lista de usuarios del XML
                List<Usuario> usuarios = new List<Usuario>();

                foreach (var usuarioElement in xmlDoc.Root.Elements("usuario"))
                {
                    string nombreXML = usuarioElement.Element("nombre").Value;
                    string contraseñaXML = usuarioElement.Element("contraseña").Value;

                    usuarios.Add(new Usuario { Nombre = nombreXML, Contraseña = contraseñaXML });
                }

                // Verificar si el usuario y la contraseña coinciden con los registros en el XML


                foreach (var usuario in usuarios)
                {
                    if (usuario.Nombre == nombre && usuario.Contraseña == contraseña)
                    {
                        usuarioValido = true;
                        break;
                    }
                }

            }
            return usuarioValido;
        }


        public bool CambiarUsuarioYContraseña(string nuevoUsuarioIngresado, string nuevaContraseñaIngresada, string nombreUsuarioActual)
        {
            // Valido que las entradas no estén vacías
            if (string.IsNullOrWhiteSpace(nuevoUsuarioIngresado) || string.IsNullOrWhiteSpace(nuevaContraseñaIngresada))
            {
                return false;
            }

            // Cargar y analizar el archivo XML
            string xmlFilePath = "C:\\Users\\Juanma\\Desktop\\AppConsorcioFinal\\Consorcio_app\\Datos.xml";

            XDocument xmlDoc = XDocument.Load(xmlFilePath);

            // Obtener la lista de usuarios del XML
            List<Usuario> usuarios = new List<Usuario>();

            foreach (var usuarioElement in xmlDoc.Root.Elements("usuario"))
            {
                string nombre = usuarioElement.Element("nombre").Value;
                string contraseña = usuarioElement.Element("contraseña").Value;

                usuarios.Add(new Usuario { Nombre = nombre, Contraseña = contraseña });
            }

            // Encuentra y modifica al usuario actual
            Usuario usuarioActual = usuarios.Find(u => u.Nombre == nombreUsuarioActual);
            Console.WriteLine(usuarioActual);
            if (usuarioActual != null)
            {
                // Modifica el nombre y la contraseña del usuario
                usuarioActual.Nombre = nuevoUsuarioIngresado;
                usuarioActual.Contraseña = nuevaContraseñaIngresada;

                // Guarda la información actualizada en el archivo XML
                xmlDoc.Root.Elements("usuario")
                    .First(u => u.Element("nombre").Value == nombreUsuarioActual)
                    .SetElementValue("nombre", nuevoUsuarioIngresado);

                xmlDoc.Root.Elements("usuario")
                    .First(u => u.Element("nombre").Value == nuevoUsuarioIngresado)
                    .SetElementValue("contraseña", nuevaContraseñaIngresada);

                xmlDoc.Save(xmlFilePath);

                return true;
            }
            else
            {
                // El usuario no fue encontrado
                return false;
            }
        }

        public bool PublicarReclamo(string contenido, string nombreUsuarioActual)
        {
            if (string.IsNullOrEmpty(contenido))
            {
                return false;
            }

            string path = "reclamos.json";
          

            // Verificar si el archivo existe
            if (File.Exists(path))
            {
                // Cargar la lista de reclamos existente desde el archivo JSON
                ISerializable<Reclamo> serializableReclamos = new SerializadoraJSON<Reclamo>(path);
                List<Reclamo> listaReclamos = serializableReclamos.Deserializar();

                // Crear un nuevo reclamo
                Reclamo nuevoReclamo = new Reclamo
                {
                    Contenido = contenido,
                    Autor = nombreUsuarioActual,
                    Fecha = DateTime.Now,
                };


                listaReclamos.Add(nuevoReclamo);


                try
                {
                    ISerializable<Reclamo> serializableReclamo = new SerializadoraJSON<Reclamo>(path);
                    serializableReclamo.Serializar(listaReclamos);

                    return true; // Devuelvo true para indicar que el reclamo se publicó con éxito
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"Error al escribir el archivo JSON: {ex.Message}");
                    return false;
                }
            }
            else
            {
                // Si el archivo no existe, crear uno nuevo con el reclamo actual
                List<Reclamo> listaReclamos = new List<Reclamo>();
                Reclamo nuevoReclamo = new Reclamo
                {
                    Contenido = contenido,
                    Autor = nombreUsuarioActual,
                    Fecha = DateTime.Now,
                };
                listaReclamos.Add(nuevoReclamo);

                try
                {
                    // Guardar la lista de reclamos en el nuevo archivo JSON
                    ISerializable<Reclamo> serializableReclamos = new SerializadoraJSON<Reclamo>(path);
                    serializableReclamos.Serializar(listaReclamos);
                    return true; // Devuelvo true para indicar que el reclamo se publicó con éxito
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"Error al escribir el archivo JSON: {ex.Message}");
                    return false;
                }
            }
        }


        public void GetObjectData(SerializationInfo info, StreamingContext context)
        {
            throw new NotImplementedException();
        }
    }






}

