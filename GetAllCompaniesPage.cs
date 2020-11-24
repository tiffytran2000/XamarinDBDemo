using System;
using System.IO;
using SQLite;
using Xamarin.Forms;

namespace DBDemo.Views
{
    public class GetAllCompaniesPage : ContentPage
    {
        private ListView _listView;
        string _dbPath = Path.Combine(System.Environment.GetFolderPath(System.Environment.SpecialFolder.Personal), "my DB.db3");

        public GetAllCompaniesPage()
        {
            this.Title = "Companies";

            var db = new SQLiteConnection(_dbPath);

            StackLayout stackLayout = new StackLayout();

            _listView = new ListView();
            _listView.ItemsSource = db.Table<Company>().OrderBy(x => x.Name).ToList();
            stackLayout.Children.Add(_listView);

            Content = stackLayout;


        }
    }
}

