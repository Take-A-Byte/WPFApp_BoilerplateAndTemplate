namespace FrontEnd.Resources
{
    using System;
    using System.Collections.Generic;
    using System.Windows;
    using FrontEnd.Resources.Contracts;

    public class DialogService : IDialogService
    {
        #region Private Fields

        private Dictionary<Type, Type> mappings;

        #endregion Private Fields

        #region Public Constructors

        public DialogService()
        {
            mappings = new Dictionary<Type, Type>();
        }

        #endregion Public Constructors

        #region Public Methods

        public void Register<TViewModel, TView>()
        {
            if (mappings.ContainsKey(typeof(TViewModel)))
            {
                throw new ArgumentException(
                    $"Type {typeof(TViewModel)} is already registered to type {mappings[typeof(TViewModel)]}");
            }

            mappings.Add(typeof(TViewModel), typeof(TView));
        }

        public bool? ShowDialog<TViewModel>(TViewModel viewModel, Window parentWindow = null)
            where TViewModel : IDialogViewModel
        {
            bool? result = null;
            Type viewType = mappings[viewModel.GetType()]; // if key not present will throw error

            return result;
        }

        #endregion Public Methods

        #region Private Methods

        private static bool CheckWindowIsOpen(Type windowType)
        {
            return true;
        }

        #endregion Private Methods
    }
}