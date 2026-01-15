/*
 * Added:
 * - Moods: users record their emotional state with each entry
 * - JSON format: instead of basic text files for entries
 * - Creation and management: journals stored in a folder in the working directory
 * - Database: tracks all saved journals in journalIndex.json
 * - Database: displays numbered list from index for easy selection
 * - Timestamps: time (not just date) to track when entries were written
 * - Automatic .json extension handling
 */
using System;

class Program
{
    static void Main(string[] args)
    {
        Journal journal = new Journal();
        PromptGenerator promptGenerator = new PromptGenerator();

        Console.WriteLine("Welcome to the Journal Program!");

        string choice = "";
        while (choice != "5")
        {
            Console.WriteLine("\nPlease select one of the following choices: ");
            Console.WriteLine("1. Write a new entry.");
            Console.WriteLine("2. Display journal entries.");
            Console.WriteLine("3. Save the journal to a file.");
            Console.WriteLine("4. Load the journal from a file.");
            Console.WriteLine("5. Quit.");

            choice = Console.ReadLine();

            switch (choice)
            {
                case "1":
                    Console.Write("How are you feeling? (happy/sad/stressed/excited): ");
                    string mood = Console.ReadLine();

                    string prompt = promptGenerator.GeneratePrompt();
                    Console.WriteLine(prompt);
                    Console.Write("> ");

                    string response = Console.ReadLine();
                    Entry entry = new Entry(prompt, response, mood);
                    journal.AddEntry(entry);

                    break;
                case "2":
                    journal.DisplayAllEntries();

                    break;
                case "3":
                    Console.Write("What is the filename? ");
                    string filename = Console.ReadLine();
                    journal.SaveToFile(filename);

                    break;
                case "4":
                    journal.DisplaySavedFiles();

                    List<string> files = journal.GetSavedFiles();
                    
                    if (files.Count == 0)
                    {
                        break;
                    }

                    Console.WriteLine("\nEnter number to load or type filename: ");
                    string input = Console.ReadLine();

                    if (int.TryParse(input, out int fileNum) && fileNum >= 1 && fileNum <= files.Count)
                    {
                        journal.LoadFromFile(files[fileNum - 1]);
                    }
                    else
                    {
                        journal.LoadFromFile(input);
                    }

                    break;
                case "5":
                    Console.WriteLine("Goodbye.");

                    break;
                default:
                    Console.WriteLine("Invalid option. Please select 1-5.");

                    break;
            }
        }
    }
}