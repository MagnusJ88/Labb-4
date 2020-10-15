using System;
using System.Linq;
using System.Runtime.CompilerServices;
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
                        Console.WriteLine($"Input words, press enter to break.");
                        newWordList.Add(Console.ReadLine());


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
                        //testAdd();
                        
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
