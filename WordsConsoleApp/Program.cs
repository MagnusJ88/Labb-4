using System;
using System.Linq;
using WordLibrary;

namespace WordsConsoleApp
{
    class WordsConsoleApp
    {
        static void Main(string[] args)
        {
            if (args.Length == 0)
            {
                PrintCommands();
            }
            else
            {
                switch (args[0])
                {
                    case "-lists":
                        string[] lists = WordList.GetLists();
                        if (lists.Length > 0)
                        {
                            foreach (var list in lists)
                            {
                                Console.WriteLine(list);
                            }
                        }
                        else
                        {
                            Console.WriteLine("There are no lists available!");
                            PrintCommands();
                        }
                        break;
                    case "-new":
                        try
                        {
                            New(args);
                        }
                        catch (Exception)
                        {
                            Console.WriteLine("Wrong input");
                            PrintCommands();
                        }
                        break;
                    case "-add":
                        try
                        {
                            Add(args);
                        }
                        catch (Exception)
                        {
                            Console.WriteLine("Wrong input");
                            PrintCommands();
                        }
                        break;
                    case "-remove":
                        try
                        {
                            Remove(args);
                        }
                        catch (Exception)
                        {
                            Console.WriteLine("Wrong input");
                            PrintCommands();
                        }
                        break;
                    case "-words":
                        try
                        {
                            WordList wordsList = WordList.LoadList(args[1]);
                            int sortByTranslation = 0;
                            if (args.Length > 2)
                            {
                                for (int i = 1; i < wordsList.Languages.Length; i++)
                                {
                                    if (args[2].ToUpper() == wordsList.Languages[i].ToUpper())
                                    {
                                        sortByTranslation = i;
                                        break;
                                    }
                                }
                            }
                            showTranslations(wordsList.Languages);
                            Action<string[]> action = new Action<string[]>(showTranslations);
                            wordsList.List(sortByTranslation, action);
                        }
                        catch (Exception)
                        {
                            Console.WriteLine("Wrong input");
                            PrintCommands();
                        }
                        break;
                    case "-count":
                        try
                        {
                            WordList countList = WordList.LoadList(args[1]);
                            Console.WriteLine($"{args[1]} contains {countList.Count()} words");
                        }
                        catch (Exception)
                        {
                            Console.WriteLine("Wrong input");
                            PrintCommands();
                        }
                        break;
                    case "-practice":
                        try
                        {
                            Practice(args);
                        }
                        catch (Exception)
                        {
                            Console.WriteLine("Wrong input");
                            PrintCommands();
                        }
                        break;
                    default:
                        PrintCommands();
                        break;
                }
            }
        }
        private static void New(string[] args)
        {
            WordList newWordList = new WordList(args[1], args.Skip(2).ToArray());

            bool cont = true;
            string input;
            while (cont)
            {
                string[] inputArray = new string[newWordList.Languages.Length];
                Console.WriteLine($"Input a word in {newWordList.Languages[0]}");
                input = Console.ReadLine();
                if (input == "")
                {
                    cont = false;
                }
                else
                {
                    inputArray[0] = input;
                    for (int i = 1; i < inputArray.Length; i++)
                    {
                        Console.WriteLine($"Input a word in {newWordList.Languages[i]}");
                        input = Console.ReadLine();
                        if (input == "")
                        {
                            cont = false;
                            break;
                        }
                        else
                        {
                            inputArray[i] = input;
                        }
                    }
                    if (cont)
                    {
                        newWordList.Add(inputArray);
                    }
                }
            }
            Save(newWordList);
        }
        private static void Add(string[] args)
        {
            WordList addWordList = WordList.LoadList(args[1]);
            int counter = 0;
            bool cont = true;
            string input;
            while (cont)
            {
                string[] inputArray = new string[addWordList.Languages.Length];
                Console.WriteLine($"Input a word in {addWordList.Languages[0]}");
                input = Console.ReadLine();
                if (input == "")
                {
                    cont = false;
                }
                else
                {
                    inputArray[0] = input.Trim().ToLower();
                    for (int i = 1; i < inputArray.Length; i++)
                    {
                        Console.WriteLine($"Input a word in {addWordList.Languages[i]}");
                        input = Console.ReadLine();
                        if (input == "")
                        {
                            cont = false;
                            break;
                        }
                        else
                        {
                            inputArray[i] = input;
                        }
                    }
                    if (cont)
                    {
                        addWordList.Add(inputArray);
                        counter++;
                    }
                }
            }
            if (counter > 0)
            {
                Save(addWordList);
                Console.WriteLine($"Saved successfully! {counter} words were added to {addWordList.Name}.");
            }
            else
            {
                Console.WriteLine($"No words were added to {addWordList.Name}!");
                PrintCommands();
            }
        }
        private static void Remove(string[] args)
        {
            WordList removeList = WordList.LoadList(args[1]);
            int counter = 0;
            string[] wordsToRemove = args.Skip(3).ToArray();
            for (int i = 0; i < removeList.Languages.Length; i++)
            {
                if (args[2].ToUpper() == removeList.Languages[i].ToUpper())
                {
                    foreach (String word in wordsToRemove)
                    {
                        if (removeList.Remove(i, word))
                        {
                            Console.WriteLine($"{word} was removed from the list!");
                            counter++;
                        }
                        else
                        {
                            Console.WriteLine($"The word {word} could not be found.");
                        }
                    }
                    break;
                }
            }
            if (counter > 0)
            {
                Save(removeList);
                Console.WriteLine($"Saved successfully! {counter} words were removed from {removeList.Name}.");
            }
            else
            {
                Console.WriteLine($"No words were removed from {removeList.Name}!");
                PrintCommands();
            }
        }
        private static void Practice(string[] args)
        {
            WordList practiceList = WordList.LoadList(args[1]);
            bool practicing = true;
            decimal correctAnswers = 0m, wrongAnswers = 0m;
            while (practicing)
            {
                Word practiceWord = practiceList.GetWordToPractice();
                Console.WriteLine($"Translate {practiceWord.Translations[practiceWord.FromLanguage]} to " +
                                    $"{practiceList.Languages[practiceWord.ToLanguage]}:");
                String userInput = Console.ReadLine();
                if (userInput != "")
                {
                    if (userInput.Trim().ToLower() == practiceWord.Translations[practiceWord.ToLanguage])
                    {
                        correctAnswers++;
                        Console.WriteLine("Correct! Well done!");
                    }
                    else
                    {
                        wrongAnswers++;
                        Console.WriteLine("Wrong! Better luck next time!");
                    }
                }
                else
                {
                    practicing = false;
                }
            }
            Console.WriteLine($"Total number of guesses: {correctAnswers + wrongAnswers}\n" +
                $"Correct answers: {correctAnswers} " +
                $"({Math.Round(correctAnswers / (correctAnswers + wrongAnswers), 2) * 100}% correct)");
        }
        private static void PrintCommands()
        {
            Console.WriteLine("Use any of the following parameters:\n" +
                                        "-lists\n" +
                                        "-new <list name> <language 1> <language 2> .. <langauge n>\n" +
                                        "-add <list name>\n" +
                                        "-remove <list name> <language> <word 1> <word 2> .. <word n>\n" +
                                        "-words <listname> <sortByLanguage>\n" +
                                        "-count <listname>\n" +
                                        "-practice <listname>");
        }
        private static void Save(WordList wordList)
        {
            Console.WriteLine("Do you wish to save changes? <y/n>");
            string yesOrNo = Console.ReadLine();
            switch (yesOrNo.ToLower())
            {
                case "y":
                    wordList.Save();
                    Console.WriteLine($"Saved to {Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData) + "\\World_of_Wordcraft"}");
                    break;
                default:
                    break;
            }
        }
        private static void showTranslations(string[] translations)
        {
            for (int i = 0; i < translations.Length; i++)
            {
                Console.Write($"{ translations[i],-10 }");
            }
            Console.WriteLine();
        }
    }
}