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
                        WordList newWordList = new WordList(args[1], args.Skip(2).ToArray());

                        bool cont = true;
                        string input;
                        try
                        {
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
                        }
                        catch (Exception)
                        {
                            Console.WriteLine("Wrong input");
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
                        break;
                    case "-add":
                        WordList tempList = WordList.LoadList(args[1]);

                        bool cont2 = true;
                        string input2;
                        try
                        {
                            while (cont2)
                            {
                                string[] inputArray = new string[tempList.Languages.Length];
                                Console.WriteLine($"Input a word in {tempList.Languages[0]}");
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
                                        Console.WriteLine($"Input a word in {tempList.Languages[i]}");
                                        input2 = Console.ReadLine();
                                        if (input2 == "")
                                        {
                                            cont2 = false;
                                        }
                                        else
                                        {
                                            inputArray[i] = input2;
                                        }
                                    }
                                    if (cont2)
                                    {
                                        tempList.Add(inputArray);
                                    }
                                }
                            }
                        }
                        catch (Exception)
                        {
                            Console.WriteLine("Wrong input");
                        }

                        Console.WriteLine("Do you wish to save? <y/n> ");
                        string yNo = Console.ReadLine();
                        switch (yNo.ToLower())
                        {
                            case "y":
                                tempList.Save();
                                break;
                            default:
                                break;
                        }

                        break;
                    case "-remove":
                        //Remove();
                        break;
                    case "-words":
                        break;
                    case "-count":

                        break;
                    case "-practice":
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
    }
}
