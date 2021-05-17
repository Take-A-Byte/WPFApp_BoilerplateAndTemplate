namespace FrontEnd.Resources
{
    using System.ComponentModel;
    using System.Runtime.CompilerServices;

    public class ObservableBase : INotifyPropertyChanged
    {
        #region Public Events

        public event PropertyChangedEventHandler PropertyChanged;

        #endregion Public Events

        #region Protected Methods

        protected void OnPropertyChanged([CallerMemberName] string changedProperty = "")
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(changedProperty));
        }

        protected void OnPropertyChanged(string[] changedProperties)
        {
            foreach (var changedProperty in changedProperties)
            {
                OnPropertyChanged(changedProperty);
            }
        }

        #endregion Protected Methods
    }
}