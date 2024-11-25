using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Security.Cryptography;

namespace CreditCeleste
{
    public static class MDPversMD5
    {
        public static string ConversionMD5(string mdp)
        {
            using (MD5 md5 = MD5.Create())
            {
                byte[] inputBytes = Encoding.UTF8.GetBytes(mdp);
                byte[] hashBytes = md5.ComputeHash(inputBytes);

                // Convertir le hash en une chaîne hexadécimale
                StringBuilder sb = new StringBuilder();
                for (int i = 0; i < hashBytes.Length; i++)
                {
                    sb.Append(hashBytes[i].ToString("x2")); // "x2" pour des caractères hexadécimaux en minuscules
                }
                return sb.ToString();
            }
        }

    }
}
