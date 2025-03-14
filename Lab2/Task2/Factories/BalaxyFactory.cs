using Lab2.Task2.Devices;

namespace Lab2.Task2.Factories;


public class BalaxyFactory : IFactory
{
    public ILaptop CreateLaptop() => new BalaxyLaptop();
    public INetbook CreateNetbook() => new BalaxyNetbook();
    public IEBook CreateEBook() => new BalaxyEBook();
    public ISmartphone CreateSmartphone() => new BalaxySmartphone();
}

public class BalaxyLaptop : ILaptop
{
    public string CPU => "i5-8250U";
    public string GPU => "GTX 1050";  
}

public class BalaxyNetbook : INetbook
{
    public string Storage => "128 GB";
}

public class BalaxyEBook : IEBook
{
    public string Screen => "AMOLED";
}

public class BalaxySmartphone : ISmartphone
{
    public string CPU => "Exynos";
}
