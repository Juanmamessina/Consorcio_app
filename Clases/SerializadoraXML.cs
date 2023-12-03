using System;
using System.IO;
using System.Xml;
using System.Xml.Serialization;

namespace Clases
{
    internal class SerializadoraXML<T> : Serializador, ISerializable<T> where T : new()
    {

        public SerializadoraXML(string path) : base(path)
        {

        }

        public bool Serializar(List<T> datos)
        {
            using (var stream = new StringWriter())
            {
                if (stream != null)
                {
                    var xml = new XmlSerializer(typeof(List<T>));

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
                    var xml = new XmlSerializer(typeof(List<T>));

                    var listaDeserializada = xml.Deserialize(stream);

                    if (listaDeserializada != null)
                    {
                        lista = (List<T>)listaDeserializada;
                    }
                }
            }
            return lista;
        }

    }

}
        

