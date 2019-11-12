using System;
using System.Collections.Generic;
using System.Text;

namespace SMS.BusinessLogic
{
    public class NamesInAllLanguages
    {
        public string French { get; set; }
        public string English { get; set; }
        public string Deutch { get; set; }

        public NamesInAllLanguages()
        {
        }

        public NamesInAllLanguages(string francais, string anglais, string deutch)
        {
            if (string.IsNullOrEmpty(francais) || string.IsNullOrEmpty(anglais) || string.IsNullOrEmpty(deutch))
            {
                throw new Exception("Le nom de l'article doit être renseigné dans toutes les langues.");
            }
            French = francais;
            English = anglais;
            Deutch = deutch;
        }


        public virtual  string ToString(Langue langue)
        {
            switch (langue)
            {
                case Langue.French:
                    return French;
                case Langue.English:
                    return English;
                case Langue.Deutch:
                    return Deutch;
                default:
                    throw new Exception("Langue non prise en compte");
            }
        }
    }
}
