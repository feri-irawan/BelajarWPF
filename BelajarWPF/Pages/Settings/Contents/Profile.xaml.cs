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

namespace BelajarWPF.Pages.Settings.Contents
{
    /// <summary>
    /// Interaction logic for Profile.xaml
    /// </summary>
    public partial class Profile : Page, IPageWithPathKey
    {
        public string PathKey => "profile";
        public Profile()
        {
            InitializeComponent();
        }
    }
}
