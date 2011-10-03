using System;
using MavenThought.Commons.Extensions;

namespace BddCloud.UnitTestPatterns.Sample03.SingleResponsibilityTestPattern
{
    public class SpreadsheetImportWithMultipleResponsibilities : ISpreadsheetImport
    {
        private readonly IFileReader _fileReader;
        private readonly ISpreadsheetCreationService _spreadsheetCreationService;

        public SpreadsheetImportWithMultipleResponsibilities(IFileReader fileReader, ISpreadsheetCreationService spreadsheetCreationService)
        {
            _fileReader = fileReader;
            _spreadsheetCreationService = spreadsheetCreationService;
        }

        public void CreateSpreadsheetFromCSV(string csvPath, string spreadsheetPath)
        {
            var lines = _fileReader.ReadAllLines(csvPath);
            var spreadsheet = _spreadsheetCreationService.Create(spreadsheetPath);
            lines.ForEach((i,l) => spreadsheet.AddRow(i, l.Split(new[] {','})));
            spreadsheet.Save();
        }
    }
}