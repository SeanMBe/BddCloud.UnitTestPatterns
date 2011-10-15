using System;
using System.Collections.Generic;
using System.Linq;
using MavenThought.Commons.Testing;
using SharpTestsEx;

namespace BddCloud.UnitTestPatterns.Test.Sample00.GivenWhenThenPattern
{
    [ExceptionSpecification]
    public class When_list_of_string_with_ilist_contract_gets_item_with_an_out_of_bounds_index : ListOfStringSpecificationWithIListContract
    {
        private ArgumentOutOfRangeException _expectedException;

        protected override void GivenThat()
        {
            base.GivenThat();

            _expectedException = new ArgumentOutOfRangeException("index", "Index was out of range. Must be non-negative and less than the size of the collection.");
        }

        protected override void WhenIRun()
        {
            Actual = Sut[InitialItems.Count()];
        }

        [It]
        public void Should_throw_expected_exception()
        {
            ExceptionThrown.GetType().Should().Be(_expectedException.GetType());
        }

        [It]
        public void Should_have_expected_exception_message()
        {
            ExceptionThrown.Message.Should().Be.EqualTo(_expectedException.Message);
        }

        [It]
        public void Should_have_expected_inner_exception()
        {
            ExceptionThrown.InnerException.Should().Be(_expectedException.InnerException);
        }
    }
}