using System.Linq;
using MavenThought.Commons.Testing;
using SharpTestsEx;

namespace BddCloud.UnitTestPatterns.Test.Sample00.GivenWhenThenPattern
{
    public class When_list_of_string_with_ilist_contract_gets_first_item
        : ListOfStringSpecificationWithIListContract
    {
        private string _actual;

        protected override void WhenIRun()
        {
            _actual = Sut[0];
        }

        [It]
        public void Should_be_the_first_item()
        {
            _actual.Should().Be.EqualTo(InitialItems.First());
        }
    }
}
