using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using MavenThought.Commons.Testing;
using SharpTestsEx;

namespace BddCloud.UnitTestPatterns.Test.Sample00.GivenWhenThenPattern
{
    public class When_list_of_string_with_icollection_contract_adds_item_to_empty_collection : ListOfStringSpecificationWithICollectionContract
    {
        private string _expected;

        protected override void GivenThat()
        {
            base.GivenThat();

            _expected = "expected";
        }

        protected override void WhenIRun()
        {
            Sut.Add(_expected);
        }

        [It]
        public void Should_contain_expected_item()
        {
            Sut.Contains(_expected);
        }

        [It]
        public void Should_have_count_of_one()
        {
            Sut.Count.Should().Be(1);
        }
    }
}
