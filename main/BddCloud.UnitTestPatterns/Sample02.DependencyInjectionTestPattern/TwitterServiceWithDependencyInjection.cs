using BddCloud.UnitTestPatterns.Common;

namespace BddCloud.UnitTestPatterns.Sample02.DependencyInjectionTestPattern
{
    public class TwitterServiceWithDependencyInjection : ITwitterService
    {
        private readonly IDependencyToSeeIfTwitterIsOnline _dependencyForTwitterOnlineStatus;
        private readonly IDependencyForDatabaseRepository _dependencyForDatabaseRepository;

        public TwitterServiceWithDependencyInjection
            (IDependencyToSeeIfTwitterIsOnline dependencyForTwitterOnlineStatus,
             IDependencyForDatabaseRepository dependencyForDatabaseRepository)
        {
            _dependencyForTwitterOnlineStatus = dependencyForTwitterOnlineStatus;
            _dependencyForDatabaseRepository = dependencyForDatabaseRepository;
        }

        public void RecordTheOnlineStatusOfTwitter()
        {
            var twitterOnlineStatus = _dependencyForTwitterOnlineStatus.IsTwitterOnline;
            _dependencyForDatabaseRepository.RecordTwitterOnlineStatus(twitterOnlineStatus);
        }
    }
}
