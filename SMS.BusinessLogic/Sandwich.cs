using System;
using System.Collections.Generic;
using System.Text;

namespace SMS.BusinessLogic
{
    public class Sandwich
    {
        public string NameFrench { get; set; }
        public string NameEnglish { get; set; }
        public string NameDeutch { get; set; }
        public Fournisseur Fournisseur { get; set; }
        public List<Ingrédient> Ingrédients { get; set; }
    }
}
