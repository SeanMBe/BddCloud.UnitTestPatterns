using System.Collections.Generic;
using MavenThought.Commons.Testing;
using SharpTestsEx;

namespace BddCloud.UnitTestPatterns.Test.Sample00.GivenWhenThenPattern
{
    [Specification]
    public class When_list_of_string_with_enumerable_contract_goes_to_next_item : ListOfStringSpecficationWithIEnumerableContract
    {
        private IEnumerator<string> _actualEnumerator;
        private bool _actualHasMore;

        protected override void AndGivenThatAfterCreated()
        {
            base.AndGivenThatAfterCreated();

            _actualEnumerator = Sut.GetEnumerator();
        }

        protected override void WhenIRun()
        {
            _actualHasMore = _actualEnumerator.MoveNext();
        }

        [It]
        public void Should_have_current_as_first_item()
        {
            _actualEnumerator.Current.Should().Be("first");
        }

        [It]
        public void Should_have_expected_items()
        {
            Sut.Should().Have.SameSequenceAs(InitialItems);
        }

        [It]
        public void Should_have_more_items()
        {
            _actualHasMore.Should().Be.True();
        }
    }
}