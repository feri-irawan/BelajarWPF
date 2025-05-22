using System.Windows;
using System.Windows.Controls;
using BelajarWPF.Interfaces;
using BelajarWPF.Models;
using BelajarWPF.Pages.Dashboard;
using BelajarWPF.Pages.Members;
using BelajarWPF.Pages.Settings;
using BelajarWPF.Pages.Members.Contents;
using BelajarWPF.Services;

namespace BelajarWPF
{
    /// <summary>
    /// Interaction logic for DashboardWindow.xaml
    /// </summary>
    public partial class DashboardWindow : Window, IPageWithPathKey
    {
        public string PathKey => "dashboard";
        private readonly List<MenuItemModel> Menus = [];
        private readonly MenuNavigator _menuNavigator;


        public DashboardWindow()
        {
            InitializeComponent();
            DialogService.Instance.Register(DialogContent, DialogOverlay);

            var menuItems = new List<MenuItemModel>()
            {
                new() {
                    Judul = "Dashboard",
                    PathKey = "dashboard",
                    Icon = new IconHome(),
                    TargetPage = new Dashboard(),
                },
                new() {
                    Judul = "Members",
                    PathKey = "member",
                    TargetPage = new Members(),
                },
                new() {
                    Judul = "Settings",
                    PathKey = "settings",
                    TargetPage = new Settings(),
                }
            };

            _menuNavigator = new MenuNavigator(menuItems, MenuContainer, page => ContentContainer.Navigate(page), "MainMenuButtonStyle");
            _menuNavigator.InitializeMenu();
        }

        private void Backdrop_Click(object sender, System.Windows.Input.MouseButtonEventArgs e)
        {
            DialogService.Instance.Close();
        }
        private void DialogContent_Click(object sender, System.Windows.Input.MouseButtonEventArgs e)
        {
            e.Handled = true;
        }

    }
}
