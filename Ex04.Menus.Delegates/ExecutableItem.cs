using System;

namespace Ex04.Menus.Delegates
{
    public delegate void ExecutableDelegate();

    public class ExecutableItem : MenuItem
    {
        public event ExecutableDelegate Execute;

        public ExecutableItem()
        {
            Execute = null;
        }
           
        public ExecutableItem(string i_Title, ExecutableDelegate i_ItemToExecute)
        {
            Title = i_Title;
            Execute += i_ItemToExecute;
        }

        internal override void ExecuteMenuOption()
        {
            if (Execute == null)
            {
                Console.WriteLine("The Executable item is not initialized.");

            }
            else
            {
                OnExecute();
                Console.WriteLine(Environment.NewLine);
            }
        }

        protected virtual void OnExecute()
        {
            if (Execute != null)
            {
                Execute.Invoke();
            }
        }
    }
}