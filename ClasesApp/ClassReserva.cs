using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClasesApp
{ 
    public class Reserva
    {
        public DateTime Fecha { get; set; }
        public string NombreUsuario { get; set; }
        public DateTime FechaReservada { get; set; }

        public override string ToString()
        {
            // Convertir la reserva a una cadena para la serialización en el archivo de texto
            return $"{Fecha} - {NombreUsuario} - {FechaReservada}";
        }

    }
}
