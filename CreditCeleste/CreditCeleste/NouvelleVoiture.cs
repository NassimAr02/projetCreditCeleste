using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CreditCeleste
{
    class NouvelleVoiture : Voiture
    {
        
        private string puissance { get; set; }
        private string age { get; set; }
        private string libeleNouvVoiture { get; set; }

        public NouvelleVoiture(string numImmat, DateTime dateImmat, string numeroSerie, string libeleNouvVoiture, string age) : base(numImmat, dateImmat, numeroSerie)
        {
            this.libeleNouvVoiture = libeleNouvVoiture;
            this.age = age;
        }
        public NouvelleVoiture(string numImmat, DateTime dateImmat, string numeroSerie, string libeleNouvVoiture, string puissance, string age) : base( numImmat, dateImmat, numeroSerie)
        {
            this.libeleNouvVoiture = libeleNouvVoiture;
            this.puissance = puissance;
            this.age = age;
        }
       
        public string LibeleNouvVoiture
        {
            get { return libeleNouvVoiture; }
            set { libeleNouvVoiture = value; }
        }
        public string Puissance
        {
            get { return puissance; }
            set { puissance = value;  }
        }
        public string Age
        {
            get { return age; }
            set { age = value; }
        }
    }
}
