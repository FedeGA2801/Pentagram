using BE;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Services
{
    public class Encriptacion
    {
        public const string AESKey = "NvcPDboKaCA0uOzHH4MuKaqeIiYmxcAH";
        public const string IV = "6smmaXQd4zyATQTU";
        public const int SALT_SIZE = 30; // tamaño en bytes
        public const int HASH_SIZE = 30; // tamaño en bytes

        /// <summary>
        /// Funcion para crear un hash en base a un string, una sal y una cantidad de iteraciones especifica.
        /// Utilizada en el login.
        /// </summary>
        public static byte[] CrearSal()
        {
            // Genero Sal unica
            RNGCryptoServiceProvider provider = new RNGCryptoServiceProvider();
            byte[] salt = new byte[SALT_SIZE];
            provider.GetBytes(salt);

            return salt;
        }

        public static int GenerarIteraciones()
        {
            Random rnd = new Random();
            return rnd.Next(5000, 10000);
        }

        /// <summary>
        /// Funcion para crear un hash en base a un string, una sal y una cantidad de iteraciones especifica.
        /// Utilizada en el login.
        /// </summary>
        public static byte[] CrearHashPBKDF2(string input, byte[] sal, int itera)
        {
            // Genero Hash
            Rfc2898DeriveBytes pbkdf2 = new Rfc2898DeriveBytes(input, sal, itera);
            return pbkdf2.GetBytes(HASH_SIZE);
        }

        public static string EncriptarStringSimetrico(string plainText)
        {
            byte[] array;

            using (Aes aes = Aes.Create())
            {
                byte[] key = Encoding.UTF8.GetBytes(AESKey);
                byte[] iv = Encoding.UTF8.GetBytes(IV);
                aes.Key = key;
                aes.IV = iv;

                ICryptoTransform encryptor = aes.CreateEncryptor(aes.Key, aes.IV);

                using (MemoryStream memoryStream = new MemoryStream())
                {
                    using (CryptoStream cryptoStream = new CryptoStream((Stream)memoryStream, encryptor, CryptoStreamMode.Write))
                    {
                        using (StreamWriter streamWriter = new StreamWriter((Stream)cryptoStream))
                        {
                            streamWriter.Write(plainText);
                        }

                        array = memoryStream.ToArray();
                    }
                }
            }

            return Convert.ToBase64String(array);
        }

        public static string DesencriptarStringSimetrico(string cipherText)
        {
            byte[] buffer = Convert.FromBase64String(cipherText);

            using (Aes aes = Aes.Create())
            {
                aes.Key = Encoding.UTF8.GetBytes(AESKey);
                aes.IV = Encoding.UTF8.GetBytes(IV);
                ICryptoTransform decryptor = aes.CreateDecryptor(aes.Key, aes.IV);

                using (MemoryStream memoryStream = new MemoryStream(buffer))
                {
                    using (CryptoStream cryptoStream = new CryptoStream((Stream)memoryStream, decryptor, CryptoStreamMode.Read))
                    {
                        using (StreamReader streamReader = new StreamReader((Stream)cryptoStream))
                        {
                            return streamReader.ReadToEnd();
                        }
                    }
                }
            }
        }
    }
}
