using System.Collections.Generic;

namespace BddCloud.UnitTestPatterns.Sample00.GivenWhenThenPattern
{
    public class MyBag : IBag
    {
        private readonly IDictionary<object, int> _instanceCounts;

        public MyBag()
        {
            _instanceCounts = new Dictionary<object, int>();
        }

        /// <summary>
        /// Gets the number of occurences of the instance in bag.
        /// </summary>
        /// <param name="instance">Instance to get count of</param>
        /// <returns>The number of instances of object in bag. 0 if no instances are found in bag.</returns>
        public int NumberOfEquivalentInstances(object instance)
        {
            return _instanceCounts[instance];
        }

        /// <summary>
        /// Add an instance to the bag.
        /// </summary>
        /// <param name="instance">Instance to add to bag.</param>
        public void Add(object instance)
        {
            if(_instanceCounts.ContainsKey(instance))
            {
                _instanceCounts[instance] += 1;
            }
            else
            {
                _instanceCounts.Add(instance, 1);
            }
        }

        /// <summary>
        /// Remove an instance from the bag.
        /// </summary>
        /// <param name="instance">Instance to remove from bag. If no instance is found, throw an exception.</param>
        public void Remove(object instance)
        {
        }
    }
}