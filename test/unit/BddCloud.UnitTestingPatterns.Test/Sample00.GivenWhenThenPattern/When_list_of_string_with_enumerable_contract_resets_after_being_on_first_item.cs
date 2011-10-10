using System.Collections.Generic;
using MavenThought.Commons.Extensions;
using MavenThought.Commons.Testing;
using SharpTestsEx;

namespace BddCloud.UnitTestPatterns.Test.Sample00.GivenWhenThenPattern
{
    [Specification]
    public class When_list_of_string_with_enumerable_contract_resets_after_being_on_first_item 
        : ListOfStringWithIEnumerableContractSpecification
    {
        private IEnumerator<string> _actualEnumerator;

        protected override void AndGivenThatAfterCreated()
        {
            base.AndGivenThatAfterCreated();

            _actualEnumerator = Sut.GetEnumerator();
            _actualEnumerator.MoveNext();
        }

        protected override void WhenIRun()
        {
            _actualEnumerator.Reset();
        }

        [It]
        public void Should_have_null_current_enumerator()
        {
            _actualEnumerator.Current.Should().Be.Null();
        }
    }
}
