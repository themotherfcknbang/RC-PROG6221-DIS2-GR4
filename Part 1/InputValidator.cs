class InputValidator
{

    public static bool IsEmpty(string input)
    {
     
        return string.IsNullOrWhiteSpace(input);
    }

    public static string GetDefaultResponse(string name)
    {
        return $"I didn't quite understand that, {name}. Could you rephrase? 🤔\n\n" +
               "    Try asking about: passwords, phishing, or safe browsing.\n" +
               "    Or type 'help' to see all topics!";
    }
}
