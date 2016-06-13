namespace XamlPowerToysDemo.View.People {
    using Xamarin.Forms;

    public partial class PeopleWorkPlace : ContentPage {

        public PeopleWorkPlace() {
            InitializeComponent();
            this.BindingContext = new PersonEditorViewModel();
        }

    }
}
