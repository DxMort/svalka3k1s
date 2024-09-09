//Создать "ленивый"(lazy) синглтон Servers. Данный объект хранит список серверов ( в виде строк). Реализуйте следующую функциональность:
//1) Добавление сервера в список
//    1.1) Метод добавления должен возвращать true(если сервер добавлен) или false(если сервер не добавлен ).
//    1.2) Добавить можно только адреса, начинающиеся с http или https.
//    1.3) Добавление дубликата невозможно.
//2) Получить список серверов, адреса которых начинаются с 'http'.
//3) Получить список серверов, адреса которых начинаются с 'https'.

class SingletonServers
{
    static Lazy<SingletonServers> instance = new Lazy<SingletonServers>();
    public static SingletonServers Instance
    {
        get
        {
            return instance.Value;
        }
    }
    private HashSet<string> _servers;
    public SingletonServers()
    {
        _servers = new HashSet<string>();
    }
    public bool AddServer(string address)
    {
        if (!address.StartsWith("http://") && !address.StartsWith("https://"))
        {
            return false;
    }
        return _servers.Add(address);
    }

    public List<string> GetHttpServers()
    {
        return new List<string>(_servers.Where(server => server.StartsWith("http://")));
    }

    public List<string> GetHttpsServers()
    {
        return new List<string>(_servers.Where(server => server.StartsWith("https://")));
    }
}
class Program
{
    static void Main()
    {
        SingletonServers servers = SingletonServers.Instance;

        Console.WriteLine(servers.AddServer("http://yandex.ru/games/")); //T
        Console.WriteLine(servers.AddServer("https://youtube.com")); //T

        Console.WriteLine(servers.AddServer("http://yandex.ru/music")); //T
        Console.WriteLine(servers.AddServer("http://yandex.ru/music")); //F

        Console.WriteLine(servers.AddServer("https://olympic.nsu.ru/nsuts-new/login")); //T
        Console.WriteLine(servers.AddServer("https://olympic.nsu.ru/nsuts-new/login")); //F

        Console.WriteLine(servers.AddServer("ftp://zydin.com")); //F

        Console.WriteLine(string.Join(", ", servers.GetHttpServers()));
        Console.WriteLine(string.Join(", ", servers.GetHttpsServers()));
    }
}