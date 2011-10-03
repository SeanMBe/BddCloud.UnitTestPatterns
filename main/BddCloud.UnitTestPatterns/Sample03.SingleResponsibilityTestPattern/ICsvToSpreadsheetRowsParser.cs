using System.Collections.Generic;
using MavenThought.Commons;

namespace BddCloud.UnitTestPatterns.Sample03.SingleResponsibilityTestPattern
{
    public interface ICsvToSpreadsheetRowsParser
    {
        IEnumerable<ISpreadsheetRow> Parse(string csvPath);
    }
}