namespace XamlPowerToysDemo.View.Books {
    using System;
    using System.Collections.Generic;
    using System.Windows.Input;
    using Xamarin.Forms;
    using XamlPowerToysDemo.Infrastructure;
    using XamlPowerToysDemo.Model.Books;
    using XamlPowerToysDemo.Model.Infrastructure;

    public class BooksDetailPageViewModel : ObservableObject {

        readonly INavigation _navigation;

        public Book Book { get; set; }

        public ICommand DeleteCommand => new Command(DeleteCommandExecute);

        public IList<String> Formats { get; }

        public ICommand SaveCommand => new Command(SaveCommandExecute);

        public BooksDetailPageViewModel(INavigation navigation, Book book) {
            if (navigation == null) {
                throw new ArgumentNullException(nameof(navigation));
            }
            _navigation = navigation;
            if (book == null) {
                throw new ArgumentNullException(nameof(book));
            }
            this.Book = book;
            this.Formats = GetFormats();
        }

        void DeleteCommandExecute() {
            MessagingCenter.Send(this, Constants.DeleteBook, this.Book);
        }

        IList<String> GetFormats() {
            var list = new List<String>();
            foreach (var name in Enum.GetNames(typeof(Format))) {
                list.Add(name);
            }
            return list;
        }

        async void SaveCommandExecute() {
            MessagingCenter.Send(this, Constants.SaveBook, this.Book);
            await _navigation.PopAsync();
        }

    }
}
