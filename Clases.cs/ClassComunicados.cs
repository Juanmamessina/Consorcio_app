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
            // asi se va a ver en el rtb
            return $"{Autor} - {Fecha.ToString("yyyy-MM-dd HH:mm")} - {Contenido}";
        }

    }


}
