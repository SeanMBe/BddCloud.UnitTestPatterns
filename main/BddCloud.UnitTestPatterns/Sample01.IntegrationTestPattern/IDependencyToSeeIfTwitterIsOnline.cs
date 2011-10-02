namespace BddCloud.UnitTestPatterns.Sample01.IntegrationTestPattern
{
    public interface IDependencyToSeeIfTwitterIsOnline
    {
        bool IsTwitterOnline { get; }
    }
}