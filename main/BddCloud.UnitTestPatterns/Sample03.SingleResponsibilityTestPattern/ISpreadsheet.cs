using System.Collections.Generic;

namespace BddCloud.UnitTestPatterns.Sample03.SingleResponsibilityTestPattern
{
    public interface ISpreadsheet
    {
        bool AddRow(int rowIndex, IEnumerable<string> values);
        void Save();
    }
}