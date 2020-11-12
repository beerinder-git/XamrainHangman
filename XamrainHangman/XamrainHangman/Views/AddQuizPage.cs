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
    public class AddQuizPage : ContentPage
    {
        private Entry _wordEntry;
        private Button _saveBtn;

        private string _dbPath = Path.Combine(System.Environment.GetFolderPath(Environment.SpecialFolder.Personal), "myDB.db3");


        public AddQuizPage()
        {
            this.Title = "Add Quiz";

            StackLayout stackLayout = new StackLayout();

            _wordEntry = new Entry { Keyboard = Keyboard.Text, Placeholder = "A word like 'HELLO'" };
            stackLayout.Children.Add(_wordEntry);

            _saveBtn = new Button { Text = "Save" };
            _saveBtn.Clicked += _saveBtn_Clicked;
            stackLayout.Children.Add(_saveBtn);

            Content = stackLayout;
        }

        private async void _saveBtn_Clicked(object sender, EventArgs e)
        {
            SQLiteConnection db = new SQLiteConnection(_dbPath);
            db.CreateTable<Quiz>();

            var maxPK = db.Table<Quiz>().OrderByDescending(c => c.Id).FirstOrDefault();

            Quiz quiz = new Quiz
            {
                Id = (maxPK == null ? 1 : maxPK.Id + 1),
                Word = _wordEntry.Text
            };
            db.Insert(quiz);

            DependencyService.Get<IMessage>().LongAlert(quiz.Word + " Saved");

            await Navigation.PopAsync();
        }
    }
}