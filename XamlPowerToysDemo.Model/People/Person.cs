namespace XamlPowerToysDemo.Model.People {
    using System;
    using XamlPowerToysDemo.Model.Infrastructure;

    public class Person : ObservableObject, IComparable<Person>, IEquatable<Person> {

        String _address;
        DateTime _birthDate;
        DateTimeOffset _birthdayOffset;
        String _city;
        String _country;
        String _firstName;
        Int32 _id;
        Boolean _isActive;
        String _lastName;
        Int32 _numberOfComputers;
        String _phone;
        String _state;
        String _zipCode;

        public String Address {
            get { return _address; }
            set {
                _address = value;
                RaisePropertyChanged();
            }
        }

        public DateTime BirthDate {
            get { return _birthDate; }
            set {
                _birthDate = value;
                RaisePropertyChanged();
            }
        }

        public DateTimeOffset BirthdayOffset {
            get { return _birthdayOffset; }
            set {
                _birthdayOffset = value;
                RaisePropertyChanged();
            }
        }

        public String City {
            get { return _city; }
            set {
                _city = value;
                RaisePropertyChanged();
            }
        }

        public String Country {
            get { return _country; }
            set {
                _country = value;
                RaisePropertyChanged();
            }
        }

        public String FirstName {
            get { return _firstName; }
            set {
                _firstName = value;
                RaisePropertyChanged();
            }
        }

        public Int32 Id {
            get { return _id; }
            set {
                _id = value;
                RaisePropertyChanged();
            }
        }

        public Boolean IsActive {
            get { return _isActive; }
            set {
                _isActive = value;
                RaisePropertyChanged();
            }
        }

        public String LastName {
            get { return _lastName; }
            set {
                _lastName = value;
                RaisePropertyChanged();
            }
        }

        public Int32 NumberOfComputers {
            get { return _numberOfComputers; }
            set {
                _numberOfComputers = value;
                RaisePropertyChanged();
            }
        }

        public String Phone {
            get { return _phone; }
            set {
                _phone = value;
                RaisePropertyChanged();
            }
        }

        public String State {
            get { return _state; }
            set {
                _state = value;
                RaisePropertyChanged();
            }
        }

        public String ZipCode {
            get { return _zipCode; }
            set {
                _zipCode = value;
                RaisePropertyChanged();
            }
        }

        public Person() {
        }

        public Int32 CompareTo(Person other) {
            if (this.LastName == other.LastName && this.FirstName == other.FirstName) {
                return 0;
            }
            return String.Compare($"{this.LastName}{this.FirstName}", $"{other.LastName}{other.FirstName}", StringComparison.Ordinal);
        }

        public Boolean Equals(Person other) {
            return this.LastName.Equals(other.LastName) && this.FirstName.Equals(other.FirstName);
        }

    }
}
