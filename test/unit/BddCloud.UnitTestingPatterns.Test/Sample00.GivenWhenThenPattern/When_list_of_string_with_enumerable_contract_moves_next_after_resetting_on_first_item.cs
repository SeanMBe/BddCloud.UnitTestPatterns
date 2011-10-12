using System.Collections.Generic;
using System.Linq;
using MavenThought.Commons.Testing;
using SharpTestsEx;

namespace BddCloud.UnitTestPatterns.Test.Sample00.GivenWhenThenPattern
{
    [Specification]
    public class When_list_of_string_with_enumerable_contract_moves_next_after_resetting_on_first_item
        : ListOfStringSpecficationWithIEnumerableContract
    {
        private IEnumerator<string> _actualEnumerator;

        protected override void AndGivenThatAfterCreated()
        {
            base.AndGivenThatAfterCreated();

            _actualEnumerator = Sut.GetEnumerator();
            _actualEnumerator.MoveNext();
            _actualEnumerator.Reset();
        }

        protected override void WhenIRun()
        {
            _actualEnumerator.MoveNext();
        }

        [It]
        public void Should_have_expected_current_on_enumerator()
        {
            _actualEnumerator.Current.Should().Be(InitialItems.First());
        }
    }
}
