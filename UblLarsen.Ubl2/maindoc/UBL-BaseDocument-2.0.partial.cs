using System.Xml.Serialization;
using System.Xml;
using System.Linq;

namespace UblLarsen.Ubl2
{
    public abstract partial class UblBaseDocumentType
    {
        /// <summary>
        /// Variable holding the default UBL version given to all documents in their base class constructor. Default is "2.0". 
        /// This library is Generated for "2.0" only, so don't change it.
        /// </summary>
        public static string GlbUblVersionID = "2.0";

        /// <summary>
        /// Default value given to all UBL documents in their base class constructor. Default is null. 
        /// UBL Larsen can't guess what should go in here. Depends on region/business etc.
        /// </summary>
        public static string GlbCustomizationID = null;
        
        /// <summary>
        /// Default value given to all UBL documents in their base constructor. Default is null. Consult UBL documentation.
        /// Example: Basic billing is "urn:www.nesubl.eu:profiles:profile5:ver1.0"
        /// More samples at http://www.oioubl.info/Codelists/en/urn_oioubl_id_profileid-1.1.html
        /// </summary>
        public static string GlbProfileID = null;

        /// <summary>
        /// UBL Base class constructor. Gets called by all UBL maindoc's when they are constructed.
        /// </summary>
        public UblBaseDocumentType()
        {
            this.UBLVersionID = GlbUblVersionID;
            this.CustomizationID = GlbCustomizationID;
            this.ProfileID = GlbProfileID;
        }

        /// <summary>
        /// Takes care of namespace prefix in saved xml documents
        /// </summary>
        [System.Xml.Serialization.XmlNamespaceDeclarations()]
        public XmlSerializerNamespaces Xmlns
        {
            get
            {
                return new XmlSerializerNamespaces(
                    new XmlQualifiedName[] 
                        {
                            new XmlQualifiedName("cac", "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2"),
                            new XmlQualifiedName("cbc", "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2"),
                            new XmlQualifiedName("udt", "urn:un:unece:uncefact:data:specification:UnqualifiedDataTypesSchemaModule:2"),
                            new XmlQualifiedName("ext", "urn:oasis:names:specification:ubl:schema:xsd:CommonExtensionComponents-2"),
                            new XmlQualifiedName("qdt", "urn:oasis:names:specification:ubl:schema:xsd:QualifiedDatatypes-2"),
                            new XmlQualifiedName("", (this.GetType().GetCustomAttributes(typeof(XmlTypeAttribute), false).FirstOrDefault() as XmlTypeAttribute).Namespace)
                        });
            }
            set{}
        }
    }
}
