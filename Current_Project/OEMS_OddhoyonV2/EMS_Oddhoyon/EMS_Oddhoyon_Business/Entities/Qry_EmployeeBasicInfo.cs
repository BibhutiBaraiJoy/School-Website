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
    public partial class Qry_EmployeeBasicInfo: IObjectWithChangeTracker, INotifyPropertyChanged
    {
        #region Primitive Properties
    
        [DataMember]
        public string EmployeeBasicInfo_EmployeeID
        {
            get { return _employeeBasicInfo_EmployeeID; }
            set
            {
                if (_employeeBasicInfo_EmployeeID != value)
                {
                    _employeeBasicInfo_EmployeeID = value;
                    OnPropertyChanged("EmployeeBasicInfo_EmployeeID");
                }
            }
        }
        private string _employeeBasicInfo_EmployeeID;
    
        [DataMember]
        public string EmployeeBasicInfo_Name
        {
            get { return _employeeBasicInfo_Name; }
            set
            {
                if (_employeeBasicInfo_Name != value)
                {
                    _employeeBasicInfo_Name = value;
                    OnPropertyChanged("EmployeeBasicInfo_Name");
                }
            }
        }
        private string _employeeBasicInfo_Name;
    
        [DataMember]
        public int EmployeeBasicInfo_DesignationID
        {
            get { return _employeeBasicInfo_DesignationID; }
            set
            {
                if (_employeeBasicInfo_DesignationID != value)
                {
                    if (ChangeTracker.ChangeTrackingEnabled && ChangeTracker.State != ObjectState.Added)
                    {
                        throw new InvalidOperationException("The property 'EmployeeBasicInfo_DesignationID' is part of the object's key and cannot be changed. Changes to key properties can only be made when the object is not being tracked or is in the Added state.");
                    }
                    _employeeBasicInfo_DesignationID = value;
                    OnPropertyChanged("EmployeeBasicInfo_DesignationID");
                }
            }
        }
        private int _employeeBasicInfo_DesignationID;
    
        [DataMember]
        public bool EmployeeBasicInfo_IsClassTeacher
        {
            get { return _employeeBasicInfo_IsClassTeacher; }
            set
            {
                if (_employeeBasicInfo_IsClassTeacher != value)
                {
                    if (ChangeTracker.ChangeTrackingEnabled && ChangeTracker.State != ObjectState.Added)
                    {
                        throw new InvalidOperationException("The property 'EmployeeBasicInfo_IsClassTeacher' is part of the object's key and cannot be changed. Changes to key properties can only be made when the object is not being tracked or is in the Added state.");
                    }
                    _employeeBasicInfo_IsClassTeacher = value;
                    OnPropertyChanged("EmployeeBasicInfo_IsClassTeacher");
                }
            }
        }
        private bool _employeeBasicInfo_IsClassTeacher;
    
        [DataMember]
        public int EmployeeBasicInfo_TypeID
        {
            get { return _employeeBasicInfo_TypeID; }
            set
            {
                if (_employeeBasicInfo_TypeID != value)
                {
                    if (ChangeTracker.ChangeTrackingEnabled && ChangeTracker.State != ObjectState.Added)
                    {
                        throw new InvalidOperationException("The property 'EmployeeBasicInfo_TypeID' is part of the object's key and cannot be changed. Changes to key properties can only be made when the object is not being tracked or is in the Added state.");
                    }
                    _employeeBasicInfo_TypeID = value;
                    OnPropertyChanged("EmployeeBasicInfo_TypeID");
                }
            }
        }
        private int _employeeBasicInfo_TypeID;
    
        [DataMember]
        public int EmployeeBasicInfo_BranchID
        {
            get { return _employeeBasicInfo_BranchID; }
            set
            {
                if (_employeeBasicInfo_BranchID != value)
                {
                    if (ChangeTracker.ChangeTrackingEnabled && ChangeTracker.State != ObjectState.Added)
                    {
                        throw new InvalidOperationException("The property 'EmployeeBasicInfo_BranchID' is part of the object's key and cannot be changed. Changes to key properties can only be made when the object is not being tracked or is in the Added state.");
                    }
                    _employeeBasicInfo_BranchID = value;
                    OnPropertyChanged("EmployeeBasicInfo_BranchID");
                }
            }
        }
        private int _employeeBasicInfo_BranchID;
    
        [DataMember]
        public int EmployeeBasicInfo_ShiftID
        {
            get { return _employeeBasicInfo_ShiftID; }
            set
            {
                if (_employeeBasicInfo_ShiftID != value)
                {
                    if (ChangeTracker.ChangeTrackingEnabled && ChangeTracker.State != ObjectState.Added)
                    {
                        throw new InvalidOperationException("The property 'EmployeeBasicInfo_ShiftID' is part of the object's key and cannot be changed. Changes to key properties can only be made when the object is not being tracked or is in the Added state.");
                    }
                    _employeeBasicInfo_ShiftID = value;
                    OnPropertyChanged("EmployeeBasicInfo_ShiftID");
                }
            }
        }
        private int _employeeBasicInfo_ShiftID;
    
        [DataMember]
        public int EmployeeBasicInfo_DepartmentID
        {
            get { return _employeeBasicInfo_DepartmentID; }
            set
            {
                if (_employeeBasicInfo_DepartmentID != value)
                {
                    if (ChangeTracker.ChangeTrackingEnabled && ChangeTracker.State != ObjectState.Added)
                    {
                        throw new InvalidOperationException("The property 'EmployeeBasicInfo_DepartmentID' is part of the object's key and cannot be changed. Changes to key properties can only be made when the object is not being tracked or is in the Added state.");
                    }
                    _employeeBasicInfo_DepartmentID = value;
                    OnPropertyChanged("EmployeeBasicInfo_DepartmentID");
                }
            }
        }
        private int _employeeBasicInfo_DepartmentID;
    
        [DataMember]
        public int EmployeeBasicInfo_SubjectID
        {
            get { return _employeeBasicInfo_SubjectID; }
            set
            {
                if (_employeeBasicInfo_SubjectID != value)
                {
                    if (ChangeTracker.ChangeTrackingEnabled && ChangeTracker.State != ObjectState.Added)
                    {
                        throw new InvalidOperationException("The property 'EmployeeBasicInfo_SubjectID' is part of the object's key and cannot be changed. Changes to key properties can only be made when the object is not being tracked or is in the Added state.");
                    }
                    _employeeBasicInfo_SubjectID = value;
                    OnPropertyChanged("EmployeeBasicInfo_SubjectID");
                }
            }
        }
        private int _employeeBasicInfo_SubjectID;
    
        [DataMember]
        public System.DateTime EmployeeBasicInfo_JoiningDate
        {
            get { return _employeeBasicInfo_JoiningDate; }
            set
            {
                if (_employeeBasicInfo_JoiningDate != value)
                {
                    if (ChangeTracker.ChangeTrackingEnabled && ChangeTracker.State != ObjectState.Added)
                    {
                        throw new InvalidOperationException("The property 'EmployeeBasicInfo_JoiningDate' is part of the object's key and cannot be changed. Changes to key properties can only be made when the object is not being tracked or is in the Added state.");
                    }
                    _employeeBasicInfo_JoiningDate = value;
                    OnPropertyChanged("EmployeeBasicInfo_JoiningDate");
                }
            }
        }
        private System.DateTime _employeeBasicInfo_JoiningDate;
    
        [DataMember]
        public int EmployeeBasicInfo_StatusID
        {
            get { return _employeeBasicInfo_StatusID; }
            set
            {
                if (_employeeBasicInfo_StatusID != value)
                {
                    if (ChangeTracker.ChangeTrackingEnabled && ChangeTracker.State != ObjectState.Added)
                    {
                        throw new InvalidOperationException("The property 'EmployeeBasicInfo_StatusID' is part of the object's key and cannot be changed. Changes to key properties can only be made when the object is not being tracked or is in the Added state.");
                    }
                    _employeeBasicInfo_StatusID = value;
                    OnPropertyChanged("EmployeeBasicInfo_StatusID");
                }
            }
        }
        private int _employeeBasicInfo_StatusID;
    
        [DataMember]
        public byte[] EmployeeBasicInfo_Image
        {
            get { return _employeeBasicInfo_Image; }
            set
            {
                if (_employeeBasicInfo_Image != value)
                {
                    _employeeBasicInfo_Image = value;
                    OnPropertyChanged("EmployeeBasicInfo_Image");
                }
            }
        }
        private byte[] _employeeBasicInfo_Image;
    
        [DataMember]
        public string EmployeeBasicInfo_FatherName
        {
            get { return _employeeBasicInfo_FatherName; }
            set
            {
                if (_employeeBasicInfo_FatherName != value)
                {
                    _employeeBasicInfo_FatherName = value;
                    OnPropertyChanged("EmployeeBasicInfo_FatherName");
                }
            }
        }
        private string _employeeBasicInfo_FatherName;
    
        [DataMember]
        public string EmployeeBasicInfo_MotherName
        {
            get { return _employeeBasicInfo_MotherName; }
            set
            {
                if (_employeeBasicInfo_MotherName != value)
                {
                    _employeeBasicInfo_MotherName = value;
                    OnPropertyChanged("EmployeeBasicInfo_MotherName");
                }
            }
        }
        private string _employeeBasicInfo_MotherName;
    
        [DataMember]
        public string EmployeeBasicInfo_Nationality
        {
            get { return _employeeBasicInfo_Nationality; }
            set
            {
                if (_employeeBasicInfo_Nationality != value)
                {
                    _employeeBasicInfo_Nationality = value;
                    OnPropertyChanged("EmployeeBasicInfo_Nationality");
                }
            }
        }
        private string _employeeBasicInfo_Nationality;
    
        [DataMember]
        public string EmployeeBasicInfo_Religion
        {
            get { return _employeeBasicInfo_Religion; }
            set
            {
                if (_employeeBasicInfo_Religion != value)
                {
                    _employeeBasicInfo_Religion = value;
                    OnPropertyChanged("EmployeeBasicInfo_Religion");
                }
            }
        }
        private string _employeeBasicInfo_Religion;
    
        [DataMember]
        public string EmployeeBasicInfo_BloodGroup
        {
            get { return _employeeBasicInfo_BloodGroup; }
            set
            {
                if (_employeeBasicInfo_BloodGroup != value)
                {
                    _employeeBasicInfo_BloodGroup = value;
                    OnPropertyChanged("EmployeeBasicInfo_BloodGroup");
                }
            }
        }
        private string _employeeBasicInfo_BloodGroup;
    
        [DataMember]
        public System.DateTime EmployeeBasicInfo_DateOfBirth
        {
            get { return _employeeBasicInfo_DateOfBirth; }
            set
            {
                if (_employeeBasicInfo_DateOfBirth != value)
                {
                    if (ChangeTracker.ChangeTrackingEnabled && ChangeTracker.State != ObjectState.Added)
                    {
                        throw new InvalidOperationException("The property 'EmployeeBasicInfo_DateOfBirth' is part of the object's key and cannot be changed. Changes to key properties can only be made when the object is not being tracked or is in the Added state.");
                    }
                    _employeeBasicInfo_DateOfBirth = value;
                    OnPropertyChanged("EmployeeBasicInfo_DateOfBirth");
                }
            }
        }
        private System.DateTime _employeeBasicInfo_DateOfBirth;
    
        [DataMember]
        public string EmployeeBasicInfo_NationalID
        {
            get { return _employeeBasicInfo_NationalID; }
            set
            {
                if (_employeeBasicInfo_NationalID != value)
                {
                    _employeeBasicInfo_NationalID = value;
                    OnPropertyChanged("EmployeeBasicInfo_NationalID");
                }
            }
        }
        private string _employeeBasicInfo_NationalID;
    
        [DataMember]
        public string EmployeeBasicInfo_Contact
        {
            get { return _employeeBasicInfo_Contact; }
            set
            {
                if (_employeeBasicInfo_Contact != value)
                {
                    _employeeBasicInfo_Contact = value;
                    OnPropertyChanged("EmployeeBasicInfo_Contact");
                }
            }
        }
        private string _employeeBasicInfo_Contact;
    
        [DataMember]
        public string EmployeeBasicInfo_PresentAddress
        {
            get { return _employeeBasicInfo_PresentAddress; }
            set
            {
                if (_employeeBasicInfo_PresentAddress != value)
                {
                    _employeeBasicInfo_PresentAddress = value;
                    OnPropertyChanged("EmployeeBasicInfo_PresentAddress");
                }
            }
        }
        private string _employeeBasicInfo_PresentAddress;
    
        [DataMember]
        public string EmployeeBasicInfo_PresentPost
        {
            get { return _employeeBasicInfo_PresentPost; }
            set
            {
                if (_employeeBasicInfo_PresentPost != value)
                {
                    _employeeBasicInfo_PresentPost = value;
                    OnPropertyChanged("EmployeeBasicInfo_PresentPost");
                }
            }
        }
        private string _employeeBasicInfo_PresentPost;
    
        [DataMember]
        public string EmployeeBasicInfo_PresentThana
        {
            get { return _employeeBasicInfo_PresentThana; }
            set
            {
                if (_employeeBasicInfo_PresentThana != value)
                {
                    _employeeBasicInfo_PresentThana = value;
                    OnPropertyChanged("EmployeeBasicInfo_PresentThana");
                }
            }
        }
        private string _employeeBasicInfo_PresentThana;
    
        [DataMember]
        public string EmployeeBasicInfo_PresentDistrict
        {
            get { return _employeeBasicInfo_PresentDistrict; }
            set
            {
                if (_employeeBasicInfo_PresentDistrict != value)
                {
                    _employeeBasicInfo_PresentDistrict = value;
                    OnPropertyChanged("EmployeeBasicInfo_PresentDistrict");
                }
            }
        }
        private string _employeeBasicInfo_PresentDistrict;
    
        [DataMember]
        public string EmployeeBasicInfo_PermanentAddress
        {
            get { return _employeeBasicInfo_PermanentAddress; }
            set
            {
                if (_employeeBasicInfo_PermanentAddress != value)
                {
                    _employeeBasicInfo_PermanentAddress = value;
                    OnPropertyChanged("EmployeeBasicInfo_PermanentAddress");
                }
            }
        }
        private string _employeeBasicInfo_PermanentAddress;
    
        [DataMember]
        public string EmployeeBasicInfo_PermanentPost
        {
            get { return _employeeBasicInfo_PermanentPost; }
            set
            {
                if (_employeeBasicInfo_PermanentPost != value)
                {
                    _employeeBasicInfo_PermanentPost = value;
                    OnPropertyChanged("EmployeeBasicInfo_PermanentPost");
                }
            }
        }
        private string _employeeBasicInfo_PermanentPost;
    
        [DataMember]
        public string EmployeeBasicInfo_PermanentThana
        {
            get { return _employeeBasicInfo_PermanentThana; }
            set
            {
                if (_employeeBasicInfo_PermanentThana != value)
                {
                    _employeeBasicInfo_PermanentThana = value;
                    OnPropertyChanged("EmployeeBasicInfo_PermanentThana");
                }
            }
        }
        private string _employeeBasicInfo_PermanentThana;
    
        [DataMember]
        public string EmployeeBasicInfo_PermanentDistrict
        {
            get { return _employeeBasicInfo_PermanentDistrict; }
            set
            {
                if (_employeeBasicInfo_PermanentDistrict != value)
                {
                    _employeeBasicInfo_PermanentDistrict = value;
                    OnPropertyChanged("EmployeeBasicInfo_PermanentDistrict");
                }
            }
        }
        private string _employeeBasicInfo_PermanentDistrict;
    
        [DataMember]
        public string EmployeeBasicInfo_Status
        {
            get { return _employeeBasicInfo_Status; }
            set
            {
                if (_employeeBasicInfo_Status != value)
                {
                    _employeeBasicInfo_Status = value;
                    OnPropertyChanged("EmployeeBasicInfo_Status");
                }
            }
        }
        private string _employeeBasicInfo_Status;
    
        [DataMember]
        public string EmployeeBasicInfo_InstituteAccount
        {
            get { return _employeeBasicInfo_InstituteAccount; }
            set
            {
                if (_employeeBasicInfo_InstituteAccount != value)
                {
                    _employeeBasicInfo_InstituteAccount = value;
                    OnPropertyChanged("EmployeeBasicInfo_InstituteAccount");
                }
            }
        }
        private string _employeeBasicInfo_InstituteAccount;
    
        [DataMember]
        public string EmployeeBasicInfo_GovtAccount
        {
            get { return _employeeBasicInfo_GovtAccount; }
            set
            {
                if (_employeeBasicInfo_GovtAccount != value)
                {
                    _employeeBasicInfo_GovtAccount = value;
                    OnPropertyChanged("EmployeeBasicInfo_GovtAccount");
                }
            }
        }
        private string _employeeBasicInfo_GovtAccount;
    
        [DataMember]
        public bool EmployeeBasicInfo_IsGovtSalaryActive
        {
            get { return _employeeBasicInfo_IsGovtSalaryActive; }
            set
            {
                if (_employeeBasicInfo_IsGovtSalaryActive != value)
                {
                    if (ChangeTracker.ChangeTrackingEnabled && ChangeTracker.State != ObjectState.Added)
                    {
                        throw new InvalidOperationException("The property 'EmployeeBasicInfo_IsGovtSalaryActive' is part of the object's key and cannot be changed. Changes to key properties can only be made when the object is not being tracked or is in the Added state.");
                    }
                    _employeeBasicInfo_IsGovtSalaryActive = value;
                    OnPropertyChanged("EmployeeBasicInfo_IsGovtSalaryActive");
                }
            }
        }
        private bool _employeeBasicInfo_IsGovtSalaryActive;
    
        [DataMember]
        public int EmployeeBasicInfo_GovtSalaryGrade
        {
            get { return _employeeBasicInfo_GovtSalaryGrade; }
            set
            {
                if (_employeeBasicInfo_GovtSalaryGrade != value)
                {
                    if (ChangeTracker.ChangeTrackingEnabled && ChangeTracker.State != ObjectState.Added)
                    {
                        throw new InvalidOperationException("The property 'EmployeeBasicInfo_GovtSalaryGrade' is part of the object's key and cannot be changed. Changes to key properties can only be made when the object is not being tracked or is in the Added state.");
                    }
                    _employeeBasicInfo_GovtSalaryGrade = value;
                    OnPropertyChanged("EmployeeBasicInfo_GovtSalaryGrade");
                }
            }
        }
        private int _employeeBasicInfo_GovtSalaryGrade;
    
        [DataMember]
        public string Designation_Name
        {
            get { return _designation_Name; }
            set
            {
                if (_designation_Name != value)
                {
                    _designation_Name = value;
                    OnPropertyChanged("Designation_Name");
                }
            }
        }
        private string _designation_Name;
    
        [DataMember]
        public string EmployeeType_Name
        {
            get { return _employeeType_Name; }
            set
            {
                if (_employeeType_Name != value)
                {
                    _employeeType_Name = value;
                    OnPropertyChanged("EmployeeType_Name");
                }
            }
        }
        private string _employeeType_Name;
    
        [DataMember]
        public string EmployeeDepartment_Name
        {
            get { return _employeeDepartment_Name; }
            set
            {
                if (_employeeDepartment_Name != value)
                {
                    if (ChangeTracker.ChangeTrackingEnabled && ChangeTracker.State != ObjectState.Added)
                    {
                        throw new InvalidOperationException("The property 'EmployeeDepartment_Name' is part of the object's key and cannot be changed. Changes to key properties can only be made when the object is not being tracked or is in the Added state.");
                    }
                    _employeeDepartment_Name = value;
                    OnPropertyChanged("EmployeeDepartment_Name");
                }
            }
        }
        private string _employeeDepartment_Name;
    
        [DataMember]
        public string EmployeeStatus_Name
        {
            get { return _employeeStatus_Name; }
            set
            {
                if (_employeeStatus_Name != value)
                {
                    _employeeStatus_Name = value;
                    OnPropertyChanged("EmployeeStatus_Name");
                }
            }
        }
        private string _employeeStatus_Name;
    
        [DataMember]
        public string ShiftSetup_Name
        {
            get { return _shiftSetup_Name; }
            set
            {
                if (_shiftSetup_Name != value)
                {
                    if (ChangeTracker.ChangeTrackingEnabled && ChangeTracker.State != ObjectState.Added)
                    {
                        throw new InvalidOperationException("The property 'ShiftSetup_Name' is part of the object's key and cannot be changed. Changes to key properties can only be made when the object is not being tracked or is in the Added state.");
                    }
                    _shiftSetup_Name = value;
                    OnPropertyChanged("ShiftSetup_Name");
                }
            }
        }
        private string _shiftSetup_Name;
    
        [DataMember]
        public string Branch_Name
        {
            get { return _branch_Name; }
            set
            {
                if (_branch_Name != value)
                {
                    if (ChangeTracker.ChangeTrackingEnabled && ChangeTracker.State != ObjectState.Added)
                    {
                        throw new InvalidOperationException("The property 'Branch_Name' is part of the object's key and cannot be changed. Changes to key properties can only be made when the object is not being tracked or is in the Added state.");
                    }
                    _branch_Name = value;
                    OnPropertyChanged("Branch_Name");
                }
            }
        }
        private string _branch_Name;
    
        [DataMember]
        public int EmployeeBasicInfo_ID
        {
            get { return _employeeBasicInfo_ID; }
            set
            {
                if (_employeeBasicInfo_ID != value)
                {
                    if (ChangeTracker.ChangeTrackingEnabled && ChangeTracker.State != ObjectState.Added)
                    {
                        throw new InvalidOperationException("The property 'EmployeeBasicInfo_ID' is part of the object's key and cannot be changed. Changes to key properties can only be made when the object is not being tracked or is in the Added state.");
                    }
                    _employeeBasicInfo_ID = value;
                    OnPropertyChanged("EmployeeBasicInfo_ID");
                }
            }
        }
        private int _employeeBasicInfo_ID;
    
        [DataMember]
        public int EmployeeBasicInfo_SectionID
        {
            get { return _employeeBasicInfo_SectionID; }
            set
            {
                if (_employeeBasicInfo_SectionID != value)
                {
                    if (ChangeTracker.ChangeTrackingEnabled && ChangeTracker.State != ObjectState.Added)
                    {
                        throw new InvalidOperationException("The property 'EmployeeBasicInfo_SectionID' is part of the object's key and cannot be changed. Changes to key properties can only be made when the object is not being tracked or is in the Added state.");
                    }
                    _employeeBasicInfo_SectionID = value;
                    OnPropertyChanged("EmployeeBasicInfo_SectionID");
                }
            }
        }
        private int _employeeBasicInfo_SectionID;
    
        [DataMember]
        public string EmployeeBasicInfo_DbOperationStatus
        {
            get { return _employeeBasicInfo_DbOperationStatus; }
            set
            {
                if (_employeeBasicInfo_DbOperationStatus != value)
                {
                    if (ChangeTracker.ChangeTrackingEnabled && ChangeTracker.State != ObjectState.Added)
                    {
                        throw new InvalidOperationException("The property 'EmployeeBasicInfo_DbOperationStatus' is part of the object's key and cannot be changed. Changes to key properties can only be made when the object is not being tracked or is in the Added state.");
                    }
                    _employeeBasicInfo_DbOperationStatus = value;
                    OnPropertyChanged("EmployeeBasicInfo_DbOperationStatus");
                }
            }
        }
        private string _employeeBasicInfo_DbOperationStatus;
    
        [DataMember]
        public Nullable<int> EmployeeBasicInfo_CategoryID
        {
            get { return _employeeBasicInfo_CategoryID; }
            set
            {
                if (_employeeBasicInfo_CategoryID != value)
                {
                    _employeeBasicInfo_CategoryID = value;
                    OnPropertyChanged("EmployeeBasicInfo_CategoryID");
                }
            }
        }
        private Nullable<int> _employeeBasicInfo_CategoryID;
    
        [DataMember]
        public Nullable<int> EmployeeBasicInfo_VersionID
        {
            get { return _employeeBasicInfo_VersionID; }
            set
            {
                if (_employeeBasicInfo_VersionID != value)
                {
                    _employeeBasicInfo_VersionID = value;
                    OnPropertyChanged("EmployeeBasicInfo_VersionID");
                }
            }
        }
        private Nullable<int> _employeeBasicInfo_VersionID;
    
        [DataMember]
        public string EmployeeBasicInfo_Gender
        {
            get { return _employeeBasicInfo_Gender; }
            set
            {
                if (_employeeBasicInfo_Gender != value)
                {
                    _employeeBasicInfo_Gender = value;
                    OnPropertyChanged("EmployeeBasicInfo_Gender");
                }
            }
        }
        private string _employeeBasicInfo_Gender;
    
        [DataMember]
        public string EmployeeBasicInfo_MaritalStatus
        {
            get { return _employeeBasicInfo_MaritalStatus; }
            set
            {
                if (_employeeBasicInfo_MaritalStatus != value)
                {
                    _employeeBasicInfo_MaritalStatus = value;
                    OnPropertyChanged("EmployeeBasicInfo_MaritalStatus");
                }
            }
        }
        private string _employeeBasicInfo_MaritalStatus;
    
        [DataMember]
        public string EmployeeBasicInfo_EmergencyContactAddress
        {
            get { return _employeeBasicInfo_EmergencyContactAddress; }
            set
            {
                if (_employeeBasicInfo_EmergencyContactAddress != value)
                {
                    _employeeBasicInfo_EmergencyContactAddress = value;
                    OnPropertyChanged("EmployeeBasicInfo_EmergencyContactAddress");
                }
            }
        }
        private string _employeeBasicInfo_EmergencyContactAddress;
    
        [DataMember]
        public string EmployeeBasicInfo_EmergencyTandTNo
        {
            get { return _employeeBasicInfo_EmergencyTandTNo; }
            set
            {
                if (_employeeBasicInfo_EmergencyTandTNo != value)
                {
                    _employeeBasicInfo_EmergencyTandTNo = value;
                    OnPropertyChanged("EmployeeBasicInfo_EmergencyTandTNo");
                }
            }
        }
        private string _employeeBasicInfo_EmergencyTandTNo;
    
        [DataMember]
        public string EmployeeBasicInfo_MobileNo
        {
            get { return _employeeBasicInfo_MobileNo; }
            set
            {
                if (_employeeBasicInfo_MobileNo != value)
                {
                    _employeeBasicInfo_MobileNo = value;
                    OnPropertyChanged("EmployeeBasicInfo_MobileNo");
                }
            }
        }
        private string _employeeBasicInfo_MobileNo;
    
        [DataMember]
        public string EmployeeBasicInfo_Email
        {
            get { return _employeeBasicInfo_Email; }
            set
            {
                if (_employeeBasicInfo_Email != value)
                {
                    _employeeBasicInfo_Email = value;
                    OnPropertyChanged("EmployeeBasicInfo_Email");
                }
            }
        }
        private string _employeeBasicInfo_Email;
    
        [DataMember]
        public string EmployeeBasicInfo_SMSNotificationNo
        {
            get { return _employeeBasicInfo_SMSNotificationNo; }
            set
            {
                if (_employeeBasicInfo_SMSNotificationNo != value)
                {
                    _employeeBasicInfo_SMSNotificationNo = value;
                    OnPropertyChanged("EmployeeBasicInfo_SMSNotificationNo");
                }
            }
        }
        private string _employeeBasicInfo_SMSNotificationNo;
    
        [DataMember]
        public string EmployeeSubject_Name
        {
            get { return _employeeSubject_Name; }
            set
            {
                if (_employeeSubject_Name != value)
                {
                    if (ChangeTracker.ChangeTrackingEnabled && ChangeTracker.State != ObjectState.Added)
                    {
                        throw new InvalidOperationException("The property 'EmployeeSubject_Name' is part of the object's key and cannot be changed. Changes to key properties can only be made when the object is not being tracked or is in the Added state.");
                    }
                    _employeeSubject_Name = value;
                    OnPropertyChanged("EmployeeSubject_Name");
                }
            }
        }
        private string _employeeSubject_Name;
    
        [DataMember]
        public string Version_Name
        {
            get { return _version_Name; }
            set
            {
                if (_version_Name != value)
                {
                    if (ChangeTracker.ChangeTrackingEnabled && ChangeTracker.State != ObjectState.Added)
                    {
                        throw new InvalidOperationException("The property 'Version_Name' is part of the object's key and cannot be changed. Changes to key properties can only be made when the object is not being tracked or is in the Added state.");
                    }
                    _version_Name = value;
                    OnPropertyChanged("Version_Name");
                }
            }
        }
        private string _version_Name;
    
        [DataMember]
        public string CategoryName
        {
            get { return _categoryName; }
            set
            {
                if (_categoryName != value)
                {
                    _categoryName = value;
                    OnPropertyChanged("CategoryName");
                }
            }
        }
        private string _categoryName;
    
        [DataMember]
        public string EmployeeSection_Name
        {
            get { return _employeeSection_Name; }
            set
            {
                if (_employeeSection_Name != value)
                {
                    _employeeSection_Name = value;
                    OnPropertyChanged("EmployeeSection_Name");
                }
            }
        }
        private string _employeeSection_Name;
    
        [DataMember]
        public string EmployeeBasicInfo_EmpDeviceUserID
        {
            get { return _employeeBasicInfo_EmpDeviceUserID; }
            set
            {
                if (_employeeBasicInfo_EmpDeviceUserID != value)
                {
                    _employeeBasicInfo_EmpDeviceUserID = value;
                    OnPropertyChanged("EmployeeBasicInfo_EmpDeviceUserID");
                }
            }
        }
        private string _employeeBasicInfo_EmpDeviceUserID;
    
        [DataMember]
        public string EmployeeBasicInfo_CardNo
        {
            get { return _employeeBasicInfo_CardNo; }
            set
            {
                if (_employeeBasicInfo_CardNo != value)
                {
                    _employeeBasicInfo_CardNo = value;
                    OnPropertyChanged("EmployeeBasicInfo_CardNo");
                }
            }
        }
        private string _employeeBasicInfo_CardNo;
    
        [DataMember]
        public Nullable<int> EmployeeShift_ID
        {
            get { return _employeeShift_ID; }
            set
            {
                if (_employeeShift_ID != value)
                {
                    _employeeShift_ID = value;
                    OnPropertyChanged("EmployeeShift_ID");
                }
            }
        }
        private Nullable<int> _employeeShift_ID;
    
        [DataMember]
        public string EmployeeShift_Name
        {
            get { return _employeeShift_Name; }
            set
            {
                if (_employeeShift_Name != value)
                {
                    _employeeShift_Name = value;
                    OnPropertyChanged("EmployeeShift_Name");
                }
            }
        }
        private string _employeeShift_Name;

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