using System;
using System.IO;
using System.Xml;
using System.Xml.Serialization;

namespace ClasesApp
{
    public class SerializadoraXML<T> : Serializador, ISerializable<T> where T : class
    {
        public SerializadoraXML()
        {
            
        }
        public SerializadoraXML(string path) : base(path)
        {
            Path = path;
        }

        public bool Serializar(List <T> datos)
        {
            List<T> lista;
            if(File.Exists(Path))
            {
                lista = Deserializar();
            }
            else 
            {
                lista = new List<T>();
            }

            lista.AddRange(datos);

            using (StreamWriter stream = new StreamWriter(Path))
            {
                if (stream != null)
                {
                    XmlSerializer xml = new XmlSerializer(typeof(List<T>));
                    xml.Serialize(stream, datos);
                }
                return true;
            }
        }

        public List<T> Deserializar()
        {
            var lista = new List<T>();

            using (var stream = new StreamReader(Path))
            {
                if (stream != null)
                {
                    XmlSerializer xml = new XmlSerializer(typeof(List<T>));
                    lista = (List<T>)xml.Deserialize(stream);
                }
            }
            return lista;
        }


    }

}
        

