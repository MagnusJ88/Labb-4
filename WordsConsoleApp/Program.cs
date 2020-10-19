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
                        else Console.WriteLine("There are no lists available!");
                        break;
                    case "-new":
                        try
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
                            Console.WriteLine("Do you wish to save? <y/n> ");
                            string yesNo = Console.ReadLine();
                            switch (yesNo.ToLower())
                            {
                                case "y":
                                    newWordList.Save();
                                    break;
                                default:
                                    break;
                            }
                        }
                        catch (Exception)
                        {
                            Console.WriteLine("Wrong input");
                        }

                        break;
                    case "-add":
                        try
                        {
                            WordList addList = WordList.LoadList(args[1]);

                            bool cont2 = true;
                            string input2;
                            while (cont2)
                            {
                                string[] inputArray = new string[addList.Languages.Length];
                                Console.WriteLine($"Input a word in {addList.Languages[0]}");
                                input2 = Console.ReadLine();
                                if (input2 == "")
                                {
                                    cont2 = false;
                                }
                                else
                                {
                                    inputArray[0] = input2;
                                    for (int i = 1; i < inputArray.Length; i++)
                                    {
                                        Console.WriteLine($"Input a word in {addList.Languages[i]}");
                                        input2 = Console.ReadLine();
                                        if (input2 == "")
                                        {
                                            cont2 = false;
                                            break;
                                        }
                                        else
                                        {
                                            inputArray[i] = input2;
                                        }
                                    }
                                    if (cont2)
                                    {
                                        addList.Add(inputArray);
                                    }
                                }
                            }
                            Console.WriteLine("Do you wish to save? <y/n> ");
                            string yNo = Console.ReadLine();
                            switch (yNo.ToLower())
                            {
                                case "y":
                                    addList.Save();
                                    break;
                                default:
                                    break;
                            }
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
                            WordList removeList = WordList.LoadList(args[1]);

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
                                        }
                                        else
                                        {
                                            Console.WriteLine($"{word} could not be found.");
                                        }
                                    }
                                    break;
                                }
                            }
                            Console.WriteLine("Do you wish to save? <y/n> ");
                            string yN = Console.ReadLine();
                            switch (yN.ToLower())
                            {
                                case "y":
                                    removeList.Save();
                                    break;
                                default:
                                    break;
                            }
                        }
                        catch (Exception)
                        {
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
                            Console.WriteLine("No such list!");
                            PrintCommands();
                        }
                        break;
                    case "-practice":
                        try
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
                                    if (userInput == practiceWord.Translations[practiceWord.ToLanguage])
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
                        catch (Exception)
                        {
                            PrintCommands();
                        }

                        break;
                    default:
                        PrintCommands();
                        break;
                }
            }
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
        private static void showTranslations(string[] translations)
        {
            for (int i = 0; i < translations.Length; i++)
            {
                Console.Write($"{ translations[i], -10 }");
            }
            Console.WriteLine();
        }
    }
}
