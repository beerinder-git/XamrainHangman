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
    public class GetQuizPage : ContentPage
    {
        private ListView _listView;

        private string _dbPath = Path.Combine(System.Environment.GetFolderPath(Environment.SpecialFolder.Personal), "myDB.db3");

        public GetQuizPage()
        {
            this.Title = "Quiz List";

            StackLayout stackLayout = new StackLayout();

            SQLiteConnection db = new SQLiteConnection(_dbPath);

            _listView = new ListView { ItemsSource = db.Table<Quiz>().OrderBy(x => x.Word).ToList() };
            stackLayout.Children.Add(_listView);

            Content = stackLayout;
        }
    }
}