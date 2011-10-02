namespace BddCloud.UnitTestPatterns.Sample01.IntegrationTestPattern
{
    public class TwitterServiceWithConcreteDependencies : ITwitterService
    {
        private readonly DependencyToSeeIfTwitterIsOnline _dependencyTwitterWeb;
        private readonly DependencyForDatabaseRepository _dependencyForDatabaseRepository;

        public TwitterServiceWithConcreteDependencies
            (DependencyToSeeIfTwitterIsOnline dependencyTwitterWeb,
             DependencyForDatabaseRepository dependencyForDatabaseRepository)
        {
            _dependencyTwitterWeb = dependencyTwitterWeb;
            _dependencyForDatabaseRepository = dependencyForDatabaseRepository;
        }

        public void RecordTheOnlineStatusOfTwitter()
        {
            var isTwitterOnline = _dependencyTwitterWeb.IsTwitterOnline;
            _dependencyForDatabaseRepository.RecordTwitterOnlineStatus(isTwitterOnline);
        }
    }
}