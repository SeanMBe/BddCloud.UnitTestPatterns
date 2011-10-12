using System.Collections.Generic;
using MavenThought.Commons.Extensions;
using MavenThought.Commons.Testing;

namespace BddCloud.UnitTestPatterns.Test.Sample00.GivenWhenThenPattern
{
    public abstract class ListOfStringSpecficationWithIEnumerableContract : AutoMockSpecification<List<string>,IEnumerable<string>>
    {
        protected internal IEnumerable<string> InitialItems { get; set; }

        protected override void GivenThat()
        {
            base.GivenThat();

            InitialItems = Enumerable.Create("first", "second", "third");
        }

        protected override IEnumerable<string> CreateSut()
        {
            return new List<string>(InitialItems);
        }
    }
}
