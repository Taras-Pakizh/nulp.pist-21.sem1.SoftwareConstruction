﻿#pragma warning disable 1591
//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан программой.
//     Исполняемая версия:4.0.30319.42000
//
//     Изменения в этом файле могут привести к неправильной работе и будут потеряны в случае
//     повторной генерации кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace DataAccess
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
	
	
	[global::System.Data.Linq.Mapping.DatabaseAttribute(Name="db_labs")]
	public partial class ClientDataContext : System.Data.Linq.DataContext
	{
		
		private static System.Data.Linq.Mapping.MappingSource mappingSource = new AttributeMappingSource();
		
    #region Определения метода расширяемости
    partial void OnCreated();
    partial void Insertclient(client instance);
    partial void Updateclient(client instance);
    partial void Deleteclient(client instance);
    partial void Selectclient(client instance);
        #endregion

        public ClientDataContext() : 
				base(global::DataAccess.Properties.Settings.Default.db_labsConnectionString, mappingSource)
		{
			OnCreated();
		}
		
		public ClientDataContext(string connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public ClientDataContext(System.Data.IDbConnection connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public ClientDataContext(string connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public ClientDataContext(System.Data.IDbConnection connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public System.Data.Linq.Table<client> client
		{
			get
			{
				return this.GetTable<client>();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="labs.client")]
	public partial class client : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _id_client;
		
		private string _first_name;
		
		private string _last_name;
		
		private System.Nullable<System.DateTime> _registration_date;
		
		private string _phone;
		
    #region Определения метода расширяемости
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void Onid_clientChanging(int value);
    partial void Onid_clientChanged();
    partial void Onfirst_nameChanging(string value);
    partial void Onfirst_nameChanged();
    partial void Onlast_nameChanging(string value);
    partial void Onlast_nameChanged();
    partial void Onregistration_dateChanging(System.Nullable<System.DateTime> value);
    partial void Onregistration_dateChanged();
    partial void OnphoneChanging(string value);
    partial void OnphoneChanged();
    #endregion
		
		public client()
		{
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_id_client", AutoSync=AutoSync.OnInsert, DbType="Int NOT NULL IDENTITY", IsPrimaryKey=true, IsDbGenerated=true)]
		public int id_client
		{
			get
			{
				return this._id_client;
			}
			set
			{
				if ((this._id_client != value))
				{
					this.Onid_clientChanging(value);
					this.SendPropertyChanging();
					this._id_client = value;
					this.SendPropertyChanged("id_client");
					this.Onid_clientChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_first_name", DbType="VarChar(255) NOT NULL", CanBeNull=false)]
		public string first_name
		{
			get
			{
				return this._first_name;
			}
			set
			{
				if ((this._first_name != value))
				{
					this.Onfirst_nameChanging(value);
					this.SendPropertyChanging();
					this._first_name = value;
					this.SendPropertyChanged("first_name");
					this.Onfirst_nameChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_last_name", DbType="VarChar(255) NOT NULL", CanBeNull=false)]
		public string last_name
		{
			get
			{
				return this._last_name;
			}
			set
			{
				if ((this._last_name != value))
				{
					this.Onlast_nameChanging(value);
					this.SendPropertyChanging();
					this._last_name = value;
					this.SendPropertyChanged("last_name");
					this.Onlast_nameChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_registration_date", DbType="Date")]
		public System.Nullable<System.DateTime> registration_date
		{
			get
			{
				return this._registration_date;
			}
			set
			{
				if ((this._registration_date != value))
				{
					this.Onregistration_dateChanging(value);
					this.SendPropertyChanging();
					this._registration_date = value;
					this.SendPropertyChanged("registration_date");
					this.Onregistration_dateChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_phone", DbType="VarChar(255)")]
		public string phone
		{
			get
			{
				return this._phone;
			}
			set
			{
				if ((this._phone != value))
				{
					this.OnphoneChanging(value);
					this.SendPropertyChanging();
					this._phone = value;
					this.SendPropertyChanged("phone");
					this.OnphoneChanged();
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
