using System;

class Program
{
    static void Main(string[] args)
    {
        // Simulate dice roll (like a slot machine)
        Random random = new Random();
        int roll1 = random.Next(1, 7);
        int roll2 = random.Next(1, 7);
        int roll3 = random.Next(1, 7);

        int total = roll1 + roll2 + roll3;

        Console.WriteLine($"Spin result: {roll1} | {roll2} | {roll3}");
        Console.WriteLine($"Total: {total}");

        // Check for doubles or triples
        if ((roll1 == roll2) || (roll2 == roll3) || (roll1 == roll3))
        {
            if ((roll1 == roll2) && (roll2 == roll3))
            {
                Console.WriteLine("🔥 Triple Match! +6 Bonus!");
                total += 6;
            }
            else
            {
                Console.WriteLine("💫 Double Match! +2 Bonus!");
                total += 2;
            }
        }

        Console.WriteLine($"Final Score (after bonus): {total}");

        // Prize logic
        if (total >= 16)
        {
            Console.WriteLine("You win a brand new car!");
        }
        else if (total >= 10)
        {
            Console.WriteLine("You win a new laptop!");
        }
        else if (total == 7)
        {
            Console.WriteLine("You win a vacation trip!");
        }
        else
        {
            Console.WriteLine("You win a kitten!");
        }

        Console.WriteLine("\n✅ Game Over - Thanks for playing!");
    }
}
