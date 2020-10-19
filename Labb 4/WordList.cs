using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace WordLibrary
{
    public class WordList
    {
        Random random = new Random();
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
            string[] allFiles = new string[Files.Length];
            for (int i = 0; i < Files.Length; i++)
            {
                allFiles[i] = Path.GetFileNameWithoutExtension(Files[i].Name);
            }
            return allFiles;
        }
        public static WordList LoadList(string name)
        {
            //Laddar in ordlistan(name anges utan filändelse) och returnerar som WordList. 
            //läser in filen från path.
            //sätter Name och Languages och matar in till words alla översättningar.

            var bös = File.ReadLines(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData) + "\\World_of_Wordcraft\\" + name + ".dat").First();
            string[] languages = bös.Split(new[] { ';' }, StringSplitOptions.RemoveEmptyEntries);
            WordList newWordList = new WordList(name, languages);

            string[] temp = File.ReadAllLines(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData) + "\\World_of_Wordcraft\\" + name + ".dat").Skip(1).ToArray();

            foreach (var word in temp)
            {
                newWordList.Add(word.Split(new[] { ';' }, StringSplitOptions.RemoveEmptyEntries));
            }

            return newWordList;
        }
        public void Save()
        {
            //Sparar listan till en fil med samma namn som listan och filändelse .dat 
            string folderPath = Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData);
            string listFolder = Path.Combine(folderPath, "World_of_Wordcraft");
            Directory.CreateDirectory(listFolder);
            var listName = Path.Combine(listFolder, Name);

            File.WriteAllText(listName + ".dat", String.Empty);
            foreach (var language in Languages)
            {
                File.AppendAllText(listName.ToLower() + ".dat", language.ToUpper() + ";");
            }
            foreach (Word word in Words)
            {
                File.AppendAllText(listName + ".dat", Environment.NewLine);
                foreach (var translation in word.Translations)
                {
                    File.AppendAllText(listName + ".dat", translation.ToLower() + ";");
                }
            }
        }
        public void Add(params string[] translations)
        {
            //Lägger till ord i listan.Kasta ArgumentException om det är fel antal translations. 
            if (translations.Length == Languages.Length)
            {
                Words.Add(new Word(translations));
            }
            else
            {
                throw new ArgumentException();
            }
        }
        public bool Remove(int translation, string word)
        {
            //translation motsvarar index i Languages. Sök igenom språket och ta bort ordet. 
            bool temp = false;
            for (int i = 0; i < Words.Count; i++)
            {
                if (Words[i].Translations[translation] == word)
                {
                    Words.RemoveAt(i);
                    temp = true;
                    return temp;
                }
            }
            return temp;
        }
        public int Count()
        {
            //Räknar och returnerar antal ord i listan. 
            return Words.Count;
        }
        public void List(int sortByTranslation, Action<string[]> showTranslations)
        {
            //sortByTranslation = Vilket språk listan ska sorteras på.
            //showTranslations = Callback som anropas för varje ord i listan.
            //Listar ord (alla språk) från angiven lista. Om man anger språk sorteras listan efter
            //det, annars sortera efter första språket.
            Words = Words.OrderBy(temp => temp.Translations[sortByTranslation]).ToList();
            foreach (Word word in Words)
            {
                showTranslations(word.Translations);
            }
        }
        public Word GetWordToPractice()
        {
            //Returnerar slumpmässigt Word från listan, med slumpmässigt valda
            //FromLanguage och ToLanguage(dock inte samma). 
            int indexOfWord = random.Next(0, Words.Count);
            int fromLanguage = random.Next(0, Languages.Length);
            int toLanguage = random.Next(0, Languages.Length);

            if (fromLanguage == toLanguage)
            {
                toLanguage = Math.Abs(fromLanguage - 1);
            }
            Word temp = new Word(fromLanguage, toLanguage, Words[indexOfWord].Translations);
            return temp;
        }
    }
}
