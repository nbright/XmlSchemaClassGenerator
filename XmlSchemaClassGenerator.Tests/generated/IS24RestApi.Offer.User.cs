//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.34003
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

// This code was generated by XmlSchemaClassGenerator version 0.1.5142.33774.
namespace IS24RestApi.Offer.User
{
    using System.Collections.ObjectModel;
    using System.Xml.Serialization;
    
    
    /// <summary>
    /// </summary>
    [System.SerializableAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("XmlSchemaClassGenerator", "0.1.5142.33774")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute("offerUser", Namespace="http://rest.immobilienscout24.de/schema/offer/user/1.0")]
    [System.Xml.Serialization.XmlRootAttribute("offerUser", Namespace="http://rest.immobilienscout24.de/schema/offer/user/1.0")]
    public partial class OfferUser
    {
        
        /// <summary>
        /// </summary>
        [System.Xml.Serialization.XmlElementAttribute("customer", Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public Customer Customer { get; set; }
    }
    
    /// <summary>
    /// </summary>
    [System.SerializableAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("XmlSchemaClassGenerator", "0.1.5142.33774")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute("customer", Namespace="http://rest.immobilienscout24.de/schema/offer/user/1.0")]
    public partial class Customer
    {
        
        /// <summary>
        /// </summary>
        [System.Xml.Serialization.XmlArrayAttribute("contractContactDetails", Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        [System.Xml.Serialization.XmlArrayItemAttribute("companyName", Form=System.Xml.Schema.XmlSchemaForm.Unqualified, DataType="string")]
        public System.Collections.ObjectModel.Collection<string> ContractContactDetails { get; private set; }
        
        /// <summary>
        /// <para xml:lang="de">Ruft einen Wert ab, der angibt, ob die ContractContactDetails-Collection leer ist.</para>
        /// <para xml:lang="en">Gets a value indicating whether the ContractContactDetails collection is empty.</para>
        /// </summary>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool ContractContactDetailsSpecified
        {
            get
            {
                return (this.ContractContactDetails.Count != 0);
            }
        }
        
        /// <summary>
        /// <para xml:lang="de">Initialisiert eine neue Instanz der <see cref="Customer" /> Klasse.</para>
        /// <para xml:lang="en">Initializes a new instance of the <see cref="Customer" /> class.</para>
        /// </summary>
        public Customer()
        {
            this.ContractContactDetails = new System.Collections.ObjectModel.Collection<string>();
        }
        
        /// <summary>
        /// </summary>
        [System.Xml.Serialization.XmlElementAttribute("professional", Form=System.Xml.Schema.XmlSchemaForm.Unqualified, DataType="boolean")]
        public bool Professional { get; set; }
    }
    
    /// <summary>
    /// </summary>
    [System.SerializableAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("XmlSchemaClassGenerator", "0.1.5142.33774")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute("contractContactDetails", Namespace="http://rest.immobilienscout24.de/schema/offer/user/1.0")]
    public partial class ContractContactDetails
    {
        
        /// <summary>
        /// </summary>
        [System.Xml.Serialization.XmlElementAttribute("companyName", Form=System.Xml.Schema.XmlSchemaForm.Unqualified, DataType="string")]
        public string CompanyName { get; set; }
    }
}
