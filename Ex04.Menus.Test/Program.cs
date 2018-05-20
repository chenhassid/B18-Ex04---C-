using Ex04.Menus.Interfaces;
using Ex04.Menus.Delegates;

namespace Ex04.Menus.Test
{
    class Program
    {
        public static void Main()
        {
            Interfaces.MainMenu firstMenuToShow = buildMainMenuInterface();
            firstMenuToShow.Show();
        }

        private static Interfaces.MainMenu buildMainMenuInterface()
        {
            // Create Executable Items 
            IExecutable showTimeExecute = new MenuDelegatesAndInterfaces.ShowTime();
            IExecutable showDateExcute = new MenuDelegatesAndInterfaces.ShowDate();
            IExecutable countCapitalsExcute = new MenuDelegatesAndInterfaces.CountCapitals();
            IExecutable showVersionExcute = new MenuDelegatesAndInterfaces.ShowVersion();

            Interfaces.ExecutableItem executableItemShowTime = new Interfaces.ExecutableItem("Show Time", showTimeExecute);
            Interfaces.ExecutableItem executableItemShowDate = new Interfaces.ExecutableItem("Show Date", showDateExcute);
            Interfaces.ExecutableItem executableItemCountCapitals = new Interfaces.ExecutableItem("Count Capitals Letters", countCapitalsExcute);
            Interfaces.ExecutableItem executableItemShowVersion = new Interfaces.ExecutableItem("Show Version", showVersionExcute);

            //Creates the sub menus: "Show Date/Time" and "Version and Capitals"
            Interfaces.SubMenu showDateAndTimeMenu = new Interfaces.SubMenu("Show Date/Time");
            showDateAndTimeMenu.AddItem(executableItemShowTime);
            showDateAndTimeMenu.AddItem(executableItemShowDate);
            Interfaces.SubMenu VersionAndCapitalsMenu = new Interfaces.SubMenu("Version and Capitals");
            showDateAndTimeMenu.AddItem(executableItemCountCapitals);
            showDateAndTimeMenu.AddItem(executableItemShowVersion);

            //Creates the Main Menu with both of the sub menus
            Interfaces.MainMenu mainMenuInterface = new Interfaces.MainMenu("Main Menu Of the Interface");
            mainMenuInterface.AddItemToMainMenu(showDateAndTimeMenu);
            mainMenuInterface.AddItemToMainMenu(VersionAndCapitalsMenu);
            return mainMenuInterface;

        }
    }
}

