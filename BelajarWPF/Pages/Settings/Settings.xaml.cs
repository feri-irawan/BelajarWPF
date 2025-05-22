using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using BelajarWPF.Interfaces;
using BelajarWPF.Models;
using BelajarWPF.Pages.Members.Contents;
using BelajarWPF.Pages.Settings.Contents;

namespace BelajarWPF.Pages.Settings
{
    /// <summary>
    /// Interaction logic for Settings.xaml
    /// </summary>
    public partial class Settings : Page, IPageWithPathKey
    {
        public string PathKey => "settings";
        private readonly MenuNavigator _menuNavigator;
        public Settings()
        {
            InitializeComponent();

            var menuItems = new List<MenuItemModel>()
            {
                new() {
                    Judul = "Profile",
                    PathKey = "profile",
                    TargetPage = new Profile(),
                }
            };

            _menuNavigator = new MenuNavigator(menuItems, MenuContainer, page => ContentContainer.Navigate(page));
            _menuNavigator.InitializeMenu();
        }
    }
}
