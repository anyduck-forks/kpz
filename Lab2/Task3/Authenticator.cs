namespace Lab2.Task3;

public sealed class Authenticator
{
    private static Authenticator? _instance;
    private static readonly object _lock = new object();

    private Authenticator() { }

    public static Authenticator GetInstance()
    {
        if (_instance == null)
        {
            lock (_lock)
            {
                if (_instance == null)
                {
                    _instance = new Authenticator();
                }
            }
        }
        return _instance;
    }

    public bool Login(string username, string password)
    {
        return username == "admin" && password == "admin";
    }
}