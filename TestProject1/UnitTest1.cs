using ClasesApp.metodos;

namespace TestProject1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void ValidacionLogIn()
        {
            MetodosUsuario metodosUsuario = new MetodosUsuario();

            string usuarioIngresado = "j";
            string contrase�aIngresada = "m";

            bool resultado = metodosUsuario.ValidarUsuario(usuarioIngresado, contrase�aIngresada);

            Assert.IsTrue(resultado);
        }

        [TestMethod]
        public void ValidarUsuarioCreado()
        {
            MetodosAdministrador metodosAdministrador = new MetodosAdministrador();

            string nombreUsuarioNuevo = "j";
            string contrase�aUsuarioNuevo = "k";

            bool resultado = metodosAdministrador.CrearUsuario(nombreUsuarioNuevo, contrase�aUsuarioNuevo);

            Assert.IsTrue(resultado);
        }
    }
}