namespace BddCloud.UnitTestPatterns.Sample01.IntegrationTestPattern
{
    public class TwitterServiceWithConcreteDependencies
    {
        private readonly ConcreteDependencyToSeeIfTwitterIsOnline _dependencyTwitterWeb;
        private readonly ConcreteDependencyForDatabaseRepository _dependencyForDatabaseRepository;

        public TwitterServiceWithConcreteDependencies
            (ConcreteDependencyToSeeIfTwitterIsOnline dependencyTwitterWeb,
             ConcreteDependencyForDatabaseRepository dependencyForDatabaseRepository)
        {
            _dependencyTwitterWeb = dependencyTwitterWeb;
            _dependencyForDatabaseRepository = dependencyForDatabaseRepository;
        }

        public void RecordTwitterStatus()
        {
            var isTwitterOnline = _dependencyTwitterWeb.IsTwitterOnline();
            _dependencyForDatabaseRepository.RecordTwitterIsOnline(isTwitterOnline);
        }
    }
}