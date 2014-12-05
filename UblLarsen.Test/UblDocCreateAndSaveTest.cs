using System;
using System.IO;
using System.Xml;
using System.Xml.Linq;
using System.Xml.Schema;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using UblLarsen.Ubl2;
using UblLarsen.Ubl2.Cac;
using UblLarsen.Ubl2.Udt;

namespace UblLarsen.Test
{


    /// <summary>
    ///This is a test class for InvoiceTypeTest and is intended
    ///to contain all InvoiceTypeTest Unit Tests
    ///</summary>
    [TestClass()]
    public class UblDocCreateAndSaveTest
    {


        private TestContext testContextInstance;

        /// <summary>
        ///Gets or sets the test context which provides
        ///information about and functionality for the current test run.
        ///</summary>
        public TestContext TestContext
        {
            get
            {
                return testContextInstance;
            }
            set
            {
                testContextInstance = value;
            }
        }

        #region Additional test attributes
        // 
        //You can use the following additional attributes as you write your tests:
        //
        //Use ClassInitialize to run code before running the first test in the class
        //[ClassInitialize()]
        //public static void MyClassInitialize(TestContext testContext)
        //{
        //}
        //
        //Use ClassCleanup to run code after all tests in a class have run
        //[ClassCleanup()]
        //public static void MyClassCleanup()
        //{
        //}
        //
        //Use TestInitialize to run code before running each test
        //[TestInitialize()]
        //public void MyTestInitialize()
        //{
        //}
        //
        //Use TestCleanup to run code after each test has run
        //[TestCleanup()]
        //public void MyTestCleanup()
        //{
        //}
        //
        #endregion

        /// <summary>
        /// Creating an Ubl document without implicit assignment operators is hard work
        /// .NET 3.0 constuructor object initializers makes it a bit easier. but.... 
        /// No one will make longwinded production code like this!
        /// This is how you would have coded an invoice if you generated the Ubl library with xsd.exe
        /// UBL Larsen is no longer xsd.exe compatible. A lot of classes have been optimized away. Hence, this test is only here as a comment for reference
        /// </summary>
/*        [TestMethod]
        public void SaveExplicitCreatedNorwegianInvoice()
        {
            //Ubl2.Udt.AmountType.TlsDefaultCurrencyID = "XXX";
            string sNok = "NOK";


            InvoiceType doc = new InvoiceType
            {
                UBLVersionID = new UBLVersionIDType { Value = "2.0" },
                CustomizationID = new CustomizationIDType { Value = "urn:www.cenbii.eu:transaction:biicoretrdm010:ver1.0" },
                ProfileID = new ProfileIDType { Value = "urn:www.cenbii.eu:profile:bii05:ver1.0" },
                ID = new IDType { Value = "123456" },
                IssueDate = new IssueDateType { Value = new DateTime(2009, 11, 12) },
                DocumentCurrencyCode = new DocumentCurrencyCodeType { Value = sNok },
                OrderReference = new OrderReferenceType { ID = new IDType { Value = "Prosjekt 13" } },
                ContractDocumentReference = new DocumentReferenceType[] { new DocumentReferenceType { ID = new IDType { Value = "K987654321" } } },
                AccountingSupplierParty = new SupplierPartyType
                {
                    Party = new PartyType
                    {
                        PartyName = new PartyNameType[] { new PartyNameType { Name = new NameType1 { Value = "Leverandør" } } },
                        PostalAddress = new AddressType
                        {
                            Postbox = new PostboxType { Value = "Postboks 123" },
                            StreetName = new StreetNameType { Value = "Oslogate" },
                            BuildingNumber = new BuildingNumberType { Value = "1" },
                            CityName = new CityNameType { Value = "Oslo" },
                            PostalZone = new PostalZoneType { Value = "0612" },
                            Country = new CountryType { IdentificationCode = new IdentificationCodeType { Value = "NO" } },
                        },
                        PartyTaxScheme = new PartyTaxSchemeType[]
                        {
                            new PartyTaxSchemeType 
                            {
                                CompanyID = new CompanyIDType { Value = "NO999999999MVA" },
                                TaxScheme = new TaxSchemeType 
                                { 
                                    ID = new IDType 
                                    { 
                                        schemeID = "UN/ECE 5153",
                                        schemeAgencyID = "6",
                                        Value = "VAT"
                                    } 
                                }
                            }
                        },
                        PartyLegalEntity = new PartyLegalEntityType[] 
                        {
                            new PartyLegalEntityType { CompanyID = new CompanyIDType { Value = "999999999" } }
                        },
                        Contact = new ContactType { ID = new IDType { Value = "O Hansen" } },

                    }
                },
                AccountingCustomerParty = new CustomerPartyType
                {
                    Party = new PartyType
                    {
                        PartyIdentification = new PartyIdentificationType[]
                        { 
                            new PartyIdentificationType { ID = new IDType { Value = "456789" } }
                        },
                        PartyName = new PartyNameType[] 
                        { 
                            new PartyNameType { Name = new NameType1 { Value = "Kjøper" } }
                        },
                        PostalAddress = new AddressType
                        {
                            StreetName = new StreetNameType { Value = "Testveien" },
                            BuildingNumber = new BuildingNumberType { Value = "1" },
                            CityName = new CityNameType { Value = "Frogner" },
                            PostalZone = new PostalZoneType { Value = "2012" },
                            Country = new CountryType { IdentificationCode = new IdentificationCodeType { Value = "NO" } }
                        },
                        PartyLegalEntity = new PartyLegalEntityType[]
                        {
                            new PartyLegalEntityType { CompanyID = new CompanyIDType { Value = "NO888888888MVA" } }
                        },
                        Contact = new ContactType { ID = new IDType { Value = "Arne Bjarne Baluba" } }
                    }
                },
                Delivery = new DeliveryType[]
                {
                    new DeliveryType 
                    {
                        ActualDeliveryDate = new ActualDeliveryDateType {  Value = new DateTime(2009,11,25) },
                        DeliveryLocation = new LocationType1 // NAMECLASH #2
                        {
                            Address = new AddressType 
                            {
                                StreetName = new StreetNameType { Value = "Testgata" },
                                BuildingNumber = new BuildingNumberType { Value = "1" },
                                CityName = new CityNameType { Value = "Oslo" },
                                PostalZone = new PostalZoneType { Value = "0112" },
                                Country = new CountryType { IdentificationCode = new IdentificationCodeType { Value="NO"}}
                            }
                        }
                    }
                },
                PaymentMeans = new PaymentMeansType[]
                {
                    new PaymentMeansType
                    {
                        PaymentMeansCode = new PaymentMeansCodeType1 { Value = "31" },
                        PaymentDueDate = new PaymentDueDateType { Value = new DateTime(2009, 11, 27) },
                        PaymentID = new PaymentIDType[] { new PaymentIDType { Value = "1234561" } },
                        PayeeFinancialAccount = new FinancialAccountType
                        {
                            ID = new IDType { schemeID="IBAN", Value="NO9386011117947"},
                            FinancialInstitutionBranch = new BranchType
                            {
                                ID = new IDType { schemeID="BIC", Value="DNBANOKK"},
                            }
                        }
                    }
                },
                TaxTotal = new TaxTotalType[]
                {
                    new TaxTotalType 
                    {
                        TaxAmount = new TaxAmountType { Value = 962.0M, currencyID = sNok },
                        TaxSubtotal = new TaxSubtotalType[]
                        {
                            new TaxSubtotalType 
                            {
                                TaxableAmount = new TaxableAmountType { Value = 3400.0M, currencyID = sNok },
                                TaxAmount = new TaxAmountType { Value=850.0M, currencyID = sNok },
                                TaxCategory = new TaxCategoryType 
                                { 
                                    ID = new IDType { Value="S" },
                                    Percent = new PercentType { Value = 25.0M },
                                    TaxScheme = new TaxSchemeType { ID = new IDType { Value = "VAT" } }
                                }
                            },
                            new TaxSubtotalType
                            {
                                TaxableAmount = new TaxableAmountType { Value = 800.0M, currencyID = sNok }, // Shortcut on currency
                                TaxAmount = new TaxAmountType { Value = 112.0M, currencyID = sNok },
                                TaxCategory = new TaxCategoryType
                                {
                                    ID = new IDType { Value="AA" },
                                    Percent = new PercentType { Value = 8 },
                                    TaxScheme = new TaxSchemeType { ID = new IDType { Value="VAT" } }
                                }
                            
                            }
                        }
                    }
                },
                LegalMonetaryTotal = new MonetaryTotalType
                {
                    LineExtensionAmount = new LineExtensionAmountType { currencyID = sNok, Value = 4200.0M },
                    TaxExclusiveAmount = new TaxExclusiveAmountType { currencyID = sNok, Value = 4200.0M },
                    TaxInclusiveAmount = new TaxInclusiveAmountType { currencyID = sNok, Value = 5162.0M },
                    PayableAmount = new PayableAmountType { currencyID = sNok, Value = 5162.0M }
                },
                InvoiceLine = new InvoiceLineType[] 
                { 
                    new InvoiceLineType
                    {
                        ID = new IDType { Value = "1" },
                        InvoicedQuantity = new InvoicedQuantityType { unitCode="NMP", unitCodeSpecified=true, Value=2 },
                        LineExtensionAmount = new LineExtensionAmountType { currencyID=sNok, Value=400.0M },
                        AccountingCost = new AccountingCostType { Value="200500600" },
                        OrderLineReference = new OrderLineReferenceType[]
                        {
                            new OrderLineReferenceType { LineID = new LineIDType { Value = "5"} }
                        },
                        TaxTotal = new TaxTotalType[]
                        {
                            new TaxTotalType { TaxAmount = new TaxAmountType { currencyID=sNok, Value=100.0M }}
                        },
                        Item = new ItemType
                        {
                            Name = new NameType1 { Value = "Testprodukt 1"},
                            SellersItemIdentification = new ItemIdentificationType { ID = new IDType { Value = "12345670" }},
                            ClassifiedTaxCategory = new TaxCategoryType[] 
                            {
                                new TaxCategoryType 
                                { 
                                    ID = new IDType { Value = "S" },
                                    Percent = new PercentType { Value=25.0M },
                                    TaxScheme = new TaxSchemeType { ID = new IDType { Value="VAT" }}
                                }
                            }
                        },
                        Price = new PriceType 
                        {
                            PriceAmount = new PriceAmountType { currencyID=sNok, Value=200.0M }
                        }
                    },
                    new InvoiceLineType
                    {
                        ID = new IDType { Value = "2" },
                        InvoicedQuantity = new InvoicedQuantityType { unitCode="NAR", unitCodeSpecified=true, Value=20 },
                        LineExtensionAmount = new LineExtensionAmountType { currencyID=sNok, Value=3000.0M },
                        AccountingCost = new AccountingCostType { Value="200900600" },
                        OrderLineReference = new OrderLineReferenceType[]
                        {
                            new OrderLineReferenceType { LineID = new LineIDType { Value = "7"} }
                        },
                        TaxTotal = new TaxTotalType[]
                        {
                            new TaxTotalType { TaxAmount = new TaxAmountType { currencyID=sNok, Value=750.0M }}
                        },
                        Item = new ItemType
                        {
                            Name = new NameType1 { Value = "Testprodukt 2"},
                            SellersItemIdentification = new ItemIdentificationType { ID = new IDType { Value = "24683432" }},
                            ClassifiedTaxCategory = new TaxCategoryType[] 
                            {
                                new TaxCategoryType 
                                { 
                                    ID = new IDType { Value = "S" },
                                    Percent = new PercentType { Value=25.0M },
                                    TaxScheme = new TaxSchemeType { ID = new IDType { Value="VAT" }}
                                }
                            }
                        },
                        Price = new PriceType 
                        {
                            PriceAmount = new PriceAmountType { currencyID=sNok, Value=150.0M }
                        }
                    
                    },
                    new InvoiceLineType
                    {
                        ID = new IDType { Value = "3" },
                        InvoicedQuantity = new InvoicedQuantityType { unitCode="KGM", unitCodeSpecified=true, Value=8 },
                        LineExtensionAmount = new LineExtensionAmountType { currencyID=sNok, Value=800.0M },
                        AccountingCost = new AccountingCostType { Value="200600700" },
                        OrderLineReference = new OrderLineReferenceType[]
                        {
                            new OrderLineReferenceType { LineID = new LineIDType { Value = "8"} }
                        },
                        TaxTotal = new TaxTotalType[]
                        {
                            new TaxTotalType { TaxAmount = new TaxAmountType { currencyID=sNok, Value=112.0M }}
                        },
                        Item = new ItemType
                        {
                            Name = new NameType1 { Value = "Matprodukt 1"},
                            SellersItemIdentification = new ItemIdentificationType { ID = new IDType { Value = "23456785" }},
                            ClassifiedTaxCategory = new TaxCategoryType[] 
                            {
                                new TaxCategoryType 
                                { 
                                    ID = new IDType { Value = "AA" },
                                    Percent = new PercentType { Value=8.0M },
                                    TaxScheme = new TaxSchemeType { ID = new IDType { Value="VAT" }}
                                }
                            }
                        },
                        Price = new PriceType 
                        {
                            PriceAmount = new PriceAmountType { currencyID=sNok, Value=100.0M }
                        }
                    }
                }
            };
            // Arg!! That was f... to much to type for just one invoice. Something must be done!

            string filename = Path.Combine(this.TestContext.TestRunDirectory, "SampleExplicitInvoice.xml");
            UblDoc<InvoiceType>.Save(filename, doc);
            this.TestContext.WriteLine(filename);

            // now validate ouput file at http://vefa.difi.no/formatvalidering/
            string buffer = string.Empty;
            using (MemoryStream ms = new MemoryStream())
            {
                UblDoc<InvoiceType>.Save(ms, doc);
                ms.Position = 0;
                using (StreamReader sr = new StreamReader(ms))
                {
                    buffer = sr.ReadToEnd();
                }
            }
            bool containsXXX = buffer.Contains("\"XXX\"");
            Assert.AreEqual(false, containsXXX, "A value got set by implicit convertion constructor");
        }*/

        [TestMethod]
        public void SaveImplicitCreatedNorwegianInvoice()
        {
            // Set global defaults for all Ubl documents that get created
            UblBaseDocumentType.GlbCustomizationID = "urn:www.cenbii.eu:transaction:biicoretrdm010:ver1.0";
            UblBaseDocumentType.GlbProfileID = "urn:www.cenbii.eu:profile:bii05:ver1.0";

            // Set thread local default for all currency types
            Ubl2.Udt.AmountType.TlsDefaultCurrencyID = "NOK";

            // Create an invoice using global defaults set above
            InvoiceType doc = new InvoiceType
            {
                ID = "123456",
                IssueDate = new DateTime(2009, 11, 12),
                DocumentCurrencyCode = "NOK",
                OrderReference = new OrderReferenceType { ID = "Prosjekt 13" },
                ContractDocumentReference = new DocumentReferenceType[] { new DocumentReferenceType { ID = "K987654321" } },
                AccountingSupplierParty = new SupplierPartyType
                {
                    Party = new PartyType
                    {
                        PartyName = new PartyNameType[] { "Leverandør" },
                        PostalAddress = new AddressType
                        {
                            Postbox = "Postboks 123",
                            StreetName = "Oslogate",
                            BuildingNumber = "1",
                            CityName = "Oslo",
                            PostalZone = "0612",
                            Country = new CountryType { IdentificationCode = "NO" },
                        },
                        PartyTaxScheme = new PartyTaxSchemeType[]
                        {
                            new PartyTaxSchemeType 
                            {
                                CompanyID = "NO999999999MVA",
                                TaxScheme = new TaxSchemeType 
                                { 
                                    ID = new IdentifierType 
                                    { 
                                        schemeID = "UN/ECE 5153",
                                        schemeAgencyID = "6",
                                        Value = "VAT"
                                    } 
                                }
                            }
                        },
                        PartyLegalEntity = new PartyLegalEntityType[] 
                        {
                            new PartyLegalEntityType { CompanyID = "999999999" }
                        },
                        Contact = new ContactType { ID = "O Hansen" },

                    }
                },
                AccountingCustomerParty = new CustomerPartyType
                {
                    Party = new PartyType
                    {
                        PartyIdentification = new PartyIdentificationType[] { "456789" },
                        PartyName = new PartyNameType[] { "Kjøper" },
                        PostalAddress = new AddressType
                        {
                            StreetName = "Testveien",
                            BuildingNumber = "1",
                            CityName = "Frogner",
                            PostalZone = "2012",
                            Country = new CountryType { IdentificationCode = "NO" }
                        },
                        PartyLegalEntity = new PartyLegalEntityType[]
                        {
                            new PartyLegalEntityType { CompanyID = "NO888888888MVA" }
                        },
                        Contact = new ContactType { ID = "Arne Bjarne Baluba" }
                    }
                },
                Delivery = new DeliveryType[]
                {
                    new DeliveryType 
                    {
                        ActualDeliveryDate =  new DateTime(2009,11,25),
                        DeliveryLocation = new LocationType1 // NAMECLASH #2
                        {
                            Address = new AddressType 
                            {
                                StreetName = "Testgata",
                                BuildingNumber = "1",
                                CityName = "Oslo",
                                PostalZone = "0112",
                                Country = new CountryType { IdentificationCode = "NO"}
                            }
                        }
                    }
                },
                PaymentMeans = new PaymentMeansType[]
                {
                    new PaymentMeansType
                    {
                        PaymentMeansCode = "31",
                        PaymentDueDate = new DateTime(2009, 11, 27),
                        PaymentID = new Ubl2.Udt.IdentifierType[] { "1234561" },
                        PayeeFinancialAccount = new FinancialAccountType
                        {
                            ID = "NO9386011117947",
                            FinancialInstitutionBranch = new BranchType
                            {
                                ID = new IdentifierType { schemeID="BIC", Value="DNBANOKK"},
                            }
                        }
                    }
                },
                TaxTotal = new TaxTotalType[]
                {
                    new TaxTotalType 
                    {
                        TaxAmount = 962.0M,
                        TaxSubtotal = new TaxSubtotalType[]
                        {
                            new TaxSubtotalType 
                            {
                                TaxableAmount = 3400.0M,
                                TaxAmount = 850.0M,
                                TaxCategory = new TaxCategoryType 
                                { 
                                    ID = "S" ,
                                    Percent = 25.0M,
                                    TaxScheme = "VAT"
                                }
                            },
                            new TaxSubtotalType
                            {
                                TaxableAmount = 800.0M,
                                TaxAmount = 112.0M,
                                TaxCategory = new TaxCategoryType
                                {
                                    ID = "AA",
                                    Percent = 8.0M,
                                    TaxScheme = "VAT" 
                                }
                            }
                        }
                    }
                },
                LegalMonetaryTotal = new MonetaryTotalType
                {
                    LineExtensionAmount = 4200.0M,
                    TaxExclusiveAmount = 4200.0M,
                    TaxInclusiveAmount = 5162.0M,
                    PayableAmount = 5162.0M
                },
                InvoiceLine = new InvoiceLineType[] 
                { 
                    new InvoiceLineType
                    {
                        ID = "1",
                        InvoicedQuantity = new  Ubl2.Udt.QuantityType { unitCode="NMP", Value=2 },
                        LineExtensionAmount = 400.0M,
                        AccountingCost = "200500600",
                        OrderLineReference = new OrderLineReferenceType[]
                        {
                            new OrderLineReferenceType { LineID = "5" }
                        },
                        TaxTotal = new TaxTotalType[]
                        {
                            new TaxTotalType { TaxAmount = 100.0M }
                        },
                        Item = new ItemType
                        {
                            Name = "Testprodukt 1",
                            SellersItemIdentification = new ItemIdentificationType { ID = "12345670" },
                            ClassifiedTaxCategory = new TaxCategoryType[] 
                            {
                                new TaxCategoryType 
                                { 
                                    ID = "S" ,
                                    Percent = 25.0M,
                                    TaxScheme = "VAT"
                                }
                            }
                        },
                        Price = 200.0M
                    },
                    new InvoiceLineType
                    {
                        ID = "2" ,
                        InvoicedQuantity = new QuantityType { unitCode="NAR", Value=20 },
                        LineExtensionAmount = 3000.0M ,
                        AccountingCost = "200900600",
                        OrderLineReference = new OrderLineReferenceType[]
                        {
                            new OrderLineReferenceType { LineID = "7" }
                        },
                        TaxTotal = new TaxTotalType[]
                        {
                            new TaxTotalType { TaxAmount = 750.0M }
                        },
                        Item = new ItemType
                        {
                            Name = "Testprodukt 2",
                            SellersItemIdentification = new ItemIdentificationType { ID = "24683432" },
                            ClassifiedTaxCategory = new TaxCategoryType[] 
                            {
                                new TaxCategoryType 
                                { 
                                    ID = "S",
                                    Percent = 25.0M,
                                    TaxScheme = "VAT"
                                }
                            }
                        },
                        Price = 150.0M
                    },
                    new InvoiceLineType
                    {
                        ID = "3",
                        InvoicedQuantity = new QuantityType { unitCode="KGM", Value=8 },
                        LineExtensionAmount = 800.0M,
                        AccountingCost = "200600700",
                        OrderLineReference = new OrderLineReferenceType[]
                        {
                            new OrderLineReferenceType { LineID = "8" }
                        },
                        TaxTotal = new TaxTotalType[]
                        {
                            new TaxTotalType { TaxAmount = 112.0M }
                        },
                        Item = new ItemType
                        {
                            Name = "Matprodukt 1",
                            SellersItemIdentification = new ItemIdentificationType { ID = "23456785" },
                            ClassifiedTaxCategory = new TaxCategoryType[] 
                            {
                                new TaxCategoryType 
                                { 
                                    ID = "AA",
                                    Percent = 8.0M,
                                    TaxScheme = "VAT"
                                }
                            }
                        },
                        Price = 100.0M 
                    }
                }
            };

            string filename = "SampleImplicitInvoice.xml";
            UblDoc<InvoiceType>.Save(filename, doc);

            // Use schema validation (pull xsd from the net)
            XmlSchemaSet invoiceSchemaSet = new XmlSchemaSet();
            using (XmlTextReader xr = new XmlTextReader("http://docs.oasis-open.org/ubl/os-UBL-2.0-update/xsdrt/maindoc/UBL-Invoice-2.0.xsd"))
            {
                invoiceSchemaSet.Add(XmlSchema.Read(xr, null));
            }

            XDocument xDoc = XDocument.Load(filename);
            // throw if invalid
            System.Xml.Schema.Extensions.Validate(xDoc, invoiceSchemaSet, null);

        }

        /// <summary>
        /// Sample data taken from:
        /// http://www.anskaffelser.no/filearchive/implementation-guide-ehf-invoice-and-creditnote-v1.4.pdf
        /// </summary>
        [TestMethod]
        public void SaveImplicitCreatedNorwegianCreditNote()
        {
            // Set global defaults for Ubl documents that get created
            UblBaseDocumentType.GlbCustomizationID = "urn:www.cenbii.eu:transaction:BiiCoreTrdm001:ver1.0:extentionId";
            UblBaseDocumentType.GlbProfileID = "urn:www.cenbii.eu:profile:bii05:ver1.0";

            // Set thread local default for all amounts types decending from AmountType
            Ubl2.Udt.AmountType.TlsDefaultCurrencyID = "NOK";

            // Create a serializable CreditNote instance.
            CreditNoteType doc = new CreditNoteType();
            doc.ID = "654321";
            doc.IssueDate = new DateTime(2009, 11, 12, 0, 0, 0, DateTimeKind.Utc);
            doc.DocumentCurrencyCode = "NOK";

            // <cac:BillingReference> 
            //   <cac:InvoiceDocumentReference> 
            //     <cbc:ID>123456</cbc:ID> 
            //   </cac:InvoiceDocumentReference> 
            // </cac:BillingReference>
            // Becomes:
            doc.BillingReference = new BillingReferenceType[] 
            {  
                new BillingReferenceType{ InvoiceDocumentReference = new DocumentReferenceType { ID = "123456" } }
            };

            doc.AccountingSupplierParty = new SupplierPartyType
            {
                Party = new PartyType
                {
                    PartyName = new PartyNameType[] { "Leverandør" }, // "public static implicit operator PartyNameType(..)" kicks in here
                    PostalAddress = new AddressType
                    {
                        Postbox = "Postboks 123",
                        StreetName = "Oslogate",
                        BuildingNumber = "1",
                        CityName = "Oslo",
                        PostalZone = "0612",
                        Country = new CountryType { IdentificationCode = "NO" }
                    },
                    /*                    PartyTaxScheme = new PartyTaxSchemeType[] // Doc sample missed out on this one. Need it to be valid at http://vefa.difi.no/formatvalidering/
                                        {
                                            new PartyTaxSchemeType 
                                            {
                                                CompanyID = "NO999999999MVA",
                                                TaxScheme = new TaxSchemeType 
                                                { 
                                                    ID = new IdentifierType 
                                                    { 
                                                        schemeID = "UN/ECE 5153",
                                                        schemeAgencyID = "6",
                                                        Value = "VAT"
                                                    } 
                                                }
                                            }
                                        }, */
                    PartyLegalEntity = new PartyLegalEntityType[] { new PartyLegalEntityType { CompanyID = "NO999999999MVA" } },
                    Contact = new ContactType { ID = "O Hansen" },
                }
            };

            // Populating class instance the old way but are still using implicit operator assingnment functions
            doc.AccountingCustomerParty = new CustomerPartyType();
            PartyType p = new PartyType();
            doc.AccountingCustomerParty.Party = p;
            p.PartyIdentification = new PartyIdentificationType[] { "456789" };
            p.PartyName = new PartyNameType[1];
            p.PartyName[0] = new PartyNameType { Name = "Kjøper" };
            p.PostalAddress = new AddressType();
            p.PostalAddress.StreetName = "Testveien";
            p.PostalAddress.BuildingNumber = "1";
            p.PostalAddress.CityName = "Frogner";
            p.PostalAddress.PostalZone = "2012";
            p.PostalAddress.Country = new CountryType();
            p.PostalAddress.Country.IdentificationCode = "NO"; // NerdNote! public static implicit operator CountryIdentificationCodeType(System.String value) gets called for string "NO" assignment
            p.PartyLegalEntity = new PartyLegalEntityType[] { new PartyLegalEntityType() };
            p.PartyLegalEntity[0].CompanyID = "NO888888888MVA";
            p.Contact = new ContactType { ID = "3150bdn" };

            TaxTotalType tax = new TaxTotalType();
            doc.TaxTotal = new TaxTotalType[1] { tax };
            tax.TaxAmount = 112.0M;
            tax.TaxSubtotal = new TaxSubtotalType[1] { new TaxSubtotalType() };
            tax.TaxSubtotal[0].TaxableAmount = 800.0M;
            tax.TaxSubtotal[0].TaxAmount = 112.0M;
            tax.TaxSubtotal[0].TaxCategory = new TaxCategoryType
            {
                ID = "AA",
                Percent = 14.0M,
                TaxScheme = "VAT"
            };

            doc.LegalMonetaryTotal = new MonetaryTotalType();
            doc.LegalMonetaryTotal.LineExtensionAmount = 800.0M; // Note difi.no doc use "AED" instead of DocumentCurrency code. QA slip.
            doc.LegalMonetaryTotal.LineExtensionAmount.currencyID = "AED";
            doc.LegalMonetaryTotal.TaxExclusiveAmount = 800.0M;
            doc.LegalMonetaryTotal.TaxExclusiveAmount.currencyID = "AED";
            doc.LegalMonetaryTotal.TaxInclusiveAmount = 912.0M;
            doc.LegalMonetaryTotal.TaxInclusiveAmount.currencyID = "AED";
            doc.LegalMonetaryTotal.PayableAmount = 912.0M;
            doc.LegalMonetaryTotal.PayableAmount.currencyID = "AED";

            doc.CreditNoteLine = new CreditNoteLineType[1];
            doc.CreditNoteLine[0] = new CreditNoteLineType
            {
                ID = "1",
                CreditedQuantity = new Ubl2.Udt.QuantityType { Value = 8, unitCode = "KGM" },
                LineExtensionAmount = 800.0M,
                TaxTotal = new TaxTotalType[] { new TaxTotalType { TaxAmount = 112.0M } },
                Item = new ItemType
                {
                    Name = "Matprodukt-1",
                    SellersItemIdentification = new ItemIdentificationType { ID = "23456785" },
                    ClassifiedTaxCategory = new TaxCategoryType[] 
                    {
                        new TaxCategoryType
                        {
                            ID = "S",
                            Percent = 14.0M,
                            TaxScheme = "VAT"
                        }
                    }
                },
                Price = 100.0M
            };
            
            // save the creditnote to xml
            string filename = "ImplicitCreatedNorwegianCreditNote.xml";
            UblDoc<CreditNoteType>.Save(filename, doc);

            // Compare it with a local copy grabbed from difi.no doc
            bool areEqual = UblXmlComparer.IsCopyEqual<CreditNoteType>("NorwegianCreditNoteFromDifiPdfDoc.xml", doc);
            Assert.AreEqual(areEqual, true, "Written UBL doc differs from original");
        }

    }
}
