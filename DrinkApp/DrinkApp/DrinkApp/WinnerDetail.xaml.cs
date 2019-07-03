using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using DrinkApp.Models;

namespace DrinkApp
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class WinnerDetail : ContentPage
    {
        public List<Person> PeopleList;
        public Person WinnerPerson;
        public WinnerDetail()
        {
            InitializeComponent();

            PeopleList = new List<Person>();
            WinnerPerson = new Person();
        }

        private void GetHeighestRoll()
        {
            Person p1 = new Person();

            foreach (Person p in PeopleList)
            {
                if (p1.Name == null || p1.Name == "")
                    p1 = p;

                else if (p1 != null)
                {
                    if (p1.Number > p.Number)
                        p1 = p;
                }
            }

            WinnerPerson = p1;
        }

        public void FillPeopleList(List<Person> people)
        {
            lvPeople.ItemsSource = null;
            PeopleList = people;

            Random random = new Random();

            foreach (Person p in PeopleList)
            {
                p.Number = random.Next(1000);
            }

            GetHeighestRoll();
            
            lvPeople.ItemsSource = PeopleList;
            lblWinner.Text = WinnerPerson.Name;
            lblNumber.Text = WinnerPerson.Number.ToString();
        }
    }
}