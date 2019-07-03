using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using DrinkApp.Models;
using DrinkApp.DataAccess;

namespace DrinkApp
{
    public partial class MainPage : ContentPage
    {
        public List<Person> People { get; set; }
        private WinnerDetail winnerdetail;
        public MainPage()
        {
            InitializeComponent();
            People = new List<Person>();
            winnerdetail = new WinnerDetail();

            enName.Text = "";

            btnEnter.Clicked += Clicked_Button;
            btnRandom.Clicked += RandomClicked_Button;
            btnGroups.Clicked += GroupsClicked_Button;
        }

        private void Clicked_Button(object sender, EventArgs e)
        {
            if(enName.Text != "")
            {
                People.Add(new Person
                {
                    Id = People.Count + 1,
                    Name = enName.Text,
                    Number = 0
                });

                enName.Text = "";
                enName.Focus();
                resetPeopleView();
            }
            else
            {
                AlertMessage("Indtast et gyldigt navn.");
            }
        }

        private async void RandomClicked_Button(object sender, EventArgs e)
        {
            if(People.Count > 1)
            { 
                winnerdetail.FillPeopleList(People);
                await Navigation.PushAsync(winnerdetail);
            }
            else
            {
                AlertMessage("Der skal mindst 2 personer til raffle.");
            }
        }

        public void DeleteButton_OnClicked(object sender, EventArgs e)
        {
            var button = sender as Button;
            var person = button?.BindingContext as Person;
            People.Remove(person);
            resetPeopleView();
        }

        public async void GroupsClicked_Button(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new GroupPage());
        }

        private async void AlertMessage(string message)
        {
            await DisplayAlert("Adversel!", "Fejl: " + message, "Ok");
        }

        private void resetPeopleView()
        {
            lvPersons.ItemsSource = null;
            lvPersons.ItemsSource = People;
        }
    }
}
