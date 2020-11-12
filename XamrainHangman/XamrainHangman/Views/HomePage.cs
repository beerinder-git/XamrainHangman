using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Xamarin.Forms;

namespace XamrainHangman.Views
{
    public class HomePage : ContentPage
    {
        public HomePage()
        {
            this.Title = "Quiz Database";

            StackLayout stackLayout = new StackLayout();

            Button addBtn = new Button { Text = "Add Quiz" };
            addBtn.Clicked += AddBtn_Clicked;
            stackLayout.Children.Add(addBtn);

            Button getBtn = new Button { Text = "List Quiz" };
            getBtn.Clicked += GetBtn_Clicked;
            stackLayout.Children.Add(getBtn);

            Button editBtn = new Button { Text = "Edit Quiz" };
            editBtn.Clicked += EditBtn_Clicked;
            stackLayout.Children.Add(editBtn);

            Button delBtn = new Button { Text = "Delete Quiz" };
            delBtn.Clicked += DeleteBtn_Clicked;
            stackLayout.Children.Add(delBtn);

            Content = stackLayout;

        }

        private async void AddBtn_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new AddQuizPage());
        }

        private async void GetBtn_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new GetQuizPage());
        }

        private async void EditBtn_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new EditQuizPage());
        }

        private async void DeleteBtn_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new DeleteQuizPage());
        }
    }
}