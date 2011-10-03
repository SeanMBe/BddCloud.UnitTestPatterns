using System.Collections.Generic;
using MavenThought.Commons;

namespace BddCloud.UnitTestPatterns.Sample03.SingleResponsibilityTestPattern
{
    public interface ISpreadsheetFactory
    {
        void Create(IEnumerable<ISpreadsheetRow> rows, string spreadsheetPath);
    }
}