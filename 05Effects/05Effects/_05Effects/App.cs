using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Xamarin.Forms;

namespace _05Effects
{
    public class App : Application
    {
        public App()
        {
            Entry entryText = new Entry
            {
                HorizontalOptions = LayoutOptions.Center,
                Text = "Click here!"
            };
            entryText.Effects.Add(Effect.Resolve("DevsDNA.FocusEffect"));

            // The root page of your application
            MainPage = new ContentPage
            {
                Content = new StackLayout
                {
                    VerticalOptions = LayoutOptions.Center,
                    Children =
                    {
                        entryText
                    }
                }
            };
        }

        protected override void OnStart()
        {
            // Handle when your app starts
        }

        protected override void OnSleep()
        {
            // Handle when your app sleeps
        }

        protected override void OnResume()
        {
            // Handle when your app resumes
        }
    }
}
