using System.Collections.Generic;
using MavenThought.Commons.Extensions;
using MavenThought.Commons.Testing;
using SharpTestsEx;

namespace BddCloud.UnitTestPatterns.Test.Sample00.GivenWhenThenPattern
{
    public class When_list_of_string_with_icollection_contract_clears_an_empty_list 
        : ListOfStringSpecificationWithICollectionContract
    {
        private IEnumerable<string> _initialItems;

        protected override void GivenThat()
        {
            base.GivenThat();

            _initialItems = Enumerable.Create("first", "second", "third");
        }

        protected override ICollection<string> CreateSut()
        {
            return new List<string>(_initialItems);
        }

        protected override void WhenIRun()
        {
            Sut.Clear();
        }

        [It]
        public void Should_have_no_items()
        {
            Sut.Count.Should().Be(0);
        }
    }
}
