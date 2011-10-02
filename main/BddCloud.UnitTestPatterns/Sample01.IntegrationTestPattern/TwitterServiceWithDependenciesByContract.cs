using System;

namespace BddCloud.UnitTestPatterns.Sample01.IntegrationTestPattern
{
    public class TwitterServiceWithDependenciesByContract : ITwitterService
    {
        private readonly IDependencyToSeeIfTwitterIsOnline _dependencyTwitterWeb;
        private readonly IDependencyForDatabaseRepository _dependencyForDatabaseRepository;

        public TwitterServiceWithDependenciesByContract
            (IDependencyToSeeIfTwitterIsOnline dependencyTwitterWeb,
             IDependencyForDatabaseRepository dependencyForDatabaseRepository)
        {
            _dependencyTwitterWeb = dependencyTwitterWeb;
            _dependencyForDatabaseRepository = dependencyForDatabaseRepository;
        }

        public void RecordTheOnlineStatusOfTwitter()
        {
            var twitterOnlineStatus = _dependencyTwitterWeb.IsTwitterOnline;
            _dependencyForDatabaseRepository.RecordTwitterOnlineStatus(twitterOnlineStatus);
        }
    }
}
