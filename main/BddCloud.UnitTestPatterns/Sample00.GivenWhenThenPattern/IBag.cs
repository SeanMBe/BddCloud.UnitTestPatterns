namespace BddCloud.UnitTestPatterns.Sample00.GivenWhenThenPattern
{
    public interface IBag
    {
        /// <summary>
        /// Gets the number of occurences of the instance in bag.
        /// </summary>
        /// <param name="instance">Instance to get count of</param>
        /// <returns>The number of instances of object in bag. 0 if no instances are found in bag.</returns>
        int NumberOfEquivalentInstances(object instance);

        /// <summary>
        /// Add an instance to the bag.
        /// </summary>
        /// <param name="instance">Instance to add to bag.</param>
        void Add(object instance);

        /// <summary>
        /// Remove an instance from the bag.
        /// </summary>
        /// <param name="instance">Instance to remove from bag. If no instance is found, throw an exception.</param>
        void Remove(object instance);
    }
}
