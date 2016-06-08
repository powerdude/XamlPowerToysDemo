namespace XamlPowerToysDemo.View.People {
    using Xamarin.Forms;

    public partial class PersonEditorView : ContentPage {

        public PersonEditorView() {
            InitializeComponent();
            this.BindingContext = new PersonEditorViewModel();
        }

    }
}
