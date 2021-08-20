using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01_Cafe
{
    public class MenuRepo
    {
        //private static readonly List<CafeMenu> _menuItems = new List<CafeMenu>();
        public List<CafeMenu> _menuItems = new List<CafeMenu>();

        //create takes info from console/user and gives info to database
        public bool AddMealToMenu(CafeMenu meal)
        {
            int startingCount = _menuItems.Count;
            _menuItems.Add(meal);
            bool mealWasAdded = _menuItems.Count > startingCount;
            return mealWasAdded;
        }

    }
}

// this is where we have CRUD operations
// 
//
//
//create takes info from console/user and gives info to database
//read reads info from database and gives to console/user
//update updates info in database from user input
//delete deletes info in database that user tell to delete
