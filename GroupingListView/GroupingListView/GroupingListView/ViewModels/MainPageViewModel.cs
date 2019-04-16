using GroupingListView.Models;
using System.Collections.Generic;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Windows.Input;
using Xamarin.Forms;

namespace GroupingListView.ViewModels
{
    public class MainPageViewModel : INotifyPropertyChanged
    {
        private List<PersonGroup> _personGroups;
        public List<PersonGroup> PersonGroups
        {
            get => _personGroups;
            set { _personGroups = value; OnPropertyChanged(); }
        }

        private ICommand _loadPersonGroupsCommand;

        public ICommand LoadPersonGroupsCommand => _loadPersonGroupsCommand ?? (_loadPersonGroupsCommand = new Command(LoadPersonGroups));

        private void LoadPersonGroups()
        {
            PersonGroups = new List<PersonGroup>
            {
                new PersonGroup("Persons with A", "A") { new Person("Anna") },
                new PersonGroup("Persons with C", "C") { new Person("Caroline"), new Person("Cécile"), new Person("Clemens") },
                new PersonGroup("Persons with D", "D") { new Person("David"), new Person("Dino") },
                new PersonGroup("Persons with E", "E") { new Person("Eckhard") },
                new PersonGroup("Persons with G", "G") { new Person("Gino") },
                new PersonGroup("Persons with J", "J") { new Person("José") },
                new PersonGroup("Persons with K", "K") { new Person("Kai"), new Person("Ketsiri") },
                new PersonGroup("Persons with M", "M") { new Person("Marius"), new Person("Martin"), new Person("Melissa"), new Person("Mohit") },
                new PersonGroup("Persons with P", "P") { new Person("Petra"), new Person("Philipp") },
                new PersonGroup("Persons with R", "R") { new Person("Rituparna"), new Person("Robert") },
                new PersonGroup("Persons with S", "S") { new Person("Samuel"), new Person("Sebastian"), new Person("Sibeesh") },
                new PersonGroup("Persons with T", "T") { new Person("Thomas") }
            };
        }

        public event PropertyChangedEventHandler PropertyChanged;

        protected void OnPropertyChanged([CallerMemberName]string propertyName = "")
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
