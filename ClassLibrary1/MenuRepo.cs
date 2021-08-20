using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CafeClassLibrary
{
    public class MenuRepo
    {
        //private static readonly List<CafeMenu> _menuItems = new List<CafeMenu>();
        public List<CafeMenuItem> _menuItems = new List<CafeMenuItem>();

        //create takes info from console/user and gives info to database
        public bool AddMealToMenu(CafeMenuItem meal)
        {
            try
            {
                _menuItems.Add(meal);
                return true;
            }
            catch
            {
                return false;
            }
        }

        //read reads info from database and gives to console/user
        public List<CafeMenuItem> AllMenuItems()
        {
            return _menuItems;
        } 
        //update updates info in database from user input -- We do not need to update in this case so this will be empty


        //delete deletes info in database that user tell to delete
        public bool RemoveMeal(CafeMenuItem meal)
        {
            try
            {
                _menuItems.Remove(meal);
                return true;
            }
            catch
            {
                return false;
            }
        }

    }
}

// this is where we have CRUD operations
// 
//
//
//create - takes info from console/user and gives info to database
//read - reads info from database and gives to console/user
//update - updates info in database from user input
//delete - deletes info in database that user tell to delete
    
