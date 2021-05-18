namespace FrontEnd.Resources
{
    using System;
    using System.Windows;
    using System.Windows.Input;

    public class RelayCommand : ICommand
    {
        #region Private Fields

        private Action<object> execute;
        private Func<object, bool> canExecute;

        #endregion Private Fields

        #region Public Constructors

        public RelayCommand(Action<object> execute, Func<object, bool> canExecute = null)
        {
            this.execute = execute;
            this.canExecute = canExecute;
        }

        #endregion Public Constructors

        #region Public Events

        public event EventHandler CanExecuteChanged
        {
            add { CommandManager.RequerySuggested += value; }
            remove { CommandManager.RequerySuggested -= value; }
        }

        #endregion Public Events

        #region Public Methods

        public static void ForceRequery()
        {
            Application.Current.Dispatcher.Invoke(() =>
            {
                CommandManager.InvalidateRequerySuggested();
            });
        }

        public bool CanExecute(object parameter)
        {
            return canExecute == null || canExecute(parameter);
        }

        public void Execute(object parameter)
        {
            execute(parameter);
        }

        #endregion Public Methods
    }

    public class RelayCommand<ParameterType> : ICommand
    {
        #region Private Fields

        private Action<ParameterType> execute;
        private Func<ParameterType, bool> canExecute;

        #endregion Private Fields

        #region Public Constructors

        public RelayCommand(Action<ParameterType> execute, Func<ParameterType, bool> canExecute = null)
        {
            this.execute = execute;
            this.canExecute = canExecute;
        }

        #endregion Public Constructors

        #region Public Events

        public event EventHandler CanExecuteChanged
        {
            add { CommandManager.RequerySuggested += value; }
            remove { CommandManager.RequerySuggested -= value; }
        }

        #endregion Public Events

        #region Public Methods

        public bool CanExecute(ParameterType parameter)
        {
            return canExecute == null || canExecute(parameter);
        }

        public void Execute(ParameterType parameter)
        {
            execute(parameter);
        }

        public bool CanExecute(object parameter)
        {
            if (parameter is ParameterType parameterInType)
            {
                CanExecute(parameterInType);
            }

            return false;
        }

        public void Execute(object parameter)
        {
            if (parameter is ParameterType parameterInType)
            {
                execute(parameterInType);
            }
        }

        #endregion Public Methods
    }
}