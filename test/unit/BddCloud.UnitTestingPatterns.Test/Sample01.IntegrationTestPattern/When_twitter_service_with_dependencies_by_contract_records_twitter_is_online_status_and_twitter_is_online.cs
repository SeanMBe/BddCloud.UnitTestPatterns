using BddCloud.UnitTestPatterns.Sample01.IntegrationTestPattern;
using MavenThought.Commons.Testing;
using NUnit.Framework;
using Rhino.Mocks;

namespace BddCloud.UnitTestPatterns.Test.Sample01.IntegrationTestPattern
{
    [Specification]
    public class When_twitter_service_with_dependencies_by_contract_records_twitter_is_online_status_and_twitter_is_online : TwitterServiceWithConcreteDependenciesSpecification
    {
        protected override void GivenThat()
        {
            base.GivenThat();

            Expected = true;
            Dep<IDependencyToSeeIfTwitterIsOnline>().Stub(o => o.IsTwitterOnline).Return(Expected);
        }

        protected override void WhenIRun()
        {
            Sut.RecordTheOnlineStatusOfTwitter();
        }

        [It]
        public void Should_record_expected_twitter_online_status_in_repository()
        {
            Dep<IDependencyForDatabaseRepository>()
                .AssertWasCalled(r => r.RecordTwitterOnlineStatus(Expected));
        }
    }
}