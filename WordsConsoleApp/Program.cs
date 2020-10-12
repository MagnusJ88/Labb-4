using WordLibrary;
using System;

namespace WordsConsoleApp
{
    class WordsConsoleApp
    {
        static void Main(string[] args)
        {
            if (args.Length == 0)
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
}
