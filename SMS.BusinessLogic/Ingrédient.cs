using System;
using System.Collections.Generic;
using System.Text;

namespace SMS.BusinessLogic
{
    public class Ingrédient
    {
        public Ingrédient(NamesInAllLanguages translated, bool allergene)
        {
            Name = translated;
            Allergene = allergene;
        }

        public NamesInAllLanguages Name { get; set; }
        public bool Allergene { get; set; }

        public string ToString(Langue langue)
        {
            return Allergene ? Name.ToString(langue) + "*" : Name.ToString(langue);
        }
    }
}
