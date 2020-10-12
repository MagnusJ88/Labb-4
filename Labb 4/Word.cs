using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WordLibrary
{
    public class Word
    {
        public string[] Translations { get; }
        public int FromLanguage { get; }
        public int ToLanguage { get; }
        public Word(params string[] translations)
        {
            //Konstruktor
            //initialiserar ’Translations’ med data som skickas in som ’translations’ 
            Translations = translations;
        }
        public Word(int fromLanguage, int toLanguage, params string[] translations)
        {
            //Konstruktor2
            //som ovan, fast sätter även FromLanguage och ToLanguage.
            
            FromLanguage = fromLanguage;
            ToLanguage = toLanguage;
            //skicka translations till föregående konstruktor
        }
    }
}
