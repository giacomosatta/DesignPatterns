namespace SingletonPattern;

public class ConfigurationManager
{
    //Istanza Singleton privata 
    private static ConfigurationManager? instance;

    //Dati di configurazione
    private Dictionary<string, string> configurationData;

    //Costruttore privato perchè non deve essere richiamato all'esterno della classe
    private ConfigurationManager()
    {
        configurationData = new Dictionary<string, string>{
            {"Username","admin"},
            {"Password","psw123"}
        };
    }

    //Metodo pubblico per ottenere l'istanza Singleton
    //Se l'istanza non è creata ancora viene creata, sennò restituisce quella esistente
    public static ConfigurationManager Instance
    {
        get
        {
            if (instance == null)
                instance = new ConfigurationManager();

            return instance;
        }
    }

    // Metodo per ottenere un valore di configurazione specifico
    public string? GetConfigurationValue(string key)
    {
        if (configurationData.ContainsKey(key))
        {
            return configurationData[key];
        }
        else
        {
            return null; // Chiave non trovata
        }
    }
}