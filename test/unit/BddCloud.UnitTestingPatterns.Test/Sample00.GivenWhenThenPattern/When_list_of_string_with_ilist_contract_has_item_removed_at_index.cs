using System.Collections.Generic;
using System.Linq;
using MavenThought.Commons.Extensions;
using Enumerable = MavenThought.Commons.Extensions.Enumerable;
using MavenThought.Commons.Testing;
using SharpTestsEx;

namespace BddCloud.UnitTestPatterns.Test.Sample00.GivenWhenThenPattern
{
    public class When_list_of_string_with_ilist_contract_has_item_removed_at_index : ListOfStringSpecificationWithIListContract
    {
        private IEnumerable<string> _expectedItems;
        private IEnumerable<int> _expectedIndexOf;

        protected override void GivenThat()
        {
            base.GivenThat();

            _expectedItems = Enumerable.Create("first", "third");
            _expectedIndexOf = Enumerable.Create(0, -1, 1);
        }

        protected override void WhenIRun()
        {
            Sut.RemoveAt(1);
        }

        [It]
        public void Should_have_expected_sequence()
        {
            Sut.Should().Have.SameSequenceAs(_expectedItems);
        }

        [It]
        public void Should_have_expected_index_of_for_second_item()
        {
            Sut.ForEach((i,e) => Sut.IndexOf(InitialItems.ElementAt(i)).Should().Be(_expectedIndexOf.ElementAt(i)));
        }
    }
}
