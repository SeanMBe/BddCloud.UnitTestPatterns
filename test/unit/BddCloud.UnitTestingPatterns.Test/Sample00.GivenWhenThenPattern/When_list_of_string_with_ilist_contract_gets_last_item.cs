using System.Linq;
using MavenThought.Commons.Testing;
using SharpTestsEx;

namespace BddCloud.UnitTestPatterns.Test.Sample00.GivenWhenThenPattern
{
    public class When_list_of_string_with_ilist_contract_gets_last_item
        : ListOfStringSpecificationWithIListContract
    {
        private string _actual;

        protected override void WhenIRun()
        {
            _actual = Sut[InitialItems.Count() - 1];
        }

        [It]
        public void Should_be_the_last_item()
        {
            _actual.Should().Be(InitialItems.Last());
        }
    }
}
