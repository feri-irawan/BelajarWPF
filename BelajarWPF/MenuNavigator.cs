using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BelajarWPF.Interfaces;
using BelajarWPF.Models;
using System.Windows.Controls;
using System.Windows;

namespace BelajarWPF
{
    public class MenuNavigator
    {
        private readonly List<MenuItemModel> _menuItems;
        private readonly Panel _menuContainer;
        private readonly Action<Page> _navigateAction;
        private readonly string _resourceKey;

        public MenuNavigator(List<MenuItemModel> menuItems, Panel menuContainer, Action<Page> navigateAction, string resourceKey = "SubMenuButtonStyle")
        {
            _menuItems = menuItems;
            _menuContainer = menuContainer;
            _navigateAction = navigateAction;
            _resourceKey = resourceKey;
        }

        public void InitializeMenu()
        {
            _menuContainer.Children.Clear();

            foreach (var menu in _menuItems)
            {
                var menuPanel = new StackPanel()
                {
                    Orientation = Orientation.Vertical,
                    Margin = new Thickness(5)
                };
                _menuContainer.Children.Add(menuPanel);

                // Main menu button
                var menuButton = new Button
                {
                    Content = menu.Icon,
                    DataContext = menu,
                    Style = (Style)Application.Current.FindResource(_resourceKey)
                };
                menuButton.Click += (s, e) => ShowPage(menu.TargetPage);
                menuPanel.Children.Add(menuButton);

                // Sub-menu buttons
                if (menu.SubMenuItems != null)
                {
                    foreach (var subMenu in menu.SubMenuItems)
                    {
                        var subMenuButton = new Button
                        {
                            Content = subMenu.Judul,
                            DataContext = subMenu,
                            Style = (Style)Application.Current.FindResource("SubSubMenuButtonStyle")
                        };
                        subMenuButton.Click += (s, e) => ShowPage(subMenu.TargetPage);
                        menuPanel.Children.Add(subMenuButton);
                    }
                }
            }

            // Show first page by default
            if (_menuItems.Count > 0)
            {
                _menuItems.First().IsSelected = true;
                ShowPage(_menuItems.First().TargetPage);
            }
        }

        public void ShowPage(Page page)
        {
            _navigateAction(page);
            UpdateActiveMenu(page);
        }

        public void UpdateActiveMenu(Page page)
        {
            string? currentPathKey = (page as IPageWithPathKey)?.PathKey;

            foreach (var menu in _menuItems)
            {
                menu.IsSelected = IsPathMatch(menu.PathKey, currentPathKey);

                if (menu.SubMenuItems != null)
                {
                    foreach (var sub in menu.SubMenuItems)
                    {
                        sub.IsSelected = IsPathMatch(sub.PathKey, currentPathKey);
                        if (sub.IsSelected)
                            menu.IsSelected = true;
                    }
                }
            }
        }

        private static bool IsPathMatch(string? menuPath, string? currentPath)
        {
            if (string.IsNullOrWhiteSpace(menuPath) || string.IsNullOrWhiteSpace(currentPath))
                return false;

            return currentPath.StartsWith(menuPath);
        }
    }
}
