using System;
using System.Media;
using System.Threading; 

class UI
{
    public static void DisplayLogo()
    {
        Console.BackgroundColor = ConsoleColor.Black;
        Console.Clear();

        Console.ForegroundColor = ConsoleColor.DarkGreen;
        Console.WriteLine("\n  +---------------------------------------------------------+");
        Console.WriteLine("  |                                                         |");

        Console.ForegroundColor = ConsoleColor.Green;
        Console.WriteLine(@"  |  ██████╗██╗   ██╗██████╗ ███████╗██████╗                |");
        Console.WriteLine(@"  | ██╔════╝╚██╗ ██╔╝██╔══██╗██╔════╝██╔══██╗               |");
        Console.WriteLine(@"  | ██║      ╚████╔╝ ██████╔╝█████╗  ██████╔╝               |");
        Console.WriteLine(@"  | ██║       ╚██╔╝  ██╔══██╗██╔══╝  ██╔══██╗               |");
        Console.WriteLine(@"  | ╚██████╗   ██║   ██████╔╝███████╗██║  ██║               |");
        Console.WriteLine(@"  |  ╚═════╝   ╚═╝   ╚═════╝ ╚══════╝╚═╝  ╚═╝               |");

        Console.ForegroundColor = ConsoleColor.DarkGreen;
        Console.WriteLine("    /\\  /\\    /\\  /\\    /\\  /\\    /\\  /\\           ");

        Console.ForegroundColor = ConsoleColor.Green;
        Console.WriteLine("  |                                                         |");
        Console.WriteLine("  |          A W A R E N E S S   B O T                      |");
        Console.WriteLine("  |  -------------------------------------------------------+");

        Console.ForegroundColor = ConsoleColor.Yellow;
        Console.WriteLine("  |        CYBERSECURITY PROTECTION SYSTEM                  |");

        Console.ForegroundColor = ConsoleColor.DarkGreen;
        Console.WriteLine("  |  -------------------------------------------------------+");
        Console.WriteLine("  |  v1.0.0     [ SECURE ][ AWARE ][ PROTECTED ]   ONLINE   |");
        Console.WriteLine("  |                 -- initialising... --                   |");
        Console.WriteLine("  |                                                         |");
        Console.WriteLine("  +---------------------------------------------------------+");

        Console.ResetColor();
        Console.WriteLine();
    }

    public static void PlayGreeting()
    {
        try
        {
            SoundPlayer player = new SoundPlayer("greeting.wav");
            player.PlaySync();
        }
        catch
        {
            PrintBotMessage("(Voice greeting file not found - skipping)");
        }
    }

    public static void ShowWelcomeMessage(string name)
    {
        Console.ForegroundColor = ConsoleColor.Cyan;
        Console.WriteLine("\n  ╔══════════════════════════════════════════════╗");
        Console.WriteLine($"   Welcome, {name}!".PadRight(49) + "║");
        Console.WriteLine("  ║  I am your Cybersecurity Awareness Bot.     ║");
        Console.WriteLine("  ║  I am here to help keep you safe online!  ║");
        Console.WriteLine("  ╚══════════════════════════════════════════════╝");
        Console.ResetColor();

        PrintDivider();

        Console.WriteLine("  Type a question and press Enter.");
        Console.WriteLine("   Type 'exit' to quit.\n");

        PrintDivider();
    }

    public static void PrintBotMessage(string message)
    {
        Console.ForegroundColor = ConsoleColor.Green;
        Console.Write("\n   Bot: ");
        Console.ResetColor();

        foreach (char letter in message)
        {
            Console.Write(letter);
            Thread.Sleep(18);
        }

        Console.WriteLine(); 
    }

    public static void PrintDivider()
    {
        Console.ForegroundColor = ConsoleColor.DarkCyan;
        Console.WriteLine("\n  ══════════════════════════════════════════════\n");
        Console.ResetColor();
    }
}