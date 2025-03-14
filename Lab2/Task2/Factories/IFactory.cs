using Lab2.Task2.Devices;

namespace Lab2.Task2.Factories;


public interface IFactory
{
    public ILaptop CreateLaptop();
    public INetbook CreateNetbook();
    public IEBook CreateEBook();
    public ISmartphone CreateSmartphone();
}
