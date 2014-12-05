// ------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
//
//     http://ubllarsen.codeplex.com/
//
// </auto-generated>
//------------------------------------------------------------------------------
namespace UblLarsen.Ubl2
{
    using UblLarsen.Ubl2.Cac;
    
    
    /// <summary>
    ///  The document used to specify the status of Orders, Billing, and Payment. This document is a Statement of Account and not intended as a summary Invoice
    /// </summary>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("ublxsd", "2.0.0.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:oasis:names:specification:ubl:schema:xsd:Statement-2")]
    [System.Xml.Serialization.XmlRootAttribute("Statement", Namespace="urn:oasis:names:specification:ubl:schema:xsd:Statement-2", IsNullable=false)]
    public partial class StatementType : UblBaseDocumentType
    {
        
        private Udt.IdentifierType idField;
        
        private Udt.IndicatorType copyIndicatorField;
        
        private Udt.IdentifierType uUIDField;
        
        private Udt.DateType issueDateField;
        
        private Udt.TimeType issueTimeField;
        
        private Udt.TextType[] noteField;
        
        private Qdt.CurrencyCodeType documentCurrencyCodeField;
        
        private Udt.AmountType totalDebitAmountField;
        
        private Udt.AmountType totalCreditAmountField;
        
        private Udt.AmountType totalBalanceAmountField;
        
        private Udt.NumericType lineCountNumericField;
        
        private PeriodType statementPeriodField;
        
        private DocumentReferenceType[] additionalDocumentReferenceField;
        
        private SignatureType[] signatureField;
        
        private SupplierPartyType accountingSupplierPartyField;
        
        private CustomerPartyType accountingCustomerPartyField;
        
        private CustomerPartyType buyerCustomerPartyField;
        
        private SupplierPartyType sellerSupplierPartyField;
        
        private CustomerPartyType originatorCustomerPartyField;
        
        private PartyType payeePartyField;
        
        private PaymentMeansType paymentMeansField;
        
        private PaymentTermsType[] paymentTermsField;
        
        private AllowanceChargeType[] allowanceChargeField;
        
        private TaxTotalType[] taxTotalField;
        
        private StatementLineType[] statementLineField;
        
        /// <summary>
        ///  An identifier for the Statement.
        /// </summary>
        [System.Xml.Serialization.XmlElementAttribute(Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public Udt.IdentifierType ID
        {
            get
            {
                return this.idField;
            }
            set
            {
                this.idField = value;
            }
        }
        
        /// <summary>
        ///  Indicates whether the Statement is a copy (true) or not (false).
        /// </summary>
        [System.Xml.Serialization.XmlElementAttribute(Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public Udt.IndicatorType CopyIndicator
        {
            get
            {
                return this.copyIndicatorField;
            }
            set
            {
                this.copyIndicatorField = value;
            }
        }
        
        /// <summary>
        ///  A universally unique identifier for an instance of this ABIE.
        /// </summary>
        [System.Xml.Serialization.XmlElementAttribute(Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public Udt.IdentifierType UUID
        {
            get
            {
                return this.uUIDField;
            }
            set
            {
                this.uUIDField = value;
            }
        }
        
        /// <summary>
        ///  The date assigned by the Creditor on which the Statement was issued.
        /// </summary>
        [System.Xml.Serialization.XmlElementAttribute(Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public Udt.DateType IssueDate
        {
            get
            {
                return this.issueDateField;
            }
            set
            {
                this.issueDateField = value;
            }
        }
        
        /// <summary>
        ///  The time assigned by the Creditor at which the Statement was issued.
        /// </summary>
        [System.Xml.Serialization.XmlElementAttribute(Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public Udt.TimeType IssueTime
        {
            get
            {
                return this.issueTimeField;
            }
            set
            {
                this.issueTimeField = value;
            }
        }
        
        /// <summary>
        ///  Free-form text applying to the Statement. This element may contain notes or any other similar information that is not contained explicitly in another structure.
        /// </summary>
        [System.Xml.Serialization.XmlElementAttribute("Note", Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public Udt.TextType[] Note
        {
            get
            {
                return this.noteField;
            }
            set
            {
                this.noteField = value;
            }
        }
        
        /// <summary>
        ///  The default currency for the Statement.
        /// </summary>
        [System.Xml.Serialization.XmlElementAttribute(Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public Qdt.CurrencyCodeType DocumentCurrencyCode
        {
            get
            {
                return this.documentCurrencyCodeField;
            }
            set
            {
                this.documentCurrencyCodeField = value;
            }
        }
        
        /// <summary>
        ///  The total of all debit amounts for the Statement.
        /// </summary>
        [System.Xml.Serialization.XmlElementAttribute(Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public Udt.AmountType TotalDebitAmount
        {
            get
            {
                return this.totalDebitAmountField;
            }
            set
            {
                this.totalDebitAmountField = value;
            }
        }
        
        /// <summary>
        ///  The total of all credit amounts for the Statement.
        /// </summary>
        [System.Xml.Serialization.XmlElementAttribute(Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public Udt.AmountType TotalCreditAmount
        {
            get
            {
                return this.totalCreditAmountField;
            }
            set
            {
                this.totalCreditAmountField = value;
            }
        }
        
        /// <summary>
        ///  The total amount for the Statement.
        /// </summary>
        [System.Xml.Serialization.XmlElementAttribute(Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public Udt.AmountType TotalBalanceAmount
        {
            get
            {
                return this.totalBalanceAmountField;
            }
            set
            {
                this.totalBalanceAmountField = value;
            }
        }
        
        /// <summary>
        ///  The number of lines in the document.
        /// </summary>
        [System.Xml.Serialization.XmlElementAttribute(Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public Udt.NumericType LineCountNumeric
        {
            get
            {
                return this.lineCountNumericField;
            }
            set
            {
                this.lineCountNumericField = value;
            }
        }
        
        /// <summary>
        ///  An association to period(s) to which the Statement applies.
        /// </summary>
        [System.Xml.Serialization.XmlElementAttribute(Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2")]
        public PeriodType StatementPeriod
        {
            get
            {
                return this.statementPeriodField;
            }
            set
            {
                this.statementPeriodField = value;
            }
        }
        
        /// <summary>
        ///  An associative reference to Additional Document.
        /// </summary>
        [System.Xml.Serialization.XmlElementAttribute("AdditionalDocumentReference", Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2")]
        public DocumentReferenceType[] AdditionalDocumentReference
        {
            get
            {
                return this.additionalDocumentReferenceField;
            }
            set
            {
                this.additionalDocumentReferenceField = value;
            }
        }
        
        /// <summary>
        ///  An association to Signature.
        /// </summary>
        [System.Xml.Serialization.XmlElementAttribute("Signature", Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2")]
        public SignatureType[] Signature
        {
            get
            {
                return this.signatureField;
            }
            set
            {
                this.signatureField = value;
            }
        }
        
        /// <summary>
        ///  An association to the Accounting Supplier Party.
        /// </summary>
        [System.Xml.Serialization.XmlElementAttribute(Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2")]
        public SupplierPartyType AccountingSupplierParty
        {
            get
            {
                return this.accountingSupplierPartyField;
            }
            set
            {
                this.accountingSupplierPartyField = value;
            }
        }
        
        /// <summary>
        ///  An association to the Accounting Customer Party.
        /// </summary>
        [System.Xml.Serialization.XmlElementAttribute(Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2")]
        public CustomerPartyType AccountingCustomerParty
        {
            get
            {
                return this.accountingCustomerPartyField;
            }
            set
            {
                this.accountingCustomerPartyField = value;
            }
        }
        
        /// <summary>
        ///  An association to the Buyer.
        /// </summary>
        [System.Xml.Serialization.XmlElementAttribute(Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2")]
        public CustomerPartyType BuyerCustomerParty
        {
            get
            {
                return this.buyerCustomerPartyField;
            }
            set
            {
                this.buyerCustomerPartyField = value;
            }
        }
        
        /// <summary>
        ///  An association to the Seller.
        /// </summary>
        [System.Xml.Serialization.XmlElementAttribute(Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2")]
        public SupplierPartyType SellerSupplierParty
        {
            get
            {
                return this.sellerSupplierPartyField;
            }
            set
            {
                this.sellerSupplierPartyField = value;
            }
        }
        
        /// <summary>
        ///  An association to the Originator.
        /// </summary>
        [System.Xml.Serialization.XmlElementAttribute(Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2")]
        public CustomerPartyType OriginatorCustomerParty
        {
            get
            {
                return this.originatorCustomerPartyField;
            }
            set
            {
                this.originatorCustomerPartyField = value;
            }
        }
        
        /// <summary>
        ///  An association to the Payee.
        /// </summary>
        [System.Xml.Serialization.XmlElementAttribute(Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2")]
        public PartyType PayeeParty
        {
            get
            {
                return this.payeePartyField;
            }
            set
            {
                this.payeePartyField = value;
            }
        }
        
        /// <summary>
        ///  An association to Payment Means.
        /// </summary>
        [System.Xml.Serialization.XmlElementAttribute(Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2")]
        public PaymentMeansType PaymentMeans
        {
            get
            {
                return this.paymentMeansField;
            }
            set
            {
                this.paymentMeansField = value;
            }
        }
        
        /// <summary>
        ///  An association to Payment Terms.
        /// </summary>
        [System.Xml.Serialization.XmlElementAttribute("PaymentTerms", Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2")]
        public PaymentTermsType[] PaymentTerms
        {
            get
            {
                return this.paymentTermsField;
            }
            set
            {
                this.paymentTermsField = value;
            }
        }
        
        /// <summary>
        ///  An association to Allowances and Charges that apply to the Statement period as a whole.
        /// </summary>
        [System.Xml.Serialization.XmlElementAttribute("AllowanceCharge", Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2")]
        public AllowanceChargeType[] AllowanceCharge
        {
            get
            {
                return this.allowanceChargeField;
            }
            set
            {
                this.allowanceChargeField = value;
            }
        }
        
        /// <summary>
        ///  An association with summary information for particular taxes.
        /// </summary>
        [System.Xml.Serialization.XmlElementAttribute("TaxTotal", Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2")]
        public TaxTotalType[] TaxTotal
        {
            get
            {
                return this.taxTotalField;
            }
            set
            {
                this.taxTotalField = value;
            }
        }
        
        /// <summary>
        ///  An association to one or more Statement Lines.
        /// </summary>
        [System.Xml.Serialization.XmlElementAttribute("StatementLine", Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2")]
        public StatementLineType[] StatementLine
        {
            get
            {
                return this.statementLineField;
            }
            set
            {
                this.statementLineField = value;
            }
        }
    }
}