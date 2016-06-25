namespace XamlPowerToysDemo.WPF {
    using System.Windows;

    public partial class MainWindow : Window {

        public MainWindow() {
            InitializeComponent();
            this.DataContext = new PersonEditorViewModel();
        }

    }
}
