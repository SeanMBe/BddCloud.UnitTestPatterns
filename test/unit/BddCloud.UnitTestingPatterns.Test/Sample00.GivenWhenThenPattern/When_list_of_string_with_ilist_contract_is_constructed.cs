using System.Collections.Generic;
using MavenThought.Commons.Testing;
using SharpTestsEx;

namespace BddCloud.UnitTestPatterns.Test.Sample00.GivenWhenThenPattern
{
    [ConstructorSpecification]
    public class When_list_of_string_with_ilist_contract_is_constructed : ListOfStringSpecificationWithIListContract
    {
        protected override IList<string> CreateSut()
        {
            return new List<string>();
        }

        [It]
        public void Should_have_count_of_zero_for_collection()
        {
            Sut.Count.Should().Be.EqualTo(0);
        }

        [It]
        public void Should_have_empty_enumerable()
        {
            Sut.Should().Be.Empty();
        }
    }
}