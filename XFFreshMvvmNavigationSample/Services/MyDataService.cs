using System;
namespace XFFreshMvvmNavigationSample.Services
{
    public interface IMyDataService
    {
        string GetMessage();
    }

    public class MyDataService : IMyDataService
    {
        public string GetMessage()
        {
            return "Have you subscribed to my channel yet? ;)";
        }
    }
}
