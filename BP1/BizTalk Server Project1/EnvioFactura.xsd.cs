namespace BizTalk_Server_Project1 {
    using Microsoft.XLANGs.BaseTypes;
    
    
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.BizTalk.Schema.Compiler", "3.0.1.0")]
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    [SchemaType(SchemaTypeEnum.Document)]
    [Schema(@"http://BizTalk_Server_Project1.Schema2",@"Root")]
    [Microsoft.XLANGs.BaseTypes.PropertyAttribute(typeof(global::BizTalk_Server_Project1.FacturaId), XPath = @"/*[local-name()='Root' and namespace-uri()='http://BizTalk_Server_Project1.Schema2']/*[local-name()='FacturaId' and namespace-uri()='']", XsdType = @"int")]
    [System.SerializableAttribute()]
    [SchemaRoots(new string[] {@"Root"})]
    [Microsoft.XLANGs.BaseTypes.SchemaReference(@"BizTalk_Server_Project1.psFacturaID", typeof(global::BizTalk_Server_Project1.psFacturaID))]
    public sealed class Schema2 : Microsoft.XLANGs.BaseTypes.SchemaBase {
        
        [System.NonSerializedAttribute()]
        private static object _rawSchema;
        
        [System.NonSerializedAttribute()]
        private const string _strSchema = @"<?xml version=""1.0"" encoding=""utf-16""?>
<xs:schema xmlns=""http://BizTalk_Server_Project1.Schema2"" xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"" xmlns:ns0=""https://BizTalk_Server_Project1.psFacturaID"" targetNamespace=""http://BizTalk_Server_Project1.Schema2"" xmlns:xs=""http://www.w3.org/2001/XMLSchema"">
  <xs:annotation>
    <xs:appinfo>
      <b:imports>
        <b:namespace prefix=""ns0"" uri=""https://BizTalk_Server_Project1.psFacturaID"" location=""BizTalk_Server_Project1.psFacturaID"" />
      </b:imports>
    </xs:appinfo>
  </xs:annotation>
  <xs:element name=""Root"">
    <xs:annotation>
      <xs:appinfo>
        <b:properties>
          <b:property name=""ns0:FacturaId"" xpath=""/*[local-name()='Root' and namespace-uri()='http://BizTalk_Server_Project1.Schema2']/*[local-name()='FacturaId' and namespace-uri()='']"" />
        </b:properties>
      </xs:appinfo>
    </xs:annotation>
    <xs:complexType>
      <xs:sequence>
        <xs:element name=""FacturaId"" type=""xs:int"" />
        <xs:element name=""FullName"" type=""xs:string"" />
        <xs:element name=""TotalAmount"" type=""xs:int"" />
      </xs:sequence>
    </xs:complexType>
  </xs:element>
</xs:schema>";
        
        public Schema2() {
        }
        
        public override string XmlContent {
            get {
                return _strSchema;
            }
        }
        
        public override string[] RootNodes {
            get {
                string[] _RootElements = new string [1];
                _RootElements[0] = "Root";
                return _RootElements;
            }
        }
        
        protected override object RawSchema {
            get {
                return _rawSchema;
            }
            set {
                _rawSchema = value;
            }
        }
    }
}
