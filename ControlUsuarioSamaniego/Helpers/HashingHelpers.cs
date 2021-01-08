using System.Security.Cryptography;
using System.Text;

namespace ControlUsuarioSamaniego.Helpers
{
    public static class HashingHelpers
    {
        public static string GetHelper(string cadena)
        {
            var alg = SHA256.Create();
            byte[] codificar = Encoding.UTF8.GetBytes(cadena);
            byte[] hash = alg.ComputeHash(codificar);
            string a = "";
            foreach (var objeto in hash)
            {
                a += objeto.ToString("x2");
            }
            return a;
        }
    }
}