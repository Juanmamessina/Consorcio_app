using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppConsorcio
{
    public class Comunicado
    {
        public string Contenido { get; set; }
        public string Autor { get; set; }
        public DateTime Fecha { get; set; }

        public override string ToString()
        {
            // Personaliza cómo se muestra un comunicado en el ComboBox
            return $"{Autor} - {Fecha.ToString("HH:mm")} - {Contenido}";
        }
    }


}
