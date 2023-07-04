using System.Text.RegularExpressions;

namespace TestDojo.Mocking;

public class NewApplication
{
    private readonly IInstaller _installer;

    public NewApplication(IInstaller installer)
    {
        _installer = installer;
    }

    public bool InstallApplication(string url)
    {
        if (!_installer.ValidateUrl(url)) return false;
        
        bool result;
        try
        {
            result = _installer.Install(url);
        }
        catch (Exception e)
        {
            Console.WriteLine(e);
            return false;
        }
        return result;
    }
}

public interface IInstaller
{
    bool Install(string url);
    bool ValidateUrl(string ur);  
}

public class Installer : IInstaller
{
    public bool Install(string url)
    {
        throw new NotImplementedException();
    }
    
    public bool ValidateUrl(string url)
    {
        // https://uibakery.io/regex-library/url-regex-csharp
        var regex = new Regex(
            "^https?:\\/\\/(?:www\\.)?[-a-zA-Z0-9@:%._\\+~#=]" +
            "{1,256}\\.[a-zA-Z0-9()]{1,6}\\b(?:[-a-zA-Z0-9()@:%_\\+.~#?&\\/=]*)$");
        return regex.IsMatch(url);
    }
}