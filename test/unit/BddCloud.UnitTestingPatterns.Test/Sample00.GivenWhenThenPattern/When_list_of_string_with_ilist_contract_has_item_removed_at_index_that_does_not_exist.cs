﻿using System;
using System.Collections.Generic;
using MavenThought.Commons.Extensions;
using MavenThought.Commons.Testing;
using SharpTestsEx;

namespace BddCloud.UnitTestPatterns.Test.Sample00.GivenWhenThenPattern
{
    [ExceptionSpecification]
    public class When_list_of_string_with_ilist_contract_has_item_removed_that_does_not_exist : ListOfStringSpecificationWithIListContract
    {
        private ArgumentOutOfRangeException _expectedException;

        protected override void GivenThat()
        {
            base.GivenThat();

            InitialItems = Enumerable.Create("first", "second");
            _expectedException = new ArgumentOutOfRangeException("index", "Index was out of range. Must be non-negative and less than the size of the collection.");
        }

        protected override void WhenIRun()
        {
            Sut.RemoveAt(2);
        }

        [It]
        public void Should_throw_expected_exception()
        {
            ExceptionThrown.GetType().Should().Be(_expectedException.GetType());
        }

        [It]
        public void Should_have_expected_exception_message()
        {
            ExceptionThrown.Message.Should().Be.EqualTo(_expectedException.Message);
        }  
    }
}
