using System.Collections.Generic;
using BddCloud.UnitTestPatterns.Sample03.SingleResponsibilityTestPattern;
using MavenThought.Commons.Extensions;
using MavenThought.Commons.Testing;
using Rhino.Mocks;

namespace BddCloud.UnitTestPatterns.Test.Sample03.SingleResponsibilityTestPattern
{
    public class When_spreadsheet_import_with_single_responsibility_creates_spreadsheet_from_csv_file
        : SpreadsheetImportWithSingleResponsibilitySpecification
    {
        private string _csvInputPath;
        private string _expectedSpreadsheetOutputPath;
        private IEnumerable<ISpreadsheetRow> _expectedRows;

        protected override void GivenThat()
        {
            base.GivenThat();

            _csvInputPath = "csv input path";
            _expectedSpreadsheetOutputPath = "expected spreadsheet output path";
            _expectedRows = Enumerable.Create(Mock<ISpreadsheetRow>(), Mock<ISpreadsheetRow>(), Mock<ISpreadsheetRow>());
            Dep<ICsvToSpreadsheetRowsParser>().Stub(p => p.Parse(Arg<string>.Is.Equal(_csvInputPath))).Return(_expectedRows);
        }

        protected override void WhenIRun()
        {
            Sut.CreateSpreadsheetFromCSV(_csvInputPath, _expectedSpreadsheetOutputPath);
        }

        [It]
        public void Should_create_spread_sheet_with_expected_rows_and_output_path()
        {
            Dep<ISpreadsheetFactory>()
                .AssertWasCalled(f => f.Create( Arg<IEnumerable<ISpreadsheetRow>>.Is.Same(_expectedRows), 
                                                Arg<string>.Is.Equal(_expectedSpreadsheetOutputPath)));
        }
    }
}