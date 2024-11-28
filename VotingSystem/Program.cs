using System;

class VotingSystem
{
    static void Main()
    {
        // Step 1: Initialize candidates and votes
        string[] candidates = { "Alice", "Bob", "Charlie" };
        int[] votes = new int[candidates.Length];

        while (true)
        {
            Console.Clear();
            Console.WriteLine("=== Voting System ===");
            Console.WriteLine("Choose an option:");
            Console.WriteLine("1. Cast a Vote");
            Console.WriteLine("2. View Results");
            Console.WriteLine("3. Exit");
            Console.Write("Enter your choice (1-3): ");

            string choice = Console.ReadLine();

            switch (choice)
            {
                case "1":
                    CastVote(candidates, votes);
                    break;
                case "2":
                    ViewResults(candidates, votes);
                    break;
                case "3":
                    Console.WriteLine("Thank you for using the voting system!");
                    return;
                default:
                    Console.WriteLine("Invalid choice. Press Enter to try again.");
                    Console.ReadLine();
                    break;
            }
        }
    }

    static void CastVote(string[] candidates, int[] votes)
    {
        Console.Clear();
        Console.WriteLine("=== Cast Your Vote ===");
        for (int i = 0; i < candidates.Length; i++)
        {
            Console.WriteLine($"{i + 1}. {candidates[i]}");
        }
        Console.Write("Enter the number of your chosen candidate: ");

        if (int.TryParse(Console.ReadLine(), out int vote) && vote > 0 && vote <= candidates.Length)
        {
            votes[vote - 1]++;
            Console.WriteLine($"You voted for {candidates[vote - 1]}. Thank you!");
        }
        else
        {
            Console.WriteLine("Invalid vote. Please try again.");
        }
        Console.WriteLine("Press Enter to return to the main menu.");
        Console.ReadLine();
    }

    static void ViewResults(string[] candidates, int[] votes)
    {
        Console.Clear();
        Console.WriteLine("=== Voting Results ===");
        for (int i = 0; i < candidates.Length; i++)
        {
            Console.WriteLine($"{candidates[i]}: {votes[i]} votes");
        }
        Console.WriteLine("Press Enter to return to the main menu.");
        Console.ReadLine();
    }
}
