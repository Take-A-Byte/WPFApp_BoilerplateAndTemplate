namespace FrontEnd.Resources.Contracts
{
    using System;
    using FrontEnd.Resources.Infrastructure;

    public interface IDialogViewModel
    {
        #region Public Events

        event EventHandler<DialogCloseRequestedEventArgs> CloseRequested;

        #endregion Public Events
    }
}