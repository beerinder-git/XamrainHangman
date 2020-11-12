using SQLite;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

using Xamarin.Forms;
using XamrainHangman.Models;

namespace XamrainHangman.Views
{
    public class DeleteQuizPage : ContentPage
    {
        private ListView _listView;
        private Quiz _quiz;
        private Button _delBtn;

        private string _dbPath = Path.Combine(System.Environment.GetFolderPath(Environment.SpecialFolder.Personal), "myDB.db3");

        public DeleteQuizPage()
        {
            this.Title = "Delete Quiz";

            StackLayout stackLayout = new StackLayout();

            SQLiteConnection db = new SQLiteConnection(_dbPath);

            _listView = new ListView { ItemsSource = db.Table<Quiz>().OrderBy(z => z.Word).ToList() };
            _listView.ItemSelected += _listView_ItemSelected;
            stackLayout.Children.Add(_listView);

            _delBtn = new Button { Text = "Delete" };
            _delBtn.Clicked += _delBtn_Clicked;
            stackLayout.Children.Add(_delBtn);

            Content = stackLayout;
        }

        private async void _delBtn_Clicked(object sender, EventArgs e)
        {
            SQLiteConnection db = new SQLiteConnection(_dbPath);
            db.Table<Quiz>().Delete(z => z.Id == _quiz.Id);

            DependencyService.Get<IMessage>().LongAlert("A Word has been Deleted");
            await Navigation.PopAsync();

        }

        private void _listView_ItemSelected(object sender, SelectedItemChangedEventArgs e)
        {
            _quiz = (Quiz) e.SelectedItem;
        }
    }
}