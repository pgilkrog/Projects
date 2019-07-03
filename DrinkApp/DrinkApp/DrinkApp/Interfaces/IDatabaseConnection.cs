using System;
using System.Collections.Generic;
using System.Text;

namespace DrinkApp.Interfaces
{
    public interface IDatabaseConnection
    {
        SQLite.SQLiteConnection DBConnection();
    }
}
