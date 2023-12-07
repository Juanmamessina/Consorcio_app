using ClasesApp.Serializadoras;
using ClasesApp;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Windows.Forms;
using ClasesApp.Interfaces;
using ClasesApp.metodos;

namespace AppConsorcio.Forms
{
    public partial class Eventos : Form
    {
        private readonly string nombreUsuarioActual;

        public Eventos()
        {
            InitializeComponent();
            nombreUsuarioActual = FormLogIn.NombreUsuarioActual;
        }

        private void Eventos_Load(object sender, EventArgs e)
        {
            LoadTheme();
        }

        private void SetButtonColors(Control control)
        {
            foreach (Control ctrl in control.Controls)
            {
                if (ctrl is Button btn)
                {
                    btn.BackColor = ThemeColor.colorPrimario;
                    btn.ForeColor = Color.Black;
                    btn.FlatAppearance.BorderColor = ThemeColor.colorSecundario;
                }

                // Llamada recursiva para los controles anidados
                SetButtonColors(ctrl);
            }
        }

        private void LoadTheme()
        {
            SetButtonColors(this);
        }



        private void GuardarReservaEnArchivo(DateTime fecha)
        {
            string path = "reservas.txt";

            var serializadora = new SerializadoraTXT<Reserva>(path);
            List<Reserva> reservas = serializadora.Deserializar();

            // Crear un objeto que represente la reserva
            Reserva reserva = new Reserva
            {
                Fecha = DateTime.Now,
                NombreUsuario = nombreUsuarioActual,
                FechaReservada = fecha,
            };

            // Agregar la nueva reserva a la lista
            reservas.Add(reserva);

            // Utilizar la SerializadoraTXT para guardar las reservas actualizadas
            if (serializadora.Serializar(reservas))
            {
                MessageBox.Show("Reserva hecha exitosamente.");
            }
            else
            {
                MessageBox.Show("No se pudo realizar la reserva.");
            }

            DateTime fechaSeleccionada = monthCalendar.SelectionStart;
            DeshabilitarFechaEnCalendario(fechaSeleccionada);
        }


        private void DeshabilitarFechaEnCalendario(DateTime fecha)
        {
            // Deshabilitar la fecha seleccionada
            monthCalendar.AddBoldedDate(fecha);
            monthCalendar.UpdateBoldedDates();
        }

        private void CargarFechasReservadas()
        {
            string path = "reservas.txt";


            if (File.Exists(path))
            {
                // Deserializar en una lista de Reserva
                ISerializable<Reserva> serializableReservas = new SerializadoraTXT<Reserva>(path);
                List<Reserva> listaReservas = serializableReservas.Deserializar();

                if (listaReservas != null && listaReservas.Any())
                {
                    foreach (var reserva in listaReservas)
                    {
                        string reservaFormateada = reserva.ToString();
                        rtbReservas.AppendText($"{reservaFormateada}{Environment.NewLine}");
                    }
                }
                else
                {
                    rtbReservas.AppendText("No hay reservas hechas." + Environment.NewLine);
                }

                rtbReservas.Visible = true;
            }
            else
            {
                rtbReservas.AppendText("No hay reservas hechas." + Environment.NewLine);
                rtbReservas.Visible = true;
            }
        }

        private void btnAgendar_Click(object sender, EventArgs e)
        {
            DateTime fechaSeleccionada = monthCalendar.SelectionStart;

            // Verificar si ya hay una reserva para la fecha seleccionada
            if (FechaYaAgendada(fechaSeleccionada))
            {
                MessageBox.Show("La fecha ya fue agendada previamente, por favor seleccione otra fecha.", "Fecha ocupada", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                // Llamar a la función para agendar solo si la fecha no está ocupada
                GuardarReservaEnArchivo(fechaSeleccionada);
                DeshabilitarFechaEnCalendario(fechaSeleccionada);
            }
        }

        private bool FechaYaAgendada(DateTime fecha)
        {
            string path = "reservas.txt";

            if (File.Exists(path))
            {
                // Deserializar en una lista de Reserva
                ISerializable<Reserva> serializableReservas = new SerializadoraTXT<Reserva>(path);
                List<Reserva> listaReservas = serializableReservas.Deserializar();

                // Verificar si ya hay una reserva para la fecha seleccionada
                return listaReservas?.Any(reserva => reserva.FechaReservada.Date == fecha.Date) ?? false;
            }

            return false;
        }

        private void btnConsultarEventos_Click(object sender, EventArgs e)
        {
            if (sender == btnConsultarEventos)
            {
                monthCalendar.Visible = false;
                btnAgendar.Visible = false;
                btnConsultarEventos.Visible = false;
                rtbReservas.Visible = true;

                // Solo cargar las fechas reservadas si el rtbReservas está visible
                CargarFechasReservadas();
            }
        }
    }
}




