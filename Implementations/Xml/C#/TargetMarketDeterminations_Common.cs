﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using System.Xml.Serialization;

// 
// This source code was auto-generated by xsd, Version=4.6.1055.0.
// 


/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(Namespace="urn://www.fsc.org.au/DDO/TMD/0.1")]
[System.Xml.Serialization.XmlRootAttribute("TMDReport", Namespace="urn://www.fsc.org.au/DDO/TMD/0.1", IsNullable=false)]
public partial class TMDReportType {
    
    private TMDReportHeader headerField;
    
    private TMDReportBody bodyField;
    
    private TMDReportFooter footerField;
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(Order=0)]
    public TMDReportHeader header {
        get {
            return this.headerField;
        }
        set {
            this.headerField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(Order=1)]
    public TMDReportBody body {
        get {
            return this.bodyField;
        }
        set {
            this.bodyField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(Order=2)]
    public TMDReportFooter footer {
        get {
            return this.footerField;
        }
        set {
            this.footerField = value;
        }
    }
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(Namespace="urn://www.fsc.org.au/DDO/TMD/0.1")]
public partial class TMDReportHeader {
    
    private System.DateTime reportExtractionDateTimeField;
    
    private EntityIdentifierType issuerPrimaryIdentifierField;
    
    private EntityIdentifierType[] issuerAlternativeIdentifiersField;
    
    private string standardVersionField;
    
    public TMDReportHeader() {
        this.standardVersionField = "0.1";
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(Order=0)]
    public System.DateTime ReportExtractionDateTime {
        get {
            return this.reportExtractionDateTimeField;
        }
        set {
            this.reportExtractionDateTimeField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(Order=1)]
    public EntityIdentifierType IssuerPrimaryIdentifier {
        get {
            return this.issuerPrimaryIdentifierField;
        }
        set {
            this.issuerPrimaryIdentifierField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlArrayAttribute(Order=2)]
    [System.Xml.Serialization.XmlArrayItemAttribute("Identifier", Namespace="urn://www.fsc.org.au/DDO/Common/0.1", IsNullable=false)]
    public EntityIdentifierType[] IssuerAlternativeIdentifiers {
        get {
            return this.issuerAlternativeIdentifiersField;
        }
        set {
            this.issuerAlternativeIdentifiersField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string StandardVersion {
        get {
            return this.standardVersionField;
        }
        set {
            this.standardVersionField = value;
        }
    }
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(Namespace="urn://www.fsc.org.au/DDO/Common/0.1")]
public partial class EntityIdentifierType {
    
    private EntityIdentifierTypeEnum entityIdentifierType1Field;
    
    private string entityIdentifierValueField;
    
    private string subUnitField;
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute("EntityIdentifierType", Order=0)]
    public EntityIdentifierTypeEnum EntityIdentifierType1 {
        get {
            return this.entityIdentifierType1Field;
        }
        set {
            this.entityIdentifierType1Field = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(Order=1)]
    public string EntityIdentifierValue {
        get {
            return this.entityIdentifierValueField;
        }
        set {
            this.entityIdentifierValueField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(Order=2)]
    public string SubUnit {
        get {
            return this.subUnitField;
        }
        set {
            this.subUnitField = value;
        }
    }
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
[System.SerializableAttribute()]
[System.Xml.Serialization.XmlTypeAttribute(Namespace="urn://www.fsc.org.au/DDO/Common/0.1")]
public enum EntityIdentifierTypeEnum {
    
    /// <remarks/>
    FAR,
    
    /// <remarks/>
    ABN,
    
    /// <remarks/>
    ASAL,
    
    /// <remarks/>
    ACL,
    
    /// <remarks/>
    Bespoke,
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(Namespace="urn://www.fsc.org.au/DDO/TMD/0.1")]
public partial class TMDReportFooter {
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(Namespace="urn://www.fsc.org.au/DDO/TMD/0.1")]
public partial class TMDCharacteristicType {
    
    private TMDCharacteristicEnum characteristicField;
    
    private TMDIndicatorEnum valueField;
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(Order=0)]
    public TMDCharacteristicEnum Characteristic {
        get {
            return this.characteristicField;
        }
        set {
            this.characteristicField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(Order=1)]
    public TMDIndicatorEnum Value {
        get {
            return this.valueField;
        }
        set {
            this.valueField = value;
        }
    }
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
[System.SerializableAttribute()]
[System.Xml.Serialization.XmlTypeAttribute(Namespace="urn://www.fsc.org.au/DDO/Common/0.1")]
public enum TMDCharacteristicEnum {
    
    /// <remarks/>
    InvestmentObjective_CapitalGrowth,
    
    /// <remarks/>
    InvestmentObjective_CapitalPreservation,
    
    /// <remarks/>
    InvestmentObjective_CapitalGuaranteed,
    
    /// <remarks/>
    InvestmentObjective_RegularIncome,
    
    /// <remarks/>
    InvestmentObjective_Specialist,
    
    /// <remarks/>
    ProductUse_SolutionStandalone,
    
    /// <remarks/>
    ProductUse_CoreComponent,
    
    /// <remarks/>
    ProductUse_Satellite,
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
[System.SerializableAttribute()]
[System.Xml.Serialization.XmlTypeAttribute(Namespace="urn://www.fsc.org.au/DDO/Common/0.1")]
public enum TMDIndicatorEnum {
    
    /// <remarks/>
    In,
    
    /// <remarks/>
    Potentially,
    
    /// <remarks/>
    NotConsidered,
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(Namespace="urn://www.fsc.org.au/DDO/TMD/0.1")]
public partial class TMDCharacteristicsType {
    
    private string investmentObjectiveDescriptionField;
    
    private TMDCharacteristicsTypeInvestmentObjective_CapitalGrowth investmentObjective_CapitalGrowthField;
    
    private string productUseDescriptionField;
    
    private string investmentTimeframeDescriptionField;
    
    private string riskAndReturnDescriptionField;
    
    private string redemptionFrequencyDescriptionField;
    
    private string liquidityDescriptionField;
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(Order=0)]
    public string InvestmentObjectiveDescription {
        get {
            return this.investmentObjectiveDescriptionField;
        }
        set {
            this.investmentObjectiveDescriptionField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(Order=1)]
    public TMDCharacteristicsTypeInvestmentObjective_CapitalGrowth InvestmentObjective_CapitalGrowth {
        get {
            return this.investmentObjective_CapitalGrowthField;
        }
        set {
            this.investmentObjective_CapitalGrowthField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(Order=2)]
    public string ProductUseDescription {
        get {
            return this.productUseDescriptionField;
        }
        set {
            this.productUseDescriptionField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(Order=3)]
    public string InvestmentTimeframeDescription {
        get {
            return this.investmentTimeframeDescriptionField;
        }
        set {
            this.investmentTimeframeDescriptionField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(Order=4)]
    public string RiskAndReturnDescription {
        get {
            return this.riskAndReturnDescriptionField;
        }
        set {
            this.riskAndReturnDescriptionField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(Order=5)]
    public string RedemptionFrequencyDescription {
        get {
            return this.redemptionFrequencyDescriptionField;
        }
        set {
            this.redemptionFrequencyDescriptionField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(Order=6)]
    public string LiquidityDescription {
        get {
            return this.liquidityDescriptionField;
        }
        set {
            this.liquidityDescriptionField = value;
        }
    }
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="urn://www.fsc.org.au/DDO/TMD/0.1")]
public partial class TMDCharacteristicsTypeInvestmentObjective_CapitalGrowth : TMDCharacteristicType {
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(Namespace="urn://www.fsc.org.au/DDO/Common/0.1")]
public partial class ContactDetailsType {
    
    private string nameField;
    
    private string titleField;
    
    private string phoneField;
    
    private string emailField;
    
    private string addressField;
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(Order=0)]
    public string Name {
        get {
            return this.nameField;
        }
        set {
            this.nameField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(Order=1)]
    public string Title {
        get {
            return this.titleField;
        }
        set {
            this.titleField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(Order=2)]
    public string Phone {
        get {
            return this.phoneField;
        }
        set {
            this.phoneField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(Order=3)]
    public string Email {
        get {
            return this.emailField;
        }
        set {
            this.emailField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(Order=4)]
    public string Address {
        get {
            return this.addressField;
        }
        set {
            this.addressField = value;
        }
    }
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(Namespace="urn://www.fsc.org.au/DDO/Common/0.1")]
public partial class ProductIdentifierType {
    
    private ProductIdentifierTypeEnum identifierTypeField;
    
    private string identifierValueField;
    
    private string disambiguationField;
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(Order=0)]
    public ProductIdentifierTypeEnum IdentifierType {
        get {
            return this.identifierTypeField;
        }
        set {
            this.identifierTypeField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(Order=1)]
    public string IdentifierValue {
        get {
            return this.identifierValueField;
        }
        set {
            this.identifierValueField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(Order=2)]
    public string Disambiguation {
        get {
            return this.disambiguationField;
        }
        set {
            this.disambiguationField = value;
        }
    }
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
[System.SerializableAttribute()]
[System.Xml.Serialization.XmlTypeAttribute(Namespace="urn://www.fsc.org.au/DDO/Common/0.1")]
public enum ProductIdentifierTypeEnum {
    
    /// <remarks/>
    ISIN,
    
    /// <remarks/>
    SPIN,
    
    /// <remarks/>
    APIR,
    
    /// <remarks/>
    ExchangeId,
    
    /// <remarks/>
    IssuerProvided,
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(Namespace="urn://www.fsc.org.au/DDO/TMD/0.1")]
public partial class TargetMarketDeterminationType {
    
    private ProductIdentifierType productPrimaryIdentifierField;
    
    private ProductIdentifierType[] productAlternativeIdentifersField;
    
    private string productNameField;
    
    private EntityIdentifierType issuerIdentifierField;
    
    private EntityIdentifierType[] issuerAlternativeIdentifiersField;
    
    private string productIssuerNameField;
    
    private System.DateTime dateApprovedField;
    
    private string tMDVersionField;
    
    private TMDStatusEnum tMDStatusField;
    
    private System.DateTime mandatoryReviewDateField;
    
    private ContactDetailsType contactDeailsField;
    
    private TMDCharacteristicsType tMDCharacteristicsField;
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(Order=0)]
    public ProductIdentifierType ProductPrimaryIdentifier {
        get {
            return this.productPrimaryIdentifierField;
        }
        set {
            this.productPrimaryIdentifierField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlArrayAttribute(Order=1)]
    [System.Xml.Serialization.XmlArrayItemAttribute("ProductId", Namespace="urn://www.fsc.org.au/DDO/Common/0.1", IsNullable=false)]
    public ProductIdentifierType[] ProductAlternativeIdentifers {
        get {
            return this.productAlternativeIdentifersField;
        }
        set {
            this.productAlternativeIdentifersField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(Order=2)]
    public string ProductName {
        get {
            return this.productNameField;
        }
        set {
            this.productNameField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(Order=3)]
    public EntityIdentifierType IssuerIdentifier {
        get {
            return this.issuerIdentifierField;
        }
        set {
            this.issuerIdentifierField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlArrayAttribute(Order=4)]
    [System.Xml.Serialization.XmlArrayItemAttribute("Identifier", Namespace="urn://www.fsc.org.au/DDO/Common/0.1", IsNullable=false)]
    public EntityIdentifierType[] IssuerAlternativeIdentifiers {
        get {
            return this.issuerAlternativeIdentifiersField;
        }
        set {
            this.issuerAlternativeIdentifiersField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(Order=5)]
    public string ProductIssuerName {
        get {
            return this.productIssuerNameField;
        }
        set {
            this.productIssuerNameField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(DataType="date", Order=6)]
    public System.DateTime DateApproved {
        get {
            return this.dateApprovedField;
        }
        set {
            this.dateApprovedField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(DataType="positiveInteger", Order=7)]
    public string TMDVersion {
        get {
            return this.tMDVersionField;
        }
        set {
            this.tMDVersionField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(Order=8)]
    public TMDStatusEnum TMDStatus {
        get {
            return this.tMDStatusField;
        }
        set {
            this.tMDStatusField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(DataType="date", Order=9)]
    public System.DateTime MandatoryReviewDate {
        get {
            return this.mandatoryReviewDateField;
        }
        set {
            this.mandatoryReviewDateField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(Order=10)]
    public ContactDetailsType ContactDeails {
        get {
            return this.contactDeailsField;
        }
        set {
            this.contactDeailsField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(Order=11)]
    public TMDCharacteristicsType TMDCharacteristics {
        get {
            return this.tMDCharacteristicsField;
        }
        set {
            this.tMDCharacteristicsField = value;
        }
    }
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
[System.SerializableAttribute()]
[System.Xml.Serialization.XmlTypeAttribute(Namespace="urn://www.fsc.org.au/DDO/Common/0.1")]
public enum TMDStatusEnum {
    
    /// <remarks/>
    Available,
    
    /// <remarks/>
    UnderReview,
    
    /// <remarks/>
    StopDistribution,
    
    /// <remarks/>
    Closed,
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(Namespace="urn://www.fsc.org.au/DDO/TMD/0.1")]
public partial class TMDReportBody {
    
    private TargetMarketDeterminationType[] tMDsField;
    
    /// <remarks/>
    [System.Xml.Serialization.XmlArrayAttribute(Order=0)]
    [System.Xml.Serialization.XmlArrayItemAttribute("TMD", IsNullable=false)]
    public TargetMarketDeterminationType[] TMDs {
        get {
            return this.tMDsField;
        }
        set {
            this.tMDsField = value;
        }
    }
}