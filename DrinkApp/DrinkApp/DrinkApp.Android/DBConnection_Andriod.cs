using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using DrinkApp.Droid;
using DrinkApp.Interfaces;
using SQLite;

[assembly: Xamarin.Forms.Dependency(typeof(DBConnection_Andriod))]
namespace DrinkApp.Droid
{
    public class DBConnection_Andriod : IDatabaseConnection
    {
        public SQLiteConnection DBConnection()
        {
            var dbName = "PeopleDb.db3";
            var path = Path.Combine(System.Environment.GetFolderPath(System.Environment.SpecialFolder.Personal), dbName);
            return new SQLiteConnection(path);
        }
    }
}