using System.Collections.Generic;

namespace BddCloud.UnitTestPatterns.Sample03.SingleResponsibilityTestPattern
{
    public interface IFileReader
    {
        IEnumerable<string> ReadAllLines(string path);
    }
}