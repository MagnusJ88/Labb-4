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
        public WordList(string name, params string[] languages)
        {
            Name = name;
            Languages = languages;
        }
        public static string[] GetLists()
        {
            Directory.CreateDirectory(FilePath());
            DirectoryInfo listFolder = new DirectoryInfo(FilePath());
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
            try
            {
                string languageToLoad = File.ReadLines(FilePath() + name + ".dat").First();
                string[] languages = languageToLoad.Split(new[] { ';' }, StringSplitOptions.RemoveEmptyEntries);
                WordList loadedWordList = new WordList(name, languages);

                string[] wordsToLoad = File.ReadAllLines(FilePath() + name + ".dat").Skip(1).ToArray();

                foreach (var word in wordsToLoad)
                {
                    loadedWordList.Add(word.Split(new[] { ';' }, StringSplitOptions.RemoveEmptyEntries));
                }

                return loadedWordList;
            }
            catch
            {
                throw new FileNotFoundException();
            }
        }
        public void Save()
        {
            try
            {
                Directory.CreateDirectory(FilePath());
                var listName = Path.Combine(FilePath(), Name);

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
            catch
            {
                throw new IOException();
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
            try
            {
                for (int i = 0; i < Words.Count; i++)
                {
                    if (Words[i].Translations[translation] == word)
                    {
                        Words.RemoveAt(i);
                        wasRemoved = true;
                        return wasRemoved;
                    }
                }
            }
            catch
            {
                throw new Exception();
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
            Random random = new Random();
            if (Words.Count != 0 && Languages.Length != 0)
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
            else
            {
                throw new IndexOutOfRangeException();
            }
        }
        private static string FilePath()
        {
            return Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData) +
                    "\\World_of_Wordcraft\\";
        }
    }
}