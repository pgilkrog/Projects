using SQLite;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace DrinkApp.Models
{
    [Table("Peple")]
    public class Person : INotifyPropertyChanged
    {
        private int _id;
        [PrimaryKey, AutoIncrement]
        public int Id
        {
            get { return _id; }
            set { this._id = value; OnPropertyChanged(nameof(Id)); }
        }

        private string _name;
        [NotNull]
        public string Name
        {
            get { return _name; }
            set { this._name = value; OnPropertyChanged(nameof(Name)); }
        }

        private int _number;
        public int Number
        {
            get { return _number; }
            set { this._number = value; OnPropertyChanged(nameof(Number)); }
        }

        private int _groupId;
        public int GroupId
        {
            get { return _groupId; }
            set { this._groupId = value; OnPropertyChanged(nameof(GroupId)); }
        }

        public event PropertyChangedEventHandler PropertyChanged;

        private void OnPropertyChanged(string propertyName)
        {
            this.PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        public override string ToString()
        {
            return Name + " " + Number;
        }
    }
}
