using System.Collections.Generic;
using BddCloud.UnitTestPatterns.Sample03.SingleResponsibilityTestPattern;
using MavenThought.Commons.Extensions;
using MavenThought.Commons.Testing;
using Rhino.Mocks;

namespace BddCloud.UnitTestPatterns.Test.Sample03.SingleResponsibilityTestPattern
{
    public class When_spreadsheet_import_iwht_multiple_responsibilities_creates_spreadsheet_from_csv_file 
        : SpreadsheetImportWithMultipleResponsibilitiesSpecification
    {
        private string _csvInputPath;
        private IEnumerable<string> _lines;
        private string _spreadsheetOutputPath;
        private IEnumerable<IEnumerable<string>> _expectedRowAdds;

        protected override void GivenThat()
        {
            base.GivenThat();

            _spreadsheetOutputPath = "spreadsheetpath";

            _csvInputPath = "csvpath";

            _lines = Enumerable.Create("a,b,c,d", "e,f,g,h", "j,k,l,m");

            _expectedRowAdds = Enumerable.Create<IEnumerable<string>>(new[] {"a", "b", "c", "d"},
                                                                      new[] {"e", "f", "g", "h"},
                                                                      new[] {"j", "k", "l", "m"});
                                                                                                

            Dep<IFileReader>().Stub(r => r.ReadAllLines(Arg<string>.Is.Equal(_csvInputPath))).Return(_lines);

            Stub<ISpreadsheetCreationService, ISpreadsheet>(f => f.Create(Arg<string>.Is.Equal(_spreadsheetOutputPath)));
        }

        protected override void WhenIRun()
        {
            Sut.CreateSpreadsheetFromCSV(_csvInputPath, _spreadsheetOutputPath);
        }

        [It]
        public void Should_add_the_first_expected_line_to_the_spreadsheet()
        {
            Dep<ISpreadsheet>().AssertWasCalled(s => 
                s.AddRow(Arg<int>.Is.Equal(0), Arg<IEnumerable<string>>.Is.Equal(System.Linq.Enumerable.ElementAt(_expectedRowAdds, 0))));
        }

        [It]
        public void Should_add_the_second_expected_line_to_the_spreadsheet()
        {
            Dep<ISpreadsheet>().AssertWasCalled(s =>
                 s.AddRow(Arg<int>.Is.Equal(1), Arg<IEnumerable<string>>.Is.Equal(System.Linq.Enumerable.ElementAt(_expectedRowAdds, 1))));
        }

        [It]
        public void Should_add_the_third_expected_line_to_the_spreadsheet()
        {
            Dep<ISpreadsheet>().AssertWasCalled(s =>
                 s.AddRow(Arg<int>.Is.Equal(2), Arg<IEnumerable<string>>.Is.Equal(System.Linq.Enumerable.ElementAt(_expectedRowAdds, 2))));
        }

        [It]
        public void Should_save_the_spreadsheet()
        {
            Dep<ISpreadsheet>().AssertWasCalled(s => s.Save());
        }
    }
}