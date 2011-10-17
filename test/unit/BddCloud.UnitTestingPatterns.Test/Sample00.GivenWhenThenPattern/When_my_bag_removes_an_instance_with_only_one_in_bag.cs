using MavenThought.Commons.Testing;
using SharpTestsEx;

namespace BddCloud.UnitTestPatterns.Test.Sample00.GivenWhenThenPattern
{
    public class When_my_bag_removes_an_instance_with_only_one_in_bag : MyBagSpecification
    {
        private string _inBag = "in bag";

        protected override void AndGivenThatAfterCreated()
        {
            base.AndGivenThatAfterCreated();
        
            Sut.Add(_inBag);
        }

        protected override void WhenIRun()
        {
            Sut.Remove(_inBag);
        }

        [It]
        public void Should_contain_zero_instances_in_bag()
        {
            Sut.NumberOfEquivalentInstances(_inBag).Should().Be(0);
        }
    }
}