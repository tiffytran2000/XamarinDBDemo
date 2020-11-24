using System;
using DBDemo.Views;
using Xamarin.Forms;

namespace DBDemo
{
    public class HomePage : ContentPage
    {
        public HomePage()
        {
            this.Title = "Select Options";

            /* StackLayout stackLayout = new StackLayout();
            Button button = new Button();
            button.Text = "Add Company"; 
            button.Clicked += Button_Clicked;
            stackLayout.Children.Add(button); */
            

            button = new Button();
            button.Text = "Get";
            button.Clicked += Button_Get_Clicked;
            stackLayout.Children.Add(button);

            button = new Button();
            button.Text = "Edit";
            button.Clicked += Button_Edit_Clicked;
            stackLayout.Children.Add(button);

            button = new Button();
            button.Text = "Delete";
            button.Clicked += Button_Delete_Clicked;
            stackLayout.Children.Add(button);



            Content = stackLayout;
        }



        private async void Button_Get_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new GetAllCompaniesPage());
        }

        private async void Button_Edit_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new EditCompanyPage());
        }

        private async void Button_Delete_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new DeleteCompanyPage());
        }

    }
}

