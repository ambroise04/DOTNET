using System;
using System.Collections.Generic;
using System.Text;

namespace SMS.Domain
{
    public class Ingredient
    {
        public Ingredient(NamesInAllLanguages translated, bool allergene)
        {
            Name = translated;
            Allergene = allergene;
        }

        public int Id { get; set; }
        public NamesInAllLanguages Name { get; set; }
        public bool Allergene { get; set; }

        public string ToString(Langue langue)
        {
            return Allergene ? Name.ToString(langue) + "*" : Name.ToString(langue);
        }
    }
}
