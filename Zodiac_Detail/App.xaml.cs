using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Zodiac_Detail
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            MainPage = new Zodiac_Fly();
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
