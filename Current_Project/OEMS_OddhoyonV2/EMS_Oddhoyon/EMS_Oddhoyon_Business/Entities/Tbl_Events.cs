//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Collections.Specialized;
using System.ComponentModel;
using System.Globalization;
using System.Runtime.Serialization;

namespace EMS_Oddhoyon_Business
{
    [DataContract(IsReference = true)]
    public partial class Tbl_Events: IObjectWithChangeTracker, INotifyPropertyChanged
    {
        #region Primitive Properties
    
        [DataMember]
        public int Events_ID
        {
            get { return _events_ID; }
            set
            {
                if (_events_ID != value)
                {
                    if (ChangeTracker.ChangeTrackingEnabled && ChangeTracker.State != ObjectState.Added)
                    {
                        throw new InvalidOperationException("The property 'Events_ID' is part of the object's key and cannot be changed. Changes to key properties can only be made when the object is not being tracked or is in the Added state.");
                    }
                    _events_ID = value;
                    OnPropertyChanged("Events_ID");
                }
            }
        }
        private int _events_ID;
    
        [DataMember]
        public string Events_Title
        {
            get { return _events_Title; }
            set
            {
                if (_events_Title != value)
                {
                    _events_Title = value;
                    OnPropertyChanged("Events_Title");
                }
            }
        }
        private string _events_Title;
    
        [DataMember]
        public string Events_Description
        {
            get { return _events_Description; }
            set
            {
                if (_events_Description != value)
                {
                    _events_Description = value;
                    OnPropertyChanged("Events_Description");
                }
            }
        }
        private string _events_Description;
    
        [DataMember]
        public string Events_Location
        {
            get { return _events_Location; }
            set
            {
                if (_events_Location != value)
                {
                    _events_Location = value;
                    OnPropertyChanged("Events_Location");
                }
            }
        }
        private string _events_Location;
    
        [DataMember]
        public Nullable<System.DateTime> Events_StartDate
        {
            get { return _events_StartDate; }
            set
            {
                if (_events_StartDate != value)
                {
                    _events_StartDate = value;
                    OnPropertyChanged("Events_StartDate");
                }
            }
        }
        private Nullable<System.DateTime> _events_StartDate;
    
        [DataMember]
        public Nullable<System.DateTime> Events_EndDate
        {
            get { return _events_EndDate; }
            set
            {
                if (_events_EndDate != value)
                {
                    _events_EndDate = value;
                    OnPropertyChanged("Events_EndDate");
                }
            }
        }
        private Nullable<System.DateTime> _events_EndDate;
    
        [DataMember]
        public Nullable<System.DateTime> Exents_ExpireDate
        {
            get { return _exents_ExpireDate; }
            set
            {
                if (_exents_ExpireDate != value)
                {
                    _exents_ExpireDate = value;
                    OnPropertyChanged("Exents_ExpireDate");
                }
            }
        }
        private Nullable<System.DateTime> _exents_ExpireDate;
    
        [DataMember]
        public string Events_Status
        {
            get { return _events_Status; }
            set
            {
                if (_events_Status != value)
                {
                    _events_Status = value;
                    OnPropertyChanged("Events_Status");
                }
            }
        }
        private string _events_Status;
    
        [DataMember]
        public Nullable<int> Events_AddBy
        {
            get { return _events_AddBy; }
            set
            {
                if (_events_AddBy != value)
                {
                    _events_AddBy = value;
                    OnPropertyChanged("Events_AddBy");
                }
            }
        }
        private Nullable<int> _events_AddBy;
    
        [DataMember]
        public Nullable<System.DateTime> Events_AddDate
        {
            get { return _events_AddDate; }
            set
            {
                if (_events_AddDate != value)
                {
                    _events_AddDate = value;
                    OnPropertyChanged("Events_AddDate");
                }
            }
        }
        private Nullable<System.DateTime> _events_AddDate;
    
        [DataMember]
        public Nullable<int> Events_UpdateBy
        {
            get { return _events_UpdateBy; }
            set
            {
                if (_events_UpdateBy != value)
                {
                    _events_UpdateBy = value;
                    OnPropertyChanged("Events_UpdateBy");
                }
            }
        }
        private Nullable<int> _events_UpdateBy;
    
        [DataMember]
        public Nullable<System.DateTime> Events_UpdateDate
        {
            get { return _events_UpdateDate; }
            set
            {
                if (_events_UpdateDate != value)
                {
                    _events_UpdateDate = value;
                    OnPropertyChanged("Events_UpdateDate");
                }
            }
        }
        private Nullable<System.DateTime> _events_UpdateDate;

        #endregion
        #region ChangeTracking
    
        protected virtual void OnPropertyChanged(String propertyName)
        {
            if (ChangeTracker.State != ObjectState.Added && ChangeTracker.State != ObjectState.Deleted)
            {
                ChangeTracker.State = ObjectState.Modified;
            }
            if (_propertyChanged != null)
            {
                _propertyChanged(this, new PropertyChangedEventArgs(propertyName));
            }
        }
    
        protected virtual void OnNavigationPropertyChanged(String propertyName)
        {
            if (_propertyChanged != null)
            {
                _propertyChanged(this, new PropertyChangedEventArgs(propertyName));
            }
        }
    
        event PropertyChangedEventHandler INotifyPropertyChanged.PropertyChanged{ add { _propertyChanged += value; } remove { _propertyChanged -= value; } }
        private event PropertyChangedEventHandler _propertyChanged;
        private ObjectChangeTracker _changeTracker;
    
        [DataMember]
        public ObjectChangeTracker ChangeTracker
        {
            get
            {
                if (_changeTracker == null)
                {
                    _changeTracker = new ObjectChangeTracker();
                    _changeTracker.ObjectStateChanging += HandleObjectStateChanging;
                }
                return _changeTracker;
            }
            set
            {
                if(_changeTracker != null)
                {
                    _changeTracker.ObjectStateChanging -= HandleObjectStateChanging;
                }
                _changeTracker = value;
                if(_changeTracker != null)
                {
                    _changeTracker.ObjectStateChanging += HandleObjectStateChanging;
                }
            }
        }
    
        private void HandleObjectStateChanging(object sender, ObjectStateChangingEventArgs e)
        {
            if (e.NewState == ObjectState.Deleted)
            {
                ClearNavigationProperties();
            }
        }
    
        protected bool IsDeserializing { get; private set; }
    
        [OnDeserializing]
        public void OnDeserializingMethod(StreamingContext context)
        {
            IsDeserializing = true;
        }
    
        [OnDeserialized]
        public void OnDeserializedMethod(StreamingContext context)
        {
            IsDeserializing = false;
            ChangeTracker.ChangeTrackingEnabled = true;
        }
    
        protected virtual void ClearNavigationProperties()
        {
        }

        #endregion
    }
}
