using System.Windows.Controls;
using BelajarWPF.Interfaces;
using BelajarWPF.Models;
using BelajarWPF.Pages.Members.Contents;
namespace BelajarWPF.Pages.Members
{
    /// <summary>
    /// Interaction logic for Members.xaml
    /// </summary>
    public partial class Members : Page, IPageWithPathKey
    {
        public string PathKey => "members";
        private readonly MenuNavigator _menuNavigator;

        public Members()
        {
            InitializeComponent();
            var menuItems = new List<MenuItemModel>()
            {
                new() {
                    Judul = "Members",
                    PathKey = "members",
                    TargetPage = new MemberList(),
                    SubMenuItems =
                    [
                        new MenuItemModel
                        {
                            Judul = "Member List",
                            PathKey = "members/list",
                            TargetPage = new MemberList()
                        },
                        new MenuItemModel
                        {
                            Judul = "Member Add",
                            PathKey = "members/add",
                            TargetPage = new MemberAdd()
                        }
                    ]
                }
            };

            _menuNavigator = new MenuNavigator(menuItems, MenuContainer, page => ContentContainer.Navigate(page));
            _menuNavigator.InitializeMenu();
        }
    }
}
