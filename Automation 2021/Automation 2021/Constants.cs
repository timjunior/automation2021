using System.Configuration;

namespace Automation_2021
{
    public class Constants
    {
        public static string BaseUrl = ConfigurationManager.AppSettings["BaseUrl"];
    }
}
