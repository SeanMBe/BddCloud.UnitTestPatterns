namespace BddCloud.UnitTestPatterns.Sample03.SingleResponsibilityTestPattern
{
    public interface ISpreadsheetCreationService
    {
        ISpreadsheet Create(string path);
    }
}