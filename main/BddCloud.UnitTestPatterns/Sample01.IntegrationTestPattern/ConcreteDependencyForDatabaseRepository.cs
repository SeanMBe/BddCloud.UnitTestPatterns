using System;

namespace BddCloud.UnitTestPatterns.Sample01.IntegrationTestPattern
{
    public class ConcreteDependencyForDatabaseRepository
    {
        public void RecordTwitterIsOnline(bool isTwitterOnline)
        {
            throw new Exception("Database connection string incorrect");
        }
    }
}