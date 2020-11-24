using System;
using System.IO;
using SQLite;
using Xamarin.Forms;

namespace DBDemo.Views
{
    public class DeleteCompanyPage : ContentPage
    {
        private ListView _listView;
        private Button _button;

        Company _company = new Company();

        string _dbPath = Path.Combine(System.Environment.GetFolderPath(System.Environment.SpecialFolder.Personal), "my DB.db3");

        public DeleteCompanyPage()
        {
            this.Title = "Edit Company";

            var db = new SQLiteConnection(_dbPath);

            StackLayout stackLayout = new StackLayout();

            _listView = new ListView();
            _listView.ItemsSource = db.Table<Company>().OrderBy(x => x.Name).ToList();
            _listView.ItemSelected += _listView_ItemSelected;
            stackLayout.Children.Add(_listView);

            _button = new Button();
            _button.Text = "Delete";
            _button.Clicked += _button_Clicked;
            stackLayout.Children.Add(_button);


            Content = stackLayout;
        }
        private void _listView_ItemSelected(object sender, SelectedItemChangedEventArgs e)
        {
            _company = (Company)e.SelectedItem;
          
        }

        private async void _button_Clicked(object sender, EventArgs e)
        {
            var db = new SQLiteConnection(_dbPath);
            db.Table<Company>().Delete(x => x.id == _company.id);
            await Navigation.PopAsync();
        }


    }
}

