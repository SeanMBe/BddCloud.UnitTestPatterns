using System.Collections.Generic;
using System.Linq;
using MavenThought.Commons.Extensions;
using MavenThought.Commons.Testing;
using SharpTestsEx;
using Enumerable = MavenThought.Commons.Extensions.Enumerable;

namespace BddCloud.UnitTestPatterns.Test.Sample00.GivenWhenThenPattern
{
    public class When_list_of_string_has_item_inserted : ListOfStringSpecificationWithIListContract
    {
        private IEnumerable<string> _expected;

        protected override void GivenThat()
        {
            base.GivenThat();

            _expected = Enumerable.Create("first", "second", "expected", "third");
        }

        protected override void WhenIRun()
        {
            Sut.Insert(2, _expected.ElementAt(2));
        }

        [It]
        public void Should_have_expected_sequence()
        {
            _expected.ForEach((i, e) => Sut[i].Should().Be.EqualTo(e));
        }

        [It]
        public void Should_have_expected_for_index_of()
        {
            _expected.ForEach((i, e) => Sut.IndexOf(e).Should().Be(i));
        }
    }
}