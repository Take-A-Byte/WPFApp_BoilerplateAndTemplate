namespace FrontEnd.Resources.Infrastructure
{
    using System;

    public class DialogCloseRequestedEventArgs : EventArgs
    {
        #region Public Constructors

        public DialogCloseRequestedEventArgs(bool? dialogResult = null)
        {
            DialogResult = dialogResult;
        }

        #endregion Public Constructors

        #region Public Properties

        public bool? DialogResult { get; }

        #endregion Public Properties
    }
}