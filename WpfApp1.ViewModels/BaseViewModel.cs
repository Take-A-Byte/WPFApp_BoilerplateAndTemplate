namespace WpfApp1.ViewModels
{
    using System;
    using System.Collections.Generic;
    using FrontEnd.Resources;
    using FrontEnd.Resources.Contracts;

    public class BaseViewModel : Observable
    {
        #region Private Classes

        private static class ViewModelMediator
        {
            #region Private Fields

            internal static Dictionary<VMEvent, List<EventHandler>> eventHandlers;

            #endregion Private Fields

            #region Public Constructors

            static ViewModelMediator()
            {
                eventHandlers = new Dictionary<VMEvent, List<EventHandler>>();
                foreach (VMEvent vmEvent in Enum.GetValues(typeof(VMEvent)))
                {
                    eventHandlers.Add(vmEvent, null);
                }
            }

            #endregion Public Constructors
        }

        #endregion Private Classes

        #region Protected Enums

        protected enum VMEvent
        {
        }

        #endregion Protected Enums

        #region Protected Properties

        protected static IDialogService DialogService { get; }

        #endregion Protected Properties

        #region Protected Methods

        protected void RegisterForEvent(VMEvent vmEvent, EventHandler handler)
        {
            if (!ViewModelMediator.eventHandlers[vmEvent].Contains(handler))
            {
                ViewModelMediator.eventHandlers[vmEvent].Add(handler);
            }
        }

        protected void DeRegisterForEvent(VMEvent vmEvent, EventHandler handler)
        {
            if (ViewModelMediator.eventHandlers[vmEvent].Contains(handler))
            {
                ViewModelMediator.eventHandlers[vmEvent].Remove(handler);
            }
        }

        protected void TryInvokeEvent(VMEvent vmEvent, EventArgs args)
        {
            // If want certain events to ve invoked based on certain conditions only
            // TODO: add conditions here
            foreach (var handler in ViewModelMediator.eventHandlers[vmEvent])
            {
                handler(this, args);
            }
        }

        #endregion Protected Methods
    }
}