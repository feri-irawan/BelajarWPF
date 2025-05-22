using System.Windows.Controls;
using BelajarWPF.Interfaces;

namespace BelajarWPF.Pages.Members.Contents
{
    /// <summary>
    /// Interaction logic for MemberAdd.xaml
    /// </summary>
    public partial class MemberAdd : Page, IPageWithPathKey
    {
        public string PathKey => "members/add";
        public MemberAdd()
        {
            InitializeComponent();
        }
    }
}
