using MavenThought.Commons.Extensions;
using MavenThought.Commons.Testing;
using SharpTestsEx;

namespace BddCloud.UnitTestPatterns.Test.Sample00.GivenWhenThenPattern
{
    public class When_my_bag_removes_an_instance_with_two_in_bag : MyBagSpecification
    {
        private string _inBag = "in bag";

        protected override void AndGivenThatAfterCreated()
        {
            base.AndGivenThatAfterCreated();

            2.Times(() => Sut.Add(_inBag));
        }

        protected override void WhenIRun()
        {
            Sut.Remove(_inBag);
        }

        [It]
        public void Should_contain_one_instance_in_bag()
        {
            Sut.NumberOfEquivalentInstances(_inBag).Should().Be(1);
        }
    }
}