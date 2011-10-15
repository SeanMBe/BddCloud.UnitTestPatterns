using MavenThought.Commons.Testing;
using SharpTestsEx;
using System.Linq;

namespace BddCloud.UnitTestPatterns.Test.Sample00.GivenWhenThenPattern
{
    [ConstructorSpecification]
    public class When_list_of_string_with_ilist_contract_is_constructed_with_initial_items : ListOfStringSpecificationWithIListContract
    {
        [It]
        public void Should_have_expected_number_of_items_in_collection()
        {
            Sut.Count.Should().Be.EqualTo(InitialItems.Count());
        }

        [It]
        public void Should_have_expected_number_of_items_in_enumerable()
        {
            Sut.Count().Should().Be.EqualTo(InitialItems.Count());
        }

        [It]
        public void Should_have_same_items_as_expected_in_enumerable()
        {
            Sut.Should().Have.SameSequenceAs(InitialItems);
        }
    }
}