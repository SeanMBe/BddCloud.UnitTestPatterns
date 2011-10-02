using System;
using BddCloud.UnitTestPatterns.Sample01.IntegrationTestPattern;
using MavenThought.Commons.Testing;
using SharpTestsEx;

namespace BddCloud.UnitTestPatterns.Test.Sample01.IntegrationTestPattern
{
    [Specification]
    public class When_twitter_service_with_concrete_dependencies_records_twitter_is_online_status : TwitterServiceWithConcreteDependenciesSpecification
    {
        private DependencyToSeeIfTwitterIsOnline _dependencyToSeeIfTwitterIsOnline;
        private DependencyForDatabaseRepository _dependencyForTwitterDatabaseRepository;
        private DateTime _timeBeforeRecordingTwitterWebsiteIsOnline;

        protected override void GivenThat()
        {
            base.GivenThat();

            _dependencyToSeeIfTwitterIsOnline = new DependencyToSeeIfTwitterIsOnline();
            _dependencyForTwitterDatabaseRepository = new DependencyForDatabaseRepository();
        }

        protected override ITwitterService CreateSut()
        {
            return new TwitterServiceWithConcreteDependencies(_dependencyToSeeIfTwitterIsOnline, _dependencyForTwitterDatabaseRepository);
        }

        protected override void AndGivenThatAfterCreated()
        {
            base.AndGivenThatAfterCreated();

            _timeBeforeRecordingTwitterWebsiteIsOnline = DateTime.Now;
        }
        
        protected override void WhenIRun()
        {
            Sut.RecordTheOnlineStatusOfTwitter();
        }

        [It]
        public void Should_contain_twitter_status_in_repository_that_was_just_recorded()
        {
            _dependencyForTwitterDatabaseRepository
                .LastOnlineStatus.First.Should().Be.GreaterThanOrEqualTo(_timeBeforeRecordingTwitterWebsiteIsOnline)
                .And.Be.LessThanOrEqualTo(_timeBeforeRecordingTwitterWebsiteIsOnline.AddSeconds(5));
        }
    }
}