using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using DrinkApp.Models;
using DrinkApp.Controls;

namespace DrinkApp
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class GroupPeoplePage : ContentPage
	{
        public Group Group { get; set; }
        public List<Person> GroupPeople { get; set; }

        private PersonController pCL;
        private WinnerDetail winnerDetail;

        public GroupPeoplePage ()
		{
			InitializeComponent();
            pCL = new PersonController();
            winnerDetail = new WinnerDetail();
            Group = new Group();
            eAddPerson.Text = "";

            btnAddPerson.Clicked += btnAddPerson_Clicked;
            btnRaffle.Clicked += btnRaffle_Clicked;
        }

        public void FillGroup(Group group)
        {
            Group = group;
            lblName.Text = Group.GroupName;
            ResetListView();
        }

        public void btnAddPerson_Clicked(object sender, EventArgs e)
        {
            if (eAddPerson.Text != "")
            {
                Person p = new Person();
                p.Name = eAddPerson.Text;
                p.GroupId = Group.Id;
                pCL.InsertPerson(p);
                ResetListView();
                eAddPerson.Text = "";
                eAddPerson.Focus();
            }
            else
            {
                DisplayAlert("Advarsel!", "Navnet på personen er ikke gyldigt.", "Ok");
            }
        }

        public void btnRaffle_Clicked(object sender, EventArgs e)
        {
            if (GroupPeople.Count > 1)
            {
                winnerDetail.FillPeopleList(GroupPeople);
                Navigation.PushAsync(winnerDetail);
            }
            else
            {
                DisplayAlert("Advarsel!", "Der skal mindst 2 til at raffle", "Ok");
            }
        }

        public async void btnDelete_Clicked(object sender, EventArgs e)
        {
            var button = sender as Button;
            var person = button?.BindingContext as Person;

            var warningPerson = await DisplayAlert("Advarsel!", "Vil du fjerne " + person.Name+ "?", "Ja", "Nej");

            if(warningPerson == true)
            {
                pCL.DeletePerson(person);
                ResetListView();
            }
        }

        public void ResetListView()
        {
            GroupPeople = pCL.GetPeopleByGroupId(Group.Id).ToList();

            lvGroupPeople.ItemsSource = null;
            lvGroupPeople.ItemsSource = GroupPeople;
        }
	}
}