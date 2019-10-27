using System;
using System.Collections.Generic;

namespace SMS.BusinessLogic
{
    public class Fournisseur
    {
        public string Name { get; set; }
        public string ContactName { get; set; }
        public string Email { get; set; }
        public string LanguageChoice { get; set; }
        public List<Sandwich> Sandwichs { get; set; }
    }
}
