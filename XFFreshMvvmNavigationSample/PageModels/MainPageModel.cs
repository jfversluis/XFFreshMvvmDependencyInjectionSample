using System;
using FreshMvvm;
using Xamarin.Forms;

namespace XFFreshMvvmNavigationSample.PageModels
{
    public class MainPageModel : FreshBasePageModel
    {
        public Command GoToPageCommand { get; set; }
        public Command GoToPageModalCommand { get; set; }

        public MainPageModel()
        {
            GoToPageCommand = new Command(() =>
            {
                CoreMethods.PushPageModel<FirstPageModel>();
            });

            GoToPageModalCommand = new Command(() =>
            {
                CoreMethods.PushPageModel<FirstPageModel>(null, true);
            });
        }
    }
}
