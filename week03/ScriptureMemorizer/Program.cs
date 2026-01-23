using System;
/*
 * Added:
 * - Scripture library: Loads and parses scriptures from file. Fallback to hard coded library if file is not found.
 * - Random selection: Randomly selects a scripture from the library each time the program is run.
 * - Word hiding: Hides words randomly without repeating already hidden words.
 * - Scripture count: Shows user how many scriptures are loaded at start if loaded from file.
 */

class Program
{
    static void Main(string[] args)
    {
        Scripture.LoadFromFile();
        int scriptureCount = Scripture.GetScriptureCount();

        if (scriptureCount > 0)
        {
            Console.WriteLine($"Loaded {Scripture.GetScriptureCount()} scriptures.");
        }

        Scripture scripture = Scripture.GetRandomScripture();

        if (scripture == null)
        {
            Console.WriteLine("No scripture available.");
            return;
        }

        int[] verseWordRange = Enumerable.Range(0, scripture.GetWordCount()).ToArray();
        Random.Shared.Shuffle(verseWordRange);

        Console.Clear();
        Console.WriteLine(scripture.GetDisplayText());

        int wordIndex = 0;
        string userInput = "";
        while (userInput != "quit" && !scripture.IsCompletelyHidden())
        {
            Console.WriteLine("\nPress Enter to continue or type 'quit' to finish:");
            userInput = Console.ReadLine();

            if (userInput != "quit")
            {
                for (int i = 0; i < 3 && wordIndex < verseWordRange.Length; i++, wordIndex++) {
                    scripture.HideRandomWords(verseWordRange[wordIndex]);
                }

                Console.Clear();
                Console.WriteLine(scripture.GetDisplayText());
            }
        }
    }
}