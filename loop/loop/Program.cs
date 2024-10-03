namespace loop
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //variables
            string playerName = "adventurer";
            string userChoice = "NONE";

            //program
            Console.Write("Welcome to the jungle\n We got fun and games\n We got everything you want\n Honey, we know the names\n");
            Console.WriteLine("Wait...I don't actually know your name.");
            Console.WriteLine("What is your name?");
            Console.WriteLine("[Please enter your name, then press 'ENTER' on the keyboard]");

            //read player name
            playerName = Console.ReadLine();
            Console.WriteLine("\nWelcome to the jungle " + playerName + "!");

            //more story
            Console.WriteLine("" +
                "We approach a clearing in the jungle\n" +
                "There seems to be a trail to the left...\n" +
                "And a cave entrance to the right.\n"
                );

            //decision 1
            Console.WriteLine("Which path do you chose?");
            Console.WriteLine("Type 'left' to choose the path and go left or type 'right' to choose the cave and go right.");
            userChoice = Console.ReadLine();
            Console.WriteLine("\nYou chose: " + userChoice + "\n");

            //Select our path
            if (userChoice == "left")
            {
                //Go to the left
                Console.WriteLine("You have survived you lucky sun of a daisy!");

            }
            else if (userChoice == "right")
            {
                //Go to the right
                Console.WriteLine("Womp womp, you are stuck in a cave now.");
            }
            else
            {
                //Oh no! the user typed in something else.
                userChoice = "NONE";
                while (userChoice != "left" && userChoice != "right" && userChoice != "up")
                {
                    Console.WriteLine("Please enter either 'left', 'right', or our now super    secret answer of 'up'.");
                    userChoice = Console.ReadLine();
                    Console.WriteLine("\nYou chose: " + userChoice + "\n");
                }
                if (userChoice == "left")
                {
                    //Go to the left
                }
                else if (userChoice == "right")
                {
                    //Go to the right
                }
                else if (userChoice == "up")
                {
                    //Easter Egg
                    Console.WriteLine("'up' seriously? 'up'!? How can we go up? UP YOURS! |_(O_O)_/ **Flips keyboard** CLOSE THE PROGRAM!");
                }
                else
                {
                    Console.WriteLine("I honestly don't know how you got here. Congrats.");
                }
            }
        }
    }
}
