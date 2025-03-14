using Lab2.Task3;
using Xunit;

namespace Lab2.Task3.Tests;


public class SingletoneTests
{
    [Fact]
    public async Task AuthenticatorMultithreading()
    {
        var tasks = new List<Task<Authenticator>>();
        for (int i = 0; i < 100; i++)
        {
            tasks.Add(Task.Run(() => Authenticator.GetInstance()));
        }

        var first = await tasks.First();
        foreach (var instance in tasks)
        {
            Assert.Same(first, await instance);
        }
    }

}
