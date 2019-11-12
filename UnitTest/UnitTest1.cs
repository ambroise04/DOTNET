using Microsoft.VisualStudio.TestTools.UnitTesting;
using SMS.BusinessLogic;
using System.Collections.Generic;
using System.Diagnostics;

namespace UnitTest
{
    [TestClass]
    public class UnitTest1
    {
        [DataTestMethod]

        [DataRow(Langue.French, "Jambon*, Oignon")]
        [DataRow(Langue.English, "Ham*, Onion")]
        [DataRow(Langue.Deutch, "Ham*, Ui")]

        public void GetListeDesIngredients_AvecAllergeneOuPas(Langue langue, string result)
        {
            //Traduction -> Nom des ingrédients
            NamesInAllLanguages ing1 = new NamesInAllLanguages("Jambon", "Ham", "Ham");
            NamesInAllLanguages ing2 = new NamesInAllLanguages("Oignon", "Onion", "Ui");
            NamesInAllLanguages ing3 = new NamesInAllLanguages("Blé", "Corn", "Tarwe");
            NamesInAllLanguages ing4 = new NamesInAllLanguages("Avoine", "Oat", "Haver");            

            //Ingredients
            List<Ingredient> ingrédients1 = new List<Ingredient> 
            {
                new Ingredient(ing1, true),
                new Ingredient(ing2, false)
            };

            List<Ingredient> ingrédients2 = new List<Ingredient>
            {
                new Ingredient(ing3, true),
                new Ingredient(ing4, false)
            };

            //Traduction -> Nom des sandwiches
            NamesInAllLanguages s1 = new NamesInAllLanguages("Américain", "American", "Amerikaans");
            NamesInAllLanguages s2 = new NamesInAllLanguages("Peanut butter and jelly sandwich", "Sandwich au beurre de cacahuette et confiture", "Broodje pindakass en jam");


            //Creation des fournisseurs
            Fournisseur f1 = new Fournisseur { Name = "Gauthier", ContactName = "Gauthier", Email = "gauthier@gmail.com", LanguageChoice = Langue.French };
            //Fournisseur f2 = new Fournisseur { Name = "Ambroise", ContactName = "Ambroise", Email = "ambroise@gmail.com", LanguageChoice = Langue.English.ToString() };

            //Sandwiches
            Sandwich sandwich1 = new Sandwich(s1, f1);
            Sandwich sandwich2 = new Sandwich(s2, f1);

            //Ajout des Ingredients aux sandwiches
            sandwich1.Ingrédients = ingrédients1;
            sandwich2.Ingrédients = ingrédients2;

            //Ajout des Sandwiches d'un client
            
            f1.Sandwiches.Add(sandwich1);
            f1.Sandwiches.Add(sandwich2);

            //Assert.AreEqual(result, sandwich1.GetListIngredients(langue));
            //Assert.AreEqual(result, f1.ToString(f1.LanguageChoice));
        }
    }
}
