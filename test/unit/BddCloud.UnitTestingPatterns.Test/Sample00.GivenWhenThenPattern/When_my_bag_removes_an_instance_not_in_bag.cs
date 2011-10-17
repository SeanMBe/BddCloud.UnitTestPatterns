using System;
using MavenThought.Commons.Testing;
using SharpTestsEx;

namespace BddCloud.UnitTestPatterns.Test.Sample00.GivenWhenThenPattern
{
    [ExceptionSpecification]
    public class When_my_bag_removes_an_instance_not_in_bag : MyBagSpecification
    {
        protected override void WhenIRun()
        {
            Sut.Remove("not in bag");
        }

        [It]
        public void Should_throw_exception()
        {
            ExceptionThrown.GetType().Should().Be(typeof (Exception));
        }

        [It]
        public void Should_have_exception_message_of_not_found_in_bag()
        {
            ExceptionThrown.Message.Should().Be("Not found in bag");
        }
    }
}
