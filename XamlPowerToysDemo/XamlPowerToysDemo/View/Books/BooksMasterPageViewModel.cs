namespace XamlPowerToysDemo.View.Books {
    using System.Collections.Generic;
    using System.Linq;
    using Xamarin.Forms;
    using XamlPowerToysDemo.Infrastructure;
    using XamlPowerToysDemo.Model.Books;
    using XamlPowerToysDemo.Model.Infrastructure;

    public class BooksMasterPageViewModel : ObservableObject {

        IList<Book> _books;

        public IList<Book> Books {
            get { return _books; }
            private set {
                _books = value;
                RaisePropertyChanged();
            }
        }

        public BooksMasterPageViewModel() {
            var business = new BookData();
            this.Books = business.GetBooks();
            MessagingCenter.Subscribe<BooksDetailPageViewModel, Book>(this, Constants.SaveBook, SaveBook);
        }

        void SaveBook(BooksDetailPageViewModel vm, Book editedBook) {
            var remove = this.Books.FirstOrDefault(x => x.Id == editedBook.Id);
            this.Books.Remove(remove);
            this.Books.Add(editedBook);
            this.Books = this.Books.OrderBy(x => x.Title).ToList();
        }

    }
}
