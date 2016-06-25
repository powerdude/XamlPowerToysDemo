namespace XamlPowerToysDemo.Universal {
    using System;
    using System.Windows.Input;

    /// <summary>
    /// DO NOT USE THIS CLASS IN YOUR CODE.  THIS IS DEMO ONLY!!!!!!!!!!!!!!!!!!!!!!!!!
    /// </summary>
    /// <seealso cref="System.Windows.Input.ICommand" />
    public sealed class DummyCommand : ICommand {

        readonly Func<Boolean> _canExecuteMethod;
        readonly Action _executeMethod;

        public DummyCommand(Action executeMethod)
            : this(executeMethod, null) {
        }

        public DummyCommand(Action executeMethod, Func<Boolean> canExecuteMethod) {
            if (executeMethod == null) {
                throw new ArgumentNullException(nameof(executeMethod));
            }
            _executeMethod = executeMethod;
            _canExecuteMethod = canExecuteMethod;
        }

        public Boolean CanExecute(Object parameter) {
            return _canExecuteMethod == null || _canExecuteMethod();
        }

        public event EventHandler CanExecuteChanged;

        public void Execute(Object parameter) {
            _executeMethod?.Invoke();
        }

    }
}
