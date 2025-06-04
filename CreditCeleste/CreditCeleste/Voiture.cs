using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CreditCeleste
{
    class Voiture
    {

        private string numImmat { get; set; }
        public DateTime dateImmat { get; set; }
        public string numeroSerie { get; set; }
        public Voiture( string numImmat,DateTime dateImmat, string numeroSerie)
        {
            this.numImmat = numImmat;
            this.dateImmat = dateImmat;
            this.numeroSerie = numeroSerie;
        }
        public string NumImmat
        {
            get { return numImmat; }
            set { numImmat = value; }
        }
        public DateTime DateImmat
        {
            get { return dateImmat; }
            set { dateImmat = value; }
        }
        public string NumeroSerie
        {
            get { return numeroSerie; }
            set { numeroSerie = value; }
        }

    }
}
