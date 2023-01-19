using Microsoft.VisualStudio.TestPlatform.ObjectModel.DataCollection;

namespace TestProjectLifeTime;

public class CollectionFixture : IAsyncLifetime
{
    public CollectionFixture()
    {
        Write.Line("CollectionFixture : Constructor");
    }

    public Task InitializeAsync()
    {
        Write.Line("CollectionFixture : IAsyncLifetime : InitializeAsync");
        return Task.CompletedTask;
    }

    public Task DisposeAsync()
    {
        Write.Line("CollectionFixture : IAsyncLifetime : DisposeAsync");
        return Task.CompletedTask;
    }
}

[CollectionDefinition(nameof(CollectionFixture))]
public class Collection : ICollectionFixture<CollectionFixture>
{
    
}