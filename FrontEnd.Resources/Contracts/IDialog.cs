namespace FrontEnd.Resources.Contracts
{
    using System.ComponentModel;
    using System.Windows;

    public interface IDialog
    {
        #region Public Properties

        object DataContext { get; set; }

        bool? DialogResult { get; }

        Window Owner { get; set; }

        #endregion Public Properties

        #region Public Events

        event CancelEventHandler Closing;

        #endregion Public Events

        #region Public Methods

        void Close();

        bool? ShowDialog();

        #endregion Public Methods
    }
}