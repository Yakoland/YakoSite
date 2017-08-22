﻿//------------------------------------------------------------------------------
// <auto-generated>
//    Este código se generó a partir de una plantilla.
//
//    Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//    Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------

using System;
using System.ComponentModel;
using System.Data.EntityClient;
using System.Data.Objects;
using System.Data.Objects.DataClasses;
using System.Linq;
using System.Runtime.Serialization;
using System.Xml.Serialization;

[assembly: EdmSchemaAttribute()]
namespace WebApplication4
{
    #region Contextos
    
    /// <summary>
    /// No hay documentación de metadatos disponible.
    /// </summary>
    public partial class NorthwindEntities : ObjectContext
    {
        #region Constructores
    
        /// <summary>
        /// Inicializa un nuevo objeto NorthwindEntities usando la cadena de conexión encontrada en la sección 'NorthwindEntities' del archivo de configuración de la aplicación.
        /// </summary>
        public NorthwindEntities() : base("name=NorthwindEntities", "NorthwindEntities")
        {
            this.ContextOptions.LazyLoadingEnabled = true;
            OnContextCreated();
        }
    
        /// <summary>
        /// Inicializar un nuevo objeto NorthwindEntities.
        /// </summary>
        public NorthwindEntities(string connectionString) : base(connectionString, "NorthwindEntities")
        {
            this.ContextOptions.LazyLoadingEnabled = true;
            OnContextCreated();
        }
    
        /// <summary>
        /// Inicializar un nuevo objeto NorthwindEntities.
        /// </summary>
        public NorthwindEntities(EntityConnection connection) : base(connection, "NorthwindEntities")
        {
            this.ContextOptions.LazyLoadingEnabled = true;
            OnContextCreated();
        }
    
        #endregion
    
        #region Métodos parciales
    
        partial void OnContextCreated();
    
        #endregion
    
        #region Propiedades de ObjectSet
    
        /// <summary>
        /// No hay documentación de metadatos disponible.
        /// </summary>
        public ObjectSet<Customers> Customers
        {
            get
            {
                if ((_Customers == null))
                {
                    _Customers = base.CreateObjectSet<Customers>("Customers");
                }
                return _Customers;
            }
        }
        private ObjectSet<Customers> _Customers;

        #endregion

        #region Métodos AddTo
    
        /// <summary>
        /// Método desusado para agregar un nuevo objeto al EntitySet Customers. Considere la posibilidad de usar el método .Add de la propiedad ObjectSet&lt;T&gt; asociada.
        /// </summary>
        public void AddToCustomers(Customers customers)
        {
            base.AddObject("Customers", customers);
        }

        #endregion

    }

    #endregion

    #region Entidades
    
    /// <summary>
    /// No hay documentación de metadatos disponible.
    /// </summary>
    [EdmEntityTypeAttribute(NamespaceName="NorthwindModel", Name="Customers")]
    [Serializable()]
    [DataContractAttribute(IsReference=true)]
    public partial class Customers : EntityObject
    {
        #region Método de generador
    
        /// <summary>
        /// Crear un nuevo objeto Customers.
        /// </summary>
        /// <param name="customerID">Valor inicial de la propiedad CustomerID.</param>
        /// <param name="companyName">Valor inicial de la propiedad CompanyName.</param>
        public static Customers CreateCustomers(global::System.String customerID, global::System.String companyName)
        {
            Customers customers = new Customers();
            customers.CustomerID = customerID;
            customers.CompanyName = companyName;
            return customers;
        }

        #endregion

        #region Propiedades primitivas
    
        /// <summary>
        /// No hay documentación de metadatos disponible.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=true, IsNullable=false)]
        [DataMemberAttribute()]
        public global::System.String CustomerID
        {
            get
            {
                return _CustomerID;
            }
            set
            {
                if (_CustomerID != value)
                {
                    OnCustomerIDChanging(value);
                    ReportPropertyChanging("CustomerID");
                    _CustomerID = StructuralObject.SetValidValue(value, false);
                    ReportPropertyChanged("CustomerID");
                    OnCustomerIDChanged();
                }
            }
        }
        private global::System.String _CustomerID;
        partial void OnCustomerIDChanging(global::System.String value);
        partial void OnCustomerIDChanged();
    
        /// <summary>
        /// No hay documentación de metadatos disponible.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=false)]
        [DataMemberAttribute()]
        public global::System.String CompanyName
        {
            get
            {
                return _CompanyName;
            }
            set
            {
                OnCompanyNameChanging(value);
                ReportPropertyChanging("CompanyName");
                _CompanyName = StructuralObject.SetValidValue(value, false);
                ReportPropertyChanged("CompanyName");
                OnCompanyNameChanged();
            }
        }
        private global::System.String _CompanyName;
        partial void OnCompanyNameChanging(global::System.String value);
        partial void OnCompanyNameChanged();
    
        /// <summary>
        /// No hay documentación de metadatos disponible.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=true)]
        [DataMemberAttribute()]
        public global::System.String ContactName
        {
            get
            {
                return _ContactName;
            }
            set
            {
                OnContactNameChanging(value);
                ReportPropertyChanging("ContactName");
                _ContactName = StructuralObject.SetValidValue(value, true);
                ReportPropertyChanged("ContactName");
                OnContactNameChanged();
            }
        }
        private global::System.String _ContactName;
        partial void OnContactNameChanging(global::System.String value);
        partial void OnContactNameChanged();
    
        /// <summary>
        /// No hay documentación de metadatos disponible.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=true)]
        [DataMemberAttribute()]
        public global::System.String ContactTitle
        {
            get
            {
                return _ContactTitle;
            }
            set
            {
                OnContactTitleChanging(value);
                ReportPropertyChanging("ContactTitle");
                _ContactTitle = StructuralObject.SetValidValue(value, true);
                ReportPropertyChanged("ContactTitle");
                OnContactTitleChanged();
            }
        }
        private global::System.String _ContactTitle;
        partial void OnContactTitleChanging(global::System.String value);
        partial void OnContactTitleChanged();
    
        /// <summary>
        /// No hay documentación de metadatos disponible.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=true)]
        [DataMemberAttribute()]
        public global::System.String Address
        {
            get
            {
                return _Address;
            }
            set
            {
                OnAddressChanging(value);
                ReportPropertyChanging("Address");
                _Address = StructuralObject.SetValidValue(value, true);
                ReportPropertyChanged("Address");
                OnAddressChanged();
            }
        }
        private global::System.String _Address;
        partial void OnAddressChanging(global::System.String value);
        partial void OnAddressChanged();
    
        /// <summary>
        /// No hay documentación de metadatos disponible.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=true)]
        [DataMemberAttribute()]
        public global::System.String City
        {
            get
            {
                return _City;
            }
            set
            {
                OnCityChanging(value);
                ReportPropertyChanging("City");
                _City = StructuralObject.SetValidValue(value, true);
                ReportPropertyChanged("City");
                OnCityChanged();
            }
        }
        private global::System.String _City;
        partial void OnCityChanging(global::System.String value);
        partial void OnCityChanged();
    
        /// <summary>
        /// No hay documentación de metadatos disponible.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=true)]
        [DataMemberAttribute()]
        public global::System.String Region
        {
            get
            {
                return _Region;
            }
            set
            {
                OnRegionChanging(value);
                ReportPropertyChanging("Region");
                _Region = StructuralObject.SetValidValue(value, true);
                ReportPropertyChanged("Region");
                OnRegionChanged();
            }
        }
        private global::System.String _Region;
        partial void OnRegionChanging(global::System.String value);
        partial void OnRegionChanged();
    
        /// <summary>
        /// No hay documentación de metadatos disponible.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=true)]
        [DataMemberAttribute()]
        public global::System.String PostalCode
        {
            get
            {
                return _PostalCode;
            }
            set
            {
                OnPostalCodeChanging(value);
                ReportPropertyChanging("PostalCode");
                _PostalCode = StructuralObject.SetValidValue(value, true);
                ReportPropertyChanged("PostalCode");
                OnPostalCodeChanged();
            }
        }
        private global::System.String _PostalCode;
        partial void OnPostalCodeChanging(global::System.String value);
        partial void OnPostalCodeChanged();
    
        /// <summary>
        /// No hay documentación de metadatos disponible.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=true)]
        [DataMemberAttribute()]
        public global::System.String Country
        {
            get
            {
                return _Country;
            }
            set
            {
                OnCountryChanging(value);
                ReportPropertyChanging("Country");
                _Country = StructuralObject.SetValidValue(value, true);
                ReportPropertyChanged("Country");
                OnCountryChanged();
            }
        }
        private global::System.String _Country;
        partial void OnCountryChanging(global::System.String value);
        partial void OnCountryChanged();
    
        /// <summary>
        /// No hay documentación de metadatos disponible.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=true)]
        [DataMemberAttribute()]
        public global::System.String Phone
        {
            get
            {
                return _Phone;
            }
            set
            {
                OnPhoneChanging(value);
                ReportPropertyChanging("Phone");
                _Phone = StructuralObject.SetValidValue(value, true);
                ReportPropertyChanged("Phone");
                OnPhoneChanged();
            }
        }
        private global::System.String _Phone;
        partial void OnPhoneChanging(global::System.String value);
        partial void OnPhoneChanged();
    
        /// <summary>
        /// No hay documentación de metadatos disponible.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=true)]
        [DataMemberAttribute()]
        public global::System.String Fax
        {
            get
            {
                return _Fax;
            }
            set
            {
                OnFaxChanging(value);
                ReportPropertyChanging("Fax");
                _Fax = StructuralObject.SetValidValue(value, true);
                ReportPropertyChanged("Fax");
                OnFaxChanged();
            }
        }
        private global::System.String _Fax;
        partial void OnFaxChanging(global::System.String value);
        partial void OnFaxChanged();

        #endregion

    
    }

    #endregion

    
}