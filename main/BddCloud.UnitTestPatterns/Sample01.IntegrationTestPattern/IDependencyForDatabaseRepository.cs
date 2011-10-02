using System;
using MavenThought.Commons;

namespace BddCloud.UnitTestPatterns.Sample01.IntegrationTestPattern
{
    public interface IDependencyForDatabaseRepository
    {
        DateTime RecordTwitterOnlineStatus(bool isTwitterOnline);
        Pair<DateTime, bool> LastOnlineStatus { get; }
    }
}