using System.Collections.Generic;
using MavenThought.Commons.Testing;

namespace BddCloud.UnitTestPatterns.Test.Sample00.GivenWhenThenPattern
{
    public abstract class ListOfStringSpecificationWithICollectionContract : AutoMockSpecification<List<string>, ICollection<string>>
    {
        protected override ICollection<string> CreateSut()
        {
            return new List<string>();
        }

    }
}
