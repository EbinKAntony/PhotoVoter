﻿//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using System;
using System.Data.Objects;
using System.Data.Objects.DataClasses;
using System.Data.EntityClient;
using System.ComponentModel;
using System.Xml.Serialization;
using System.Runtime.Serialization;

[assembly: EdmSchemaAttribute()]

namespace PhotoVoterMvc.Models
{
    #region Contexts
    
    /// <summary>
    /// No Metadata Documentation available.
    /// </summary>
    public partial class F0001Entities2 : ObjectContext
    {
        #region Constructors
    
        /// <summary>
        /// Initializes a new F0001Entities2 object using the connection string found in the 'F0001Entities2' section of the application configuration file.
        /// </summary>
        public F0001Entities2() : base("name=F0001Entities2", "F0001Entities2")
        {
            this.ContextOptions.LazyLoadingEnabled = true;
            OnContextCreated();
        }
    
        /// <summary>
        /// Initialize a new F0001Entities2 object.
        /// </summary>
        public F0001Entities2(string connectionString) : base(connectionString, "F0001Entities2")
        {
            this.ContextOptions.LazyLoadingEnabled = true;
            OnContextCreated();
        }
    
        /// <summary>
        /// Initialize a new F0001Entities2 object.
        /// </summary>
        public F0001Entities2(EntityConnection connection) : base(connection, "F0001Entities2")
        {
            this.ContextOptions.LazyLoadingEnabled = true;
            OnContextCreated();
        }
    
        #endregion
    
        #region Partial Methods
    
        partial void OnContextCreated();
    
        #endregion
    
        #region Function Imports
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        /// <param name="productId">No Metadata Documentation available.</param>
        /// <param name="customerId">No Metadata Documentation available.</param>
        /// <param name="specVersion">No Metadata Documentation available.</param>
        /// <param name="quantity">No Metadata Documentation available.</param>
        /// <param name="postNo">No Metadata Documentation available.</param>
        /// <param name="articlePrice">No Metadata Documentation available.</param>
        /// <param name="articleGrossPrice">No Metadata Documentation available.</param>
        /// <param name="articleCustomerPrice">No Metadata Documentation available.</param>
        /// <param name="articleCustomerGrossPrice">No Metadata Documentation available.</param>
        /// <param name="articleDiscount1">No Metadata Documentation available.</param>
        /// <param name="articleDiscount2">No Metadata Documentation available.</param>
        /// <param name="articleDiscount3">No Metadata Documentation available.</param>
        /// <param name="articleDiscount4">No Metadata Documentation available.</param>
        /// <param name="articleDiscount5">No Metadata Documentation available.</param>
        /// <param name="articleVatPercent">No Metadata Documentation available.</param>
        /// <param name="articleCurrency">No Metadata Documentation available.</param>
        /// <param name="noUnit">No Metadata Documentation available.</param>
        public int GetPrice(global::System.String productId, Nullable<global::System.Int32> customerId, Nullable<global::System.Int32> specVersion, Nullable<global::System.Double> quantity, global::System.String postNo, ObjectParameter articlePrice, ObjectParameter articleGrossPrice, ObjectParameter articleCustomerPrice, ObjectParameter articleCustomerGrossPrice, ObjectParameter articleDiscount1, ObjectParameter articleDiscount2, ObjectParameter articleDiscount3, ObjectParameter articleDiscount4, ObjectParameter articleDiscount5, ObjectParameter articleVatPercent, ObjectParameter articleCurrency, ObjectParameter noUnit)
        {
            ObjectParameter productIdParameter;
            if (productId != null)
            {
                productIdParameter = new ObjectParameter("ProductId", productId);
            }
            else
            {
                productIdParameter = new ObjectParameter("ProductId", typeof(global::System.String));
            }
    
            ObjectParameter customerIdParameter;
            if (customerId.HasValue)
            {
                customerIdParameter = new ObjectParameter("CustomerId", customerId);
            }
            else
            {
                customerIdParameter = new ObjectParameter("CustomerId", typeof(global::System.Int32));
            }
    
            ObjectParameter specVersionParameter;
            if (specVersion.HasValue)
            {
                specVersionParameter = new ObjectParameter("SpecVersion", specVersion);
            }
            else
            {
                specVersionParameter = new ObjectParameter("SpecVersion", typeof(global::System.Int32));
            }
    
            ObjectParameter quantityParameter;
            if (quantity.HasValue)
            {
                quantityParameter = new ObjectParameter("Quantity", quantity);
            }
            else
            {
                quantityParameter = new ObjectParameter("Quantity", typeof(global::System.Double));
            }
    
            ObjectParameter postNoParameter;
            if (postNo != null)
            {
                postNoParameter = new ObjectParameter("PostNo", postNo);
            }
            else
            {
                postNoParameter = new ObjectParameter("PostNo", typeof(global::System.String));
            }
    
            return base.ExecuteFunction("GetPrice", productIdParameter, customerIdParameter, specVersionParameter, quantityParameter, postNoParameter, articlePrice, articleGrossPrice, articleCustomerPrice, articleCustomerGrossPrice, articleDiscount1, articleDiscount2, articleDiscount3, articleDiscount4, articleDiscount5, articleVatPercent, articleCurrency, noUnit);
        }

        #endregion
    }
    

    #endregion
    
    #region ComplexTypes
    
    /// <summary>
    /// No Metadata Documentation available.
    /// </summary>
    [EdmComplexTypeAttribute(NamespaceName="F0001Model", Name="ComplexType1")]
    [DataContractAttribute(IsReference=true)]
    [Serializable()]
    public partial class ComplexType1 : ComplexObject
    {
    }

    #endregion
    
}