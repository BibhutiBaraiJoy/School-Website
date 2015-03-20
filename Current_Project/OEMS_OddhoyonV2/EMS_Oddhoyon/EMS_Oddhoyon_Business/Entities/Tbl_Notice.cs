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
    public partial class Tbl_Notice: IObjectWithChangeTracker, INotifyPropertyChanged
    {
        #region Primitive Properties
    
        [DataMember]
        public int Notice_ID
        {
            get { return _notice_ID; }
            set
            {
                if (_notice_ID != value)
                {
                    if (ChangeTracker.ChangeTrackingEnabled && ChangeTracker.State != ObjectState.Added)
                    {
                        throw new InvalidOperationException("The property 'Notice_ID' is part of the object's key and cannot be changed. Changes to key properties can only be made when the object is not being tracked or is in the Added state.");
                    }
                    _notice_ID = value;
                    OnPropertyChanged("Notice_ID");
                }
            }
        }
        private int _notice_ID;
    
        [DataMember]
        public string Notice_Title
        {
            get { return _notice_Title; }
            set
            {
                if (_notice_Title != value)
                {
                    _notice_Title = value;
                    OnPropertyChanged("Notice_Title");
                }
            }
        }
        private string _notice_Title;
    
        [DataMember]
        public string Notice_Description
        {
            get { return _notice_Description; }
            set
            {
                if (_notice_Description != value)
                {
                    _notice_Description = value;
                    OnPropertyChanged("Notice_Description");
                }
            }
        }
        private string _notice_Description;
    
        [DataMember]
        public Nullable<System.DateTime> Notice_ExpireDate
        {
            get { return _notice_ExpireDate; }
            set
            {
                if (_notice_ExpireDate != value)
                {
                    _notice_ExpireDate = value;
                    OnPropertyChanged("Notice_ExpireDate");
                }
            }
        }
        private Nullable<System.DateTime> _notice_ExpireDate;
    
        [DataMember]
        public string Notice_Status
        {
            get { return _notice_Status; }
            set
            {
                if (_notice_Status != value)
                {
                    _notice_Status = value;
                    OnPropertyChanged("Notice_Status");
                }
            }
        }
        private string _notice_Status;
    
        [DataMember]
        public Nullable<bool> Notice_IsScroll
        {
            get { return _notice_IsScroll; }
            set
            {
                if (_notice_IsScroll != value)
                {
                    _notice_IsScroll = value;
                    OnPropertyChanged("Notice_IsScroll");
                }
            }
        }
        private Nullable<bool> _notice_IsScroll;
    
        [DataMember]
        public Nullable<int> Notice_AddBy
        {
            get { return _notice_AddBy; }
            set
            {
                if (_notice_AddBy != value)
                {
                    _notice_AddBy = value;
                    OnPropertyChanged("Notice_AddBy");
                }
            }
        }
        private Nullable<int> _notice_AddBy;
    
        [DataMember]
        public Nullable<System.DateTime> Notice_AddDate
        {
            get { return _notice_AddDate; }
            set
            {
                if (_notice_AddDate != value)
                {
                    _notice_AddDate = value;
                    OnPropertyChanged("Notice_AddDate");
                }
            }
        }
        private Nullable<System.DateTime> _notice_AddDate;
    
        [DataMember]
        public Nullable<int> Notice_UpdateBy
        {
            get { return _notice_UpdateBy; }
            set
            {
                if (_notice_UpdateBy != value)
                {
                    _notice_UpdateBy = value;
                    OnPropertyChanged("Notice_UpdateBy");
                }
            }
        }
        private Nullable<int> _notice_UpdateBy;
    
        [DataMember]
        public Nullable<System.DateTime> Notice_UpdateDate
        {
            get { return _notice_UpdateDate; }
            set
            {
                if (_notice_UpdateDate != value)
                {
                    _notice_UpdateDate = value;
                    OnPropertyChanged("Notice_UpdateDate");
                }
            }
        }
        private Nullable<System.DateTime> _notice_UpdateDate;
    
        [DataMember]
        public Nullable<System.DateTime> Notice_PublishDate
        {
            get { return _notice_PublishDate; }
            set
            {
                if (_notice_PublishDate != value)
                {
                    _notice_PublishDate = value;
                    OnPropertyChanged("Notice_PublishDate");
                }
            }
        }
        private Nullable<System.DateTime> _notice_PublishDate;

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
