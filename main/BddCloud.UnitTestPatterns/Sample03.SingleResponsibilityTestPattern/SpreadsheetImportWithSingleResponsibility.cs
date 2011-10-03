namespace BddCloud.UnitTestPatterns.Sample03.SingleResponsibilityTestPattern
{
    public class SpreadsheetImportWithSingleResponsibility : ISpreadsheetImport
    {
        private readonly ISpreadsheetFactory _spreadsheetFactory;
        private readonly ICsvToSpreadsheetRowsParser _csvToSpreadsheetRowsParser;

        public SpreadsheetImportWithSingleResponsibility(ICsvToSpreadsheetRowsParser csvToSpreadsheetRowsParser, ISpreadsheetFactory spreadsheetFactory)
        {
            _spreadsheetFactory = spreadsheetFactory;
            _csvToSpreadsheetRowsParser = csvToSpreadsheetRowsParser; 
        }

        public void CreateSpreadsheetFromCSV(string csvPath, string spreadsheetPath)
        {
            _spreadsheetFactory.Create(_csvToSpreadsheetRowsParser.Parse(csvPath), spreadsheetPath);
        }
    }
}