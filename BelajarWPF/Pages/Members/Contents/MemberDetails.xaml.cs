using System.Windows;
using System.Windows.Controls;
using BelajarWPF.Interfaces;
using BelajarWPF.Services;
using BelajarWPF.Pages.Members.UserControls;

namespace BelajarWPF.Pages.Members.Contents
{
    /// <summary>
    /// Interaction logic for MemberDetails.xaml
    /// </summary>
    public partial class MemberDetails : Page, IPageWithPathKey
    {
        public string PathKey => "members/details";
        public MemberDetails()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, System.Windows.RoutedEventArgs e)
        {
            

            DialogService.Instance.Show(new FilterMemberDialog());
        }
    }
}
