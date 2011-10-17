using MavenThought.Commons.Testing;
using SharpTestsEx;

namespace BddCloud.UnitTestPatterns.Test.Sample00.GivenWhenThenPattern
{
    public class When_my_bag_gets_number_of_instances_of_item_not_in_bag : MyBagSpecification
    {
        private int _actual;

        protected override void WhenIRun()
        {
            _actual = Sut.NumberOfEquivalentInstances("not in bag");
        }  

        [It]
        public void Should_contain_zero_instances()
        {
            _actual.Should().Be(0);
        }
    }
}