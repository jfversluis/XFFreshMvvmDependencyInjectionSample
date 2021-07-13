using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using FreshMvvm;
using XFFreshMvvmNavigationSample.PageModels;

namespace XFFreshMvvmNavigationSample
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            var page = FreshPageModelResolver.ResolvePageModel<MainPageModel>();

            var navigationPage = new FreshNavigationContainer(page);

            navigationPage.BarBackgroundColor = Color.Blue;
            navigationPage.BarTextColor = Color.White;

            MainPage = navigationPage;
        }

        protected override void OnStart()
        {
        }

        protected override void OnSleep()
        {
        }

        protected override void OnResume()
        {
        }
    }
}
