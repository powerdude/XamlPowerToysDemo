﻿namespace XamlPowerToysDemo.Universal {
    using Windows.UI.Xaml.Controls;

    public sealed partial class MainPage : Page {

        public MainPage() {
            this.InitializeComponent();
            this.DataContext = new PersonEditorViewModel();
        }

    }
}
