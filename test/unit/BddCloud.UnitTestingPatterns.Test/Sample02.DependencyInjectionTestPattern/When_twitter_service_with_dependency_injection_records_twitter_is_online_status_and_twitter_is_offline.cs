using BddCloud.UnitTestPatterns.Common;
using MavenThought.Commons.Testing;
using Rhino.Mocks;

namespace BddCloud.UnitTestPatterns.Test.Sample02.DependencyInjectionTestPattern
{
    [Specification]
    public class When_twitter_service_with_dependency_injection_records_twitter_is_online_status_and_twitter_is_offline : TwitterServiceWithDependencyInjectionSpecification
    {
        protected override void WhenIRun()
        {
            Sut.RecordTheOnlineStatusOfTwitter();
        }

        [It]
        public void Should_record_expected_twitter_online_status_in_repository()
        {
            Dep<IDependencyForDatabaseRepository>()
                .AssertWasCalled(r => r.RecordTwitterOnlineStatus(false));
        }
    }
}