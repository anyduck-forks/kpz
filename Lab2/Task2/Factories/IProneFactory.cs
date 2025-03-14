using Lab2.Task2.Devices;

namespace Lab2.Task2.Factories;


public class IProneFactory: IFactory
{
    public ILaptop CreateLaptop() => new IProneLaptop();
    public INetbook CreateNetbook() => new IProneNetbook();
    public IEBook CreateEBook() => new IProneEBook();
    public ISmartphone CreateSmartphone() => new IProneSmartphone();
}

public class IProneLaptop : ILaptop
{
    public string CPU => "M2 Max";
    public string GPU => "M2 Max";  
}

public class IProneNetbook : INetbook
{
    public string Storage => "32 GB";
}

public class IProneEBook : IEBook
{
    public string Screen => "OLED 4K";
}

public class IProneSmartphone : ISmartphone
{
    public string CPU => "A12";
}
