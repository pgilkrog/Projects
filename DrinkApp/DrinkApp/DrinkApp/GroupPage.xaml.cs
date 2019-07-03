using DrinkApp.Controls;
using DrinkApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace DrinkApp
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class GroupPage : ContentPage
	{
        private GroupController gCL;
        private GroupPeoplePage gpp;

        private IEnumerable<Group> groups;
		public GroupPage ()
		{
			InitializeComponent ();
            gCL = new GroupController();
            gpp = new GroupPeoplePage();

            btnAddGroup.Clicked += btnAddGroup_Clicked;
            //btnDeleteAll.Clicked += btnDeleteAll_Clicked;

            groups = gCL.GetAllGroups();

            ResetListView();
		}

        public void btnAddGroup_Clicked(object sender, EventArgs e)
        {
            Group group = new Group();
            group.GroupName = eAddGroup.Text;
            gCL.InsertGroup(group);
            eAddGroup.Text = "";
            ResetListView();
        }

        public void btnDeleteAll_Clicked(object sender, EventArgs e)
        {
            gCL.DeleteGroupTable();
            ResetListView();
        }

        public void ResetListView()
        {
            groups = gCL.GetAllGroups();
            lvGroups.ItemsSource = null;
            lvGroups.ItemsSource = gCL.GetAllGroups();
        }

        public void btnDeleteGroup_CLicked(object sender, EventArgs e)
        {
            var button = sender as Button;
            var group = button?.BindingContext as Group;
            gCL.DeleteGroup(group);
            ResetListView();
        }

        private async void LvGroups_ItemSelected(object sender, SelectedItemChangedEventArgs e)
        {
            Group group = e.SelectedItem as Group;
            gpp.FillGroup(group);
            await Navigation.PushAsync(gpp);
        }
    }
}