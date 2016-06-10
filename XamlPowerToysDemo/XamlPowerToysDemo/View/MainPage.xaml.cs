namespace XamlPowerToysDemo.View {
    using System;
    using Xamarin.Forms;
    using XamlPowerToysDemo.View.Books;
    using XamlPowerToysDemo.View.People;

    public partial class MainPage : ContentPage {

        public MainPage() {
            InitializeComponent();
        }

        async void BooksButton_OnClicked(Object sender, EventArgs e) {
            await this.Navigation.PushAsync(new BooksMasterPage());
        }

        async void PeopleButton_OnClicked(Object sender, EventArgs e) {
            await this.Navigation.PushAsync(new PersonEditorView());
        }

        async void PersonWithImageButton_OnClicked(object sender, EventArgs e) {
            await this.Navigation.PushAsync(new PersonEditorWithIconsInsteadOfLabels());

        }

    }
}
