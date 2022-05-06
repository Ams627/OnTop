using System.Windows;
using System.Windows.Controls;

namespace OnTop
{
    public partial class MainWindow : Window
    {
        public bool AlwaysOnTop { get; set; }
        public MainWindow()
        {
            InitializeComponent();

            Deactivated += (s, e) =>
            {
                var wnd = s as Window;
                wnd.Topmost = AlwaysOnTop;
            };
        }

        private void CheckBox_Click(object sender, RoutedEventArgs e)
        {
            var box = sender as CheckBox;
            AlwaysOnTop = box.IsChecked ?? false;
        }
    }
}
