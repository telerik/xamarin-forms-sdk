using System;
using System.ComponentModel;
using Telerik.Barcode;

namespace SDKBrowser.Examples.BarcodeControl.SwissQRCodeCategory.SwissQRCodeConfigurationExample
{
    public class SwissQRConfigurationViewModel : INotifyPropertyChanged
    {
        private string value;
        private string errors;
        private string ibanText;
        private string ibanTypeString;
        private string codeCurrencyString;
        private string creditorName;
        private string creditorCountry;
        private string creditorZipCode;
        private string creditorCity;
        private string creditorStreet;
        private string creditorHouseNumber;
        private string referenceTypeString;
        private string reference;
        private string unstructuredMessage;
        private string billingInformation;
        private string debtorName;
        private string debtorCountry;
        private string debtorZipCode;
        private string debtorCity;
        private string debtorStreet;
        private string debtorHouseNumber;
        private decimal amount;
        private string alternativeProcedure1;
        private string alternativeProcedure2;
        private bool hasAdditionalInfo;
        private bool hasDebtor;
        private bool hasAmount;
        private bool hasAlternativeProcedures;

        public SwissQRConfigurationViewModel()
        {
            this.ibanText = "CH5204835012345671000";
            this.creditorName = "Max Muster & Söhne";
            this.creditorCountry = "CH";
            this.creditorZipCode = "8000";
            this.creditorCity = "Seldwyla";
            this.creditorStreet = "Musterstrasse";
            this.creditorHouseNumber = "316";
            this.unstructuredMessage = "unstructured message";
            this.billingInformation = "billing info";
            this.debtorName = "Simon Muster";
            this.debtorCountry = "CH";
            this.debtorZipCode = "8000";
            this.debtorCity = "Seldwyla";
            this.debtorStreet = "Debtor street";
            this.debtorHouseNumber = "12";
            this.amount = 10.49M;

            this.ibanTypeString = Enum.GetValues(typeof(IbanType)).GetValue(0).ToString();
            this.codeCurrencyString = Enum.GetValues(typeof(SwissQRCodeCurrency)).GetValue(0).ToString();
            this.referenceTypeString = Enum.GetValues(typeof(ReferenceType)).GetValue(2).ToString();

            this.errors = string.Empty;
            this.reference = string.Empty;
            this.alternativeProcedure1 = string.Empty;
            this.alternativeProcedure2 = string.Empty;

            this.hasAdditionalInfo = true;
            this.hasDebtor = true;
            this.hasAmount = true;
            this.hasAlternativeProcedures = false;

            this.GenerateBarcodeValue();
        }

        public event PropertyChangedEventHandler PropertyChanged;

        public string Value
        {
            get
            {
                return this.value;
            }
            set
            {
                if (this.value != value)
                {
                    this.value = value;
                    this.RaisePropertyChanged(nameof(Value));
                }
            }
        }

        public string Errors
        {
            get
            {
                return this.errors;
            }
            set
            {
                if (this.errors != value)
                {
                    this.errors = value;
                    this.RaisePropertyChanged(nameof(Errors));
                }
            }
        }

        public string IbanText
        {
            get
            {
                return this.ibanText;
            }
            set
            {
                if (this.ibanText != value)
                {
                    this.ibanText = value;
                    this.RaisePropertyChanged(nameof(IbanText));
                    this.GenerateBarcodeValue();
                }
            }
        }

        public string IbanType
        {
            get
            {
                return this.ibanTypeString;
            }
            set
            {
                if (this.ibanTypeString != value)
                {
                    this.ibanTypeString = value;
                    this.RaisePropertyChanged(nameof(IbanType));
                    this.GenerateBarcodeValue();
                }
            }
        }

        public string CodeCurrency
        {
            get
            {
                return this.codeCurrencyString;
            }
            set
            {
                if (this.codeCurrencyString != value)
                {
                    this.codeCurrencyString = value;
                    this.RaisePropertyChanged(nameof(CodeCurrency));
                    this.GenerateBarcodeValue();
                }
            }
        }

        public string CreditorName
        {
            get
            {
                return this.creditorName;
            }
            set
            {
                if (this.creditorName != value)
                {
                    this.creditorName = value;
                    this.RaisePropertyChanged(nameof(CreditorName));
                    this.GenerateBarcodeValue();
                }
            }
        }

        public string CreditorCountry
        {
            get
            {
                return this.creditorCountry;
            }
            set
            {
                if (this.creditorCountry != value)
                {
                    this.creditorCountry = value;
                    this.RaisePropertyChanged(nameof(CreditorCountry));
                    this.GenerateBarcodeValue();
                }
            }
        }

        public string CreditorZipCode
        {
            get
            {
                return this.creditorZipCode;
            }
            set
            {
                if (this.creditorZipCode != value)
                {
                    this.creditorZipCode = value;
                    this.RaisePropertyChanged(nameof(CreditorZipCode));
                    this.GenerateBarcodeValue();
                }
            }
        }

        public string CreditorCity
        {
            get
            {
                return this.creditorCity;
            }
            set
            {
                if (this.creditorCity != value)
                {
                    this.creditorCity = value;
                    this.RaisePropertyChanged(nameof(CreditorCity));
                    this.GenerateBarcodeValue();
                }
            }
        }

        public string CreditorStreet
        {
            get
            {
                return this.creditorStreet;
            }
            set
            {
                if (this.creditorStreet != value)
                {
                    this.creditorStreet = value;
                    this.RaisePropertyChanged(nameof(CreditorStreet));
                    this.GenerateBarcodeValue();
                }
            }
        }

        public string CreditorHouseNumber
        {
            get
            {
                return this.creditorHouseNumber;
            }
            set
            {
                if (this.creditorHouseNumber != value)
                {
                    this.creditorHouseNumber = value;
                    this.RaisePropertyChanged(nameof(CreditorHouseNumber));
                    this.GenerateBarcodeValue();
                }
            }
        }

        public string ReferenceType
        {
            get
            {
                return this.referenceTypeString;
            }
            set
            {
                if (this.referenceTypeString != value)
                {
                    this.referenceTypeString = value;
                    this.RaisePropertyChanged(nameof(referenceTypeString));
                    this.GenerateBarcodeValue();
                }
            }
        }

        public string Reference
        {
            get
            {
                return this.reference;
            }
            set
            {
                if (this.reference != value)
                {
                    this.reference = value;
                    this.RaisePropertyChanged(nameof(Reference));
                    this.GenerateBarcodeValue();
                }
            }
        }

        public string UnstructuredMessage
        {
            get
            {
                return this.unstructuredMessage;
            }
            set
            {
                if (this.unstructuredMessage != value)
                {
                    this.unstructuredMessage = value;
                    this.RaisePropertyChanged(nameof(UnstructuredMessage));
                    this.GenerateBarcodeValue();
                }
            }
        }

        public string BillingInformation
        {
            get
            {
                return this.billingInformation;
            }
            set
            {
                if (this.billingInformation != value)
                {
                    this.billingInformation = value;
                    this.RaisePropertyChanged(nameof(BillingInformation));
                    this.GenerateBarcodeValue();
                }
            }
        }

        public string DebtorName
        {
            get
            {
                return this.debtorName;
            }
            set
            {
                if (this.debtorName != value)
                {
                    this.debtorName = value;
                    this.RaisePropertyChanged(nameof(DebtorName));
                    this.GenerateBarcodeValue();
                }
            }
        }

        public string DebtorCountry
        {
            get
            {
                return this.debtorCountry;
            }
            set
            {
                if (this.debtorCountry != value)
                {
                    this.debtorCountry = value;
                    this.RaisePropertyChanged(nameof(DebtorCountry));
                    this.GenerateBarcodeValue();
                }
            }
        }

        public string DebtorZipCode
        {
            get
            {
                return this.debtorZipCode;
            }
            set
            {
                if (this.debtorZipCode != value)
                {
                    this.debtorZipCode = value;
                    this.RaisePropertyChanged(nameof(DebtorZipCode));
                    this.GenerateBarcodeValue();
                }
            }
        }

        public string DebtorCity
        {
            get
            {
                return this.debtorCity;
            }
            set
            {
                if (this.debtorCity != value)
                {
                    this.debtorCity = value;
                    this.RaisePropertyChanged(nameof(DebtorCity));
                    this.GenerateBarcodeValue();
                }
            }
        }

        public string DebtorStreet
        {
            get
            {
                return this.debtorStreet;
            }
            set
            {
                if (this.debtorStreet != value)
                {
                    this.debtorStreet = value;
                    this.RaisePropertyChanged(nameof(DebtorStreet));
                    this.GenerateBarcodeValue();
                }
            }
        }

        public string DebtorHouseNumber
        {
            get
            {
                return this.debtorHouseNumber;
            }
            set
            {
                if (this.debtorHouseNumber != value)
                {
                    this.debtorHouseNumber = value;
                    this.RaisePropertyChanged(nameof(DebtorHouseNumber));
                    this.GenerateBarcodeValue();
                }
            }
        }

        public decimal Amount
        {
            get
            {
                return this.amount;
            }
            set
            {
                if (this.amount != value)
                {
                    this.amount = value;
                    this.RaisePropertyChanged(nameof(Amount));
                    this.GenerateBarcodeValue();
                }
            }
        }

        public string AlternativeProcedure1
        {
            get
            {
                return this.alternativeProcedure1;
            }
            set
            {
                if (this.alternativeProcedure1 != value)
                {
                    this.alternativeProcedure1 = value;
                    this.RaisePropertyChanged(nameof(AlternativeProcedure1));
                    this.GenerateBarcodeValue();
                }
            }
        }

        public string AlternativeProcedure2
        {
            get
            {
                return this.alternativeProcedure2;
            }
            set
            {
                if (this.alternativeProcedure2 != value)
                {
                    this.alternativeProcedure2 = value;
                    this.RaisePropertyChanged(nameof(AlternativeProcedure2));
                    this.GenerateBarcodeValue();
                }
            }
        }

        public bool HasAdditionalInfo
        {
            get
            {
                return this.hasAdditionalInfo;
            }
            set
            {
                if (this.hasAdditionalInfo != value)
                {
                    this.hasAdditionalInfo = value;
                    this.RaisePropertyChanged(nameof(HasAdditionalInfo));
                    this.GenerateBarcodeValue();
                }
            }
        }

        public bool HasDebtor
        {
            get
            {
                return this.hasDebtor;
            }
            set
            {
                if (this.hasDebtor != value)
                {
                    this.hasDebtor = value;
                    this.RaisePropertyChanged(nameof(HasDebtor));
                    this.GenerateBarcodeValue();
                }
            }
        }

        public bool HasAmount
        {
            get
            {
                return this.hasAmount;
            }
            set
            {
                if (this.hasAmount != value)
                {
                    this.hasAmount = value;
                    this.RaisePropertyChanged(nameof(HasAmount));
                    this.GenerateBarcodeValue();
                }
            }
        }

        public bool HasAlternativeProcedures
        {
            get
            {
                return this.hasAlternativeProcedures;
            }
            set
            {
                if (this.hasAlternativeProcedures != value)
                {
                    this.hasAlternativeProcedures = value;
                    this.RaisePropertyChanged(nameof(HasAlternativeProcedures));
                    this.GenerateBarcodeValue();
                }
            }
        }

        private void GenerateBarcodeValue()
        {
            AdditionalInformation additionalInfo = this.hasAdditionalInfo ?
                new AdditionalInformation(this.unstructuredMessage, this.billingInformation)
                : null;

            Contact debtor = this.hasDebtor ?
                new Contact(this.debtorName,
                         new StructuredAddress(this.debtorCountry,
                                               this.debtorZipCode,
                                               this.debtorCity,
                                               this.debtorStreet,
                                               this.debtorHouseNumber))
                : null;

            decimal? amount = null;
            if (this.hasAmount)
            {
                amount = this.amount;
            }

            AlternativeProcedure procedure = this.hasAlternativeProcedures ?
                new AlternativeProcedure(this.alternativeProcedure1, this.alternativeProcedure2)
                : null;

            SwissQRCodeValueStringBuilder qRCodeValue = new SwissQRCodeValueStringBuilder(
             new Iban(this.ibanText, (IbanType)Enum.Parse(typeof(IbanType), this.ibanTypeString, true)),
             (SwissQRCodeCurrency)Enum.Parse(typeof(SwissQRCodeCurrency), this.codeCurrencyString, true),
             new Contact(this.creditorName,
                         new StructuredAddress(this.creditorCountry,
                                               this.creditorZipCode,
                                               this.creditorCity,
                                               this.creditorStreet,
                                               this.creditorHouseNumber)),
             new Reference((ReferenceType)Enum.Parse(typeof(ReferenceType), this.referenceTypeString, true), this.reference),

             additionalInfo,
             debtor,
             amount,
             procedure);

            this.Errors = qRCodeValue.Validate();

            if (!string.IsNullOrEmpty(this.errors))
            {
                this.Value = null;
            }
            else
            {
                this.Value = qRCodeValue.BuildValue();
            }
        }

        private void RaisePropertyChanged(string propertyName)
        {
            this.PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
