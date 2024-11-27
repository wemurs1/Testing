using Xunit.Abstractions;

namespace Calculations.Test;

public class TestCollectionsOrderer : ITestCollectionOrderer
{
    public IEnumerable<ITestCollection> OrderTestCollections(IEnumerable<ITestCollection> testCollections)
    {
        return testCollections.OrderBy(x => x.DisplayName);
    }
}
