using System.Windows;
using System.Windows.Controls;

namespace BelajarWPF.Services
{
    public class DialogService
    {
        private static DialogService? _instance;
        private ContentPresenter? _dialogHost;
        private UIElement? _dialogOverlay;

        public static DialogService Instance => _instance ??= new DialogService();

        public void Register(ContentPresenter host, UIElement overlay)
        {
            _dialogHost = host;
            _dialogOverlay = overlay;
        }

        public void Show(UserControl dialog)
        {
            if (_dialogHost == null || _dialogOverlay == null)
                throw new System.Exception("DialogService belum diregister ke MainWindow!");

            _dialogHost.Content = dialog;
            _dialogOverlay.Visibility = Visibility.Visible;
        }

        public void Close()
        {
            if (_dialogHost == null || _dialogOverlay == null)
                return;

            _dialogOverlay.Visibility = Visibility.Collapsed;
            _dialogHost.Content = null;
        }

        public bool IsOpen => _dialogOverlay?.Visibility == Visibility.Visible;
    }
}
