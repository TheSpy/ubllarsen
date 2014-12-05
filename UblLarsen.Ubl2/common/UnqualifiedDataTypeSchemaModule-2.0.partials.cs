using System;

namespace UblLarsen.Ubl2.Udt
{
    public partial class AmountType
    {
        /// <summary>
        /// Thread local variable for default currency. Will be undefined if a context switch occurs. Thread handling is not part of the library.
        /// </summary>
        [ThreadStatic]
        public static string TlsDefaultCurrencyID;

        public AmountType()
        {
            this.currencyID = TlsDefaultCurrencyID;
        }
    }

    //
    // The following types got lost when Common Basic Components (Cac) was optimized away. 
    // Have added them here manually from an older version of the generated file.
    //
    
    /// <summary>
    ///  One calendar day according the Gregorian calendar.
    /// </summary>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("ublxsd", "2.0.0.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public partial class DateType
    {

        private System.DateTime valueField;

        public static implicit operator DateType(System.DateTime value)
        {
            return new DateType { Value = value };
        }

        [System.Xml.Serialization.XmlTextAttribute(DataType = "date")]
        public System.DateTime Value
        {
            get
            {
                return this.valueField;
            }
            set
            {
                this.valueField = value;
            }
        }
    }

    /// <summary>
    ///  The instance of time that occurs every day.
    /// </summary>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("ublxsd", "2.0.0.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public partial class TimeType
    {

        private System.DateTime valueField;

        public static implicit operator TimeType(System.DateTime value)
        {
            return new TimeType { Value = value };
        }

        [System.Xml.Serialization.XmlTextAttribute(DataType = "time")]
        public System.DateTime Value
        {
            get
            {
                return this.valueField;
            }
            set
            {
                this.valueField = value;
            }
        }
    }

    /// <summary>
    ///  A list of two mutually exclusive Boolean values that express the only possible states of a property.
    /// </summary>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("ublxsd", "2.0.0.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public partial class IndicatorType
    {

        private bool valueField;

        public static implicit operator IndicatorType(System.Boolean value)
        {
            return new IndicatorType { Value = value };
        }

        [System.Xml.Serialization.XmlTextAttribute()]
        public bool Value
        {
            get
            {
                return this.valueField;
            }
            set
            {
                this.valueField = value;
            }
        }
    }

    /// <summary>
    ///  Numeric information that is assigned or is determined by calculation, counting, or sequencing. It does not require a unit of quantity or unit of measure.
    /// </summary>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("ublxsd", "2.0.0.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public partial class NumericType
    {

        private decimal valueField;

        public static implicit operator NumericType(System.Decimal value)
        {
            return new NumericType { Value = value };
        }

        [System.Xml.Serialization.XmlTextAttribute()]
        public decimal Value
        {
            get
            {
                return this.valueField;
            }
            set
            {
                this.valueField = value;
            }
        }
    }

    /// <summary>
    ///  Numeric information that is assigned or is determined by calculation, counting, or sequencing. It does not require a unit of quantity or unit of measure.
    /// </summary>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("ublxsd", "2.0.0.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public partial class PercentType
    {

        private decimal valueField;

        public static implicit operator PercentType(System.Decimal value)
        {
            return new PercentType { Value = value };
        }

        [System.Xml.Serialization.XmlTextAttribute()]
        public decimal Value
        {
            get
            {
                return this.valueField;
            }
            set
            {
                this.valueField = value;
            }
        }
    }

    /// <summary>
    ///  Numeric information that is assigned or is determined by calculation, counting, or sequencing. It does not require a unit of quantity or unit of measuret.
    /// </summary>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("ublxsd", "2.0.0.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public partial class RateType
    {

        private decimal valueField;

        public static implicit operator RateType(System.Decimal value)
        {
            return new RateType { Value = value };
        }

        [System.Xml.Serialization.XmlTextAttribute()]
        public decimal Value
        {
            get
            {
                return this.valueField;
            }
            set
            {
                this.valueField = value;
            }
        }
    }
 
}
