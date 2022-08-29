using System;
using System.IO;
using System.Collections.Generic;


using System.Text;
using System.Diagnostics.CodeAnalysis;
using System.Globalization;
using System.Runtime.Serialization;
namespace My_Diary_proje
{

    class Program
    {
        public static List<string> dates = new List<string>();
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
            Console.WriteLine("You have chosen to write an entry.");
            string CurrentDate = GetDate();
            // this line above doesnt seem to replace the / with - idk why
            Console.WriteLine(CurrentDate);
            
            string path = $@"JournalEntry{CurrentDate}.txt";
        
            File.AppendAllText(@"DateList.txt", "\n" + CurrentDate );
            // Fgure out how to put the new file in a folder so they arent just everywhere
            File.CreateText(path);
            Console.WriteLine("Enter your entry now!");
            string entry = Console.ReadLine();
            File.AppendAllText(path, entry);
            Console.WriteLine("What would you like to name your entry?");
            string Title = Console.ReadLine();








        }
        public static string GetDate()
        {
            Console.WriteLine("What is today's date?\n return a date in the MM/DD/YEAR:");
            string CurrentDate = Console.ReadLine();
            CurrentDate = CurrentDate.Replace('/', '-');
            int DateLetters = 0;
            foreach (char C in CurrentDate)
            {
                DateLetters = DateLetters + 1;
                if (DateLetters > 10)
                {
                    Console.WriteLine("The date you entered exceeded the limit of 10 characters.");
                    DateLetters = 0;
                    CurrentDate = GetDate();

                }

            }
            return CurrentDate;


        }


        static void ReadJournalEntry()
        {
            int i = 1;
            Console.WriteLine("What date would you like a entry from?\nHere are the list of choseable dates");
            string[] allDates = File.ReadAllLines("DateList.txt");
            foreach (string date in allDates)
            {

                Console.WriteLine($"\n{i}. {date}");
                i = i + 1;
            }
            string chosenDate = Console.ReadLine();
            string wantedEntry = File.ReadAllText($@"JournalEntry{chosenDate}.txt");
            Console.WriteLine(wantedEntry);

        }


    }
}
