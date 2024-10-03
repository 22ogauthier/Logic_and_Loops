namespace October_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //variables
            string playerName = "adventurer";
            string userChoice = "none";

            //Program start
            Console.WriteLine("Welcome to the jungle\nWe got fun and games\nWe got everything you want\nHoney, we know the names");
            Console.WriteLine("Wait... I don't actually know your name.");
            Console.WriteLine("What is your name?");
            Console.WriteLine("[Please enter your name, then press 'ENTER' on the keyboard]");

            //grab some user input
            playerName = Console.ReadLine();
            Console.WriteLine("\nWelcome to the jungle " + playerName + "!");

            //continue the story
            Console.WriteLine("We approach a clearing in the jungle\nThere seems to be a trail to the left...\nand a cave entrance to the right.");
            Console.WriteLine("Which path do you choose?");
            Console.WriteLine("Type 'left' to choose the path or type 'right' to choose the cave.");

            userChoice = Console.ReadLine();
            Console.WriteLine("You chose: " + userChoice + "!");

            //select the path
            if (userChoice == "left")
            {
                Console.WriteLine("You take the path to the left. It leads you out of the jungle. You are safe to adventure another day!");
            }
            else if (userChoice == "right")
            {
                Console.WriteLine("You take the path to the right. It leads you into a cave. There is a cave in and you are trapped!");
            }
            else
            {
                userChoice = "none";
                while (userChoice != "left" && userChoice != "right")
                {
                    Console.WriteLine("Please enter 'left' or 'right'");
                    userChoice = Console.ReadLine();
                    Console.WriteLine("\nYou chose: " + userChoice + "!");
                }
                if (userChoice == "left")
                {
                    Console.WriteLine("You take the path to the left. It leads you out of the jungle. You are safe to adventure another day!");
                }
                else if (userChoice == "right")
                {
                    Console.WriteLine("You take the path to the right. It leads you into a cave. There is a cave in and you are trapped!");
                }
                else
                {
                    Console.WriteLine("I honestly don't know how you got here. Congrats!");
                }
            }
        }
    }
}
