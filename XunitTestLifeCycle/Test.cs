using Xunit.Abstractions;

namespace TestProjectLifeTime;

[Collection(nameof(CollectionFixture))]
public class Test : IAsyncLifetime, IClassFixture<TestFixture>
{
    private readonly TestFixture _fixture;
    private readonly CollectionFixture _collectionFixture;

    public Test(TestFixture fixture, CollectionFixture collectionFixture, ITestOutputHelper outputHelper)
    {
        _fixture = fixture;
        _collectionFixture = collectionFixture;
        Write.Line("Constructing Test Case");
     }
    
    [Fact]
    public void TestLifeTime()
    {
        Write.Line("Running Test Case");
    }

    public Task InitializeAsync()
    {
        Write.Line("Test Case : IAsyncLifetime : InitializeAsync");
        return Task.CompletedTask;
    }

    public Task DisposeAsync()
    {
        Write.Line("Test Case : IAsyncLifetime : DisposeAsync");
        return Task.CompletedTask;
    }
}