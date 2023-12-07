using ClasesApp.Interfaces;
using ClasesApp.Serializadoras;
using ClasesApp;

public class SerializadoraTXT<T> : Serializador, ISerializable<T>
{
    public SerializadoraTXT(string path) : base(path)
    {
    }

    public List<T> Deserializar()
    {
        List<T> lista = new List<T>();

        try
        {
            var lines = File.ReadAllLines(Path);

            foreach (var line in lines)
            {
                var item = DeserializarLinea(line);
                lista.Add(item);
            }
        }
        catch (Exception ex)
        {
            Console.WriteLine(ex.ToString());
        }

        return lista;
    }

    private T DeserializarLinea(string linea)
    {
        if (typeof(T) == typeof(Reserva))
        {
            var partes = linea.Split(new[] { " - " }, StringSplitOptions.RemoveEmptyEntries);


            if (partes.Length == 3)
            {
                // Ajusta según tu lógica real para deserializar una línea a Reserva
                var reserva = new Reserva
                {
                    Fecha = DateTime.Parse(partes[0]), // Ajusta según el formato real
                    NombreUsuario = partes[1],
                    FechaReservada = DateTime.Parse(partes[2])
                };

                return (T)(object)reserva;
            }
        }

        return default;
    }

    public bool Serializar(List<T> datos)
    {
        try
        {
            File.WriteAllLines(Path, datos.Select(d => d.ToString()));
            return true;
        }
        catch (IOException ex)
        {
            Console.WriteLine(ex.Message);
            return false;
        }
    }
}

