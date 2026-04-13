using System;

class Program
{
    static void Main(string[] args)
    {
        
        UI.DisplayLogo();

        
        UI.PlayGreeting();

       
        Console.ForegroundColor = ConsoleColor.White;
        Console.Write("\n  Before we begin, what is your name? ");
        Console.ResetColor();
        string name = Console.ReadLine();

        if (string.IsNullOrWhiteSpace(name))
            name = "Friend";

        
        UI.ShowWelcomeMessage(name);

        ChatLoop(name);
    }

    static void ChatLoop(string name)
    {
        while (true)
        {
            
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.Write($"\n  {name}: ");
            Console.ResetColor();

            string input = Console.ReadLine();

            if (InputValidator.IsEmpty(input))
            {
                UI.PrintBotMessage("Hmm, it looks like you didn't type anything. Could you try again?");
                continue; 
            }

            input = input.ToLower().Trim();

            if (input == "exit" || input == "quit" || input == "bye")
            {
                UI.PrintBotMessage($"Goodbye, {name}! Stay safe online! 🔒");
                break;
            }

            string response = ResponseEngine.GetResponse(input, name);
            UI.PrintBotMessage(response);
        }
    }
}