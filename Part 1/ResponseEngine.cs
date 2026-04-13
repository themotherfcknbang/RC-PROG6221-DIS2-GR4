
class ResponseEngine
{
   
    public static string GetResponse(string input, string name)
    {
        // General conversation
        if (input.Contains("how are you"))
            return $"I'm running perfectly, {name}! Always alert and ready to help! 😊";

        if (input.Contains("purpose") || input.Contains("what do you do"))
            return $"My purpose, {name}, is to teach you how to stay safe online!";

        if (input.Contains("what can i ask") || input.Contains("help") || input.Contains("topics"))
            return "You can ask me about:\n\n" +
                   "    Password safety\n" +
                   "    Phishing\n" +
                   "    Safe browsing\n" +
                   "    How I am\n" +
                   "    My purpose";

        // Password Safety
        if (input.Contains("password"))
            return $"Great question, {name}! Password tips:\n\n" +
                   "     Use at least 12 characters\n" +
                   "     Mix letters, numbers & symbols (e.g. P@ssw0rd!)\n" +
                   "     Never use your name or birthday\n" +
                   "     Use a different password for every account\n" +
                   "     Consider using a password manager!";

        // Phishing
        if (input.Contains("phishing") || input.Contains("phish"))
            return $"Phishing is when a bad person pretends to be someone\n" +
                   $"    you trust to steal your info, {name}!\n\n" +
                   "     Watch out for:\n" +
                   "     Emails asking for your password\n" +
                   "     Fake links like 'amaz0n.com'\n" +
                   "     Urgent messages like 'Act NOW!'\n" +
                   "     When in doubt — don't click!";

        // Safe Browsing
        if (input.Contains("browsing") || input.Contains("browse") ||
            input.Contains("internet") || input.Contains("website"))
            return $"Safe browsing tips, {name}:\n\n" +
                   "     Look for  HTTPS in the web address\n" +
                   "     Avoid clicking pop-up ads\n" +
                   "     Don't download files from unknown sites\n" +
                   "     Keep your browser updated!";

        return InputValidator.GetDefaultResponse(name);
    }
}
