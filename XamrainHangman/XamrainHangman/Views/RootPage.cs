using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Xamarin.Forms;

namespace XamrainHangman.Views
{
    public class RootPage : ContentPage
    {
        public RootPage()
        {
            this.Title = "Hangman Game";

            StackLayout stackLayout = new StackLayout();

            Button dbBtn = new Button { Text = "Quiz Database" };
            dbBtn.Clicked += DbBtn_Clicked;
            stackLayout.Children.Add(dbBtn);

            Button playBtn = new Button { Text = "Play" };
            playBtn.Clicked += PlayBtn_Clicked;
            stackLayout.Children.Add(playBtn);

            Content = stackLayout;

        }

        private async void PlayBtn_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new MainPage());
        }

        private async void DbBtn_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new HomePage());
        }
    }
}