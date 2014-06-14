#region Copyright
/*
Copyright 2014 Cluster Reply s.r.l.

Licensed under the Apache License, Version 2.0 (the "License");
you may not use this file except in compliance with the License.
You may obtain a copy of the License at

    http://www.apache.org/licenses/LICENSE-2.0

Unless required by applicable law or agreed to in writing, software
distributed under the License is distributed on an "AS IS" BASIS,
WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
See the License for the specific language governing permissions and
limitations under the License.
*/
#endregion
// ------------------------------------------------------------------------------
//  <auto-generated>
//    Generated by Xsd2Code. Version 3.4.0.32989
//    <NameSpace>Oasis.Ubl.v21</NameSpace><Collection>ObservableCollection</Collection><codeType>CSharp</codeType><EnableDataBinding>False</EnableDataBinding><EnableLazyLoading>False</EnableLazyLoading><TrackingChangesEnable>False</TrackingChangesEnable><GenTrackingClasses>False</GenTrackingClasses><HidePrivateFieldInIDE>False</HidePrivateFieldInIDE><EnableSummaryComment>False</EnableSummaryComment><VirtualProp>False</VirtualProp><IncludeSerializeMethod>False</IncludeSerializeMethod><UseBaseClass>False</UseBaseClass><GenBaseClass>False</GenBaseClass><GenerateCloneMethod>False</GenerateCloneMethod><GenerateDataContracts>False</GenerateDataContracts><CodeBaseTag>Net20</CodeBaseTag><SerializeMethodName>Serialize</SerializeMethodName><DeserializeMethodName>Deserialize</DeserializeMethodName><SaveToFileMethodName>SaveToFile</SaveToFileMethodName><LoadFromFileMethodName>LoadFromFile</LoadFromFileMethodName><GenerateXMLAttributes>False</GenerateXMLAttributes><OrderXMLAttrib>False</OrderXMLAttrib><EnableEncoding>False</EnableEncoding><AutomaticProperties>False</AutomaticProperties><GenerateShouldSerialize>False</GenerateShouldSerialize><DisableDebug>False</DisableDebug><PropNameSpecified>Default</PropNameSpecified><Encoder>UTF8</Encoder><CustomUsings></CustomUsings><ExcludeIncludedTypes>True</ExcludeIncludedTypes><EnableInitializeFields>True</EnableInitializeFields>
//  </auto-generated>
// ------------------------------------------------------------------------------
namespace Oasis.Ubl.v21 {
    using System;
    using System.Diagnostics;
    using System.Xml.Serialization;
    using System.Collections;
    using System.Xml.Schema;
    using System.ComponentModel;
    using System.Collections.ObjectModel;
    
    
    public partial class AmountType1 : AmountType {
    }


    [System.Xml.Serialization.XmlIncludeAttribute(typeof(AmountType1))]
    public partial class AmountType { }
      /*  
        private string currencyIDField;
        
        private string currencyCodeListVersionIDField;
        
        private decimal valueField;
        
        public string currencyID {
            get {
                return this.currencyIDField;
            }
            set {
                this.currencyIDField = value;
            }
        }
        
        public string currencyCodeListVersionID {
            get {
                return this.currencyCodeListVersionIDField;
            }
            set {
                this.currencyCodeListVersionIDField = value;
            }
        }
        
        [System.Xml.Serialization.XmlTextAttribute()]
        public decimal Value {
            get {
                return this.valueField;
            }
            set {
                this.valueField = value;
            }
        }
    }
    */
    public partial class BinaryObjectType1 : BinaryObjectType {
    }
    
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(BinaryObjectType1))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(VideoType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(SoundType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(PictureType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(GraphicType))]
    public partial class BinaryObjectType {
        
        private string formatField;
        
        private string mimeCodeField;
        
        private string encodingCodeField;
        
        private string characterSetCodeField;
        
        private string uriField;
        
        private string filenameField;
        
        private byte[] valueField;
        
        public string format {
            get {
                return this.formatField;
            }
            set {
                this.formatField = value;
            }
        }
        
        public string mimeCode {
            get {
                return this.mimeCodeField;
            }
            set {
                this.mimeCodeField = value;
            }
        }
        
        public string encodingCode {
            get {
                return this.encodingCodeField;
            }
            set {
                this.encodingCodeField = value;
            }
        }
        
        public string characterSetCode {
            get {
                return this.characterSetCodeField;
            }
            set {
                this.characterSetCodeField = value;
            }
        }
        
        public string uri {
            get {
                return this.uriField;
            }
            set {
                this.uriField = value;
            }
        }
        
        public string filename {
            get {
                return this.filenameField;
            }
            set {
                this.filenameField = value;
            }
        }
        
        [System.Xml.Serialization.XmlAttribute(DataType="base64Binary")]
        public byte[] Value {
            get {
                return this.valueField;
            }
            set {
                this.valueField = value;
            }
        }
    }
    
    public partial class VideoType : BinaryObjectType {
    }
    
    public partial class SoundType : BinaryObjectType {
    }
    
    public partial class PictureType : BinaryObjectType {
    }
    
    public partial class GraphicType : BinaryObjectType {
    }
    
    public partial class CodeType1 : CodeType {
    }

    [System.Xml.Serialization.XmlIncludeAttribute(typeof(CodeType1))]

    public partial class CodeType { }
    /*    
        private string listIDField;
        
        private string listAgencyIDField;
        
        private string listAgencyNameField;
        
        private string listNameField;
        
        private string listVersionIDField;
        
        private string nameField;
        
        private string languageIDField;
        
        private string listURIField;
        
        private string listSchemeURIField;
        
        private string valueField;
        
        public string listID {
            get {
                return this.listIDField;
            }
            set {
                this.listIDField = value;
            }
        }
        
        public string listAgencyID {
            get {
                return this.listAgencyIDField;
            }
            set {
                this.listAgencyIDField = value;
            }
        }
        
        public string listAgencyName {
            get {
                return this.listAgencyNameField;
            }
            set {
                this.listAgencyNameField = value;
            }
        }
        
        public string listName {
            get {
                return this.listNameField;
            }
            set {
                this.listNameField = value;
            }
        }
        
        public string listVersionID {
            get {
                return this.listVersionIDField;
            }
            set {
                this.listVersionIDField = value;
            }
        }
        
        public string name {
            get {
                return this.nameField;
            }
            set {
                this.nameField = value;
            }
        }
        
        public string languageID {
            get {
                return this.languageIDField;
            }
            set {
                this.languageIDField = value;
            }
        }
        
        public string listURI {
            get {
                return this.listURIField;
            }
            set {
                this.listURIField = value;
            }
        }
        
        public string listSchemeURI {
            get {
                return this.listSchemeURIField;
            }
            set {
                this.listSchemeURIField = value;
            }
        }
        
        [System.Xml.Serialization.XmlTextAttribute(DataType="normalizedString")]
        public string Value {
            get {
                return this.valueField;
            }
            set {
                this.valueField = value;
            }
        }
    }
    */
    public partial class DateTimeType {
        
        private System.DateTime valueField;
        
        [System.Xml.Serialization.XmlAttribute()]
        public System.DateTime Value {
            get {
                return this.valueField;
            }
            set {
                this.valueField = value;
            }
        }
    }
    
    public partial class DateType {
        
        //private System.DateTime valueField;
        
        //[System.Xml.Serialization.XmlTextAttribute(DataType="date")]
        //public System.DateTime Value {
        //    get {
        //        return this.valueField;
        //    }
        //    set {
        //        this.valueField = value;
        //    }
        //}
    }
    
    public partial class TimeType {
        
        private System.DateTime valueField;
        
        [System.Xml.Serialization.XmlTextAttribute(DataType="time")]
        public System.DateTime Value {
            get {
                return this.valueField;
            }
            set {
                this.valueField = value;
            }
        }
    }
    
    public partial class IdentifierType1 : IdentifierType {
    }

    [System.Xml.Serialization.XmlIncludeAttribute(typeof(IdentifierType1))]
    public partial class IdentifierType { }
    /*
        
        private string schemeIDField;
        
        private string schemeNameField;
        
        private string schemeAgencyIDField;
        
        private string schemeAgencyNameField;
        
        private string schemeVersionIDField;
        
        private string schemeDataURIField;
        
        private string schemeURIField;
        
        private string valueField;
        
        public string schemeID {
            get {
                return this.schemeIDField;
            }
            set {
                this.schemeIDField = value;
            }
        }
        
        public string schemeName {
            get {
                return this.schemeNameField;
            }
            set {
                this.schemeNameField = value;
            }
        }
        
        public string schemeAgencyID {
            get {
                return this.schemeAgencyIDField;
            }
            set {
                this.schemeAgencyIDField = value;
            }
        }
        
        public string schemeAgencyName {
            get {
                return this.schemeAgencyNameField;
            }
            set {
                this.schemeAgencyNameField = value;
            }
        }
        
        public string schemeVersionID {
            get {
                return this.schemeVersionIDField;
            }
            set {
                this.schemeVersionIDField = value;
            }
        }
        
        public string schemeDataURI {
            get {
                return this.schemeDataURIField;
            }
            set {
                this.schemeDataURIField = value;
            }
        }
        
        public string schemeURI {
            get {
                return this.schemeURIField;
            }
            set {
                this.schemeURIField = value;
            }
        }
        
        [System.Xml.Serialization.XmlTextAttribute(DataType="normalizedString")]
        public string Value {
            get {
                return this.valueField;
            }
            set {
                this.valueField = value;
            }
        }
    }
    */
    public partial class IndicatorType {
        
        private string valueField;

        [System.Xml.Serialization.XmlTextAttribute()]
        public string Value {
            get {
                return this.valueField;
            }
            set {
                this.valueField = value;
            }
        }



    }
    
    public partial class MeasureType1 : MeasureType {
    }

    [System.Xml.Serialization.XmlIncludeAttribute(typeof(MeasureType1))]
    public partial class MeasureType { }
    /*    
        private string unitCodeField;
        
        private string unitCodeListVersionIDField;
        
        private decimal valueField;
        
        public string unitCode {
            get {
                return this.unitCodeField;
            }
            set {
                this.unitCodeField = value;
            }
        }
        
        public string unitCodeListVersionID {
            get {
                return this.unitCodeListVersionIDField;
            }
            set {
                this.unitCodeListVersionIDField = value;
            }
        }
        
        [System.Xml.Serialization.XmlTextAttribute()]
        public decimal Value {
            get {
                return this.valueField;
            }
            set {
                this.valueField = value;
            }
        }
    }
    */
    public partial class NumericType1 : NumericType {
    }
    
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(NumericType1))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(RateType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(PercentType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(ValueType))]
    public partial class NumericType {
        
        private string formatField;
        
        private string valueField;
        
        public string format {
            get {
                return this.formatField;
            }
            set {
                this.formatField = value;
            }
        }
        
        [System.Xml.Serialization.XmlTextAttribute()]
        public string Value {
            get {
                return this.valueField;
            }
            set {
                this.valueField = value;
            }
        }
    }
    
    public partial class RateType : NumericType {
    }
    
    public partial class PercentType : NumericType {
    }
    
    //public partial class ValueType : NumericType {
    //}
    
    public partial class QuantityType1 : QuantityType {
    }


    [System.Xml.Serialization.XmlIncludeAttribute(typeof(QuantityType1))]
    public partial class QuantityType { }
    /*    
        private string unitCodeField;
        
        private string unitCodeListIDField;
        
        private string unitCodeListAgencyIDField;
        
        private string unitCodeListAgencyNameField;
        
        private decimal valueField;
        
        public string unitCode {
            get {
                return this.unitCodeField;
            }
            set {
                this.unitCodeField = value;
            }
        }
        
        public string unitCodeListID {
            get {
                return this.unitCodeListIDField;
            }
            set {
                this.unitCodeListIDField = value;
            }
        }
        
        public string unitCodeListAgencyID {
            get {
                return this.unitCodeListAgencyIDField;
            }
            set {
                this.unitCodeListAgencyIDField = value;
            }
        }
        
        public string unitCodeListAgencyName {
            get {
                return this.unitCodeListAgencyNameField;
            }
            set {
                this.unitCodeListAgencyNameField = value;
            }
        }
        
        [System.Xml.Serialization.XmlTextAttribute()]
        public decimal Value {
            get {
                return this.valueField;
            }
            set {
                this.valueField = value;
            }
        }
    }
    */
    public partial class TextType1 : TextType {
    }


    [System.Xml.Serialization.XmlIncludeAttribute(typeof(TextType1))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(NameType))]
    public partial class TextType { }
    /*    
        private string languageIDField;
        
        private string languageLocaleIDField;
        
        private string valueField;
        
        public string languageID {
            get {
                return this.languageIDField;
            }
            set {
                this.languageIDField = value;
            }
        }
        
        public string languageLocaleID {
            get {
                return this.languageLocaleIDField;
            }
            set {
                this.languageLocaleIDField = value;
            }
        }
        
        [System.Xml.Serialization.XmlTextAttribute()]
        public string Value {
            get {
                return this.valueField;
            }
            set {
                this.valueField = value;
            }
        }
    }
    */
    public partial class NameType : TextType {
    }
}
