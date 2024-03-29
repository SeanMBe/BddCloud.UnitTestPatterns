﻿using System.Collections;

namespace BddCloud.UnitTestPatterns.Sample00.GivenWhenThenPattern
{
    public interface IAmThePublicApiForEnumerable<T> : IEnumerable
    {
        /// <summary>
        ///               Returns an enumerator that iterates through the collection.
        ///           </summary>
        /// <returns>
        ///               A <see cref="T:System.Collections.Generic.IEnumerator`1" /> that can be used to iterate through the collection.
        ///           </returns>
        /// <filterpriority>1</filterpriority>
        IAmThePublicApiForEnumerable<T> GetEnumerator();
    }
}