namespace FrontEnd.Resources.Contracts
{
    using System.Windows;

    public interface IDialogService
    {
        #region Public Methods

        bool? ShowDialog<TViewModel>(TViewModel viewModel, Window parentWindow = null)
            where TViewModel : IDialogViewModel;

        #endregion Public Methods
    }
}