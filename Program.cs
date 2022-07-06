using System;
using System.IO;
using System.Text;
using System.Diagnostics.CodeAnalysis;
using System.Globalization;
using System.Runtime.Serialization;
namespace My_Diary_proje 
{
    class Program
    {
        static void Main(string[] args)
        {
            Start();
        }

        static void Start()
        {
            Console.WriteLine("Welcome to your Personal Journal!\nIf you would like to write an entry or read an entry?\n Select 'write' or 'read'.");
            string FirstResponse = Console.ReadLine();
            if (FirstResponse.ToLower() == "write")
            {
                WriteJournalEntry();
            }
            else if (FirstResponse.ToLower() == "read")
            {
                ReadJournalEntry();
            }
            else
            {
                Start();
            }

        }


        static void WriteJournalEntry()
        {
            Console.WriteLine("You have chosen to write an entry.\nWhat is today's date?\n return a date in the MM/DD/YEAR:");
            string CurrentDate = Console.ReadLine();
            Console.WriteLine("Enter your entry now!");
            string entry = Console.ReadLine();
            string path = $@"\JournalEntries\JournalEntry{CurrentDate}.txt";
           File.CreateText(path);
        




        }


        static void ReadJournalEntry()
        {

        }


    }
}
