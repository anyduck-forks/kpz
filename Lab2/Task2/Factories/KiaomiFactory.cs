using Lab2.Task2.Devices;

namespace Lab2.Task2.Factories;


public class KiaomiFactory: IFactory
{
    public ILaptop CreateLaptop() => new KiaomiLaptop();
    public INetbook CreateNetbook() => new KiaomiNetbook();
    public IEBook CreateEBook() => new KiaomiEBook();
    public ISmartphone CreateSmartphone() => new KiaomiSmartphone();
}

public class KiaomiLaptop : ILaptop
{
    public string CPU => "Ryzen 5 3900";
    public string GPU => "Vega 8";  
}

public class KiaomiNetbook : INetbook
{
    public string Storage => "256 GB";
}

public class KiaomiEBook : IEBook
{
    public string Screen => "IPC 1080p";
}

public class KiaomiSmartphone : ISmartphone
{
    public string CPU => "Snapdragon 860";
}
