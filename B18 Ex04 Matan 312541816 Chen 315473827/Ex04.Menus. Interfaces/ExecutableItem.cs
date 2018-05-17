﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex04.Menus.Interfaces
{
    class ExecutableItem : MenuItem
    {
        private IExecutable m_Executable;

        public ExecutableItem()
        {
            m_Executable = null;
        }

        public IExecutable Executable
        {
            get { return m_Executable; }
            set { m_Executable = value; }
        }

        public ExecutableItem(string i_Title, IExecutable i_Executable)
        {
            Title = i_Title;
            m_Executable = i_Executable;
        }

        internal override void ExecuteMenuOption()
        {
            if (Executable == null)
            {
                Console.WriteLine("Please initialize Executable item.");

            }
            else
            {
                Executable.Execute();
                Console.WriteLine(Environment.NewLine);
            }
        }
    }
}

