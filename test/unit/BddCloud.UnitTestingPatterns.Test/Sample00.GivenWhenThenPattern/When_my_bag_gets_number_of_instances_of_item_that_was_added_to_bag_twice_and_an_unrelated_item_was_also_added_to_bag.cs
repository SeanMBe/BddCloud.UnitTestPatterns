using MavenThought.Commons.Testing;
using SharpTestsEx;

namespace BddCloud.UnitTestPatterns.Test.Sample00.GivenWhenThenPattern
{
    public class When_my_bag_gets_number_of_instances_of_item_that_was_added_to_bag_twice_and_an_unrelated_item_was_also_added_to_bag 
        : MyBagSpecification
    {
        private int _actual;

        protected override void AndGivenThatAfterCreated()
        {
            base.AndGivenThatAfterCreated();

            Sut.Add("this is in bag twice");
            Sut.Add("this is in bag twice");
            Sut.Add("this is in bag twice ...actually this is a different instance in bag");
        }

        protected override void WhenIRun()
        {
            _actual = Sut.NumberOfEquivalentInstances("this is in bag twice");
        }

        [It]
        public void Should_contain_two_instances()
        {
            _actual.Should().Be(2);
        }
    }
}