namespace WpfApp1.Exceptions
{
    [System.Serializable]
    public class ServiceNotRegisteredException : System.Exception
    {
        #region Public Constructors

        public ServiceNotRegisteredException()
        {
        }

        public ServiceNotRegisteredException(string message) : base(message)
        {
        }

        public ServiceNotRegisteredException(string message, System.Exception inner) : base(message, inner)
        {
        }

        #endregion Public Constructors

        #region Protected Constructors

        protected ServiceNotRegisteredException(
          System.Runtime.Serialization.SerializationInfo info,
          System.Runtime.Serialization.StreamingContext context) : base(info, context) { }

        #endregion Protected Constructors
    }
}