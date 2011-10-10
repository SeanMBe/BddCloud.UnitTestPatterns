using System.Collections.Generic;
using BddCloud.UnitTestPatterns.Sample00.GivenWhenThenPattern;
using MavenThought.Commons.Extensions;
using MavenThought.Commons.Testing;

namespace BddCloud.UnitTestPatterns.Test.Sample00.GivenWhenThenPattern
{
    public class ListOfStringSpecification : AutoMockSpecification<List<string>, IList<string>>
    {
        protected internal IEnumerable<string> InitialItems { get; set; }

        protected override void GivenThat()
        {
            base.GivenThat();

            InitialItems = Enumerable.Create("first", "second", "third");
        }

        protected override IList<string> CreateSut()
        {
            return new List<string>(InitialItems);
        }
    }
}
