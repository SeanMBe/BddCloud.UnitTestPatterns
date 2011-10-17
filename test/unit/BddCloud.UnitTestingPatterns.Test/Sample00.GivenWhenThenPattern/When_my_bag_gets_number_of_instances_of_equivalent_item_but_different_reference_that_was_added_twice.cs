using MavenThought.Commons.Testing;
using SharpTestsEx;

namespace BddCloud.UnitTestPatterns.Test.Sample00.GivenWhenThenPattern
{
    public class When_my_bag_gets_number_of_instances_of_equivalent_items_with_same_hash_code_but_different_reference_types
        : MyBagSpecification
    {
        private int _actual;
        private MockReferenceType1 _mockFirstInstance;
        private MockReferenceType2 _mockSecondInstanceThatIsEquivalentToFirstInstance;
        private MockReferenceType2 _mockThirdInstanceThatIsEquivalentToFirstInstance;
        private MockReferenceType1 _mockReferenceTypeThatIsNotEquivalentToOtherThree;

        protected override void AndGivenThatAfterCreated()
        {
            base.AndGivenThatAfterCreated();
            
            const int hashCodeForTwoInstances = 8;
            const int hashCodForOtherInstance = hashCodeForTwoInstances + 1;

            _mockFirstInstance = new MockReferenceType1(hashCodeForTwoInstances);
            _mockSecondInstanceThatIsEquivalentToFirstInstance = new MockReferenceType2(hashCodeForTwoInstances);
            _mockThirdInstanceThatIsEquivalentToFirstInstance = new MockReferenceType2(hashCodeForTwoInstances);
            _mockReferenceTypeThatIsNotEquivalentToOtherThree = new MockReferenceType1(hashCodForOtherInstance);

            Sut.Add(_mockFirstInstance);
            Sut.Add(_mockSecondInstanceThatIsEquivalentToFirstInstance);
            Sut.Add(_mockThirdInstanceThatIsEquivalentToFirstInstance);
            Sut.Add(_mockReferenceTypeThatIsNotEquivalentToOtherThree);
        }

        protected override void WhenIRun()
        {
            _actual = Sut.NumberOfEquivalentInstances(_mockSecondInstanceThatIsEquivalentToFirstInstance);
        }

        [It]
        public void Should_have_three_instances()
        {
          _actual.Should().Be(3);
        }
    }
}