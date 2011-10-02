using BddCloud.UnitTestPatterns.Sample02.DependencyInjectionTestPattern;
using MavenThought.Commons.Testing;

namespace BddCloud.UnitTestPatterns.Test.Sample02.DependencyInjectionTestPattern
{
    public class TwitterServiceWithDependencyInjectionSpecification : AutoMockSpecificationWithNoContract<TwitterServiceWithDependencyInjection>
    {
        protected bool Expected { get; set; }
    }
}
