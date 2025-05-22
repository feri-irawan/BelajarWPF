using System.Windows.Controls;
using BelajarWPF.Interfaces;

namespace BelajarWPF.Pages.Members.Contents
{
    /// <summary>
    /// Interaction logic for MemberList.xaml
    /// </summary>
    public partial class MemberList : Page, IPageWithPathKey
    {
        public string PathKey => "members/list";
        public MemberList()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, System.Windows.RoutedEventArgs e)
        {
            this.NavigationService.Navigate(new MemberDetails());
        }
    }
}
