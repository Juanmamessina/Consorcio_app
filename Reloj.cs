using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppConsorcio
{
    public class Reloj
    {
        // Delegado para el evento de cambio de hora
        public delegate void HoraCambiadaEventHandler(object sender, EventArgs e);

        // Evento de cambio de hora
        public event HoraCambiadaEventHandler HoraCambiada;

        // Propiedad para almacenar la hora actual
        private DateTime horaActual;

        // Propiedad pública para acceder a la hora actual
        public DateTime HoraActual
        {
            get { return horaActual; }
            private set
            {
                if (horaActual != value)
                {
                    horaActual = value;

                    // Disparar el evento de cambio de hora
                    OnHoraCambiada(EventArgs.Empty);
                }
            }
        }

        // Método para disparar el evento de cambio de hora
        protected virtual void OnHoraCambiada(EventArgs e)
        {
            HoraCambiada?.Invoke(this, e);
        }

        // Constructor
        public Reloj()
        {
            // Inicializar la hora actual
            HoraActual = DateTime.Now;

            // Configurar el temporizador para actualizar la hora cada segundo
            System.Windows.Forms.Timer timer = new System.Windows.Forms.Timer();
            timer.Interval = 1000; // 1000 milisegundos = 1 segundo
            timer.Tick += Timer_Tick;
            timer.Start();
        }

        // Método que se ejecuta cada vez que el temporizador hace tic
        private void Timer_Tick(object sender, EventArgs e)
        {
            // Actualizar la hora
            HoraActual = DateTime.Now;
        }
    }
}
