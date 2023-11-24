using System.Xml.Linq;
using System.Xml.Serialization;
using Clases;
using Newtonsoft.Json;




namespace AppConsorcio
{
    [Serializable]
    [XmlRoot("usuarios")]
    public class Usuario : IOperacionesUsuario
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

            Dictionary<string, List<Reclamo>> reclamosDict = new Dictionary<string, List<Reclamo>>();

            // Cargar el diccionario de reclamos existente desde el archivo JSON
            if (File.Exists("reclamos.json"))
            {
                string json = File.ReadAllText("reclamos.json");
                reclamosDict = JsonConvert.DeserializeObject<Dictionary<string, List<Reclamo>>>(json);
            }

            // Crear un nuevo reclamo
            Reclamo nuevoReclamo = new Reclamo
            {
                Contenido = contenido,
                Fecha = DateTime.Now,
            };

            // Agregar el nuevo reclamo a la lista de reclamos del usuario actual
            if (!reclamosDict.ContainsKey(nombreUsuarioActual))
            {
                reclamosDict[nombreUsuarioActual] = new List<Reclamo>();
            }
            reclamosDict[nombreUsuarioActual].Add(nuevoReclamo);

            // Guardar el diccionario completo de reclamos en el archivo JSON
            string jsonUpdated = JsonConvert.SerializeObject(reclamosDict);
            File.WriteAllText("reclamos.json", jsonUpdated);

            return true; // Devuelvo true para indicar que el reclamo se publicó con éxito
        }




    }






}

