using System;
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
            File.Create(listName); //filändelse?
            Add();
        }
        public static string[] GetLists()
        {
            //Returnerar array med namn på alla listor som finns lagrade(utan filändelsen).
            /*DirectoryInfo d = new DirectoryInfo(@" filsökvägen! ");
            FileInfo[] Files = d.GetFiles("*.txt"); //Getting Text files
            string str = "";
            foreach(FileInfo file in Files )
            {
            str = str + ", " + file.Name;
            }*/
        }
        public static WordList LoadList(string name)
        {
            //Laddar in ordlistan(name anges utan filändelse) och returnerar som WordList. 
        }
        public void Save()
        {
            //Sparar listan till en fil med samma namn som listan och filändelse .dat 
            //Joina en string med Name + ".dat" och skapa med filestream?
        }
        public void Add(params string[] translations)
        {
            //Lägger till ord i listan.Kasta ArgumentException om det är fel antal translations. 
            // Lägger till ord via en loop?

            string[] knas = new string[Languages.Length];
            for (int i = 0; i < Languages.Length; i++)
            {
                //skriva till en viss fil...
            }
        }
        public bool Remove(int translation, string word)
        {
            //translation motsvarar index i Languages. Sök igenom språket och ta bort ordet. 
        }
        public int Count()
        {
            //Räknar och returnerar antal ord i listan. 
            //Foreach? 
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
        }
    }
}
