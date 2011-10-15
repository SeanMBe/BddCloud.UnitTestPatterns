using MavenThought.Commons.Testing;
using SharpTestsEx;

namespace BddCloud.UnitTestPatterns.Test.Sample00.GivenWhenThenPattern
{
    [ConstructorSpecification]
    public class When_list_of_string_with_icollection_contract_is_created : ListOfStringSpecificationWithICollectionContract
    {
        [It]
        public void Should_have_count_of_zero()
        {
            Sut.Count.Should().Be(0);
        }
    }
}
