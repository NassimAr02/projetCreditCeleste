using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CreditCeleste
{
    class AncienneVoiture : Voiture
    {
        private string libeleAncVoiture { get; set; }

        public AncienneVoiture (string numImmat, DateTime dateImmat, string numeroSerie, string libeleAncVoiture) : base(numImmat, dateImmat, numeroSerie)
        {
            this.libeleAncVoiture = libeleAncVoiture;
        }
        public string LibeleAncVoiture
        {
            get { return libeleAncVoiture;  }
            set { libeleAncVoiture = value; }
        }
        
    }
}
