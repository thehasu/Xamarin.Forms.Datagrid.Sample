using DatagridSample.Models;
using DatagridSample.Utils;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using Xamarin.Forms;

namespace DatagridSample.ViewModels
{
    public class MainPageViewModel : INotifyPropertyChanged
    {
        private ObservableCollection<Professional> _professionals;
        private Professional _selectedProfessional;
        private bool _isRefreshing;

        public ObservableCollection<Professional> Professionals
        {
            get
            {
                return _professionals;
            }
            set
            {
                _professionals = value;
                OnPropertyChanged(nameof(Professionals));
            }
        }
        public Professional SelectedProfesstional
        {
            get
            {
                return _selectedProfessional;
            }
            set
            {
                _selectedProfessional = value;
                OnPropertyChanged(nameof(SelectedProfesstional));
            }
        }

        public bool IsRefreshing
        {
            get
            {
                return _isRefreshing;
            }
            set
            {
                _isRefreshing = value;
                OnPropertyChanged(nameof(IsRefreshing));
            }
        }

        public ICommand RefreshCommand { get; set; }

        public MainPageViewModel()
        {
            Professionals = DummyProfessionalData.GetProfessionals();
            RefreshCommand = new Command(CmdRefresh);
        }

        private async void CmdRefresh()
        {
            var person = new Professional()
            {
                Id = Professionals.Count + 1,
                Name = "Monkey",
                Desigination = "Developer",
                Domain = "Mobile",
                Experience = "1"
            };

            IsRefreshing = true;
            await Task.Delay(1000);

            Professionals.Add(person);
            IsRefreshing = false;
        }

        public event PropertyChangedEventHandler PropertyChanged;

        private void OnPropertyChanged(string property)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(property));
        }
    }
}
