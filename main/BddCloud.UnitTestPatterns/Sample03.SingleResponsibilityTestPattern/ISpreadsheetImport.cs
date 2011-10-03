namespace BddCloud.UnitTestPatterns.Sample03.SingleResponsibilityTestPattern
{
    public interface ISpreadsheetImport
    {
        void CreateSpreadsheetFromCSV(string csvPath, string spreadsheetPath);
    }
}