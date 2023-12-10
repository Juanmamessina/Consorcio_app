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
            string contraseñaIngresada = "m";

            bool resultado = metodosUsuario.ValidarUsuario(usuarioIngresado, contraseñaIngresada);

            Assert.IsTrue(resultado);
        }

        [TestMethod]
        public void ValidarUsuarioCreado()
        {
            MetodosAdministrador metodosAdministrador = new MetodosAdministrador();

            string nombreUsuarioNuevo = "j";
            string contraseñaUsuarioNuevo = "k";

            bool resultado = metodosAdministrador.CrearUsuario(nombreUsuarioNuevo, contraseñaUsuarioNuevo);

            Assert.IsTrue(resultado);
        }
    }
}