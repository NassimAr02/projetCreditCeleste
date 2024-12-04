using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CreditCeleste
{
    internal class Assert
    {
        public static string estVrai(object ent, object verif, string message)
        {
            if (!ent.Equals(verif))
            {
                return message + Environment.NewLine + "Valeur attendue : " + ent + " valeur calculée : " + verif;
            }
            else
            {
                return "";
            }
        }
    }

}