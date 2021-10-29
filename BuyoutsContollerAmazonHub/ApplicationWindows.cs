using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BuyoutsContollerAmazonHub
{
    public static class ApplicationWindows
    {
        private static Form _mainMenu;

        public static void SetMainMenu(Form mainMenu)
        {
            _mainMenu = mainMenu;
        }

        public static void BackToMainMenu(Form hidenForm)
        {
            hidenForm.Hide();
            _mainMenu.Show();
            _mainMenu.Location = hidenForm.Location;
        }

        public static void ShowNewForm(Form showForm)
        {
            _mainMenu.Hide();
            showForm.Show();
            showForm.Location = _mainMenu.Location;
        }
    }
}
