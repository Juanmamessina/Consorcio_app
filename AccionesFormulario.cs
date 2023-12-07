using System;
using System.Linq;
using System.Windows.Forms;

namespace AppConsorcio
{
    public static class AccionesFormulario<T> where T : System.Windows.Forms.Form
    {
        public static void CerrarFormulario()
        {
            T formulario = Application.OpenForms.OfType<T>().FirstOrDefault();

            if (formulario != null)
            {
                formulario.Close();
            }
        }
    }
}
