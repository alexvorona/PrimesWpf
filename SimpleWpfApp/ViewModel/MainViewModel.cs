using System;
using System.Windows.Documents;
using GalaSoft.MvvmLight;
using SimpleWpfApp.Model;
using System.Collections.Generic;
using System.Windows;
using GalaSoft.MvvmLight.Command;

namespace SimpleWpfApp.ViewModel
{
    public class MainViewModel : ViewModelBase
    {
        private string _number;
        private bool _numberIsValid;
        private Prime prime;
        private List<int> _primesList;
        private string _content;
        private int _selectedValue;
        private bool _buttonIsEnabled;

        /// <summary>
        /// Initializes a new instance of the MainViewModel class.
        /// </summary>
        public MainViewModel()
        {
            prime = new Prime();
            OkCommand = new RelayCommand(() => { MessageBox.Show($"You have chosen {Number} and {SelectedValue}"); });
            Update(_number);
        }

        public string Number
        {
            get { return _number; }
            set
            {
               _number = value;
                Update(_number); 
                RaisePropertyChanged();
            }
        }

        public bool NumberIsValid
        {
            get { return _numberIsValid; }
            set
            {
                _numberIsValid = value;
                RaisePropertyChanged();
            }
        }

        public string Content
        {
            get { return _content; }
            set
            {
                _content = value;
                RaisePropertyChanged();
            }
        }

        public List<int> PrimesList
        {
            get { return _primesList; }
            set
            {
                _primesList = value;
                RaisePropertyChanged();
            }
        }

        public int SelectedValue
        {
            get { return _selectedValue; }
            set
            {
                _selectedValue = value;
                ButtonIsEnabled = true;
                RaisePropertyChanged();
            }
        }

        public bool ButtonIsEnabled
        {
            get { return _buttonIsEnabled; }
            set
            {
                _buttonIsEnabled = value;
                RaisePropertyChanged();
            }
        }

        public RelayCommand OkCommand { get; private set; }

        private void Update(string number)
        {
            int x;
            if (Int32.TryParse(number, out x))
            {
                NumberIsValid = true;
                Content = $"Primes up to {x * x}:";
                PrimesList = prime.GeneratePrimes(x * x);
            }
            else
            {
                NumberIsValid = false;
                ButtonIsEnabled = false;
                Content = "Primes up to X:";
                PrimesList = new List<int>();
            }
        }
    }
}
