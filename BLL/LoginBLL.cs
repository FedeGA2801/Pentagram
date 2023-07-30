using BE;
using DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class LoginBLL
    {
        public bool Login(Usuario user)
        {
            //DigitoBLL digiBLL = new DigitoBLL();
            //digiBLL.RecalcularDigitos();
            //List<Tuple<string, string>> errores = digiBLL.VerificarIntegridadGeneral();
            if (true)
            {
                //Registro en bitacora el login
                BitacoraBLL bitacoraBLL = new BitacoraBLL();
                LoginDAL logDAL = new LoginDAL();
                //Gestiono login
                bool exitoSeguridad = logDAL.ObtenerCredencialesCriptograficas(user);
                if (exitoSeguridad)
                {
                    //userlog.setPasswordCifrada(contra);
                    //Voy con usuario y contraseña a buscar si los datos son correctos
                    logDAL.LoginUsuario(user);
                    /*
                    if (usuario != null)
                    {
                        //Seteo sesion
                        SesionUsuario.Login(usuario);
                        //Cargo Permisos
                        PermisosBLL permiBLL = new PermisosBLL();
                        IList<Componente> lista = permiBLL.ObtenerPermisosUser(SesionUsuario.GetInstance.Usuario);
                        if (lista.Count > 0)
                            SesionUsuario.GetInstance.Usuario.setPermisos(lista);
                        //Con los permisos, ahora me busco el idioma predefinido del usuario
                        IdiomaBLL idiomaBLL = new IdiomaBLL();
                        Idioma idioma = idiomaBLL.GetIdiomaUser(SesionUsuario.GetInstance.Usuario);
                        if (idioma != null)
                        {
                            //Cargo su diccionario
                            idiomaBLL.GetTraduccionesIdioma(idioma);
                        }
                        //Guardo idioma en sesionIdioma
                        SesionUsuario.CargarIdioma(idioma);

                        //Registro en bitacora el login
                        bitacoraBLL.RegistrarActividad("Se logeo en el sistema", SalasBE.Sistema.TipoEvento.Mensaje);

                        return true;
                    }
                    */
                }
                //bitacoraBLL.RegistrarActividadSinUser("Se intento loguear el usuario " + userlog.user + " en el sistema sin exito", SalasBE.Sistema.TipoEvento.Mensaje);
                return false;
            }
            else
            {
                //Tengo que analizar que causo el error
                //Si rompio el usuario
                /*if (errores.Count > 0 && errores.Any(x => x.Item1 == "Usuario"))
                {
                    throw new SalasExceptionMain("Error_INTEGRIDADUSUARIO", OrigenError.Negocio);
                }
                else
                {
                    if (errores.Count > 0 && errores.Any(x => x.Item1 == "DB"))
                    {
                        throw new SalasExceptionMain("Error_FALTADB", OrigenError.Negocio);
                    }
                    else
                    {
                        throw new SalasExceptionMain("Error_INTEGRIDADDB", OrigenError.Negocio);
                    }
                }*/
            }
        }
    }
}
