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
            Person p = new Person();
            p.Name = eAddPerson.Text;
            p.GroupId = Group.Id;
            pCL.InsertPerson(p);
            ResetListView();
            eAddPerson.Text = "";
            eAddPerson.Focus();
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

        public void btnDelete_Clicked(object sender, EventArgs e)
        {
            var button = sender as Button;
            var person = button?.BindingContext as Person;
            pCL.DeletePerson(person);
            ResetListView();
        }

        public void ResetListView()
        {
            GroupPeople = pCL.GetPeopleByGroupId(Group.Id).ToList();

            lvGroupPeople.ItemsSource = null;
            lvGroupPeople.ItemsSource = GroupPeople;
        }
	}
}