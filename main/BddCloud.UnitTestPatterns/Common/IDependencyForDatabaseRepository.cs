using System;
using MavenThought.Commons;

namespace BddCloud.UnitTestPatterns.Common
{
    public interface IDependencyForDatabaseRepository
    {
        DateTime RecordTwitterOnlineStatus(bool isTwitterOnline);
        Pair<DateTime, bool> LastOnlineStatus { get; }
    }
}