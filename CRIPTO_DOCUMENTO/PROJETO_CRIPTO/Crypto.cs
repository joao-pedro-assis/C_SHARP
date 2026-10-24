using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Security.Cryptography;
namespace PROJETO_CRIPTO
{
    public class Crypto
    {
        public string Trava { get; set; }
        public string Codificar(string texto)
        {
            byte[] Results; // codificar em bytes
            UTF8Encoding UTF8 = new UTF8Encoding();
            MD5CryptoServiceProvider Provider = new MD5CryptoServiceProvider();
            byte[] Key = Provider.ComputeHash(UTF8.GetBytes(Trava));
            TripleDESCryptoServiceProvider algoritmo = new TripleDESCryptoServiceProvider();
            algoritmo.Key = Key;
            algoritmo.Mode = CipherMode.ECB;
            algoritmo.Padding = PaddingMode.PKCS7;
            try
            {
                byte[] dados = UTF8.GetBytes(texto);
                ICryptoTransform Encode = algoritmo.CreateEncryptor();
                Results = Encode.TransformFinalBlock(dados,0,dados.Length);
            }
            finally
            {
                algoritmo.Clear();
                Provider.Clear();
            }
            return Convert.ToBase64String(Results);
        }

        public string Decodificar(string Texto)
        {
            byte[] Results; // codificar em bytes
            UTF8Encoding UTF8 = new UTF8Encoding();
            MD5CryptoServiceProvider Provider = new MD5CryptoServiceProvider();
            byte[] Key = Provider.ComputeHash(UTF8.GetBytes(Trava));
            TripleDESCryptoServiceProvider algoritmo = new TripleDESCryptoServiceProvider();
            algoritmo.Key = Key;
            algoritmo.Mode = CipherMode.ECB;
            algoritmo.Padding = PaddingMode.PKCS7;
            try
            {
                byte[] dados = Convert.FromBase64String(Texto);
                ICryptoTransform dec = algoritmo.CreateDecryptor();
                Results = dec.TransformFinalBlock(dados, 0,dados.Length);
            }
            finally
            {
                Provider.Clear();
                algoritmo.Clear();
            }
            return UTF8.GetString(Results);
        }
    }
}
