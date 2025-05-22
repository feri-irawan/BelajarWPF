using System.Windows.Controls;
using BelajarWPF.Interfaces;
using BelajarWPF.Models;
using BelajarWPF.Pages.Dashboard.Contents;

namespace BelajarWPF.Pages.Dashboard
{
    /// <summary>
    /// Interaction logic for Dashboard.xaml
    /// </summary>
    public partial class Dashboard : Page, IPageWithPathKey
    {
        public string PathKey => "dashboard";
        private readonly MenuNavigator _menuNavigator;

        public Dashboard()
        {
            InitializeComponent();
            var menuItems = new List<MenuItemModel>()
            {
                new() {
                    Judul = "Dashboard",
                    PathKey = "dashboard",
                    TargetPage = new Overview(),
                    SubMenuItems =
                    [
                        new MenuItemModel
                        {
                            Judul = "Overview",
                            PathKey = "dashboard/overview",
                            TargetPage = new Overview()
                        },
                        new MenuItemModel
                        {
                            Judul = "Buku Panduan",
                            PathKey = "dashboard/cookbook",
                            TargetPage = new CookBook()
                        },
                        new MenuItemModel
                        {
                            Judul = "Notifikasi",
                            PathKey = "dashboard/notification",
                            TargetPage = new Notification()
                        }
                    ]
                }
            };

            _menuNavigator = new MenuNavigator(menuItems, MenuContainer, page => ContentContainer.Navigate(page));
            _menuNavigator.InitializeMenu();
        }
    }
}
