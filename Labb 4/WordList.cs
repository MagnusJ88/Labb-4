using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace WordLibrary
{
    public class WordList
    {
        public string Name { get; }
        public string[] Languages { get; }
        private List<Word> Words = new List<Word>();
        private Random random = new Random();
        public WordList(string name, params string[] languages)
        {
            Name = name;
            Languages = languages;
        }
        public static string[] GetLists()
        {
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
            var languageToLoad = File.ReadLines(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData) + "\\World_of_Wordcraft\\" + name + ".dat").First();
            string[] languages = languageToLoad.Split(new[] { ';' }, StringSplitOptions.RemoveEmptyEntries);
            WordList loadedWordList = new WordList(name, languages);

            string[] wordsToLoad = File.ReadAllLines(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData) + "\\World_of_Wordcraft\\" + name + ".dat").Skip(1).ToArray();

            foreach (var word in wordsToLoad)
            {
                loadedWordList.Add(word.Split(new[] { ';' }, StringSplitOptions.RemoveEmptyEntries));
            }

            return loadedWordList;
        }
        public void Save()
        {
            string folderPath = Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData);
            string listFolder = Path.Combine(folderPath, "World_of_Wordcraft");
            Directory.CreateDirectory(listFolder);
            var listName = Path.Combine(listFolder, Name);

            File.WriteAllText(listName + ".dat", String.Empty);
            foreach (var language in Languages)
            {
                File.AppendAllText(listName.ToLower() + ".dat", language.Trim().ToUpper() + ";");
            }
            foreach (Word word in Words)
            {
                File.AppendAllText(listName + ".dat", Environment.NewLine);
                foreach (var translation in word.Translations)
                {
                    File.AppendAllText(listName + ".dat", translation.ToLower().Trim() + ";");
                }
            }
        }
        public void Add(params string[] translations)
        {
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
            bool wasRemoved = false;
            for (int i = 0; i < Words.Count; i++)
            {
                if (Words[i].Translations[translation] == word)
                {
                    Words.RemoveAt(i);
                    wasRemoved = true;
                    return wasRemoved;
                }
            }
            return wasRemoved;
        }
        public int Count()
        {
            return Words.Count;
        }
        public void List(int sortByTranslation, Action<string[]> showTranslations)
        {
            Words = Words.OrderBy(sorting => sorting.Translations[sortByTranslation]).ToList();
            foreach (Word word in Words)
            {
                showTranslations(word.Translations);
            }
        }
        public Word GetWordToPractice()
        {
            int indexOfWord = random.Next(0, Words.Count);
            int fromLanguage = random.Next(0, Languages.Length);
            int toLanguage = random.Next(0, Languages.Length);

            if (fromLanguage == toLanguage)
            {
                toLanguage = Math.Abs(fromLanguage - 1);
            }
            Word wordToPractice = new Word(fromLanguage, toLanguage, Words[indexOfWord].Translations);
            return wordToPractice;
        }
    }
}