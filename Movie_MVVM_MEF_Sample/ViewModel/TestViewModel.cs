using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using Movie_MVVM_MEF_Sample.Model;

namespace Movie_MVVM_MEF_Sample.ViewModel
{
    class TestViewModel : INotifyPropertyChanged
    {
        private string _name;
        public string Name
        {
            get { return _name; }
            set
            {
                _name = value;
                OnPropertyChanged("Name");
            }
        }

        private RelayCommand _movies;
        public ICommand LoadMovies
        {
            get
            {
                return this._movies ?? (this._movies = new RelayCommand(ExecuteClick, CanExecuteClick));
            }
        }
        private void ExecuteClick(object args)
        {
            Movie movie = new Model.Movie();
            Name = movie.Story();
        }
        private bool CanExecuteClick(object args)
        {
            return true;
        }

        public event PropertyChangedEventHandler PropertyChanged;
        protected void OnPropertyChanged(string propertyName)
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
            }
        }

    }
}
