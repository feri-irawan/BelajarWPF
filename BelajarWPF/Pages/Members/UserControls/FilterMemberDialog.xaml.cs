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

namespace BelajarWPF.Pages.Members.UserControls
{
    /// <summary>
    /// Interaction logic for FilterMemberDialog.xaml
    /// </summary>
    public partial class FilterMemberDialog : UserControl
    {
        public FilterMemberDialog()
        {
            InitializeComponent();
        }

        private void Apply_Click(object sender, RoutedEventArgs e)
        {
            var _statusAktif = statusAktif.SelectedValue;
            var _statusKeanggotaan = statusKeanggotaan.SelectedValue;

            Console.WriteLine(_statusAktif);
            Console.WriteLine(_statusKeanggotaan);
        }
    }
}
