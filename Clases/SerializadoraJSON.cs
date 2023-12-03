using Clases;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace Clases
{
    public class SerializadoraJSON<T> : Serializador, ISerializable<T>
    {

        public SerializadoraJSON(string path) : base(path)
        {

        }

        public List<T> Deserializar()
        {
            List<T> lista = new List<T>();

            try
            {
                var json = File.ReadAllText(Path);
                lista = JsonConvert.DeserializeObject<List<T>>(json);
            }
            catch(Exception ex)  
            {
                Console.WriteLine(ex.ToString());
            }
            return lista;
        }

        public bool Serializar(List<T> datos)
        {
            try
            {
                using(var stream = new StreamWriter(Path, false))
                {
                   
                    var json = JsonConvert.SerializeObject(datos);
                    stream.Write(json);

                }
                return true;
            }
            catch(IOException ex) 
            {
                Console.WriteLine(ex.Message);
                return false;
            }
            catch (Newtonsoft.Json.JsonException ex) 
            {
                Console.WriteLine(ex.Message);
                return false;
            }
        }
    }

}
