using System;
using MavenThought.Commons;

namespace BddCloud.UnitTestPatterns.Sample01.IntegrationTestPattern
{
    public class DependencyForDatabaseRepository : IDependencyForDatabaseRepository
    {
        public DateTime RecordTwitterOnlineStatus(bool isTwitterOnline)
        {
            throw new Exception("Database connection string incorrect");
        }

        public Pair<DateTime, bool> LastOnlineStatus
        {
            get { throw new Exception("Database connection string incorrect"); }
        }
    }
}