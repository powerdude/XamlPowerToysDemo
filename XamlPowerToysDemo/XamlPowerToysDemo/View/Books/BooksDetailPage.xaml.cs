namespace XamlPowerToysDemo.View.Books {
    using Xamarin.Forms;
    using XamlPowerToysDemo.Model.Books;

    public partial class BooksDetailPage : ContentPage {

        public BooksDetailPage(Book book) {
            InitializeComponent();
            this.BindingContext = new BooksDetailPageViewModel(this.Navigation, book);
        }

    }
}
