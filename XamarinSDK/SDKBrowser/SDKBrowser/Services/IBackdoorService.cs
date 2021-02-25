namespace SDKBrowser.Services
{
    public interface IBackdoorService
    {
        string NavigateToExample(string controlName, string exampleName);

        bool TryNavigateToExample(string controlName, string exampleName);
    }
}