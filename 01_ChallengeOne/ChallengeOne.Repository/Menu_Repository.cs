using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;


    public class Menu_Repository
    {
        private readonly List<Menu> _menuDatabase = new List<Menu>();
        private int _count = 0;
        public bool AddMenuToDataBase(Menu menu)
        {
            if (menu != null)
            {
                _count++;
                menu.ID = _count;
                _menuDatabase.Add(menu);
                return true;
            }else{
                return false;
            }
        }
        public List<Menu> GetEveryMenu()
        {
            return _menuDatabase;
        }
        public Menu GetMenuByID(int id)
        {
            foreach(Menu menu in _menuDatabase)
            {
                if(menu.ID == id)
                {
                    return menu;
                }
            }
            return null;
        }
        public bool RemoveMenuFromDatabase(int id)
        {
            var menu = GetMenuByID(id);
            if(menu != null)
            {
                _menuDatabase.Remove(menu);
                return true;
            }else{
                return false;
            }
        }
    }
