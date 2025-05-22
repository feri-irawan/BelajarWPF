using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;

namespace BelajarWPF.Models
{
    public class MenuItemModel : INotifyPropertyChanged
    {
        public UserControl? Icon { get; set; }
        public required string Judul { get; set; }
        public required Page TargetPage { get; set; }
        public required string PathKey { get; set; }
        public List<MenuItemModel>? SubMenuItems { get; set; }

        private bool _isSelected;
        public bool IsSelected
        {
            get => _isSelected;
            set
            {
                if (_isSelected != value)
                {
                    _isSelected = value;
                    OnPropertyChanged(nameof(IsSelected));
                }
            }
        }

        public event PropertyChangedEventHandler? PropertyChanged;
        protected void OnPropertyChanged(string name)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(name));
        }
    }

}
