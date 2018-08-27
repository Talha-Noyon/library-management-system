﻿#pragma warning disable 1591
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.36366
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Library_Managment_System.Entity
{
	using System.Data.Linq;
	using System.Data.Linq.Mapping;
	using System.Data;
	using System.Collections.Generic;
	using System.Reflection;
	using System.Linq;
	using System.Linq.Expressions;
	using System.ComponentModel;
	using System;
	
	
	[global::System.Data.Linq.Mapping.DatabaseAttribute(Name="LibraryDB")]
	public partial class LibraryDBDataContext : System.Data.Linq.DataContext
	{
		
		private static System.Data.Linq.Mapping.MappingSource mappingSource = new AttributeMappingSource();
		
    #region Extensibility Method Definitions
    partial void OnCreated();
    partial void InsertUser(User instance);
    partial void UpdateUser(User instance);
    partial void DeleteUser(User instance);
    partial void InsertBookSelf(BookSelf instance);
    partial void UpdateBookSelf(BookSelf instance);
    partial void DeleteBookSelf(BookSelf instance);
    partial void InsertBrowseBook(BrowseBook instance);
    partial void UpdateBrowseBook(BrowseBook instance);
    partial void DeleteBrowseBook(BrowseBook instance);
    #endregion
		
		public LibraryDBDataContext() : 
				base(global::Library_Managment_System.Entity.Properties.Settings.Default.LibraryDBConnectionString, mappingSource)
		{
			OnCreated();
		}
		
		public LibraryDBDataContext(string connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public LibraryDBDataContext(System.Data.IDbConnection connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public LibraryDBDataContext(string connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public LibraryDBDataContext(System.Data.IDbConnection connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public System.Data.Linq.Table<User> Users
		{
			get
			{
				return this.GetTable<User>();
			}
		}
		
		public System.Data.Linq.Table<BookSelf> BookSelfs
		{
			get
			{
				return this.GetTable<BookSelf>();
			}
		}
		
		public System.Data.Linq.Table<BrowseBook> BrowseBooks
		{
			get
			{
				return this.GetTable<BrowseBook>();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.[User]")]
	public partial class User : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _Id;
		
		private string _UserId;
		
		private string _Title;
		
		private string _UserName;
		
		private string _Email;
		
		private string _Password;
		
		private string _Password1;
		
		private string _Address;
		
		private string _DOB;
		
		private string _AdvPayment;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnIdChanging(int value);
    partial void OnIdChanged();
    partial void OnUserIdChanging(string value);
    partial void OnUserIdChanged();
    partial void OnTitleChanging(string value);
    partial void OnTitleChanged();
    partial void OnUserNameChanging(string value);
    partial void OnUserNameChanged();
    partial void OnEmailChanging(string value);
    partial void OnEmailChanged();
    partial void OnPasswordChanging(string value);
    partial void OnPasswordChanged();
    partial void OnPassword1Changing(string value);
    partial void OnPassword1Changed();
    partial void OnAddressChanging(string value);
    partial void OnAddressChanged();
    partial void OnDOBChanging(string value);
    partial void OnDOBChanged();
    partial void OnAdvPaymentChanging(string value);
    partial void OnAdvPaymentChanged();
    #endregion
		
		public User()
		{
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Id", AutoSync=AutoSync.OnInsert, DbType="Int NOT NULL IDENTITY", IsPrimaryKey=true, IsDbGenerated=true)]
		public int Id
		{
			get
			{
				return this._Id;
			}
			set
			{
				if ((this._Id != value))
				{
					this.OnIdChanging(value);
					this.SendPropertyChanging();
					this._Id = value;
					this.SendPropertyChanged("Id");
					this.OnIdChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_UserId", DbType="VarChar(40) NOT NULL", CanBeNull=false)]
		public string UserId
		{
			get
			{
				return this._UserId;
			}
			set
			{
				if ((this._UserId != value))
				{
					this.OnUserIdChanging(value);
					this.SendPropertyChanging();
					this._UserId = value;
					this.SendPropertyChanged("UserId");
					this.OnUserIdChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Title", DbType="VarChar(10)")]
		public string Title
		{
			get
			{
				return this._Title;
			}
			set
			{
				if ((this._Title != value))
				{
					this.OnTitleChanging(value);
					this.SendPropertyChanging();
					this._Title = value;
					this.SendPropertyChanged("Title");
					this.OnTitleChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_UserName", DbType="VarChar(50)")]
		public string UserName
		{
			get
			{
				return this._UserName;
			}
			set
			{
				if ((this._UserName != value))
				{
					this.OnUserNameChanging(value);
					this.SendPropertyChanging();
					this._UserName = value;
					this.SendPropertyChanged("UserName");
					this.OnUserNameChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Email", DbType="VarChar(60)")]
		public string Email
		{
			get
			{
				return this._Email;
			}
			set
			{
				if ((this._Email != value))
				{
					this.OnEmailChanging(value);
					this.SendPropertyChanging();
					this._Email = value;
					this.SendPropertyChanged("Email");
					this.OnEmailChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Password", DbType="VarChar(70)")]
		public string Password
		{
			get
			{
				return this._Password;
			}
			set
			{
				if ((this._Password != value))
				{
					this.OnPasswordChanging(value);
					this.SendPropertyChanging();
					this._Password = value;
					this.SendPropertyChanged("Password");
					this.OnPasswordChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Password1", DbType="VarChar(70)")]
		public string Password1
		{
			get
			{
				return this._Password1;
			}
			set
			{
				if ((this._Password1 != value))
				{
					this.OnPassword1Changing(value);
					this.SendPropertyChanging();
					this._Password1 = value;
					this.SendPropertyChanged("Password1");
					this.OnPassword1Changed();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Address", DbType="VarChar(60)")]
		public string Address
		{
			get
			{
				return this._Address;
			}
			set
			{
				if ((this._Address != value))
				{
					this.OnAddressChanging(value);
					this.SendPropertyChanging();
					this._Address = value;
					this.SendPropertyChanged("Address");
					this.OnAddressChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_DOB", DbType="VarChar(40)")]
		public string DOB
		{
			get
			{
				return this._DOB;
			}
			set
			{
				if ((this._DOB != value))
				{
					this.OnDOBChanging(value);
					this.SendPropertyChanging();
					this._DOB = value;
					this.SendPropertyChanged("DOB");
					this.OnDOBChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_AdvPayment", DbType="VarChar(50)")]
		public string AdvPayment
		{
			get
			{
				return this._AdvPayment;
			}
			set
			{
				if ((this._AdvPayment != value))
				{
					this.OnAdvPaymentChanging(value);
					this.SendPropertyChanging();
					this._AdvPayment = value;
					this.SendPropertyChanged("AdvPayment");
					this.OnAdvPaymentChanged();
				}
			}
		}
		
		public event PropertyChangingEventHandler PropertyChanging;
		
		public event PropertyChangedEventHandler PropertyChanged;
		
		protected virtual void SendPropertyChanging()
		{
			if ((this.PropertyChanging != null))
			{
				this.PropertyChanging(this, emptyChangingEventArgs);
			}
		}
		
		protected virtual void SendPropertyChanged(String propertyName)
		{
			if ((this.PropertyChanged != null))
			{
				this.PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.BookSelf")]
	public partial class BookSelf : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _Id;
		
		private string _UserId;
		
		private string _BookName;
		
		private string _BackDate;
		
		private string _DaysOverDue;
		
		private string _Fine;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnIdChanging(int value);
    partial void OnIdChanged();
    partial void OnUserIdChanging(string value);
    partial void OnUserIdChanged();
    partial void OnBookNameChanging(string value);
    partial void OnBookNameChanged();
    partial void OnBackDateChanging(string value);
    partial void OnBackDateChanged();
    partial void OnDaysOverDueChanging(string value);
    partial void OnDaysOverDueChanged();
    partial void OnFineChanging(string value);
    partial void OnFineChanged();
    #endregion
		
		public BookSelf()
		{
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Id", AutoSync=AutoSync.OnInsert, DbType="Int NOT NULL IDENTITY", IsPrimaryKey=true, IsDbGenerated=true)]
		public int Id
		{
			get
			{
				return this._Id;
			}
			set
			{
				if ((this._Id != value))
				{
					this.OnIdChanging(value);
					this.SendPropertyChanging();
					this._Id = value;
					this.SendPropertyChanged("Id");
					this.OnIdChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_UserId", DbType="VarChar(50)")]
		public string UserId
		{
			get
			{
				return this._UserId;
			}
			set
			{
				if ((this._UserId != value))
				{
					this.OnUserIdChanging(value);
					this.SendPropertyChanging();
					this._UserId = value;
					this.SendPropertyChanged("UserId");
					this.OnUserIdChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_BookName", DbType="VarChar(60)")]
		public string BookName
		{
			get
			{
				return this._BookName;
			}
			set
			{
				if ((this._BookName != value))
				{
					this.OnBookNameChanging(value);
					this.SendPropertyChanging();
					this._BookName = value;
					this.SendPropertyChanged("BookName");
					this.OnBookNameChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_BackDate", DbType="VarChar(50)")]
		public string BackDate
		{
			get
			{
				return this._BackDate;
			}
			set
			{
				if ((this._BackDate != value))
				{
					this.OnBackDateChanging(value);
					this.SendPropertyChanging();
					this._BackDate = value;
					this.SendPropertyChanged("BackDate");
					this.OnBackDateChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_DaysOverDue", DbType="VarChar(60)")]
		public string DaysOverDue
		{
			get
			{
				return this._DaysOverDue;
			}
			set
			{
				if ((this._DaysOverDue != value))
				{
					this.OnDaysOverDueChanging(value);
					this.SendPropertyChanging();
					this._DaysOverDue = value;
					this.SendPropertyChanged("DaysOverDue");
					this.OnDaysOverDueChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Fine", DbType="VarChar(90)")]
		public string Fine
		{
			get
			{
				return this._Fine;
			}
			set
			{
				if ((this._Fine != value))
				{
					this.OnFineChanging(value);
					this.SendPropertyChanging();
					this._Fine = value;
					this.SendPropertyChanged("Fine");
					this.OnFineChanged();
				}
			}
		}
		
		public event PropertyChangingEventHandler PropertyChanging;
		
		public event PropertyChangedEventHandler PropertyChanged;
		
		protected virtual void SendPropertyChanging()
		{
			if ((this.PropertyChanging != null))
			{
				this.PropertyChanging(this, emptyChangingEventArgs);
			}
		}
		
		protected virtual void SendPropertyChanged(String propertyName)
		{
			if ((this.PropertyChanged != null))
			{
				this.PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.BrowseBook")]
	public partial class BrowseBook : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _Id;
		
		private string _BookName;
		
		private string _BookId;
		
		private string _Author;
		
		private string _Catagory;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnIdChanging(int value);
    partial void OnIdChanged();
    partial void OnBookNameChanging(string value);
    partial void OnBookNameChanged();
    partial void OnBookIdChanging(string value);
    partial void OnBookIdChanged();
    partial void OnAuthorChanging(string value);
    partial void OnAuthorChanged();
    partial void OnCatagoryChanging(string value);
    partial void OnCatagoryChanged();
    #endregion
		
		public BrowseBook()
		{
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Id", AutoSync=AutoSync.OnInsert, DbType="Int NOT NULL IDENTITY", IsPrimaryKey=true, IsDbGenerated=true)]
		public int Id
		{
			get
			{
				return this._Id;
			}
			set
			{
				if ((this._Id != value))
				{
					this.OnIdChanging(value);
					this.SendPropertyChanging();
					this._Id = value;
					this.SendPropertyChanged("Id");
					this.OnIdChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_BookName", DbType="VarChar(40) NOT NULL", CanBeNull=false)]
		public string BookName
		{
			get
			{
				return this._BookName;
			}
			set
			{
				if ((this._BookName != value))
				{
					this.OnBookNameChanging(value);
					this.SendPropertyChanging();
					this._BookName = value;
					this.SendPropertyChanged("BookName");
					this.OnBookNameChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_BookId", DbType="VarChar(50) NOT NULL", CanBeNull=false)]
		public string BookId
		{
			get
			{
				return this._BookId;
			}
			set
			{
				if ((this._BookId != value))
				{
					this.OnBookIdChanging(value);
					this.SendPropertyChanging();
					this._BookId = value;
					this.SendPropertyChanged("BookId");
					this.OnBookIdChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Author", DbType="VarChar(60) NOT NULL", CanBeNull=false)]
		public string Author
		{
			get
			{
				return this._Author;
			}
			set
			{
				if ((this._Author != value))
				{
					this.OnAuthorChanging(value);
					this.SendPropertyChanging();
					this._Author = value;
					this.SendPropertyChanged("Author");
					this.OnAuthorChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Catagory", DbType="VarChar(60) NOT NULL", CanBeNull=false)]
		public string Catagory
		{
			get
			{
				return this._Catagory;
			}
			set
			{
				if ((this._Catagory != value))
				{
					this.OnCatagoryChanging(value);
					this.SendPropertyChanging();
					this._Catagory = value;
					this.SendPropertyChanged("Catagory");
					this.OnCatagoryChanged();
				}
			}
		}
		
		public event PropertyChangingEventHandler PropertyChanging;
		
		public event PropertyChangedEventHandler PropertyChanged;
		
		protected virtual void SendPropertyChanging()
		{
			if ((this.PropertyChanging != null))
			{
				this.PropertyChanging(this, emptyChangingEventArgs);
			}
		}
		
		protected virtual void SendPropertyChanged(String propertyName)
		{
			if ((this.PropertyChanged != null))
			{
				this.PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
			}
		}
	}
}
#pragma warning restore 1591
