using AppConsorcio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using Newtonsoft.Json;

namespace ClasesApp
{
    public class MetodosUsuario : IOperacionesUsuario, ISerializable
    {
        public MetodosUsuario()
        {
            
        }
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
                string path = "C:\\Users\\Juanma\\Desktop\\AppConsorcioFinal\\Consorcio_app\\Datos.xml";

                ISerializable<Usuario> serializableUsuarios = new SerializadoraXML<Usuario>(path);

                // Deserializar la lista de usuarios del archivo XML
                List<Usuario> usuarios = serializableUsuarios.Deserializar();

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

            foreach (Usuario usuario in usuarios)
            {
                string nombre = usuario.Nombre;
                string contraseña = usuario.Contraseña;

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
