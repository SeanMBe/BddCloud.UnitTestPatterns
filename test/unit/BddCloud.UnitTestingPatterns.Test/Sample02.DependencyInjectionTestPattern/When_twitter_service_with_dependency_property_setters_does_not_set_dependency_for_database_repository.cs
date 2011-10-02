using BddCloud.UnitTestPatterns.Common;
using MavenThought.Commons.Testing;
using Rhino.Mocks;

namespace BddCloud.UnitTestPatterns.Test.Sample02.DependencyInjectionTestPattern
{
    [Specification]
    public class When_twitter_service_with_dependency_property_setters_does_not_set_dependency_for_database_repository : TwitterServiceWithDependenciesByPropertySettersSpecification
    {
        protected override void AndGivenThatAfterCreated()
        {
            base.AndGivenThatAfterCreated();

            ConcreteSut.DependencyForTwitterOnlineStatus = Dep<IDependencyToSeeIfTwitterIsOnline>();
        }

        protected override void WhenIRun()
        {
            Sut.RecordTheOnlineStatusOfTwitter();
        }

        [It]
        public void Should_not_record_twitter_online_status_in_repository()
        {
            Dep<IDependencyForDatabaseRepository>().AssertWasNotCalled(r => r.RecordTwitterOnlineStatus(Arg<bool>.Is.Anything));
        }
    }
}