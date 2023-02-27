using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace kakaotalkClone
{
    internal class RelayCommand<T> : ICommand
    {
        readonly Action<T> _execute;
        readonly Predicate<T> _canexecute;
        


        public RelayCommand(Action<T> execute, Predicate<T> canexecute)
        {
            _execute = execute;
            _canexecute = canexecute;
        }

        public RelayCommand(Action<T> execute) : this(execute, null)
        {

        }
        public event EventHandler? CanExecuteChanged
        {
            add { CommandManager.RequerySuggested += value; }
            remove{ CommandManager.RequerySuggested -= value; }
        }
        public bool CanExecute(object? parameter)
        {
            return _canexecute == null ? true : _canexecute((T)parameter);
        }

        public void Execute(object? parameter)
        {
            _execute((T)parameter);
        }
    }
}
