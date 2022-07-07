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


        static async void WriteJournalEntry()
        {
            Console.WriteLine("You have chosen to write an entry.\nWhat is today's date?\n return a date in the MM/DD/YEAR:");
            string CurrentDate = Console.ReadLine();
            CurrentDate.Replace('/', '-');
            // this line above doesnt seem to replace the / with - idk why
Console.WriteLine(CurrentDate);
            string path = $@"JournalEntry{CurrentDate}.txt";
            // Fgure out how to put the new file in a folder so they arent just everywhere
           File.CreateText(path);
           Console.WriteLine("Enter your entry now!");
            string entry = Console.ReadLine();
            File.AppendAllText(path, entry);
            
        




        }


        static void ReadJournalEntry()
        {

        }


    }
}
