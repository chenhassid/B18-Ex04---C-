using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex04.Menus.Interfaces
{
    public abstract class MenuItem
    {
        private int m_MenuItemOptionNumber = 0;
        private string m_Title;

        internal abstract void ExecuteMenuOption();

        internal int MenuItemOptionNumber
        {
            get
            {
                return m_MenuItemOptionNumber;
            }
            set
            {
                m_MenuItemOptionNumber = value;
            }
        }

        public string Title
        {
            get
            {
                return m_Title;
            }

            set
            {
                m_Title = value;
            }
        }
    }
}
