namespace XamlPowerToysDemo.View.People
{
    using System;
    using System.Collections.Generic;
    using System.Windows.Input;
    using Xamarin.Forms;
    using XamlPowerToysDemo.Model.Infrastructure;
    using XamlPowerToysDemo.Model.People;

    public class PersonEditorViewModel : ObservableObject
    {

        IList<Country> _countries;
        Person _person;
        IList<String> _states;

        public ICommand DeleteCommand => new Command(DeleteCommandExecute);

        public ICommand SaveCommand => new Command(SaveCommandExecute);


        public IList<Country> Countries {
            get { return _countries; }
            set {
                _countries = value;
                RaisePropertyChanged();
            }
        }

        public Person Person {
            get { return _person; }
            set {
                _person = value;
                RaisePropertyChanged();
            }
        }

        public IList<String> States {
            get { return _states; }
            set {
                _states = value;
                RaisePropertyChanged();
            }
        }

        public PersonEditorViewModel()
        {
            var person = new Person();
            person.BirthDate = new DateTime(1960, 12, 25);
            person.NumberOfComputers = 6;
            person.IsActive = true;
            person.LastName = "Shifflett";
            person.Address = "2 Commerce Drive";
            person.City = "Cranbury";
            person.Country = "USA";
            person.State = "NJ";
            person.Id = 100;
            person.FirstName = "Karl";
            person.Phone = "800-555-1212";
            person.ZipCode = "08512";
            this.Person = person;

            this.States = new List<String> { "NC", "NJ", "NY" };
            this.Countries = new List<Country>();
            this.Countries.Add(new Country { Abbreviation = "BGR", Name = "Bulgaria" });
            this.Countries.Add(new Country { Abbreviation = "ROU", Name = "Romania" });
            this.Countries.Add(new Country { Abbreviation = "RUS", Name = "Russian Federation" });
            this.Countries.Add(new Country { Abbreviation = "USA", Name = "United States" });
        }

        private void DeleteCommandExecute(object obj)
        {

        }
        private void SaveCommandExecute(object obj)
        {

        }

    }
}
