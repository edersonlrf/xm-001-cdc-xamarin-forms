using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Modulo1
{
    public partial class App : Application
    {
        public App()
        {
            //InitializeComponent();

            var content = new ContentPage
            {
                Title = "Modulo1",
                Content = new StackLayout
                {
                    VerticalOptions = LayoutOptions.Center,
                    Children =
                    {
                        new Label
                        {
                            HorizontalTextAlignment = TextAlignment.Center,
                            Text = "Welcome to Xamarin Forms!"
                        }
                    }
                }
            };

            //MainPage = new MainPage();
            MainPage = content;
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
