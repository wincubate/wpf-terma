using System.Threading.Tasks;
using System.Windows.Input;

namespace Wincubate.Threading.CaseStudyA.ViewModels
{
    class MainViewModel : ViewModelBase
    {
        public int Counter
        {
            get => _counter;
            set
            {
                if (_counter != value)
                {
                    _counter = value;
                    OnPropertyChanged();

                    CommandManager.InvalidateRequerySuggested();
                }
            }
        }
        private int _counter;

        public ICommand StartCommand => _startCommand;
        private readonly RelayCommand _startCommand;

        public ICommand ResetCommand => _resetCommand;
        private readonly RelayCommand _resetCommand;

        public MainViewModel()
        {
            _startCommand = new RelayCommand(
                _ => Task.Run(async () =>
               {
                   while (true)
                   {
                       await Task.Delay(1000);
                       Counter++;

                       //_resetCommand.RaiseCanExecuteChanged();
                       //System.Windows.Application.Current.Dispatcher.Invoke( () => CommandManager.InvalidateRequerySuggested() );
                   }
               })
            );

            _resetCommand = new RelayCommand(
                _ => Counter = 0,
                _ => Counter != 0
            );
        }
    }
}