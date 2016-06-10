namespace XamlPowerToysDemo.View.People {
    using Xamarin.Forms;

    public partial class PersonEditorWithIconsInsteadOfLabels : ContentPage {

        public PersonEditorWithIconsInsteadOfLabels() {
            InitializeComponent();
            this.BindingContext = new PersonEditorViewModel();
        }

    }
}
