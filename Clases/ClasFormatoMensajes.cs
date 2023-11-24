namespace AppConsorcio
{
    public class FormatoMensajes
    {
        public string Contenido { get; set; }
        public string Autor { get; set; }
        public DateTime Fecha { get; set; }

        public override string ToString()
        {
            // asi se va a ver en el listBox
            return $"{Fecha.ToString("yyyy-MM-dd HH:mm")} - {Contenido}";
        }
    }
}