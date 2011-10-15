using System.Collections.Generic;
using System.Linq;
using MavenThought.Commons.Testing;
using SharpTestsEx;
using Enumerable = MavenThought.Commons.Extensions.Enumerable;

namespace BddCloud.UnitTestPatterns.Test.Sample00.GivenWhenThenPattern
{
    public class When_list_of_string_with_ilist_contract_has_item_assigned_to_second_index: ListOfStringSpecificationWithIListContract
    {
        private IEnumerable<string> _expected;

        protected override void GivenThat()
        {
            base.GivenThat();

            _expected = Enumerable.Create("first", "expected", "third");
        }

        protected override void WhenIRun()
        {
            Sut[1] = _expected.ElementAt(1);
        }

        [It]
        public void Should_have_expected_sequence()
        {
            Sut.Should().Have.SameSequenceAs(_expected);
        }
    }
}