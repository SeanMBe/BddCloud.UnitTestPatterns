using System.Collections.Generic;
using System.Linq;
using MavenThought.Commons.Testing;
using SharpTestsEx;

namespace BddCloud.UnitTestPatterns.Test.Sample00.GivenWhenThenPattern
{
    [ConstructorSpecification]
    public class When_list_of_string_with_enumerable_contract_is_constructed : ListOfStringSpecficationWithIEnumerableContract
    {
        protected override void GivenThat()
        {
            InitialItems = Enumerable.Empty<string>();
        }

        [It]
        public void Should_have_null_current_on_enumerator()
        {
            Sut.GetEnumerator().Current.Should().Be.Null();
        }

        [It]
        public void Should_have_expected_items_count()
        {
            Sut.Count().Should().Be(0);
        }
    }
}