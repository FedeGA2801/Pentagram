namespace BE
{
    public class Credenciales
    {
        private byte[] _passwordCifrada { get; set; }
        protected byte[] _sal { get; set; }
        protected int _iteraciones { get; set; }

        public Credenciales(byte[] password, byte[] sal, int iteraciones)
        {
            _passwordCifrada = password;
            _sal = sal;
            _iteraciones = iteraciones;
        }

        public byte[] Password
        {
            get { return _passwordCifrada; }
        }

        public byte[] Sal
        {
            get { return _sal; }
        }

        public int Iteraciones { get { return _iteraciones; } }
    }
}