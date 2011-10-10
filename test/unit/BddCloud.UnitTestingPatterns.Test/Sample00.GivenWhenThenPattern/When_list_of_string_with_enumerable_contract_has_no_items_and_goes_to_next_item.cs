using System.Collections.Generic;
using System.Linq;
using MavenThought.Commons.Testing;
using SharpTestsEx;

namespace BddCloud.UnitTestPatterns.Test.Sample00.GivenWhenThenPattern
{
    [Specification]
    public class When_list_of_string_with_enumerable_contract_has_no_items_and_goes_to_next_item : ListOfStringWithIEnumerableContractSpecification
    {     
        private IEnumerator<string> _actualEnumerator;
        private bool _actual;

        protected override void GivenThat()
        {
            InitialItems = Enumerable.Empty<string>();
        }

        protected override void AndGivenThatAfterCreated()
        {
            base.AndGivenThatAfterCreated();

            _actualEnumerator = Sut.GetEnumerator();
        }

        protected override void WhenIRun()
        {
            _actual = _actualEnumerator.MoveNext();
        }

        [It]
        public void Should_return_false_for_having_more_items()
        {
            _actual.Should().Be.Equals(true);
        }
    }
}