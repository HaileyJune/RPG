using System;

namespace RPG
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please select a character:");
            Console.WriteLine("To select a Type A character, submit A.");
            Console.WriteLine("summary of type a.");
            Console.WriteLine("To select a Type B character, submit B.");
            Console.WriteLine("summary of type b.");

            Hero player;

            string InputLine = Console.ReadLine();
            if (InputLine == "A" || InputLine == "a")
            {
                System.Console.WriteLine("Enter a name: ");
                InputLine = Console.ReadLine();
                player = new TypeA(InputLine);
            }
            else if (InputLine == "B" || InputLine == "b")
            {
                System.Console.WriteLine("Enter a name: ");
                InputLine = Console.ReadLine();
                player = new TypeB(InputLine);
            }
            else
            {
                System.Console.WriteLine("Well you really screwed that up huh? I don't know how to fix this yet.");
                player = new Hero ("Generic", 10, 10, 10);
            }

            System.Console.WriteLine("_________________");
            System.Console.WriteLine("Here's a glimpse at what your stats look like:");
            player.GetInfo();
            System.Console.WriteLine("Yep it's pretty lame. Let's put you to work!");

            Chore chore1 = new Chore ("dishes");
            Work work1 = new Work ("homework");

            System.Console.WriteLine("Today you have to do {0} and {1}.", chore1.name, work1.name);
            
            while (chore1.isCompleate == false && work1.isCompleate == false)
            {
                System.Console.WriteLine("Here's what you can do:");
                System.Console.WriteLine("Type 'd' to work on the dishes.");
                System.Console.WriteLine("Type 'h' to work on the homework.");
                System.Console.WriteLine("Type 'b' to binge watch Netflix.");
                System.Console.WriteLine("Type 'r' to rest.");
                System.Console.WriteLine("Type 'i' to see your stats.");

                InputLine = Console.ReadLine();

                if (InputLine == "d" || InputLine == "D")
                {
                    player.WorkOn(chore1);
                }
                else if (InputLine == "h" || InputLine == "H")
                {
                    player.WorkOn(work1);
                }
                else if (InputLine == "b" || InputLine == "B")
                {
                    player.BingeTV();
                }
                else if (InputLine == "r" || InputLine == "R")
                {
                    player.Rest();
                }
                else if (InputLine == "i" || InputLine == "I")
                {
                    player.GetInfo();
                }
                else
                {
                    System.Console.WriteLine("I can't read your mind, type something I understand.");
                }
            }
        // TypeA player = new TypeA("Jane");
        // Chore problem1 = new Chore("Laundry");
        // Work problem2 = new Work("OOP with C#");
        // System.Console.WriteLine("");
        // player.GetInfo();
        // player.WorkOn(problem1);
        // player.GetInfo();
        // player.Rest();
        // System.Console.WriteLine("");
        // player.WorkOn(problem2);
        // player.WorkOn(problem2);
        // player.WorkOn(problem2);
        // player.GetInfo();
        // System.Console.WriteLine("");
        }
    }
}
