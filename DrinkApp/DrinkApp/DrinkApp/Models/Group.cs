using SQLite;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace DrinkApp.Models
{
    [Table("Groups")]
    public class Group : INotifyPropertyChanged
    {
        private int _id;
        [PrimaryKey, AutoIncrement]

        public int Id
        {
            get { return _id; }
            set { this._id = value; OnPropertyChanged(nameof(Id)); }
        }

        private string _groupName;
        [NotNull]
        public string GroupName
        {
            get { return _groupName; }
            set { this._groupName = value; OnPropertyChanged(nameof(GroupName)); }
        }

        public event PropertyChangedEventHandler PropertyChanged;

        private void OnPropertyChanged(string propertyName)
        {
            this.PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
