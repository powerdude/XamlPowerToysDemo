namespace XamlPowerToysDemo.View.Books {
    using System;
    using Xamarin.Forms;
    using XamlPowerToysDemo.Model.Books;
    using XamlPowerToysDemo.Model.Infrastructure;

    public partial class BooksMasterPage : ContentPage {

        public BooksMasterPage() {
            InitializeComponent();
            this.BindingContext = new BooksMasterPageViewModel();
        }

        async void BooksListView_OnItemSelected(Object sender, SelectedItemChangedEventArgs e) {
            var book = e.SelectedItem as Book;
            if (book != null) {
                ((ListView)sender).SelectedItem = null;
                await this.Navigation.PushAsync(new BooksDetailPage(Cloner.DeepCopy(book)));
            }
        }

    }
}
