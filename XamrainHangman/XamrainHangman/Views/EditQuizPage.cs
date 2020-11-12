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
    public class EditQuizPage : ContentPage
    {
        private ListView _listView;
        private Entry _idEntry;
        private Entry _wordEntry;
        private Button _saveBtn;
        private Quiz _quiz;

        private string _dbPath = Path.Combine(System.Environment.GetFolderPath(Environment.SpecialFolder.Personal), "myDB.db3");

        public EditQuizPage()
        {
            this.Title = "Edit Quiz";

            StackLayout stackLayout = new StackLayout();

            _quiz = new Quiz();

            SQLiteConnection db = new SQLiteConnection(_dbPath);

            _listView = new ListView { ItemsSource = db.Table<Quiz>().OrderBy(z => z.Word).ToList() };
            _listView.ItemSelected += _listView_ItemSelected;
            stackLayout.Children.Add(_listView);

            _idEntry = new Entry { Placeholder = "ID", IsVisible = false };
            stackLayout.Children.Add(_idEntry);

            _wordEntry = new Entry { Keyboard = Keyboard.Text, Placeholder = "a word like 'HELLO'" };
            stackLayout.Children.Add(_wordEntry);

            _saveBtn = new Button { Text = "Save" };
            _saveBtn.Clicked += _saveBtn_Clicked;
            stackLayout.Children.Add(_saveBtn);

            Content = stackLayout;
        }

        private async void _saveBtn_Clicked(object sender, EventArgs e)
        {
            SQLiteConnection db = new SQLiteConnection(_dbPath);

            Quiz quiz = new Quiz
            {
                Id = Convert.ToInt32(_idEntry.Text),
                Word = _wordEntry.Text
            };
            db.Update(quiz);

            DependencyService.Get<IMessage>().LongAlert("A Word has been Updated");

            await Navigation.PopAsync();

        }

        private void _listView_ItemSelected(object sender, SelectedItemChangedEventArgs e)
        {
            _quiz = (Quiz)e.SelectedItem;
            _idEntry.Text = _quiz.Id.ToString();
            _wordEntry.Text = _quiz.Word;
        }
    }
}