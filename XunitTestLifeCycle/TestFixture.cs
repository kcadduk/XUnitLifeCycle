using Xunit.Abstractions;

namespace TestProjectLifeTime;


public class TestFixture : IAsyncLifetime
{
    public ITestOutputHelper? OutputHelper { get; set; }
    public TestFixture()
    {
        Write.Line("TestFixture : Constructor");
    }
    public Task InitializeAsync()
    {
        Write.Line("TestFixture : IAsyncLifetime : InitializeAsync");
        return Task.CompletedTask;
    }

    public Task DisposeAsync()
    {
        Write.Line("TestFixture : IAsyncLifetime : DisposeAsync");
        return Task.CompletedTask;
    }
}