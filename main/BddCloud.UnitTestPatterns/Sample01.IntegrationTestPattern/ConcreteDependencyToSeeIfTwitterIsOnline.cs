using System;

namespace BddCloud.UnitTestPatterns.Sample01.IntegrationTestPattern
{
    public class ConcreteDependencyToSeeIfTwitterIsOnline
    {
        public bool IsTwitterOnline()
        {
            throw new Exception("No internet connection");
        }
    }
}