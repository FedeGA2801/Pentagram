using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BE
{
    public class Sesion
    {
        private static Sesion _instancia;
        public Usuario usuario;
        // Otros datos de sesión que desees almacenar

        // Constructor privado para evitar instanciar desde fuera de la clase
        private Sesion()
        {
        }

        // Método estático para obtener la instancia única
        public static Sesion ObtenerInstancia()
        {
            if (_instancia == null)
            {
                _instancia = new Sesion();
            }
            return _instancia;
        }

        // Método para establecer los datos de sesión (nombre de usuario en este caso)
        public void IniciarSesion(Usuario user)
        {
            usuario = user;
            // Puedes establecer otros datos de sesión aquí si lo necesitas
        }

        // Método para cerrar sesión y restablecer los datos
        public void CerrarSesion()
        {
            usuario = null;
            // Restablecer otros datos de sesión si los tienes
        }

        public bool Logeado()
        {
            return _instancia.usuario != null;
        }
    }
}
