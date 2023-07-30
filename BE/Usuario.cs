using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BE
{
    public class Usuario
    {
        private int _id { get; set; }
        private string _username { get; set; }
        private string _password { get; set; }
        private Credenciales _sec { get; set; }

        public Usuario(string username, string password)
        {
            _username = username;
            _password = password;
        }

        public int Id
        {
            get { return _id; }
            set { _id = value; }
        }

        public void CargarCredencialesCriptograficas(byte[] password, byte[] sal, int ite)
        {
            _sec = new Credenciales(password, sal, ite);
        }

        public string Username
        {
            get
            {
                return _username;
            }
        }

        public string Password
        {
            get { return _password; }
        }

        public byte[] PasswordCifrada
        {
            get
            {
                return _sec.Password;
            }
        }

        public Credenciales Credenciales
        {
            get { return _sec; }
        }
    }
}
