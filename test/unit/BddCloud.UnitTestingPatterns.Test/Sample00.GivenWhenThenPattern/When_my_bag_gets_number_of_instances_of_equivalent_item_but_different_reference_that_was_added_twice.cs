using BddCloud.UnitTestPatterns.Test.Sample00.GivenWhenThenPattern.Common;
using MavenThought.Commons.Testing;
using SharpTestsEx;

namespace BddCloud.UnitTestPatterns.Test.Sample00.GivenWhenThenPattern
{
    public class When_my_bag_gets_number_of_instances_of_equivalent_items_with_same_hash_code_but_different_reference_types
        : MyBagSpecification
    {
        private int _actual;
        private MockReferenceType1 _mockFirstReferenceType1InstanceWithHashCode1;
        private MockReferenceType2 _mockFirstReferenceType2InstanceWithHashCode1;
        private MockReferenceType2 _mockSecondReferenceType2InstanceWithHashCode1;
        private MockReferenceType1 _mockSecondReferenceType1InstanceButWithHashCode2;

        protected override void AndGivenThatAfterCreated()
        {
            base.AndGivenThatAfterCreated();
            
            const int hashCode1 = 8;
            const int hashCod2 = hashCode1 + 1;

            _mockFirstReferenceType1InstanceWithHashCode1 = new MockReferenceType1(hashCode1);
            _mockFirstReferenceType2InstanceWithHashCode1 = new MockReferenceType2(hashCode1);
            _mockSecondReferenceType2InstanceWithHashCode1 = new MockReferenceType2(hashCode1);
            _mockSecondReferenceType1InstanceButWithHashCode2 = new MockReferenceType1(hashCod2);

            Sut.Add(_mockFirstReferenceType1InstanceWithHashCode1);
            Sut.Add(_mockFirstReferenceType2InstanceWithHashCode1);
            Sut.Add(_mockSecondReferenceType2InstanceWithHashCode1);
            Sut.Add(_mockSecondReferenceType1InstanceButWithHashCode2);
        }

        protected override void WhenIRun()
        {
            _actual = Sut.NumberOfEquivalentInstances(_mockFirstReferenceType2InstanceWithHashCode1);
        }

        [It]
        public void Should_have_three_instances()
        {
          _actual.Should().Be(3);
        }
    }
}