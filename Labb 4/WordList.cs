using System;
using System.Collections.Generic;
using System.IO;

namespace WordLibrary
{
    public class WordList
    {
        public string Name { get; } //namnet på listan
        public string[] Languages { get; } //namnet på språken
        private List<Word> Words = new List<Word>();
        public WordList(string name, params string[] languages)
        {
            //Konstruktor.Sätter properites Name och Languages till parametrarnas värden.
            Name = name;
            Languages = languages;
        }
        public static string[] GetLists()
        {
            //Returnerar array med namn på alla listor som finns lagrade(utan filändelsen).
            DirectoryInfo listFolder = new DirectoryInfo(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData) + "\\World_of_Wordcraft");
            FileInfo[] Files = listFolder.GetFiles("*.dat");
            string[] allLanguages = new string[Files.Length];
            for (int i = 0; i < Files.Length; i++)
            {
                allLanguages[i] = Path.GetFileNameWithoutExtension(Files[i].Name);
            }
            return allLanguages;
        }
        /*public static WordList LoadList(string name)
        {
            //Laddar in ordlistan(name anges utan filändelse) och returnerar som WordList. 
            läser in filen från path.
            sätter Name och Languages och matar in till words alla översättningar.
        }*/
        public void Save()
        {
            //Sparar listan till en fil med samma namn som listan och filändelse .dat 

            string folderPath = Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData);
            string listFolder = Path.Combine(folderPath, "World_of_Wordcraft");
            Directory.CreateDirectory(listFolder);

            var listName = Path.Combine(listFolder, Name);

            if (!File.Exists(listName + ".dat"))
            {
                foreach (var language in Languages)
                {
                    File.AppendAllText(listName.ToLower() + ".dat", language.ToLower() + ";");
                }
                File.AppendAllText(listName.ToLower() + ".dat", "\n");
                foreach (Word word in Words)
                {
                    File.AppendAllText(listName.ToLower() + ".dat", word.ToString().ToLower() + ";");
                }
            }
        }
        public void Add(params string[] translations)
        {
            //Lägger till ord i listan.Kasta ArgumentException om det är fel antal translations. 
            /*if (translations.Length % Languages.Length == 0)
            {
                words.Add(new Word(translations));
            }*/

            Words.Add(new Word(translations));

            //using (StreamWriter outputFile = new StreamWriter(Path.Combine(specificFolder, Name + ".dat"), true))

        }/*
        public bool Remove(int translation, string word)
        {
            //translation motsvarar index i Languages. Sök igenom språket och ta bort ordet. 
        }*/
        public int Count()
        {
            //Räknar och returnerar antal ord i listan. 
            return Words.Count;
        }
      /*  public void List(int sortByTranslation, Action<string[]> showTranslations)
        {
            //sortByTranslation = Vilket språk listan ska sorteras på.
            //showTranslations = Callback som anropas för varje ord i listan.

        }
        public Word GetWordToPractice()
        {
            //Returnerar slumpmässigt Word från listan, med slumpmässigt valda
            //FromLanguage och ToLanguage(dock inte samma). 

            //FromLanguage
            //ToLanguage
        }*/
    }
}
