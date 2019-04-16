using Lab03.Model;
using Lab03.Tools;
using Lab03.Tools.Meneger;
using System;

namespace Lab03.ViewModels
{
    class OutputViewModel : BaseViewModel
    {
        private Person _mainPerson;
        public Action CloseAction { get; set; }
        private RelayCommand<object> _closeCommand;
        public OutputViewModel(Person person)
        {
            _mainPerson = person;
        }

        public Person MainPerson
        {
            get
            {
                return _mainPerson;
            }
            set
            {
                _mainPerson = value;
                OnPropertyChanged("MainPerson");
            }
        }
        public RelayCommand<object> CloseCommand
        {
            get
            {
                return _closeCommand = new RelayCommand<object>(param => Close());
            }
        }
        private void Close()
        {
            CloseAction();
            LoaderManeger.Instance.HideLoader();
        }
    }
}
