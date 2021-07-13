using System;
using FreshMvvm;
using Xamarin.Forms;
using XFFreshMvvmNavigationSample.Services;

namespace XFFreshMvvmNavigationSample.PageModels
{
    public class FirstPageModel : FreshBasePageModel
    {
        public string FirstPageMessage { get; set; }

        public Command ClosePageCommand { get; set; }

        public FirstPageModel(IMyDataService myDataService)
        {
            ClosePageCommand = new Command(() =>
            {
                CoreMethods.PopPageModel(modal: true);
            });

            FirstPageMessage = myDataService.GetMessage();
        }
    }
}
