using BddCloud.UnitTestPatterns.Common;

namespace BddCloud.UnitTestPatterns.Sample02.DependencyInjectionTestPattern
{
    public class TwitterServiceWithDependenciesByPropertySetters : ITwitterService
    {
        public IDependencyToSeeIfTwitterIsOnline DependencyForTwitterOnlineStatus { get; set; }
        
        public IDependencyForDatabaseRepository DependencyForDatabaseRepository { get; set; }

        public void RecordTheOnlineStatusOfTwitter()
        {
            if (DependencyForTwitterOnlineStatus != null)
            {
                var isTwitterOnline = DependencyForTwitterOnlineStatus.IsTwitterOnline;
                if (DependencyForDatabaseRepository != null)
                {
                    DependencyForDatabaseRepository.RecordTwitterOnlineStatus(isTwitterOnline);
                }
            }
        }
    }
}