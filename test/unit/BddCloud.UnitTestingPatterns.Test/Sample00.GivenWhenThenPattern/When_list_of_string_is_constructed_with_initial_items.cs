using System.Collections.Generic;
using MavenThought.Commons.Extensions;
using MavenThought.Commons.Testing;
using SharpTestsEx;
using System.Linq;
using Enumerable = MavenThought.Commons.Extensions.Enumerable;

namespace BddCloud.UnitTestPatterns.Test.Sample00.GivenWhenThenPattern
{
    [ConstructorSpecification]
    public class When_list_of_string_is_constructed_with_initial_items : ListOfStringSpecification
    {
        private IEnumerable<string> _expectedInitialItems;

        protected override void GivenThat()
        {
            base.GivenThat();

            _expectedInitialItems = Enumerable.Create("first", "second", "third");
        }

        protected override IList<string> CreateSut()
        {
            return new List<string>(_expectedInitialItems);
        }

        [It]
        public void Should_have_count_of_zero_for_collection()
        {
            Sut.Count.Should().Be.EqualTo(_expectedInitialItems.Count());
        }

        [It]
        public void Should_have_empty_enumerable()
        {
            Sut.Count().Should().Be.EqualTo(_expectedInitialItems.Count());
        }

        [It]
        public void Should_have_same_items_as_enumerable()
        {
            Sut.Should().Have.SameSequenceAs(_expectedInitialItems);
        }

        [It]
        public void Should_have_expected_items_using_indexor()
        {
            Sut.ForEach((i, s) => Sut[i].Should().Be.EqualTo(_expectedInitialItems.ElementAt(i)));
        }

        [It]
        public void Should_have_expected_index_for_each_initial_item()
        {
            Sut.ForEach((i, s) => Sut.IndexOf(s).Should().Be.EqualTo(i));
        }
    }
}