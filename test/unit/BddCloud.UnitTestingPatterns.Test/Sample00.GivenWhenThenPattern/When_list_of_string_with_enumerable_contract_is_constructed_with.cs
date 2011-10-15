using MavenThought.Commons.Testing;
using SharpTestsEx;

namespace BddCloud.UnitTestPatterns.Test.Sample00.GivenWhenThenPattern
{
    [ConstructorSpecification]
    public class When_list_of_string_with_enumerable_contract_is_constructed_with : ListOfStringSpecficationWithIEnumerableContract
    {
        [It]
        public void Should_have_null_current_for_enumerator()
        {
            Sut.GetEnumerator().Current.Should().Be.Null();
        }

        [It]
        public void Should_have_expected_items()
        {
            Sut.Should().Have.SameSequenceAs(InitialItems);
        }
    }
}