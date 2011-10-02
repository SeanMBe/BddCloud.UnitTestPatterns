using BddCloud.UnitTestPatterns.Sample01.IntegrationTestPattern;
using MavenThought.Commons.Testing;

namespace BddCloud.UnitTestPatterns.Test.Sample01.IntegrationTestPattern
{
    public class TwitterServiceWithConcreteDependenciesSpecification : AutoMockSpecification<TwitterServiceWithDependenciesByContract, ITwitterService>
    {
        protected internal bool Expected { get; set; }
    }
}
