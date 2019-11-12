﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SMS.BusinessLogic
{
    public class Sandwich
    {
        public Sandwich(NamesInAllLanguages translated, Fournisseur fournisseur)
        {
            Name = translated;
            Fournisseur = fournisseur;
        }

        public NamesInAllLanguages Name { get; set; }
        public Fournisseur Fournisseur { get; set; }
        public List<Ingrédient> Ingrédients { get; set; }

        public string ToString(Langue langue)
        {
            return Name.ToString(langue);
        }
        public string GetListIngredients(Langue langue)
        {
            StringBuilder menu = new StringBuilder();
            menu.Append(Name.ToString(langue) + " => ");
            menu.Append(string.Join(", ", Ingrédients.Select(ing => ing.ToString(langue))));
            return menu.ToString();
        }
    }
}
