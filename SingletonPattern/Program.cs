namespace SingletonPattern;

class Program
{
    static void Main()
    {
        //Ottenere l'istanza del singleton
        ConfigurationManager configurationManager = ConfigurationManager.Instance;

        string? username = configurationManager.GetConfigurationValue("Username");
        string? password = configurationManager.GetConfigurationValue("Password");

        Console.WriteLine($"Username:{username}, Password:{password}");
    }
}