using System.Linq;
using MavenThought.Commons.Extensions;
using Enumerable = MavenThought.Commons.Extensions.Enumerable;
using MavenThought.Commons.Testing;
using SharpTestsEx;

namespace BddCloud.UnitTestPatterns.Test.Sample00.GivenWhenThenPattern
{


public class When_list_of_string_with_ilist_contract_has_item_removed 
    : ListOfStringSpecificationWithIListContract
{
    protected override void GivenThat()
    {
        base.GivenThat();

        this.InitialItems = Enumerable.Create("first", "second");
    }

    protected override void WhenIRun()
    {
        Sut.RemoveAt(1);
    }

    [It]
    public void Should_have_count_of_one()
    {
        Sut.Count.Should().Be(1);
    }

    [It]
    public void Should_have_first_item()
    {
        Sut.Contains("first").Should().Be.True();
    }

    [It]
    public void Should_not_have_second_item()
    {
        Sut.Contains("second").Should().Be.False();
    }
}
}
