using System;
using System.Collections.Generic;
using System.IO;

namespace WordLibrary
{
    public class WordList
    {
        public string Name { get; } //namnet på listan
        public string[] Languages { get; } //namnet på språken
        public WordList(string name, params string[] languages)
        {
            //Konstruktor.Sätter properites Name och Languages till parametrarnas värden.
            Name = name;
            Languages = languages;

            string folderPath = Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData);
            string listFolder = Path.Combine(folderPath, "World_of_Wordcraft");
            Directory.CreateDirectory(listFolder);

            var listName = Path.Combine(listFolder, name);

            if (!File.Exists(listName + ".dat"))
            {
                foreach (var language in languages)
                {
                    File.AppendAllText(listName.ToLower() + ".dat", language.ToLower() + ";");
                }
            }
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
        }
        public void Save()
        {
            //Sparar listan till en fil med samma namn som listan och filändelse .dat 
            //Joina en string med Name + ".dat" och skapa med filestream?
        }*/
        public void Add(params string[] translations)
        {
            //Lägger till ord i listan.Kasta ArgumentException om det är fel antal translations. 


        }/*
        public bool Remove(int translation, string word)
        {
            //translation motsvarar index i Languages. Sök igenom språket och ta bort ordet. 
        }        
        public int Count()
        {
            //Räknar och returnerar antal ord i listan. 

        }
        public void List(int sortByTranslation, Action<string[]> showTranslations)
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
