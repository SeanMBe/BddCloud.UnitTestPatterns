using System;

namespace BddCloud.UnitTestPatterns.Sample01.IntegrationTestPattern
{
    public class DependencyToSeeIfTwitterIsOnline : IDependencyToSeeIfTwitterIsOnline
    {
        public bool IsTwitterOnline
        {
            get { throw new Exception("No internet connection"); }
        }
    }
}