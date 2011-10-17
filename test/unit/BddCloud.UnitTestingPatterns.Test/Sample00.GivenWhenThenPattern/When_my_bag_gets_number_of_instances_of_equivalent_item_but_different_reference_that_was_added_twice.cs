using System.Collections;
using MavenThought.Commons.Testing;
using NUnit.Framework;
using Rhino.Mocks;
using SharpTestsEx;

namespace BddCloud.UnitTestPatterns.Test.Sample00.GivenWhenThenPattern
{
    public class When_my_bag_gets_number_of_instances_of_equivalent_item_but_different_reference_that_was_added_twice
        : MyBagSpecification
    {
        private int _actual;
        private IEnumerable _mockFirstInstance;
        private IEnumerable _mockSecondInstanceThatIsEquivalentToFirstInstance;

        protected override void AndGivenThatAfterCreated()
        {
            base.AndGivenThatAfterCreated();

            _mockFirstInstance = Mock<IEnumerable>();
            _mockSecondInstanceThatIsEquivalentToFirstInstance = Mock<IEnumerable>();

            //this syntax is not allowing override of Equals
            //_mockFirstInstance.Stub(i => i.Equals(_mockSecondInstanceThatIsEquivalentToFirstInstance)).Return(true);
            //_mockSecondInstanceThatIsEquivalentToFirstInstance.Stub(i => i.Equals(Arg<object>.Is.Same(_mockFirstInstance))).Return(true);

            Sut.Add(_mockFirstInstance);
            Sut.Add(_mockSecondInstanceThatIsEquivalentToFirstInstance);
        }

        protected override void WhenIRun()
        {
            _actual = Sut.NumberOfEquivalentInstances(_mockSecondInstanceThatIsEquivalentToFirstInstance);
        }

        [It]
        public void Should_have_two_instances()
        {
            Assert.Inconclusive("Please implement this scenario");
            _actual.Should().Be(2);
        }
    }
}