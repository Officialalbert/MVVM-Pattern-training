using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace WpfResist.Core
{
    internal class Acting : ICommand
    {

        private Action<object> execute;
        private Func<object, bool> Canexecute;

        public event EventHandler? CanExecuteChanged
        {
            add { CommandManager.RequerySuggested += value; }
            remove { CommandManager.RequerySuggested -= value; }
        }
        public Acting(Action<object> execute, Func<object,bool> canexecute = null)
        {
            this.execute = execute;
            this.Canexecute = canexecute;
        }

        public bool CanExecute(object? parameter)
        {
            return this.Canexecute == null || this.Canexecute(parameter);
        }

        public void Execute(object? parameter)
        {
            this.execute(parameter);
        }
    }
}
