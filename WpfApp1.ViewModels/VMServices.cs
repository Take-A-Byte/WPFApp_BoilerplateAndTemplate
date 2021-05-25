namespace WpfApp1.ViewModels
{
    using System;
    using System.Collections.Generic;
    using WpfApp1.Exceptions;

    /// <summary>
    /// Register global (to view model) services in this class.
    /// </summary>
    internal class VMServices
    {
        #region Private Fields

        private Dictionary<Type, object> services = new Dictionary<Type, object>();

        #endregion Private Fields

        #region Internal Methods

        internal void RegisterService<ServiceType>(ServiceType service) where ServiceType : class
        {
            if (service == null)
            {
                throw new ArgumentNullException(nameof(service));
            }

            services.Add(typeof(ServiceType), service);
        }

        internal ServiceType GetService<ServiceType>()
        {
            if (services.ContainsKey(typeof(ServiceType)))
            {
                return (ServiceType)services[typeof(ServiceType)];
            }

            throw new ServiceNotRegisteredException();
        }

        #endregion Internal Methods
    }
}