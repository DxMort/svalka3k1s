//Создать "ленивый"(lazy) синглтон Servers. Данный объект хранит список серверов ( в виде строк). Реализуйте следующую функциональность:
//1) Добавление сервера в список
//    1.1) Метод добавления должен возвращать true(если сервер добавлен) или false(если сервер не добавлен ).
//    1.2) Добавить можно только адреса, начинающиеся с http или https.
//    1.3) Добавление дубликата невозможно.
//2) Получить список серверов, адреса которых начинаются с 'http'.
//3) Получить список серверов, адреса которых начинаются с 'https'.

//Доп.задания:
//1*) Измените класс Servers так, чтобы его можно было использовать в многопоточном приложении (реализуйте механизм синхронизации).
//2*) Измените тип синглтона с "ленивого"(lazy) на "жадный"(eager).

class SingletonServers
{
    static SingletonServers instance = new SingletonServers();
    object _lock = new object();
    HashSet<string> _servers;

    public SingletonServers()
    {
        _servers = new HashSet<string>();
    }

    public static SingletonServers Instance
    {
        get
        {
            return instance;
        }
    }

    public bool AddServer(string address)
    {
        if (!address.StartsWith("http://") && !address.StartsWith("https://"))
        {
            return false;
        }
        lock (_lock)
        {
            return _servers.Add(address);
        }
    }

    public List<string> GetHttpServers()
    {
        lock (_lock)
        {
            return new List<string>(_servers.Where(server => server.StartsWith("http://")));
        }
    }

    public List<string> GetHttpsServers()
    {
        lock (_lock)
        {
            return new List<string>(_servers.Where(server => server.StartsWith("https://")));
        }
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