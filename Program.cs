namespace SelectionStatementExcersise
{
    class Program
    {
        static void Main(string[] args)
        {
            //If/Else Statement
            int favNumber = 777;

            Console.WriteLine("Try to guess my favorite number. Hint it is betwwen 1 and 1000.");
            var userGuess = int.Parse(Console.ReadLine());

            if (userGuess < favNumber)
            {
             Console.WriteLine("That is to low!");
            }
            else if (userGuess > favNumber)
            {
             Console.WriteLine("That is to high!");
            }
            else if (userGuess == favNumber)
            {
             Console.WriteLine($"That is correct! My favorite number is {favNumber}");
            }
            else
            {
                Console.WriteLine("Nevermind.");
            }

            //Switch/Case Statement
            Console.WriteLine("What is your favoirte school subject?");
            string variable = Console.ReadLine();

            switch (variable)
            {
                case "Math":
                    Console.WriteLine("That is my favorite subject too!");
                    break;
                case "Sience":
                    Console.WriteLine("e=mc^2!");
                    break;
                case "English":
                    Console.WriteLine("I do not like english at all.");
                    break;
                case "Histroy":
                    Console.WriteLine("Lets learn from our mistakes.");
                    break;
                case "Tech":
                    Console.WriteLine("The future is here!");
                    break;
                default:
                    Console.WriteLine("Did not know that was even an option.");
                    break;
            }

        }


    }


}


           
